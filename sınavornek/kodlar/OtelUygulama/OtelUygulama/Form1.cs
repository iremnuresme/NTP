using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Musteri> musteriListesi= new List<Musteri>();
        Musteri secilen;
        private void Form1_Load(object sender, EventArgs e)
        {
            musteriListesi.Add(new Musteri("Tuğba Altun", new DateTime(2025, 3, 15), 1500));
            musteriListesi.Add(new Musteri("Sudenaz Buse", new DateTime(2025, 3, 18), 2500));
            musteriListesi.Add(new Musteri("Tuğba İpek", new DateTime(2025, 3, 19), 600));
            Listele();
        }

        private void Listele()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource=musteriListesi.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAdSoyadE.Text;
            DateTime giris=dtpGirisE.Value.Date;
            int ucret=Convert.ToInt32(txtGunlukUcretE.Text);

            musteriListesi.Add(new Musteri(ad, giris, ucret));
            Listele();

        }


        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuncellenecekVeriGetir();
        }

        private void GuncellenecekVeriGetir()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                secilen = (Musteri)dataGridView1.SelectedRows[0].DataBoundItem;
                txtAdSoyadG.Text = secilen.AdSoyad;
                dtpGirisG.Value = secilen.GirisTarihi;
                txtGunlukUcretG.Text = secilen.GunlukUcret.ToString();
                tabControl1.SelectedIndex = 2;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Seçili kayıt silinsin mi?","Kayıt Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                musteriListesi.Remove((Musteri)dataGridView1.CurrentRow.DataBoundItem);
                Listele();
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            secilen.AdSoyad = txtAdSoyadG.Text;
            secilen.GirisTarihi=dtpGirisG.Value;
            secilen.GunlukUcret = Convert.ToDouble(txtGunlukUcretG.Text);
            Listele();
            tabControl1.SelectedIndex = 0;
            MessageBox.Show("Bilgiler Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2) { //Güncelle tabpage seçiliyse

                GuncellenecekVeriGetir();

            }
        }

       
    }
}

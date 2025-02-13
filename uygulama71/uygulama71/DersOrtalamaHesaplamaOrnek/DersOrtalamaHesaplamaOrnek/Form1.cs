using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersOrtalamaHesaplamaOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ders> dersListesi=new List<Ders>();
        Ders secilenDers;

        private void Form1_Load(object sender, EventArgs e)
        {
            Ders d1 = new Ders("Nesne Tabanlı Programlama", 10, 70, 60, 80, 100);
            Ders d2 = new Ders("Robotik Kodlama", 3, 80, 90, 100, 100);
            Ders d3 = new Ders("Matematik", 5, 40, 50, 40, 50);

            dersListesi.Add(d1);
            dersListesi.Add(d2);
            dersListesi.Add(d3);
            Listele();
            btnEkle.Enabled = false;

        }

        private void Listele()
        {
            dgvDersler.DataSource = null;
            dgvDersler.DataSource=dersListesi.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad=txtDersAdi.Text;
            int saat=Convert.ToInt32(txtDersSaati.Text);
            double yazili1=Convert.ToDouble(txtYazili1.Text);
            double yazili2=Convert.ToDouble(txtYazili2.Text);
            double performans1=Convert.ToDouble(txtPerformans1.Text);
            double performans2 = Convert.ToDouble(txtPerformans2.Text);

            Ders ders=new Ders(ad, saat, yazili1, yazili2, performans1, performans2);
            dersListesi.Add((ders));
            Listele();
            btnEkle.Enabled = false;
        }

        private void Temizle()
        {
            txtDersAdi.Clear();
            txtDersSaati.Clear();
            txtYazili1.Clear();
            txtYazili2.Clear();
            txtPerformans1.Clear();
            txtPerformans2.Clear();
        }

        private void dgvDersler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnEkle.Enabled = true;
        }

        private void dgvDersler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count > 0)
            {
                secilenDers = (Ders)dgvDersler.SelectedRows[0].DataBoundItem;
            }
            txtDersAdi.Text = secilenDers.DersAdi;
            txtDersSaati.Text = secilenDers.DersSaati.ToString();
            txtYazili1.Text = secilenDers.Not1.ToString();
            txtYazili2.Text = secilenDers.Not2.ToString();
            txtPerformans1.Text = secilenDers.Performans1.ToString();
            txtPerformans2.Text = secilenDers.Performans2.ToString();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            lblDurum.Text = SonucYazdir();
        }

        private string SonucYazdir()
        {
            int kalinanDersSayisi = 0;
            int toplamDersSaati = 0;
            double agirlikliOrtalamaToplami=0;
            double agirlikliOrtalama=0;
            string belge = "";

            foreach(Ders d in dersListesi)
            {
                toplamDersSaati += d.DersSaati;
                agirlikliOrtalamaToplami += d.AgirlikliOrtalama;

                agirlikliOrtalama = Math.Round(agirlikliOrtalamaToplami / toplamDersSaati,2);
                
                if (d.Durum == "KALDI")
                {
                    kalinanDersSayisi++;
                }
            }

            if (kalinanDersSayisi == 0)
            {
                if(agirlikliOrtalama>=50 && agirlikliOrtalama < 70)
                {
                    belge = "Geçtiniz";
                }
                else if(agirlikliOrtalama>=70 && agirlikliOrtalama < 85)
                {
                    belge = "Teşekkür belgesi aldınız.";
                }
                else if(agirlikliOrtalama>=85 && agirlikliOrtalama <= 100)
                {
                    belge = "Takdir belgesi aldınız.";
                }
                else
                {
                    belge = "Hata!";
                }
            }
            else if (kalinanDersSayisi > 3)
            {
                belge = "Sınıfta kaldınız :(";
            }
            else
            {
                belge = "Sorumlu geçtiniz.";
            }


            string sonuc = $"Ağırlıklı ortalamanız: {agirlikliOrtalama}\nKaldığınız ders sayısı: {kalinanDersSayisi}" +
                $"\n{belge}";
            return sonuc;


        }
    }
}

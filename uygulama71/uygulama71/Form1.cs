using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama71
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<Ders> DersListesi = new List<Ders>();
        private void lblHesapla_Click(object sender, EventArgs e)
        {
            string ad=txtDersAdi.Text;
            int saat=Convert.ToInt32(txtDersSaati.Text);
            double not1=Convert.ToDouble(txtNot1.Text);
            double not2=Convert.ToDouble(txtNot2.Text);

            Ders ders = new Ders(ad, saat, not1, not2);
            DersListesi.Add(ders);

            dgvListe.DataSource = DersListesi.ToList();

        }
    }
}

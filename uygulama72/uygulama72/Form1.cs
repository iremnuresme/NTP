using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama72
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Ders> DersListesi = new List<Ders>();
        Ders secilenDers;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            string DersAdi = txtDersAdi.Text;
            int DersSaati = Convert.ToInt32(txtDersSaati.Text);
            double Not1 = Convert.ToDouble(txtnot1.Text);
            double Not2 = Convert.ToDouble(txtnot2.Text);
            double performans1 = Convert.ToDouble(txtperformans1.Text);
            double performans2 = Convert.ToDouble(txtperformans2.Text);

            Ders ders = new Ders(DersAdi, DersSaati, Not1, Not2, performans1, performans2);
            DersListesi.Add(ders);
            Listele();
            btnEkle.Enabled = false;

            dgvListe.DataSource = DersListesi.ToList();
        }

        private void Temizle()
        {
            txtDersAdi.Clear();
            txtDersSaati.Clear();
            txtnot1.Clear();
            txtnot2.Clear();
            txtperformans1.Clear();
            txtperformans2.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ders d1 = new Ders("NTP", 10, 70, 60, 80, 100);
            Ders d2 = new Ders("Robotik Kodlama", 3, 80, 90, 100, 100);
            Ders d3 = new Ders("Matematik", 5, 40, 50, 40, 50);

            DersListesi.Add(d1);
            DersListesi.Add(d2);
            DersListesi.Add(d3);

            Listele();

        }

        private void Listele()
        {
            dgvListe.DataSource = null;
            dgvListe.DataSource = DersListesi.ToList();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Temizle();
            btnEkle.Enabled = true;
        }

        private void dgvListe_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListe.SelectedRows.Count > 0)
            {
                secilenDers = (Ders)dgvListe.SelectedRows[0].DataBoundItem;
            }

            txtDersAdi.Text = secilenDers.DersAdi;
            txtDersSaati.Text = secilenDers.DersSaati.ToString();
            txtnot1.Text = secilenDers.Not1.ToString();
            txtnot2.Text = secilenDers.Not2.ToString();
            txtperformans1.Text = secilenDers.Performans1.ToString();
            txtperformans2.Text = secilenDers.Performans2.ToString();

        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            lblDurum.Text = SonucYazdir();
        }

        private string SonucYazdir()
        {
            int kalinanDersSayisi = 0;
            int toplamDersSaati = 0;
            double agirlikliOrtalamaToplami = 0;
            double agirlikliOrtalama = 0;
            string belge = "";

            foreach (Ders d in DersListesi)
            {
                toplamDersSaati += d.DersSaati;
                agirlikliOrtalamaToplami += d.AgirlikliOrtalama;

                agirlikliOrtalama = Math.Round(agirlikliOrtalamaToplami / toplamDersSaati, 2);

                if (d.Durum == "KALDI")
                {
                    kalinanDersSayisi++;
                }
            }

            if (kalinanDersSayisi == 0)
            {
                if (agirlikliOrtalama >= 50 && agirlikliOrtalama < 70)
                {
                    belge = "Geçtiniz";
                }
                else if (agirlikliOrtalama >= 70 && agirlikliOrtalama < 85)
                {
                    belge = "Teşekkür belgesi aldınız.";
                }
                else if (agirlikliOrtalama >= 85 && agirlikliOrtalama <= 100)
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agirlikiOrtalama
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
      


    

        private void btnTikla_Click(object sender, EventArgs e)
        {
            double toplamDers = 0;
            double toplamAgirlik = 0;
            double agirlikliOrtalama = 0;
            int basarisizDersSayisi = 0;

            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i++)
            {
                TextBox txtDers = (TextBox)flowLayoutPanel2.Controls[i];
                TextBox txtOrtalama = (TextBox)flowLayoutPanel3.Controls[i];

                double dersSaati = Convert.ToDouble(txtDers.Text);
                double dersOrt = Convert.ToDouble(txtOrtalama.Text);

                toplamAgirlik += dersSaati * dersOrt;
                toplamDers += dersSaati;

                if (dersOrt < 50)
                {
                    basarisizDersSayisi++;
                }
            }

            // Ağırlıklı Ortalama Hesaplama
            if (toplamDers > 0)
            {
                agirlikliOrtalama = toplamAgirlik / toplamDers;
            }

            // Durum Mesajını Belirleme
            if (basarisizDersSayisi == 0)
            {
                if (agirlikliOrtalama >= 85)
                {
                    lblDurum.Text = "Takdir Aldınız:)";
                }
                else if (agirlikliOrtalama >= 70 && agirlikliOrtalama < 85)
                {
                    lblDurum.Text = "Teşekkür Aldınız:)";
                }
                else
                {
                    lblDurum.Text = "Düz Geçtiniz:|";
                }
            }
            else if (basarisizDersSayisi == 3)
            {
                lblDurum.Text = "Sorumlu geçtiniz.";
            }
            else if (basarisizDersSayisi > 3)
            {
                lblDurum.Text = "Sınıfta Kaldınız.";
            }
            else
            {
                lblDurum.Text = $"{basarisizDersSayisi} adet başarısız dersiniz var.";
            }

            lblAgirlikliOrtalama.Text = "Ağırlıklı Ortalamanız: " + Math.Round(agirlikliOrtalama, 2);
        } 
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Takdir Teşekkür Hesaplama Programı";
            this.BackColor = Color.FromArgb(84, 160, 255);

            for (int i = 1; i <= 20; i++)
            {
                cmbDersSayiAdeti.Items.Add(i.ToString());
            }
        }

        private void cmbDersSayiAdeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            int adet = Convert.ToInt32(cmbDersSayiAdeti.Text);

            for (int i = 1; i <= adet; i++)
            {
                TextBox txt = new TextBox();
                flowLayoutPanel1.Controls.Add(txt);
                txt.Text = "Ders " + i.ToString();
                txt.Width = 200;
            }

            for (int i = 1; i <= adet; i++)
            {
                TextBox txt = new TextBox();
                //Label lbl = new Label();

                //flowLayoutPanel2.Controls.Add(lbl);
                flowLayoutPanel2.Controls.Add(txt);


                //lbl.Text = "Ders Saati";
                txt.Width = 200;
                //lbl.Width = 90;
            }
            for (int i = 1; i <= adet; i++)
            {
                TextBox txt = new TextBox();
                //Label lbl = new Label();

                //flowLayoutPanel3.Controls.Add(lbl);
                flowLayoutPanel3.Controls.Add(txt);


                //lbl.Text = "Ortalama";
                txt.Width = 200;
                //lbl.Width = 90;
            }

        }
    }
}



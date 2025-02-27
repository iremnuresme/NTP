using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgirlikliOrtalamaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Takdir Teşekkür Hesaplama Programı";
            this.BackColor = Color.FromArgb(84, 160, 255);

            for(int i = 1; i <= 20; i++)
            {
                cmbDersSayi.Items.Add(i.ToString());
            }

        }

        private void cmbDersSayi_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            int adet = Convert.ToInt32(cmbDersSayi.Text);

            for(int i=1;i<=adet;i++)
            {
                TextBox txt=new TextBox();
                flowLayoutPanel1.Controls.Add(txt);
                txt.Text = "Ders "+i.ToString();
                txt.Width = 200;
            }

            for (int i = 1; i <= adet; i++)
            {
                TextBox txt = new TextBox();
                Label lbl = new Label();

                flowLayoutPanel2.Controls.Add(lbl);
                flowLayoutPanel2.Controls.Add(txt);
                

                lbl.Text = "Ders Saati";
                txt.Width = 100;
                lbl.Width = 90;
            }
            for (int i = 1; i <= adet; i++)
            {
                TextBox txt = new TextBox();
                Label lbl = new Label();

                flowLayoutPanel3.Controls.Add(lbl);
                flowLayoutPanel3.Controls.Add(txt);


                lbl.Text = "Ortalama";
                txt.Width = 100;
                lbl.Width = 90;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

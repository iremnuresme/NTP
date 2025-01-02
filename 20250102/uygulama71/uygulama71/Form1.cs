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

        private void button1_Click(object sender, EventArgs e)
        {
            int kk ,uk;
            kk =Convert.ToInt32(textBox1.Text);
            uk=Convert.ToInt32(textBox2.Text);

            Dikdortgen dd = new Dikdortgen(kk, uk);

            label3.Text = "Alan :" + dd.AlanHesapla();
            label4.Text = "Çevre :" + dd.CevreHesapla();



        }
    }
}

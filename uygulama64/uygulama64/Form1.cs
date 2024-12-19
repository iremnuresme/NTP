using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime hedefZaman = new DateTime(2500, 1, 1, 16, 05, 0);

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text=hedefZaman.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            TimeSpan fark = hedefZaman - simdi;
            if (fark.Hours == 0 && fark.Minutes == 0 && fark.Seconds == 0)
            {
                this.BackColor = Color.Red;
                timer1.Stop();
            }
            label1.Text = simdi.ToLongTimeString();
        }
    }
}

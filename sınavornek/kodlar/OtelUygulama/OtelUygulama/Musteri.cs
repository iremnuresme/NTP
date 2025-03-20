using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulama
{
    internal class Musteri
    {
        string adSoyad;
        DateTime girisTarihi;
        double gunlukUcret;
        int kaldigiGunSayisi;
        double odenecekTutar;

        public Musteri()
        {

        }

        public Musteri(string adSoyad, DateTime girisTarihi, double gunlukUcret)
        {
            AdSoyad = adSoyad;
            GirisTarihi = girisTarihi;
            GunlukUcret = gunlukUcret;
        }

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public DateTime GirisTarihi { get => girisTarihi; set => girisTarihi = value; }
        public double GunlukUcret { get => gunlukUcret; set => gunlukUcret = value; }
        public int KaldigiGunSayisi { get => GunHesapla();  }
        public double OdenecekTutar { get => OdenecekTutarHesapla(); }




        private int GunHesapla()
        {
            TimeSpan fark = DateTime.Today - GirisTarihi;
            return fark.Days;
        }

        

        private double OdenecekTutarHesapla()
        {
            return KaldigiGunSayisi * GunlukUcret;
        }
    }
}

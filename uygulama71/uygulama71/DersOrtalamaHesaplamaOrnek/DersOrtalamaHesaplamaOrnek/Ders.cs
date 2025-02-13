using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersOrtalamaHesaplamaOrnek
{
    internal class Ders
    {
        string dersAdi;
        int dersSaati;
        double not1;
        double not2;
        double performans1;
        double performans2;
        double ortalama;
        double agirlikliOrtalama;
        string durum;

        public string DersAdi { get => dersAdi; set => dersAdi = value; }
        public int DersSaati { get => dersSaati; set => dersSaati = value; }
        public double Not1 { get => not1; set => not1 = value; }
        public double Not2 { get => not2; set => not2 = value; }
        public double Performans1 { get => performans1; set => performans1 = value; }
        public double Performans2 { get => performans2; set => performans2 = value; }
        public double Ortalama { get => OrtalamaHesapla(); }
        public double AgirlikliOrtalama { get => AgirlikliOrtalamaHesapla(); }
        public string Durum { get => DurumHesapla(); }

        public Ders(string dersAdi, int dersSaati, double not1, double not2, double performans1, double performans2)
        {
            DersAdi = dersAdi;
            DersSaati = dersSaati;
            Not1 = not1;
            Not2 = not2;
            Performans1 = performans1;
            Performans2 = performans2;
        }

        public double OrtalamaHesapla()
        {
            return (Not1+Not2+Performans1+Performans2)/4.0;
        }
        public double AgirlikliOrtalamaHesapla()
        {
            return Ortalama * DersSaati;
        }
        public string DurumHesapla()
        {
            string s= "GEÇTİ";
            if (Ortalama < 50)
            {
                s = "KALDI";
            }
            return s;
        }

    }
}

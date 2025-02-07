using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace uygulama71
{
    internal class Ders
    { 
        string dersAdi;
        int dersSaati;
        double not1;
        double not2;
        double ortalama;
        string durum;
     
        public string DersAdi { get => dersAdi; set => dersAdi = value; }
        public int DersSaati { get => dersSaati; set => dersSaati = value; }
        public double Not1 { get => not1; set => not1 = value; }
        public double Not2 { get => not2; set => not2 = value; }
        public double Ortalama { get => OrtalamaHesapla(); }
        public string Durum1 { get => DurumBul(); }

        public Ders(string dersAdi, int dersSaati, double not1, double not2)
        {
            DersAdi = dersAdi;
            DersSaati = dersSaati;
            Not1 = not1;
            Not2 = not2;
        }

        public double OrtalamaHesapla()
        {
            return Math.Round((Not1 + Not2) / 2);

        }

        public string DurumBul()
        {
            string durum = "GEÇTİ";
            if (OrtalamaHesapla() < 50)
            {
                durum = "KALDI";
            }
            return durum;
            
        }
    }
}

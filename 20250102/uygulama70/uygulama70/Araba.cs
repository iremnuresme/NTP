using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama70
{
    internal class Araba
    {
        string marka;
        string Model;
        string yakitTuru;
        decimal fiyat;

        public string Marka { get => marka; set => marka = value; }
        public string Model1 { get => Model; set => Model = value; }
        public string YakitTuru { get => yakitTuru; set => yakitTuru = value; }
        public decimal Fiyat { get => fiyat; set => fiyat = value; }

        public Araba(string marka, string model1, string yakitTuru, decimal fiyat)
        {
            Marka = marka;
            Model1 = model1;
            YakitTuru = yakitTuru;
            Fiyat = fiyat;


        }
        public string BilgileriYazdir()
        {
            string s = $"Marka; {marka}\nModel: {Model}\nYakıt Türü: {yakitTuru}\nListe Fiyatı: {fiyat}\n ";
            return s ;
        }
        public decimal IndirimYap (int oran)
        {
            decimal indirimliFiyat = fiyat - (fiyat * oran / 100);
            return indirimliFiyat;
        }
        public decimal FiyatArttir(int oran)
        {
            decimal zamliFiyat = fiyat + (fiyat * oran / 100);
            return zamliFiyat; 
        }
    }
    
}

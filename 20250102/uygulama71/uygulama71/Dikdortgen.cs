using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama71
{
    internal class Dikdortgen
    {
        int kisa;
        int uzun;

        public int Kisa { get => kisa; set => kisa = value; }
        public int Uzun { get => uzun; set => uzun = value; }

        public Dikdortgen(int kisa, int uzun)
        {
            Kisa = kisa;
            Uzun = uzun;
        }
        public int AlanHesapla()
        {
            return kisa * uzun;
        }
        public int CevreHesapla()
        {
            return 2 * (kisa + uzun);
        }
    }
}

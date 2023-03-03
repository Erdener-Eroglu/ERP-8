using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib
{
    public static class Hesapla
    {
        public static void StoktanDus(Urun urun, int dusulecekMiktar)
        {
            urun.Stok -= dusulecekMiktar;
        }

        public static void StokEkle(Urun urun, int eklenecekMiktar)
        {
            urun.Stok += eklenecekMiktar;
        }

        public static void IndirimHesapla(Urun urun, int indirimYuzdesi)
        {
            double indirimMiktarı = (urun.Fiyat * indirimYuzdesi) / 100;
            urun.Fiyat -= indirimMiktarı;
        }
    }
}

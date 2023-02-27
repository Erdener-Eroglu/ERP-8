using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayininOkunusuForm
{
    internal class SayiOkunus
    {
        int _girilenSayi = 0;


        public int GirilenSayi
        {
            get => _girilenSayi;
            set
            {
                if (value < 0 || value > 9999999)
                    throw new Exception("0-9999999 arasında bir sayı giriniz.");
                _girilenSayi = value;
            }
        }


        public string OkunusuAl()
        {
            if (_girilenSayi == 0)
                return "Sıfır";
            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] yuzler = { "", "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };
            string[] binler = { "", "Bin", "İkiBin", "ÜçBin", "DörtBin", "BeşBin", "AltıBin", "YediBin", "SekizBin", "DokuzBin" };
            string[] milyonlar = { "", "BirMilyon", "İkiMilyon", "ÜçMilyon", "DörtMilyon", "BeşMilyon", "AltıMilyon", "YediMilyon", "SekizMilyon", "DokuzMilyon" };
            int basamak1 = _girilenSayi % 10;
            int basamak10 = _girilenSayi / 10 % 10;
            int basamak100 = _girilenSayi / 100 % 10;
            int basamak1000 = _girilenSayi / 1000 % 10;
            int basamak10000 = _girilenSayi / 10000 % 10;
            int basamak100000 = _girilenSayi / 100000 % 10;
            int basamak1000000 = _girilenSayi / 1000000 % 10;
            string okunus = $"{milyonlar[basamak1000000]}{yuzler[basamak100000]}{onlar[basamak10000]}{binler[basamak1000]}{yuzler[basamak100]}{onlar[basamak10]}{birler[basamak1]}";
            return okunus;
        }
    }
}

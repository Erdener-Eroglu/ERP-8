using InterfaceOrnek_Odeme.AbstractEntities;
using InterfaceOrnek_Odeme.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek_Odeme.Entities
{
    internal class KrediKartiylaOdeme : Odeme, IOdemeAlabilir
    {
        private string _kartSahibi;
        public string KartSahibi
        {
            get
            {
                return _kartSahibi;
            }
            set
            {
                bool hepsiHarfMi = true;
                if(value.Length < 5)
                {
                    throw new Exception("Lütfen bilgilerinizi geçerli giriniz");
                }
                foreach(var item in value) 
                {
                    if(!char.IsWhiteSpace(item) && !char.IsLetter(item))
                    {
                        hepsiHarfMi = false; 
                        break;
                    }
                }
                if(!hepsiHarfMi) 
                {
                    throw new Exception("Geçerli bilgi giriniz");
                }
                else
                {
                    _kartSahibi = value;
                }

            }
        }
        private string _kartNumarasi;
        public string KartNumarasi
        {
            get
            {
                return _kartNumarasi;
            }
            set
            {
                bool kuraliBozanVarMi = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (i == 4 || i == 9 || i == 14)
                    {
                        if (!char.IsWhiteSpace(value[i]))
                        {
                            kuraliBozanVarMi = true;
                            break;
                        }
                    }
                    if (!char.IsDigit(value[i]))
                    {
                        kuraliBozanVarMi = true;
                        break;
                    }
                }

                if (value.Length != 19)
                {
                    throw new Exception("Kart numarası 16 haneli olmak zorundadır");
                }
                else if (kuraliBozanVarMi)
                {
                    throw new Exception("Kart numarası sadece rakamlardan oluşmalıdır!");
                }
                else
                {
                    _kartNumarasi = value;
                }
            }
        }
        public byte SonKullanimAy { get; set; }
        private byte _sonKullanimYil;
        public byte SonKullnaimYil
        {
            get
            {
                return _sonKullanimYil;
            }
            set
            {
                if (value > 22)
                {
                    _sonKullanimYil = value;
                }
                else
                {
                    throw new Exception("Son kullanım yılını iki haneli olacak şekilde girmeniz gerekmektedir.");
                }
            }
        }
        public int CVC { get; set; }
        public decimal OdenecekTutar { get; set; }
        public string OdemeYap()
        {
            OdemeTarihi = DateTime.Now;
            return $"Kartınızdan odeme alınmıştır....";
        }
    }
}

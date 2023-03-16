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
        public string KartSahibi { get; set; }
        public string KartNumarasi { get; set; }
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
                if(value > 22)
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

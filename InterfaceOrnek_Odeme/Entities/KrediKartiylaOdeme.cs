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
        public byte SonKullnaimYil { get; set; }
        public int CVC { get; set; }
        public decimal OdenecekTutar { get; set; }
        public string OdemeYap()
        {
            OdemeTarihi = DateTime.Now;
            return $"Kartınızdan odeme alınmıştır....";
        }
    }
}

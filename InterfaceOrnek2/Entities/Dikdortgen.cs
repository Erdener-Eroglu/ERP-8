using InterfaceOrnek2.AbstractEntities;
using InterfaceOrnek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek2.Entities
{
    internal class Dikdortgen : Sekil, IAlanaSahiptir, ICevreyeSahiptir, IKosegenli
    {
        #region Properties
        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }
        #endregion
        public double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        }

        public double CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }

        public double KosegenHesapla()
        {
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarTahminForm
{
    internal class GirilenZarDegeri
    {
        private int _girilenZar;

        public int GirilenZar
        {
            get => _girilenZar;
            set
            {
                if (value < 0 || value > 6)
                {
                    throw new Exception("Lütfen 1-6 arasında değer giriniz.");
                }
                _girilenZar = value;
            }
        }
    }
}

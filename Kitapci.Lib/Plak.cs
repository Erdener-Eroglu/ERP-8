using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib;

public class Plak : Urun
{
    public Plak(double fiyat, int stok, string urunAdi) : base(fiyat, stok, urunAdi)
    {

    }
    public string sarkiciAdi { get; set; }
    public string sarkiciSoyadi { get; set; }
}

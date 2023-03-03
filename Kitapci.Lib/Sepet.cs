using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib;

public class Sepet
{
    List<Urun> _urunler = new List<Urun>();
    double _toplamFiyat = 0;

    public double ToplamFiyat { get => _toplamFiyat;}
    public List<Urun> SepettekiUrunler { get => _urunler;}

    public void SepeteUrunEkle(params Urun[] uruns)
    {
        foreach (var item in uruns)
        {
            _urunler.Add(item);
        }
    }

    public  void SepettekiUrunleriTopla()
    { 
        foreach (var item in _urunler)
        {
            _toplamFiyat += item.Fiyat;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitapci.Lib;

public class Urun
{
    private double _fiyat;
    private int _stok;
    public string _urunAdi;

    public Urun(double fiyat, int stok, string urunAdi)
    {
        _fiyat = fiyat;
        _stok = stok;
        _urunAdi = urunAdi;
    }
    public int Stok
    {
        get => _stok;
        set
        {
            if (value < 0)
                throw new Exception("Stok sıfırdan az olamaz");
            _stok = value;
        }
    }

    public double Fiyat
    {
        get => _fiyat;
        set
        {
            if (value <= 0)
                throw new Exception("Fiyat 0 dan büyük olmak zorunda");
            _fiyat = value;
        }
    }
    public string UrunAdi
    {
        get => _urunAdi;
        set
        {
            if (_urunAdi == null || _urunAdi.Length < 2)
                throw new Exception("Urun adı en az 1 karakter olmak zorundadır.");
            _urunAdi = value;
        }
    }


}

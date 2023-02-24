using System.Net.Mail;
using System.Text.RegularExpressions;

namespace OopGiris;

public class Kisi
{
    //ad, soyad, doğum tarihi, tckn,telefon,e-mail, yas özellikleri
    //Ad ve soyad da özel karakter ve sayı olmamalı. Okuunurken ilk harfi büyük sonraki harfler küçük gösterilmeli
    //tckn 11 hanneli olmalı sadece rakamlardan oluşmalı
    //telefon 10 haneli olmalı ve sadece rakamlardan oluşmalı
    //e-mail adresi @ işaretinden sonra en az 2 karakter olmalı ve email kurallarına uygun olmalı
    //yas özelliği sadece okunur olmalı

    private string _ad;
    private string _soyad;
    private string _tckn;
    private string _eMail;
    private string _telefon;

    public Kisi(string ad, string soyad, string tckn, string mail, string telefon, DateTime dogumTarihi)
    {
        Ad = ad;
        Soyad = soyad;
        Tckn = tckn;
        EMail = mail;
        Telefon = telefon;
        DogumTarihi = dogumTarihi;
    }

    public string Ad
    {
        set
        {
            if (string.IsNullOrEmpty(value) || !HepsiHarfMi(value))
            {
                throw new Exception("İsim, sayı veya özel karakter içeremez.");
            }
            _ad = value;
        }
        get => IlkHarfiBuyukYap(_ad);
    }
    public string Soyad
    {
        set
        {
            if (string.IsNullOrEmpty(value) || !HepsiHarfMi(value))
            {
                throw new Exception("Soyisim, sayı veya özel karakter içeremez.");
            }
            _soyad = value;
        }
        get =>  _soyad.ToUpper();
    }

    public string Tckn
    {
        set
        {
            if (string.IsNullOrEmpty(value) || !HepsiRakamMı(value) || value.Length != 11)
            {
                throw new Exception("TCKN 11 haneli olmalı ve rakamlardan oluşmalı");
            }
            _tckn = value;
        }
        get => _tckn;
    }
    public string Telefon
    {
        set
        {
            if (string.IsNullOrEmpty(value) || !HepsiRakamMı(value) || value.Length != 10)
            {
                throw new Exception("Telefon no 10 haneli olmalı ve rakamlardan oluşmalı");
            }
            _telefon = value;
        }
        get => _telefon;
    }
    public string EMail
    {
        set
        {
            string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
            if(!Regex.IsMatch(value,emailRegex,RegexOptions.IgnoreCase))
            {
                throw new Exception("Doğru bir email adresi giremediniz.");
            }
            _eMail = value;

        }
        get => _eMail;
    }


    public DateTime DogumTarihi { get; set; }

    public int Yas
    {
        get => DateTime.Now.Year - this.DogumTarihi.Year;
    }

    private string IlkHarfiBuyukYap(string girdi)
    {
        if (girdi.Length == 1)
            return girdi.ToUpper();
        else
            return char.ToUpper(girdi[0]) + girdi.Substring(1).ToLower();
    }
    private bool HepsiHarfMi(string girdi)
    {
        foreach (char item in girdi)
        {
            if (!char.IsLetter(item))
            {
                return false;
            }
        }
        return true;
    }

    private bool HepsiRakamMı(string girdi)
    {
        foreach (char item in girdi)
        {
            if (!char.IsDigit(item))
            {
                return false;
            }
        }
        return true;
    }

    public void KisiyiEkranaYaz(Kisi kisi)
    {
        Console.WriteLine("AD: " + kisi.Ad);
        Console.WriteLine("SOYAD: " + kisi.Soyad);
        Console.WriteLine("TCKN: " + kisi.Tckn);
        Console.WriteLine("EMAIL: " + kisi.EMail);
        Console.WriteLine("TELEFON: " + kisi.Telefon);
        Console.WriteLine("YAS: " + kisi.Yas);
    }
}

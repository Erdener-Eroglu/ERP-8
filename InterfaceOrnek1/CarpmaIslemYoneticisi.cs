namespace InterfaceOrnek1;

internal class CarpmaIslemYoneticisi :Islem, IislemYap
{
    public CarpmaIslemYoneticisi()
    {
        IslemTuru = IslemTurleri.Carpma;
    }


    public void IslemSonucunuYazdir()
    {
        Console.WriteLine("30 ile 20'yi çarptım sonucu = " + 600);
    }
}

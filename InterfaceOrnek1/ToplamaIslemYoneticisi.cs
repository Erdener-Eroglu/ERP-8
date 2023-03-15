namespace InterfaceOrnek1;

internal class ToplamaIslemYoneticisi : Islem, IislemYap
{
    public ToplamaIslemYoneticisi()
    {
        IslemTuru = IslemTurleri.Toplama;
    }

    public void IslemSonucunuYazdir()
    {
        Console.Write("1.Sayi Gir: ");
        int s1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("2.Sayi Gir: ");
        int s2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sonuç: {s1 + s2}");
    }
}

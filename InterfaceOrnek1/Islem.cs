namespace InterfaceOrnek1;

internal abstract class Islem : IislemIzmiYazdirir
{
    public IslemTurleri IslemTuru { get; set; }

    public void IslemIsmiYazdir()
    {
        Console.WriteLine($"{IslemTuru} ----> {(byte)IslemTuru}");
    }
}

enum IslemTurleri:byte
{
    Toplama,
    Cikarma,
    Carpma
}

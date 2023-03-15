using InterfaceOrnek1;
//ToplamaIslemYoneticisi toplamaYoneticisi = new ToplamaIslemYoneticisi();
//IislemIzmiYazdirir islemim = toplamaYoneticisi;
//IislemIzmiYazdirir islemim2 = new ToplamaIslemYoneticisi();
//interface new ile instance alınamaz! ama interfaceden kalıtım alan class
// newlenerek interface tipte bir değişkene sahip olabiliriz.
//IislemIzmiYazdirir[] islemler = new IislemIzmiYazdirir[]
//{
//    toplamaYoneticisi
//};
//List<IislemIzmiYazdirir> islemlerListesi = new List<IislemIzmiYazdirir>();
//islemlerListesi.Add(toplamaYoneticisi);

ToplamaIslemYoneticisi t = new ToplamaIslemYoneticisi();
CarpmaIslemYoneticisi c = new CarpmaIslemYoneticisi();

List<IislemIzmiYazdirir> islemler = new List<IislemIzmiYazdirir> { t, c };

foreach (var islem in islemler)
{
    islem.IslemIsmiYazdir();
}
Console.WriteLine("\n");
bool kontrol = int.TryParse(Console.ReadLine(), out int sectigiIslem);
if (!kontrol)
{
    Console.WriteLine("Lütfen geçerli seçim yapınız");
}

if(sectigiIslem == (int)IslemTurleri.Toplama)
{
    t.IslemSonucunuYazdir();
}
else if (sectigiIslem == (int)IslemTurleri.Carpma)
{
    c.IslemSonucunuYazdir();
}

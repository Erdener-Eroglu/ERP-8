int tahminSayisi = 0;
Random rnd = new Random();
int rastgeleSayi = rnd.Next(0, 100);
//Console.WriteLine(rastgeleSayi);
string giris = "";
int tahmin = -1;
while (tahmin != rastgeleSayi)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("0-100 arasında sayı tahmin ediniz: ");
    giris = Console.ReadLine();
    if (int.TryParse(giris, out tahmin))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        if (tahmin < 0 || tahmin > 100)
        {
            Console.WriteLine("Lütfen 0 ile 100 arasında bir değer giriniz.");
        }
        else if (tahmin > rastgeleSayi)
            Console.WriteLine("Aşağı");
        else if (tahmin < rastgeleSayi)
            Console.WriteLine("Yukarı");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("0-100 arasında sayı girişi yapınız.");
    }
    tahminSayisi++;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Tebrikler {tahminSayisi}. tahminde buldunuz.");


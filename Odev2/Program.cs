Random rnd = new Random();
int ciftGelmesiIstenilenSayi = 0;
bool sayiDogruMu = true;
Console.Write("Çift gelmesiniz istediğiniz zarı giriniz(1-6): ");
try
{
    ciftGelmesiIstenilenSayi = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Lütfen 1-6 arasında bir rakam giriniz");
    sayiDogruMu = false;
}
if (sayiDogruMu && (ciftGelmesiIstenilenSayi < 1 || ciftGelmesiIstenilenSayi > 6))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Girdiğiniz sayı 1-6 arasında olmalıdır.");
    sayiDogruMu = false;
}
int sayac = 0;
while (sayiDogruMu)
{
    sayac++;
    int zar1 = rnd.Next(1, 7);
    int zar2 = rnd.Next(1, 7);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{sayac}.Deneme -> Zar1: {zar1} - Zar2: {zar2}");
    if (zar1 == ciftGelmesiIstenilenSayi && zar2 == ciftGelmesiIstenilenSayi)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{sayac}.Denmede çift gelmiştir.");
        break;
    }

}
Console.WriteLine("Uygulama sonlandı...");
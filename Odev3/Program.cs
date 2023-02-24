Console.Write("Okunuşunu istediğini sayiyi giriniz(0-9999): ");
string giris = Console.ReadLine();
int girilenSayi = 0;
bool sayiDogruMu = true;
if (int.TryParse(giris, out girilenSayi))
{
    if (girilenSayi < 0 || girilenSayi > 9999)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Lütfen 0-9999 arasında bir değer giriniz");
        sayiDogruMu = false;
    }
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Lütfen 0-9999 arasında sayısal bir değer giriniz.");
    sayiDogruMu = false;
}
string[] rakamlar = new[] { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
string[] onlar = new[] { "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
int basamakSayacı = 0;
string sayininOkunuşu = "";
while (sayiDogruMu)
{
    int basamaktakiSayi = girilenSayi % 10;
    basamakSayacı++;
    int durumlar = basamakSayacı;
    if (basamaktakiSayi != 0)
        switch (durumlar)
        {
            case 1:
                sayininOkunuşu = rakamlar[basamaktakiSayi];
                break;
            case 2:
                sayininOkunuşu = sayininOkunuşu.Insert(0, onlar[basamaktakiSayi - 1] + " ");
                break;
            case 3:
                if (basamaktakiSayi == 1)
                {
                    sayininOkunuşu = sayininOkunuşu.Insert(0, "yüz ");
                }
                else
                {
                    sayininOkunuşu = sayininOkunuşu.Insert(0, rakamlar[basamaktakiSayi] + " yüz ");
                }
                break;
            case 4:
                if (basamaktakiSayi == 1)
                {
                    sayininOkunuşu = sayininOkunuşu.Insert(0, "bin ");
                }
                else
                {
                    sayininOkunuşu = sayininOkunuşu.Insert(0, rakamlar[basamaktakiSayi] + " bin ");
                }
                break;
            default:
                break;
        }
    if (girilenSayi < 10)
    {
        if (girilenSayi == 0)
        {
            sayininOkunuşu = rakamlar[0];
        }
        break;
    }
    girilenSayi /= 10;

}
Console.ForegroundColor = ConsoleColor.Green;
if(sayiDogruMu)
    Console.WriteLine("Sayinin okunuşu: " + sayininOkunuşu);
Console.WriteLine("Uygulama kapandı...");
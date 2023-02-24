
string[] kelimeler = { "fabrikasyon", "labirent", "ebegümeci", "karnabahar", "haberleşmek", "yazılımcı", "çabalamak" };
int rnd = new Random().Next(0, kelimeler.Length);
string secilenKelime = kelimeler[rnd];
int maksPuan = secilenKelime.Length * 100;
int hak = 6;
Console.WriteLine(secilenKelime);
string tahmin;
char tahminHarf;
char[] ekranCiktisi = new char[secilenKelime.Length];
bool kelimeBulunduMu= false;
Console.WriteLine("\n\n");
for (int i = 0; i < secilenKelime.Length; i++)
{
    ekranCiktisi[i] = '-';
}

do
{
    Console.WriteLine("\n\n");
    Console.Write(ekranCiktisi);
    Console.Write("\nKelime ya da harf tahmini yapını: ");
    tahmin = Console.ReadLine();
    if (char.TryParse(tahmin, out tahminHarf))
    {
        if (secilenKelime.Contains(tahminHarf))
        {
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                if (tahminHarf == secilenKelime[i])
                {
                    ekranCiktisi[i] = tahminHarf;
                }
            }
        }
        else
        {
            hak--;
            maksPuan -= 100;
            Console.WriteLine($"Malesef harf tahmini kalan hakkınız {hak}");
        }
    }
    else
    {
        if(tahmin != secilenKelime)
        {
            hak--;
            maksPuan -= 100;
        }
        else
        {
            kelimeBulunduMu = true;
            break;
        }
    }
    for(int i = 0; i<secilenKelime.Length; i++)
    {
        if (secilenKelime[i] != ekranCiktisi[i])
        {
            kelimeBulunduMu = false; 
            break;
        }
        kelimeBulunduMu = true;
    }
    if(hak == 0)
    {
        break;
    }
} while (!kelimeBulunduMu);
if(kelimeBulunduMu)
{
    Console.WriteLine($"Tebrikler kelimeyi buldunuz\nPuanınız: {maksPuan}");
}
else
{
    Console.WriteLine($"Malesef kelimeyi bulamadınız\nKelime {secilenKelime}");
}

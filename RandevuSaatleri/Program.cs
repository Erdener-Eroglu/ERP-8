﻿for (int i = 9; i < 17; i++)
{
    if (i == 12)
        continue;
    for (int j = 0; j < 46; j += 15)
    {
        int saat = i;
        int dakika = j;
        if (j == 45)
        {
            saat += 1;
            dakika = 0;
        }
        else
        {
            dakika += 15;
        }
        Console.WriteLine($"{i:00}:{j:00} - {saat:00}:{dakika:00}");
    }
}

Console.ForegroundColor = ConsoleColor.Cyan;
for (int saat = 9; saat < 17; saat++)
{
    if (saat == 12)
        continue;
    for (int dakika = 0; dakika < 60; dakika += 15)
    {
        int sonrakiSaat = saat;
        int sonrakiDakika = dakika + 15;
        if (sonrakiDakika == 60)
        {
            sonrakiSaat++;
            sonrakiDakika = 0;
        }
        Console.WriteLine($"{saat:00}:{dakika:00} - {sonrakiSaat:00}:{sonrakiDakika:00}");
    }
}

Console.ForegroundColor = ConsoleColor.Yellow;
DateTime baslangic = new DateTime(2000, 1, 1, 9, 0, 0);
while (baslangic.Hour < 17)
{
    DateTime ikinci = baslangic.AddMinutes(15);
    Console.WriteLine($"{baslangic:HH:mm} - {ikinci:HH:mm}");
    baslangic = baslangic.AddMinutes(15);
    if (baslangic.Hour == 12)
        baslangic = baslangic.AddHours(1);
}

Console.ForegroundColor = ConsoleColor.Green;
DateTime baslangic2 = new DateTime(2000, 1, 1, 9, 0, 0);
for (;baslangic2.Hour < 17; baslangic2 = baslangic2.AddMinutes(15))
{
    if (baslangic2.Hour == 12)
        continue;
    DateTime ikinci = baslangic2.AddMinutes(15);
    Console.WriteLine($"{baslangic2:hh:mm} - {ikinci:hh:mm} {baslangic2:tt}");
}
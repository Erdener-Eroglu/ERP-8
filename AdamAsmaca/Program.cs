using System.Globalization;

char[,] cinAli = new char[60, 60];
int diziUzunlukX = cinAli.GetLength(0);
int diziUzunlukY = cinAli.GetLength(1);
int ortaNoktaX = diziUzunlukX / 2;
for (int i = 0; i < diziUzunlukY; i++)
{
    for (int j = 0; j < diziUzunlukX; j++)
    {
        cinAli[i, j] = ' ';
    }
}

int kafaYaricap = diziUzunlukX / 6;
int sayac1 = diziUzunlukX / 6;
for (int i = kafaYaricap; i >= -kafaYaricap; i -= 2)
{
    int sayac2 = ortaNoktaX - kafaYaricap;
    for (int j = -kafaYaricap; j <= kafaYaricap; j++)
    {
        int hesap = (int)Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
        if (hesap == kafaYaricap)
        {
            cinAli[sayac1, sayac2] = '.';
        }
        sayac2++;
    }
    sayac1++;
}
int kafaUzunluk = sayac1;
int govdeUzunluk = diziUzunlukX / 4;
for (int i = kafaUzunluk; i < kafaUzunluk + govdeUzunluk; i++)
{
    cinAli[i, ortaNoktaX] = '.';
}
int kolBaşlangıç = ortaNoktaX;
int kolUzunluk = diziUzunlukX / 6;
for (int i = kafaUzunluk -1; i < kafaUzunluk + kolUzunluk; i++)
{
    cinAli[i, kolBaşlangıç] = '.';
    kolBaşlangıç -= 1;
}
kolBaşlangıç = ortaNoktaX;
for (int i = kafaUzunluk-1; i < kafaUzunluk + kolUzunluk; i++)
{
    cinAli[i, kolBaşlangıç] = '.';
    kolBaşlangıç += 1;
}

int ayakBaşlangıç = ortaNoktaX;
int ayakUzunluk = diziUzunlukX / 6;
for (int i = govdeUzunluk + kafaUzunluk; i < govdeUzunluk + kafaUzunluk + ayakUzunluk; i++)
{
    cinAli[i, ayakBaşlangıç] = '.';
    ayakBaşlangıç -= 1;
}

ayakBaşlangıç = ortaNoktaX;
for (int i = govdeUzunluk + kafaUzunluk; i < govdeUzunluk + kafaUzunluk + ayakUzunluk; i++)
{
    cinAli[i, ayakBaşlangıç] = '.';
    ayakBaşlangıç += 1;
}

for (int i = 0; i < diziUzunlukX; i++)
{
    for (int j = 0; j < diziUzunlukY; j++)
    {
        Console.Write(cinAli[i, j]);
    }
    Console.WriteLine();
}

namespace DegiskenTanimlama;
using System.Threading;
internal class Program
{
    static void saat(int kacSaniye)
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        for (int i = 0; i < kacSaniye; i++)
        {
            Console.Clear();

            DateTime simdi = DateTime.Now;

            Console.WriteLine(simdi.Hour.ToString("00") + ":" + simdi.Minute.ToString("00") + ":" + simdi.Second.ToString("00"));
            Console.WriteLine(string.Format("{0:00}:{1:00}:{2:00}", simdi.Hour, simdi.Minute, simdi.Second));
            Console.WriteLine($"{simdi.Hour:00}:{simdi.Minute:00}:{simdi.Second:00}");
            Console.WriteLine($"{simdi:dd:MM:yyyy - HH:mm:ssk}");
            Thread.Sleep(1000);
        }
    }
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("Değişken Tanımlama");

        //Tamsayı değişken tipleri

        byte degiskenByte = 2;
        short degiskenShort = 5;
        ushort degiskenUShort = 3; //Negatif yok
        int degiskenInt = 0;
        uint degiskenUInt = 0;
        long degiskenLong = 0;
        ulong degiskenULong = 0L;

        //Ondalık değişken tipleri

        double degiskenDouble = 0.5d;
        float degiskenFloat = 0.5f;
        decimal degiskenDecimal = 0.5m;

        degiskenInt = 1_999_999;
        degiskenInt = 0b1010110;
        Console.WriteLine(degiskenInt);
        degiskenInt = 0x123af45;
        Console.WriteLine(degiskenInt);

        int sonuc = 9 / 3;
        sonuc = Convert.ToInt32(5 / 2d);
        sonuc = (int)(5 / 2d);
        Console.WriteLine(sonuc);

        //Aritmetik operatörler
        //+ - * / %

        int a = 5;
        int b = 10;
        //b++;
        a = ++b;
        Console.WriteLine(a);
        Console.WriteLine(b);
        a = a + 10;
        a += 10;
        a = a % 2;
        a %= 2;

        //Karakter tipleri
        char karakter = 'a';
        karakter = '\u006a';
        Console.WriteLine(karakter);
        string kelime = "Merhaba Dünya";
        char[] kelimeDizi = new[] { 'M', 'E', 'R' };
        char harf = kelime[1];
        Console.WriteLine(kelimeDizi[2]);
        Console.WriteLine(kelime[2]);

        //Mantıksal tip
        bool dogruMu = true;

        //Mantıksal operatörler
        // > < >= <= = != ! işlem && ||
        dogruMu = degiskenInt > degiskenDouble;
        Console.WriteLine(dogruMu);
        dogruMu = degiskenShort < degiskenInt && kelime.Length > 10;
        Console.WriteLine(dogruMu);
        bool tekMi = a % 2 == 1;
        Console.WriteLine("İşlemin sonucu: " + (5 + 6 + 9));
        Console.WriteLine(tekMi.ToString());
        Console.WriteLine(tekMi + "");
        Console.Clear();
        Console.WriteLine();
        saat(30);
        //escape sequance

        /*
         * \n newLine 
         * \t tab
         * \b backSpace
         * \\
         * @
         */

        kelime = "Bu hikayenin çok uzun bir kısmını \n\"Bu metin\" karşılamaktadır";
        string path = "c:\\new\\falan.txt";
        string path2 = @"c:\new\falan.txt";

        Console.WriteLine(kelime);



    }
}
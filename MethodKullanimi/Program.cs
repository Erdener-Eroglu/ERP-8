namespace MethodKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Kullanımı");

            /*geriDönüşTipi MethodAdı (parametreTipi parametre1, parametreTipi parametre2...)
             * {
             * return keywordu metoddan çıkış yapılmasını sağlar.
             * Eğer geri dönüş tipi void değilse o tipte bir değeri method içerisinde ereturn ile döndğrmelisin
             * }
             */
            int sonuc = Topla(2, 3);
            sonuc = Topla(Topla(2, 3), Topla(3, 4));
            sonuc = Topla(3, 2, 1);
            double sonuc2 = Topla(2.2, 3);
            int sayi = 3;
            KuvvetAl(ref sayi, 3);
            Console.WriteLine(sayi);
        }
        static int FaktoriyelHesapla(int sayi)
        {
            if (sayi == 1)
                return 1;
            else
                return sayi * FaktoriyelHesapla(sayi - 1);
        }
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
        static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }
        static double AlanHesapla(double yariCap, double pi = Math.PI)
        {
            return pi * yariCap * yariCap;
        }

        //ref'li parametreler çağırıldığı yerdeki parametre ile aynı adresi taşıdığından. Method içerisinde yapılan değişiklikler
        //çağırıldığı yerdeki parametreyi yansır.

        static void KuvvetAl(ref int sayi, int kuvvet)
        {
            sayi = (int)Math.Pow(sayi, kuvvet);
        }

        static bool TryParse(string sayi, out int sonuc)
        {
            try
            {
                sonuc = int.Parse(sayi);
                return true;
            }
            catch (Exception)
            {
                sonuc = 0;
                return false;
            }
        }
    }
}

//JOHN SHARP
//koleksiyon tiplerine bak
//medyum makale
//john montgomery
//devblogs.microsoft
//ilkay ilknur
//String methodlar replace join split substring 
//Math Metodlar
//DeltaTime methodlar

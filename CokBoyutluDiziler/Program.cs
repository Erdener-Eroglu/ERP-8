int[,] dizi = new int[2, 3];
int[,,] dizi2 = new int[3, 3, 3];
dizi[0, 0] = 1;
dizi[0, 1] = 2;
dizi[1, 0] = 3;
dizi[1, 1] = 4;
Random rnd = new();
for(int i =0;i<dizi.GetLength(0);i++)
{
    for(int j = 0; j < dizi.GetLength(1);j++)
    {
        dizi[i, j] = rnd.Next(100);
    }
}
Console.WriteLine();

//cin ali çiz
//adam asmaca oyunu soru dizisi oluştur içerisinde uzun kelimeler olsun. oyun başladığında rastgele kelime seçilecek oyunun maks puanı harf * 100
//ekrana harf sayısı kadar tre
//her yanlışta - %10
//hak = 6
//birde kelime tahmini olacak
//harf tahmini olacak.
//cin ali yavaşça oluşacak
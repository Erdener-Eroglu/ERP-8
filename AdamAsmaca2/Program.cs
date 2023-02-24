using AdamAsmaca2.Helpers;

ConsoleKey key;
do
{
    Console.Clear();
    GameHelper game = new GameHelper();
    do
    {
        Console.WriteLine(game.EkranıYaz());
        var sonuc = game.TahminYap(Console.ReadLine());
        if (!sonuc) Console.Beep(5100, 300);
    } while (game.OyunAktifMi());
    Console.WriteLine(game.EkranıYaz());

    if (game.HakKontrol() > 0)
    {
        Console.WriteLine(game.SeciliSoru);
        Console.WriteLine("Tebrikler Bildiniz");
        Console.WriteLine($"Puanınız: {game.PuanKontrol()}");
    }
    else
    {
        Console.WriteLine("Bilemediniz :(");
    }
    Console.Write("Tekrar oynamak için E tuşuna basınız: ");
    key = Console.ReadKey().Key;
} while (key == ConsoleKey.E);
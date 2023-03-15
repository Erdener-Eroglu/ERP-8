using InterfaceOrnek_Odeme.AbstractEntities;
using InterfaceOrnek_Odeme.Interfaces;

namespace InterfaceOrnek_Odeme.Entities;

internal class KapidaOdeme : Odeme, IOdemeAlabilir
{
    public bool PosMakinesiIstiyorMu { get; set; }
    public string OdemeAlanPersonel { get; set; } = "Erdener Eroğlu";
    public bool NakitMi { get; set; }
    public decimal NakitOdenenTutar { get; set; }
    public bool KrediKartiMi { get; set; }
    public decimal KrediKartiylaOdenenTutar { get; set; }
    public string AcikAdres { get; set; }
    public string OdemeYap()
    {
        return $"Bilgileriniz Kaydedildi..\nKapıda Ödemeniz {OdemeAlanPersonel} tarafından {OdemeTarihi.ToString("dd.MM.yy")} tarihinde yapılacaktır";
        //string mesaj = string.Empty;
        //KrediKartiMi = PosMakinesiIstiyorMu ? true : false;
        //mesaj = NakitOdenenTutar > 100 ? "zengin" : "fakirsin";
        //mesaj = KrediKartiMi ? "Ödemeyi kartla yapmışsın" : "kredi kartın yok mu hala";
        
    }
}

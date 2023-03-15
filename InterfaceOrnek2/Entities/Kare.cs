using InterfaceOrnek2.AbstractEntities;
using InterfaceOrnek2.Interfaces;

namespace InterfaceOrnek2.Entities;

internal class Kare : Sekil, IAlanaSahiptir, ICevreyeSahiptir, IKosegenli
{
    #region Properties
    public double Kenar { get; set; }
    #endregion
    public double AlanHesapla()
    {
        try
        {
        return Kenar * Kenar;

        }
        catch (Exception)
        {

            throw;
        }
    }

    public double CevreHesapla()
    {
        return 4* Kenar;
    }

    public double KosegenHesapla()
    {
        return 0;
    }
}

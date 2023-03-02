namespace Kalitim.Lib;

public class Kare : Sekil
{
    public Kare()
    {
        
    }
    public Kare(double x) : base(x)
    {

    }

    public override double CevreHesapla()
    {
        return 4 * X;
    }
}

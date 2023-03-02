namespace Kalitim.Lib;

public class DikUcgen : Dikdortgen
{
    public DikUcgen()
    {
        
    }
    public DikUcgen(double x, double y) : base(x, y)
    {
    }

    public override double AlanHesapla()
    {
        return base.AlanHesapla() / 2;
    }
    public override double CevreHesapla()
    {
        return (X + Y) + Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
    }
}

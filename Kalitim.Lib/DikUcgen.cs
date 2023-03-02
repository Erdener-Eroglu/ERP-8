namespace Kalitim.Lib;

public sealed class DikUcgen : Dikdortgen //DikUçgen sınıfndan daha fazla kalıtım vermek istemediğimiz için sealed kullandık.
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

//public class SuperUcgen : DikUcgen Dikucgen sınıfı sealed olduğu için kalıtım alınmaz.
//{

//}

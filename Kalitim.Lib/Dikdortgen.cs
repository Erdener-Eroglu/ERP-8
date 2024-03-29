﻿namespace Kalitim.Lib;

public class Dikdortgen : Sekil
{
    public Dikdortgen()
    {
        
    }
    public Dikdortgen(double x, double y) : base(x)
    {
        this.Y = y;
    }

    public double Y { get; set; }

    public override double AlanHesapla() => X * Y;

    public override double CevreHesapla()
    {
        return 2 * (X + Y);
    }
}

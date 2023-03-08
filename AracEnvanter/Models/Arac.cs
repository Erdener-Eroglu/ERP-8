using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracEnvanter.Models;
public abstract class BaseModel
{
    public Guid Id { get; set; } = new Guid();
    public DateTime CreatedTime { get; set; } = DateTime.Now;
}
public class Arac : BaseModel
{
    public Model Model { get; set; }
    public string Plaka { get; set; }
}
public class Marka : BaseModel
{
    public string Ad { get; set; }

    public byte[] Logo { get; set; }
    public List<Model> Modeller { get; set; } = new List<Model>();

}
public class Model : BaseModel
{
    public string Ad { get; set; }
    public KasaTipi KasaTipi { get; set; }
    public Marka Marka { get; set; }
    public List<Arac> Araclar { get; set; } = new List<Arac>();
}

public enum KasaTipi
{
    HatchBack,
    Sedan,
    StationWagon,
    Coupe,
    Convertible,
    SUV,
    Crossover,
    Van,
    Pickup,
    Minivan,
    Minibus,
    Limousine,
    Roadster,
    Targa
}

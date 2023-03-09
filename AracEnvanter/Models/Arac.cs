using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracEnvanter.Models;
public class Arac : BaseModel
{
    public Model Model { get; set; }
    public string Plaka { get; set; }
    public int Yil { get; set; }
    public byte[] Fotograf { get; set; }
    public VitesTipleri VitesTipi { get; set; }
    public YakitTipleri YakitTipi { get; set; }

    public override string ToString()
    {
        return $"{Model.Marka.Ad}-{Model.Ad}-{Plaka}";
    }

}

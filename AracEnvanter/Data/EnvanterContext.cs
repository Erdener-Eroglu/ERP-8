using AracEnvanter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracEnvanter.Data;

public class EnvanterContext
{
    public List<Marka> Markalar { get; set; } = new List<Marka>();
    public List<Model> Modeller { get; set; } = new List<Model>();
    public List<Arac> Araclar { get; set; } = new List<Arac>();
  
}

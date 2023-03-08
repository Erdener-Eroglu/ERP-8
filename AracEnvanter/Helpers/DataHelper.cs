using AracEnvanter.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracEnvanter.Helpers;

public class DataHelper
{
    private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AracData.json";
    public static void Save(EnvanterContext context)
    {
        if(File.Exists(Path))
        {
            File.Delete(Path);
        }
        FileStream fs = new(Path, FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(fs);
        sw.Write(JsonConvert.SerializeObject(context, new JsonSerializerSettings()
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            MaxDepth = 1
        }));
        
        fs.Close();
        fs.Dispose();
    }
    public static EnvanterContext Load()
    {
        FileStream fs = new(Path, FileMode.OpenOrCreate);
        StreamReader sr = new StreamReader(fs);
        string data  = sr.ReadToEnd();
        if(!string.IsNullOrEmpty(data)) 
        {
            fs.Close();
            fs.Dispose();
            return JsonConvert.DeserializeObject<EnvanterContext>(data);
        }
        fs.Close();
        fs.Dispose();
        return null;
    }
}

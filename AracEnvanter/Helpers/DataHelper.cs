﻿using AracEnvanter.Data;
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
        FileStream file = File.Open(Path, FileMode.Create);
        StreamWriter writer = new StreamWriter(file);
        writer.Write(JsonConvert.SerializeObject(context));
        writer.Close();
        writer.Dispose();
    }

    public static EnvanterContext Load()
    {
        FileStream dosya = File.Open(Path, FileMode.OpenOrCreate);
        StreamReader reader = new StreamReader(dosya);
        string data = reader.ReadToEnd();
        if (!string.IsNullOrEmpty(data))
        {
            reader.Close();
            reader.Dispose();
            return JsonConvert.DeserializeObject<EnvanterContext>(data);
        }
        reader.Close();
        reader.Dispose();
        return null;
    }
}

using Newtonsoft.Json;
using System;
using System.IO;

namespace HomeWork5
{
    class Program
    {  

        static void Main(string[] args)
        {
            
            string path = "info.json";
         
            var sr = new StreamReader(path);
          

            var shop = JsonConvert.DeserializeObject<Shop>(File.ReadAllText(path));

           // Shop shop2 = JsonSerializer.Deserialize<Shop>(File.ReadAllText(path));

           // File.WriteAllText(path, JsonConvert.SerializeObject(shop));

            Console.WriteLine(shop.Name);


           

          


        }
    }
}

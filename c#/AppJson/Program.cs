using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace AppJson
{

    public class Product
    {
        public string Name { get; set; }
        public DateTime ExpiryDate {get; set; }
        public decimal Price {get; set; }
        public string[] Sizes {get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lstProductos = new List<Product>{
                new Product{Name = "Apple", ExpiryDate = new DateTime(2008, 12, 28), Price = 3.99M, Sizes = new[] {"Small", "Medium", "Large"}},
                new Product{Name = "Nokia", ExpiryDate = new DateTime(2008,12,28), Price = 3.99M, Sizes = new[] {"Small", "Medium", "Large"}}
            };

            string json = JsonConvert.SerializeObject(lstProductos);
            string path = @"D:\UNAB\estructura_de_datos\JSONS\product.json";
            //File.WriteAllText(path, json);
            List<Product> lstProductosA = new List<Product>();
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                lstProductosA = JsonConvert.DeserializeObject<List<Product>>(jsond);
            }
            foreach (Product pro in lstProductosA)
            {
                Console.WriteLine(pro.Name);
                Console.WriteLine("tamaños");
                foreach (string sizesp in pro.Sizes)
                {
                    Console.WriteLine(sizesp);
                }
            }


        }
    }
}
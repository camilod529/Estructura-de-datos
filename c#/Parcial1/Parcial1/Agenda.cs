using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Parcial1
{
    class Agenda
    {
        string ClientId { get; set; }
        string ClientName { get; set; }
        string Email { get; set; }
        string ClothingCode { get; set; }
        string ClothingName { get; set; }
        string Category { get; set; }
        int QuantityToProduce { get; set; }
        double UnitCost { get; set; }
        int ProducedQuantity { get; set; }

        public Agenda() { }

        public Agenda(string ClientId, string ClientName, string Email, string ClothingCode, string ClothingName, string Category, int QuantityToProduce, double UnitCost, int ProducedQuantity)
        {
            this.ClientId = ClientId;
            this.ClientName = ClientName;
            this.Email = Email;
            this.ClothingCode = ClothingCode;
            this.ClothingName = ClothingName;
            this.Category = Category;
            this.QuantityToProduce = QuantityToProduce;
            this.UnitCost = UnitCost;
            this.ProducedQuantity = ProducedQuantity;
        }



        public void showAgendas(Dictionary<string, Agenda> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine("Numero de produccion: {0}", item.Key);
                Console.WriteLine("ClientID: " + item.Value.ClientId + " Nombre Cliente: "+ item.Value.ClientName + " Email: " + item.Value.Email + " Codigo prenda: " + item.Value.ClothingCode + " Nombre prenda: " 
                    + item.Value.ClothingName + " Categoria: " + item.Value.Category + " Cantidad a producir: " + item.Value.QuantityToProduce + " correo: " 
                    + item.Value.UnitCost + " Cantidad Porducida: " + item.Value.ProducedQuantity);
            }
        }



        public Dictionary<string, Agenda> loadData()
        {
            Dictionary<string, Agenda> dictionary = new Dictionary<string, Agenda>();
            string path = @"./jsons/Agenda.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, Agenda>>(jsond);
            }
            return dictionary;
        }

        public void makingAgendas(Dictionary<string, Agenda> dictionary, string keyd, Agenda data)
        {
            if (!dictionary.ContainsKey(keyd))
            {
                dictionary.Add(keyd, data);
                Console.WriteLine("Usuario creado");
                string json = JsonConvert.SerializeObject(dictionary);
                string path = @"./jsons/Agenda.json";
                File.WriteAllText(path, json);
                showAgendas(dictionary);

            }
            else
            {
                Console.WriteLine("Ya hay una agenda con ese Numero de produccion");
            }
        }
    }
}

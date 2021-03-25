using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Parcial1
{
    class Agenda
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string Email { get; set; }
        public string ClothingCode { get; set; }
        public string ClothingName { get; set; }
        public string Category { get; set; }
        public int QuantityToProduce { get; set; }
        public double UnitCost { get; set; }
        public int ProducedQuantity { get; set; }

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

        public void saveData(Dictionary<string, Agenda> dictionary)
        {
            try
            {
                string json = JsonConvert.SerializeObject(dictionary);
                string path = @"..\..\..\jsons\Agenda.json";
                File.WriteAllText(path, json);
            }
            catch(IOException e)
            {
                Console.WriteLine("Error..." + e.Message.ToString());
            }
        }
        public void makingAgendas(Dictionary<string, Agenda> dictionary, string keyd, Agenda data)
        {
            if (!dictionary.ContainsKey(keyd))
            {
                dictionary.Add(keyd, data);
                Console.WriteLine("Agenda creado");
                saveData(dictionary);
                showAgendas(dictionary);

            }
            else
            {
                Console.WriteLine("Ya hay una agenda con ese Numero de produccion");
            }
        }

        public Dictionary<string, Agenda> loadData()
        {
            Dictionary<string, Agenda> dictionary = new Dictionary<string, Agenda>();
            try
            {
                
                string path = @"..\..\..\jsons\Agenda.json";
                using (StreamReader jsonStream = File.OpenText(path))
                {
                    var jsond = jsonStream.ReadToEnd();
                    dictionary = JsonConvert.DeserializeObject<Dictionary<string, Agenda>>(jsond);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error {0}", e.Message.ToString());
            }
            return dictionary;
            
        }

        

        public void updateProducedQuantity(Dictionary<string, Agenda> dictionary, string keyd, int data)
        {
            if(dictionary.ContainsKey(keyd))
            {
                foreach(var item in dictionary)
                {
                    if(item.Key == keyd)
                    {
                        item.Value.ProducedQuantity = data;
                        Console.WriteLine("Cambios realizados");
                        showAgendas(dictionary);
                        saveData(dictionary);
                    }
                }
            }
            else
            {
                Console.WriteLine("Ese numero de produccion no existe");
            }
        }

        public void showCategory(Dictionary<string, Agenda> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine("categoria: {0}", item.Value.Category);
            }
        }

        public void searchByCategory(Dictionary<string, Agenda> dictionary, string category)
        {
            Console.WriteLine("Para la categoria " + category + " hay: ");
            foreach(var item in dictionary)
            {
                if(category == item.Value.Category)
                {
                    Console.WriteLine("Numero de produccion: {0}", item.Key);
                    Console.WriteLine("ClientID: " + item.Value.ClientId + " Nombre Cliente: " + item.Value.ClientName + " Email: " + item.Value.Email + " Codigo prenda: " + item.Value.ClothingCode + " Nombre prenda: "
                        + item.Value.ClothingName + " Categoria: " + item.Value.Category + " Cantidad a producir: " + item.Value.QuantityToProduce + " correo: "
                        + item.Value.UnitCost + " Cantidad Porducida: " + item.Value.ProducedQuantity);
                }
            }
        }

        public void printProductionCost(Dictionary<string, Agenda> dictionary)
        {
            foreach(var item in dictionary)
            {
                Console.WriteLine("Numero de produccion: {0}", item.Key);
                Console.WriteLine("Costo de produccion total: {0}", (item.Value.UnitCost * item.Value.QuantityToProduce));
            }
        }
        public void printProductionCostByCategory(Dictionary<string, Agenda> dictionary)
        {
            double Caballero = 0, Dama = 0, Niño = 0, Bebe = 0;
            foreach(var item in dictionary)
            {
                if(item.Value.Category == "Caballero")
                {
                    Caballero = Caballero + item.Value.UnitCost * item.Value.QuantityToProduce;
                }
                if (item.Value.Category == "Dama")
                {
                    Dama = Dama + item.Value.UnitCost * item.Value.QuantityToProduce;
                }
                if (item.Value.Category == "Niño")
                {
                    Niño = Niño + item.Value.UnitCost * item.Value.QuantityToProduce;
                }
                if (item.Value.Category == "Bebes")
                {
                    Bebe = Bebe + item.Value.UnitCost * item.Value.QuantityToProduce;
                }
            }

            Console.WriteLine("Caballero: {0} \nDama: {1} \nNiño: {2} \nBebe: {3}", Caballero, Dama, Niño, Bebe);
        }
        public void printAllProductionCost(Dictionary<string, Agenda> dictionary)
        {
            double s=0;
            foreach (var item in dictionary)
            {
                Console.WriteLine("Numero de produccion: {0}", item.Key);
                Console.WriteLine("Costo de produccion total: {0}", (item.Value.UnitCost * item.Value.QuantityToProduce));
                s = s + item.Value.UnitCost * item.Value.QuantityToProduce;
            }
            Console.WriteLine("Costo total de totas las producciones: " + s);
        }
    }
}

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace taller1
{
    class Clientextrayecto
    {   
        //atributos
        int idCliente;
        string idTrayecto;
        string fecha;
        
        //gets & sets
        public int IdCliente{get; set; }

        public string IdTrayecto{get; set; }

        public string Fecha{get; set; }

        //constructores
        public Clientextrayecto(){ }

        public Clientextrayecto(int idCliente, string idTrayecto, string fecha)
        {
            this.idCliente = idCliente;
            this.idTrayecto = idTrayecto;
            this.fecha = fecha;
        }

        //Persistencia de datos en json
        public void Guardar(List<Clientextrayecto> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\clientextrayecto.json";
            File.WriteAllText(path, json);
        }
    }
}
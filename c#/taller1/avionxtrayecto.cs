using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace taller1
{
    class Avionxtrayecto
    {   
        //atributos
        string numeroAvion;
        string numeroTrayecto;
        string fecha;

        
        //gets & sets
        public string NumeroAvion {get; set; }

        public string NumeroTrayecto {get; set; }

        public string Fecha {get; set; }

        //constructores
        public Avionxtrayecto(){ }

        public Avionxtrayecto(string numeroAvion, string numeroTrayecto, string fecha)
        {
            this.numeroAvion = numeroAvion;
            this.numeroTrayecto = numeroTrayecto;
            this.fecha = fecha;
        }
        

        //Persistencia de datos en json
        public void Guardar(List<Clientes> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\clientes.json";
            File.WriteAllText(path, json);
        }
    }
}
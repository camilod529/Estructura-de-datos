using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace taller1
{
    class Aviones
    {   
        //Creacion de atributos
        string numero;
        string tipo;
        int cupo;

        //gets & sets
        public string Numero{get; set; }
        public string Tipo{get; set; }
        public int Cupo{get; set; }

        //constructores
        public Aviones()
        { }

        public Aviones(string numero, string tipo, int cupo)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.cupo = cupo;
            
        }

        //Persistencia de datos json
        public void Guardar(List<Aviones> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\aviones.json";
            File.WriteAllText(path, json);
        }
    }
}
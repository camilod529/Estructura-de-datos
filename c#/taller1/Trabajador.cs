using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace taller1
{
    class Trabajadores
    {
        string numero;
        string nombre;
        string cargo;

        public string Numero{get; set; }
        public string Nombre{get; set; }
        public string Cargo{get; set; }

        public Trabajadores()
        { }

        public Trabajadores(string numero, string nombre, string cargo)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.cargo = cargo;
            
        }

        public void Guardar(List<Trabajadores> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\personal.json";
            File.WriteAllText(path, json);
        }
    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace taller1
{
    class Aviones
    {
        string numero;
        string tipo;
        int cupo;

        public string Numero{get; set; }
        public string Tipo{get; set; }
        public int Cupo{get; set; }

        public Aviones()
        { }

        public Aviones(string numero, string tipo, int cupo)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.cupo = cupo;
            
        }

        public void Guardar(List<Aviones> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\aviones.json";
            File.WriteAllText(path, json);
        }
    }
}
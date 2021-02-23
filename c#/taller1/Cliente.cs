using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace taller1
{
    class Clientes
    {
        int id;
        string nombre;
        string correo;
        int telefono;
        string ciudad;
        

        public int Id{get; set; }
        public string Nombre{get; set; }
        public string Correo{get; set; }
        public int Telefono{get; set; }
        public string Ciudad{get; set; }

        public Clientes()
        { }

        public Clientes(int id, string nombre, string correo, int telefono, string ciudad)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
            this.ciudad = ciudad;
            
        }

        public void Guardar(List<Clientes> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\clientes.json";
            File.WriteAllText(path, json);
        }
    }
}
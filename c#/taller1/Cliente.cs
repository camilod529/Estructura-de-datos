using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace taller1
{
    class Clientes
    {   
        //atributos
        string id;
        string nombre;
        string correo;
        int telefono;
        string ciudad;
        
        //gets & sets
        public string Id{get; set; }
        public string Nombre{get; set; }
        public string Correo{get; set; }
        public int Telefono{get; set; }
        public string Ciudad{get; set; }

        //constructores
        public Clientes()
        { }

        public Clientes(string id, string nombre, string correo, int telefono, string ciudad)
        {
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
            this.telefono = telefono;
            this.ciudad = ciudad;
            
        }

        //Persistencia de datos en json
        public void Guardar(List<Clientes> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\clientes.json";
            File.WriteAllText(path, json);
        }

        public void ListarClientes(List<Clientes> miLista)
        {
            foreach (Clientes cliente in miLista)
            {
                Console.WriteLine("ID: {0}",cliente.Id);
                Console.WriteLine("Nombre: {0}",cliente.Nombre);
                Console.WriteLine("email: {0}",cliente.Correo);
                Console.WriteLine("Ciudad: {0}",cliente.Ciudad);
                Console.WriteLine("Telefono: {0}",cliente.Telefono);
                Console.WriteLine("----------------------------------------------");
            }

            
        }

        public void BuscarClientexCiudad(List<Clientes> miLista, string ciudad)
        {
            IEnumerable<Clientes> clientQuery =
            from cliente in miLista
            where cliente.Ciudad.Contains(ciudad)
            select cliente;

            foreach (Clientes cliente in clientQuery)
            {
                Console.WriteLine("ID: {0}",cliente.Id);
                Console.WriteLine("Nombre: {0}",cliente.Nombre);
                Console.WriteLine("email: {0}",cliente.Correo);
                Console.WriteLine("Ciudad: {0}",cliente.Ciudad);
                Console.WriteLine("Edad: {0}",cliente.Telefono);
                Console.WriteLine("----------------------------------------------");
            }
            
        }
    }
}
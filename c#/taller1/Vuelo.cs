using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;


namespace taller1
{
    class Vuelos
    {   
        //Creacion de atributos
        string codigo;
        string trayecto;
        string origen;
        string destino;
        string horapartida;
        string horallegada;
        double valor;

        //gets & sets
        public string Codigo {get; set; }
        public string Trayecto {get; set; }
        public string Origen {get; set; }
        public string Destino {get; set; }
        public string Horapartida {get; set; }
        public string Horallegada {get; set; }
        public double Valor {get; set; }

        //Constructores
        public Vuelos()
        { }

        public Vuelos(string codigo, string trayecto, string origen, string destino, string horapartida, string horallegada, double valor)
        {
            this.codigo = codigo;
            this.trayecto = trayecto;
            this.origen = origen;
            this.destino = destino;
            this.horapartida = horapartida;
            this.horallegada = horallegada;
            this.valor = valor;
        }

        //Persistencia json
        public void Guardar(List<Vuelos> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\vuelo.json";
            File.WriteAllText(path, json);
        }

        public void BuscarVueloxdestino(List<Vuelos> miLista, string ciudad)
        {
            IEnumerable<Vuelos> vuelosQuery =
            from cliente in miLista
            where cliente.Destino.Contains(ciudad)
            select cliente;

            foreach (Vuelos vuelo in vuelosQuery)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Codigo: {0}",vuelo.Codigo);
                Console.WriteLine("Trayecto: {0}",vuelo.Trayecto);
                Console.WriteLine("Origen: {0}",vuelo.Origen);
                Console.WriteLine("Destino: {0}",vuelo.Destino);
                Console.WriteLine("Hora partida: {0}",vuelo.Horapartida);
                Console.WriteLine("Hora llegada: {0}",vuelo.Horallegada);
                Console.WriteLine("Valor: {0}",vuelo.Valor);
                Console.WriteLine("----------------------------------------------");
                
            }
            
        }




    }
}
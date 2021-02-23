using System;
using System.Collections.Generic;

namespace taller1
{
    class Vuelos
    {
        string codigo;
        string trayecto;
        string origen;
        string destino;
        string horapartida;
        string horallegada;
        double valor;

        public string Codigo {get; set; }
        public string Trayecto {get; set; }
        public string Origen {get; set; }
        public string Destino {get; set; }
        public string Horapartida {get; set; }
        public string Horallegada {get; set; }
        public double Valor {get; set; }

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




    }
}
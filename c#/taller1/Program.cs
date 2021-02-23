using System;
using System.Collections.Generic;

namespace taller1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vuelos> vuelos = new List<Vuelos>{
                new Vuelos {Codigo = "TRA-01", Trayecto = "TRAYECTO A", Origen = "Bucaramanga", Destino = "Cucuta", Horapartida = "7:45 AM", Horallegada = "8:20 AM", Valor = 100000},
                new Vuelos {Codigo = "TRA-02", Trayecto = "TRAYECTO B", Origen = "Cucuta", Destino = "Bucaramanga", Horapartida = "7:45 AM", Horallegada = "8:20 AM", Valor = 120000},
                new Vuelos {Codigo = "TRA-03", Trayecto = "TRAYECTO C", Origen = "Bucaramanga", Destino = "Medellin", Horapartida = "9:00 AM", Horallegada = "10:00 AM", Valor = 250000},
                new Vuelos {Codigo = "TRA-04", Trayecto = "TRAYECTO D", Origen = "Valledupar", Destino = "Cartagena", Horapartida = "11:00 AM", Horallegada = "12:00 PM", Valor = 250000}
            };

            List<Aviones> aviones = new List<Aviones>{
                new Aviones{Numero = "ATK-01", Tipo = "Foker 50", Cupo = 50},
                new Aviones{Numero = "ATK-02", Tipo = "Air Bus 100", Cupo = 100},
                new Aviones{Numero = "ATK-03", Tipo = "Air bus 100", Cupo = 100},
                new Aviones{Numero = "ATK-04", Tipo = "Foker 100", Cupo = 100}
            };
        
            List<Trabajadores> personal = new List<Trabajadores>{
                new Trabajadores{Numero = "PER-01", Nombre = "Piloto 01", Cargo = "Piloto"},
                new Trabajadores{Numero = "PER-02", Nombre = "Piloto 02 Aux", Cargo = "Copiloto" },
                new Trabajadores{Numero = "PER-03", Nombre = "Aux 01", Cargo = "Azafata" },
                new Trabajadores{Numero = "PER-04", Nombre = "Aux 02", Cargo = "Azafata" },
                new Trabajadores{Numero = "PER-05", Nombre = "Piloto 03", Cargo = "Piloto" },
                new Trabajadores{Numero = "PER-06", Nombre = "Piloto 04 Aux", Cargo = "Copiloto" },
                new Trabajadores{Numero = "PER-07", Nombre = "Aux 03", Cargo = "Azafata" },
                new Trabajadores{Numero = "PER-08", Nombre = "Aux 04", Cargo = "Azafata" },
                new Trabajadores{Numero = "PER-09", Nombre = "Piloto 04", Cargo = "Piloto" },
                new Trabajadores{Numero = "PER-10", Nombre = "Piloto 05 Aux", Cargo = "Copiloto" },
                new Trabajadores{Numero = "PER-11", Nombre = "Aux 05", Cargo = "Azafata" },
                new Trabajadores{Numero = "PER-12", Nombre = "Aux 06", Cargo = "Azafata" } 

            };

            


        }
    }
}

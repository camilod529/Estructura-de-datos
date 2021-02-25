using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace taller1
{

    class Program
    {
        static void Main(string[] args)
        {
            //Lista de los trayectos
            List<Vuelos> vuelos = new List<Vuelos>{
                new Vuelos {Codigo = "TRA-01", Trayecto = "TRAYECTO A", Origen = "Bucaramanga", Destino = "Cucuta", Horapartida = "7:45 AM", Horallegada = "8:20 AM", Valor = 100000},
                new Vuelos {Codigo = "TRA-02", Trayecto = "TRAYECTO B", Origen = "Cucuta", Destino = "Bucaramanga", Horapartida = "7:45 AM", Horallegada = "8:20 AM", Valor = 120000},
                new Vuelos {Codigo = "TRA-03", Trayecto = "TRAYECTO C", Origen = "Bucaramanga", Destino = "Medellin", Horapartida = "9:00 AM", Horallegada = "10:00 AM", Valor = 250000},
                new Vuelos {Codigo = "TRA-04", Trayecto = "TRAYECTO D", Origen = "Valledupar", Destino = "Cartagena", Horapartida = "11:00 AM", Horallegada = "12:00 PM", Valor = 250000}
            };
            
            //Lista de los aviones
            List<Aviones> aviones = new List<Aviones>{
                new Aviones{Numero = "ATK-01", Tipo = "Foker 50", Cupo = 50},
                new Aviones{Numero = "ATK-02", Tipo = "Air Bus 100", Cupo = 100},
                new Aviones{Numero = "ATK-03", Tipo = "Air bus 100", Cupo = 100},
                new Aviones{Numero = "ATK-04", Tipo = "Foker 100", Cupo = 100}
            };
        
            //Lista de el personal        
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

            //Lista de los clientes
            List<Clientes> clientes = new List<Clientes>{
                new Clientes{Id = 111, Nombre = "Cliente A", Correo = "clientea@gmail.com", Telefono = 35556644, Ciudad = "Bucaramanga"},
                new Clientes{Id = 112, Nombre = "Cliente B", Correo = "clienteb@hotmail.com", Telefono = 4788995, Ciudad = "Bogota"},
                new Clientes{Id = 113, Nombre = "Cliente C", Correo = "clientec@yahoo.es", Telefono = 8776433, Ciudad = "Cucuta"},
                new Clientes{Id = 114, Nombre = "Cliente D", Correo = "cliented@gmail.com", Telefono = 454234, Ciudad = "Barranquilla"}
            };

            //Persistencia de los datos en json 
            Vuelos obVuelos = new Vuelos();
            obVuelos.Guardar(vuelos);
            Aviones obAviones = new Aviones();
            obAviones.Guardar(aviones);
            Trabajadores obTrabajadores = new Trabajadores();
            obTrabajadores.Guardar(personal);
            Clientes obClientes = new Clientes();
            obClientes.Guardar(clientes);


            //Creacion diccionario para enlazar aviones x personal
            Dictionary<string, string> AvionesxPersonal = new Dictionary<string, string>();
            AvionesxPersonal.Add(personal[0].Numero, aviones[0].Numero);
            AvionesxPersonal.Add(personal[1].Numero, aviones[0].Numero);
            AvionesxPersonal.Add(personal[2].Numero, aviones[0].Numero);
            AvionesxPersonal.Add(personal[3].Numero, aviones[0].Numero);
            AvionesxPersonal.Add(personal[4].Numero, aviones[1].Numero);
            AvionesxPersonal.Add(personal[5].Numero, aviones[1].Numero);
            AvionesxPersonal.Add(personal[6].Numero, aviones[1].Numero);
            AvionesxPersonal.Add(personal[7].Numero, aviones[1].Numero);
            AvionesxPersonal.Add(personal[8].Numero, aviones[2].Numero);
            AvionesxPersonal.Add(personal[9].Numero, aviones[2].Numero);
            AvionesxPersonal.Add(personal[10].Numero, aviones[2].Numero);
            AvionesxPersonal.Add(personal[11].Numero, aviones[2].Numero);
            foreach (KeyValuePair<string, string> kvp in AvionesxPersonal)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

           List<string[]> avionxtrayecto = new List<string[]>();
           avionxtrayecto.Add(new string[]{aviones[0].Numero,vuelos[0].Codigo,"10-03-21"});
           avionxtrayecto.Add(new string[]{aviones[1].Numero,vuelos[1].Codigo,"25-02-21"});
           avionxtrayecto.Add(new string[]{aviones[2].Numero,vuelos[2].Codigo,"01-03-21"});
           avionxtrayecto.Add(new string[]{aviones[3].Numero,vuelos[3].Codigo,"08-03-21"});
           foreach (string[] item in avionxtrayecto)
           {
               Console.WriteLine(item);
           }    

            /*for (int i = 0; i < avionxtrayecto.GetLength(0); i++)
        {
            for (int j = 0; j < avionxtrayecto.GetLength(1); j++)
            {
                Console.Write(string.Format("{0} ", avionxtrayecto[i, j]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }*/
        


            
        }
    }
}

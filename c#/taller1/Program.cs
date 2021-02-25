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
            List<Vuelos> vuelos = new List<Vuelos>();
            //llamando trayectos json
            string path = @"D:\UNAB\estructura_de_datos\JSON-taller1\vuelo.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                vuelos = JsonConvert.DeserializeObject<List<Vuelos>>(jsond);
            }

            //crear objeto asistente de trayectos
            Vuelos obVuelos = new Vuelos();
            
            //Lista de los aviones
            List<Aviones> aviones = new List<Aviones>();
            //llamando aviones del json
            path = @"D:\UNAB\estructura_de_datos\JSON-taller1\aviones.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                aviones = JsonConvert.DeserializeObject<List<Aviones>>(jsond);
            }

            //Lista de el personal        
            List<Trabajadores> personal = new List<Trabajadores>();

            //llamando datos personal del json
            path = @"D:\UNAB\estructura_de_datos\JSON-taller1\personal.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                personal = JsonConvert.DeserializeObject<List<Trabajadores>>(jsond);
            }

        

            //Lista de los clientes
            List<Clientes> clientes = new List<Clientes>();
            //llamando datos clientes del json
            path = @"D:\UNAB\estructura_de_datos\JSON-taller1\clientes.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                clientes = JsonConvert.DeserializeObject<List<Clientes>>(jsond);
            }
            Clientes obClientes = new Clientes();
            


            //Creacion diccionario para enlazar aviones x personal
            List<string[]> AvionesxPersonal = new List<string[]>();

            //llamando datos avionesxpersonal del json
            path = @"D:\UNAB\estructura_de_datos\JSON-taller1\AvionesxPersonal.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                AvionesxPersonal = JsonConvert.DeserializeObject<List<string[]>>(jsond);
            }
            


           List<string[]> avionxtrayecto = new List<string[]>();
           //llamando datos avionxtrayecto del json
           path = @"D:\UNAB\estructura_de_datos\JSON-taller1\avionxtrayecto.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                avionxtrayecto = JsonConvert.DeserializeObject<List<string[]>>(jsond);
            }

            

            List<string[]> clientesxtrayecto = new List<string[]>();
            //llamando datos clientesxtrayecto del json
            path = @"D:\UNAB\estructura_de_datos\JSON-taller1\clientesxtrayecto.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                clientesxtrayecto = JsonConvert.DeserializeObject<List<string[]>>(jsond);
            }

            int opcion = 0;

            do{
                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Listar clientes");
                Console.WriteLine("3. Buscar cliente por ciudad");
                Console.WriteLine("4. Comprar tiquete");
                Console.WriteLine("5. Buscar tripulacion asignada");
                Console.WriteLine("6. Salir");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        string nombre, email, ciudad, id;
                        int telefono;
                        Console.WriteLine("| MENU DE REGISTRO DE CLIENTES |");
                        Console.WriteLine("Ingrese el ID");
                        id = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el email");
                        email = Console.ReadLine();
                        Console.WriteLine("Ingrese la ciudad de residencia");
                        ciudad = Console.ReadLine();
                        Console.WriteLine("Ingrese la telefono");
                        telefono = Int32.Parse(Console.ReadLine());
                        clientes.Add(new Clientes(id, nombre, email, telefono, ciudad));
                        break;
                    case 2:
                        obClientes.ListarClientes(clientes);
                        break;
                    
                    case 3:
                        string palabra;
                        Console.WriteLine("Ingrese la ciudad");
                        palabra = Console.ReadLine();
                        obClientes.BuscarClientexCiudad(clientes, palabra);
                        break;
                    
                    case 4:
                        string destino;
                        Console.WriteLine("Ingrese el destino");
                        destino = Console.ReadLine();
                        obVuelos.BuscarVueloxdestino(vuelos, destino);
                        break;

                    case 5:
                        
                        break;
                    
                    case 6:
                    
                        break;

                    default:
                        break;
                }

            }while(opcion != 6);

            
            






























           /*for (int i = 0; i < avionxtrayecto.Count; i++)
           {
               for (int j = 0; j < avionxtrayecto[i].Length; j++)
               {
                   Console.Write(avionxtrayecto[i][j]);
               }
               Console.WriteLine();
           }
    

            for (int i = 0; i < avionxtrayecto.GetLength(0); i++)
        {
            for (int j = 0; j < avionxtrayecto.GetLength(1); j++)
            {
                Console.Write(string.Format("{0} ", avionxtrayecto[i, j]));
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }*/
        


            
        }

        public void Guardar(List<Clientes> miLista)
        {
            string json = JsonConvert.SerializeObject(miLista);
            string path = @"D:\UNAB\estructura_de_datos\JSONS\clientes.json";
            File.WriteAllText(path, json);
        }

        public List<Clientes> LoadData()
        {
            List<Clientes> misDatos = new List<Clientes>();
            string path = @"D:\UNAB\estructura_de_datos\JSONS\clientes.json";
            using(StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                misDatos = JsonConvert.DeserializeObject<List<Clientes>>(jsond);
            }
            return misDatos;
        }
    }
}

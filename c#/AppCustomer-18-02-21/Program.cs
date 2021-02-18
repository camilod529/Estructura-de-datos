using System;
using System.Collections.Generic;

namespace AppCustomer_18_02_21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Clientes> lstClient = new List<Clientes>();
            lstClient.Add(new Clientes("jose", "jose@gmail.com", 17, "Bucaramanga"));
            int opcion = 0;
            do
            {                

                Console.WriteLine("1. Registrar cliente");
                Console.WriteLine("2. Listar clientes");
                Console.WriteLine("3. Buscar cliente por ciudad");
                Console.WriteLine("4. Salir");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        string nombre, email, ciudad;
                        int edad;
                        //Console.Clear();
                        Console.WriteLine("| MENU DE REGISTRO DE CLIENTES |");
                        Console.WriteLine("Ingrese el nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el email");
                        email = Console.ReadLine();
                        Console.WriteLine("Ingrese la ciudad de residencia");
                        ciudad = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad");
                        edad = Int32.Parse(Console.ReadLine());
                        lstClient.Add(new Clientes(nombre, email, edad, ciudad));
                        break;
                    case 2:
                        Clientes objClient = new Clientes();
                        objClient.ListarClientes(lstClient);
                        break;
                    
                    case 3:
                        Clientes objClient2 = new Clientes();
                        string palabra;
                        Console.WriteLine("Digite la ciudad");
                        palabra = Console.ReadLine();  
                        //objClient2.ListarClientes(lstClient);      
                        objClient2.BuscarClientexCiudad(lstClient, palabra);
                        break;
                    
                    case 4:
                        break;

                    default:
                        break;
                }

            }while(opcion != 4);
            /*
            foreach (Clientes cliente in lstClient)
            {
                Console.WriteLine(cliente.Nombre);
            }*/

        }
    }
}

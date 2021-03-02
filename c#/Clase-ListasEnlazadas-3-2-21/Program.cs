using System;
using System.Collections.Generic;

namespace Clase_ListasEnlazadas_3_2_21
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> nombres = new LinkedList<string>();
            int opcion;

            do{
            Console.WriteLine("Como desea registrar su contactos");
            Console.WriteLine("1. Al inicio");
            Console.WriteLine("2. Al Final");
            Console.WriteLine("3. Ver la lista");
            Console.WriteLine("4. Salir");
            opcion = Int32.Parse(Console.ReadLine());
            string nombre;

            switch(opcion)
            {
                case 1:
                Console.WriteLine("Ingrese el nombre del contacto");
                nombre = Console.ReadLine();
                nombres.AddFirst(nombre);
                    break;

                case 2:
                Console.WriteLine("Ingrese el nombre del contacto");
                nombre = Console.ReadLine();
                nombres.AddLast(nombre);
                    break;
                
                case 3:
                foreach(string valor in nombres)
                {
                    Console.WriteLine(valor);
                }
                    break;
                
                case 4:
                Console.WriteLine("Hasta luego");
                    break;
                default: break;
            }
            }while(opcion != 4);

            

        }
    }
}

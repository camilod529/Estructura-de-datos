using System;
using System.Collections.Generic;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Agenda> agendas = new Dictionary<string, Agenda>();
            Agenda objAgenda = new Agenda();
            //agendas = objAgenda.loadData();


            //variables auxiliares
            int option, QuantityToProduce, ProducedQuantity;
            string productionNumber, ClientId, ClientName, Email, ClothingCode, ClothingName, Category;
            double UnitCost; 
            
            do
            {
                Console.WriteLine("---Menú de Inicio---");
                Console.WriteLine("Seleccione la acción que desea realizar:");
                Console.WriteLine("1. Crear agendas de produccion");
                Console.WriteLine("2. Actualizar cantidades fabricadas de las prendas");
                Console.WriteLine("3. Consultar por categoria");
                Console.WriteLine("4. Imprimir el costo de produccion de todas las agendas de produccion");
                Console.WriteLine("5. Calcular el costo total de produccion");
                Console.WriteLine("6. Calcular el total de produccion por cada categoria");
                Console.WriteLine("7. salir");

                option = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\n\n");
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Ingrese el numero de produccion de la agenda que desea crear");
                        productionNumber = Console.ReadLine();
                        Console.WriteLine("Ingrese el Id del cliente");

                        objAgenda.makingAgendas(agendas, productionNumber, new Agenda());
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                    Console.WriteLine("Gracias por usar el programa");
                        break;

                    default:
                        Console.WriteLine("Ingrese una opcion correcta");
                        break;
                }
            } while (option != 7);
            

        }
    }
}

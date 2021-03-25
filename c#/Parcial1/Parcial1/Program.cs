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
            agendas = objAgenda.loadData();
            objAgenda.showAgendas(agendas);

            //variables auxiliares
            int option, option2, QuantityToProduce, ProducedQuantity;
            string productionNumber, ClientId, ClientName, Email, ClothingCode, ClothingName, Category = "Null";
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
                        ClientId = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del cliente");
                        ClientName = Console.ReadLine();
                        Console.WriteLine("Ingrese el correo del cliente");
                        Email = Console.ReadLine();
                        Console.WriteLine("ingrese el codigo de la prenda");
                        ClothingCode = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre de la prenda");
                        ClothingName = Console.ReadLine();
                        Console.WriteLine("seleccione el numero de la categoria deseada");
                        
                        do
                        {
                            Console.WriteLine("---Menú de categoria---");
                            Console.WriteLine("Seleccione la categoria deseada:");
                            Console.WriteLine("1. Caballero");
                            Console.WriteLine("2. Dama");
                            Console.WriteLine("3. Niño");
                            Console.WriteLine("4. Bebes");
                            option2 = Int32.Parse(Console.ReadLine());
                            switch (option2)
                            {
                                case 1:
                                    Console.WriteLine("Seleccionado categoria Caballero");
                                    Category = "Caballero";
                                    option2 = 5;
                                    break;

                                case 2:
                                    Console.WriteLine("Seleccionado categoria Dama");
                                    Category = "Dama";
                                    option2 = 5;
                                    break;

                                case 3:
                                    Console.WriteLine("Seleccionado categoria Niño");
                                    Category = "Niño";
                                    option2 = 5;
                                    break;

                                case 4:
                                    Console.WriteLine("Seleccionado categoria Bebes");
                                    Category = "Bebes";
                                    option2 = 5;
                                    break;

                                default:
                                    Console.WriteLine("Ingrese una opcion correcta");
                                    break;
                            }

                        } while (option2 != 5);
                        Console.WriteLine("Ingrese la cantidad a producir");
                        QuantityToProduce = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el costo unitario de la prenda");
                        UnitCost = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad fabricada");
                        ProducedQuantity = Int32.Parse(Console.ReadLine());
                        Agenda aux = new Agenda(ClientId, ClientName, Email, ClothingCode, ClothingName, Category, QuantityToProduce, UnitCost, ProducedQuantity);
                        objAgenda.makingAgendas(agendas, productionNumber, aux);
                        break;
                    case 2:
                        objAgenda.showAgendas(agendas);
                        Console.WriteLine("Ingrese el numero de produccion al que desea actualizar las cantidades fabricadas de las prendas");
                        productionNumber = Console.ReadLine();
                        Console.WriteLine("Ingrese la nueva cantidad fabricada");
                        ProducedQuantity = Int32.Parse(Console.ReadLine());
                        objAgenda.updateProducedQuantity(agendas, productionNumber, ProducedQuantity);
                        break;
                    case 3:
                        objAgenda.showCategory(agendas);
                        Console.WriteLine("Escriba la categoria que desea consultar");
                        Category = Console.ReadLine();
                        objAgenda.searchByCategory(agendas, Category);
                        break;
                    case 4:
                        objAgenda.printProductionCost(agendas);
                        break;
                    case 5:
                        objAgenda.printAllProductionCost(agendas);
                        break;
                    case 6:
                        objAgenda.printProductionCostByCategory(agendas);
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

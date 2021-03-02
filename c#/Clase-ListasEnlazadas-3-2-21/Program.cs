using System;
using System.Collections.Generic;

namespace Clase_ListasEnlazadas_3_2_21
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> names = new LinkedList<string>();
            int opcion = 0;

            do{
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Como desea registrar su contactos");
                Console.WriteLine("1. Al inicio");
                Console.WriteLine("2. Al Final");
                Console.WriteLine("3. Despues de un contacto");
                Console.WriteLine("4. Antes de un contacto");
                Console.WriteLine("5. Ver la lista de contactos");
                Console.WriteLine("6. Salir");
                Console.WriteLine("------------------------------------");
                opcion = Int32.Parse(Console.ReadLine());
                string name;

                switch(opcion)
                {
                    case 1:
                    Console.WriteLine("Ingrese el nombre del contacto");
                    name = Console.ReadLine();
                    names.AddFirst(name);
                    Console.WriteLine("Agregado al inicio");
                        break;

                    case 2:
                    Console.WriteLine("Ingrese el nombre del contacto");
                    name = Console.ReadLine();
                    names.AddLast(name);
                    Console.WriteLine("Agregado al final");
                        break;

                    case 3:
                    Console.WriteLine("Ingrese el nombre de contacto que quiere usar como anterior");
                    ShowContacts(names);
                    AddAfterContact(names);
                        break;

                    case 4:
                    Console.WriteLine("Ingrese el nombre de contacto que quiere usar como despues");
                    ShowContacts(names);
                    AddBeforeContact(names);
                        break;

                    case 5:
                    ShowContacts(names);
                        break;

                    case 6:
                    Console.WriteLine("Hasta luego");
                        break;
                    
                    default: Console.WriteLine("Ingrese una opcion correcta"); break;
            }
            }while(opcion != 6);

            

        }


        public static void ShowContacts(LinkedList<string> names)
        {
            Console.WriteLine("------------------------------");
            foreach(string valor in names)
                {
                    Console.WriteLine(valor);
                }
            Console.WriteLine("------------------------------");
        }

        public static void AddAfterContact(LinkedList<string> names)
        {
            string currentContact = Console.ReadLine();
            LinkedListNode<string> current = names.FindLast(currentContact);
            Console.WriteLine("Ingrese el nombre del conacto que desea agregar");
            LinkedListNode<string> name =new LinkedListNode<string>(Console.ReadLine());
            names.AddAfter(current, name);
            Console.WriteLine("Contacto agregado despues de " + currentContact);
        }

        
        public static void AddBeforeContact(LinkedList<string> names)
        {
            string currentContact = Console.ReadLine();
            LinkedListNode<string> current = names.FindLast(currentContact);
            Console.WriteLine("Ingrese el nombre del conacto que desea agregar");
            LinkedListNode<string> name =new LinkedListNode<string>(Console.ReadLine());
            names.AddBefore(current, name);
            Console.WriteLine("Contacto agregado antes de " + currentContact);
        }
    }
}

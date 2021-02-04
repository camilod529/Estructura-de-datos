using System;

namespace introduccionNET
{

    class miNodo
    {
        public int valor;
    }
    class Program
    {
        static void Main(string[] args)
        {
            miNodo nuevoNodo = new miNodo();

            nuevoNodo.valor = 128;

            //Console.WriteLine("Hello World!");
            Console.WriteLine("Me lamo Camilo \nSon las : "+ DateTime.Now);

            Console.WriteLine("El valor almacenado en el nodo es: " + nuevoNodo.valor);
        }
    }
}

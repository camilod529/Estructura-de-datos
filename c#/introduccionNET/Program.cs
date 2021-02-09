using System;


namespace introduccionNET
{
    namespace structsssssss
    {
        struct miNodo
        {
            int Valor;

            public void setValor(int valor)
            {
                this.Valor = valor;
            }

            public int getValor()
            {
                return Valor;
            }
            public miNodo(int valor)
            {
                this.Valor = valor;
            }
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            structsssssss.miNodo nuevoNodo = new structsssssss.miNodo(789);  
            //nuevoNodo.setValor(456);           

            //Console.WriteLine("Hello World!");
            Console.WriteLine("Me llamo Camilo \nSon las : "+ DateTime.Now);

            Console.WriteLine("El valor almacenado en el nodo es: " + nuevoNodo.getValor());

        }
    }
}
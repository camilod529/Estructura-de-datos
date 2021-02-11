using System;

namespace Pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            Console.WriteLine("Ingrese el nombre de Usuario");
            user.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del Usuario");
            user.Edad = Int32.Parse(Console.ReadLine());
            user.Email = "jp@prueba.com";
            user.Sexo = "Masculino";
            user.Pais = "Colombia";
            Console.WriteLine("Nombre : {0}\nEdad : {1}\nEmail : {2}", user.Nombre, user.Edad, user.Email);
            //  user.imprimir_datos();
            Usuario userB = new Usuario("Pablo", 16, "pablo@prueba.com", "Hombre", "Peru");

            userB.imprimir_datos();

        }
    }
}

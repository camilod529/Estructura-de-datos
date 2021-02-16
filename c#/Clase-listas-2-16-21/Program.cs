using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase_listas_2_16_21
{
    class Program
    {

        public class Student
        {
            public string Nombres { get; set; }
            public string Apellido { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
                new Student {Nombres="Jose M.", Apellido="Pardo S.", ID=111, Scores= new List<int> {97, 92, 81, 60}},
                new Student {Nombres="Juan J.", Apellido="Plata G.", ID=112, Scores= new List<int> {90, 82, 81, 70}},
                new Student {Nombres="Camilo.", Apellido="Rodriguez", ID=113, Scores= new List<int> {87, 82, 61, 50}},
                new Student {Nombres="Maria", Apellido="Suarez.", ID=114, Scores= new List<int> {77,62, 61, 90}}
            };

            Student alumno = new Student();
            alumno.ID = 114;
            alumno.Nombres = "Camila";
            alumno.Apellido = "Rojas";
            alumno.Scores = new List<int> {34, 78, 89, 100};
            students.Add(alumno);

            foreach (Student estudiante in students)
            {
                Console.WriteLine("Nombre :{0}",estudiante.Nombres);
            }
            
            /*
            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };
            // Define the query expression.
            IEnumerable<int> scoreQuery =
            from score in scores
            where score > 80
            select score;
            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }


            
            string[] misPaises = {
                "Colombia",
                "Mexico",
                "Puerto Rico",
                "Chile",
                "Peru",
                "Ecuador",
                "Inglaterra"
            };

            List<string> paises = new List<string>();
            paises.AddRange(misPaises);
            
            //string[] otrosPaises = paises.ToArray();
            Console.WriteLine(paises.Find(x => x.Equals("Colombia")) != null ? paises.Find(x => x.Equals("Colombia")) : "No se encontro");

            string[] subPaises = paises.FindAll(x => x.Contains("i")).ToArray();
            /*
            foreach (string dato in otrosPaises)
            {
                Console.WriteLine(dato);
            }*/
            /*
            Console.WriteLine("**************************************");
            //Console.WriteLine("El indice de peru es = {0}", paises.FindIndex(x => x.Equals("Peru")));
            Console.WriteLine("El ultimo registro encontrado [{0}]", paises.FindLast(x => x.Contains("o")));

            foreach(string dato in subPaises)
            {
                Console.WriteLine(dato);
            }




            /*
            foreach (string pais in paises){
                Console.WriteLine(pais);
            }

            Console.WriteLine("La lista contiene: {0}", paises.Count);
            Console.WriteLine("***** LISTA APLICANDO METODO REVERSE ****");
            paises.Reverse();

            //Eliminar todos los elementos que satisfagan la condicion (Chile)
            paises.RemoveAll(x => x.Equals("Chile"));
            Console.WriteLine("\n");

            foreach(string pais in paises)
            {
                Console.WriteLine(pais);
            }
            Console.WriteLine("La lista contiene: {0}", paises.Count);
        
            //paises.Clear();
            
            paises.Add("Estados Unidos");
            Console.WriteLine("\n\n");
            
            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }
            
            Console.WriteLine("\nBusqueda binaria en Listas \"Uruguay\":\n");
            int index = paises.BinarySearch("Uruguay");
            if(index < 0)
            {
                paises.Insert(~index, "Uruguay");
            }

            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }*/
        }
    }
}

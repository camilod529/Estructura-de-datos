using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add("Maria");
            nombres.Add("Martha");
            nombres.Add("Camilo");
            nombres.Add("Juan");
            nombres.Add("Jose");

            /*for(int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i]);
            }*/
            
            foreach (string user in nombres)
            {
                Console.WriteLine(user);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace EstudioBiblioteca
{
    class Book
    {
        //Nombre del autor
        public string Author { get; set; }
        //Nombre del libro
        public string Name { get; set; }
        //Numero de inventario
        public string InventaryCode { get; set;}
        //Especialidad de libro (Explicado en clase)
        public string Specialty { get; set; }
        //estado del libro (Prestado en Sala = PS, Prestado en Domicilio = PD, Reservado = RS, Disponible = D)
        public string State { get; set; }
        //Sala de ubicacion (Hemeroteca, ciencias basicas, ingenieria, literatura general)
        public string Room { get; set; }

        public Book() { }

        public Book(string Author, string Name, string InventaryCode, string Specialty, string State, string Room)
        {
            this.Author = Author;
            this.Name = Name;
            this.InventaryCode = InventaryCode;
            this.Specialty = Specialty;
            this.State = State;
            this.Room = Room;
        }
        //guardar datos
        public void saveData(Dictionary<string, Book> dictionary)
        {
            string json = JsonConvert.SerializeObject(dictionary);
            string path = @"./jsons/Books.json";
            File.WriteAllText(path, json);
        }
        //cargar datos json
        public Dictionary<string, Book> loadData()
        {
            Dictionary<string, Book> dictionary = new Dictionary<string, Book>();
            string path = @"./jsons/Books.json";
            using (StreamReader jsonStream = File.OpenText(path))
            {
                var jsond = jsonStream.ReadToEnd();
                dictionary = JsonConvert.DeserializeObject<Dictionary<string, Book>>(jsond);
            }
            return dictionary;
        }
        //mostrar libros
        public void printBooks(Dictionary<string, Book> dictionary)
        {
            foreach(var item in dictionary)
                {
                    Console.WriteLine("ISBN: {0}", item.Key);
                    Console.WriteLine("Autor: " + item.Value.Author + " Nombre: " + item.Value.Name + " InventaryCode: " + item.Value.InventaryCode + " Especialidad: " + item.Value.Specialty + " Estado: " + item.Value.State + " Ubicacion en sala: " + item.Value.Room); 
                }
        }
        //mostrar libros x ISBN
        public void printBooksISBN(Dictionary<string, Book> dictionary, string ISBN)
        {
            foreach (var item in dictionary)
            {
                if(ISBN == item.Key)
                {
                    Console.WriteLine("Autor: " + item.Value.Author + " Nombre: " + item.Value.Name + " InventaryCode: " + item.Value.InventaryCode + " Especialidad: " + item.Value.Specialty + " Estado: " + item.Value.State + " Ubicacion en sala: " + item.Value.Room);
                }
            }
        }
        //crear nuevo libro
        public void recordBook (Dictionary<string, Book> dictionary, string keyd, Book data)
        {
            if(!dictionary.ContainsKey(keyd))
            {
                dictionary.Add(keyd, data);
                Console.WriteLine("Libro creado");
                string json = JsonConvert.SerializeObject(dictionary);
                string path = @"./jsons/Books.json";
                File.WriteAllText(path, json);
                printBooks(dictionary);
            }
            else
            {
                Console.WriteLine("Ya hay un libro creado con ese ISBN");
            }
        }
        //cambiar estado
        public void changeStatus(Dictionary<string, Book> dictionary, string keyd, string status)
        {
            if(dictionary.ContainsKey(keyd))
            {
                foreach(var item in dictionary)
                {
                    if(keyd == item.Key)
                    {
                        item.Value.State = status;
                        Console.WriteLine("Cambios realizados");
                        break;
                    }
                    else
                    {
                        if(item.Value.InventaryCode == keyd)
                        {
                            item.Value.State = status;
                            Console.WriteLine("Cambios realizados");
                            break;
                        }
                    }
                }
            }
            
        }   
        //busqueda por autor
        public void searchxAuthor(Dictionary<string, Book> dictionary, string author)
        {
            int n=0;
            foreach(var item in dictionary)
            {
                if(item.Value.Author == author)
                {
                    printBooksISBN(dictionary, item.Key);
                    n=1;
                }
            }
            if(n==0)
            {
                Console.WriteLine("libro no encontrado asosiado al autor ", author);
            }
        }
        //busqueda por nombre
        public void searchxName(Dictionary<string, Book> dictionary, string name)
        {
            int n=0;
            foreach(var item in dictionary)
            {
                if(item.Value.Name == name)
                {
                    printBooksISBN(dictionary, item.Key);
                    n=1;
                }
            }
            if(n==0)
            {
                Console.WriteLine("libro no encontrado asosiado al nombre ", name);
            }
        }
        //busqueda por ISBN
        public void searchxISBN(Dictionary<string, Book> dictionary, string ISBN)
        {
            int n=0;
            foreach(var item in dictionary)
            {
                if(item.Key == ISBN)
                {
                    printBooksISBN(dictionary, item.Key);
                    n=1;
                }
            }
            if(n==0)
            {
                Console.WriteLine("libro no encontrado asosiado al ISBN ", ISBN);
            }
        }
        //reserva por ISBN
        public void bookxISBN(Dictionary<string, Book> dictionary, string ISBN)
        {
            if(dictionary.ContainsKey(ISBN))
            {
                foreach (var item in dictionary)
                {
                    if(item.Key == ISBN)
                    {
                        if(item.Value.State == "D")
                        {
                            item.Value.State = "RS";
                            Console.WriteLine("Libro reservado, acerquese a la mesa principal para confirmar la reserva");
                            saveData(dictionary);

                        }
                        else
                        {
                            Console.WriteLine("El libro asociado al ISBN ", ISBN, " No esta disponible para reservar");
                        }
                    }
                }
            }
        }
        //reserva por inventaryCode
        public void bookxInventaryCode(Dictionary<string, Book> dictionary, string inventaryCode)
        {
            foreach (var item in dictionary)
            {
                if(item.Value.InventaryCode == inventaryCode)
                {
                    if(item.Value.State == "D")
                        {
                            item.Value.State = "RS";
                            Console.WriteLine("Libro reservado, acerquese a la mesa principal para confirmar la reserva");
                            saveData(dictionary);
                        }
                        else
                        {
                            Console.WriteLine("El libro asociado al codigo interno de inventario ", inventaryCode, " No esta disponible para reservar");
                        }
                }
            }
        }


    }
}
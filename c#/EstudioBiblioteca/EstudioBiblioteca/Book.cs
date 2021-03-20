using System;
using System.Collections.Generic;
using System.Text;

namespace EstudioBiblioteca
{
    class Book
    {
        
        public string Author { get; set; }
        //Nombre del libro
        public string Name { get; set; }
        //Numero de inventario
        public string InventaryCode { get; set;}
        //Especialidad de libro (Explicado en clase)
        public string Specialty { get; set; }
        //estado del libro (Prestado en Sala = PS, Prestado en Domicilio = D, Reservado = RS, Disponible = D)
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


    }
}

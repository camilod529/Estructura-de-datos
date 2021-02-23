using System;

namespace taller1
{
    class Trabajadores
    {
        string numero;
        string nombre;
        string cargo;

        public string Numero{get; set; }
        public string Nombre{get; set; }
        public string Cargo{get; set; }

        public Trabajadores()
        { }

        public Trabajadores(string numero, string nombre, string cargo)
        {
            this.numero = numero;
            this.nombre = nombre;
            this.cargo = cargo;
            
        }
    }
}
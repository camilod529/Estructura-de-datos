using System;

namespace taller1
{
    class Aviones
    {
        string numero;
        string tipo;
        int cupo;

        public string Numero{get; set; }
        public string Tipo{get; set; }
        public int Cupo{get; set; }

        public Aviones()
        { }

        public Aviones(string numero, string tipo, int cupo)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.cupo = cupo;
            
        }
    }
}
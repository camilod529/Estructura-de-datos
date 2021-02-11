using System;
using System.Collections.Generic;
using System.Text;

namespace Pract1
{

    class Usuario
    {
        string nombre;
        int edad;
        string email;
        string sexo;
        string pais;


        //get and set atributes
        /// <summary>
        ///nombre del usuario tipo cadena
        ///</summary>
        public string Nombre{
            get{return nombre;}
            set{nombre=value;}
        }
        
        /// <summary>
        ///Edad del usuario tipo entero
        ///</summary>

        public int Edad { 
            get{return edad;} 
            set{edad=value;}

            }
        /// <summary>
        ///email del usuario tipo cadena
        ///</summary>

        public string Email { 
            get{return email;} 
            set{email=value;}

            }
        
        /// <summary>
        ///sexo del usuario tipo cadena
        ///</summary>

        public string Sexo { 
            get{return sexo;} 
            set{sexo=value;}

            }
            
        /// <summary>
        ///pais del usuario tipo cadena
        ///</summary>

        public string Pais { 
            get{return pais;} 
            set{pais=value;}

            }

        public Usuario(){ }

        public Usuario(string nombre, int edad, string email, string sexo, string pais)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.email = email;
            this.sexo = sexo;
            this.pais = pais;
        }

        public void imprimir_datos()
        {
            Console.WriteLine("Nombre: " + this.nombre + " Edad: " + this.edad + " email: " + this.email + " sexo: " + this.sexo + " pais: " + this.pais);

        }



    }
}
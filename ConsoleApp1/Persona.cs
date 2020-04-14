using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    /// <summary>
    /// Clase que describe una Persona
    /// </summary>
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona ()
        {
            this.nombre = "";
            this.edad = 0;
        }

        public void setNombre (string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
           return  this.nombre;
        }


        public void setEdad(int edad)
        {
            this.edad= edad;
        }

        public int getEdad()
        {
            return this.edad;
        }


        public void presentar()
        {
            Console.WriteLine("Hola soy " + this.nombre + " y tengo " + this.edad + " años");
        }
    }
}

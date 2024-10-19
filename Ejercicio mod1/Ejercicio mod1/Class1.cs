using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_mod1
{
    internal class Class1
    {
        public struct Persona //Aqui se define la estructura de cada persona y se almacena el nombre direccion y sus demas datos
        {
            public string Nombre;
            public string Direccion;
            public string Telefono;
            public int Edad;

            public Persona(string nombre, string direccion, string telefono, int edad) //Usamos el metodo constructor para inicializar cada variable 
            {
                Nombre = nombre;
                Direccion = direccion;
                Telefono = telefono;
                Edad = edad;
            }
        }
    }
}

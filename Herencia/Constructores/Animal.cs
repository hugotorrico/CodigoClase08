using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Constructores
{
    public class Animal
    {
        public string Nombre { get; set; }

        // Constructor de la clase base
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        public void Comer()
        {
            Console.WriteLine("El animal está comiendo.");
        }
    }
}

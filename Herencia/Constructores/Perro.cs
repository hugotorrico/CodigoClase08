using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.Constructores
{
    public class Perro : Animal
    {
        public string Raza { get; set; }

        // Constructor de la clase derivada que llama al constructor de la clase base
        public Perro(string nombre, string raza) : base(nombre)
        {
            Raza = raza;
        }

        public void Ladrar()
        {
            Console.WriteLine("Guau guau!");
        }
    }
}

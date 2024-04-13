using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescribir
{
     class Rectangulo : Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        //override: Sobre escribir al método de la clase padre
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}

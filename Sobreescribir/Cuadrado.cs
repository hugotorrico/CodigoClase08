using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescribir
{
     class Cuadrado :Poligono
    {
        public double Lado { get; set; }

        //override: Sobre escribir al método de la clase padre
        public override double CalcularArea()
        {
            return Lado * Lado;
        }
    }
}

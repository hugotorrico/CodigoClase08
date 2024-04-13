using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobreescribir
{
     class Poligono
    {
        public double Area { get; set; }
        public double Perimetro { get; set; }
        //Virtual:Que este método sera sobre escrito en las clases hijas
        public virtual double CalcularArea()
        {
            return 0;
        }

    }
}

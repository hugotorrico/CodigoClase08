using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class Vendedor : Persona
    {
        public string Sucursal { get; set; }
        public double Sueldo { get; set; }
        public string Codigo { get; set; }

        public double CalcularImpuesto()
        {
            return Sueldo * 0.18;
        }
    }
}

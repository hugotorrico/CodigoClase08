using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class Trabajador : Persona
    {
        public string Agencia { get; set; }
        public double Sueldo { get; set; }

        #region SobreCargaFunciones
        public double CalcularImpuesto()
        {
            return this.Sueldo * 0.18;
        }

        public double CalcularImpuesto(double impuesto)
        {
            return this.Sueldo * impuesto;
        }
        public double CalcularImpuesto(double impuesto, double bono)
        {
            return this.Sueldo * impuesto +bono;
        }
        #endregion
    }
}

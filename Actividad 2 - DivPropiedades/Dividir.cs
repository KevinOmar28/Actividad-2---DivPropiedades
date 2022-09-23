using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2___DivPropiedades
{
    internal class Dividir
    {
        private double num1;
        private double num2;

        public double Num1 { get => num1; set => num1 = value; }
        public double Num2 { get => num2; set => num2 = value; }

        public double division()
        {
            return Num1 / Num2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Tetraedro : FigurasTridimensionales
    {
        public new void CalcularArea(double lado)
        {
            Lado = lado;
            Area = Math.Pow(Lado, 2) * Math.Sqrt(3);
        }

        public new void CalcularVolumen(double lado)
        {
            Lado = lado;
            Volume = Math.Pow(Lado, 3) * (Math.Sqrt(2)/12);
        }
    }
}

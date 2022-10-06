using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Cubo : FigurasTridimensionales
    {
        public new void CalcularArea(double lado)
        {
            Lado = lado;
            Area = 12 * Lado;
        }

        public new void CalcularVolumen(double lado)
        {
            Lado = lado;
            Volume = Math.Pow(Lado, 3);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Cuadrado : FiguraBidimensionales
    {
        public new void CalcularArea(double lado)
        {
            Lado = lado;
            Area = Lado * Lado;
        }

        public new void CalcularPerimetro(double lado)
        {
            Perimetro = 4 * lado;
        }
    }
}

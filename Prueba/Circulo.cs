using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Circulo : FiguraBidimensionales
    {
        public Circulo()
        {

        }

        public new void CalcularArea(double rad)
        {
            Radio = rad;
            Area= Math.Pow(Radio, 2) * Pi;
        }

        public new void CalcularPerimetro(double rad)
        {
            Radio = rad;
            Perimetro = (2 * Pi) * Radio;
        }
    }
}

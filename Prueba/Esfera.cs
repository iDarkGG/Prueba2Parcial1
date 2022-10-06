using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Esfera : FigurasTridimensionales
    {
        public new void CalcularArea(double radio)
        {
            Area = (4 * Pi) * Math.Pow(radio, 2);
        }

        public new void CalcularVolumen(double radio)
        {
            Volume = (Pi * 1.33) * Math.Pow(radio, 3);
        }
    }
}

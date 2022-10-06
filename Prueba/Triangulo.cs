using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Triangulo : FiguraBidimensionales
    {

        public new void CalcularArea(double sbase, double altura)
        {
            Altura = altura;
            Lado = sbase;
            Area = Lado * Altura;
        }

        public new void CalcularAltura(double LadoArriba, double LadoAbajo)
        {
            Altura = Math.Sqrt(Math.Pow(LadoArriba, 2) * Math.Pow(LadoAbajo, 2));
        }

        public new void CalcularPerimetro(double lado)
        {
            Perimetro = lado*3;
        }
    }
}

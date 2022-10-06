using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class FiguraBidimensionales : Figuras
    {
        private double area;
        private double perimetro;
        private double radio;
        private double lado;
        private double altura;
        private double diametro;
        private double PI = Math.PI;


        //Getter y Setters;
        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double Perimetro
        {
            get { return perimetro; }
            set { perimetro = value; }
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Diametro
        {
            get { return diametro; }
            set { diametro = value; }
        }

        public double Pi
        {
            get { return PI; }
        }





        public override void CalcularArea()
        {

        }
        public override void CalcularPerimetro()
        {

        }
        public override void CalcularVolumen()
        {

        }
        public override void CalcularAltura()
        {

        }

    }
}

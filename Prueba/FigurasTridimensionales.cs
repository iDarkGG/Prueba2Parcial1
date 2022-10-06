using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class FigurasTridimensionales : Figuras
    {
        private double area;
        private double volumen;
        private double lado;
        private double arista;
        private double radio;
        private double PI = Math.PI;


        //Getters y Setters
        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double Volume
        {
            get { return volumen; }
            set { volumen = value; }
        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public double Arista
        {
            get { return arista; }
            set { arista = value; }
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
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

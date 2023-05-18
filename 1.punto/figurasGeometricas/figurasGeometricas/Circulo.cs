using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas
{
   public  class Circulo
    {
        private double area;
        private double radio;

        public double calcularAreaCirculo(double radio) {
            area = radio * radio * Math.PI;
            return area;
        }
        public void setRadio(double r) {
            radio = r;
        }

        public double getRadio() {
            return radio;
        }
    }
}

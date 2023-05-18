using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas
{
    public class Rectangulo
    {
        private double Base;
        private double Altura;
        private double Respuesta;

        public double calcularAreaRectangulo(double bas, double altura)
        {
            Respuesta = bas * altura;
            return Respuesta;
        }
        public void setBase(double b)
        {
            Base = b;
        }

        public double getBase()
        {
            return Base;
        }
        public void setAltura(double a)
        {
            Altura = a;
        }

        public double getAltura()
        {
            return Altura;
        }
    }
}

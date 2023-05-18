using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasGeometricas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            Rectangulo rectangulo = new Rectangulo();
            int  numero;
            double resultado;
            string condicion;
            do {
                Console.WriteLine("Elija un Figura Geometrica");
                Console.WriteLine("1- Circulo");
                Console.WriteLine("2- Rectangulo");
                numero = Convert.ToInt32(Console.ReadLine());
                switch (numero) {
                    case 1:
                        Console.Write("Ingrese Radio: ");
                        circulo.setRadio(Double.Parse(Console.ReadLine()));
                        resultado = circulo.calcularAreaCirculo(circulo.getRadio());
                        Console.WriteLine("\n El area Circulo Es: " + resultado);
                        break;
                    case 2:
                        Console.Write("Ingrese la base: ");
                        rectangulo.setBase( Convert.ToInt32(Console.ReadLine()));
                        Console.Write("Ingrese la Altura: ");
                        rectangulo.setAltura(Convert.ToInt32(Console.ReadLine()));
                        resultado = rectangulo.calcularAreaRectangulo(rectangulo.getBase(), rectangulo.getAltura());
                        Console.WriteLine("\n El area del rectagulo Es: " + resultado);
                        break;
                      
                }
                Console.WriteLine("\n Desea Intentarlo de nuevo");
                Console.WriteLine("1- Si");
                Console.WriteLine("2- No");
                condicion = Console.ReadLine();
            }
            while (condicion == "1" );
        }
        public static double debeSerUno( double entrada) {
            return entrada;
        }
    }
    
}

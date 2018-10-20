using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaCatorce
{
    class CalculoDeArea
    {
        public  static double area;
        public static double CalcularCuadrado(double lado)
        {
           // double area;

            area = Math.Pow(lado, 2);

            return area;

        }

        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
          //  double area;

            area = (baseTriangulo * alturaTriangulo) / 2;

            return area;
        }


        public static double CalcularCirculo(double radio)
        {
            area =3.14*(Math.Pow(radio,2));
            return area;
        }
    }
}

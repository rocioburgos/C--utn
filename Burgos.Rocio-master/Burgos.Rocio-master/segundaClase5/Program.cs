using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaCatorce
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;


            //Pido al usuario que ingrese el dato y lo valido. 


            Console.WriteLine("Ingrese la medida del lado del cuadrado: ");
            while (!double.TryParse(Console.ReadLine(), out ladoCuadrado))
            {
                Console.WriteLine("Error. Ingrese la medida del lado del cuadrado: ");
            }
            //Calculo el area del cuadrado. 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Area del cuadrado: ");
            Console.WriteLine(CalculoDeArea.CalcularCuadrado(ladoCuadrado));





            Console.ForegroundColor = ConsoleColor.Gray;
            //Pido al usuario que ingrese el dato y lo valido.
            Console.WriteLine("Ingrese la medida de la base del triangulo: ");
            while (!double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.WriteLine("Error. Ingrese la medida de la base del triangulo: ");
            }
            //Pido al usuario que ingrese el dato y lo valido.
            Console.WriteLine("Ingrese la medida de la altura del triangulo: ");
            while (!double.TryParse(Console.ReadLine(), out alturaTriangulo))
            {
                Console.WriteLine("Error. Ingrese la medida de la altura del triangulo: ");
            }

            //Calculo el area del triangulo.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nArea del  triangulo: ");
            Console.WriteLine(CalculoDeArea.CalcularTriangulo(baseTriangulo, alturaTriangulo));







            Console.ForegroundColor = ConsoleColor.Gray;
            //Pido al usuario que ingrese el dato y lo valido.
            Console.WriteLine("Ingrese la medida del radio del circulo: ");
            while (!double.TryParse(Console.ReadLine(), out radioCirculo))
            {
                Console.WriteLine("Error. Ingrese la medida del radio del circulo: ");
            }
            //Calculo el area del circulo.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nArea del  circulo: ");
            Console.WriteLine(CalculoDeArea.CalcularCirculo(radioCirculo));
            Console.ReadKey();
        }


    }
}

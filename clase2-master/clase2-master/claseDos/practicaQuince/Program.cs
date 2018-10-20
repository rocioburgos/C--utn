using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaQuince
{
    class Program
    {
        static void Main(string[] args)
        {
            string seguir="s";
            double numeroUno=0;
            double numeroDos = 0;
            string operando;
            double resultadoDeLaOperacion=0;

            do {
                Console.Write("Ingrese el primer operando:");
                while (!double.TryParse(Console.ReadLine(), out numeroUno))
                {
                    Console.WriteLine("Error, reingrese un numero");
                }

                Console.Write("Ingrese el segundo operando:");
                while (!double.TryParse(Console.ReadLine(), out numeroDos))
                {
                    Console.WriteLine("Error, reingrese un numero");
                }


                Console.Write("Ingrese la operacion a realizar (+ ; - ; * ; / ):");
                operando = Console.ReadLine();

               
                Calculadora.Mostrar(Calculadora.Calcular(numeroUno, numeroDos, operando));

                Console.WriteLine("Continuar? S/N");
                seguir = Console.ReadLine();

                while (seguir != "S" && seguir != "s" && seguir!= "N" && seguir != "n")
                {
                    Console.WriteLine("Error. Continuar? S/N");
                    seguir = Console.ReadLine();
                }

            } while (seguir== "s"|| seguir=="S");

            Console.ReadKey();
        }
    }
}

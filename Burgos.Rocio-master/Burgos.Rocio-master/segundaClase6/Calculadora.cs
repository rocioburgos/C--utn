using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaQuince
{
    class Calculadora
    {

        public static double Calcular(double numeroUno, double numeroDos, string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = numeroUno + numeroDos;
                    break;
                case "-":
                    resultado = numeroUno - numeroDos;
                    break;
                case "*":
                    resultado = numeroUno * numeroDos;
                    break;
                case "/":
                    if (Validar(numeroDos))
                    {
                        resultado = numeroUno / numeroDos;
                    }
                    else
                    {
                        Console.WriteLine("El divisor no puede ser 0");
                    }
                    break;
                default:
                    Console.WriteLine("No existe esa operacion");
                    break;
            }

            return resultado;
        }



        private static bool Validar(double numero)
        {
            if (numero == 0)
            {
                return false;

            }
            else
            {
                return true;
            }

        }




        public static void Mostrar(double resultado)
        {
            Console.WriteLine("El resultado es :" + resultado);
        }
    }
}

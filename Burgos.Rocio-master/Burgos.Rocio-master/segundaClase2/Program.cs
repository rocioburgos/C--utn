using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int max = 0;
            int min = 0;
            int acumulador = 0;
            float promedio;
            int contador;

            for (contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("{0} Ingrese un numero entre el 100 y -100", contador);
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado) || Validacion.validar(numeroIngresado, 100, -100) == false)
                {
                    Console.WriteLine("Error, reingrese un numero");
                }

                if (contador == 1)
                {
                    max = numeroIngresado;
                    min = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }
                    else if (numeroIngresado > max)
                    {
                        max = numeroIngresado;
                    }
                }

                acumulador += numeroIngresado;


            }

            promedio = (float)acumulador * 5 / 100;

            Console.WriteLine("Maximo:{0} \nMinimo: {1}\nPromedio: {2}", max, min, promedio);
            Console.ReadKey();

        }
    }
}

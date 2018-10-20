using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDoce
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaTotal = 0;
            int numeroIngresado;
            do
            {
                //pido el numero al usuario
                Console.WriteLine("Ingrese un numero:");
                //lo leo y valido que sea un numero
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("Error, reingrese un numero");
                }

                //voy sumando los numeros
                sumaTotal += numeroIngresado;
            } while (ValidarRespuesta.ValidaS_N());//llamo al metodo de la calse ValidarRespuesta

            //imprimo el numero de la suma total por pantalla
            Console.WriteLine("La suma total es: " + sumaTotal);
            Console.ReadKey();
        }
    }
}
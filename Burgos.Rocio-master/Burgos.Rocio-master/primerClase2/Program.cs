using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioUno
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int contador;
            int maximo = 0;
            int min = 0;
            float acumulador = 0;
            int primerLugaropar = 0;
            int contadorNumerosPares = 0;
            int banderaPrimerNumeroPar = 0;
            int primerNumeroPar = 0;
            int ultimoImpar = 0;
            int lugarUltimoImpar = 0;
            float promedioTotal = 0;



            for (contador = 0; contador < 7; contador++)
            {
                Console.WriteLine("por favor ingrese el primer numero");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error,por favor ingrese el primer numero");
                }

                if (contador == 0)
                {
                    maximo = numero;
                    min = numero;

                }
                else
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }


                    if (numero < min)
                    {
                        min = numero;
                    }


                }

                acumulador = acumulador + numero;

                if (numero % 2 == 0)
                {
                    if (banderaPrimerNumeroPar == 0)
                    {
                        primerLugaropar = contador + 1;
                        primerNumeroPar = numero;
                        banderaPrimerNumeroPar = 1;
                    }

                    contadorNumerosPares++;

                }

                if (numero % 2 != 0)
                {
                    ultimoImpar = numero;
                    lugarUltimoImpar = contador + 1;
                }

            }
            promedioTotal = acumulador / 7;
            Console.WriteLine("El lugar del 1er par " + primerLugaropar + "\n1er numero par " + primerNumeroPar + "\nCantidad de pares " + contadorNumerosPares);
            Console.WriteLine("El ultimo par " + ultimoImpar + "\nLugar del ultimo impar " + lugarUltimoImpar);
            Console.WriteLine("El mayor es: " + maximo + "\tEl minimo es " + min);
            Console.WriteLine("\nSuma total " + acumulador + "\nPromedio " + promedioTotal);
            Console.ReadLine();

        }

    }
}

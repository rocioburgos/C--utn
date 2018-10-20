using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaTrece
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeroBinario;
            double binarioConverido;

            double numeroDecimal;
            string decimalConvertido;


            //pido los numeros en binario
            Console.WriteLine("Ingrese un numero BINARIO");
            numeroBinario=Console.ReadLine();


            //convierto el numero en decimal y lo muestro
            binarioConverido = Conversor.BinarioDecimal(numeroBinario);
            Console.WriteLine("El numero en decimal es: "+binarioConverido);
            





            //pido el numero decimal
            Console.WriteLine("Ingrese un numero decimal");
            while(!double.TryParse(Console.ReadLine(),out numeroDecimal))
            {
                Console.WriteLine("Error. reingrese un numero decimal");
            }

            //convierto el numero en binario y lo muestro
             decimalConvertido = Conversor.DecimalBinario(numeroDecimal);
             Console.WriteLine("El numero en binario es: "+decimalConvertido);


            Console.ReadKey();




        }
    }
}

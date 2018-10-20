using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroUno;
            int numeroDos;
            int resultado;
            string datoUno;
            bool esNumero;


            Console.WriteLine("por favor ingrese el primer numero");

            // datoUno = Console.ReadLine();
            //  esNumero=int.TryParse(datoUno,out numeroUno);

            //numeroUno = int.Parse(datoUno);

            while (!int.TryParse(Console.ReadLine(), out numeroUno))
            {
                Console.WriteLine("Error,por favor ingrese el primer numero");
            }

            Console.WriteLine("por favor ingrese el segundo numero");


            while (!int.TryParse(Console.ReadLine(), out numeroDos))
            {
                Console.WriteLine("Error,por favor ingrese el primer numero");
            }

            //datoUno = Console.ReadLine();
            // esNumero = int.TryParse(datoUno, out numeroDos);


            //numeroDos = int.Parse(datoUno);



            resultado = numeroUno + numeroDos;


            Console.WriteLine("El resultado es {0}", resultado);
            Console.Read();
        }
    }
}


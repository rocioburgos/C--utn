using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuatro
{
    class Program
    {
        static void Main(string[] args)
        {

            Cosa unaCosa = new Cosa();
            Cosa otraCosa = new Cosa(new DateTime(2017, 12, 29, 12, 52, 20), 145, "la");
            Cosa otra = new Cosa();

            Console.WriteLine("Otra cosa: \n" + otraCosa.Mostrar());
            Console.WriteLine("Una cosa: \n" + unaCosa.Mostrar());


            unaCosa.EstablecerValor(new DateTime(2017, 12, 29));
            unaCosa.EstablecerValor(1);
            unaCosa.EstablecerValor("lala");
            unaCosa.EstablecerValor(ConsoleColor.Cyan);


            Console.WriteLine(unaCosa.Mostrar());

            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ReadKey();
        }
    }
}

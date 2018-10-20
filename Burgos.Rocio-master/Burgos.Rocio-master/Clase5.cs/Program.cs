using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Clase05;
namespace Clase5.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta unaTinta;
            Tinta otraTinta;
            unaTinta = new Tinta();
            otraTinta = new Tinta();
            //Console.WriteLine(Tinta.Mostrar(unaTinta));

           // otraTinta = new Tinta(ConsoleColor.Black,ETipoTinta.ConBrillito);


            //Prueba de sobrecarga operador == .
            if (unaTinta == otraTinta)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            
            Console.WriteLine(otraTinta);
           
            //Prueba de sobrecarga de conversiones explicita.
           //   Console.WriteLine((string) otraTinta);
           
            Console.WriteLine((string)otraTinta);

            Pluma unaPluma;
            unaPluma=new Pluma("Bic",unaTinta,15);
           
            
            unaPluma= unaPluma+otraTinta;

            Console.WriteLine(unaPluma);
          
            
            


            Console.ReadKey();
        }
    }
}

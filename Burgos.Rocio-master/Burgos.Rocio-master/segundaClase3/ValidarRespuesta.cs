using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaDoce
{
    class ValidarRespuesta
    {


        public static bool ValidaS_N()
        {
            string respuesta;
            bool retorno = true;


            Console.WriteLine("Continuar? S/N");
            respuesta = Console.ReadLine();

            while (respuesta != "S" && respuesta != "s" && respuesta != "N" && respuesta != "n")
            {
                Console.WriteLine("Error. Continuar? S/N");
                respuesta = Console.ReadLine();
            }



            if (respuesta == "S" || respuesta == "s")
            {
                retorno = true;
            }
            else if (respuesta == "N" || respuesta == "n")
            {
                retorno = false;
            }

            return retorno;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaOnce
{
    class Validacion
    {

        //si es un numero valido retorna true
        public static bool validar(int numero, int max, int min)
        {
            if (numero > max || numero < min)
            {
                return false;
            }
            return true;
        }
    }
}

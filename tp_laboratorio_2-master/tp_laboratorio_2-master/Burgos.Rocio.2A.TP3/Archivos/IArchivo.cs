using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
   
    public interface IArchivo<T>
    {
        /// <summary>
        /// Firma para implementar. Permite guardar datos en un archivo.
        /// </summary>
        /// <param name="archivo">El path de donde se va a guardar el archivo. </param>
        /// <param name="datos">Los datos que se van a guardar.</param>
        /// <returns></returns>
         bool Guardar(string archivo, T datos);

        /// <summary>
        /// Firma para implemtar. Permite leer datos de un archivo.
        /// </summary>
        /// <param name="archivo">El path de donde se va a leer el archivo.</param>
        /// <param name="datos">Donde se van a mandar los datos que se leen.</param>
        /// <returns></returns>
         bool Leer(string archivo, out T datos); 
    }
}

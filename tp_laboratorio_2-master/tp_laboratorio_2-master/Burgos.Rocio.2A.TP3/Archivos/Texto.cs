using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using EntidadesAbstractas;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        
        /// <summary>
        /// Permite guardar en un archivo de texto.
        /// </summary>
        /// <param name="archivo">El path del archivo.</param>
        /// <param name="datos">Los datos a guardar.</param>
        /// <returns></returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;

            try
            {

                StreamWriter fichero = new StreamWriter(archivo);

                fichero.Write(datos);

                fichero.Close();

                retorno = true;

            }
            catch(Excepciones.ArchivosException e)
            {
                throw e.InnerException;
            }

            return retorno;
        }


        /// <summary>
        /// Permite leer datos de un archivo de texto.
        /// </summary>
        /// <param name="archivo">El path del archivo.</param>
        /// <param name="datos">Donde se van a guardar los datos leidos.</param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            
            bool retorno = false;

            try {

                StreamReader fichero = new StreamReader(archivo);

                datos = fichero.ReadToEnd();

                fichero.Close();

                retorno = true;
            }
            catch(ArchivosException e)
            {
                throw e.InnerException;
            }

            return retorno;
            
        }

    }
}

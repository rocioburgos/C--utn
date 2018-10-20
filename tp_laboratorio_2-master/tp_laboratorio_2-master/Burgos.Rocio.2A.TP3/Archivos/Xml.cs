using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Excepciones;



namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        /// <summary>
        /// Permite escribir en un archivo XML.
        /// </summary>
        /// <param name="archivo">El path de donde se van a guardar los archivos.</param>
        /// <param name="datos">Los datos de tipo T que se van a escribir.</param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(T));
                TextWriter fichero = new StreamWriter(archivo);

                writer.Serialize(fichero, datos);

                fichero.Close();
                return true;
            }
            catch (ArchivosException e)
            {
                throw e.InnerException;
            }
        }
          
 

        /// <summary>
        /// Permite leer datos de un archivo XML.
        /// </summary>
        /// <param name="archivo">El path del archivo.</param>
        /// <param name="datos">Donde se van a enviar los datos leidos.</param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer read = new XmlSerializer(typeof(T));
                TextReader fichero = new StreamReader(archivo);
                datos= (T) read.Deserialize(fichero);

                fichero.Close();
                return true;
            }
            catch(ArchivosException e)
            {
                throw e.InnerException;
            }
        }
    }
}

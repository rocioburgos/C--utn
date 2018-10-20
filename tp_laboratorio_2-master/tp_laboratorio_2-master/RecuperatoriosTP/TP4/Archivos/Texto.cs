using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        string _path;

        public Texto(string archivo)
        {
            this._path = archivo;
        }

        public bool guardar(string datos)
        {
            try {

                StreamWriter sw = new StreamWriter(this._path,true);
                sw.WriteLine(datos);
                sw.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool leer(out List<string> datos)
        {
            string linea;
            List<string> lista = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(this._path);

                while (sr.EndOfStream==false)
                {
                    linea = sr.ReadLine();
                    lista.Add(linea);
                }

                sr.Close();

                datos = lista;
                return true;
            }
            catch
            {
                datos = lista;
                return false;
            }

            
        }
    }
}

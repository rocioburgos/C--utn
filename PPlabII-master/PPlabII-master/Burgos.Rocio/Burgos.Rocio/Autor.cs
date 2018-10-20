using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgos.Rocio
{
    public class Autor
    {
        string _apellido;
        string _nombre;
       
        #region Constructores
        public Autor(string nombre, string apellido)
        {
            this._apellido = apellido;
            this._nombre = nombre;
        }
        #endregion

        #region Sobrecargas

        public static implicit operator string(Autor a)
        {
            string retorno= a._nombre + " " + a._apellido;
           
            return retorno;
        }

        public static bool operator ==(Autor a, Autor b)
        {
            bool retorno = false;

            if (a._apellido == b._apellido && a._nombre == b._nombre)
            { retorno = true; }

            return retorno;

        }

        public static bool operator !=(Autor a, Autor b)
        {
            return !(a == b);
        }
        
        #endregion
    }
}

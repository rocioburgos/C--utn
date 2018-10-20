using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgos.Rocio
{
   public class Novela:Libro
    {
       public EGenero genero;


       #region Constructores
       public Novela(string titulo, float precio, Autor autor, EGenero genero)
           : base(titulo,autor,precio)
       {
           this.genero = genero;
       }
       #endregion

       #region Metodos

       public string Mostrar()
       {
           
           return this.genero.ToString() + " " + base.ToString();
       }

       #endregion
       #region Sobrecargas

       public static implicit operator double(Novela n)
       {
           return (double)n._precio;
       }


       public static bool operator ==(Novela a, Novela b)
       {
           bool retorno = false;
           if (a == b && a.genero == b.genero)
           {
               retorno = true;
           }

           return retorno;
       
       }

       public static bool operator !=(Novela a, Novela b)
       {

           return !(a == b);
       }

        #endregion
    }
}

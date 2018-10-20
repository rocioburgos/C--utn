using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgos.Rocio
{
  public  class Manual:Libro
    {
      public ETipo tipo;

      #region Constructores
      
      public Manual(string titulo, float precio, string nombre, string apellido, ETipo tipo):base(precio,titulo,nombre,apellido)
      {
          this.tipo = tipo;
      }


      #endregion 

      #region Metodos
      public string Mostrar()
      {
          string retorno;
          
          retorno = "\n" + this.tipo.ToString();
          retorno = base.ToString();
         

          return retorno;
      }
      #endregion

      #region Sobrecargas
      public static bool operator ==(Manual a, Manual b)
      {
          bool retorno = false;
          if (a.tipo == b.tipo && a == b)
          {
              retorno = true;
            
          }
          return retorno;
      }

      public static bool operator !=(Manual a, Manual b)
      {
          return !(a == b);
      }


      public static implicit operator double(Manual m)
      {
          return  (double) m._precio;
      }


      #endregion
    }
}

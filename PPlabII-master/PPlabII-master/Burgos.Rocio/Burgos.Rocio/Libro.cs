using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgos.Rocio
{
    public class Libro
    {
        protected  Autor _autor;
        protected int _cantidadDePaginas;
        protected static Random _generadorDePaginas;
        protected float _precio;
        protected string _titulo;

        #region Constructores 
       
        static Libro()
        {
            Libro._generadorDePaginas.Next(10, 580);
            
        }

        

        public Libro(float precio, string titulo, string nombre, string apellido)
        {
            this._precio = precio;
            this._titulo = titulo;
            this._autor = new Autor(nombre,apellido);
        }

        public Libro(string titulo, Autor autor,float precio):this(precio,titulo,autor,autor)
        {
            
        }
        
        #endregion


        #region Propiedades

      

        public int CantidadDePaginas
        {
            get {

                if (this._cantidadDePaginas == 0)
                { 
                   int.TryParse(_generadorDePaginas.ToString(),out this._cantidadDePaginas);
                }
               

                return this._cantidadDePaginas; 
            }
            
        }


        #endregion

        #region Metodos
        private static string Mostrar(Libro l)
        {
            StringBuilder r = new StringBuilder();
            r.AppendLine(l._autor);
            r.AppendLine( l._titulo);
            r.AppendLine(l._cantidadDePaginas.ToString());
            r.AppendLine(l._precio.ToString());
           
            return r.ToString();
        }

        
        #endregion

        #region Sobrecargas

        public static bool operator ==(Libro a, Libro b)
        {
            bool retorno = false;
            
            if (a._titulo == b._titulo && a._autor == b._autor)
            { retorno = true; }
           
            return retorno;
        }

        public static bool operator !=(Libro a, Libro b)
        {
            return !(a == b);
         }


        public static explicit operator string(Libro l)
        {
            return Libro.Mostrar(l);
        }
        #endregion

    }
}

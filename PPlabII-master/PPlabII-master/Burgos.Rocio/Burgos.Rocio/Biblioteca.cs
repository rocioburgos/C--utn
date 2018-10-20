using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgos.Rocio
{
    public class Biblioteca
    {
        private int _capacidad;
        private List<Libro> _libros;

        #region Constructores
        private Biblioteca()
        {
            this._libros = new List<Libro>();
        }

        private Biblioteca(int capacidad):this()
        {
            this._capacidad = capacidad;
        }


        #endregion

        #region Metodos
        public static string Mostrar(Biblioteca b)
        {
            string r;

            r = "Capacidad: " + b._capacidad;
           
            foreach (Libro i in b._libros)
            {
                r += (string)i;
            }
            
            
            return r;
        }

        #endregion

        #region Sobrecargas

        public static implicit operator Biblioteca(int capacidad)
        {
            Biblioteca b = new Biblioteca(capacidad);

            return b;
        }


        public static bool operator ==(Biblioteca b, Libro l)
        {
            bool retorno = false;

            foreach (Libro i in b._libros)
            {
                if (i == l)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno; 
        }

        public static bool operator !=(Biblioteca b, Libro l)
        {
            return !(b == l);
        }


        public static Biblioteca operator +(Biblioteca b, Libro l)
        {
            bool existe =true;

            if (b._capacidad < b._libros.Count)
            {
                if ((b == l) == false)
                {
                    b._libros.Add(l);
                    existe = false;
                }

            }
            else
            { 
                Console.WriteLine("no hay mas espacio\n");
            }


            if (existe == true)
            {
                Console.WriteLine("Ya existe\n");
            }
            return b;
        }



        private double ObtenerPrecio(ELibro tipoLibro)
        {
            double retono;
            double cantManuales = 0;
            double cantNovelas = 0;

            foreach (Libro i in this._libros)
            {
                if (i is Manual)
                {
                    cantManuales += (Manual)i;
                }
                else if (i is Novela)
                {
                    cantNovelas += (Novela)i;
                }

            }

            if (ELibro.Manual == tipoLibro)
            {
                retono = cantManuales;
            }
            else if (ELibro.Novela == tipoLibro)
            {
                retono = cantNovelas;
            }
            else
            {
                retono = (cantNovelas + cantManuales);
            }

            return retono;

        }

        #endregion
      

        #region Propiedades
        public double PrecioDeManuales
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Manual);
            }
        }

        public double PrecioDeNovelas
        {
            get
            {
                return this.ObtenerPrecio(ELibro.Novela);
            }
        }

        public double PrecioTotal
        {
            get { return this.ObtenerPrecio(ELibro.Ambos); }
        }
        #endregion
    }
}

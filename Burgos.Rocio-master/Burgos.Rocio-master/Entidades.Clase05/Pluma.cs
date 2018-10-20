using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase05
{
   public class Pluma
    {
        string _marca;
        Tinta _tinta;
        int _cantidad;

        public Pluma()
        {
            this._marca = "Sin marca";
            this._cantidad = 0;
            this._tinta = null;
        }

        public Pluma(string marca):this()
        {
            this._marca = marca;
        }

        public Pluma(string marca, Tinta tinta):this(marca)
        {
           
            this._tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad): this(marca, tinta)
        {
            this._cantidad = cantidad;
        }


        string Mostrar()
        {
            return (this._cantidad.ToString()+" "+this._marca.ToString()+" "+Tinta.Mostrar(this._tinta));
        }


        public static bool operator ==(Tinta tinta, Pluma pluma)
        {
            if (pluma._tinta == tinta)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tinta, Pluma pluma)
        {
            return !(tinta== pluma._tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (tinta ==pluma  && pluma._cantidad<100)
            {
                pluma._cantidad++;
            }

            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (tinta == pluma && pluma._cantidad > 0)
            {
                pluma._cantidad--;
            }

            return pluma;
        }

       
        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }


    }
}

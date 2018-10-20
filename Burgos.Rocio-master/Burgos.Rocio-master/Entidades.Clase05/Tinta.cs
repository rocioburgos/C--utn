using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase05
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;
      

        public Tinta()
        {
            this._color = ConsoleColor.Black;
            this._tipo = ETipoTinta.Comun;
        }


        public Tinta(ConsoleColor color):this()
        {
            this._color = color;
        }


        public Tinta(ConsoleColor color, ETipoTinta tinta):this(color)
        {
            this._tipo = tinta;
        }


        //Metodo de instancia.
        string Mostrar()
        {
            return (this._color.ToString()+" "+this._tipo.ToString());
           
        }


        //Metodo estatico de clase.
        public static string Mostrar(Tinta objetoTinta)
        {
            return objetoTinta.Mostrar();
        }


        public static bool operator ==(Tinta tintaUno, Tinta tintaDos)
        {
            if (tintaUno._color== tintaDos._color && tintaDos._tipo==tintaUno._tipo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Tinta tintaUno, Tinta tintaDos)
        {

            //el opuesto de un operador siempre tiene que ser el negado.

            return !(tintaUno == tintaDos);

          
            
            /* if(tintaUno._color!= tintaDos._color || tintaDos._tipo != tintaUno._tipo)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            
        }
 

        //conversion explicita.
        /*public static explicit operator string(Tinta t1)
        {

            return Tinta.Mostrar(t1);
        }*/


        public static implicit operator string(Tinta t2)
        {
            return t2._tipo.ToString();
        }

    }





}

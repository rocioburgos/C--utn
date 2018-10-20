using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
   public abstract class Universitario: Persona
    {
        int legajo;


        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Universitario() : this(0, "", "", "1", ENacionalidad.Argentino)
        {

        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion



        #region Sobrecarga

        /// <summary>
        /// Establece si un el objeto es igual al que recibe por parametro.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true: si son iguales. flase si son diferentes.</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj == (Object)this)
            {
                retorno = true;
            }

            return retorno;
        }

        /// <summary>
        /// Establece si dos universitarios son iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>True: si son iguales. False: si son diferentes.</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool retorno = false;
            if (pg1.GetType() == pg2.GetType() && pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo)
            {
                retorno = true;
            }

            return retorno;

        }
        /// <summary>
        /// Establece si dos universitarios son diferentes.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>True: si son iguales. False: si son diferentes.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }


        #endregion

        #region Metodos

        /// <summary>
        /// Hace un string de todos los datos de un universitario.
        /// </summary>
        /// <returns>Retorna  todos los datos de un universitario.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine(base.ToString());
            retorno.AppendLine("Legajo: "+this.legajo.ToString());

            return retorno.ToString();
        }
       
    
        protected abstract string ParticiparEnClase();


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases.Instanciables
{

    public sealed class Alumno : Universitario
    {

        public enum EEstadoCuenta { Deudor, Becado, AlDia }

        Universidad.EClases _clasesQueToma;
        EEstadoCuenta _estadoCuenta;

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Alumno()
        { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Numero de legajo.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">Numero de DNI del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="clases">Clase que toma el alumno.</param>
        public Alumno(int id, string nombre, string apellido,string dni, ENacionalidad nacionalidad, Universidad.EClases clases):base(id,nombre,apellido,dni,nacionalidad)
        {
             this._clasesQueToma = clases;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Numero de legajo.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">Numero de DNI del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="clases">Clase que toma el alumno.</param>
        /// <param name="estadoCuenta">Estado de cuenta del alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases clases, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,clases)
        {
            this._estadoCuenta = estadoCuenta;
        }


        #endregion


        #region Metodos


        /// <summary>
        /// Muestra todos los datos del alumno.
        /// </summary>
        /// <returns>Un string con todos los datos del alumno.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
           
            retorno.Append(base.MostrarDatos());
            retorno.AppendLine(this.ParticiparEnClase());
            retorno.AppendLine("Estado de cuenta: "+this._estadoCuenta.ToString());
            retorno.AppendLine();

            return retorno.ToString();
        }


        #endregion


        #region Sobrecargas
        /// <summary>
        /// Establece si un alumno es igual a una clase.
        /// </summary>
        /// <param name="a">Un alumno.</param>
        /// <param name="clase">Una clase.</param>
        /// <returns>true: si toma la clase. False: si no toma la clase</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            bool retorno = false;

            if (a._estadoCuenta != EEstadoCuenta.Deudor && a._clasesQueToma == clase)
            {
                     retorno = true;
                
            }

            return retorno;

        }

        /// <summary>
        /// Establece si un alumno es distinto a una clase.
        /// </summary>
        /// <param name="a">Un alumno.</param>
        /// <param name="clase">Una clase.</param>
        /// <returns>true: si toma la clase. False: si no toma la clase</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        /// <summary>
        /// Establece que clase toma el alumno.
        /// </summary>
        /// <returns>La clase que toma el usuario como string.</returns>
        protected override string ParticiparEnClase()
        {
            return "Toma clase de: "+this._clasesQueToma.ToString();
        }

        /// <summary>
        /// Sobrecarga del ToString.
        /// </summary>
        /// <returns>Todos los datos del alumno.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases.Instanciables
{
    public sealed class Profesor : Universitario
    {
        Queue<Universidad.EClases> _clasesDelDia;
        static Random random;

        #region Constructores

        /// <summary>
        /// Constructor de clase.
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Profesor()
        {
        }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="id">Numero de legajo.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">Numero de DNI del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this._clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClase();
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Establece dos clases aleatoreamente a un profesor.
        /// </summary>
        private void _randomClase()
        {
            this._clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(4));
            this._clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(4));
            
        }

        /// <summary>
        /// Permite mostrar todos los datos de un profesor.
        /// </summary>
        /// <returns>Todos los del profesor.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Profesor: ");
            retorno.AppendLine(base.MostrarDatos());

            foreach(Universidad.EClases i in this._clasesDelDia)
            {
                 retorno.AppendLine("CLASES DEL DIA: "+i.ToString());
            }

            retorno.AppendLine();
            return base.MostrarDatos();
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Permite establecer si un profesor es igual a una clase.
        /// </summary>
        /// <param name="i">Profesor.</param>
        /// <param name="clase">Clase.</param>
        /// <returns>True: si el profesor da la clase. False: Si no da la clase.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach(Universidad.EClases c in i._clasesDelDia)
            {
                if(clase== c)
                { 
                    retorno = true;
                    break;
                }
            }
           
            return retorno;
        }

        /// <summary>
        ///  Permite establecer si un profesor es diferente a una clase.
        /// </summary>
        /// <param name="i">Profesor.</param>
        /// <param name="clase">Clase.</param>
        /// <returns>True: si el profesor da la clase. False: Si no da la clase.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }


        /// <summary>
        /// Permite establecer la clase que da un profesor.
        /// </summary>
        /// <returns>La clase que da un profesor.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Clases del dia: ");

            foreach(Universidad.EClases i in this._clasesDelDia)
            {
                retorno.AppendLine(i.ToString());
            }
            return retorno.ToString();
        }

        /// <summary>
        /// Muestra todos los datos del profesor.
        /// </summary>
        /// <returns>TOdos los datos del profesor.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        #endregion









    }
}

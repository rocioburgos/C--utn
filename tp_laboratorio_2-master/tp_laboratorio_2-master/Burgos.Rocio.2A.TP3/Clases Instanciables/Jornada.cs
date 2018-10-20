using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using System.IO;
using Archivos;

namespace Clases.Instanciables
{
    public class Jornada
    {
        List<Alumno> _alumnos;
        Universidad.EClases _clase;
        Profesor _instructor;

        #region Constructores

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="clase">La clase de la jornada.</param>
        /// <param name="profesor">El profesor que da la clase.</param>
        public Jornada(Universidad.EClases clase, Profesor profesor):this()
        {
            this._clase = clase;
            this._instructor = profesor;
        }


        #endregion


        #region PRopiedades
        /// <summary>
        /// Retorna una lista de alumnos que toman la clase.
        /// Establece una lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        /// <summary>
        /// Retorna la clase de la jornada.
        /// Establece una clase a la jornada.
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return this._clase; }
            set { this._clase = value; }
        }

        /// <summary>
        /// Retorna el profesor de la jornada.
        /// Establece un profesor a la jornada.
        /// </summary>
        public Profesor Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }

        #endregion



        #region Metodos

        /// <summary>
        /// Guarda una jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada">La jornada que se va a guardar.</param>
        /// <returns>True: si pudo guardar. False si no pudo guardar.</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto escribir = new Texto();
           return escribir.Guardar(AppDomain.CurrentDomain.BaseDirectory + "\\jornada.txt", jornada.ToString());

        }
        /// <summary>
        /// Lee una jornada en un archivo de texto.
        /// </summary>
        /// <returns>True: si pudo leer. False si no pudo leer.</returns>
        public static string Leer()
        {
            Texto leer = new Texto();
            string retorn;
            leer.Leer(AppDomain.CurrentDomain.BaseDirectory + "\\jornada.txt", out retorn);
            return retorn;

        }

        #endregion

        #region sobrecarga

        /// <summary>
        /// Establece si una jornada es igual a un alumno.
        /// </summary>
        /// <param name="i">La jornada a comparar</param>
        /// <param name="a">El alumno a buscar si existe.</param>
        /// <returns>True: si participa de la clase. False: si no participa a la clase.</returns>
        public static bool operator ==(Jornada i, Alumno a)
        {
           bool retorno = false;
           foreach(Alumno alum in i._alumnos)
            {
                if(a== alum)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Establece si una jornada es distinta a un alumno.
        /// </summary>
        /// <param name="i">La jornada a comparar</param>
        /// <param name="a">El alumno a buscar si existe.</param>
        /// <returns>True: si participa de la clase. False: si no participa a la clase.</returns>
        public static bool operator !=(Jornada i , Alumno a)
        { return !(i==a); }


        /// <summary>
        /// Permite agregar un alumno a una jornada.
        /// </summary>
        /// <param name="j">Jornada a agregar alumno.</param>
        /// <param name="a">Alumno a agregar.</param>
        /// <returns>Retorna la jornada con el alumno agregado o no.</returns>
        public static Jornada operator +(Jornada j,Alumno a)
        {
            if(j!=a)
            {
                j._alumnos.Add(a);
            }

            return j;
        }

        /// <summary>
        /// Sobrecarga de tostring.
        /// </summary>
        /// <returns>Todos los datos de la jornada.</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            
            retorno.AppendLine("\nJORNADA: \n\n CLASE: "+this._clase.ToString());
            retorno.AppendLine("Profesor: " + this._instructor.ToString());
            retorno.AppendLine("Alumnos: ");
            foreach (Alumno i in this._alumnos)
            {
                retorno.AppendLine(i.ToString());
            }

            retorno.AppendLine("---------------------------------------");
            retorno.AppendLine();

            return retorno.ToString();
        }

        #endregion

    }
}

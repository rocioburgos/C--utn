using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using Archivos;

namespace Clases.Instanciables
{

    [Serializable]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Jornada))]

    
    public class Universidad
    {
        public enum EClases { Programacion, Laboratorio, SPD, Legislacion }

        List<Alumno> _alumnos;
        List<Jornada> _jornada;
        List<Profesor> _profesores;


        
        #region Constructor

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Universidad()
        {
            this._alumnos = new List<Alumno>();
            this._jornada = new List<Jornada>();
            this._profesores = new List<Profesor>();
        }


        #endregion

        #region Propiedades

        /// <summary>
        /// Retorna una lista de Alumnos.
        /// Establece una lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        /// <summary>
        /// Retorna una lista de profesores.
        /// Establece una lista de profesores.
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return this._profesores; }
            set { this._profesores = value; }
        }

        /// <summary>
        /// Retorna una lista de jornadas.
        /// Establece una lista de jornadas.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return this._jornada; }
            set { this._jornada = value; }
        }
        
        /// <summary>
        /// Permite obtener o establecer una de la lista jornada.
        /// </summary>
        /// <param name="i">El indice de la lista.</param>
        /// <returns>Una jornada de la lista segun el indice.</returns>
        public Jornada this[int i]
        {
            get {
                if (i >= this._jornada.Count || i < 0)
                {
                    return null;
                }
                else
                {
                    return this._jornada[i];
                }

            }
            set { this._jornada[i] = value; }
        }



        #endregion

        #region metodos

        /// <summary>
        /// Guarda en un archivo XML.
        /// </summary>
        /// <param name="gim">La universidad que va a guardar.</param>
        /// <returns>True: si pudo guardar. False: si no pudo guardar.</returns>
        public static bool Guardar(Universidad gim)
        {
            bool retorno = false;

            Xml<Universidad> archivo = new Xml<Universidad>();
            retorno= archivo.Guardar(AppDomain.CurrentDomain.BaseDirectory + "\\universidad.xml", gim);

            return retorno;
        }

        /// <summary>
        /// Permite leer datos de un archivo XML.
        /// </summary>
        /// <returns>Lo que pudo leer del archivo.</returns>
        public static Universidad Leer()
        {
            Universidad retorno = new Universidad();
            Xml<Universidad> uni = new Xml<Universidad>();
            
            uni.Leer(AppDomain.CurrentDomain.BaseDirectory + "\\universidad.xml", out retorno );

            return retorno; 
        }

        /// <summary>
        /// Muestra todos los datos de una universidad.
        /// </summary>
        /// <param name="gim">La universidad de la cual se mostraran los datos.</param>
        /// <returns>Una cadena con los datos de la universidad.</returns>
        private string MostrarDatos(Universidad gim)
        {
           
            StringBuilder r = new StringBuilder();
           

            foreach (Jornada i in gim._jornada)
            {
                r.AppendFormat(i.ToString());
            }

          /*  r.AppendLine("Profesores: ");
            foreach (Profesor i in this._profesores)
            { r.AppendFormat(i.ToString()); }

            r.AppendLine("Alumnos: ");
            foreach (Alumno i in this._alumnos)
            { r.AppendFormat(i.ToString()); }

    */

            return r.ToString();
        }





        #endregion


        #region Sobrecargas

        /// <summary>
        /// Sobrecarga tostring.
        /// </summary>
        /// <returns>Retorna todos los datos de la universidad.</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Establece si una universidad es igual a un alumno.
        /// </summary>
        /// <param name="g">La universidad</param>
        /// <param name="a">El alumno.</param>
        /// <returns>True: Si alumno esta inscripto en la universidad. False: Si no se encuentra en la universidad.</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            foreach(Alumno alum in g._alumnos)
            {
                if(alum == a)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }


        /// <summary>
        /// Establece si una universidad es igual a un alumno.
        /// </summary>
        /// <param name="g">La universidad.</param>
        /// <param name="a">El alumno.</param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Establece si una universidad es igual a una clase.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns>El primer profesor que pueda dar la clase.Si no encuentra uno lanza una excepcion </returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            Profesor profesor= new Profesor();


            try
            {
                foreach(Profesor p in g._profesores)
                {
                    if(p==clase)
                    {
                       profesor = p;
                       break;
                    }
                }

            }
            catch(SinProfesorException e)
            {
            
                throw e.InnerException;
            }


           return profesor;
        }


        /// <summary>
        /// Permite establecer si una universidad es igual a una clase.
        /// </summary>
        /// <param name="g">La universidad.</param>
        /// <param name="clase">La clase. </param>
        /// <returns>El primer profesor que no pueda dar la clase.</returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            foreach(Profesor i in g._profesores)
            {
                if(i!=clase)
                {
                    return i;
                }
            }
            

            return null;
        }


        /// <summary>
        /// Establece si un profesor es igual a una universidad.
        /// </summary>
        /// <param name="g">La universidad.</param>
        /// <param name="i">El profesor.</param>
        /// <returns>True: Si el profesor esta en la universidad. False:Si el profesor no esta en la universidad .</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            bool retorno = false;
            foreach(Profesor profe in g._profesores)
            {
                if(profe ==i)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Establece si un profesor es distinto a una universidad.
        /// </summary>
        /// <param name="g">La universidad.</param>
        /// <param name="i">El profesor.</param>
        /// <returns>True: Si el profesor esta en la universidad. False:Si el profesor no esta en la universidad .</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Permite agregar un alumno a una universidad.
        /// </summary>
        /// <param name="g">La universidad.</param>
        /// <param name="a">El alumno.</param>
        /// <returns>La universidad.</returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if(g!=a)
            {
                g._alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }


            return g;
        }

        /// <summary>
        /// Agrega una clase a una universidad
        /// </summary>
        /// <param name="g">La universidad.</param>
        /// <param name="a">La clase.</param>
        /// <returns>La universidad.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profe= new Profesor();
            List<Alumno> alumnos = new List<Alumno>();
            bool hayProfe = false;
            foreach (Profesor i in g._profesores)
            {
                if(i== clase)
                {
                    profe = i;
                    hayProfe = true;
                    break;
                }
            }


            if(!hayProfe)
            {
                throw new SinProfesorException();
            }else
            {
                foreach(Alumno i in g._alumnos)
                {
                    if(i== clase)
                    {
                        alumnos.Add(i);
                    }
                }

              Jornada nuevaJornada = new Jornada(clase,profe);
              nuevaJornada.Alumnos = alumnos;
                g._jornada.Add(nuevaJornada);

            }

            return g;
        }

        /// <summary>
        /// Permite agregar un profesor a la universidad.
        /// </summary>
        /// <param name="g">La universidad.</param>
        /// <param name="i">El profesor.</param>
        /// <returns>La universida.</returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if(g!=i)
            {
                g._profesores.Add(i);
            }
            return g;
        }
        #endregion
    }
}

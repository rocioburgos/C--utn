using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using System.Text.RegularExpressions;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        public enum ENacionalidad { Argentino, Extranjero }

        string _nombre;
        string _apellido;
        int _dni;
        ENacionalidad _nacionalidad;

        #region Propiedades

        /// <summary>
        /// Permite establecer un apellido(string) validandolo primero.
        /// Retorna el apellido.
        /// </summary>
        public string Apellido
        { get { return this._apellido; }

            set { this._apellido = this.ValidarNombreApellid(value); }
        }

        /// <summary>
        /// Permite establecer un dni(int) validandolo primero.
        /// Retorna el dni.
        /// </summary>
        public int DNI
        {
            get { return this._dni; }

            set { this._dni = this.ValidarDni(this._nacionalidad, value); }
        }

        /// <summary>
        /// Permite establecer un nombre(string) validandolo primero.
        /// Retorna el nombre.
        /// </summary>
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = this.ValidarNombreApellid(value); }
        }

        /// <summary>
        /// Permite establecer una nacionalidad.
        /// Retorna la nacionalidad.
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set { this._nacionalidad = value; }
        }

        /// <summary>
        /// Permite establecer un dni(string) validandolo primero.
        /// </summary>
        public string StringToDNI
        {
           set  {this._dni = this.ValidarDni(this._nacionalidad, value);}
        }

        #endregion


    

        #region Constructores

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Persona()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad):this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">Dni del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido,int dni ,ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;   
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        /// <param name="dni">Dni del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion



        #region Sobrecarga

        /// <summary>
        /// Retorna todos los datos de la persona.
        /// </summary>
        /// <returns>Retorna todos los datos de la persona como string.</returns>
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            
            retorno.AppendLine("Nombre completo :"+this._apellido + ", " + this._nombre);
            retorno.Append("DNI: "+this._dni.ToString() + " Nacionalidad: " + this._nacionalidad.ToString());
           
            return retorno.ToString();
        }

        #endregion


        #region Validaciones

        /// <summary>
        /// Valida el dni segun la nacionalidad
        /// </summary>
        /// <param name="nacionalidad">La nacionalidad.</param>
        /// <param name="dato">El dni.</param>
        /// <returns>El dni si pasa la validacion. Lanza una excepcion de lo contrario.</returns>
        protected int ValidarDni(ENacionalidad nacionalidad, int dato)
        {

            if (nacionalidad == ENacionalidad.Argentino)
            {
                if (dato > 0 && dato < 89999999)
                {
                    return dato;
                } else
                {
                    throw new NacionalidadInvalidaException("No coincide con el DNI argentino");
                }

            }
            else if (nacionalidad == ENacionalidad.Extranjero)
            {

                if (dato > 89999999 && dato < 99999999)
                {
                    return dato;
                }
                else {
                    throw new NacionalidadInvalidaException();

                }
            }
            return dato;
        
        }

        /// <summary>
        /// Valida el dni segun la nacionalidad
        /// </summary>
        /// <param name="nacionalidad">La nacionalidad.</param>
        /// <param name="dato">El dni.</param>
        /// <returns>El dni si pasa la validacion. Lanza una excepcion de lo contrario.</returns>
        protected int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
           int retorno;

            
                if (int.TryParse(dato, out retorno))
                {
                    return this.ValidarDni(nacionalidad, retorno);
                }
            
           
             throw new DniInvalidoException("El DNI debe contener numeros solamente"); 
        }
        
        /// <summary>
        /// Valida que un apellido o nombre contenga solo letras.
        /// </summary>
        /// <param name="dato">El dato</param>
        /// <returns>El dato validado.</returns>
        protected string ValidarNombreApellid(string dato)
        {
            Regex expresion = new Regex("^[A-Za-z]+$");

           if(expresion.IsMatch(dato))
            {
                return dato;
            }
            return "";
        }

        #endregion



    }
}

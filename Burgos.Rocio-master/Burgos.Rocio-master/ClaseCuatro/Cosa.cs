using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseCuatro
{
    class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;
        public ConsoleColor color;




        /// <summary>
        /// Constructor que inicializa los valores por defecto.
        /// </summary>
        public Cosa()
        {
            this.entero = 0;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
            this.color = ConsoleColor.Gray;
        }






        /// <summary>
        /// Construtor que inicializa el entero con datos recibidos
        /// como parametros.
        /// </summary>
        /// <param name="numero">El numero a asignar.</param>
        public Cosa(int numero) : this()
        {
            this.entero = numero;

            //estas lineas se van xq reutilizamos codigo con el ":this()".

            /*this.cadena = "Sin valor";
            this.fecha = DateTime.Now;*/
        }







        /// <summary>
        /// Construtor que inicializa el entero y el string con datos recibidos
        /// como parametros.
        /// </summary>
        /// <param name="numero">El numero a asignar.</param>
        /// <param name="texto">El texto a asignar.</param>
        public Cosa(int numero, string texto) : this(numero)//primero llamo al constructor que me inicialice el numero y se lo paso como parametro.
        {
            //this.entero = numero;
            this.cadena = texto;
            //this.fecha = DateTime.Now;
        }



        /// <summary>
        /// Constructor completo, inicializa todos los valores.
        /// </summary>
        /// <param name="hoy">La fecha a asignar.</param>
        /// <param name="numero">El entero a asignar.</param>
        /// <param name="texto">El string a asignar.</param>
        public Cosa(DateTime hoy, int numero, string texto) : this(numero, texto)
        {
            this.fecha = hoy;
        }





        /// <summary>
        /// Asigna un valor a un entero del objeto.
        /// </summary>
        /// <param name="numero">El numero que sera asignado</param>
        public void EstablecerValor(int numero)
        {
            this.entero = numero;
        }


        /// <summary>
        /// Asigna un valor a un string del objeto.
        /// </summary>
        /// <param name="texto">El string que sera asignado.</param>
        public void EstablecerValor(string texto)
        {
            this.cadena = texto;
        }


        /// <summary>
        /// Asigna la fecha que recibe por parametro a un DateTime del objeto.
        /// </summary>
        /// <param name="time">Es la fecha a asignar.</param>
        public void EstablecerValor(DateTime time)
        {
            this.fecha = time;
        }

        public void EstablecerValor(ConsoleColor c)
        {
            this.color = c;
        }



        /// <summary>
        /// Concatena todos los datos del objeto y los retorna.
        /// </summary>
        /// <returns>Retorna la cadena con todos los datos que fueron recibidos.</returns>
        public string Mostrar()
        {
            Console.ForegroundColor = this.color;
            return "Entero: " + this.entero + " Texto: " + this.cadena + " Fecha: " + this.fecha + "Color " + this.color;
        }


    }
}

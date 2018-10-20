using System;

namespace Entidades
{
    public class Numero
    {
        private double _Numero;


        /// <summary>
        /// Constructor por defecto inicializa el atributo en 0.
        /// </summary>
        public Numero() : this(0)
        {

        }

        /// <summary>
        /// Constructor que carga el numero que recibe.
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this._Numero = numero;
        }



        /// <summary>
        ///Constructor que verifica que el string recibido como parametro sea un numero valido. 
        /// </summary>
        /// <param name="numeroString"></param>

        public Numero(string numeroString)
        {
            this.SetNumero(numeroString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetNumero()
        {
            return this._Numero;
        }

        /// <summary>
        /// Permite asignar un numero verificado como valor del atributo.
        /// </summary>
        /// <param name="numeroString"></param>
        private void SetNumero(string numeroString)
        {
            this._Numero = this.ValidarNumero(numeroString);

        }


        /// <summary>
        /// Permite validar que el string sea un numero valido y lo convierte a double.
        /// </summary>
        /// <param name="numeroString"></param>
        /// <returns></returns>
        private double ValidarNumero(string numeroString)
        {
            double numeroRetorno;

            if (double.TryParse(numeroString, out numeroRetorno) == false)
            {
                numeroRetorno = 0;
            }

            return numeroRetorno;
        }



    }
}

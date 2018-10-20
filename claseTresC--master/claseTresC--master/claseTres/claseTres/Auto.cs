using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    class Auto
    {


        //Creo los atributos, para que tengan alcance mas alla
        //de mi clase y poder usarla en el main.
        //Son de instancia, para cada objeto estos datos van a ser unicos.
        public string marca;
        public  string patente;
        public float precio;
        
        //Cada vez que se cree una instancia va a contar, y el valor tiene queser
        //el mismo durannte todo el desarollo del programa, por eso es static
        public static int cantidadDeInstancias;
        public static DateTime f_inicio;
        public static DateTime f_ultimo;
        
        
        
        //Generar de manera explicita el constructor,que por cada objeto incremente el contador.
        //Me permite inicializar los valores como yo quiero, sino quedan por default
        public Auto()
        {
            //obtengo la fecha de la primera instancia
           /* if (Auto.cantidadDeInstancias == 0)
            {
                Auto.f_inicio = DateTime.Now;
            }
            */
            Auto.cantidadDeInstancias++;
           
            Auto.f_ultimo = DateTime.Now;
        }
        //Constructor estatico se ejecuta una sola vez y antes que el de instancia.
        //Cuando termina de pasar por aca, pasa al de instancia.
        static Auto()
        {
            Auto.f_inicio = DateTime.Now;
           
        }
        
        
        
        
        //Es un metodo de instancia, como en el main se crea el objeto
        //se lo puede usar.
        //El this solo se puede usar en metodos de instacia, no en estaticos.
        //public string Mostrar() Se cambio la visibilidad a privado
        private string Mostrar()
        {
            string texto = "Marca:" + this.marca + "\nPatente:" + this.patente + "\nPrecio:" + this.precio;//El this para saber que se esta refiriendo al objeto
            
            return texto;
        }

        
        
        
        
        
        //Al ser estatico no puedo usar el this, y tengo que recibir los parametros.
        public static string Mostrar(Auto auto)
        {

            return auto.Mostrar();
        }


    }
}

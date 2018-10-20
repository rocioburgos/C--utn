using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaUno
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaro una variable del tipo persona(nueva clase)
            persona unaPersona = new persona();//constructor new, inicia nuestro objeto por defcto

            //llamo al metodo directamente desde el nombre de la clase
            //porque ese metodo es stactic
            persona.Saludar();

            //llamo al metodo con el objeto que cree, y ahora al ser una isntancia
            //me permite acceder a todos los metodos
            unaPersona.SaludaDos();


            Console.ReadKey();

        }
    }


}

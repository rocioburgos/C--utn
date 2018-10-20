using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseTres
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objetos por defecto.
            Auto a1 = new Auto();
            Auto a2 = new Auto();
            TimeSpan pasaron;



            //Inicializar los atributos de mi objeto
            a1.marca = "Fiat";
            a1.patente = "A001";
            a1.precio = 130000;

            a2.marca = "Ford";
            a2.patente = "B00Z";
            a2.precio = 80000;


            /* Console.WriteLine(a1.Mostrar());
             Console.WriteLine();
             Console.WriteLine(a2.Mostrar()); 
             Console.WriteLine();*/

            //Le asigno la instancia a2 a a1, porque son del mismo tipo se puede hacer.
            //Si tienen los mismos atributos pero de distinta clase no se puede hacer.

            a1 = a2;
            //Los dos tienen los mismos datos, si cambio atraves de uno algun dato
            //va a cambiar el dato para los dos.
            a1.marca = "Renault";
            /* Console.WriteLine(a1.Mostrar());
             Console.WriteLine();
             Console.WriteLine(a2.Mostrar());*/



            //Ahora modificamos el metodo de instancia Mostar() a privado,
            //y creamos un metodo de clase que recibe un auto, ahora se accede
            //al metodo atraves de la clase
            //Se accede siempre desde la clase xq es static
            Console.WriteLine(Auto.Mostrar(a1));
            Console.WriteLine(Auto.Mostrar(a2));

            Console.WriteLine("Cantidad de instancias: " + Auto.cantidadDeInstancias);
            Console.WriteLine("Const. Static: fecha primer instancia: {0}:{1}:{2}", Auto.f_inicio.Hour, Auto.f_inicio.Minute, Auto.f_inicio.Millisecond);
            Console.WriteLine("fecha ultima instancia: {0}:{1}:{2}", Auto.f_ultimo.Hour, Auto.f_ultimo.Minute, Auto.f_ultimo.Millisecond);
            pasaron = Auto.f_ultimo - Auto.f_inicio;
            Console.WriteLine("Pasaron " + pasaron.TotalMilliseconds + "milisegundos");


            Console.ReadKey();

        }
    }
}

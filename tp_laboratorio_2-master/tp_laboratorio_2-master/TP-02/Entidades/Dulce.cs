using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {
#region Constructor
        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param marca=Marca del producto> </param>
        /// <param patente=codigo de barras del producto></param>
        /// <param color=color del paquete></param>
        public Dulce(EMarca marca, string patente, ConsoleColor color):base(patente,marca,color)
        {

        }
        #endregion

#region Propiedad
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        #endregion

#region Metodo
    
        /// <summary>
        /// Permite mostrar los detalles del producto.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat(" CALORIAS : {0} ",this.CantidadCalorias.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

#endregion
    }
}

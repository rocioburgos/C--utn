using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Snacks: Producto
    {
        #region Constructor 

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param marca=Marca del producto> </param>
        /// <param patente=codigo de barras del producto></param>
        /// <param color=color del paquete></param>
        public Snacks(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
        }
        #endregion


#region Propiedades y metodos

        /// <summary>
        /// Los snacks tienen 104 calorías.
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        /// <summary>
        /// Permite mostrar un producto con todos sus detalles.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0} ", this.CantidadCalorias.ToString());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
#endregion
    }
}

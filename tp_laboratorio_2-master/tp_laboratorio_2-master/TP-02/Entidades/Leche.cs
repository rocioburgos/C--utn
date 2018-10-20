using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
   public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo _tipo;
       
        #region Constructores
      
        
        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param patente=codigo de barras del producto></param>
        /// <param color=color del paquete></param>
        public Leche(EMarca marca, string patente, ConsoleColor color):this(marca,patente,color,ETipo.Entera)
        {
          
        }



        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param marca=Marca del producto> </param>
        /// <param patente=codigo de barras del producto></param>
        /// <param color=color del paquete></param>
        /// <param tipo=Entera o Descremada></param>
        public Leche(EMarca marca, string codigo, ConsoleColor color, ETipo tipo):base(codigo, marca, color)
        {
            this._tipo = tipo;
        }



        #endregion

#region Propiedades y metodos
      
        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }



        /// <summary>
        /// Muestra todos los detalles de un producto.
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0} ",this.CantidadCalorias.ToString());
            sb.AppendFormat(" TIPO : {0} " , this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
#endregion
    }
}

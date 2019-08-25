using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{

    public class Snacks : Producto
    {

        #region Propiedades
        
        /// <summary>
        /// Propiedad que establece la cantidad de calorias en 104.
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        #endregion

        #region Constructores
        
        /// <summary>
        /// Constructor que inicializa los tres parametros de un producto de tipo Snack
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="color"></param>
        public Snacks(EMarca marca, string codigo, ConsoleColor color) : base(codigo, marca, color)
        {

        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra el contenido de un producto de tipo Snack.
        /// </summary>
        /// <returns> Retorna un string con los datos de Snack </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS: {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}

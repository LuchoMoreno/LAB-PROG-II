using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    public class Dulce : Producto
    {

        #region Propiedades

        /// <summary>
        /// Propiedad que establece que los dulces tienen 80 calorias.
        /// </summary>
        protected override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        #endregion


        #region Constructores

        /// <summary>
        /// Constructor que se encarga de inicializar los parametros de un producto de tipo dulce
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="patente"></param>
        /// <param name="color"></param>
        public Dulce(EMarca marca, string codigo, ConsoleColor color) : base (codigo, marca, color)
        {

        }

        #endregion


        #region Metodos
        /// <summary>
        /// Muestra el contenido de un producto de tipo dulce.
        /// </summary>
        /// <returns> Retorna un string con los datos </returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion

    }


}

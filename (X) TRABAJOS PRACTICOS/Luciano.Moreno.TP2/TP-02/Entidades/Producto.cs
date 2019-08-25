using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2018
{
    /// <summary>
    /// La clase Producto no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto
    {

        #region Enumerados

        /// <summary>
        /// Enumerado.
        /// </summary>
        public enum EMarca
        {
            Serenisima,
            Campagnola,
            Arcor,
            Ilolay,
            Sancor,
            Pepsico
        }

        #endregion


        #region Atributos

        private EMarca marca;       // Marca privada
        private string codigoDeBarras;  // Codigo privado.
        private ConsoleColor colorPrimarioEmpaque;  // Color Empaque privado.

        #endregion


        #region Constructores

        /// <summary>
        /// Constructor que inicializa 
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="color"></param>
        public Producto(string codigo, EMarca marca, ConsoleColor color)
        {
            this.codigoDeBarras = codigo;
            this.colorPrimarioEmpaque = color;
            this.marca = marca;
        }

        #endregion


        #region Propiedades
        /// <summary>
        /// ReadOnly: Propiedad de solo escritorura que retorna la cantidad de calorias.
        /// </summary>
        protected abstract short CantidadCalorias { get;}

        #endregion


        #region Metodos
        /// <summary>
        /// Muestra todos los datos del producto.
        /// </summary>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

   
        #region Operadores

        /// <summary>
        /// Devuelve todos los datos de un producto en formato string.
        /// </summary>
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CODIGO DE BARRAS: {0}\r\n", p.codigoDeBarras);
            sb.AppendFormat("MARCA          : {0}\r\n", p.marca.ToString());
            sb.AppendFormat("COLOR EMPAQUE  : {0}\r\n", p.colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (p1.codigoDeBarras == p2.codigoDeBarras)
            {
                retorno = true;
            }
            return retorno;
        }
      
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        #endregion
    }

}

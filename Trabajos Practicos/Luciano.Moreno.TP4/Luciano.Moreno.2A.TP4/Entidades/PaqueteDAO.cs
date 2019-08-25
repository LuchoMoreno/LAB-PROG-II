using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Añade las clases de .SQLCLIENT.
using System.Data; // Añáde clases de .Data.

namespace Entidades
{
    public static class PaqueteDAO
    {

        #region Atributos

        // Atributo para comandos.
        private static SqlCommand comando;
        // Atributo para conexiones.
        private static SqlConnection conexion;

        #endregion


        #region Constructores

        static PaqueteDAO()
        {
            comando = new SqlCommand();
            conexion = new SqlConnection(Properties.Settings.Default.conexion);
            comando.Connection = conexion;
        }

        #endregion


        #region Metodos

        /// <summary>
        /// Inserta un PAQUTE en la base de datos (correo-sp-2017)
        /// </summary>
        /// <param name="p"> Objeto que se va a insertar </param>
        /// <returns> True -> Se insertó el objeto / False -> No se insertó </returns>

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;
            comando.CommandText = string.Format("INSERT INTO Paquetes values ('{0}','{1}','{2}')", p.DireccionEntrega, p.TrackingID, "Luciano Moreno");
            comando.CommandType = System.Data.CommandType.Text;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                retorno = true;
            }
            catch (Exception e)
            {
                // Acá va el mensaje de excepcion.
           
                throw e;
            }

            finally
            {
                conexion.Close();
            }
            return retorno;
        }

        #endregion

    }
}

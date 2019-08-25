using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardarString
    {

        /// <summary>
        /// Guarda un archivo de texto, en la ubicacion escritorio (Por default)
        /// </summary>
        /// <param name="texto"> Texto que se va a guardar </param>
        /// <param name="archivo"> PATH del archivo </param>
        /// <returns> TRUE -> Se pudo guardar / False -> No se pudo guardar </returns>

        public static bool Guardar(this string texto, string archivo)
        {
            bool retorno = true;
            string direccion = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo;

            try
            {
                if (File.Exists(direccion))
                {
                    using (StreamWriter sw = new StreamWriter(direccion, true))
                    {
                        sw.WriteLine(texto);
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(direccion, false))
                    {
                        sw.WriteLine(texto);
                    }
                }
            }
            catch (Exception e)
            {
                // Si fuera consola, acá mostría el mensaje.
                // console.WriteLine(e.Message);
                retorno = false;

            }
            return retorno;
        }

    }
}

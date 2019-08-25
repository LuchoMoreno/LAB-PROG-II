using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        #region Constructores
        public ArchivosException(Exception innerExcepcion) : base("ERROR en el archivo. ", innerExcepcion)
        {
        }
        #endregion

    }
}

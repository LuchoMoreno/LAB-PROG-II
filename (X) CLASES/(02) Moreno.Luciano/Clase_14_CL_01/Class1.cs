using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_CL_01
{
    public static class ParseadoraDeEnteros
  {


    public static int Parse (string dato)
    {
      int resultado = 0;

      try
      {
        resultado = Int32.Parse(dato);
      }

      catch (FormatException e)
      {
        throw new ErrorParserException(e.Message + "por error de formato");


      }
      catch (OverflowException e)
      {
        throw new ErrorParserException(e.Message + "por tamaño del dato");

      }

      return resultado;
    }



    public static bool TryParse(string dato, out int salida)
    {

      bool resultado = false;
      salida = 0;
      try
      {
        salida = Parse(dato);
        return true;
      }
      catch (Exception)
      {

        resultado = false;
      }

      return resultado;
    }



  }
}

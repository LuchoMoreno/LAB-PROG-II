using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria; // ESTO ES EL USING QUE UTILIZO, PORQUE PREVIAMENTE METI EL .DLL

namespace Clase_03_E_02
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(prueba.saludar()); //prueba es el nombre del .dll, y saludar es el metodo.

      Console.ReadLine();

    }
  }
}

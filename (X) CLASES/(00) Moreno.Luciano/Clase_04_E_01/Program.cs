using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04_CL_01;

namespace Clase_04_E_01
{
  class Program
  {
    static void Main(string[] args)
    {

      cosa objeto0 = new cosa();
      Console.WriteLine(objeto0.Mostrar());

      cosa objeto1 = new cosa(8);
      Console.WriteLine(objeto1.Mostrar());

      cosa objeto2 = new cosa(8, new DateTime(2000,05,10));
      Console.WriteLine(objeto2.Mostrar());

      cosa objeto3 = new cosa(8, "Lucho", new DateTime(2000, 05, 10));
      Console.WriteLine(objeto3.Mostrar());



      Console.WriteLine();
      objeto1.EstablecerValor(3);
      objeto1.EstablecerValor("Hola");
      objeto1.EstablecerValor(DateTime.Now);

      Console.WriteLine(objeto1.Mostrar());
     
      Console.ReadLine();

    }
  }
}

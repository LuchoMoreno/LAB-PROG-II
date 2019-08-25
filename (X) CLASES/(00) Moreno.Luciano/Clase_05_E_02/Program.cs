using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05_CL_01;


namespace Clase_05_E_02
{
  class Program
  {
    static void Main(string[] args)
    {

      tinta t1 = new tinta();
      tinta t2 = new tinta(ConsoleColor.Blue);
      tinta t3 = new tinta(ConsoleColor.Red, ETipoTinta.ConBrillito);
      tinta t4 = new tinta();


      if (t1.Equals(t4)) //ACA ES CUANDO APUNTAN A LA MISMA DIRECCION DEL HEAP
      { Console.WriteLine("Son iguales"); }

      else
      { Console.WriteLine("No son iguales"); }


      if (t1 == t3) //ACA ES CUANDO SON IGUALES
      { Console.WriteLine("Son iguales"); }

      else
      { Console.WriteLine("No son iguales"); }

      if (t1 == t1)
      { Console.WriteLine("Son iguales"); }

      else
      { Console.WriteLine("No son iguales"); }


      pluma pluma1 = new pluma("BIC", t1, 20);
      Console.WriteLine();

      string s = (string)pluma1;
      Console.ReadLine();
    }



  }
}

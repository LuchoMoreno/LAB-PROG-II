using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using spaceBoligrafo;

namespace Ejercicio_17
{
  class Program
  {
    static void Main(string[] args)
    {
            short tintaAzul = 100;
            short tintaRoja = 100;


            // Primer manera.
            Boligrafo boligrafoRojo;
            boligrafoRojo = new Boligrafo(tintaRoja, ConsoleColor.Red);

      
            // Segunda manera.
            Boligrafo boligrafoAzul = new Boligrafo(tintaAzul, ConsoleColor.Blue);



        }
  }
}

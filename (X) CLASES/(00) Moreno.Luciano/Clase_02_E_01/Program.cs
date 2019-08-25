using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02_E_01
{
    class Program
    {
        static void Main(string[] args)
        {



            Sello.color = ConsoleColor.Red;
            Sello.mensaje = "Hola";


            Sello.ImprimirEnColor();
            Console.WriteLine(Sello.Imprimir());


          

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre;

            Console.Write("Ingrese su nombre: "); //printf
            nombre = Console.ReadLine(); //devuelve un string. Toma hasta que se ingresa enter

            Console.WriteLine("El nombre ingresado es :{0}", nombre);
            Console.ReadKey();
        }
    }
}

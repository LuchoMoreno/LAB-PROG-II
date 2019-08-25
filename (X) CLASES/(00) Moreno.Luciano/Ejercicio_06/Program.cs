using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             * 6. Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4. 
             * Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. 
             * Por ejemplo: el año 2000 es bisiesto pero 1900 no. Pedirle al usuario un año de inicio y otro de fin y mostrar 
             * todos los años bisiestos en ese rango. Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). 
             *
             */

            Console.Title = "Ejercicio_06";

            Int32 añoIngresadoInicio;
            Int32 añoIngresadoFinal;
            Int32 contadorAnios = 0;


            Console.Write("Ingrese un año inicial para calcular: ");
            añoIngresadoInicio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese un año final para calcular: ");
            añoIngresadoFinal = int.Parse(Console.ReadLine());


            if (añoIngresadoInicio > añoIngresadoFinal)
            {
                Console.WriteLine("ERROR! El año inicial no puede ser mayor al año final");
            }

            else
            {

                for (int i=añoIngresadoInicio; i<= añoIngresadoFinal; i++)
                {
                        if ((i % 4) == 0 && (i % 100 != 0 || i % 400 == 0))
                         {
                             Console.Write("{0,7:#,###}", i);
                             contadorAnios++;

                                if (contadorAnios == 10)
                                {Console.WriteLine("\n"); contadorAnios = 0;}
                         }
                }

            }

            Console.ReadLine();
        }
    }
}

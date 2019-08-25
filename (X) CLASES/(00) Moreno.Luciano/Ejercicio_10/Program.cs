using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
              Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla una pirámide como la siguiente: 
 
                           * 
                          ***
                         ******
                        ********
                       ********** 
           */

            string mensajeConFormato = "";
            int largoPiramide;
            int i;


            Console.Write("Ingrese el largo de la piramide: ");
            largoPiramide = int.Parse(Console.ReadLine());

            for (i = 1; i <= largoPiramide; i++)
            {
                for (int espacios = 0; espacios < (largoPiramide - i); espacios++)
                {
                    Console.Write(" ");
                }

                for (int asteriscos = 0; asteriscos < (i * 2) - 1; asteriscos++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Escribir un programa que imprima por pantalla una pirámide como la siguiente: 
             * * 
             * *** 
             * ***** 
             * ******* 
             * ********* 
             */

            string mensajeConFormato = "";
            int largoPiramide;
            int i;


            Console.Write("Ingrese el largo de la piramide: ");
            largoPiramide = int.Parse(Console.ReadLine());

            for (i = 0; i < largoPiramide * 2; i++)
            {
                mensajeConFormato += "*";
                if (i % 2 == 0)
                { Console.WriteLine(mensajeConFormato); }

            }

            Console.ReadLine();
        }
    }
}


/****
    for (i = 1; i <= largoPiramide; i++)
            {
                for (int j = 0; j<(i* 2) - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
*/



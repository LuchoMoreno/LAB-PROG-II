using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             * 5. Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en 
             * dos grupos de números, cuyas sumas son iguales. El primer centro numérico es el 6, el cual separa la lista (1 a 8) 
             * en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
             * 
             * El segundo centro numérico es el 35, 
             * el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. 
             * 
             * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.
             * Nota: Utilizar estructuras repetitivas y selectivas. 
             */

            Console.Title = "Ejercicio_05";


            Int32 numeroMaximo;
            Int32 acumuladorNegativos = 0;
            Int32 acumuladorPositivos = 0;
            Int32 auxiliarAcumuladorPositivos = 0;

            //numeroMaximo = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Ingrese un numero maximo hasta el cual se veran los centros numericos: ");
            numeroMaximo = int.Parse(Console.ReadLine());

            if (numeroMaximo < 1)
            { Console.WriteLine("Error. Usted debe ingresar 1 o mayor.");}

            else
            {

                for (int i = 1; i<=numeroMaximo; i++)
                {
                    for (int j = 1; j<i; j++)
                    {
                        acumuladorNegativos = acumuladorNegativos + j;
                    }

                    acumuladorPositivos = i + 1;
                    auxiliarAcumuladorPositivos = i + 1;

                    while (acumuladorNegativos >= acumuladorPositivos)
                    {

                        if (acumuladorNegativos == acumuladorPositivos)
                        {
                            Console.WriteLine("Grupo *** Centro numerico: 1..." + (i-1) +" |"+i+"| "+(i+1)+"..."+auxiliarAcumuladorPositivos);
                            break;
                        }

                        else
                        {
                            auxiliarAcumuladorPositivos = auxiliarAcumuladorPositivos + 1;
                            acumuladorPositivos = acumuladorPositivos + auxiliarAcumuladorPositivos;
                        }
                    }

                    acumuladorNegativos = 0;
                    auxiliarAcumuladorPositivos = 0;
                    acumuladorPositivos = 0;

                }

                

            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             *4. Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
                (excluido el mismo) que son divisores del número.
                El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
                Escribir una aplicación que encuentre los 4 primeros números perfectos.
                Nota: Utilizar estructuras repetitivas y selectivas.
            */


            Console.Title = "Ejercicio_04";

            int contadorNumerosPerfectos = 0;
            int acumulador = 0;

            Console.Title = "EjercicioNro_04";

            while (contadorNumerosPerfectos < 4)
            {
                for (int i = 0; ; i++)
                {
                    for (int j = 1; j<i; j++)
                    {
                        if (i % j == 0)
                          {
                            acumulador = acumulador + j;
                          }
                    }

                    if (acumulador == i)
                         {
                            if (contadorNumerosPerfectos == 0)
                            {
                                Console.WriteLine("Los primeros 4 numeros perfectos son: \n");
                            }

                            Console.WriteLine("{0:#,###}", i);
                            contadorNumerosPerfectos++;
                         }

                    acumulador = 0;
                    i++;
                }
  
            }

            Console.ReadKey();

        }
    }
        
}

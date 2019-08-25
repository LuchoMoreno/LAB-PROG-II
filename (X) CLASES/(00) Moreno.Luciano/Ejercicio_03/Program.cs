using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             * 3. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola. 
             * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%). 
            */
           

            Console.Title = "Ejercicio_03";

            Int32 numeroIngresado;
            Int32 contador = 0;
            string auxNumeroIngresado;


            Console.WriteLine("Ingrese un numero:");
            auxNumeroIngresado = Console.ReadLine();
            numeroIngresado = int.Parse(auxNumeroIngresado);


            /** Tambien podria ser: 
             *  int numero;
             *  numero = int.Parse(Console.ReadLine());
            */


            if (numeroIngresado <= 1)
            {
                if (numeroIngresado == 1)
                {
                    Console.WriteLine("1 No es considerado un numero primo!. ");
                }
                else
                {
                    Console.WriteLine("Los numeros por debajo de 1 no son primos!. ");
                }

            }

            for (int i=2; i<=numeroIngresado; i++)
            {
                for (int j=1; j<=i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }

                 if (contador == 2)
                    {
                    Console.WriteLine("{0:#,###.00}", i);
                    }

                contador = 0;
            }

            Console.ReadLine();
        }
    }
}

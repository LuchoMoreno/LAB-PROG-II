using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {

            /***
             *1. Ingresar 5 números por consola, guardándolos en una variable escalar. 
             * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio. 
             */


            Console.Title = "Ejercicio_01";

            string auxNumero;
            Int32 contadorNumeros = 0;
            Int32 numero;
            Int32 minimo = 0;
            Int32 maximo = 0;
            Int32 acumulador = 0;
            float promedio = 0;
            
            do
            {
                contadorNumeros++;

                Console.WriteLine("Ingrese un numero:");
                auxNumero = Console.ReadLine();
                numero=int.Parse(auxNumero);

                if (contadorNumeros == 1)
                {
                    minimo = numero;
                    maximo = numero;
                }
                
            
                    if (numero<minimo)
                    {
                        minimo = numero;
                    }

                    if (numero>maximo)
                    {
                       maximo = numero;
                    }


                acumulador = numero + acumulador;

            } while (contadorNumeros != 5);

            promedio = (float)acumulador / 5;


            Console.WriteLine("El numero minimo es: {0:#,###.00}", minimo);
            Console.WriteLine("El numero maximo es: {0:#,###.00}", maximo);
            Console.WriteLine("El promedio de numeros es: {0:#,###.00}", promedio);
            Console.ReadKey();
        }
    }
}

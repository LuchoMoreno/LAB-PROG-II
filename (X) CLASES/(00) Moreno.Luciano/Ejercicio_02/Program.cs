using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {

            /***
             * 2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea 
             * mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!". 
             * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
             */


            Console.Title = "Ejercicio_02";

            string auxNumero;
            Int32 numero;
            double cuadrado = 0;
            double cubo = 0;


            Console.WriteLine("Ingrese un numero:");
            auxNumero = Console.ReadLine();
            numero = int.Parse(auxNumero);

            if (numero <= 0)
            {
                Console.WriteLine("Error!");
            }

            else
            {
                cuadrado = Math.Pow(numero, 2);
                cubo = Math.Pow(numero, 3);
            }

            Console.WriteLine("El numero elegido es: {0:#,###.00}", numero);
            Console.WriteLine("El cuadrado es : {0:#,###.00}", cuadrado);
            Console.WriteLine("El cubo es : {0:#,###.00}", cubo);
            Console.ReadKey();

        
        }
    }
}

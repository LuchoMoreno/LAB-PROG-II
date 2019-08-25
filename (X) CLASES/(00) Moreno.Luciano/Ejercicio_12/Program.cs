using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de un mensaje 
             *  "¿Continuar? (S/N)". 
             *  En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones. 
             *  El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. 
             *
             */
            char rta;
            bool validadorRTA;
            Int32 contador = 0;
            Int32 numeroIngresado;
            Int32 acumulador = 0;
            

            do {


                Console.Write("Ingrese el numero {0}: ", contador);
                numeroIngresado = int.Parse(Console.ReadLine());

                acumulador = acumulador + numeroIngresado;

                Console.Write("Desea continuar? : ");
                rta = Convert.ToChar(Console.ReadLine());
                validadorRTA = validarRespuesta.ValidaS_N(rta);

                contador++;

            } while (validadorRTA == true);



            Console.WriteLine("\nLa suma es: {0}", acumulador);
            Console.ReadLine();

        }
    }


    class validarRespuesta
    {
        public static bool ValidaS_N(char c)
        {

            bool validar = false;

            if (c == 's' || c == 'S')
            {
                validar = true;
            }

            return validar;
        }

    }
}
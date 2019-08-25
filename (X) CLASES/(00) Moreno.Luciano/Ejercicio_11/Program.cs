using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

             //* 11. Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100. 
             //* Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar, 
             //* que posea la siguiente firma: bool Validar(int valor, int min, int max): 
             //* a. valor: dato a validar 
             //* b. min y max: rango en el cual deberá estar la variable valor. 
             //*
             //* Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
            
            

            Int32 numeroIngresado;
            bool validando;
            Int32 contador = 0;
            Int32 maximo = 0;
            Int32 minimo = 0;
            Int32 acumulador = 0;
            float promedio = 0;

            for (int i = 0; i<10; i++)
            {

                Console.Write("Ingrese el numero {0}: ", i);
                numeroIngresado = int.Parse(Console.ReadLine());

                validando = Validacion.Validar(numeroIngresado, -100, 100);

                while (validando == false)
                {
                    Console.Write("Error. Ingrese el numero {0}: ", i);
                    numeroIngresado = int.Parse(Console.ReadLine());
                }

                contador++;

                if (contador == 1)
                {
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;
                }

                if (numeroIngresado > maximo)
                { maximo = numeroIngresado; }

                if (numeroIngresado < minimo)
                { minimo = numeroIngresado; }


                acumulador = acumulador + numeroIngresado;
                promedio = (acumulador / 10);
            }

            Console.WriteLine("El numero maximo es {0}: ", maximo);
            Console.WriteLine("El numero mimino es {0}: ", minimo);
            Console.WriteLine("El promedio es {0:#.00}: ", promedio);


            Console.ReadLine();
        }
    }



    public class Validacion
    {

        public static bool Validar(int valor, int min, int max)
        {
            bool validador = false;

            if (valor > min && valor < max)
            { validador = true; }

            return validador;
        }

    }


}

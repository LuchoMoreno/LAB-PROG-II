using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y calcule 
             * el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now). 
             * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos. 
             * 
             */

            int dia;
            int mes;
            int año;
            int actual;


            DateTime fechaNacimiento;
            DateTime fechaActual = DateTime.Today;


            Console.Write("Ingrese dia de nacimiento: ");
            dia = int.Parse(Console.ReadLine());
            while (dia<0 || dia>31)
            {
                Console.Write("Ingrese dia de nacimiento: ");
                dia = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese mes de nacimiento: ");
            mes = int.Parse(Console.ReadLine());
            while (mes<0 || mes>12)
            {
                Console.Write("Ingrese mes de nacimiento: ");
                mes = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese año de nacimiento: ");
            año = int.Parse(Console.ReadLine());
            while (año>DateTime.Now.Year)
            {
                Console.Write("Ingrese año de nacimiento: ");
                año = int.Parse(Console.ReadLine());
            }


            fechaNacimiento = new DateTime(año, mes, dia);
            actual = fechaActual.Subtract(fechaNacimiento).Days;


            Console.WriteLine("Fecha nacimiento: " + dia + "/" + mes + "/" + año);
            Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(">>> {0:#,###} dias de vida.", actual);

            Console.ReadLine();



        }
    }
}

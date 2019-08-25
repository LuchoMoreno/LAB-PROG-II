using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03_E_01
{
  class Program
  {
    static void Main(string[] args)
    {
            LibreriaClases objeto1;
            objeto1 = new LibreriaClases(18, "Lucho");

            // entonces, ahora yo puedo usar writelines, y me va a mostrar los parametros.

            Console.WriteLine("El nombre es: {0}" + ", y la edad es: {1}", objeto1.nombre, objeto1.edad);
            Console.ReadLine();


            //TAMBIEN SE PUEDE DEFINIR TODO EN UNA LINEA:
            LibreriaClases objeto2 = new LibreriaClases(20, "Alguien");
            Console.WriteLine("El nombre es: {0}" + ", y la edad es: {1}", objeto2.nombre, objeto2.edad);
            Console.ReadLine();


            // Y PARA MOSTRAR LOS ATRIBUTOS ESTATICOS, SERAN SIEMPRE LOS MISMOS EN CUALQUIER OBJETO.
            // SE ACCEDE DIRECTAMENTE DESDE EL NOMBRE DE LA LIBRERIA.

            Console.WriteLine("La fecha estatica es: {0}", LibreriaClases.fecha);
            Console.WriteLine("El numero estatico es: {0}", LibreriaClases.numero);
            Console.ReadLine();

        }
  }
}

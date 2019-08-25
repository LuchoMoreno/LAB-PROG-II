using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03_E_01
{
    public class LibreriaClases
    {

        public static int numero;       //ESTATICO      
        public static DateTime fecha;   //ESTATICO

        public string nombre;           //NO ESTATICO
        public int edad;                //NO ESTATICO   


        public LibreriaClases(int edadParametro, string nombreParametro) //CONSTRUCTOR NO ESTATICO
        {
            this.nombre = nombreParametro;
            this.edad = edadParametro;

        }

        static LibreriaClases() // CONSTRUCTOR ESTATICO
        {
            LibreriaClases.fecha = DateTime.Now;
            LibreriaClases.numero = 5;
        }




    }
}

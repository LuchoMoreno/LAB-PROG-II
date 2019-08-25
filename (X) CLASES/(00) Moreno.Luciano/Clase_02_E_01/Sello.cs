using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02_E_01
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;



        public static string Imprimir()
        { 
            return Sello.ArmarFormatoMensaje();
        }


        public static void Borrar()
        {
            Sello.mensaje = " ";
        }


        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());

            Console.ForegroundColor = ConsoleColor.DarkGray;

        }

        private static string ArmarFormatoMensaje()
        {
            string mensajeConFormato = "";
            int largoMensaje;
            int i;

            largoMensaje = Sello.mensaje.Length + 2;
            
            for (i=0; i<largoMensaje; i++)
            {

                mensajeConFormato += "*";

            }
            mensajeConFormato += "\n*" + mensaje + "*\n" + mensajeConFormato;

  
            return mensajeConFormato;
        }

    }
}

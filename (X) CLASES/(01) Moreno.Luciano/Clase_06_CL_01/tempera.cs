using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06_CL_01
{
    public class Tempera
    {

        private ConsoleColor _color;
        private string _marca;
        private SByte _cantidad;


        public ConsoleColor Color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }


        public string Marca
        {
            get
            {
                return this._marca;
            }
            set
            {
                this._marca = value;
            }
        }


        public sbyte CantidadMaxima
        {
            get
            {
                return this._cantidad;
            }
            set
            {
                this._cantidad = value;
            }
        }


        //*********************************************** CONSTUCTOR
        public Tempera(ConsoleColor colorParametro, string marcaParametro, SByte cantidadParametro)
        {
            this._color = colorParametro;
            this._marca = marcaParametro;
            this._cantidad = cantidadParametro;
        }



        //*********************************************** MOSTRAR
        private string Mostrar()
        {
            return this._color.ToString() + "--" + this._marca.ToString() + "--" + this._cantidad.ToString();
        }


        static public string Mostrar(Tempera tipoTempera)
        {
            if (!Equals(tipoTempera,null))
            {
                return tipoTempera.Mostrar();   
            }
            else
            {
                return " ";
            }
                 
        }



        public static bool operator == (Tempera tempera1, Tempera tempera2)
        {
            if (!Equals(tempera1, null) && !Equals(tempera2, null))
            {
                if (tempera1._color == tempera2._color)
                {
                    if (tempera1._marca == tempera2._marca)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public static bool operator != (Tempera tempera1, Tempera tempera2)
        {
       
            return !(tempera1 == tempera2);
        }

    

     
        public static Tempera operator + (Tempera temperaParametro, SByte cantidadParametro)
        {
            temperaParametro._cantidad += cantidadParametro;
            return temperaParametro;
           
        }

        public static Tempera operator +(Tempera temperaParametro, Tempera temperaParametro2)
        {

            if (temperaParametro == temperaParametro2) // Aca verifica que sean iguales. Al pasar 2 parametros de tipo tempera, directamente acude a la funcion.
            {
                temperaParametro._cantidad += temperaParametro2; // Aca llama a la sobrecarga + que utiliza un parametro TEMPERA / SBYTE.
            }

            return temperaParametro;
        }


    public static Tempera operator -(Tempera temperaParametro, SByte cantidadParametro)
    {
      temperaParametro._cantidad -= cantidadParametro;
      return temperaParametro;

    }

    public static Tempera operator -(Tempera temperaParametro, Tempera temperaParametro2)
    {

      if (temperaParametro == temperaParametro2) // Aca verifica que sean iguales. Al pasar 2 parametros de tipo tempera, directamente acude a la funcion.
      {
        temperaParametro -= temperaParametro2._cantidad; // Aca llama a la sobrecarga - que utiliza un parametro TEMPERA / SBYTE.
      }

      return temperaParametro;
    }


    public static implicit operator sbyte (Tempera temperaParametro)
        {
            if (!Equals(temperaParametro, null))
            {
                return temperaParametro._cantidad;
            }

            return 0;  
        }

    }
}

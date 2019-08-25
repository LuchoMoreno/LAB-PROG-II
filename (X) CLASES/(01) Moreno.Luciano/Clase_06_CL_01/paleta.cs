using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_06_CL_01
{
    public class Paleta
    {
        private Tempera[] _tempera;
        private int _cantidadMaxima;

  

        public Tempera[] temperas { get
      {
        return this._tempera;
      }
      }


    private Paleta() : this(5)
        {
        }
  
        private Paleta(int cantidadMaxima)
        {
            _tempera = new Tempera[cantidadMaxima];
            this._cantidadMaxima = cantidadMaxima;
        }


        public static implicit operator Paleta (int cantidadMaxima)
        {
            Paleta miPaleta;
            miPaleta = new Paleta(cantidadMaxima);
            return miPaleta;
        }

        private string Mostrar()
        {
            //string datoAMostrar = "No hay nada.";
            //for (int i = 0; i<this._cantidadMaxima; i++)
            //{
            //    datoAMostrar += Tempera.Mostrar(this._tempera[i]);
            //}
            //return datoAMostrar;

            StringBuilder retorno = new StringBuilder();
            foreach (Tempera e in this._tempera)
            {
                if (!Equals(e, null))
                {
                    retorno.AppendLine(Tempera.Mostrar(e));
                }
            }
            return retorno.ToString();

        }

        public static explicit operator string (Paleta Dato)
        {
            return Dato.Mostrar();
        }


        public static bool operator ==(Paleta paletaParametro, Tempera temperaParametro)
        {
            //bool rta = false;
            //for (int i=0; i<paletaParametro._cantidadMaxima; i++)
            //{
            //    if (temperaParametro == paletaParametro._tempera[i])
            //    { rta = true; }
            //}
            //return rta;

            foreach (Tempera u in paletaParametro._tempera)
            {
                if (u == temperaParametro)
                {
                    return true;
                }
            }

            return false;

        }

        public static bool operator !=(Paleta paletaParametro, Tempera temperaParametro)
        {
           
            return !(paletaParametro == temperaParametro);

        }


        public static Paleta operator +(Paleta paletaParametro, Tempera temperaParametro)
        {
            if (paletaParametro != temperaParametro)
            {
                //paletaParametro._tempera.Add(temperaParametro);
            }
            return paletaParametro;
        }

        public static Paleta operator -(Paleta paletaParametro, Tempera temperaParametro)
        {
            if (paletaParametro == temperaParametro)
            {
                //paletaParametro._tempera.Remove(temperaParametro);
            }

            return paletaParametro;
        }



    }
}

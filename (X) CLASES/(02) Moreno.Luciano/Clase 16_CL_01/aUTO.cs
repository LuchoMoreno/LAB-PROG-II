using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16_CL_01
{
    public class Auto
    {

    #region Atributos

    private string _color;
    private string _marca;

    #endregion

    #region Propiedades

    public string Color
    {
      get
      {
        return this._color;
      }
    }

    public string Marca
    {
      get
      {
        return this._marca;
      }
    }
        #endregion

    #region Constructores
    public Auto (string color, string marca)
    {
      this._color = color;
      this._marca = marca;
    }

        #endregion

    #region Metodos

    public override bool Equals(object obj)
    {
      bool retorno = false;

      if (obj is Auto)
      {
        if ((Auto)obj == this) 
        {
          retorno = true;
        }
      }
      return retorno;
    }

    public static bool operator == (Auto a, Auto b)
    {
      bool retorno = false;

      if (a._color == b._color && a._marca == b._marca)
      {
        retorno = true;
      }

      return retorno;
    }

    public static bool operator != (Auto a, Auto b)
    {
      return !(a == b);
    }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Marca:{0}", this._marca);
            sb.AppendFormat("-- Color:{0}\n", this._color);
       
            return sb.ToString();
        }


    }

    #endregion
}

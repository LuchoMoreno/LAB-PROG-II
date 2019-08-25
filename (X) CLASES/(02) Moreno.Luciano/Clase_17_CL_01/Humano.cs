using System;

namespace Clase_17_CL_01
{
    public class Humano
    {

    #region Atributos

    private int _dni;

    #endregion

    #region Propiedades

    public int Dni {

      get
      {
        return this._dni;
      }
         set
      {

        this._dni = value;
      }
    }

    #endregion


    public override string ToString()
    {
      return string.Format("DNI: {0}", this._dni.ToString());
    }

  }

}

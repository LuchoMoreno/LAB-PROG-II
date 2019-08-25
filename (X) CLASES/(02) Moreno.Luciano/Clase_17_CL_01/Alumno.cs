using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization; // ES NECESARIO.

namespace Clase_17_CL_01
{
    public class Alumno : Persona
    {

    #region Atributos

    private int _legajo;

    #endregion


    #region Propiedades

    public int Legajo {
      get
      {
        return this._legajo;
      }
      set
      {

      }

    }

    #endregion


    public override string ToString()
    {
      return base.ToString() + string.Format(" -- Legajo: {0}", this._legajo.ToString());
    }

  }
}

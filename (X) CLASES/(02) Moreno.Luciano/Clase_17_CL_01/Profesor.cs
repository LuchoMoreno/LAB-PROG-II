using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17_CL_01
{
    public class Profesor : Persona
    {

    #region Atributos

    private string _titulo;

    #endregion


    #region Propiedades

    public string Titulo {

      get
      {
        return this._titulo;
      }

      set
      {
        this._titulo = value;
      }

    }

    #endregion


    #region Metodos

    public override string ToString()
    {
      return base.ToString() + string.Format(" -- Titulo: : {0}", this._titulo);
    }

    #endregion
  }
}

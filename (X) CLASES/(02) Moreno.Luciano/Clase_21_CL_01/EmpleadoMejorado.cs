using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21_CL_01
{
  public class EmpleadoMejorado
  {

    #region Atributos
    private string _nombre;
    private int _legajo;
    private float _sueldo;
    #endregion

    #region Aventos

    public event DelSueldo _limiteSueldo;


    #endregion

    #region Propiedades

    public string Nombre
    {
      get
      {
        return this._nombre;
      }
      set
      {
        this._nombre = value;
      }
    }

    public int Legajo
    {
      get
      {
        return this._legajo;
      }
      set
      {
        this._legajo = value;
      }
    }

    public float Sueldo
    {


      get
      {
        return this._sueldo;
      }
      set
      {
        if (value > 12000)
        {
          EmpleadoSueldoArgs empl = new EmpleadoSueldoArgs();
          empl.Sueldo = value;
          this._limiteSueldo(this, empl);
        }
        else
        {
          this._sueldo = value;
        }

      }
    }

    #endregion


    #region Metodos

    public override string ToString()
    {
      return string.Format("{0} -- {1} -- {2} ", this._nombre, this._legajo, this._sueldo);
    }

    #endregion

  }
}

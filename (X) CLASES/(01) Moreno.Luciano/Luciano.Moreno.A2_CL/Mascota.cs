using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luciano.Moreno.A2_CL
{
    public abstract class Mascota
    {

    private string _nombre;
    private string _raza;


    public string Nombre
    {
      get
      {
        return this._nombre;
      }
    }

    public string Raza
    {
      get
      {
        return this._raza;
      }
    }

    public Mascota(string nombre, string raza)
    {
      this._nombre = nombre;
      this._raza = raza;
    }


    protected abstract string Ficha();
    protected virtual string datosCompletos()
    {
      return this._nombre.ToString() + this._raza.ToString();
    }




  }
}

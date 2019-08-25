using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18_CL_01
{
  public class Persona
  {
    public int _id;
    public string _nombre;
    public string _apellido;
    public int _edad;


    public Persona (int id, string nombre, string apellido, int edad)
    {
      this._id = id;
      this._nombre = nombre;
      this._apellido = apellido;
      this._edad = edad;
    }


    public override string ToString()
    {
      return string.Format("{0} - {1} - {2} - {3}", this._id.ToString(), this._nombre, this._apellido, this._edad.ToString());
    }
   
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luciano.Moreno.A2_CL
{
  class Perro : Mascota
  {

    private int _edad;
    private bool _esAlfa;


    public Perro(string nombre, string raza) : this (nombre, raza, 0, false)
    {

    }

    public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
    {
      this._edad = edad;
      this._esAlfa = esAlfa;
    }


    protected override string Ficha()
    {
      string info = "";

      if (this._esAlfa == true)
      {
        info = base.datosCompletos() + ", alfa de la manada, edad "+ this._edad;
      }
      else
      {
        info = base.datosCompletos() + "edad " + this._edad;
      }

      return info;
    }


    public static bool operator ==(Perro p1, Perro p2)
    {
      bool retorno = false;

      if (p1.Nombre == p2.Nombre && p1.Raza == p2.Raza && p1._edad == p2._edad)
      {
        retorno = true;
      }

      return retorno;
    }

    public static bool operator !=(Perro p1, Perro p2)
    {
      return !(p1 == p2);
    }

    public static explicit operator int (Perro p)
    {
      int a;
      a = p._edad;

      return a;
    }



    public override bool Equals (object obj)
    {
      bool retorno = false;

      if (obj is Perro)
      {
        if ((Perro)obj == this) // Se castea a perro para acceder a la sobrecarga.
        {
          retorno = true;
        }
      }

      return retorno;
    }




  }



}




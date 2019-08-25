using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luciano.Moreno.A2_CL
{
  class Gato : Mascota
  {

    public Gato(string nombre, string raza) : base(nombre, raza)
    {

    }

    protected override string Ficha()
    {
      return base.datosCompletos();
    }


    public static bool operator ==(Gato g1, Gato g2)
    {
      bool retorno = false;

      if (g1.Nombre == g2.Nombre && g1.Raza == g2.Raza)
      {
        retorno = true;
      }

      return retorno;
    }

    public static bool operator !=(Gato g1, Gato g2)
    {
      return !(g1 == g2);
    }


    public override string ToString()
    {
      return base.datosCompletos();
    }


    public override bool Equals(object obj)
    {
      bool retorno = false;

      if (obj is Gato)
      {
        if ((Gato)obj == this) // Se castea a perro para acceder a la sobrecarga.
        {
          retorno = true;
        }
      }

      return retorno;
    }


  }
}

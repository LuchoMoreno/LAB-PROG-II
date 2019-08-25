using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luciano.Moreno.A2_CL
{
  class Grupo
  {
    private List<Mascota> _manada;
    private string _nombre;
    static private eTipoManada _tipo; // Tiene que ser static, porque su constructor es static.

    public int MyProperty
    {
     set
      {
        Grupo._tipo = (eTipoManada)value;
      }
    }


    private Grupo()
    {
      this._manada = new List<Mascota>();
    }

    static Grupo ()
    {
      Grupo._tipo = eTipoManada.Unica;
    }


    public Grupo (string nombre) : this () // Esto llama al privado, sino crashea
    {
      this._nombre = nombre;
    }

    public Grupo (string nombre, eTipoManada tipo) : this (nombre)
    {
      Grupo._tipo = tipo;


    }


  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_CL_01
{
  public class tinta
  {

    private ConsoleColor _color;
    private ETipoTinta _tipoTinta;


    public string Mostrar()
    {
      return this._color.ToString() + "--" + this._tipoTinta.ToString();
    }

    static public string Mostrar(tinta tipoTinta)
    {
      return tipoTinta.Mostrar();
    }


    public tinta() : this(ConsoleColor.Black, ETipoTinta.Comun) 
    {
    }

    public tinta(ConsoleColor colorParametro) : this(colorParametro, ETipoTinta.Comun) //NIVEL 1
    {
    }

    public tinta(ConsoleColor colorParametro, ETipoTinta tintaParametro) // NIVEL 2
    {
      this._color = colorParametro;
      this._tipoTinta = tintaParametro;
    }


    public static bool operator ==  (tinta tinta1, tinta tinta2)
    {
      bool rta = false;

      if (tinta1._color == tinta2._color && tinta1._tipoTinta == tinta2._tipoTinta)
      { rta = true; }

      return rta;

    }

    public static bool operator != (tinta tinta1, tinta tinta2)
    {
      bool rta = false;

      if (tinta1._color != tinta2._color && tinta1._tipoTinta != tinta2._tipoTinta)
      { rta = true; }

      return rta;

    }
  }


}

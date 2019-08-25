using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16_CL_01
{
  public class DepositoDeAutos
  {

    #region Atributos
    private int _capacidadMaxima;
    private List<Auto> _lista;
        #endregion

    #region Constructores

    public DepositoDeAutos(int capacidad)
    {
      this._capacidadMaxima = capacidad;
      this._lista = new List<Auto>();
    }
        #endregion

    #region Metodos

        private int GetIndice (Auto a)
    {
      int contador = -1;
      int index = -1;

      foreach (Auto auto in this._lista)
      {
        contador++;
        if (auto == a)
        {
          index = contador;
          break;
        }
      }

      return index;
    }


    public static bool operator + (DepositoDeAutos d, Auto a)
    {
      bool retorno = false;
      if (d._lista.Count < d._capacidadMaxima)
      {
        d._lista.Add(a);
        retorno = true;
      }
      return retorno ;
    }


    public bool Agregar(Auto a)
    {
      return this + a;
    }


    public static bool operator - (DepositoDeAutos d, Auto a)
    {
      bool retorno = false;
      int indice = d.GetIndice(a);

      if (indice != -1)
      {
        d._lista.RemoveAt(indice);
        retorno = true;
      }
      
      return retorno;
    }



    public bool Remover (Auto a)
    {
      return this - a;

    }


    public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Auto autos in this._lista)
            {
                sb.AppendFormat("");
                if (autos is Auto)
                {
                    sb.AppendFormat(((Auto)autos).ToString());
                }
            }
            
            sb.AppendFormat("Capacidad:{0}\n", this._capacidadMaxima);
            
            return sb.ToString();
        }

  }
    #endregion
}

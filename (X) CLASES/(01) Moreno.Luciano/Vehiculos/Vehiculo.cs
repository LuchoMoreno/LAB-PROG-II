using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public abstract class Vehiculo // La idea es representar fielmente la clase como algo abstracto.
    {
    protected string _patente;
    protected byte _cantidadRuedas;
    protected eMarca _marca;


    #region Propiedades
    public string Patente
    {
      get // LECTURA
      {
        return this._patente;
      }
    }

    public string Marca
    {
      get // LECTURA
      {
        return this._marca.ToString();
      }
    }


    public abstract double Precio { get; set; }
    public abstract double calcularPrecioConIva();

    #endregion

    public Vehiculo(string patenteParametro, Byte ruedasParametro, eMarca marcaParametro)
    {
      this._patente = patenteParametro;
      this._cantidadRuedas = ruedasParametro;
      this._marca = marcaParametro;

    }


    //protected string mostrarVehiculo()
    //{

    //  return this._patente.ToString() + "--" + this._marca.ToString() + "--" + this._cantidadRuedas.ToString();
    //}

    public override string ToString()
    {
      return this._patente.ToString() + "--" + this._marca.ToString() + "--" + this._cantidadRuedas.ToString();
    }


    public static bool operator == (Vehiculo vehiculoA, Vehiculo vehiculoB)
    {
      bool retorno = false;
      if (vehiculoA._patente == vehiculoB._patente)
      { if (vehiculoA._marca == vehiculoB._marca) { retorno = true; } }

      return retorno;
    }


    public static bool operator !=(Vehiculo vehiculoA, Vehiculo vehiculoB)
    {
      return !(vehiculoA == vehiculoB);
    }





  }

}

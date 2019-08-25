using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Moto : Vehiculo
    {

    protected float cilindrada;


    public override double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override double calcularPrecioConIva()
    {
      throw new NotImplementedException();
    }

    public Moto(float cilindradaParametro, string s, byte b, eMarca m) : base(s, b, m)
    {
      this.cilindrada = cilindradaParametro;

    }


    public Moto(string patenteParametro, byte cantidadParametro, eMarca marcaParametro, float cilindradaParametro) : base(patenteParametro, cantidadParametro, marcaParametro)
    {
      this.cilindrada = cilindradaParametro;
    }



    //public string mostrarMoto()
    //{

    //  return base.mostrarVehiculo() + "--" + this.cilindrada.ToString();
    //}

    public override string ToString()
    {
      return base.ToString() + "" + this.cilindrada.ToString();
    }



  }
}

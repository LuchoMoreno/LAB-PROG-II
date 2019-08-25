using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Camion : Vehiculo 
    {

    protected float tara;


    public override double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override double calcularPrecioConIva()
    {
      throw new NotImplementedException();
    }



    public Camion(float taraParametro, string s, byte b, eMarca m) : base(s, b, m)
    {
      this.tara = taraParametro;

    }


    //public string mostrarCamion()
    //{
    //  return base.mostrarVehiculo() + "--" + this.tara.ToString();
    //}

    public override string ToString()
    {
      return base.ToString() + "" + this.tara.ToString();
    }

  }
}

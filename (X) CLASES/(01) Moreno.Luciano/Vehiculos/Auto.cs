using System;

namespace Vehiculos
{
    public class Auto : Vehiculo
    {

    protected int cantidadAsientos;

    public Auto (int cantidadAsientosParametro, string s, byte b, eMarca m) : base (s, b , m)
    {
      this.cantidadAsientos = cantidadAsientosParametro;
   
    }


    public override double Precio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override double calcularPrecioConIva()
    {
      throw new NotImplementedException();
    }

    public Auto(string patenteParametro, byte cantidadParametro, eMarca marcaParametro, int cantidadAsientosParametro) : base (patenteParametro, cantidadParametro, marcaParametro)
    {
      this.cantidadAsientos = cantidadAsientosParametro;
    }
    

    //public string mostrarAuto()
    //{
    //  return base.mostrarVehiculo() + "--" + this.cantidadAsientos.ToString();
    //}

    public override string ToString()
    {
      return base.ToString() + "" + this.cantidadAsientos.ToString();
    }



  }
}

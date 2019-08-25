using System;
using System.Collections.Generic;
using System.Text;

namespace Vehiculos
{
    public class Lavadero
    {
    private List<Vehiculo> _vehiculos;
    private float _precioAuto;
    private float _precioCamion;
    private float _precioMoto;


    public string MiLavadero
    {
      get
      {
        string informacionPrecios = "Precio auto" + this._precioAuto.ToString() + "Precio moto" + this._precioMoto.ToString() + "Precio camion" + this._precioCamion.ToString();
        string informacionVehiculos = "";

        foreach (Vehiculo vehiculo in this._vehiculos)
        {
          informacionVehiculos = informacionVehiculos + vehiculo.ToString();
        }

       return informacionPrecios + informacionVehiculos;
      }
    }



    private Lavadero()
    {
      this._vehiculos = new List<Vehiculo>();
    }

    public Lavadero(float auto, float camion, float moto) : this ()
    {
      this._precioAuto = auto;
      this._precioCamion = camion;
      this._precioMoto = moto;
    }


        public static bool operator == (Lavadero lavaderoParametro, Vehiculo VehiculoParametro)
        {

            foreach (Vehiculo vehiculo in lavaderoParametro._vehiculos)
            {
                if (vehiculo == VehiculoParametro)
                {
                    return true;
                }
            }
            return false;
     
        }

        public static bool operator !=(Lavadero lavaderoParametro, Vehiculo VehiculoParametro)
        {
            return !(lavaderoParametro == VehiculoParametro);
        }


        public static Lavadero operator +(Lavadero lavaderoParametro, Vehiculo VehiculoParametro)
        {
            if (lavaderoParametro != VehiculoParametro)
            {
                lavaderoParametro._vehiculos.Add(VehiculoParametro);

            }
            return lavaderoParametro;
            
        }

        public static Lavadero operator -(Lavadero lavaderoParametro, Vehiculo VehiculoParametro)
        {
            if (lavaderoParametro == VehiculoParametro)
            {
                lavaderoParametro._vehiculos.Remove(VehiculoParametro);

            }
            return lavaderoParametro;

        }



        public double MostrarTotalFacturado()
        {

            return 1;
        }

        //public double MostrarTotalFacturado(eVehiculos vehiculoParametro)
        //{
         
            
        //}


        public static int ordenarVehiculosPorPatente(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            int retorno;
            int comparativa = string.Compare(vehiculoA.Patente, vehiculoB.Patente);

          
            if (comparativa > 0) // La primera es mayor que la segunda, retorna 1.
            { retorno = 1; }

            else if (comparativa < 0) // La primera es menor que la segunda
            { retorno = -1; }

            else
            { retorno = 0; } // Son iguales.

            return retorno;
        }

        public static int ordenarVehiculosPorMarca(Vehiculo vehiculoA, Vehiculo vehiculoB)
        {
            int retorno;
            int comparativa = string.Compare(vehiculoA.Marca, vehiculoB.Marca);


            if (comparativa > 0) // La primera es mayor que la segunda, retorna 1.
            { retorno = 1; }

            else if (comparativa < 0) // La primera es menor que la segunda
            { retorno = -1; }

            else
            { retorno = 0; } // Son iguales.

            return retorno;
        }
    }
}

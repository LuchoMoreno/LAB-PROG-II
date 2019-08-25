using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos;

namespace Clase_09_E_01
{
  public class Program
  {
    static void Main(string[] args)
    {
      Vehiculos.Auto autoNuevo = new Vehiculos.Auto(10, "aa", 10, eMarca.Fiat);
      Vehiculos.Moto motoNueva = new Vehiculos.Moto(5, "bb", 10, eMarca.Honda);
      Vehiculos.Camion camionNuevo = new Vehiculos.Camion(2, "cc", 10, eMarca.Iveco);
      Lavadero nuevoLavadero = new Lavadero(10, 15, 20);
      nuevoLavadero += autoNuevo;
      nuevoLavadero += autoNuevo;


      Console.WriteLine(autoNuevo.ToString());
      Console.WriteLine(motoNueva.ToString());
      Console.WriteLine(camionNuevo.ToString());


      Console.WriteLine(nuevoLavadero.MiLavadero);
      Console.ReadLine();

    }
  }
}

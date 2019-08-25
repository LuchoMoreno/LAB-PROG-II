using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod] public void TestMethod1()
    {

      Estacionamiento NuevoEstacionamiento = new Estacionamiento(5);

      Assert.IsNotNull(NuevoEstacionamiento.Autos);
     
    }

    [TestMethod] public void EspacioEstacionamientoIncorrecto()
    {

      Estacionamiento NuevoEstacionamiento = new Estacionamiento(101);

      if (NuevoEstacionamiento.EspacioDisponible != 101)
      {
          Assert.Fail("Espacio es incorrecto. {0}", NuevoEstacionamiento.EspacioDisponible);
      }


      Estacionamiento OtroEstacionamiento = new Estacionamiento(0);

      Assert.AreNotEqual(OtroEstacionamiento.EspacioDisponible, 1);

      if (OtroEstacionamiento.EspacioDisponible != 0)
      {
        Assert.Fail("Esta mal validado el limite inferior {0}", OtroEstacionamiento.EspacioDisponible);
      }

    }


    [TestMethod] public void AgregarAutosEstacionamiento()
    {

      Estacionamiento NuevoEstacionamiento = new Estacionamiento(2);

      Auto autoUno = new Auto("AAA", ConsoleColor.Red);
      Auto autoDos = new Auto("BBB", ConsoleColor.Blue);
      Auto autoTres = new Auto("CCC", ConsoleColor.Black);

      try
      {
        NuevoEstacionamiento += autoUno;
        NuevoEstacionamiento += autoDos;
        NuevoEstacionamiento += autoTres;

        Assert.Fail("Si llegaste aca es porque hay una falla");

      }
      catch (Exception ExcepcionGenerada)
      {
        Assert.IsInstanceOfType (ExcepcionGenerada, typeof(EstacionamientoLlenoException));

      }
    }


    [TestMethod] public void AgregarAutoEspacioDisponible()
    {

      Estacionamiento NuevoEstacionamiento = new Estacionamiento(2);

      Auto autoUno = new Auto("AAA", ConsoleColor.Red);
      Auto autoDos = new Auto("BBB", ConsoleColor.Blue);

      NuevoEstacionamiento += autoUno;

      Assert.AreEqual(NuevoEstacionamiento.EspacioDisponible, 1);

      NuevoEstacionamiento += autoDos;

      Assert.AreEqual(NuevoEstacionamiento.EspacioDisponible, 0);
      

    }


  }
}

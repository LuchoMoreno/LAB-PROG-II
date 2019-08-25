using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_05_CL_01;

namespace Clase_05_E_01
{
  class Program
  {
    static void Main(string[] args)
    {

      tinta boligrafo1 = new tinta();
      tinta boligrafo2 = new tinta(ConsoleColor.Red);
      tinta boligrafo3 = new tinta(ConsoleColor.Blue, ETipoTinta.ConBrillito);

      Console.WriteLine(tinta.Mostrar(boligrafo1));
      Console.WriteLine(tinta.Mostrar(boligrafo2));
      Console.WriteLine(tinta.Mostrar(boligrafo3));

      Console.ReadLine();

    }
  }
}

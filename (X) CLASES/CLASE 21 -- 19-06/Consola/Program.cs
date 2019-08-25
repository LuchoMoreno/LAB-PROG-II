using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;

namespace Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Persona nuevaPersona = new Persona("Lucho", "Moreno", 18, ESexo.Masculino);

      ClaseHerencia nuevaPersonHeredada = new ClaseHerencia("Lucho", "Moreno", 18, ESexo.Masculino);

      Console.WriteLine(nuevaPersonHeredada.Nombre);
      Console.WriteLine(nuevaPersonHeredada.Apellido);
      Console.WriteLine(nuevaPersonHeredada.Edad);
      Console.WriteLine(nuevaPersonHeredada.Sexo);
      Console.ReadLine();




    }
  }
}

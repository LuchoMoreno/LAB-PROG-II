using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_18_CL_01;
using System.Data;

namespace Clase_18_C_01
{
  class Program
  {
    static void Main(string[] args)
    {
      DataTable tabla = new DataTable();
      //AccesoDatos ad = new AccesoDatos();
      //List<Persona> personas = new List<Persona>();

      //personas = ad.TraerTodos();

      ////Persona personaNueva = new Persona(0, "Lucho", "Moreno", 31);

      ////if (ad.AgregarPersona(personaNueva))
      ////{ Console.WriteLine("Se agregó a la persona"); }


      //foreach (Persona personaParametro in personas)
      //      {
      //          Console.WriteLine(personaParametro.ToString());
      //      }



      //tabla = ad.TreaerTablaPersonas();

      //foreach (DataRow fila in tabla.Rows)
      //{
      //  Console.WriteLine(fila[1].ToString(), fila["nombre"]);
      //}

      //tabla.WriteXmlSchema(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona_esquema.xml"); //Esquema. Devuelve la representacion del esquema del objeto en XML. Que campos tiene,
      //// que datos aloja, si tiene alguna PK. Etc.
      //tabla.WriteXml((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona_datos.xml"));

      tabla.ReadXmlSchema(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona_esquema.xml");
      tabla.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona_datos.xml");


      Console.ReadLine();

    }
  }
}

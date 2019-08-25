using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_17_CL_01;

namespace Clase_17_C_01
{
  public class Program
  {
    static void Main(string[] args)
    {
      List<Humano> lista = new List<Humano>();
     

      Alumno nuevoAlumno = new Alumno();
      nuevoAlumno.nombre = "Elba";
      nuevoAlumno.apellido = "Nanote";
      nuevoAlumno.Dni = 42396432;
      nuevoAlumno.Legajo = 1010;


      
      if (Program.SerializarAlumno(nuevoAlumno) == true)
      {
        Console.WriteLine("Archivo serializado! \n\n");
      }
      

      Alumno alumno = Program.DeserializarAlumno();
      Console.WriteLine(alumno.ToString());


      Persona nuevaPersona = new Persona("Lucho", "Moreno");
      nuevaPersona.Dni = 2222;

      

      Profesor nuevoProfesor = new Profesor();
      nuevoProfesor.nombre = "Julian";
      nuevoProfesor.apellido = "Gonzales";
      nuevoProfesor.Dni = 2222;
      nuevoProfesor.Titulo = "AAAA";



      Console.WriteLine(nuevaPersona.ToString());
      Console.WriteLine(nuevoProfesor.ToString());

      /**     ESTA MAL
      lista.Add(nuevoAlumno);
      lista.Add(nuevoProfesor);
      lista.Add(nuevaPersona);

      Program.SerializarListas(lista);
      List<Humano> humano = Program.DeserializarLista();
      Console.WriteLine(humano.ToString());
  */

      Console.ReadLine();
    }


    public static bool SerializarAlumno(Alumno alumnoParametro)
    {
      bool retorno = false;

      try
      {
        XmlSerializer serializador = new XmlSerializer(typeof(Alumno));
        StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.xml", true);
        serializador.Serialize(archivo, alumnoParametro);
        archivo.Close();

        retorno = true;

      }
      catch (Exception)
      {
        retorno = false;
      }

      return retorno;
    }


    public static Alumno DeserializarAlumno()
    {
      Alumno Alumno = null;

      try
      {
        using (StreamReader leer = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.xml"))
        {

          XmlSerializer serializador = new XmlSerializer(typeof(Alumno));
          Alumno = (Alumno)serializador.Deserialize(leer);
          leer.Close();

        }
      }

      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      return Alumno;

    }


    public static bool SerializarListas(List<Humano> listaParametro)
    {
      bool retorno = false;

      try
      {
        XmlSerializer serializador = new XmlSerializer(typeof(List<Humano>));
        StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\NuevaLista.xml", true);
        serializador.Serialize(archivo, listaParametro);
        archivo.Close();

        retorno = true;

      }
      catch (Exception)
      {
        retorno = false;
      }

      return retorno;
    }


    public static List<Humano> DeserializarLista()
    {

      List < Humano > lista = null;

      try
      {
        using (StreamReader leer = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\NuevaLista.xml"))
        {

          XmlSerializer serializador = new XmlSerializer(typeof(List<Humano>));
          lista = (List<Humano>)serializador.Deserialize(leer);
          leer.Close();

        }
      }

      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      return lista;

    }



    

  }
}

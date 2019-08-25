using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Clase_21_CL_01;

namespace Clase_21_C_01
{
  class Program
  {
    static void Main(string[] args)
    {
      Empleado emp = new Empleado();
      emp._limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
      emp.Legajo = 999;
      emp.Nombre = "Lucho";
      emp.Sueldo = 120000;


      //Console.WriteLine(emp.ToString());



      GuardarLog(emp, 2000);
      Console.ReadLine();

    }


    static void LimiteSueldoEmpleado (Empleado p, float sueldo)
    {
      Console.WriteLine(p.Nombre.ToString() + "--" + p.Legajo.ToString() + "-- El sueldo que se quiso pasar es: " + sueldo.ToString());
      Console.ReadLine();
    }


    static void GuardarLog(Empleado p, float sueldo) // fecha, hora, minuto, segundo + legajo + nombre + sueldo intentado
    {
      try
      {
        StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt", true);
        archivo.Write(p);
        archivo.Write(sueldo);
        archivo.Close();
      }
      catch (Exception excepcionDada)
      {
        Console.WriteLine(excepcionDada.Message);
      }

    }


  }

    
    
    
  
}

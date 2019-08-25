using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_20_WF_01
{
  public class Manejadora
  {
    public static void Manejador(object obj, EventArgs evento)
    {

      if (obj is TextBox)
      { MessageBox.Show("Se accede dede TextBox"); }

      if (obj is Label)
      { MessageBox.Show("Se accede dede Label"); }

      if (obj is Button)
      { MessageBox.Show("Se accede dede Button"); }


    }

    public void Manejador2 (object obj, EventArgs evento)
    {

      if (obj is TextBox)
      { MessageBox.Show("Se accede dede TextBox"); }

      if (obj is Label)
      { MessageBox.Show("Se accede dede Label"); }

      if (obj is Button)
      { MessageBox.Show("Se accede dede Button"); }

    }


    public static void Sumar(int a, int b)
    {
      int resultado = a + b;
    }

    public void Restar(int a, int b)
    {
      int resultado = a - b;
    }

    public void Multiplicar(int a, int b)
    {
      int resultado = a * b;
    }


    public void OtraSuma (MiDelegado delegado, int a, int b)
    {
      

    }
  }

}

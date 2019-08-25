using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_20_WF_01
{
  public partial class FrmTest2 : Form
  {
    public FrmTest2()
    {
      InitializeComponent();
      this.Load += new System.EventHandler(Inicializar);
  
    }


    public void Inicializar(object obj, EventArgs evento)
    {
      this.btnBoton1.Click += new System.EventHandler(MiManejador);


    }

    public void MiManejador(object obj, EventArgs evento)
    {
      string nombre = ((Control)obj).Name;
      MessageBox.Show(nombre);

      if (nombre == "btnBoton1")
      {
        this.btnBoton1.Click -= new System.EventHandler(this.MiManejador);
        this.btnBoton2.Click += new System.EventHandler(this.MiManejador);
      }

      else if (nombre == "btnBoton2")
      {
        this.btnBoton2.Click -= new System.EventHandler(this.MiManejador);
        this.btnBoton3.Click += new System.EventHandler(this.MiManejador);
      }

      else if (nombre == "btnBoton3")
      {
        this.btnBoton3.Click -= new System.EventHandler(this.MiManejador);
        this.btnBoton1.Click += new System.EventHandler(this.MiManejador);
      }


    }

    private void Operar_Click(object sender, EventArgs e)
    {
      MiDelegado delegado = new MiDelegado(Manejadora.Sumar);
      delegado.Invoke(3, 2); // EXPLICITA
      delegado(3, 2); // IMPLICITA

      Manejadora manejadoraParametro = new Manejadora();
      MiDelegado delegado2 = new MiDelegado(manejadoraParametro.Restar);
      delegado2(3, 0);

      Delegate delegadoTres = MiDelegado.Combine(delegado, delegado2);

      //MiDelegado delegadoCuatro = MiDelegado.Combine(delegadoTres, new MiDelegado();

    }
  }
}

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
  public partial class FrmTest1 : Form
  {
    public FrmTest1()
    {
      InitializeComponent();

      Manejadora manejo = new Manejadora();
      this.btnBoton.Click += new System.EventHandler(manejo.Manejador2); // ESTE DIRECTAMENTE LE PASA LA FUNCION 2.

      this.lblEtiqueta.Click += new System.EventHandler(Manejadora.Manejador);
      this.txtCuadroTexto.Click += new System.EventHandler(Manejadora.Manejador);

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void mostrarMensaje(object sender, EventArgs e)
    {



    }

    private void lblEtiqueta_Click(object sender, EventArgs e)
    {

    }

    private void txtCuadroTexto_Click(object sender, EventArgs e)
    {

    }


    private void txtCuadroTexto_TextChanged(object sender, EventArgs e)
    {

    }

   
  }


}

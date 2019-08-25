using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04_CL_01;

namespace Clase_04_E_WindowForms
{
  public partial class frmCosa : Form
  {
    public frmCosa()
    {
      InitializeComponent();


    }

    private void frmCosa_Load(object sender, EventArgs e)
    {
      MessageBox.Show("Hola mundo");
      this.Text = "Ejercicio";
      this.BackColor = Color.DimGray;

    }

    private void button1_Click(object sender, EventArgs e)
    {
      cosa objeto = new cosa();
      MessageBox.Show(objeto.Mostrar());

      this.button1.Text = "Cosa 1";
      this.button1.BackColor = Color.Red;
    }

    private void button2_Click(object sender, EventArgs e)
    {
       cosa objeto = new cosa();
       MessageBox.Show(objeto.Mostrar());

       this.button2.Text = "Cosa 2";
       this.button2.BackColor = Color.Blue;
    }
    }
}

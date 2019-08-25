using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_06_CL_01;

namespace Clase_07_WF_01
{
  public partial class frmTempera : Form
  {

    private Tempera _miTempera;

    public Tempera MiTempera
    {
      get { return _miTempera; }
    }


    public frmTempera()
    {
      InitializeComponent();
        

        }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }


    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      Tempera nuevaTemperaCreada = new Tempera((ConsoleColor)this.cboColor.SelectedItem, this.txtMarca.Text, Convert.ToSByte(this.txtCantidad.Text));
      MessageBox.Show(Tempera.Mostrar(nuevaTemperaCreada));
      this._miTempera = nuevaTemperaCreada;
      this.DialogResult = DialogResult.OK;

    }

    private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void frmTempera_Load(object sender, EventArgs e)
    {
      foreach (ConsoleColor item in Enum.GetValues(typeof(ConsoleColor)))
      {
        this.cboColor.Items.Add(item);
      }

    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_07_WF_01
{
  public partial class frmPrincipal : Form
  {
    public frmPrincipal()
    {
      InitializeComponent();
      this.IsMdiContainer = true;
      this.WindowState = FormWindowState.Maximized;

    }

    private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
    {

      frmPaleta paleta = new frmPaleta();
      paleta.MdiParent = this;
      paleta.StartPosition = FormStartPosition.CenterScreen;
      paleta.Show();

    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.frmPrincipal_FormClosing(sender, new FormClosingEventArgs(CloseReason.UserClosing, true));
    }

    private void frmPrincipal_Load(object sender, EventArgs e)
    {

    }

    private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("¿Desea salir?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.No)
      {
        e.Cancel = true;
      }
    }


  }
}

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
  public partial class frmPaleta : Form
  {

    Paleta p;

    private frmPaleta _myPaleta;

    public frmPaleta MyPaleta
    {
      get { return _myPaleta; }
      set { _myPaleta = value; }
    }



    public frmPaleta()
    {
      InitializeComponent();
      p = 5;

      

    }

    private void Form1_Load(object sender, EventArgs e)
    {


    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
          
    }


        private void ActualizarLstBox()
        {
            lstLista.Items.Clear();
            foreach (Tempera i in p.temperas)
            {
                lstLista.Items.Add(Tempera.Mostrar(i));
            }
        }


        private void btnMas_Click(object sender, EventArgs e)
    {
        frmTempera tempera1 = new frmTempera();
        tempera1.ShowDialog();

        if (this.DialogResult == DialogResult.OK)
        {
          this.p += tempera1.MiTempera;
        }
            ActualizarLstBox();

        }

    private void button1_Click(object sender, EventArgs e)
    {
 
 

    }

    private void lstLista_MouseDoubleClick(object sender, MouseEventArgs e)
    {
          
          
    }
  }
}

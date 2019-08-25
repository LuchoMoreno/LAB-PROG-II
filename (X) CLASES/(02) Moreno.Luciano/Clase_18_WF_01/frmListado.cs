using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_18_CL_01;


namespace Clase_18_WF_01
{
  public partial class frmListado : Form
  {
    private List<Persona> _personas;
    private DataTable _tabla;


        public frmListado()
    {

      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

            AccesoDatos acc = new AccesoDatos();
            _personas = acc.TraerTodos();
            _tabla = acc.TreaerTablaPersonas();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource = _personas;
            _personas = acc.TraerTodos();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

      
    
    }

    private void Form1_Load_1(object sender, EventArgs e)
    {
    



    }

  }
  
}


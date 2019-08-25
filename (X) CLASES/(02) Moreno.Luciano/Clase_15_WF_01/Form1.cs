using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Clase_15_WF_01
{
  public partial class frmPrincipal : Form
  {

    public frmPrincipal()
    {
      InitializeComponent();

    }

    private void button1_Click(object sender, EventArgs e)
    {
      string informacion = "";
      string directorio;
      directorio = AppDomain.CurrentDomain.BaseDirectory;

      try
      {

        //StreamReader leer = new StreamReader(directorio + "miArchivo.txt");
        StreamReader leer = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt");
        // MessageBox.Show(leer.ReadToEnd());


        while ((informacion = leer.ReadLine()) != null)
        {
          this.lstVisor.Items.Add(informacion);
        }

        leer.Close();
        
      }
      catch (Exception excepcionDada)
      {
        MessageBox.Show(excepcionDada.Message);
      }

    }

    private void button1_Click_1(object sender, EventArgs e)
    {
       
      string directorio;
        directorio = AppDomain.CurrentDomain.BaseDirectory; // Esto devuelve la direccion del ejecutable.

      try
      {
        //StreamWriter archivo = new StreamWriter(directorio + "miArchivo.txt", true); // Esto concatena el nombre para que se guarde el archivo
        //StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt", true);
     
        StreamWriter archivo = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\miArchivo.txt", true);

        archivo.WriteLine(txtValor.Text);                                                                                                                 
        archivo.Close();
      }

      catch (Exception excepcionDada)
      {
        MessageBox.Show(excepcionDada.Message);
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      string ubicacion = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      this.openFileDialog1.InitialDirectory = ubicacion;

      this.openFileDialog1.Title = "Seleccione un archivo: "; // Titulo de la ventana.
      this.openFileDialog1.Multiselect = true; // Permite seleccionar muchos.
      this.openFileDialog1.DefaultExt = ".txt"; // Extension por defecto. 
      this.openFileDialog1.AddExtension = true; // Mostrar extensiones de archivos previsualizados
      this.openFileDialog1.Filter = "(*.txt) | *.TXT"; // Mostrar SOLO estas extensiones.
    }

    private void button1_Click_2(object sender, EventArgs e)
    {

      if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
      {
        MessageBox.Show(this.openFileDialog1.FileName);
      }


    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
      this.lstVisor.Items.Clear();
      this.btnLimpiar.BackColor = Color.Red;
    }
  }
}

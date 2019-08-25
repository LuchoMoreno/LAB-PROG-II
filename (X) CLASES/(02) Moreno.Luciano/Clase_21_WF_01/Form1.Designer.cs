namespace Clase_21_WF_01
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.EmpleadoMejorado = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Legajo = new System.Windows.Forms.TextBox();
            this.Sueldo = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EmpleadoMejorado
            // 
            this.EmpleadoMejorado.Location = new System.Drawing.Point(27, 23);
            this.EmpleadoMejorado.Name = "EmpleadoMejorado";
            this.EmpleadoMejorado.Size = new System.Drawing.Size(204, 23);
            this.EmpleadoMejorado.TabIndex = 0;
            this.EmpleadoMejorado.Text = "EmpleadoMejorado";
            this.EmpleadoMejorado.UseVisualStyleBackColor = true;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(376, 23);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(241, 20);
            this.Nombre.TabIndex = 1;
            // 
            // Legajo
            // 
            this.Legajo.Location = new System.Drawing.Point(376, 66);
            this.Legajo.Name = "Legajo";
            this.Legajo.Size = new System.Drawing.Size(241, 20);
            this.Legajo.TabIndex = 2;
            // 
            // Sueldo
            // 
            this.Sueldo.Location = new System.Drawing.Point(376, 109);
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.Size = new System.Drawing.Size(241, 20);
            this.Sueldo.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(376, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Sueldo);
            this.Controls.Add(this.Legajo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.EmpleadoMejorado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button EmpleadoMejorado;
    private System.Windows.Forms.TextBox Nombre;
    private System.Windows.Forms.TextBox Legajo;
    private System.Windows.Forms.TextBox Sueldo;
    private System.Windows.Forms.ComboBox comboBox1;
  }
}


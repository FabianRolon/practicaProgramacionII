namespace FormularioClase_10
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(180, 245);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(114, 48);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(55, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(55, 123);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(24, 13);
            this.lblCuil.TabIndex = 2;
            this.lblCuil.Text = "Cuil";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(57, 161);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 3;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.AutoSize = true;
            this.lblObjetivo.Location = new System.Drawing.Point(57, 197);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(46, 13);
            this.lblObjetivo.TabIndex = 4;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(128, 154);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(128, 78);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(134, 20);
            this.textBox7.TabIndex = 5;
            // 
            // cbTipoEmpleado
            // 
            this.cbTipoEmpleado.FormattingEnabled = true;
            this.cbTipoEmpleado.Location = new System.Drawing.Point(128, 41);
            this.cbTipoEmpleado.Name = "cbTipoEmpleado";
            this.cbTipoEmpleado.Size = new System.Drawing.Size(134, 21);
            this.cbTipoEmpleado.TabIndex = 6;
            this.cbTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbTipoEmpleado_SelectedIndexChanged);
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(24, 47);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(78, 13);
            this.lblTipoEmpleado.TabIndex = 7;
            this.lblTipoEmpleado.Text = "Tipo Empleado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.cbTipoEmpleado);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
        private System.Windows.Forms.Label lblTipoEmpleado;
    }
}


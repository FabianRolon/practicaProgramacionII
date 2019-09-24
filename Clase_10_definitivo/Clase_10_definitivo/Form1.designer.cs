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
            this.txtbCuil = new System.Windows.Forms.TextBox();
            this.txtbObjetivo = new System.Windows.Forms.TextBox();
            this.txtbSueldo = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.cbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.lblBono = new System.Windows.Forms.Label();
            this.txtbBono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(207, 263);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 30);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.lblCuil.Location = new System.Drawing.Point(57, 123);
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
            // txtbCuil
            // 
            this.txtbCuil.Location = new System.Drawing.Point(128, 116);
            this.txtbCuil.Name = "txtbCuil";
            this.txtbCuil.Size = new System.Drawing.Size(134, 20);
            this.txtbCuil.TabIndex = 5;
            // 
            // txtbObjetivo
            // 
            this.txtbObjetivo.Location = new System.Drawing.Point(128, 190);
            this.txtbObjetivo.Name = "txtbObjetivo";
            this.txtbObjetivo.Size = new System.Drawing.Size(134, 20);
            this.txtbObjetivo.TabIndex = 5;
            // 
            // txtbSueldo
            // 
            this.txtbSueldo.Location = new System.Drawing.Point(128, 154);
            this.txtbSueldo.Name = "txtbSueldo";
            this.txtbSueldo.Size = new System.Drawing.Size(134, 20);
            this.txtbSueldo.TabIndex = 5;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(128, 78);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(134, 20);
            this.txtbNombre.TabIndex = 5;
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
            // lblBono
            // 
            this.lblBono.AutoSize = true;
            this.lblBono.Location = new System.Drawing.Point(57, 222);
            this.lblBono.Name = "lblBono";
            this.lblBono.Size = new System.Drawing.Size(32, 13);
            this.lblBono.TabIndex = 4;
            this.lblBono.Text = "Bono";
            // 
            // txtbBono
            // 
            this.txtbBono.Location = new System.Drawing.Point(128, 219);
            this.txtbBono.Name = "txtbBono";
            this.txtbBono.Size = new System.Drawing.Size(134, 20);
            this.txtbBono.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-148, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo Empleado";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(12, 263);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 30);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 305);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.cbTipoEmpleado);
            this.Controls.Add(this.txtbBono);
            this.Controls.Add(this.txtbObjetivo);
            this.Controls.Add(this.txtbSueldo);
            this.Controls.Add(this.txtbCuil);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblBono);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.lblSueldo);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.TextBox txtbCuil;
        private System.Windows.Forms.TextBox txtbObjetivo;
        private System.Windows.Forms.TextBox txtbSueldo;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.ComboBox cbTipoEmpleado;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Label lblBono;
        private System.Windows.Forms.TextBox txtbBono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrar;
    }
}


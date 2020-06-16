namespace Ejercicio69
{
    partial class FrmAltaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btbCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(106, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 81);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(106, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(201, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(28, 119);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(106, 112);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(201, 20);
            this.txtDni.TabIndex = 1;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(28, 160);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(28, 13);
            this.lblFoto.TabIndex = 0;
            this.lblFoto.Text = "Foto";
            this.lblFoto.DoubleClick += new System.EventHandler(this.lblFoto_DoubleClick);
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(106, 153);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(201, 20);
            this.txtFoto.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(61, 341);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(113, 37);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btbCancelar
            // 
            this.btbCancelar.Location = new System.Drawing.Point(209, 341);
            this.btbCancelar.Name = "btbCancelar";
            this.btbCancelar.Size = new System.Drawing.Size(113, 37);
            this.btbCancelar.TabIndex = 2;
            this.btbCancelar.Text = "Cancelar";
            this.btbCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.btbCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAltaAlumno";
            this.Text = "Alta Alumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.Label lblApellido;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.Label lblDni;
        public System.Windows.Forms.TextBox txtDni;
        public System.Windows.Forms.Label lblFoto;
        public System.Windows.Forms.TextBox txtFoto;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btbCancelar;
    }
}
namespace ejercicioClase21
{
    partial class FormularioArchivo
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
            this.btnFlecha = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbPantalla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFlecha
            // 
            this.btnFlecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlecha.Location = new System.Drawing.Point(713, 390);
            this.btnFlecha.Name = "btnFlecha";
            this.btnFlecha.Size = new System.Drawing.Size(75, 48);
            this.btnFlecha.TabIndex = 1;
            this.btnFlecha.Text = "->";
            this.btnFlecha.UseVisualStyleBackColor = true;
            this.btnFlecha.Click += new System.EventHandler(this.BtnFlecha_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Location = new System.Drawing.Point(12, 405);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(205, 31);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtMensaje.Location = new System.Drawing.Point(274, 405);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(393, 31);
            this.txtMensaje.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Location = new System.Drawing.Point(7, 380);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(93, 25);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(269, 380);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(101, 25);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Mensaje";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(684, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbPantalla
            // 
            this.lbPantalla.FormattingEnabled = true;
            this.lbPantalla.Location = new System.Drawing.Point(12, 27);
            this.lbPantalla.Name = "lbPantalla";
            this.lbPantalla.Size = new System.Drawing.Size(654, 342);
            this.lbPantalla.TabIndex = 6;
            // 
            // FormularioArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPantalla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnFlecha);
            this.Name = "FormularioArchivo";
            this.Text = "FormularioArchivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFlecha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbPantalla;
    }
}
namespace CalculadorDeConsumoElectrico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCargoFijo = new System.Windows.Forms.TextBox();
            this.txtValorKwh = new System.Windows.Forms.TextBox();
            this.lblCargoFijo = new System.Windows.Forms.Label();
            this.lblPrecioPond = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLecturaMedidor = new System.Windows.Forms.Label();
            this.txtLecturaMedidor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCargoFijo
            // 
            this.txtCargoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtCargoFijo.Location = new System.Drawing.Point(388, 54);
            this.txtCargoFijo.Name = "txtCargoFijo";
            this.txtCargoFijo.Size = new System.Drawing.Size(169, 31);
            this.txtCargoFijo.TabIndex = 0;
            // 
            // txtValorKwh
            // 
            this.txtValorKwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtValorKwh.Location = new System.Drawing.Point(577, 54);
            this.txtValorKwh.Name = "txtValorKwh";
            this.txtValorKwh.Size = new System.Drawing.Size(169, 31);
            this.txtValorKwh.TabIndex = 0;
            // 
            // lblCargoFijo
            // 
            this.lblCargoFijo.AutoSize = true;
            this.lblCargoFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoFijo.Location = new System.Drawing.Point(383, 26);
            this.lblCargoFijo.Name = "lblCargoFijo";
            this.lblCargoFijo.Size = new System.Drawing.Size(111, 25);
            this.lblCargoFijo.TabIndex = 1;
            this.lblCargoFijo.Text = "Cargo Fijo";
            // 
            // lblPrecioPond
            // 
            this.lblPrecioPond.AutoSize = true;
            this.lblPrecioPond.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblPrecioPond.Location = new System.Drawing.Point(572, 26);
            this.lblPrecioPond.Name = "lblPrecioPond";
            this.lblPrecioPond.Size = new System.Drawing.Size(122, 25);
            this.lblPrecioPond.TabIndex = 2;
            this.lblPrecioPond.Text = "Precio kWh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculadorDeConsumoElectrico.Properties.Resources.Edesur_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnCalcular.Location = new System.Drawing.Point(594, 390);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(194, 48);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total a Cobrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "0";
            // 
            // lblLecturaMedidor
            // 
            this.lblLecturaMedidor.AutoSize = true;
            this.lblLecturaMedidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblLecturaMedidor.Location = new System.Drawing.Point(383, 164);
            this.lblLecturaMedidor.Name = "lblLecturaMedidor";
            this.lblLecturaMedidor.Size = new System.Drawing.Size(168, 25);
            this.lblLecturaMedidor.TabIndex = 7;
            this.lblLecturaMedidor.Text = "Lectura Medidor";
            // 
            // txtLecturaMedidor
            // 
            this.txtLecturaMedidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtLecturaMedidor.Location = new System.Drawing.Point(388, 192);
            this.txtLecturaMedidor.Name = "txtLecturaMedidor";
            this.txtLecturaMedidor.Size = new System.Drawing.Size(169, 31);
            this.txtLecturaMedidor.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLecturaMedidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPrecioPond);
            this.Controls.Add(this.lblCargoFijo);
            this.Controls.Add(this.txtValorKwh);
            this.Controls.Add(this.txtLecturaMedidor);
            this.Controls.Add(this.txtCargoFijo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo Energía Eléctrica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCargoFijo;
        private System.Windows.Forms.TextBox txtValorKwh;
        private System.Windows.Forms.Label lblCargoFijo;
        private System.Windows.Forms.Label lblPrecioPond;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLecturaMedidor;
        private System.Windows.Forms.TextBox txtLecturaMedidor;
    }
}


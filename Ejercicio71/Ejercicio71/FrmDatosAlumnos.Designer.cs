namespace Ejercicio69
{
    partial class FrmDatosAlumnos
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
            this.pbFotoAlumno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFotoAlumno
            // 
            this.pbFotoAlumno.Location = new System.Drawing.Point(24, 181);
            this.pbFotoAlumno.Name = "pbFotoAlumno";
            this.pbFotoAlumno.Size = new System.Drawing.Size(226, 154);
            this.pbFotoAlumno.TabIndex = 3;
            this.pbFotoAlumno.TabStop = false;
            // 
            // FrmDatosAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 390);
            this.Controls.Add(this.pbFotoAlumno);
            this.Name = "FrmDatosAlumnos";
            this.Text = "Datos Alumnos";
            this.Controls.SetChildIndex(this.pbFotoAlumno, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotoAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFotoAlumno;
    }
}
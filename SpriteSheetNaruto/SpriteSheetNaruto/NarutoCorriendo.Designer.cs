namespace SpriteSheetNaruto
{
    partial class NarutoCorriendo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbNaruto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbNaruto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNaruto
            // 
            this.pbNaruto.Location = new System.Drawing.Point(0, 0);
            this.pbNaruto.Name = "pbNaruto";
            this.pbNaruto.Size = new System.Drawing.Size(63, 67);
            this.pbNaruto.TabIndex = 0;
            this.pbNaruto.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            // 
            // NarutoCorriendo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbNaruto);
            this.Name = "NarutoCorriendo";
            this.Size = new System.Drawing.Size(63, 67);
            ((System.ComponentModel.ISupportInitialize)(this.pbNaruto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNaruto;
        private System.Windows.Forms.Timer timer1;
    }
}

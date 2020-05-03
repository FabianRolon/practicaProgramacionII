using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCantina
{
    
    public partial class FrmBar : Form
    {
        Edificio edificio;
        public FrmBar()
        {
            InitializeComponent();
        }

        private void FrmBar_Load(object sender, EventArgs e)
        {
            edificio = Edificio.GetBar();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FrmCantidadEspaciosCantina frmCantidadEspaciosCantina = new FrmCantidadEspaciosCantina();
            frmCantidadEspaciosCantina.ShowDialog();

            if(frmCantidadEspaciosCantina.DialogResult == DialogResult.OK)
            {
                FrmCantina frmcantina = new FrmCantina(frmCantidadEspaciosCantina.CantidadEspacios);
                if(edificio + frmcantina.GetCantina)
                {
                    frmcantina.MdiParent = this;
                    frmcantina.Show();
                }
            }    
        }

        private void barrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (FrmCantina frmCantina in this.MdiChildren)
            {
                MessageBox.Show($"{frmCantina.GetInforme}", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

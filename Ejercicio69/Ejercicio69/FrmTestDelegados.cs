using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio69
{
    public partial class FrmTestDelegados : Form
    {
        FrmMostrar frmMostrar;
        public event DelegadoMostrarManejador Actualizar;
        public FrmTestDelegados()
        {
            frmMostrar = new FrmMostrar();
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(Actualizar != null)
                Actualizar.Invoke(txtDatos.Text);
        }
    }
}

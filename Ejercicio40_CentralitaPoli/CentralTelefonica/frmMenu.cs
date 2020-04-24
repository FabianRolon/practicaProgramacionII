using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio40_CentralitaPoli;

namespace CentralTelefonica
{
    public partial class FrmMenu : Form
    {
        FrmLlamador frmLlamador;
        Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
            centralita = new Centralita("MiEmpresa");
        }
                

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGenerarLlamada_Click(object sender, EventArgs e)
        {
            
            //this.Hide();
            frmLlamador.ShowDialog();
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            frmLlamador = new FrmLlamador(centralita);
        }
    }
}

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
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        public Centralita Centralita
        {
            get
            {
                return centralita;
            }
        }

        public void Limpiar()
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
        }

        private void FrmLlamador_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
                txtNroDestino.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void BtnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
        }
    }
}

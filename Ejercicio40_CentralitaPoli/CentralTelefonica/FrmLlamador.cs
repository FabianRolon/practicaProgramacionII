using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio40_CentralitaPoli;

namespace CentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        TextBox auxTxt = new TextBox();
        
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
            cmbFranja.Enabled = false;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            auxTxt.Text = "";
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
            if(auxTxt == txtNroDestino)
                txtNroDestino.Text += "1";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "2";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "3";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "4";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "5";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "6";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "7";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "8";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "9";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "9";
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "*";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "*";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "0";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "0";
        }

        private void BtnNumeral_Click(object sender, EventArgs e)
        {
            if (auxTxt == txtNroDestino)
                txtNroDestino.Text += "#";
            if (auxTxt == txtNroOrigen)
                txtNroOrigen.Text += "#";
            if (txtNroDestino.Text.IndexOf('#') == 0)
                cmbFranja.Enabled = true;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            int duracion;
            Random randomDuracion = new Random();
            duracion = randomDuracion.Next(1,50);
            
            if (cmbFranja.Enabled)
            {
                Provincial llamadaProv = new Provincial(txtNroOrigen.Text , (Provincial.Franja)cmbFranja.SelectedValue ,duracion, txtNroDestino.Text);
                centralita.Llamadas.Add(llamadaProv);
            }
            else
            {
                float costo;
                Random randomCosto = new Random();
                costo = randomCosto.Next(1, 5);
                costo *= (float)randomCosto.NextDouble();
                Local llamadaLocal = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
                centralita.Llamadas.Add(llamadaLocal);
            }
        }

        private void txtNroDestino_Enter(object sender, EventArgs e)
        {
            auxTxt = txtNroDestino;
        }

        private void txtNroOrigen_Enter(object sender, EventArgs e)
        {
            auxTxt = txtNroOrigen;
        }
    }
}

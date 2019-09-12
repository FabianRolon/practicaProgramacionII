using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace Conversor
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
            btnLock.Image = System.Drawing.Image.FromFile(@"C:\Users\Fabian\Downloads\Lock-Lock-icon.png");
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (txtPesoPeso.Enabled)
            {
                txtCotiDolar.Enabled = false;
                txtCotiEuro.Enabled = false;
                txtCotiPeso.Enabled = false;
                txtDolarDolar.Enabled = false;
                txtDolarEuro.Enabled = false;
                txtDolarPeso.Enabled = false;
                txtEuroDolar.Enabled = false;
                txtEuroEuro.Enabled = false;
                txtEuroPeso.Enabled = false;
                txtPesoDolar.Enabled = false;
                txtPesoEuro.Enabled = false;
                txtPesoPeso.Enabled = false;
                btnLock.Image = System.Drawing.Image.FromFile(@"C:\Users\Fabian\Downloads\Lock-Lock-icon.png");
            }
            else
            {
                txtCotiDolar.Enabled = true;
                txtCotiEuro.Enabled = true;
                txtCotiPeso.Enabled = true;
                txtDolarDolar.Enabled = true;
                txtDolarEuro.Enabled = true;
                txtDolarPeso.Enabled = true;
                txtEuroDolar.Enabled = true;
                txtEuroEuro.Enabled = true;
                txtEuroPeso.Enabled = true;
                txtPesoDolar.Enabled = true;
                txtPesoEuro.Enabled = true;
                txtPesoPeso.Enabled = true;
                btnLock.Image = System.Drawing.Image.FromFile(@"C:\Users\Fabian\Downloads\Lock-Unlock-icon.png");
            }
            
        }

        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            Euro e1 = new Euro(double.Parse(txtCantidadEuro.Text));
            Dolar d1 = (Dolar)e1;
            Pesos p1 = (Pesos)e1;
            txtEuroPeso.Text = p1.GetCantidad().ToString();
            txtEuroEuro.Text = e1.GetCantidad().ToString();
            txtEuroDolar.Text = d1.GetCantidad().ToString();
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            Dolar d1 = new Dolar(double.Parse(txtCantidadDolar.Text));
            Euro e1 = (Euro)d1;
            Pesos p1 = (Pesos)d1;
            txtDolarEuro.Text = e1.GetCantidad().ToString();
            txtDolarDolar.Text = d1.GetCantidad().ToString();
            txtDolarPeso.Text = p1.GetCantidad().ToString();
        }

        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            Pesos p1 = new Pesos(double.Parse(txtCantidadPesos.Text));
            Euro e1 = (Euro)p1;
            Dolar d1 = (Dolar)p1;
            txtPesoEuro.Text = e1.GetCantidad().ToString();
            txtPesoDolar.Text = d1.GetCantidad().ToString();
            txtPesoPeso.Text = p1.GetCantidad().ToString();
        }
    }
}

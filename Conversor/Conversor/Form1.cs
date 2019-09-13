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
            btnLock.BackgroundImage = Image.FromFile(@"C:\Users\Calidad\Desktop\Programas\Program\practicaProgramacionII\Conversor\bloqueado (1).png");
            txtCotiEuro.Text = "1,16";
            txtCotiPeso.Text = "55,93";
            txtCotiDolar.Text = "1";
            Euro.SetCotizacion(txtCotiEuro.Text);
            Dolar.SetCotizacion(txtCotiDolar.Text);
            Pesos.SetCotizacion(txtCotiPeso.Text);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (txtCotiDolar.Enabled)
            {
                txtCotiDolar.Enabled = false;
                txtCotiEuro.Enabled = false;
                txtCotiPeso.Enabled = false;
                btnLock.BackgroundImage = Image.FromFile(@"C:\Users\Calidad\Desktop\Programas\Program\practicaProgramacionII\Conversor\bloqueado.png");
            }
            else
            {
                txtCotiDolar.Enabled = true;
                txtCotiEuro.Enabled = true;
                txtCotiPeso.Enabled = true;
                btnLock.BackgroundImage = Image.FromFile(@"C:\Users\Calidad\Desktop\Programas\Program\practicaProgramacionII\Conversor\Conversor\Resources\bloqueado (1).png");
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

        private void TxtCotiPeso_Leave(object sender, EventArgs e)
        {
            Pesos.SetCotizacion(txtCotiPeso.Text);
            txtCotiPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void TxtCotiDolar_Leave(object sender, EventArgs e)
        {
            Dolar.SetCotizacion(txtDolarDolar.Text);
            txtCotiDolar.Text = Dolar.GetCotizacion().ToString();
        }

        private void TxtCotiEuro_Leave(object sender, EventArgs e)
        {
            Euro.SetCotizacion(txtCotiEuro.Text);
            txtCotiEuro.Text = Euro.GetCotizacion().ToString();
        }
    }
}

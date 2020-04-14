using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CalculadorDeConsumoElectrico
{
    public partial class CalculadoraConsumo : Form
    {
        public CalculadoraConsumo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Factura f = new Factura(int.Parse(txtLecturaMedidor.Text), double.Parse(txtCargoFijo.Text), double.Parse(txtValorKwh.Text));
            lblResultado.Text = f.TotalPagar(f).ToString() + "$";
        }
    }
}

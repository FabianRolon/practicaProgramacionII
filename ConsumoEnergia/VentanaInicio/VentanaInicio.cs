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
using CalculadorDeConsumoElectrico;

namespace VentanaInicio
{
    public partial class VentanaInicio : Form
    {
        List<Factura> facturas;
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculadoraConsumo.ShowDialog();
        }
    }
}

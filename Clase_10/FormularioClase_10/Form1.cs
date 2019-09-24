using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_10;

namespace FormularioClase_10
{
    public partial class Form1 : Form
    {
        public List<Persona> Personas;
        public Form1()
        {
            InitializeComponent();
            this.cbTipoEmpleado.DataSource = Enum.GetValues(typeof(Empleado.ETipoEmpleado));
        }

        private void cbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

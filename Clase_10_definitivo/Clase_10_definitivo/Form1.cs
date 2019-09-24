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
            this.Personas = new List<Persona>();
        }

        public void Limpiar()
        {
            txtbNombre.Text = "";
            txtbCuil.Text = "";
            txtbBono.Text = "";
            txtbObjetivo.Text = "";
            txtbSueldo.Text = "";
        }

        private void cbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            switch (cbTipoEmpleado.Text)
            {
                case "Empleado":
                    Empleado empleado = new Empleado(txtbNombre.Text, int.Parse(txtbCuil.Text), float.Parse(txtbSueldo.Text));
                    Personas.Add(empleado);
                    break;
                case "Jefe":
                    Jefe jefe = new Jefe(txtbNombre.Text, int.Parse(txtbCuil.Text), float.Parse(txtbSueldo.Text), int.Parse(txtbBono.Text));
                    Personas.Add(jefe);
                    break;
                case "Vendedor":
                    Vendedor vendedor = new Vendedor(txtbNombre.Text, int.Parse(txtbCuil.Text), float.Parse(txtbSueldo.Text), int.Parse(txtbObjetivo.Text));
                    Personas.Add(vendedor);
                    break;
            }
            Limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbTipoEmpleado.DataSource = Enum.GetValues(typeof(Empleado.ETipoEmpleado));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class FrmPersonas : Form
    {
        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            lstPersonas.DataSource = PersonaDAO.Leer();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(txtNombre.Text, txtApellido.Text);
            PersonaDAO.Guardar(persona);
        }
    }
}

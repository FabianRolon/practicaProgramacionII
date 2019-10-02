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

namespace VistaForm
{
    public partial class FormDT : Form
    {
        DirectorTecnico directorTecnico;
        public FormDT()
        {
            InitializeComponent();
        }

        private void ButtonCrear_Click(object sender, EventArgs e)
        {
            directorTecnico = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, int.Parse(numericUpDownEdad.Value.ToString()), (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value) ;
            MessageBox.Show("Se ha creado el DT!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonValidar_Click(object sender, EventArgs e)
        {
            if(directorTecnico != null && directorTecnico.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El DT no es apto.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

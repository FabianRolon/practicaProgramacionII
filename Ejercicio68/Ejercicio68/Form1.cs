using System;
using System.Windows.Forms;

namespace Ejercicio68
{
    public partial class FormPersona : Form
    {
        Persona persona;

        public FormPersona()
        {
            persona = new Persona();
            InitializeComponent();
            persona.EnventoString += NotificarCambio;
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (persona.Nombre == String.Empty && persona.Apellido == String.Empty)
            {

                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                btnCrear.Text = "Actualizar";
                MessageBox.Show($"{persona.Mostrar()}");
            }
            else 
            {
                persona.Nombre = txtNombre.Text;
                persona.Apellido = txtApellido.Text;
                MessageBox.Show($"{persona.Mostrar()}");
            }
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
        }
    }
}

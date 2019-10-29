using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioClase21
{
    public partial class FormularioArchivo : Form
    {
        List<Mensaje> mensajes;
        public FormularioArchivo()
        {
            InitializeComponent();
            mensajes = new List<Mensaje>();
        }

        private void BtnFlecha_Click(object sender, EventArgs e)
        {
            Mensaje mensaje = new Mensaje(txtUsuario.Text, txtMensaje.Text, DateTime.Now);
            mensajes.Add(mensaje);
            lbPantalla.DataSource = mensajes;
            txtMensaje.Text = "";
            txtUsuario.Text = "";
        }
    }
}

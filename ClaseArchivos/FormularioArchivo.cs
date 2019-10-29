using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ejercicioClase21;

namespace ClaseArchivos
{
    public partial class FormularioArchivo : Form
    {
        List<Mensaje> mensajes;
        public FormularioArchivo()
        {
            InitializeComponent();
            mensajes = new List<Mensaje>();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if(txtMensaje.Text != "" && txtUsuario.Text != "")
            {
                Mensaje mensaje = new Mensaje(txtUsuario.Text, txtMensaje.Text, DateTime.Now);
                mensajes.Add(mensaje);
                txtMensaje.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                MessageBox.Show("Error, los campos estan vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.cargar();
        }

        void limpiar()
        {
            this.txtMensaje.Text = "";
            this.txtUsuario.Text = "";
        }
        void cargar()
        {

            try
            {
                mensajes = Mensaje.Deserializar();
                this.lbPantalla.DataSource = null;
                this.lbPantalla.DataSource = mensajes;
                StreamWriter sw = new StreamWriter("archivo.log");
                sw.WriteLine(DateTime.Now.ToString("yyyMMddhhmmssttt") + ":  Se actualizaron los mensajes");
                sw.Close();
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }

        }
    }
}

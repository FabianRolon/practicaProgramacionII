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

        void Limpiar()
        {
            this.txtMensaje.Text = "";
            this.txtUsuario.Text = "";
        }
        void Cargar()
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

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text != "" && txtUsuario.Text != "")
            {
                Mensaje mensaje = new Mensaje(txtUsuario.Text, txtMensaje.Text, DateTime.Now);
                try
                {
                    mensaje.Serializar();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
                this.Limpiar();
                this.Cargar();
            }           
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.Cargar();
        }
    }
}

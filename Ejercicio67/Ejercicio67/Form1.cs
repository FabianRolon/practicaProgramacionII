using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;


namespace Ejercicio67
{
    public partial class FormTemp : Form
    {
        Temporizador temporizador;
        public FormTemp()
        {
            InitializeComponent();
            temporizador = new Temporizador();
        }
        private void Temporizador_Load(object sender, EventArgs e)
        {
            temporizador.Intervalo = 1000;
            temporizador.EventoTiempo += ModificarHora;
            temporizador.Activo = true;
        }

        private void ModificarHora()
        {
            if (label1.InvokeRequired)
            {
                EncargadotiempoEventHandler d = new EncargadotiempoEventHandler(ModificarHora);
                this.Invoke(d);
            }
            else
            {
                label1.Text = DateTime.Now.ToString();
            }
        }

        private void FormTemp_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizador.Activo = false;
        }
    }
}

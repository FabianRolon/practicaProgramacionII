using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06
{
    public partial class Form1 : Form
    {
        public Persona[] personas;

        public Form1()
        {
            InitializeComponent();
            personas = new Persona[3];
        }

        public void Limpiar()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int dni))
            {
                Persona unaPersona = new Persona((textBox1.Text), (textBox2.Text), dni, ObtenerSexo() , cbxProvincia.Text, chkbxVive.Checked);
                for (int i = 0; i < personas.Length; i++)
                {
                    if (personas[i] == null)
                    {
                        personas[i] = unaPersona;
                        break;
                    }
                }
            }
            else
                MessageBox.Show("DNI inválido");
            Limpiar();
        }

        public string ObtenerSexo()
        {
            foreach (Control item in grbxSexo.Controls)
            {
                if (item is RadioButton && ((RadioButton)item).Checked)
                {
                    return item.Text;
                }
            }
            return " ";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrar frmMostrar = new frmMostrar();
            frmMostrar.personas = this.personas;
            frmMostrar.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxProvincia.SelectedIndex = -1;
        }
    }
}

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
using ControlCantina;

namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            
            InitializeComponent();
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbAgua.Checked)
            {
                Agua botellaAgua = new Agua((int)numericUpDown1.Value, txtMarca.Text, (int)numericUpDown2.Value);
                barra1.AgregarBotella(botellaAgua);
            }
            if (rbCerveza.Checked)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
                Cerveza botellaCerveza = new Cerveza((int)numericUpDown1.Value, txtMarca.Text, tipo, (int)numericUpDown2.Value);
                barra1.AgregarBotella(botellaCerveza);
            }
        }
    }
}

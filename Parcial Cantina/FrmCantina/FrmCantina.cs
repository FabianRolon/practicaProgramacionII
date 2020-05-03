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

        Cantina cantina;
        public FrmCantina(int espacio)
        {
            cantina = Cantina.GetCantina(espacio);
            InitializeComponent();
        }

        public Cantina GetCantina
        {
            get
            {
                return cantina;
            }
            
        }

        public string GetInforme
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Botella botella in cantina.Botellas)
                {
                    sb.AppendLine($"{(string)botella}");
                }
                return sb.ToString();
            }
        }

        private void FrmCantina_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = cantina;
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

        private void FrmCantina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }


    }
}

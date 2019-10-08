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

namespace FormSistemaSolar
{
    public partial class Form1 : Form
    {
        List<Astro> planetas;
        public Form1()
        {
            InitializeComponent();
            planetas = new List<Astro>();
        }

        private void btnAgregarPlaneta_Click(object sender, EventArgs e)
        {
            if (txtNombrePlaneta.Text != "" && txtOrbitaPlaneta.Text != "" && numRotacion.Value > 0 && numSatelite.Value != 0 && cmbTipo.Text != "")
            {
                Planeta planeta = new Planeta(int.Parse(txtOrbitaPlaneta.Text), (int)numRotacion.Value, txtNombrePlaneta.Text, (int)numSatelite.Value);
                
                planetas.Add(planeta);
                cmbPlanetas.Items.Add(txtNombrePlaneta.Text);
            }
            else
            {
                MessageBox.Show("Complete todos los campos para agregar", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            foreach (Planeta planeta in planetas)
            {
                richTextBox1.AppendText(planeta.ToString());
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add(Tipo.Rocoso);
            cmbTipo.Items.Add(Tipo.Gaseoso);
        }

        private void btnAgregarSatelite_Click(object sender, EventArgs e)
        {
            if(cmbPlanetas.Text != "")
            {
                Satelite satelite = new Satelite((int)numOrbitaSatelite.Value, (int)numRotacionSatelite.Value, txtNombreSatelite.Text);
            }
        }
    }
}

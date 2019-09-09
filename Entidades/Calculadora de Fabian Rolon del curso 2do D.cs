using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class Calculadora_de_Fabian_Rolon_del_curso_2do_D : Form
    {
        public Calculadora_de_Fabian_Rolon_del_curso_2do_D()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(textBox1.Text);
            Numero numeroDos = new Numero(textBox2.Text);
            this.label1.Text = Calculadora.Operar(numeroUno, numeroDos, comboBox1.Text).ToString();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(label1.Text);
            this.label1.Text = numeroUno.DecimalBinario();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.label1.Text = "0";
            comboBox1.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Numero numeroUno = new Numero(label1.Text);
            this.label1.Text = numeroUno.BinarioDecimal();
        }
    }
}

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
    }
}

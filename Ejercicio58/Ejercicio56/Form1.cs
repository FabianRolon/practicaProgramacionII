using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IO;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string nroCaracter = rtbEscritura.TextLength.ToString();
            SSlblCaracteres.Text = nroCaracter + " Caracteres";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ventanaGuardado = new SaveFileDialog();

            ventanaGuardado.Filter = "binary files (*.dat)|*.dat|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ventanaGuardado.FilterIndex = 3;
            ventanaGuardado.RestoreDirectory = true;

            if (ventanaGuardado.ShowDialog() == DialogResult.OK)
            {
                if (ventanaGuardado.FilterIndex == 2)
                {
                    path = ventanaGuardado.FileName;
                    PuntoTxt puntoTxt = new PuntoTxt();
                    puntoTxt.GuardarComo(path, rtbEscritura.Text);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "binary files (*.dat)|*.dat|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }
            MessageBox.Show("Se cargó con éxito", " ", MessageBoxButtons.OK);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoTxt puntoTxt = new PuntoTxt();
            if (puntoTxt.Guardar(path, rtbEscritura.Text))
            {
                
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

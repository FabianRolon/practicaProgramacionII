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
using Ejercicio56;

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
            StreamWriter writer;
            SaveFileDialog ventanaGuardado = new SaveFileDialog();

            ventanaGuardado.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ventanaGuardado.FilterIndex = 2;
            ventanaGuardado.RestoreDirectory = true;

            if (ventanaGuardado.ShowDialog() == DialogResult.OK)
            {
                path = ventanaGuardado.FileName;
                writer = new StreamWriter(path);
                writer.Write(rtbEscritura.Text);
                writer.Close();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
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
            if (File.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path);
                writer.Write(rtbEscritura.Text);
                writer.Close();
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

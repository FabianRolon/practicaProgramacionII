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

namespace Ejercicio58
{
    public partial class Form1 : Form
    {
        string path;
        PuntoDat puntoDat;
        PuntoTxt puntoTxt;
        public Form1()
        {
            InitializeComponent();
            puntoDat = new PuntoDat();
            puntoTxt = new PuntoTxt();
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
                path = ventanaGuardado.FileName;
                if (ventanaGuardado.FilterIndex == 2)
                {
                    puntoTxt.GuardarComo(path, rtbEscritura.Text);
                }
                else if (ventanaGuardado.FilterIndex == 1)
                {
                    puntoDat.Contenido = rtbEscritura.Text;
                    puntoDat.GuardarComo(path, puntoDat);
                }
                else
                {
                    MessageBox.Show("Para guardar asigne un tipo y un nombre al archivo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    guardarComoToolStripMenuItem_Click(sender, e);
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

                    if (path.Contains(".dat"))
                    {
                        puntoDat = puntoDat.Leer(path);
                        rtbEscritura.Text = puntoDat.Contenido;
                    }
                    else if (path.Contains(".txt"))
                    {
                        rtbEscritura.Text = puntoTxt.Leer(path);
                    }
                }
            }
            MessageBox.Show("Se cargó con éxito", " ", MessageBoxButtons.OK);
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!(path is null))
            {
                if (path.Contains(".txt"))
                {
                    puntoTxt.Guardar(path, rtbEscritura.Text);
                }
                else if (path.Contains(".dat"))
                {
                    puntoDat.Contenido = rtbEscritura.Text;
                    puntoDat.Guardar(path, puntoDat);
                }
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}

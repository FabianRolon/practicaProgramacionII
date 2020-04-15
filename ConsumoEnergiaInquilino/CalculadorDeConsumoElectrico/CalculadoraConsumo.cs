using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Entidades;

namespace CalculadorDeConsumoElectrico
{
    public partial class CalculadoraConsumo : Form
    {
        public CalculadoraConsumo()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            txtLecturaMedidor.Text = "";
            txtCargoFijo.Text = "";
            txtValorKwh.Text = "";
            txtMunicipal.Text = "";
            txtProvincial.Text = "";
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Factura f = new Factura(int.Parse(txtLecturaMedidor.Text), double.Parse(txtCargoFijo.Text), double.Parse(txtValorKwh.Text), double.Parse(txtMunicipal.Text), double.Parse(txtProvincial.Text), DateTime.Now);
            lblResultado.Text = f.TotalPagar(f).ToString() + "$";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Factura f = new Factura(int.Parse(txtLecturaMedidor.Text), double.Parse(txtCargoFijo.Text), double.Parse(txtValorKwh.Text), double.Parse(txtMunicipal.Text), double.Parse(txtProvincial.Text), DateTime.Now);

            int retorno = f.Guardar();

            switch(retorno)
            {
                case 0:
                    MessageBox.Show("Correcto");
                    Limpiar();
                    break;
                case 1:
                    MessageBox.Show("Se canceló la operación");
                    break;
                case 2:
                    MessageBox.Show("ERROR");
                    break;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialogo = new OpenFileDialog(); //abre ventana para elegir el archivo para cargar
                if (dialogo.ShowDialog() == DialogResult.OK) //espera el resultado Ok, sino el usuario canceló
                {
                    FileStream st = new FileStream(dialogo.FileName, FileMode.Open); //dialogo.FileName es la ruta completa donde se eligio guardar, FileMode.Open indica que tiene que abrir el archivo  
                    BinaryFormatter binfor = new BinaryFormatter(); //permite hacer la serializacion o deserialiacion
                    Factura f = (Factura)binfor.Deserialize(st); //se crea una instancia del objeto a deserializar para que lo cargue
                    st.Close();

                    //Cargo el dataGridView
                    int n = dataGridView1.Rows.Add(); //adiciona renglon

                    //coloco info
                    dataGridView1.Rows[n].Cells[0].Value = f.Consumo.ToString();
                    dataGridView1.Rows[n].Cells[1].Value = f.FechaIngreso.ToString();
                    dataGridView1.Rows[n].Cells[2].Value = f.TotalPagar(f).ToString();
                    Limpiar();


                    MessageBox.Show("Correcto"); 
                }
                else
                {
                    MessageBox.Show("Se canceló la operación");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
        List<Factura> facturas;
        public CalculadoraConsumo()
        {
            InitializeComponent();
            facturas = new List<Factura>();
            CargaDatos();
        }
        #region Metodos auxiliares

        public List<Factura> Facturas
        {
            get 
            { 
                return facturas;
            }
        }


        public bool Vacio()
        {
            if(txtLecturaMedidor.Text != "" && txtCargoFijo.Text != "" && txtValorKwh.Text != "" && txtMunicipal.Text != "" && txtProvincial.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Limpiar()
        {
            txtLecturaMedidor.Text = "";
        }

        public int GenerarId()
        {
            var lis = (from l in facturas orderby l.IdFactura ascending select l);
            if (!(facturas is null))
            {
                if (facturas.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    return facturas[facturas.Count() - 1].IdFactura + 1;
                }
            }
            else
            {
                return 1;
            }
        }

        public void Guardar(string path)
        {
            try
            {
                //SaveFileDialog dialogo = new SaveFileDialog(); //abre ventana para elegir donde guardar el archivo
                if (!(path is null)) //espera el resultado Ok, sino el usuario canceló
                {
                    FileStream st = new FileStream(path, FileMode.Create); //dialogo.FileName es la ruta completa donde se eligio guardar, FileMode.Create crea el archivo o lo reemplaza si ya existe
                    BinaryFormatter binfor = new BinaryFormatter(); //permite hacer la serializacion
                    binfor.Serialize(st, facturas); //Se le pasa a la instacia de binnaryFormatter el stream creado y el objeto a serializar
                    st.Close();
                    MessageBox.Show("Correcto");

                    dataGridView1.Rows.Clear();
                    foreach (Factura factura in facturas)
                    {
                        CargarDataGridView(factura);
                    }

                    Limpiar();
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

        public void Cargar(string path)
        {
            try
            {
                //OpenFileDialog dialogo = new OpenFileDialog(); //abre ventana para elegir el archivo para cargar
                if (!(path is null)) //espera el resultado Ok, sino el usuario canceló
                {
                    FileStream st = new FileStream(path, FileMode.Open); //dialogo.FileName es la ruta completa donde se eligio guardar, FileMode.Open indica que tiene que abrir el archivo  
                    BinaryFormatter binfor = new BinaryFormatter(); //permite hacer la serializacion o deserialiacion
                    facturas = (List<Factura>)binfor.Deserialize(st); //se crea una instancia del objeto a deserializar para que lo cargue
                    st.Close();

                    txtMunicipal.Text = (facturas[UltimaFactura()].Municipal).ToString();
                    txtProvincial.Text = (facturas[UltimaFactura()].Provincial).ToString();
                    txtValorKwh.Text = (facturas[UltimaFactura()].PrecioUnitarioCv).ToString();
                    txtCargoFijo.Text = (facturas[UltimaFactura()].PrecioUnitarioCf).ToString();

                    var lis = (from l in facturas orderby l.IdFactura ascending select l); //Ordena la lista segun el atributo que se elija por medio de LINQ (MAGIA!!)

                    foreach (Factura factura in lis)
                    {
                        CargarDataGridView(factura);
                    }
                    //Limpiar();
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

        public void CargarDataGridView(Factura factura)
        {
            int n = dataGridView1.Rows.Add(); //adiciona renglon
            //coloco info
            dataGridView1.Rows[n].Cells[0].Value = factura.IdFactura.ToString();
            dataGridView1.Rows[n].Cells[1].Value = factura.Consumo.ToString();
            dataGridView1.Rows[n].Cells[2].Value = factura.FechaIngreso.ToString();
            dataGridView1.Rows[n].Cells[3].Value = factura.TotalPagar(factura).ToString();
        }
        public bool ValidarNumero()
        {
            double lecturaMedidor;
            double cargofijo;
            double valorKwh;
            double municipal;
            double provincial;

            if(double.TryParse(txtLecturaMedidor.Text, out lecturaMedidor) && double.TryParse(txtCargoFijo.Text, out cargofijo) && double.TryParse(txtValorKwh.Text, out valorKwh) && double.TryParse(txtMunicipal.Text, out municipal) && double.TryParse(txtProvincial.Text, out provincial))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Compara las facturas en la lista
        /// </summary>
        /// <returns>Retorna el indice de la mas  reciente</returns>
        public int UltimaFactura()
        {
            facturas.Sort((p,q) => DateTime.Compare(p.FechaIngreso , q.FechaIngreso));
            return facturas.Count - 1;
        }


        public int IndiceDeFilaSeleccionada()
        {
            int i = dataGridView1.CurrentRow.Index;
            return i;
        }

        public void BorrarFacturaPorId(int indice)
        {
            for(int i = 0; i <= facturas.Count -1; i++)
            {
                if(facturas[i].IdFactura == int.Parse((string)dataGridView1.Rows[indice].Cells[0].Value))
                {
                    facturas.RemoveAt(i);
                    break;
                }
            }
            dataGridView1.Rows.Clear();
            foreach (Factura factura in facturas)
            {
                CargarDataGridView(factura);
            } 
        }


    
        #endregion
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (Vacio())
            {
                if (ValidarNumero())
                {
                    Factura f = new Factura(int.Parse(txtLecturaMedidor.Text), double.Parse(txtCargoFijo.Text), double.Parse(txtValorKwh.Text), double.Parse(txtMunicipal.Text), double.Parse(txtProvincial.Text), DateTime.Now);
                    lblResultado.Text = f.TotalPagar(f).ToString() + "$"; 
                }
                else
                {
                    MessageBox.Show("Solo se admiten numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string auxPath = Directory.GetCurrentDirectory();
            string path = auxPath + @"\ConsumoElectrico.fabi";
            if (Vacio())
            {

                if (ValidarNumero())
                {
                    Factura f = new Factura(int.Parse(txtLecturaMedidor.Text), double.Parse(txtCargoFijo.Text), double.Parse(txtValorKwh.Text), double.Parse(txtMunicipal.Text), double.Parse(txtProvincial.Text), DateTime.Now, GenerarId());
                    facturas.Add(f);
                    Guardar(path);
                    
                }
                else
                {
                    MessageBox.Show("Solo se admiten numeros", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Faltan completar campos", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargaDatos()
        {
            //string path = @"C:\Users\Calidad\Desktop\Programas\Program\practicaProgramacionII\ConsumoEnergiaInquilino\path";
            string auxPath = Directory.GetCurrentDirectory();
            string path = auxPath + @"\ConsumoElectrico.fabi";
            Cargar(path);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBorrarDato_Click(object sender, EventArgs e)
        {
            string auxPath = Directory.GetCurrentDirectory();
            string path = auxPath + @"\ConsumoElectrico.fabi";
            BorrarFacturaPorId(IndiceDeFilaSeleccionada());
            Guardar(path);
        }
    }
}

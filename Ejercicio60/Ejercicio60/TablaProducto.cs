using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio60
{
    public partial class TablaProducto : Form
    {
        DataTable tabla;
        SqlConnection miConexion;
        SqlCommand miComando;
        SqlDataReader objetoQueRecibe;
        public TablaProducto()
        {
            miComando = new SqlCommand();
            miConexion = new SqlConnection("Data Source = FAO\\SQLEXPRESS; Database = AdventureWorks2017; Trusted_Connection = true;");
            InitializeComponent();
            tabla = new DataTable();
        }

        private void TablaProducto_Load(object sender, EventArgs e)
        {

            try
            {
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Production.Product";

                miConexion.Open();


                objetoQueRecibe = miComando.ExecuteReader();

                tabla.Load(objetoQueRecibe);
                dgvTabla.DataSource = tabla;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir conexion");
            }
            finally
            {
                miConexion.Close();
            }
            miConexion.Close();


        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvTabla.CurrentRow.Cells[1].Value.ToString();
            txtCodigo.Text = dgvTabla.CurrentRow.Cells[2].Value.ToString();
            chkbFabricar.Checked = (bool)dgvTabla.CurrentRow.Cells[3].Value;
            chkbFinalizado.Checked = (bool)dgvTabla.CurrentRow.Cells[4].Value;
            switch (dgvTabla.CurrentRow.Cells[5].Value.ToString())
            {
                case "Black":
                    cbColor.SelectedIndex = 1;
                    break;
                case "Silver":
                    cbColor.SelectedIndex = 2;
                    break;
                case "Red":
                    cbColor.SelectedIndex = 3;
                    break;
                case "White":
                    cbColor.SelectedIndex = 4;
                    break;
                case "Blue":
                    cbColor.SelectedIndex = 5;
                    break;
                case "Multi":
                    cbColor.SelectedIndex = 6;
                    break;
                case "Yellow":
                    cbColor.SelectedIndex = 7;
                    break;
                case "Grey":
                    cbColor.SelectedIndex = 8;
                    break;
                case "Silver/Black":
                    cbColor.SelectedIndex = 9;
                    break;
                default:
                    cbColor.SelectedIndex = 0;
                    break;
            }
            txtStock.Text = dgvTabla.CurrentRow.Cells[6].Value.ToString();
            txtOrdenMin.Text = dgvTabla.CurrentRow.Cells[7].Value.ToString();
            txtCosto.Text = dgvTabla.CurrentRow.Cells[8].Value.ToString();
            txtPrecio.Text = dgvTabla.CurrentRow.Cells[9].Value.ToString();
            txtTamanio.Text = dgvTabla.CurrentRow.Cells[10].Value.ToString();
            cbUniMedida.Text = dgvTabla.CurrentRow.Cells[11].Value.ToString();
            cbUniPeso.Text = dgvTabla.CurrentRow.Cells[12].Value.ToString();
            txtPeso.Text = dgvTabla.CurrentRow.Cells[13].Value.ToString();
            txtDiasFabri.Text = dgvTabla.CurrentRow.Cells[14].Value.ToString();
            cbLineaProdc.Text = dgvTabla.CurrentRow.Cells[15].Value.ToString();
            cbClase.Text = dgvTabla.CurrentRow.Cells[16].Value.ToString();
            cbEstilo.Text = dgvTabla.CurrentRow.Cells[17].Value.ToString();
            cbIDSub.Text = dgvTabla.CurrentRow.Cells[18].Value.ToString();
            cbIdModelo.Text = dgvTabla.CurrentRow.Cells[19].Value.ToString();
            dtpIniVenta.Value = (DateTime)dgvTabla.CurrentRow.Cells[20].Value;
            if (dgvTabla.CurrentRow.Cells[21].Value.ToString() == "")
            {
                dtpFinalizaVenta.Enabled = false;
            }
            else
            {
                dtpFinalizaVenta.Value = (DateTime)dgvTabla.CurrentRow.Cells[21].Value;
                dtpFinalizaVenta.Enabled = true;
            }
            if (dgvTabla.CurrentRow.Cells[22].Value.ToString() == "")
            {
                dtpDiscon.Enabled = false;
            }
            else
            {
                dtpDiscon.Value = (DateTime)dgvTabla.CurrentRow.Cells[22].Value;
                dtpDiscon.Enabled = true;
            }
            txtGuid.Text = dgvTabla.CurrentRow.Cells[23].Value.ToString();
            dtpModificaVenta.Value = (DateTime)dgvTabla.CurrentRow.Cells[24].Value;
        }

        private void chkbFinalizaVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFinalizaVenta.Checked == true)
            {
                dtpFinalizaVenta.Enabled = true;
            }
            else
            {
                dtpFinalizaVenta.Enabled = false;
            }
        }

        private void chkbDiscontinua_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbDiscontinua.Checked == true)
            {
                dtpDiscon.Enabled = true;
            }
            else
            {
                dtpDiscon.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = miConexion;
                command.CommandType = CommandType.Text;

                command.CommandText = "INSERT INTO Production.Product VALUES(@Name, @ProductNumber, @MakeFlag, " +
                "@FinishedGoodsFlag, @Color, @SafetyStockLevel, @ReorderPoint, @StandardCost, @ListPrice, @Size, " +
                "@SizeUnitMeasureCode, @WeightUnitMeasureCode, @Weight, @DaysToManufacture, @ProductLine, @Class, " +
                "@Style, @ProductSubcategoryID, @ProductModelID, @SellStartDate, @SellEndDate, @DiscontinuedDate," +
                " @rowguid, @ModifiedDate)";//con el @ pasamos parametros
                command.Parameters.Add(new SqlParameter("Name", txtNombre.Text));
                command.Parameters.Add(new SqlParameter("ProductNumber", txtCodigo.Text));
                command.Parameters.Add(new SqlParameter("MakeFlag", chkbFabricar.Checked));
                command.Parameters.Add(new SqlParameter("FinishedGoodsFlag", chkbFabricar.Checked));
                if (cbColor.Text == "" || cbColor.Text == "Ninguno")
                {
                    command.Parameters.Add(new SqlParameter("Color", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("Color", cbColor.Text));
                }
                command.Parameters.Add(new SqlParameter("SafetyStockLevel", Int16.Parse(txtStock.Text)));
                command.Parameters.Add(new SqlParameter("ReorderPoint", Int16.Parse(txtOrdenMin.Text)));
                command.Parameters.Add(new SqlParameter("StandardCost", decimal.Parse(txtCosto.Text)));
                command.Parameters.Add(new SqlParameter("ListPrice", decimal.Parse(txtPrecio.Text)));
                command.Parameters.Add(new SqlParameter("Size", txtTamanio.Text));
                if (cbUniMedida.Text == "" || cbUniMedida.Text == "Ninguno")
                {
                    command.Parameters.Add(new SqlParameter("SizeUnitMeasureCode", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("SizeUnitMeasureCode", cbUniMedida.Text));
                }
                command.Parameters.Add(new SqlParameter("WeightUnitMeasureCode", cbUniPeso.Text));
                if (txtPeso.Text == "")
                {
                    command.Parameters.Add(new SqlParameter("Weight", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("Weight", decimal.Parse(txtPeso.Text)));
                }
                command.Parameters.Add(new SqlParameter("DaysToManufacture", int.Parse(txtDiasFabri.Text)));
                if (cbLineaProdc.Text == "" || cbLineaProdc.Text == "Ninguno")
                {
                    command.Parameters.Add(new SqlParameter("ProductLine", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("ProductLine", cbLineaProdc.Text));
                }
                if (cbClase.Text == "" || cbClase.Text == "Ninguno")
                {
                    command.Parameters.Add(new SqlParameter("Class", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("Class", cbClase.Text));
                }
                if (cbEstilo.Text == "" || cbEstilo.Text == "Ninguno")
                {
                    command.Parameters.Add(new SqlParameter("Style", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("Style", cbEstilo.Text));
                }
                if (cbIDSub.Text == "")
                {
                    command.Parameters.Add(new SqlParameter("ProductSubcategoryID", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("ProductSubcategoryID", int.Parse(cbIDSub.Text)));
                }
                if (cbIdModelo.Text == "")
                {
                    command.Parameters.Add(new SqlParameter("ProductModelID", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("ProductModelID", int.Parse(cbIdModelo.Text)));
                }
                command.Parameters.Add(new SqlParameter("SellStartDate", dtpIniVenta.Value));
                if (dtpFinalizaVenta.Text == "")
                {
                    command.Parameters.Add(new SqlParameter("SellEndDate", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("SellEndDate", dtpFinalizaVenta.Value));
                }
                if (dtpDiscon.Text == "")
                {
                    command.Parameters.Add(new SqlParameter("DiscontinuedDate", DBNull.Value));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("DiscontinuedDate", dtpDiscon.Value));
                }
                command.Parameters.Add(new SqlParameter("rowguid", Guid.Parse(txtGuid.Text)));
                command.Parameters.Add(new SqlParameter("ModifiedDate", dtpModificaVenta.Value));


                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }

                int cantidadInsert = command.ExecuteNonQuery();


                MessageBox.Show("Lineas insertadas " + cantidadInsert, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("El argumento no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato del argumento no era el esperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }
                SqlCommand comando = new SqlCommand();
                comando.Connection = miConexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "UPDATE Production.Product SET Name = @Name, ProductNumber = @ProductNumber, MakeFlag = @MakeFlag, " +
                    "FinishedGoodsFlag = @FinishedGoodsFlag, Color = @Color, SafetyStockLevel = @SafetyStockLevel, ReorderPoint = @ReorderPoint, StandardCost = @StandardCost, ListPrice = @ListPrice, Size = @Size, " +
                    "SizeUnitMeasureCode = @SizeUnitMeasureCode, WeightUnitMeasureCode = @WeightUnitMeasureCode, Weight = @Weight, DaysToManufacture = @DaysToManufacture, ProductLine = @ProductLine, Class = @Class, " +
                    "Style =@Style, ProductSubcategoryID = @ProductSubcategoryID, ProductModelID = @ProductModelID, SellStartDate = @SellStartDate, SellEndDate = @SellEndDate, DiscontinuedDate = @DiscontinuedDate," +
                    " rowguid = @rowguid, ModifiedDate = @ModifiedDate WHERE ProductID = @idTabla";
                comando.Parameters.Add(new SqlParameter("idTabla", (int)dgvTabla.CurrentRow.Cells[0].Value));
                comando.Parameters.Add(new SqlParameter("Name", txtNombre.Text));
                comando.Parameters.Add(new SqlParameter("ProductNumber", txtCodigo.Text));
                comando.Parameters.Add(new SqlParameter("MakeFlag", chkbFabricar.Checked));
                comando.Parameters.Add(new SqlParameter("FinishedGoodsFlag", chkbFabricar.Checked));
                if (cbColor.Text == "" || cbColor.Text == "Ninguno")
                {
                    comando.Parameters.Add(new SqlParameter("Color", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("Color", cbColor.Text));
                }
                comando.Parameters.Add(new SqlParameter("SafetyStockLevel", Int16.Parse(txtStock.Text)));
                comando.Parameters.Add(new SqlParameter("ReorderPoint", Int16.Parse(txtOrdenMin.Text)));
                comando.Parameters.Add(new SqlParameter("StandardCost", decimal.Parse(txtCosto.Text)));
                comando.Parameters.Add(new SqlParameter("ListPrice", decimal.Parse(txtPrecio.Text)));
                comando.Parameters.Add(new SqlParameter("Size", txtTamanio.Text));
                if (cbUniMedida.Text == "" || cbUniMedida.Text == "Ninguno")
                {
                    comando.Parameters.Add(new SqlParameter("SizeUnitMeasureCode", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("SizeUnitMeasureCode", cbUniMedida.Text));
                }
                if (cbUniPeso.Text == "" || cbUniPeso.Text == "Ninguno")
                {
                    comando.Parameters.Add(new SqlParameter("WeightUnitMeasureCode", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("WeightUnitMeasureCode", cbUniPeso.Text));
                }
                if (txtPeso.Text == "")
                {
                    comando.Parameters.Add(new SqlParameter("Weight", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("Weight", decimal.Parse(txtPeso.Text)));
                }
                comando.Parameters.Add(new SqlParameter("DaysToManufacture", int.Parse(txtDiasFabri.Text)));
                if (cbLineaProdc.Text == "" || cbLineaProdc.Text == "Ninguno")
                {
                    comando.Parameters.Add(new SqlParameter("ProductLine", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("ProductLine", cbLineaProdc.Text));
                }
                if (cbClase.Text == "" || cbClase.Text == "Ninguno")
                {
                    comando.Parameters.Add(new SqlParameter("Class", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("Class", cbClase.Text));
                }
                if (cbEstilo.Text == "" || cbEstilo.Text == "Ninguno")
                {
                    comando.Parameters.Add(new SqlParameter("Style", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("Style", cbEstilo.Text));
                }
                if (cbIDSub.Text == "")
                {
                    comando.Parameters.Add(new SqlParameter("ProductSubcategoryID", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("ProductSubcategoryID", int.Parse(cbIDSub.Text)));
                }
                if (cbIdModelo.Text == "")
                {
                    comando.Parameters.Add(new SqlParameter("ProductModelID", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("ProductModelID", int.Parse(cbIdModelo.Text)));
                }
                comando.Parameters.Add(new SqlParameter("SellStartDate", dtpIniVenta.Value));
                if (dtpFinalizaVenta.Text == "")
                {
                    comando.Parameters.Add(new SqlParameter("SellEndDate", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("SellEndDate", dtpFinalizaVenta.Value));
                }
                if (dtpDiscon.Text == "")
                {
                    comando.Parameters.Add(new SqlParameter("DiscontinuedDate", DBNull.Value));
                }
                else
                {
                    comando.Parameters.Add(new SqlParameter("DiscontinuedDate", dtpDiscon.Value));
                }
                comando.Parameters.Add(new SqlParameter("rowguid", Guid.Parse(txtGuid.Text)));
                comando.Parameters.Add(new SqlParameter("ModifiedDate", dtpModificaVenta.Value));


                comando.ExecuteNonQuery();
                MessageBox.Show("Se modificó con éxito");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("El argumento no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El formato del argumento no era el esperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            tabla.Clear();
            dgvTabla.DataSource = null;
            TablaProducto_Load(sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = String.Empty;
            txtCodigo.Text = String.Empty;
            chkbFabricar.Checked = false;
            chkbFinalizado.Checked = false;
            cbColor.Text = String.Empty;
            txtStock.Text = String.Empty;
            txtOrdenMin.Text = String.Empty;
            txtCosto.Text = String.Empty;
            txtPrecio.Text = String.Empty;
            txtTamanio.Text = String.Empty;
            cbUniMedida.Text = String.Empty;
            cbUniPeso.Text = String.Empty;
            txtPeso.Text = String.Empty;
            txtDiasFabri.Text = String.Empty;
            cbLineaProdc.Text = String.Empty;
            cbClase.Text = String.Empty;
            cbEstilo.Text = String.Empty;
            cbIDSub.Text = String.Empty;
            cbIdModelo.Text = String.Empty;
            dtpIniVenta.Value = DateTime.Now;
            dtpFinalizaVenta.Value = DateTime.Now;
            dtpFinalizaVenta.Enabled = false;
            chkbFinalizaVenta.Checked = false;
            dtpDiscon.Value = DateTime.Now;
            dtpDiscon.Enabled = false;
            chkbDiscontinua.Checked = false;
            txtGuid.Text = String.Empty;
            dtpModificaVenta.Value = DateTime.Now;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTabla.CurrentRow.Cells[0].Value.ToString() != "" || !(dgvTabla.CurrentRow.Cells[0].Value is null))
            {    
                try
                {
                    if (MessageBox.Show("¿Está seguro que quiere borrar este dato? Será irrecuperable", "¡ATENCION!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (miConexion.State != ConnectionState.Open)
                        {
                            miConexion.Open();
                        }
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = miConexion;
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "DELETE FROM Production.Product WHERE ProductID = @idTabla";
                        comando.Parameters.Add(new SqlParameter("idTabla", (int)dgvTabla.CurrentRow.Cells[0].Value));
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Se Borró con éxito"); 
                    }
                }
                catch (ArgumentNullException ex)
                {
                    MessageBox.Show("El argumento no puede ser nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
                catch(InvalidCastException ex)
                {
                    MessageBox.Show("Ocurrió un error de casteo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("El formato del argumento no era el esperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir la conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    miConexion.Close();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un dato para borrar");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                dgvTabla.DataSource = null;
                dgvTabla.Rows.Clear();
                tabla.Rows.Clear();
                if (miConexion.State != ConnectionState.Open)
                {
                    miConexion.Open();
                }
                command.Connection = miConexion;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM Production.Product WHERE ProductNumber = @codigo";//con el @ pasamos parametros
                command.Parameters.Clear();//antes de cargar uno nueva por las dudas los limpio por si intento cargar el mismo
                command.Parameters.Add(new SqlParameter("codigo", txtBuscar.Text));
                objetoQueRecibe = command.ExecuteReader();
                tabla.Load(objetoQueRecibe);
                dgvTabla.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la conexion", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();//tambien se puede usar el using para no tener que usar el Close()
            }
        }
    }
}

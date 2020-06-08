﻿using System;
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
            miConexion = new SqlConnection("Data Source = CALIDAD\\SQLEXPRESS; Database = AdventureWorks2017; Trusted_Connection = true;");
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
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            miConexion = new SqlConnection("Data Source = CALIDAD\\SQLEXPRESS; Database = AdventureWorks2017; Trusted_Connection = true;");

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
                command.Parameters.Add(new SqlParameter("Color", cbColor.Text));
                command.Parameters.Add(new SqlParameter("SafetyStockLevel", Int16.Parse(txtStock.Text)));
                command.Parameters.Add(new SqlParameter("ReorderPoint", Int16.Parse(txtOrdenMin.Text)));
                command.Parameters.Add(new SqlParameter("StandardCost", decimal.Parse(txtCosto.Text)));
                command.Parameters.Add(new SqlParameter("ListPrice", decimal.Parse(txtPrecio.Text)));
                command.Parameters.Add(new SqlParameter("Size", txtTamanio.Text));
                command.Parameters.Add(new SqlParameter("SizeUnitMeasureCode", cbUniMedida.Text));
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
                command.Parameters.Add(new SqlParameter("ProductLine", cbLineaProdc.Text));
                command.Parameters.Add(new SqlParameter("Class", cbClase.Text));
                command.Parameters.Add(new SqlParameter("Style", cbEstilo.Text));
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


                MessageBox.Show
                ("Lineas insertadas " + cantidadInsert, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show
                ("No se pudo abrir la conexion", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                MessageBox.Show
                (ex.Message);
            }
            finally
            {
                miConexion.Close();
            }
        }
    }
}
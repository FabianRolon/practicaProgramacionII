namespace Ejercicio60
{
    partial class TablaProducto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtTamanio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtOrdenMin = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbUniMedida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUniPeso = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiasFabri = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbLineaProdc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbClase = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbIDSub = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbIdModelo = new System.Windows.Forms.ComboBox();
            this.dtpFinalizaVenta = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dtpDiscon = new System.Windows.Forms.DateTimePicker();
            this.chkbFabricar = new System.Windows.Forms.CheckBox();
            this.chkbFinalizado = new System.Windows.Forms.CheckBox();
            this.chkbFinalizaVenta = new System.Windows.Forms.CheckBox();
            this.chkbDiscontinua = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.dtpIniVenta = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.dtpModificaVenta = new System.Windows.Forms.DateTimePicker();
            this.txtGuid = new System.Windows.Forms.TextBox();
            this.lblrowGuid = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.AllowUserToDeleteRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(20, 190);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.Size = new System.Drawing.Size(1340, 525);
            this.dgvTabla.TabIndex = 0;
            this.dgvTabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabla_CellContentClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(156, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(30, 68);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 1;
            // 
            // txtTamanio
            // 
            this.txtTamanio.Location = new System.Drawing.Point(956, 24);
            this.txtTamanio.Name = "txtTamanio";
            this.txtTamanio.Size = new System.Drawing.Size(100, 20);
            this.txtTamanio.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(437, 25);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(110, 20);
            this.txtStock.TabIndex = 1;
            // 
            // txtOrdenMin
            // 
            this.txtOrdenMin.Location = new System.Drawing.Point(566, 25);
            this.txtOrdenMin.Name = "txtOrdenMin";
            this.txtOrdenMin.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenMin.TabIndex = 1;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(696, 24);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(826, 24);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Orden minima";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Costo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(823, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Precio de lista";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(953, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tamanio";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Ninguno",
            "Black",
            "Silver",
            "Red",
            "White",
            "Blue",
            "Multi",
            "Yellow",
            "Grey",
            "Silver/Black"});
            this.cbColor.Location = new System.Drawing.Point(286, 24);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 3;
            // 
            // cbUniMedida
            // 
            this.cbUniMedida.FormattingEnabled = true;
            this.cbUniMedida.Items.AddRange(new object[] {
            "Ninguno",
            "CM"});
            this.cbUniMedida.Location = new System.Drawing.Point(1079, 25);
            this.cbUniMedida.Name = "cbUniMedida";
            this.cbUniMedida.Size = new System.Drawing.Size(121, 21);
            this.cbUniMedida.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1076, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Unidad de medida";
            // 
            // cbUniPeso
            // 
            this.cbUniPeso.FormattingEnabled = true;
            this.cbUniPeso.Items.AddRange(new object[] {
            "Ninguno",
            "LB",
            "G"});
            this.cbUniPeso.Location = new System.Drawing.Point(1206, 25);
            this.cbUniPeso.Name = "cbUniPeso";
            this.cbUniPeso.Size = new System.Drawing.Size(121, 21);
            this.cbUniPeso.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1203, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Unidad de peso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Peso";
            // 
            // txtDiasFabri
            // 
            this.txtDiasFabri.Location = new System.Drawing.Point(156, 68);
            this.txtDiasFabri.Name = "txtDiasFabri";
            this.txtDiasFabri.Size = new System.Drawing.Size(100, 20);
            this.txtDiasFabri.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(153, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Días de fabricación";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Linea de producto";
            // 
            // cbLineaProdc
            // 
            this.cbLineaProdc.FormattingEnabled = true;
            this.cbLineaProdc.Items.AddRange(new object[] {
            "Ninguno",
            "R",
            "S",
            "M",
            "T"});
            this.cbLineaProdc.Location = new System.Drawing.Point(286, 67);
            this.cbLineaProdc.Name = "cbLineaProdc";
            this.cbLineaProdc.Size = new System.Drawing.Size(121, 21);
            this.cbLineaProdc.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(434, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Clase";
            // 
            // cbClase
            // 
            this.cbClase.FormattingEnabled = true;
            this.cbClase.Items.AddRange(new object[] {
            "Ninguno",
            "L",
            "H",
            "M"});
            this.cbClase.Location = new System.Drawing.Point(437, 67);
            this.cbClase.Name = "cbClase";
            this.cbClase.Size = new System.Drawing.Size(121, 21);
            this.cbClase.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(581, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Estilo";
            // 
            // cbEstilo
            // 
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Items.AddRange(new object[] {
            "Ninguno",
            "U",
            "W",
            "M"});
            this.cbEstilo.Location = new System.Drawing.Point(584, 67);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(121, 21);
            this.cbEstilo.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(734, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "ID Subcategoría";
            // 
            // cbIDSub
            // 
            this.cbIDSub.FormattingEnabled = true;
            this.cbIDSub.Items.AddRange(new object[] {
            "Ninguno",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37"});
            this.cbIDSub.Location = new System.Drawing.Point(737, 67);
            this.cbIDSub.Name = "cbIDSub";
            this.cbIDSub.Size = new System.Drawing.Size(121, 21);
            this.cbIDSub.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(877, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "ID Modelo";
            // 
            // cbIdModelo
            // 
            this.cbIdModelo.FormattingEnabled = true;
            this.cbIdModelo.Items.AddRange(new object[] {
            "Ninguno",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100",
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "108",
            "109",
            "110",
            "111",
            "112",
            "113",
            "114",
            "115",
            "116",
            "117",
            "118",
            "119",
            "120",
            "121",
            "122",
            "123",
            "124",
            "125",
            "126",
            "127",
            "128"});
            this.cbIdModelo.Location = new System.Drawing.Point(880, 67);
            this.cbIdModelo.Name = "cbIdModelo";
            this.cbIdModelo.Size = new System.Drawing.Size(121, 21);
            this.cbIdModelo.TabIndex = 3;
            // 
            // dtpFinalizaVenta
            // 
            this.dtpFinalizaVenta.Enabled = false;
            this.dtpFinalizaVenta.Location = new System.Drawing.Point(359, 147);
            this.dtpFinalizaVenta.Name = "dtpFinalizaVenta";
            this.dtpFinalizaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpFinalizaVenta.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(356, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Finalizacion de venta";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(671, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Fecha de Discontinuidad";
            // 
            // dtpDiscon
            // 
            this.dtpDiscon.Enabled = false;
            this.dtpDiscon.Location = new System.Drawing.Point(674, 147);
            this.dtpDiscon.Name = "dtpDiscon";
            this.dtpDiscon.Size = new System.Drawing.Size(200, 20);
            this.dtpDiscon.TabIndex = 8;
            // 
            // chkbFabricar
            // 
            this.chkbFabricar.AutoSize = true;
            this.chkbFabricar.Location = new System.Drawing.Point(602, 98);
            this.chkbFabricar.Name = "chkbFabricar";
            this.chkbFabricar.Size = new System.Drawing.Size(64, 17);
            this.chkbFabricar.TabIndex = 9;
            this.chkbFabricar.Text = "Fabricar";
            this.chkbFabricar.UseVisualStyleBackColor = true;
            // 
            // chkbFinalizado
            // 
            this.chkbFinalizado.AutoSize = true;
            this.chkbFinalizado.Location = new System.Drawing.Point(486, 98);
            this.chkbFinalizado.Name = "chkbFinalizado";
            this.chkbFinalizado.Size = new System.Drawing.Size(91, 17);
            this.chkbFinalizado.TabIndex = 10;
            this.chkbFinalizado.Text = "Finalizado OK";
            this.chkbFinalizado.UseVisualStyleBackColor = true;
            // 
            // chkbFinalizaVenta
            // 
            this.chkbFinalizaVenta.AutoSize = true;
            this.chkbFinalizaVenta.Location = new System.Drawing.Point(262, 150);
            this.chkbFinalizaVenta.Name = "chkbFinalizaVenta";
            this.chkbFinalizaVenta.Size = new System.Drawing.Size(91, 17);
            this.chkbFinalizaVenta.TabIndex = 11;
            this.chkbFinalizaVenta.Text = "Finaliza venta";
            this.chkbFinalizaVenta.UseVisualStyleBackColor = true;
            this.chkbFinalizaVenta.CheckedChanged += new System.EventHandler(this.chkbFinalizaVenta_CheckedChanged);
            // 
            // chkbDiscontinua
            // 
            this.chkbDiscontinua.AutoSize = true;
            this.chkbDiscontinua.Location = new System.Drawing.Point(584, 150);
            this.chkbDiscontinua.Name = "chkbDiscontinua";
            this.chkbDiscontinua.Size = new System.Drawing.Size(82, 17);
            this.chkbDiscontinua.TabIndex = 12;
            this.chkbDiscontinua.Text = "Discontinua";
            this.chkbDiscontinua.UseVisualStyleBackColor = true;
            this.chkbDiscontinua.CheckedChanged += new System.EventHandler(this.chkbDiscontinua_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1124, 102);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1285, 102);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Inicio de venta";
            // 
            // dtpIniVenta
            // 
            this.dtpIniVenta.Location = new System.Drawing.Point(30, 147);
            this.dtpIniVenta.Name = "dtpIniVenta";
            this.dtpIniVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpIniVenta.TabIndex = 8;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(903, 131);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(97, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Modificacion venta";
            // 
            // dtpModificaVenta
            // 
            this.dtpModificaVenta.Location = new System.Drawing.Point(906, 147);
            this.dtpModificaVenta.Name = "dtpModificaVenta";
            this.dtpModificaVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpModificaVenta.TabIndex = 8;
            // 
            // txtGuid
            // 
            this.txtGuid.Location = new System.Drawing.Point(30, 107);
            this.txtGuid.Name = "txtGuid";
            this.txtGuid.Size = new System.Drawing.Size(223, 20);
            this.txtGuid.TabIndex = 1;
            // 
            // lblrowGuid
            // 
            this.lblrowGuid.AutoSize = true;
            this.lblrowGuid.Location = new System.Drawing.Point(27, 91);
            this.lblrowGuid.Name = "lblrowGuid";
            this.lblrowGuid.Size = new System.Drawing.Size(29, 13);
            this.lblrowGuid.TabIndex = 2;
            this.lblrowGuid.Text = "Guid";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1205, 73);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(1286, 73);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1124, 73);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(111, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(131, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar por codigo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 19);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(1118, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 49);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // TablaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 727);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkbDiscontinua);
            this.Controls.Add(this.chkbFinalizaVenta);
            this.Controls.Add(this.chkbFinalizado);
            this.Controls.Add(this.chkbFabricar);
            this.Controls.Add(this.dtpModificaVenta);
            this.Controls.Add(this.dtpDiscon);
            this.Controls.Add(this.dtpIniVenta);
            this.Controls.Add(this.dtpFinalizaVenta);
            this.Controls.Add(this.cbUniPeso);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbUniMedida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbIdModelo);
            this.Controls.Add(this.cbIDSub);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.cbClase);
            this.Controls.Add(this.cbLineaProdc);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblrowGuid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtOrdenMin);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtTamanio);
            this.Controls.Add(this.txtGuid);
            this.Controls.Add(this.txtDiasFabri);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvTabla);
            this.Name = "TablaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabla Producto";
            this.Load += new System.EventHandler(this.TablaProducto_Load);
            this.Resize += new System.EventHandler(this.TablaProducto_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtTamanio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtOrdenMin;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbUniMedida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUniPeso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiasFabri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbLineaProdc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbClase;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbIDSub;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cbIdModelo;
        private System.Windows.Forms.DateTimePicker dtpFinalizaVenta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtpDiscon;
        private System.Windows.Forms.CheckBox chkbFabricar;
        private System.Windows.Forms.CheckBox chkbFinalizado;
        private System.Windows.Forms.CheckBox chkbFinalizaVenta;
        private System.Windows.Forms.CheckBox chkbDiscontinua;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker dtpIniVenta;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker dtpModificaVenta;
        private System.Windows.Forms.TextBox txtGuid;
        private System.Windows.Forms.Label lblrowGuid;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


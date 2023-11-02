namespace PuntoDeVentas
{
    partial class NuevaFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTipoConsumidor = new System.Windows.Forms.ComboBox();
            this.txtIngresarNit = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.datagridClientes = new System.Windows.Forms.DataGridView();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calendarioEmision = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSubtotal = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.datagridProductos = new System.Windows.Forms.DataGridView();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.btnVaciarFactura = new System.Windows.Forms.Button();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.datagridDetalles = new System.Windows.Forms.DataGridView();
            this.txtIdDetalle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridClientes)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBuscarCliente);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbTipoConsumidor);
            this.panel2.Controls.Add(this.txtIngresarNit);
            this.panel2.Controls.Add(this.lblNit);
            this.panel2.Controls.Add(this.datagridClientes);
            this.panel2.Controls.Add(this.txtId_Cliente);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(1010, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 519);
            this.panel2.TabIndex = 52;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(496, 265);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(144, 49);
            this.btnBuscarCliente.TabIndex = 19;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Visible = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "TIPO DE CONSUMIDOR:";
            // 
            // cbTipoConsumidor
            // 
            this.cbTipoConsumidor.FormattingEnabled = true;
            this.cbTipoConsumidor.Items.AddRange(new object[] {
            "C/F",
            "NIT"});
            this.cbTipoConsumidor.Location = new System.Drawing.Point(476, 88);
            this.cbTipoConsumidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipoConsumidor.Name = "cbTipoConsumidor";
            this.cbTipoConsumidor.Size = new System.Drawing.Size(180, 28);
            this.cbTipoConsumidor.TabIndex = 16;
            this.cbTipoConsumidor.SelectedIndexChanged += new System.EventHandler(this.cbTipoConsumidor_SelectedIndexChanged);
            // 
            // txtIngresarNit
            // 
            this.txtIngresarNit.Location = new System.Drawing.Point(476, 209);
            this.txtIngresarNit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngresarNit.Name = "txtIngresarNit";
            this.txtIngresarNit.Size = new System.Drawing.Size(200, 26);
            this.txtIngresarNit.TabIndex = 15;
            this.txtIngresarNit.Visible = false;
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(507, 168);
            this.lblNit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(117, 20);
            this.lblNit.TabIndex = 14;
            this.lblNit.Text = "Ingresar el NIT:";
            this.lblNit.Visible = false;
            // 
            // datagridClientes
            // 
            this.datagridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridClientes.Enabled = false;
            this.datagridClientes.Location = new System.Drawing.Point(24, 88);
            this.datagridClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridClientes.Name = "datagridClientes";
            this.datagridClientes.RowHeadersWidth = 62;
            this.datagridClientes.Size = new System.Drawing.Size(414, 391);
            this.datagridClientes.TabIndex = 13;
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Location = new System.Drawing.Point(144, 25);
            this.txtId_Cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.Size = new System.Drawing.Size(148, 26);
            this.txtId_Cliente.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "ID CLIENTE:";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Enabled = false;
            this.txtIdFactura.Location = new System.Drawing.Point(630, 206);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(168, 26);
            this.txtIdFactura.TabIndex = 50;
            this.txtIdFactura.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtIdFactura_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID FACTURA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 64);
            this.label1.TabIndex = 53;
            this.label1.Text = "FACTURACION";
            // 
            // calendarioEmision
            // 
            this.calendarioEmision.Location = new System.Drawing.Point(390, 303);
            this.calendarioEmision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarioEmision.Name = "calendarioEmision";
            this.calendarioEmision.Size = new System.Drawing.Size(394, 26);
            this.calendarioEmision.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "FECHA DE EMISIÓN:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(166, 35);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(130, 26);
            this.txtIdProducto.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 46);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "ID PRODUCTO:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSubtotal);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtCantidad);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtBuscarProducto);
            this.panel3.Controls.Add(this.btnAgregarProducto);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.datagridProductos);
            this.panel3.Controls.Add(this.txtIdProducto);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(1010, 649);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 560);
            this.panel3.TabIndex = 70;
            // 
            // btnSubtotal
            // 
            this.btnSubtotal.Location = new System.Drawing.Point(476, 465);
            this.btnSubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubtotal.Name = "btnSubtotal";
            this.btnSubtotal.Size = new System.Drawing.Size(154, 63);
            this.btnSubtotal.TabIndex = 82;
            this.btnSubtotal.Text = "GENERAR SUBTOTAL";
            this.btnSubtotal.UseVisualStyleBackColor = true;
            this.btnSubtotal.Click += new System.EventHandler(this.btnSubtotal_Click);
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(450, 397);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(188, 26);
            this.txtSubtotal.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(338, 402);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 74;
            this.label15.Text = "Subtotal (Q) :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(118, 397);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(148, 26);
            this.txtCantidad.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 402);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 20);
            this.label14.TabIndex = 72;
            this.label14.Text = "Cantidad:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(392, 57);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(229, 26);
            this.txtBuscarProducto.TabIndex = 71;
            this.txtBuscarProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProducto_KeyPress);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(36, 482);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(228, 46);
            this.btnAgregarProducto.TabIndex = 81;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(393, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "ingrese el nombre de producto:";
            // 
            // datagridProductos
            // 
            this.datagridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProductos.Location = new System.Drawing.Point(34, 112);
            this.datagridProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridProductos.Name = "datagridProductos";
            this.datagridProductos.RowHeadersWidth = 62;
            this.datagridProductos.Size = new System.Drawing.Size(606, 252);
            this.datagridProductos.TabIndex = 10;
            this.datagridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProductos_CellDoubleClick);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(306, 205);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(148, 26);
            this.txtIdUsuario.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "ID USUARIO:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTotalFactura);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnGuardarFactura);
            this.panel1.Controls.Add(this.btnVaciarFactura);
            this.panel1.Controls.Add(this.btnQuitarProducto);
            this.panel1.Controls.Add(this.datagridDetalles);
            this.panel1.Controls.Add(this.txtIdDetalle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(48, 415);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 794);
            this.panel1.TabIndex = 87;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 62);
            this.button1.TabIndex = 94;
            this.button1.Text = "VACIAR DETALLES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Location = new System.Drawing.Point(224, 725);
            this.txtTotalFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(211, 26);
            this.txtTotalFactura.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 729);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "TOTAL A PAGAR:";
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.Location = new System.Drawing.Point(645, 715);
            this.btnGuardarFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(192, 46);
            this.btnGuardarFactura.TabIndex = 93;
            this.btnGuardarFactura.Text = "GUARDAR FACTURA";
            this.btnGuardarFactura.UseVisualStyleBackColor = true;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // btnVaciarFactura
            // 
            this.btnVaciarFactura.Location = new System.Drawing.Point(748, 142);
            this.btnVaciarFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVaciarFactura.Name = "btnVaciarFactura";
            this.btnVaciarFactura.Size = new System.Drawing.Size(136, 62);
            this.btnVaciarFactura.TabIndex = 92;
            this.btnVaciarFactura.Text = "VACIAR FACTURA";
            this.btnVaciarFactura.UseVisualStyleBackColor = true;
            this.btnVaciarFactura.Click += new System.EventHandler(this.btnVaciarFactura_Click);
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(435, 143);
            this.btnQuitarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(136, 66);
            this.btnQuitarProducto.TabIndex = 91;
            this.btnQuitarProducto.Text = "QUITAR PRODUCTO";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // datagridDetalles
            // 
            this.datagridDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDetalles.Location = new System.Drawing.Point(36, 240);
            this.datagridDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridDetalles.Name = "datagridDetalles";
            this.datagridDetalles.RowHeadersWidth = 62;
            this.datagridDetalles.Size = new System.Drawing.Size(849, 438);
            this.datagridDetalles.TabIndex = 89;
            // 
            // txtIdDetalle
            // 
            this.txtIdDetalle.Enabled = false;
            this.txtIdDetalle.Location = new System.Drawing.Point(202, 158);
            this.txtIdDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdDetalle.Name = "txtIdDetalle";
            this.txtIdDetalle.Size = new System.Drawing.Size(168, 26);
            this.txtIdDetalle.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "ID DETALLE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(195, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(504, 37);
            this.label5.TabIndex = 85;
            this.label5.Text = "DETALLES DE FACTURACION --";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // NuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1760, 1229);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.calendarioEmision);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NuevaFactura";
            this.Text = "NuevaFactura";
            this.Load += new System.EventHandler(this.NuevaFactura_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridClientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker calendarioEmision;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView datagridProductos;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoConsumidor;
        private System.Windows.Forms.TextBox txtIngresarNit;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.DataGridView datagridClientes;
        private System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTotalFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.Button btnVaciarFactura;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.DataGridView datagridDetalles;
        private System.Windows.Forms.TextBox txtIdDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubtotal;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtIdUsuario;
    }
}
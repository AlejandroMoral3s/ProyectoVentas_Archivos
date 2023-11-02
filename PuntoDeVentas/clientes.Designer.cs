namespace PuntoDeVentas
{
    partial class Clientes
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
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.datagridClientes = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarDocumento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datagridDocumentos = new System.Windows.Forms.DataGridView();
            this.txtIdDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBuscarMunicipio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.datagridMunicipios = new System.Windows.Forms.DataGridView();
            this.txtIdMunicipio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.calendarioNacimiento = new System.Windows.Forms.DateTimePicker();
            this.calendarioIngreso = new System.Windows.Forms.DateTimePicker();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridClientes)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDocumentos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMunicipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(1239, 538);
            this.txtBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(300, 26);
            this.txtBuscarCliente.TabIndex = 58;
            this.txtBuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarCliente_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1530, 606);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 46);
            this.btnCancelar.TabIndex = 57;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1414, 606);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 46);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1299, 606);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 46);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(1184, 606);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(112, 46);
            this.btnCrear.TabIndex = 54;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(1026, 606);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(112, 46);
            this.btnUltimo.TabIndex = 53;
            this.btnUltimo.Text = ">>|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(910, 606);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 46);
            this.btnSiguiente.TabIndex = 52;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(795, 606);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(112, 46);
            this.btnAnterior.TabIndex = 51;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(680, 606);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(112, 46);
            this.btnPrimero.TabIndex = 50;
            this.btnPrimero.Text = "|<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // datagridClientes
            // 
            this.datagridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridClientes.Location = new System.Drawing.Point(81, 702);
            this.datagridClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridClientes.Name = "datagridClientes";
            this.datagridClientes.RowHeadersWidth = 62;
            this.datagridClientes.Size = new System.Drawing.Size(1484, 305);
            this.datagridClientes.TabIndex = 37;
            this.datagridClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridClientes_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(75, 626);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "FECHA DE INGRESO:";
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtBuscarDocumento);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.datagridDocumentos);
            this.panel1.Controls.Add(this.txtIdDocumento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(645, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 402);
            this.panel1.TabIndex = 47;
            // 
            // txtBuscarDocumento
            // 
            this.txtBuscarDocumento.Location = new System.Drawing.Point(51, 146);
            this.txtBuscarDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarDocumento.Name = "txtBuscarDocumento";
            this.txtBuscarDocumento.Size = new System.Drawing.Size(328, 26);
            this.txtBuscarDocumento.TabIndex = 7;
            this.txtBuscarDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarDocumento_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ingresar el documento a buscar:";
            // 
            // datagridDocumentos
            // 
            this.datagridDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDocumentos.Location = new System.Drawing.Point(34, 209);
            this.datagridDocumentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridDocumentos.Name = "datagridDocumentos";
            this.datagridDocumentos.RowHeadersWidth = 62;
            this.datagridDocumentos.Size = new System.Drawing.Size(360, 154);
            this.datagridDocumentos.TabIndex = 5;
            this.datagridDocumentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridDocumentos_CellDoubleClick);
            // 
            // txtIdDocumento
            // 
            this.txtIdDocumento.Location = new System.Drawing.Point(212, 35);
            this.txtIdDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdDocumento.Name = "txtIdDocumento";
            this.txtIdDocumento.Size = new System.Drawing.Size(148, 26);
            this.txtIdDocumento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID DOCUMENTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 563);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "FECHA DE NACIMIENTO:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(231, 485);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(300, 26);
            this.txtDireccion.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 489);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 43;
            this.label9.Text = "DIRECCION:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(794, 494);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(218, 26);
            this.txtTelefono.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 505);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "TELEFONO: ";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(231, 428);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(300, 26);
            this.txtApellidos.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 432);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "APELLIDOS:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(231, 371);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(300, 26);
            this.txtNombres.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "NOMBRES:";
            // 
            // txtNit
            // 
            this.txtNit.Location = new System.Drawing.Point(231, 317);
            this.txtNit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(202, 26);
            this.txtNit.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "NO. NIT:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(231, 169);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(168, 26);
            this.txtIdCliente.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 64);
            this.label1.TabIndex = 30;
            this.label1.Text = "CLIENTES";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBuscarMunicipio);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.datagridMunicipios);
            this.panel2.Controls.Add(this.txtIdMunicipio);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(1144, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 402);
            this.panel2.TabIndex = 48;
            // 
            // txtBuscarMunicipio
            // 
            this.txtBuscarMunicipio.Location = new System.Drawing.Point(51, 146);
            this.txtBuscarMunicipio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarMunicipio.Name = "txtBuscarMunicipio";
            this.txtBuscarMunicipio.Size = new System.Drawing.Size(328, 26);
            this.txtBuscarMunicipio.TabIndex = 7;
            this.txtBuscarMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMunicipio_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(223, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ingresar el municipio a buscar:";
            // 
            // datagridMunicipios
            // 
            this.datagridMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridMunicipios.Location = new System.Drawing.Point(34, 209);
            this.datagridMunicipios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridMunicipios.Name = "datagridMunicipios";
            this.datagridMunicipios.RowHeadersWidth = 62;
            this.datagridMunicipios.Size = new System.Drawing.Size(360, 154);
            this.datagridMunicipios.TabIndex = 5;
            this.datagridMunicipios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridMunicipios_CellDoubleClick);
            // 
            // txtIdMunicipio
            // 
            this.txtIdMunicipio.Location = new System.Drawing.Point(188, 35);
            this.txtIdMunicipio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdMunicipio.Name = "txtIdMunicipio";
            this.txtIdMunicipio.Size = new System.Drawing.Size(148, 26);
            this.txtIdMunicipio.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 40);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "ID MUNICIPIO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1140, 485);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(478, 20);
            this.label14.TabIndex = 59;
            this.label14.Text = "INGRESE EL NOMBRE O APELLIDO DEL CLIENTE A BUSCAR:";
            // 
            // calendarioNacimiento
            // 
            this.calendarioNacimiento.Location = new System.Drawing.Point(302, 552);
            this.calendarioNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarioNacimiento.Name = "calendarioNacimiento";
            this.calendarioNacimiento.Size = new System.Drawing.Size(298, 26);
            this.calendarioNacimiento.TabIndex = 60;
            // 
            // calendarioIngreso
            // 
            this.calendarioIngreso.Location = new System.Drawing.Point(302, 626);
            this.calendarioIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calendarioIngreso.Name = "calendarioIngreso";
            this.calendarioIngreso.Size = new System.Drawing.Size(298, 26);
            this.calendarioIngreso.TabIndex = 61;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.Location = new System.Drawing.Point(231, 262);
            this.txtNoDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(202, 26);
            this.txtNoDocumento.TabIndex = 63;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(72, 266);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 20);
            this.label15.TabIndex = 62;
            this.label15.Text = "NO. DOCUMENTO:";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1660, 1050);
            this.Controls.Add(this.txtNoDocumento);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.calendarioIngreso);
            this.Controls.Add(this.calendarioNacimiento);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.datagridClientes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDocumentos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMunicipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.DataGridView datagridClientes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscarDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datagridDocumentos;
        private System.Windows.Forms.TextBox txtIdDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBuscarMunicipio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView datagridMunicipios;
        private System.Windows.Forms.TextBox txtIdMunicipio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker calendarioNacimiento;
        private System.Windows.Forms.DateTimePicker calendarioIngreso;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txtNoDocumento;
        private System.Windows.Forms.Label label15;
    }
}
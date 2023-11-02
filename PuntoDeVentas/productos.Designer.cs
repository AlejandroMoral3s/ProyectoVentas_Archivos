namespace PuntoDeVentas
{
    partial class productos
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
            this.txtBuscarProductos = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.datagridProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarIva = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.datagridIva = new System.Windows.Forms.DataGridView();
            this.txtIdIva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridIva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.Location = new System.Drawing.Point(1100, 595);
            this.txtBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.Size = new System.Drawing.Size(391, 26);
            this.txtBuscarProductos.TabIndex = 58;
            this.txtBuscarProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarProductos_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(946, 586);
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
            this.btnEliminar.Location = new System.Drawing.Point(831, 586);
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
            this.btnActualizar.Location = new System.Drawing.Point(716, 586);
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
            this.btnCrear.Location = new System.Drawing.Point(600, 586);
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
            this.btnUltimo.Location = new System.Drawing.Point(393, 586);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(112, 46);
            this.btnUltimo.TabIndex = 53;
            this.btnUltimo.Text = ">>|";
            this.btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(278, 586);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 46);
            this.btnSiguiente.TabIndex = 52;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(162, 586);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(112, 46);
            this.btnAnterior.TabIndex = 51;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(46, 586);
            this.btnPrimero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(112, 46);
            this.btnPrimero.TabIndex = 50;
            this.btnPrimero.Text = "|<<";
            this.btnPrimero.UseVisualStyleBackColor = true;
            // 
            // datagridProductos
            // 
            this.datagridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridProductos.Location = new System.Drawing.Point(45, 668);
            this.datagridProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridProductos.Name = "datagridProductos";
            this.datagridProductos.RowHeadersWidth = 62;
            this.datagridProductos.Size = new System.Drawing.Size(1484, 305);
            this.datagridProductos.TabIndex = 37;
            this.datagridProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridProductos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBuscarIva);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.datagridIva);
            this.panel1.Controls.Add(this.txtIdIva);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(724, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 329);
            this.panel1.TabIndex = 47;
            // 
            // txtBuscarIva
            // 
            this.txtBuscarIva.Location = new System.Drawing.Point(438, 174);
            this.txtBuscarIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarIva.Name = "txtBuscarIva";
            this.txtBuscarIva.Size = new System.Drawing.Size(328, 26);
            this.txtBuscarIva.TabIndex = 7;
            this.txtBuscarIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarIva_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ingresar el tipo de IVA:";
            // 
            // datagridIva
            // 
            this.datagridIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridIva.Location = new System.Drawing.Point(50, 120);
            this.datagridIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datagridIva.Name = "datagridIva";
            this.datagridIva.RowHeadersWidth = 62;
            this.datagridIva.Size = new System.Drawing.Size(360, 123);
            this.datagridIva.TabIndex = 5;
            this.datagridIva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridIva_CellDoubleClick);
            // 
            // txtIdIva
            // 
            this.txtIdIva.Location = new System.Drawing.Point(188, 35);
            this.txtIdIva.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdIva.Name = "txtIdIva";
            this.txtIdIva.Size = new System.Drawing.Size(148, 26);
            this.txtIdIva.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID IVA:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(232, 458);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(900, 69);
            this.txtNota.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 463);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "NOTA:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(232, 378);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(300, 26);
            this.txtPrecio.TabIndex = 40;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "PRECIO (Q):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(232, 289);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(421, 26);
            this.txtNombre.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "NOMBRE PRODUCTO:";
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Enabled = false;
            this.txtIdProducto.Location = new System.Drawing.Point(201, 192);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(168, 26);
            this.txtIdProducto.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID PRODUCTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 64);
            this.label1.TabIndex = 30;
            this.label1.Text = "PRODUCTOS";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1170, 560);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingresar el nombre de producto:";
            // 
            // productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1037);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscarProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.datagridProductos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "productos";
            this.Text = "productos";
            this.Load += new System.EventHandler(this.productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridIva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarProductos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.DataGridView datagridProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscarIva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView datagridIva;
        private System.Windows.Forms.TextBox txtIdIva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label5;
    }
}
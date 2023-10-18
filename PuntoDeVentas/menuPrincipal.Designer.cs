namespace PuntoDeVentas
{
    partial class menuPrincipal
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.pestaniaArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.subOpcionIva = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionCambiarClave = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionCambiarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.opcionSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.pestaniaMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionNuevaFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionReporteFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.pestaniaAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionInformacion = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.perfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.municipioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1133, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // pestaniaArchivo
            // 
            this.pestaniaArchivo.Name = "pestaniaArchivo";
            this.pestaniaArchivo.Size = new System.Drawing.Size(70, 20);
            this.pestaniaArchivo.Text = "ARCHIVO";
            // 
            // opcionClientes
            // 
            this.opcionClientes.Name = "opcionClientes";
            this.opcionClientes.Size = new System.Drawing.Size(180, 22);
            this.opcionClientes.Text = "Clientes";
            this.opcionClientes.Click += new System.EventHandler(this.opcionClientes_Click);
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.documentoToolStripMenuItem.Text = "Documentos";
            this.documentoToolStripMenuItem.Click += new System.EventHandler(this.documentoToolStripMenuItem_Click);
            // 
            // opcionProductos
            // 
            this.opcionProductos.Name = "opcionProductos";
            this.opcionProductos.Size = new System.Drawing.Size(180, 22);
            this.opcionProductos.Text = "Productos";
            this.opcionProductos.Click += new System.EventHandler(this.opcionProductos_Click);
            // 
            // subOpcionIva
            // 
            this.subOpcionIva.Name = "subOpcionIva";
            this.subOpcionIva.Size = new System.Drawing.Size(180, 22);
            this.subOpcionIva.Text = "Iva";
            this.subOpcionIva.Click += new System.EventHandler(this.subOpcionIva_Click);
            // 
            // opcionUsuarios
            // 
            this.opcionUsuarios.Name = "opcionUsuarios";
            this.opcionUsuarios.Size = new System.Drawing.Size(180, 22);
            this.opcionUsuarios.Text = "Usuarios";
            this.opcionUsuarios.Click += new System.EventHandler(this.opcionUsuarios_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // opcionCambiarClave
            // 
            this.opcionCambiarClave.Name = "opcionCambiarClave";
            this.opcionCambiarClave.Size = new System.Drawing.Size(180, 22);
            this.opcionCambiarClave.Text = "Cambiar Clave";
            this.opcionCambiarClave.Click += new System.EventHandler(this.opcionCambiarClave_Click);
            // 
            // opcionCambiarUsuario
            // 
            this.opcionCambiarUsuario.Name = "opcionCambiarUsuario";
            this.opcionCambiarUsuario.Size = new System.Drawing.Size(180, 22);
            this.opcionCambiarUsuario.Text = "Cambiar de Usuario";
            this.opcionCambiarUsuario.Click += new System.EventHandler(this.opcionCambiarUsuario_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // opcionSalir
            // 
            this.opcionSalir.Name = "opcionSalir";
            this.opcionSalir.Size = new System.Drawing.Size(180, 22);
            this.opcionSalir.Text = "SALIR";
            this.opcionSalir.Click += new System.EventHandler(this.opcionSalir_Click);
            // 
            // pestaniaMovimientos
            // 
            this.pestaniaMovimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionNuevaFactura,
            this.opcionReporteFacturas});
            this.pestaniaMovimientos.Name = "pestaniaMovimientos";
            this.pestaniaMovimientos.Size = new System.Drawing.Size(98, 20);
            this.pestaniaMovimientos.Text = "MOVIMIENTOS";
            // 
            // opcionNuevaFactura
            // 
            this.opcionNuevaFactura.Name = "opcionNuevaFactura";
            this.opcionNuevaFactura.Size = new System.Drawing.Size(178, 22);
            this.opcionNuevaFactura.Text = "Nueva Factura";
            this.opcionNuevaFactura.Click += new System.EventHandler(this.opcionNuevaFactura_Click);
            // 
            // opcionReporteFacturas
            // 
            this.opcionReporteFacturas.Name = "opcionReporteFacturas";
            this.opcionReporteFacturas.Size = new System.Drawing.Size(178, 22);
            this.opcionReporteFacturas.Text = "Reporte de Facturas";
            this.opcionReporteFacturas.Click += new System.EventHandler(this.opcionReporteFacturas_Click);
            // 
            // pestaniaAyuda
            // 
            this.pestaniaAyuda.Name = "pestaniaAyuda";
            this.pestaniaAyuda.Size = new System.Drawing.Size(57, 20);
            this.pestaniaAyuda.Text = "AYUDA";
            // 
            // opcionInformacion
            // 
            this.opcionInformacion.Name = "opcionInformacion";
            this.opcionInformacion.Size = new System.Drawing.Size(214, 22);
            this.opcionInformacion.Text = "Informacion de Aplicacion";
            this.opcionInformacion.Click += new System.EventHandler(this.opcionInformacion_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 27);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1130, 725);
            this.panelPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntoDeVentas.Properties.Resources.Ventas011;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1127, 722);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // perfilesToolStripMenuItem
            // 
            this.perfilesToolStripMenuItem.Name = "perfilesToolStripMenuItem";
            this.perfilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.perfilesToolStripMenuItem.Text = "Perfiles";
            this.perfilesToolStripMenuItem.Click += new System.EventHandler(this.perfilesToolStripMenuItem_Click);
            // 
            // municipioToolStripMenuItem
            // 
            this.municipioToolStripMenuItem.Name = "municipioToolStripMenuItem";
            this.municipioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.municipioToolStripMenuItem.Text = "Municipios";
            this.municipioToolStripMenuItem.Click += new System.EventHandler(this.municipioToolStripMenuItem_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 758);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "menuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.menuPrincipal_Load);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem pestaniaArchivo;
        private System.Windows.Forms.ToolStripMenuItem pestaniaMovimientos;
        private System.Windows.Forms.ToolStripMenuItem pestaniaAyuda;
        private System.Windows.Forms.ToolStripMenuItem opcionClientes;
        private System.Windows.Forms.ToolStripMenuItem opcionProductos;
        private System.Windows.Forms.ToolStripMenuItem opcionUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opcionCambiarClave;
        private System.Windows.Forms.ToolStripMenuItem opcionCambiarUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem opcionSalir;
        private System.Windows.Forms.ToolStripMenuItem opcionNuevaFactura;
        private System.Windows.Forms.ToolStripMenuItem opcionReporteFacturas;
        private System.Windows.Forms.ToolStripMenuItem opcionInformacion;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subOpcionIva;
        private System.Windows.Forms.ToolStripMenuItem municipioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
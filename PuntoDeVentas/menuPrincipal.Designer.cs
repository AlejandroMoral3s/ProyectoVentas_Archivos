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
            this.opcionProductos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.opcionPerfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pestaniaArchivo,
            this.pestaniaMovimientos,
            this.pestaniaAyuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1104, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // pestaniaArchivo
            // 
            this.pestaniaArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionClientes,
            this.opcionProductos,
            this.opcionUsuarios,
            this.toolStripSeparator1,
            this.opcionCambiarClave,
            this.opcionCambiarUsuario,
            this.toolStripSeparator2,
            this.opcionSalir});
            this.pestaniaArchivo.Name = "pestaniaArchivo";
            this.pestaniaArchivo.Size = new System.Drawing.Size(70, 20);
            this.pestaniaArchivo.Text = "ARCHIVO";
            // 
            // opcionClientes
            // 
            this.opcionClientes.Name = "opcionClientes";
            this.opcionClientes.Size = new System.Drawing.Size(178, 22);
            this.opcionClientes.Text = "Clientes";
            this.opcionClientes.Click += new System.EventHandler(this.opcionClientes_Click);
            // 
            // opcionProductos
            // 
            this.opcionProductos.Name = "opcionProductos";
            this.opcionProductos.Size = new System.Drawing.Size(178, 22);
            this.opcionProductos.Text = "Productos";
            this.opcionProductos.Click += new System.EventHandler(this.opcionProductos_Click);
            // 
            // opcionUsuarios
            // 
            this.opcionUsuarios.Name = "opcionUsuarios";
            this.opcionUsuarios.Size = new System.Drawing.Size(178, 22);
            this.opcionUsuarios.Text = "Usuarios";
            this.opcionUsuarios.Click += new System.EventHandler(this.opcionUsuarios_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // opcionCambiarClave
            // 
            this.opcionCambiarClave.Name = "opcionCambiarClave";
            this.opcionCambiarClave.Size = new System.Drawing.Size(178, 22);
            this.opcionCambiarClave.Text = "Cambiar Clave";
            this.opcionCambiarClave.Click += new System.EventHandler(this.opcionCambiarClave_Click);
            // 
            // opcionCambiarUsuario
            // 
            this.opcionCambiarUsuario.Name = "opcionCambiarUsuario";
            this.opcionCambiarUsuario.Size = new System.Drawing.Size(178, 22);
            this.opcionCambiarUsuario.Text = "Cambiar de Usuario";
            this.opcionCambiarUsuario.Click += new System.EventHandler(this.opcionCambiarUsuario_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // opcionSalir
            // 
            this.opcionSalir.Name = "opcionSalir";
            this.opcionSalir.Size = new System.Drawing.Size(178, 22);
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
            this.pestaniaAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionInformacion,
            this.opcionPerfiles});
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
            // opcionPerfiles
            // 
            this.opcionPerfiles.Name = "opcionPerfiles";
            this.opcionPerfiles.Size = new System.Drawing.Size(214, 22);
            this.opcionPerfiles.Text = "Perfiles";
            this.opcionPerfiles.Click += new System.EventHandler(this.opcionPerfiles_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(0, 27);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1104, 635);
            this.panelPrincipal.TabIndex = 1;
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 661);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "menuPrincipal";
            this.Text = "MENU PRINCIPAL";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem opcionPerfiles;
    }
}
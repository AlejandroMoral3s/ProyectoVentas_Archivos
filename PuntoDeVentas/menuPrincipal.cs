using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PuntoDeVentas
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        void abrirFormulario(Form form)
        {
            while(panelPrincipal.Controls.Count > 0)
            {
                panelPrincipal.Controls.RemoveAt(0);
            }
            Form formularioHijo = form;
            form.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formularioHijo);
            formularioHijo.Show();
        }

        private void opcionClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Clientes());
        }

        private void opcionProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new productos());
        }

        private void opcionUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new usuarios());
        }

        private void opcionCambiarClave_Click(object sender, EventArgs e)
        {
            abrirFormulario(new cambioClave());
        }

        private void opcionCambiarUsuario_Click(object sender, EventArgs e)
        {
            // En este metodo se deberia abrir el LOGIN y cerrar el menu principal.
        }

        private void opcionSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opcionNuevaFactura_Click(object sender, EventArgs e)
        {
            abrirFormulario(new NuevaFactura());
        }

        private void opcionReporteFacturas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ReporteFacturas());
        }

        private void opcionInformacion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AcercaDe());
        }

        private void opcionPerfiles_Click(object sender, EventArgs e)
        {
            abrirFormulario(new perfiles());
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new municipio());
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormulario(new documento());
        }

        private void subOpcionIva_Click(object sender, EventArgs e)
        {
            abrirFormulario(new iva());
        }
    }
}

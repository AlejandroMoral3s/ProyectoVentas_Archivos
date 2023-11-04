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

        private void opcion_clientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new Clientes());
        }

        private void opcion_Productos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new productos());
        }

        private void opcion_usuarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new usuarios());
        }

        private void opcion_cambiarClave_Click(object sender, EventArgs e)
        {
            abrirFormulario(new cambioClave());
        }

        private void opcion_cambiarUsuario_Click(object sender, EventArgs e)
        {
            Login ventanaLogin = new Login();
            setConfig(ventanaLogin.getInicio(), ventanaLogin.getAdmin());
            ventanaLogin.ShowDialog();
            abrirFormulario(new AcercaDe());
            setConfig(ventanaLogin.getInicio(), ventanaLogin.getAdmin());
        }

        private void opcion_nuevaFactura_Click(object sender, EventArgs e)
        {
            abrirFormulario(new NuevaFactura());
        }

        private void opcion_reportes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new ReporteFacturas());
        }

        private void opcion_informacion_Click(object sender, EventArgs e)
        {
            abrirFormulario(new AcercaDe());
        }

        private void subopcion_documentos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new documento());
        }

        private void subopcion_municipio_Click(object sender, EventArgs e)
        {
            abrirFormulario(new municipio());
        }

        private void subopcion_ivas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new iva());
        }

        private void subopcion_perfiles_Click(object sender, EventArgs e)
        {
            abrirFormulario(new perfiles());
        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void setConfig(bool inicio, bool admin)
        {
            menuBar.Visible = inicio;
            panelPrincipal.Visible = inicio;
            opcion_usuarios.Visible = admin;
            opcion_reportes.Visible = admin;
            opcion_cambiarClave.Visible = admin;
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.ShowDialog();
            setConfig(ventanaLogin.getInicio(), ventanaLogin.getAdmin());
        }

        private void opcion_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

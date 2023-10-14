using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PuntoDeVentas
{
    public partial class perfiles : Form
    {
        public perfiles()
        {
            InitializeComponent();
        }

        private void listar()
        {
            try
            {
                perfilesSql ps = new perfilesSql();
                dataPerfiles.DataSource = ps.Listar();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscar()
        {
            try
            {
                perfilesSql ps = new perfilesSql();
                dataPerfiles.DataSource = ps.Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void perfiles_Load(object sender, EventArgs e)
        {
            listar();
            formato();
        }

        private void formato()
        {
            dataPerfiles.Columns[0].Width = 175;
            dataPerfiles.Columns[1].Width = 200;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (txtId.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtId, "Ingrese el id");
                    return;
                }
                if (txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombre, "Ingrese el nombre");
                    return;
                }
                //GENERAR INSTANCIA A LA CLASE PERFILES
                perfilesObj obj = new perfilesObj();
                obj.id = int.Parse(txtId.Text);
                obj.nombre = txtNombre.Text;

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                perfilesSql ps = new perfilesSql();
                respuesta = ps.Insertar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se inserto de forma correcta el registro");
                    limpiar();
                    listar();
                }
                else
                {
                    MensajeError (respuesta);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtBuscar.Clear();
            error.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);   
        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataPerfiles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            txtId.Text = dataPerfiles.CurrentRow.Cells["id_perfil"].Value.ToString();
            txtNombre.Text = dataPerfiles.CurrentRow.Cells["nombre"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";
                if (txtId.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtId, "Ingrese el id");
                    return;
                }
                if (txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombre, "Ingrese el nombre");
                    return;
                }
                //GENERAR INSTANCIA A LA CLASE PERFILES
                perfilesObj obj = new perfilesObj();
                obj.id = int.Parse(txtId.Text);
                obj.nombre = txtNombre.Text;

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                perfilesSql ps = new perfilesSql();
                respuesta = ps.Actualizar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se actualizo de forma correcta el registro");
                    limpiar();
                    listar();
                }
                else
                {
                    MensajeError(respuesta);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtId.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtId, "Ingrese el id");
                    return;
                }

                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Esta seguro de eliminar este registro permanentemente?", "Registros",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                
                

                if (Opcion == DialogResult.OK)
                {
                    perfilesSql ps = new perfilesSql();
                    respuesta = ps.Eliminar(int.Parse(txtId.Text));
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino de forma correcta el registro");
                    limpiar();
                    listar();
                }
                else
                {
                    MensajeError(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}

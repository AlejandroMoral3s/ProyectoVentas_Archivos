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
    public partial class iva : Form
    {
        public iva()
        {
            InitializeComponent();
        }

        private void listar()
        {
            try
            {
                ivaSql ps = new ivaSql();
                dataIva.DataSource = ps.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscar()
        {
            try
            {
                ivaSql ps = new ivaSql();
                dataIva.DataSource = ps.Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formato()
        {
            dataIva.Columns[0].Width = 175;
            dataIva.Columns[1].Width = 200;
        }

        private void limpiar()
        {
            txtId.Clear();
            txtPorcentaje.Clear();
            txtBuscar.Clear();
            error.Clear();
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iva_Load(object sender, EventArgs e)
        {
            listar();
            formato();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
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
                if (txtPorcentaje.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtPorcentaje, "Ingrese el porcentaje");
                    return;
                }
                //GENERAR INSTANCIA A LA CLASE PERFILES
                ivaObj obj = new ivaObj();
                obj.id_iva = int.Parse(txtId.Text);
                obj.porcentaje = int.Parse(txtPorcentaje.Text);

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                ivaSql ps = new ivaSql();
                respuesta = ps.Insertar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se inserto de forma correcta el registro");
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

        private void dataIva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            txtId.Text = dataIva.CurrentRow.Cells["id_iva"].Value.ToString();
            txtPorcentaje.Text = dataIva.CurrentRow.Cells["nombre"].Value.ToString();
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
                if (txtPorcentaje.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtPorcentaje, "Ingrese el porcentaje");
                    return;
                }
                //GENERAR INSTANCIA A LA CLASE PERFILES
                ivaObj obj = new ivaObj();
                obj.id_iva = int.Parse(txtId.Text);
                obj.porcentaje = int.Parse(txtPorcentaje.Text);

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                ivaSql ps = new ivaSql();
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
                Opcion = MessageBox.Show("Esta seguro de eliminar este registro permanentemente?", "Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



                if (Opcion == DialogResult.OK)
                {
                    ivaSql ps = new ivaSql();
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

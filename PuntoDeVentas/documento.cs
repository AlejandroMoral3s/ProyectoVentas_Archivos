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
    public partial class documento : Form
    {

        int idActual = 0;
        Validaciones check = new Validaciones();

        public documento()
        {
            InitializeComponent();
        }

        private void extraer_ultimo_id()
        {

            documentoSql ps = new documentoSql();

            string indiceVolatil = ps.ultimoId_Documento();



            if (indiceVolatil.Equals(""))
            {
                idActual = 1;

                txtId.Text = idActual.ToString();
            }
            else
            {
                idActual = int.Parse(indiceVolatil) + 1;
                txtId.Text = idActual.ToString();
            }

        }


        private void listar()
        {
            try
            {
                documentoSql ps = new documentoSql();
                dataDocumentos.DataSource = ps.Listar();

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
                documentoSql ps = new documentoSql();
                dataDocumentos.DataSource = ps.Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formato()
        {
            dataDocumentos.Columns[0].Width = 175;
            dataDocumentos.Columns[1].Width = 200;
        }

        private void documento_Load(object sender, EventArgs e)
        {
            extraer_ultimo_id();
            listar();
            formato();
        }

        private void limpiar()
        {
            error.Clear();
            txtId.Clear();
            txtTipo.Clear();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Validaciones check = new Validaciones();    
            try
            {
                string respuesta = "";
                if (txtId.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtId, "Ingrese el id");
                    return;
                }
                if (txtTipo.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtTipo, "Ingrese el nombre");
                    return;
                }
                //GENERAR INSTANCIA A LA CLASE PERFILES
                documentoObj obj = new documentoObj();
                obj.id_documento = int.Parse(txtId.Text);
                obj.tipo = txtTipo.Text;

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                documentoSql ps = new documentoSql();
                respuesta = ps.Insertar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se inserto de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
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

        private void dataDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            txtId.Text = dataDocumentos.CurrentRow.Cells["id_documento"].Value.ToString();
            txtTipo.Text = dataDocumentos.CurrentRow.Cells["tipo"].Value.ToString();
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
                if (txtTipo.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtTipo, "Ingrese el tipo");
                    return;
                }
                //GENERAR INSTANCIA A LA CLASE PERFILES
                documentoObj obj = new documentoObj();
                obj.id_documento = int.Parse(txtId.Text);
                obj.tipo = txtTipo.Text;

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                documentoSql ps = new documentoSql();
                respuesta = ps.Actualizar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se actualizo de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
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


                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Esta seguro de eliminar este registro permanentemente?", "Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



                if (Opcion == DialogResult.OK)
                {
                    documentoSql ps = new documentoSql();
                    respuesta = ps.Eliminar(int.Parse(txtId.Text = dataDocumentos.CurrentRow.Cells["id_documento"].Value.ToString()));
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
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

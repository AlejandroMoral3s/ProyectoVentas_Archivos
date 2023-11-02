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
    public partial class municipio : Form
    {

        int idActual = 0;

        public municipio()
        {
            InitializeComponent();
        }

        private void municipio_Load(object sender, EventArgs e)
        {
            extraer_ultimo_id();
            listar();
            formato();
        }

        private void extraer_ultimo_id()
        {

            municipioSql ps = new municipioSql();

            string indiceVolatil = ps.ultimoId_Municipio();



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
                municipioSql ms = new municipioSql();
                dataMunicipios.DataSource = ms.Listar();

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
                municipioSql ms = new municipioSql();
                dataMunicipios.DataSource = ms.Buscar(txtBuscar.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formato()
        {
            dataMunicipios.Columns[0].Width = 175;
            dataMunicipios.Columns[1].Width = 200;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void limpiar()
        {
            error.Clear();
            txtId.Clear();
            txtNombre.Clear();
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


        private void btnCrear_Click(object sender, EventArgs e)
        {
            error.Clear();
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
                municipioObj obj = new municipioObj();
                obj.id_municipio = int.Parse(txtId.Text);
                obj.nombre_municipio = txtNombre.Text;

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                municipioSql ms = new municipioSql();
                respuesta = ms.Insertar(obj);

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

        private void dataMunicipios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            txtId.Text = dataMunicipios.CurrentRow.Cells["id_municipio"].Value.ToString();
            txtNombre.Text = dataMunicipios.CurrentRow.Cells["nombre"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            error.Clear();
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
                //GENERAR INSTANCIA A LA CLASE MUNICIPIOS
                municipioObj obj = new municipioObj();
                obj.id_municipio = int.Parse(txtId.Text);
                obj.nombre_municipio = txtNombre.Text;

                //GENERAR INSTANCIA A LA CLASE MUNICIPIOSSQL
                municipioSql ms = new municipioSql();
                respuesta = ms.Actualizar(obj);

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
                    municipioSql ms = new municipioSql();
                    respuesta = ms.Eliminar(int.Parse(dataMunicipios.CurrentRow.Cells["id_municipio"].Value.ToString()));
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

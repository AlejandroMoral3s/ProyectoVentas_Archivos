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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        // MOSTRANDO LOS REGISTROS EN LOS DATA GRID

        private void Clientes_Load(object sender, EventArgs e)
        {

            listar_General();
            formato();
        }

        private void listar_General()
        {
            try
            {
                clientesSql us = new clientesSql();
                datagridDocumentos.DataSource = us.listar_en_dataGrids("Select * from Documento");
                datagridMunicipios.DataSource = us.listar_en_dataGrids("Select * from Municipio");
                datagridClientes.DataSource = us.listar_en_dataGrids("Select * from Cliente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }




        private void buscarCliente()
        {
            try
            {
                clientesSql us = new clientesSql();
                datagridClientes.DataSource = us.BuscarClientes(txtBuscarCliente.Text, txtBuscarCliente.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarDocumento()
        {
            try
            {
                clientesSql us = new clientesSql();
                datagridDocumentos.DataSource = us.BuscarDocumento(txtBuscarDocumento.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarMunicipio()
        {
            try
            {
                clientesSql us = new clientesSql();
                datagridMunicipios.DataSource = us.BuscarMunicipio(txtBuscarMunicipio.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarCliente();
        }

        private void txtBuscarDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarDocumento();
        }

        private void txtBuscarMunicipio_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarMunicipio();
        }


        private void limpiar()
        {
            txtIdCliente.Clear();
            txtIdDocumento.Clear();
            txtIdMunicipio.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtNit.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtBuscarDocumento.Clear();
            txtBuscarMunicipio.Clear();
            txtBuscarCliente.Clear();
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void formato()
        {
            datagridDocumentos.Columns[0].Width = 70;
            datagridDocumentos.Columns[1].Width = 125;

            datagridMunicipios.Columns[0].Width = 70;
            datagridMunicipios.Columns[1].Width = 125;

            datagridClientes.Columns[0].Width = 70;
            datagridClientes.Columns[1].Width = 80;
            datagridClientes.Columns[2].Width = 80;
            datagridClientes.Columns[3].Width = 150;
            datagridClientes.Columns[4].Width = 250;
            datagridClientes.Columns[5].Width = 250;
            datagridClientes.Columns[6].Width = 150;
            datagridClientes.Columns[7].Width = 150;
            datagridClientes.Columns[8].Width = 120;

        }


        private void btnCrear_Click(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";

                //validaciones de cada campo receptor

                if (txtIdCliente.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdCliente, "Ingrese el id_cliente");
                    return;
                }
                if (txtIdDocumento.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdDocumento, "Ingrese el id_documento");
                    return;
                }
                if (txtIdMunicipio.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdMunicipio, "Ingrese el id_municipio");
                    return;
                }
                if (txtNombres.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombres, "Ingrese el Nombre");
                    return;
                }
                if (txtNit.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNit, "Ingrese el numero de Nit");
                    return;
                }
                if (txtApellidos.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtApellidos, "Ingrese el apellido");
                    return;
                }
                if (txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtDireccion, "Ingrese su direccion");
                    return;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtTelefono, "Ingrese el numero de telefono");
                    return;
                }
                


                //GENERAR INSTANCIA A LA CLASE USUARIO
                clientesObj obj = new clientesObj();

                obj.id_cliente = int.Parse(txtIdCliente.Text);
                obj.id_documento = int.Parse(txtIdDocumento.Text);
                obj.id_municipio = int.Parse(txtIdMunicipio.Text);
                obj.nombres = txtNombres.Text;
                obj.apellidos = txtApellidos.Text;
                obj.direccion = txtDireccion.Text;
                obj.telefono = txtTelefono.Text;
                obj.nit = txtNit.Text;
                obj.fecha_nacimiento = calendarioNacimiento.Value.ToString();
                obj.fecha_ingreso = calendarioIngreso.Value.ToString();

                //GENERAR INSTANCIA A LA CLASE USUARIOS_SQL
                clientesSql us = new clientesSql();
                respuesta = us.Insertar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se inserto de forma correcta el registro");
                    limpiar();
                    listar_General();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";

                //validaciones de cada campo receptor

                if (txtIdCliente.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdCliente, "Ingrese el id_cliente");
                    return;
                }
                if (txtIdDocumento.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdDocumento, "Ingrese el id_documento");
                    return;
                }
                if (txtIdMunicipio.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdMunicipio, "Ingrese el id_municipio");
                    return;
                }
                if (txtNombres.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombres, "Ingrese el Nombre");
                    return;
                }
                if (txtNit.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNit, "Ingrese el numero de Nit");
                    return;
                }
                if (txtApellidos.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtApellidos, "Ingrese el apellido");
                    return;
                }
                if (txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtDireccion, "Ingrese su direccion");
                    return;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtTelefono, "Ingrese el numero de telefono");
                    return;
                }



                //GENERAR INSTANCIA A LA CLASE USUARIO
                clientesObj obj = new clientesObj();

                obj.id_cliente = int.Parse(txtIdCliente.Text);
                obj.id_documento = int.Parse(txtIdDocumento.Text);
                obj.id_municipio = int.Parse(txtIdMunicipio.Text);
                obj.nombres = txtNombres.Text;
                obj.apellidos = txtApellidos.Text;
                obj.direccion = txtDireccion.Text;
                obj.telefono = txtTelefono.Text;
                obj.nit = txtNit.Text;
                obj.fecha_nacimiento = calendarioNacimiento.Value.ToString();
                obj.fecha_ingreso = calendarioIngreso.Value.ToString();

                //GENERAR INSTANCIA A LA CLASE USUARIOS_SQL
                clientesSql us = new clientesSql();
                respuesta = us.Actualizar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se actualizo de forma correcta el registro");
                    limpiar();
                    listar_General();
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

                if (txtIdCliente.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdCliente, "Ingrese el id_Cliente");
                    return;
                }

                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Esta seguro de eliminar este registro permanentemente?", "Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



                if (Opcion == DialogResult.OK)
                {
                    clientesSql us = new clientesSql();
                    respuesta = us.Eliminar(int.Parse(txtIdCliente.Text));
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino de forma correcta el registro");
                    limpiar();
                    listar_General();
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

        private void datagridDocumentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscarDocumento.Clear();
            txtIdDocumento.Text = datagridDocumentos.CurrentRow.Cells["id_documento"].Value.ToString();
        }

        private void datagridMunicipios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBuscarMunicipio.Clear();
            txtIdMunicipio.Text = datagridMunicipios.CurrentRow.Cells["id_municipio"].Value.ToString();
        }

        private void datagridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            txtIdCliente.Text = datagridClientes.CurrentRow.Cells["id_cliente"].Value.ToString();
            txtIdDocumento.Text = datagridClientes.CurrentRow.Cells["id_documento"].Value.ToString();
            txtIdMunicipio.Text = datagridClientes.CurrentRow.Cells["id_municipio"].Value.ToString();
            txtNombres.Text = datagridClientes.CurrentRow.Cells["nombres"].Value.ToString();
            txtApellidos.Text = datagridClientes.CurrentRow.Cells["apellidos"].Value.ToString();
            txtNit.Text = datagridClientes.CurrentRow.Cells["nit_cliente"].Value.ToString();
            txtDireccion.Text = datagridClientes.CurrentRow.Cells["direccion"].Value.ToString();
            txtTelefono.Text = datagridClientes.CurrentRow.Cells["telefono"].Value.ToString();
            calendarioNacimiento.Text = datagridClientes.CurrentRow.Cells["fecha_nacimiento"].Value.ToString();
            calendarioIngreso.Text = datagridClientes.CurrentRow.Cells["fecha_ingreso"].Value.ToString();
        }
    }
}

﻿using System;
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

        int idActual = 0;
        Validaciones check = new Validaciones();

        public Clientes()
        {
            InitializeComponent();
        }

        // MOSTRANDO LOS REGISTROS EN LOS DATA GRID

        private void Clientes_Load(object sender, EventArgs e)
        {
            extraer_ultimo_id();
            listar_General();
            formato();
        }

        private void extraer_ultimo_id()
        {

            clientesSql ps = new clientesSql();

            string indiceVolatil = ps.ultimoId_Cliente();

            if (indiceVolatil.Equals(""))
            {
                idActual = 1;

                txtIdCliente.Text = idActual.ToString();
            }
            else
            {
                idActual = int.Parse(indiceVolatil) + 1;
                txtIdCliente.Text = idActual.ToString();
            }

        }

        private void listar_General()
        {
            try
            {

                //RECORDAR QUE DENTRO DE CLIENTES HAY QUE AGREGAR UN PRIMER REGISTRO CON LOS DATOS INDEFINIDOS PARA CONSUMIDOR FINAL
                clientesSql us = new clientesSql();
                datagridDocumentos.DataSource = us.listar_en_dataGrids("Select * from Documento where id_documento > 1");
                datagridMunicipios.DataSource = us.listar_en_dataGrids("Select * from Municipio where id_municipio > 1");
                datagridClientes.DataSource = us.listar_en_dataGrids("Select * from Cliente where id_cliente > 1");

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
            error.Clear();
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
            txtNoDocumento.Clear();
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
                error.Clear();
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
                if (txtNoDocumento.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNoDocumento, "Ingrese el No.Documento");
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
                if (check.esNum(txtIdDocumento.Text)!=("int"))
                {
                    MensajeError("Los id solo pueden ser números");
                    error.SetError(txtIdDocumento, "Ingresa un id válido");
                    return;
                }
                if (check.esNum(txtIdMunicipio.Text)!=("int"))
                {
                    MensajeError("Los id solo pueden ser números");
                    error.SetError(txtIdMunicipio, "Ingresa un id válido");
                    return;
                }
                if (check.esNum(txtTelefono.Text)!=("int"))
                {
                    MensajeError("Los teléfonos solo pueden contener caracteres numéricos");
                    error.SetError(txtTelefono, "Ingresa un teléfono válido");
                    return;
                }
                if (check.esNum(txtNoDocumento.Text)!="int")
                {
                    MensajeError("Los No. de documento solo pueden contener caracteres numéricos");
                    error.SetError(txtNoDocumento, "Ingresa un documento válido");
                    return;
                }

                //GENERAR INSTANCIA A LA CLASE USUARIO
                clientesObj obj = new clientesObj();

                obj.id_cliente = int.Parse(txtIdCliente.Text);
                obj.id_documento = int.Parse(txtIdDocumento.Text);
                obj.id_municipio = int.Parse(txtIdMunicipio.Text);
                obj.noDocumento = txtNoDocumento.Text;
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
                    extraer_ultimo_id();
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
                if (txtNoDocumento.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNoDocumento, "Ingrese el No.Documento");
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
                if (check.esNum(txtIdDocumento.Text) != ("int"))
                {
                    MensajeError("Los id solo pueden ser números");
                    error.SetError(txtIdDocumento, "Ingresa un id válido");
                    return;
                }
                if (check.esNum(txtIdMunicipio.Text) != ("int"))
                {
                    MensajeError("Los id solo pueden ser números");
                    error.SetError(txtIdMunicipio, "Ingresa un id válido");
                    return;
                }
                if (check.esNum(txtTelefono.Text) != ("int"))
                {
                    MensajeError("Los teléfonos solo pueden contener caracteres numéricos");
                    error.SetError(txtTelefono, "Ingresa un teléfono válido");
                    return;
                }
                if (check.esNum(txtNoDocumento.Text) != "int")
                {
                    MensajeError("Los No. de documento solo pueden contener caracteres numéricos");
                    error.SetError(txtNoDocumento, "Ingresa un documento válido");
                    return;
                }



                //GENERAR INSTANCIA A LA CLASE USUARIO
                clientesObj obj = new clientesObj();

                obj.id_cliente = int.Parse(txtIdCliente.Text);
                obj.id_documento = int.Parse(txtIdDocumento.Text);
                obj.id_municipio = int.Parse(txtIdMunicipio.Text);
                obj.noDocumento = txtNoDocumento.Text;
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
                    extraer_ultimo_id();
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
                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Esta seguro de eliminar este registro permanentemente?", "Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    clientesSql us = new clientesSql();
                    respuesta = us.Eliminar(int.Parse(datagridClientes.CurrentRow.Cells["id_cliente"].Value.ToString()));
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
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
            txtNoDocumento.Text = datagridClientes.CurrentRow.Cells["no_documento"].Value.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }




        //this.datagridUsuarios.CurrentCellChanged += new System.EventHandler(this.datagridUsuarios_CurrentCellChanged);


        int indice = 0;
        private void datagridClientes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (datagridClientes.CurrentRow != null)
                indice = datagridClientes.CurrentRow.Index;

        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int anterior = indice - 1;

            if (anterior < 0)
            {
                indice = datagridClientes.Rows.Count;
                anterior = datagridClientes.Rows.Count - 1;
                datagridClientes.CurrentCell = datagridClientes.Rows[anterior].Cells[datagridClientes.CurrentCell.ColumnIndex];

            }
            else
            {
                indice--;
                datagridClientes.CurrentCell = datagridClientes.Rows[anterior].Cells[datagridClientes.CurrentCell.ColumnIndex];
            }

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
            txtNoDocumento.Text = datagridClientes.CurrentRow.Cells["no_documento"].Value.ToString();


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int siguiente = indice + 1;

            if (siguiente < datagridClientes.Rows.Count - 1)
            {
                datagridClientes.CurrentCell = datagridClientes.Rows[siguiente].Cells[datagridClientes.CurrentCell.ColumnIndex];
            }
            else
            {
                indice = 0;
                siguiente = 0;
                datagridClientes.CurrentCell = datagridClientes.Rows[siguiente].Cells[datagridClientes.CurrentCell.ColumnIndex];
            }
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
            txtNoDocumento.Text = datagridClientes.CurrentRow.Cells["no_documento"].Value.ToString();

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            int primero = 0;
            datagridClientes.CurrentCell = datagridClientes.Rows[primero].Cells[datagridClientes.CurrentCell.ColumnIndex];
            indice = primero;

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
            txtNoDocumento.Text = datagridClientes.CurrentRow.Cells["no_documento"].Value.ToString();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            int ultimo = (datagridClientes.Rows.Count - 2);
            datagridClientes.CurrentCell = datagridClientes.Rows[ultimo].Cells[datagridClientes.CurrentCell.ColumnIndex];
            indice = ultimo;

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
            txtNoDocumento.Text = datagridClientes.CurrentRow.Cells["no_documento"].Value.ToString();


        }
    }
}

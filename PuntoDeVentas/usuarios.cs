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
    public partial class usuarios : Form
    {

        int idActual = 0;

        public usuarios()
        {
            InitializeComponent();
        }

        private void usuarios_Load(object sender, EventArgs e)
        {
            extraer_ultimo_id();
            listarPerfiles();
            listarUsuarios();
            formato();
        }

        private void extraer_ultimo_id()
        {

            usuariosSql ps = new usuariosSql();

            string indiceVolatil = ps.ultimoId_Usuario();



            if (indiceVolatil.Equals(""))
            {
                idActual = 1;

                txtIdUsuario.Text = idActual.ToString();
            }
            else
            {
                idActual = int.Parse(indiceVolatil) + 1;
                txtIdUsuario.Text = idActual.ToString();
            }

        }

        // METODOS PARA LISTAR PERFILES Y USUARIOS EN DATAGRID
        private void listarPerfiles()
        {
            try
            {
                usuariosSql us = new usuariosSql();
                datagridPerfil.DataSource = us.ListarPerfiles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void listarUsuarios()
        {
            try
            {
                usuariosSql us = new usuariosSql();
                datagridUsuarios.DataSource = us.ListarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //METODO PARA DAR FORMATO A LAS COLUMNAS MOSTRADAS EN DATAGRID
        private void formato()
        {
            datagridPerfil.Columns[0].Width = 70;
            datagridPerfil.Columns[1].Width = 125;

            datagridUsuarios.Columns[0].Width = 70;
            datagridUsuarios.Columns[1].Width = 70;
            datagridUsuarios.Columns[2].Width = 150;
            datagridUsuarios.Columns[3].Width = 150;
            datagridUsuarios.Columns[4].Width = 120;


        }

        //METODOS PARA BUSCAR REGISTROS DE PERFIL Y USUARIO EN DATAGRIDS
        private void buscarPerfil()
        {
            try
            {
                usuariosSql us = new usuariosSql();
                datagridPerfil.DataSource = us.BuscarPerfiles(txtBuscarPerfil.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarUsuario()
        {
            try
            {
                usuariosSql us = new usuariosSql();
                datagridUsuarios.DataSource = us.BuscarUsuarios(txtBuscarUsuario.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }





        private void btnBuscarPerfil_Click(object sender, EventArgs e)
        {
            buscarPerfil();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            buscarUsuario();
        }

        //METODO PARA CREAR NUEVOS USUARIOS

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                //validaciones de cada campo receptor

                if (txtIdUsuario.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdUsuario, "Ingrese el id");
                    return;
                }
                if (txtIdPerfil.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdPerfil, "Ingrese el id_Perfil");
                    return;
                }
                if (txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombre, "Ingrese el nombre");
                    return;
                }
                if (txtApellido.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtApellido, "Ingrese el Apellido");
                    return;
                }
                if (txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtDireccion, "Ingrese la direccion");
                    return;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtTelefono, "Ingrese el telefono");
                    return;
                }
                if (txtUserName.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtUserName, "Ingrese el nombre de usuario");
                    return;
                }
                if (txtClave.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtClave, "Ingrese la Clave");
                    return;
                }
                if (txtConfirmacion.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtConfirmacion, "Ingrese la Confirmacion de clave");
                    return;
                }


                //GENERAR INSTANCIA A LA CLASE USUARIO
                usuariosObj obj = new usuariosObj();

                obj.idUsuario = int.Parse(txtIdUsuario.Text);
                obj.idPerfil = int.Parse(txtIdPerfil.Text);
                obj.nombre = txtNombre.Text;
                obj.apellido = txtApellido.Text;
                obj.direccion = txtDireccion.Text;
                obj.telefono = txtTelefono.Text;
                obj.username = txtUserName.Text;
                obj.clave = txtClave.Text;
                obj.confirmacion = txtConfirmacion.Text;

                //GENERAR INSTANCIA A LA CLASE USUARIOS_SQL
                usuariosSql us = new usuariosSql();
                respuesta = us.Insertar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se inserto de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
                    listarUsuarios();
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
    


    
        //METODOS DE CONTROL

        private void limpiar()
        {
            txtIdPerfil.Clear();
            txtIdUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtUserName.Clear();
            txtClave.Clear();
            txtConfirmacion.Clear();
            txtBuscarPerfil.Clear();
            txtBuscarUsuario.Clear();
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void datagridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            txtIdUsuario.Text = datagridUsuarios.CurrentRow.Cells["id_usuario"].Value.ToString();
            txtIdPerfil.Text = datagridUsuarios.CurrentRow.Cells["id_perfil"].Value.ToString();
            txtNombre.Text = datagridUsuarios.CurrentRow.Cells["nombres"].Value.ToString();
            txtApellido.Text = datagridUsuarios.CurrentRow.Cells["apellidos"].Value.ToString();
            txtDireccion.Text = datagridUsuarios.CurrentRow.Cells["direccion"].Value.ToString();
            txtTelefono.Text = datagridUsuarios.CurrentRow.Cells["telefono"].Value.ToString();
            txtUserName.Text = datagridUsuarios.CurrentRow.Cells["nombre_usuario"].Value.ToString();
            txtClave.Text = datagridUsuarios.CurrentRow.Cells["clave"].Value.ToString();
            txtConfirmacion.Text = datagridUsuarios.CurrentRow.Cells["confirmacion"].Value.ToString();
            
        }

        //METODO PARA ACTUALIZAR REGISTRO

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                string respuesta = "";

                if (txtIdUsuario.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdUsuario, "Ingrese el id");
                    return;
                }
                if (txtIdPerfil.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdPerfil, "Ingrese el id_Perfil");
                    return;
                }
                if (txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombre, "Ingrese el nombre");
                    return;
                }
                if (txtApellido.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtApellido, "Ingrese el Apellido");
                    return;
                }
                if (txtDireccion.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtDireccion, "Ingrese la direccion");
                    return;
                }
                if (txtTelefono.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtTelefono, "Ingrese el telefono");
                    return;
                }
                if (txtUserName.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtUserName, "Ingrese el nombre de usuario");
                    return;
                }
                if (txtClave.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtClave, "Ingrese la Clave");
                    return;
                }
                if (txtConfirmacion.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtConfirmacion, "Ingrese la Confirmacion de clave");
                    return;
                }

                //GENERAR INSTANCIA A LA CLASE PERFILES
                usuariosObj obj = new usuariosObj();
                obj.idUsuario = int.Parse(txtIdUsuario.Text);
                obj.idPerfil = int.Parse(txtIdPerfil.Text);
                obj.nombre = txtNombre.Text;
                obj.apellido = txtApellido.Text;
                obj.direccion = txtDireccion.Text;
                obj.telefono = txtTelefono.Text;
                obj.username = txtUserName.Text;
                obj.clave = txtClave.Text;
                obj.confirmacion = txtConfirmacion.Text;

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                usuariosSql us = new usuariosSql();
                respuesta = us.Actualizar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se actualizo de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
                    listarUsuarios();
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
                    usuariosSql us = new usuariosSql();
                    respuesta = us.Eliminar(int.Parse(datagridUsuarios.CurrentRow.Cells["id_usuario"].Value.ToString()));
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
                    listarUsuarios();
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

        private void datagridPerfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPerfil.Clear();
            txtIdPerfil.Text = datagridPerfil.CurrentRow.Cells["id_perfil"].Value.ToString(); 
        }
    }
}

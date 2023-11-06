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
        Validaciones check = new Validaciones();    

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
            error.Clear();
            LoginSql user = new LoginSql(); 
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
                if (!txtClave.Text.Equals(txtConfirmacion.Text))
                {
                    MensajeError("La clave y la confirmación no coinciden.");
                    error.SetError(txtConfirmacion, "Ingrese la Confirmacion de clave");
                    return;
                }
                if (check.esNum(txtTelefono.Text) != "int")
                {
                    MensajeError("El teléfono solo puede contener caracteres numéricos.");
                    error.SetError(txtTelefono, "Ingrese el telefono");
                    return;
                }
                if (user.getUsuario(txtUserName.Text).Equals(txtUserName.Text))
                {
                    MensajeError("Este nombre de usuario ya existe.");
                    error.SetError(txtUserName, "Ingrese un nombre de usuario diferente");
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
            error.Clear();
            txtIdPerfil.Clear();
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
            
            btnCrear.Enabled = false;
            btnActualizar.Enabled = true;

        }

        //METODO PARA ACTUALIZAR REGISTRO

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            error.Clear();
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
                if (!txtClave.Text.Equals(txtConfirmacion.Text))
                {
                    MensajeError("La clave y la confirmación no coinciden.");
                    error.SetError(txtConfirmacion, "Ingrese la Confirmacion de clave");
                    return;
                }
                if (check.esNum(txtTelefono.Text) != "int")
                {
                    MensajeError("El teléfono solo puede contener caracteres numéricos.");
                    error.SetError(txtTelefono, "Ingrese el telefono");
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

                btnActualizar.Enabled = false;
                btnCrear.Enabled = true;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            extraer_ultimo_id();
            btnCrear.Enabled = true;
            btnActualizar.Enabled = false;
        }



        ////////////////////////////////////////////////////////////////////////

        int indice = 0;

        private void datagridUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (datagridUsuarios.CurrentRow != null)
                indice = datagridUsuarios.CurrentRow.Index;
        }
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            int anterior = indice - 1;

            if (anterior < 0)
            {
                indice = datagridUsuarios.Rows.Count;
                anterior = datagridUsuarios.Rows.Count - 1;
                datagridUsuarios.CurrentCell = datagridUsuarios.Rows[anterior].Cells[datagridUsuarios.CurrentCell.ColumnIndex];
                
            }
            else
            {
                indice--;
                datagridUsuarios.CurrentCell = datagridUsuarios.Rows[anterior].Cells[datagridUsuarios.CurrentCell.ColumnIndex];
            }

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

            btnActualizar.Enabled = true;
            btnCrear.Enabled = false;


        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int siguiente = indice + 1;

            if (siguiente < datagridUsuarios.Rows.Count - 1)
            {
                datagridUsuarios.CurrentCell = datagridUsuarios.Rows[siguiente].Cells[datagridUsuarios.CurrentCell.ColumnIndex];
            }
            else
            {
                indice = 0;
                siguiente=0;
                datagridUsuarios.CurrentCell = datagridUsuarios.Rows[siguiente].Cells[datagridUsuarios.CurrentCell.ColumnIndex];
            }

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

            btnActualizar.Enabled = true;
            btnCrear.Enabled = false;

        }
        private void btnPrimero_Click(object sender, EventArgs e)
        {
            int primero = 0;
            datagridUsuarios.CurrentCell = datagridUsuarios.Rows[primero].Cells[datagridUsuarios.CurrentCell.ColumnIndex];
            indice = primero;

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

            btnActualizar.Enabled = true;
            btnCrear.Enabled = false;

        }
        private void btnUltimo_Click(object sender, EventArgs e)
        {
            int ultimo = (datagridUsuarios.Rows.Count - 2);
            datagridUsuarios.CurrentCell = datagridUsuarios.Rows[ultimo].Cells[datagridUsuarios.CurrentCell.ColumnIndex];
            indice = ultimo;

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

            btnActualizar.Enabled = true;
            btnCrear.Enabled = false;

        }
    }
}

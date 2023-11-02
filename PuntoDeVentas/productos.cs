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
    public partial class productos : Form
    {

        int idActual = 0;
        Validaciones check= new Validaciones(); 

        public productos()
        {
            InitializeComponent();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            extraer_ultimo_id();
            listarProductos();
            listarIvas();
            formato();
        }

        private void extraer_ultimo_id()
        {

            productosSql ps = new productosSql();

            string indiceVolatil = ps.ultimoId_Producto();



            if (indiceVolatil.Equals(""))
            {
                idActual = 1;

                txtIdProducto.Text = idActual.ToString();
            }
            else
            {
                idActual = int.Parse(indiceVolatil) + 1;
                txtIdProducto.Text = idActual.ToString();
            }

        }


        private void listarIvas()
        {
            try
            {
                productosSql us = new productosSql();
                datagridIva.DataSource = us.ListarIvas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void listarProductos()
        {
            try
            {
                productosSql us = new productosSql();
                datagridProductos.DataSource = us.ListarProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //METODO PARA DAR FORMATO A LAS COLUMNAS MOSTRADAS EN DATAGRID
        private void formato()
        {
            datagridIva.Columns[0].Width = 70;
            datagridIva.Columns[1].Width = 125;

            datagridProductos.Columns[0].Width = 70;
            datagridProductos.Columns[1].Width = 70;
            datagridProductos.Columns[2].Width = 150;
            datagridProductos.Columns[3].Width = 150;
            datagridProductos.Columns[4].Width = 500;


        }

        //METODOS PARA BUSCAR REGISTROS DE PERFIL Y USUARIO EN DATAGRIDS
        private void buscarIva()
        {
            try
            {
                productosSql us = new productosSql();
                datagridIva.DataSource = us.BuscarIvas(txtBuscarIva.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarProductos()
        {
            try
            {
                productosSql us = new productosSql();
                datagridProductos.DataSource = us.BuscarProductos(txtBuscarProductos.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void limpiar()
        {
            error.Clear();
            txtIdProducto.Clear();
            txtIdIva.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtNota.Clear();
           
            txtBuscarIva.Clear();
            txtBuscarProductos.Clear();
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

                //validaciones de cada campo receptor

                if (txtIdProducto.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdProducto, "Ingrese el id");
                    return;
                }
                if (txtIdIva.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdIva, "Ingrese el id_iva");
                    return;
                }
                if (txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombre, "Ingrese el nombre");
                    return;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtPrecio, "Ingrese el Precio");
                    return;
                }
                if (txtNota.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNota, "Ingrese la Nota");
                    return;
                }
                if (check.esNum(txtPrecio.Text) == null)
                {
                    MensajeError("El precio debe ser un numero entero o decimal.");
                    error.SetError(txtPrecio, "Ingrese el Precio");
                    return;
                }
                if (check.esNum(txtIdIva.Text) !="int")
                {
                    MensajeError("Los id deben ser números enteros.");
                    error.SetError(txtIdIva, "Ingrese el id_iva");
                    return;
                }



                //GENERAR INSTANCIA A LA CLASE USUARIO
                productosObj obj = new productosObj();

                obj.id_producto = int.Parse(txtIdProducto.Text);
                obj.id_iva = int.Parse(txtIdIva.Text);
                obj.nombre_producto = txtNombre.Text;
                obj.precio = float.Parse(txtPrecio.Text);
                obj.nota = txtNota.Text;
               

                //GENERAR INSTANCIA A LA CLASE USUARIOS_SQL
                productosSql us = new productosSql();
                respuesta = us.Insertar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se inserto de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
                    listarProductos();
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

                if (txtIdProducto.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdProducto, "Ingrese el id");
                    return;
                }
                if (txtIdIva.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdIva, "Ingrese el id_iva");
                    return;
                }
                if (txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNombre, "Ingrese el nombre");
                    return;
                }
                if (txtPrecio.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtPrecio, "Ingrese el Precio");
                    return;
                }
                if (txtNota.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtNota, "Ingrese la Nota");
                    return;
                }
                if (check.esNum(txtPrecio.Text) == null)
                {
                    MensajeError("El precio debe ser un numero entero o decimal.");
                    error.SetError(txtPrecio, "Ingrese el Precio");
                    return;
                }
                if (check.esNum(txtIdIva.Text) != "int")
                {
                    MensajeError("Los id deben ser números enteros.");
                    error.SetError(txtIdIva, "Ingrese el id_iva");
                    return;
                }



                //GENERAR INSTANCIA A LA CLASE PERFILES
                productosObj obj = new productosObj();
               
                obj.id_producto = int.Parse(txtIdProducto.Text);
                obj.id_iva = int.Parse(txtIdIva.Text);
                obj.nombre_producto = txtNombre.Text;
                obj.precio = float.Parse(txtPrecio.Text);
                obj.nota = txtNota.Text;
               

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                productosSql us = new productosSql();
                respuesta = us.Actualizar(obj);

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se actualizo de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
                    listarProductos();
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
                    productosSql us = new productosSql();
                    respuesta = us.Eliminar(int.Parse(datagridProductos.CurrentRow.Cells["id_producto"].Value.ToString()));
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino de forma correcta el registro");
                    limpiar();
                    extraer_ultimo_id();
                    listarProductos();
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

        private void txtBuscarProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarProductos();
        }

        private void txtBuscarIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarIva();
        }

        private void datagridIva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdIva.Clear();
            txtIdIva.Text = datagridIva.CurrentRow.Cells["id_iva"].Value.ToString();
        }

        private void datagridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiar();
            txtIdProducto.Text = datagridProductos.CurrentRow.Cells["id_producto"].Value.ToString();
            txtIdIva.Text = datagridProductos.CurrentRow.Cells["id_iva"].Value.ToString();
            txtNombre.Text = datagridProductos.CurrentRow.Cells["nombre"].Value.ToString();
            txtPrecio.Text = datagridProductos.CurrentRow.Cells["precio"].Value.ToString();
            txtNota.Text = datagridProductos.CurrentRow.Cells["nota"].Value.ToString();
           
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}

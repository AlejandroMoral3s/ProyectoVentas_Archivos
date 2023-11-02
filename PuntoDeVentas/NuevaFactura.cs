using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVentas
{
    public partial class NuevaFactura : Form
    {

        int idActual_Factura = 0;
        int idActual_Detalle = 0;
        bool crearFactura_permitido = true;
        Validaciones check = new Validaciones();

        public string precioVolatil = "";
        public decimal totalFacturaVolatil = 0;


        public NuevaFactura()
        {
            InitializeComponent();
        }

        private void NuevaFactura_Load(object sender, EventArgs e)
        {
            extraer_ultimo_id_Factura();
            extraer_ultimo_id_detalle();
            listarClientes();
            listarProductos();
            //setIdUsuario();
        }


        public void setIdUsuario()
        {
            Login login = new Login();
            txtIdUsuario.Enabled = false;
            MessageBox.Show(login.getIdUsuario());
            txtIdUsuario.Text = login.getIdUsuario();
        }

        private void extraer_ultimo_id_Factura()
        {

            NuevaFacturaSql ps = new NuevaFacturaSql();

            string indiceVolatil = ps.ultimoId_nuevoFactura();



            if (indiceVolatil.Equals(""))
            {
                idActual_Factura = 1;

                txtIdFactura.Text = idActual_Factura.ToString();
            }
            else
            {
                idActual_Factura = int.Parse(indiceVolatil) + 1;
                txtIdFactura.Text = idActual_Factura.ToString();
            }

        }

        private void extraer_ultimo_id_detalle()
        {

            detalleFacturaSql ps = new detalleFacturaSql();

            string indiceVolatil = ps.ultimoId_detalle();



            if (indiceVolatil.Equals(""))
            {
                idActual_Detalle = 1;

                txtIdDetalle.Text = idActual_Detalle.ToString();
            }
            else
            {
                idActual_Detalle = int.Parse(indiceVolatil) + 1;
                txtIdDetalle.Text = idActual_Detalle.ToString();
            }

        }


        private void limpiar()
        {
            error.Clear();
            txtIdUsuario.Clear();
            //txtIdFactura.Clear();
            txtId_Cliente.Clear();
            txtIdProducto.Clear();
            txtCantidad.Clear();
            txtSubtotal.Clear();
            txtIdDetalle.Clear();
            txtTotalFactura.Clear();
            
        }

        private void MensajeError(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string msg)
        {
            MessageBox.Show(msg, "Control de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void listarClientes()
        {
            try
            {
                NuevaFacturaSql us = new NuevaFacturaSql();
                datagridClientes.DataSource = us.ListarClientes();

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
                NuevaFacturaSql us = new NuevaFacturaSql();
                datagridProductos.DataSource = us.ListarProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void listarDetalles()
        {
            try
            {
                detalleFacturaSql us = new detalleFacturaSql();
                datagridDetalles.DataSource = us.listarDetalles(int.Parse(txtIdFactura.Text));

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
                NuevaFacturaSql us = new NuevaFacturaSql();
                datagridClientes.DataSource = us.BuscarNit(txtIngresarNit.Text);

                

                if ((datagridClientes.Rows.Count == 1) && (datagridClientes.Rows[0].Cells["id_cliente"].Value == null))
                {
                    DialogResult mensaje = MessageBox.Show("Desea crear un cliente para este numero de nit?", "NIT DESCONOCIDO", MessageBoxButtons.OKCancel);

                    if (mensaje == DialogResult.OK)
                    {
                        Clientes clientesForm = new Clientes();
                        clientesForm.txtNit.Text = txtIngresarNit.Text;
                        clientesForm.Show();
                        listarClientes();
                    }
                    else
                    {
                        listarClientes();
                    }



                }
                else
                {
                    txtId_Cliente.Clear();
                    txtId_Cliente.Text = datagridClientes.Rows[0].Cells["id_cliente"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarProducto()
        {
            try
            {
                productosSql us = new productosSql();
                datagridProductos.DataSource = us.BuscarProductos(txtBuscarProducto.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void txtIdFactura_DragEnter(object sender, DragEventArgs e)
        {
            listarDetalles();
        }

        private void datagridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Clear();
            txtIdProducto.Text = datagridProductos.CurrentRow.Cells["id_producto"].Value.ToString();
            precioVolatil = datagridProductos.CurrentRow.Cells["precio"].Value.ToString();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            error.Clear();
            try
            {
                string respuestaNuevaFactura = "";
                string respuestaDetalleFactura = "";



                //validaciones de cada campo receptor

                if (txtIdUsuario.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdUsuario, "Ingrese el id");
                    return;
                }
                if (txtIdFactura.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdFactura, "Ingrese el id_factura");
                    return;
                }
                if (txtId_Cliente.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtId_Cliente, "Ingrese el Id_cliente");
                    return;
                }
                if (txtIdProducto.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdProducto, "Ingrese el id_producto");
                    return;
                }
                if (txtCantidad.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtCantidad, "Ingrese la cantidad");
                    return;
                }
                if (txtSubtotal.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtSubtotal, "Ingrese el subtotal");
                    return;
                }
                if (txtIdDetalle.Text == string.Empty)
                {
                    MensajeError("Falta llenar algunos cuadros de informacion.");
                    error.SetError(txtIdDetalle, "Ingrese el id_detalle");
                    return;
                }
                if (check.esNum(txtCantidad.Text) != "int")
                {
                    MensajeError("La cantidad debe ser un numero entero.");
                    error.SetError(txtCantidad, "Ingrese la cantidad");
                    return;
                }
                //GENERAR INSTANCIA A LA CLASE USUARIO

                //SI LA CASILLA DE ID FACTURA ESTA VISIBLE SE CREARA UN REGISTRO DE FACTURA, DE LO CONTRARIO SOLO SE CREARAN DETALLES

                if (crearFactura_permitido)
                {
                    NuevaFacturaObj objNFac = new NuevaFacturaObj();

                    objNFac.id_factura = int.Parse(txtIdFactura.Text);
                    objNFac.id_usuario = int.Parse(txtIdUsuario.Text);
                    objNFac.fecha_emision = calendarioEmision.Value.ToString();
                    objNFac.id_cliente = int.Parse(txtId_Cliente.Text);
                    objNFac.total_factura = totalFacturaVolatil;

                    NuevaFacturaSql us = new NuevaFacturaSql();
                    respuestaNuevaFactura = us.InsertarFactura(objNFac);

                    if (respuestaNuevaFactura.Equals("OK"))
                    {
                        MensajeOk("Se inserto de forma correcta la factura");
                        crearFactura_permitido = false;
                    }
                    else
                    {
                        MensajeError(respuestaNuevaFactura);
                    }

                    

                }


                //ENVIANDO LA INFORMACION DE DETALLE A SU RESPECTIVA TABLA EN BASE DE DATOS

                detalleFacturaObj DetFac = new detalleFacturaObj();

                DetFac.id_detalle = int.Parse(txtIdDetalle.Text);
                DetFac.id_factura = int.Parse(txtIdFactura.Text);
                DetFac.id_producto = int.Parse(txtIdProducto.Text);
                DetFac.cantidad = int.Parse(txtCantidad.Text);
                DetFac.subtotal = decimal.Parse(txtSubtotal.Text);
                
                detalleFacturaSql df = new detalleFacturaSql();
                respuestaDetalleFactura = df.AgregarProducto(DetFac);

                if (respuestaDetalleFactura.Equals("OK"))
                {
                    MensajeOk("Se agrego de forma correcta el producto");
                    extraer_ultimo_id_detalle();
                    listarDetalles();
                }
                else
                {
                    MensajeError(respuestaDetalleFactura);
                    totalFacturaVolatil  -= decimal.Parse(txtSubtotal.Text);
                    txtTotalFactura.Text = totalFacturaVolatil.ToString();
                }

                txtSubtotal.Clear();
                txtCantidad.Clear();
                txtIdProducto.Clear();
                
                totalFacturaVolatil += DetFac.subtotal;
                txtTotalFactura.Text = totalFacturaVolatil.ToString();
                txtIdFactura.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnSubtotal_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = (int.Parse(txtCantidad.Text) * float.Parse(precioVolatil)).ToString();
        }

        private void cbTipoConsumidor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbTipoConsumidor.SelectedIndex == 0)
            {
                lblNit.Visible = false;
                txtIngresarNit.Visible = false;
                btnBuscarCliente.Visible = false;
                txtId_Cliente.Text = "1";
            }
            else
            {
                lblNit.Visible = true;
                txtIngresarNit.Visible = true;
                btnBuscarCliente.Visible = true;
                txtId_Cliente.Text = "";
            }

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            buscarCliente();
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            buscarProducto();
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                

                //GENERAR INSTANCIA A LA CLASE PERFILES
                NuevaFacturaObj obj = new NuevaFacturaObj();
                obj.id_factura = int.Parse(txtIdFactura.Text);
                obj.total_factura = totalFacturaVolatil;

                //GENERAR INSTANCIA A LA CLASE PERFILESSQL
                NuevaFacturaSql us = new NuevaFacturaSql();
                respuesta = us.Actualizar(obj);

                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("FACTURA GUARDADA CON EXITO");
                    limpiar();
                    /*txtIdFactura.Enabled = true;
                    txtIdFactura.Text = (int.Parse(txtIdFactura.Text)+1).ToString();*/

                    extraer_ultimo_id_Factura();
                    listarDetalles();
                    crearFactura_permitido = true;
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

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {

            try
            {

                

                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Esta seguro de eliminar este producto de su compra?", "Registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



                if (Opcion == DialogResult.OK)
                {
                    detalleFacturaSql us = new detalleFacturaSql();

                    totalFacturaVolatil -= decimal.Parse(datagridDetalles.CurrentRow.Cells["subtotal"].Value.ToString());
                    txtTotalFactura.Text = totalFacturaVolatil.ToString();

                    respuesta = us.EliminarProducto(int.Parse(datagridDetalles.CurrentRow.Cells["id_detalle"].Value.ToString()));
                    


                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino de forma correcta el producto");
                    extraer_ultimo_id_detalle();
                    listarDetalles();
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

        //BOTON VACIAR DETALLES
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Esta seguro de vaciar la factura actual?", "FACTURACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                Console.WriteLine(Opcion);

                if (Opcion == DialogResult.OK)
                {
                    detalleFacturaSql us = new detalleFacturaSql();
                    respuesta = us.VaciarDetalles(int.Parse(txtIdFactura.Text));
                    listarDetalles();
                    extraer_ultimo_id_detalle();
                    totalFacturaVolatil = 0;
                    txtTotalFactura.Text = totalFacturaVolatil.ToString();
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se vacio correctamente el detalle de factura.");
                    
                    listarDetalles();
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

        private void btnVaciarFactura_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult Opcion;
                string respuesta = "";
                Opcion = MessageBox.Show("Esta seguro de vaciar los datos de la factura actual?", "FACTURACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);



                if (Opcion == DialogResult.OK)
                {
                    NuevaFacturaSql us = new NuevaFacturaSql();
                    respuesta = us.EliminarFactura(int.Parse(txtIdFactura.Text));
                    limpiar();
                }

                if (respuesta.Equals("OK"))
                {
                    MensajeOk("Se elimino el registro de factura correctamente!");
                    crearFactura_permitido = true;
                    extraer_ultimo_id_Factura();
                    extraer_ultimo_id_detalle();
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

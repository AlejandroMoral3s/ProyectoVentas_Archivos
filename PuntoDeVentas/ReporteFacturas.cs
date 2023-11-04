﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Org.BouncyCastle.Utilities.Encoders;
using static System.Net.Mime.MediaTypeNames;

namespace PuntoDeVentas
{
    public partial class ReporteFacturas : Form
    {
        public ReporteFacturas()
        {
            InitializeComponent();
        }

        private void listar()
        {
            try
            {
                ReporteFacturasSql ps = new ReporteFacturasSql();
                dataFacturas.DataSource = ps.Listar_facturas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarNits()
        {
            try
            {
                ReporteFacturasSql ps = new ReporteFacturasSql();
                dataFacturas.DataSource = ps.buscarNit(txtFiltrarNit.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarFecha()
        {
            try
            {
                ReporteFacturasSql ps = new ReporteFacturasSql();
                dataFacturas.DataSource = ps.buscarFecha(txtFecha.Value.ToString());

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
                ReporteFacturasSql ps = new ReporteFacturasSql();
                dataFacturas.DataSource = ps.buscarProducto(txtBuscarProducto.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void buscarDetalles(int id_factura)
        {
            try
            {
                ReporteFacturasSql ps = new ReporteFacturasSql();
                dataDetalles.DataSource = ps.buscarDetalles(id_factura);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ReporteFacturas_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnFiltrarNit_Click(object sender, EventArgs e)
        {
            buscarNits();
        }

        private void btnFiltrarFecha_Click(object sender, EventArgs e)
        {
            buscarFecha();
        }

        private void btnFiltrarProducto_Click(object sender, EventArgs e)
        {
            buscarProducto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listar();
        }


        //BOTON PARA LA EJECUCION DEL PDF

        private void btnPdf_Click(object sender, EventArgs e)
        {
            
            //DECLARACION DE VARIABLES QUE ALMACENARAN FACTURAS Y DETALLES DE FACTURAS
            int idFacturaRegistroActual = 0;
            string nombreProductoRow = "", cantidadRow = "", subtotalRow = "";
            string imgRuta = "D:\\U\\archivos\\proyectos\\proyecto3\\ProyectoVentas_Archivos\\PuntoDeVentas\\Resources\\logo.png";
            string PDFruta = "D:\\U\\archivos\\proyectos\\proyecto3\\prueba.pdf";

            int contadorFacturas = 0;


            //EMPIEZA LA CREACION DEL DOCUMENTO DINAMICO
            Document doc = new Document();

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(PDFruta, FileMode.Create));

            doc.AddTitle("REPORTES DE FACTURACION XD");

            doc.Open();

            BaseColor azul = new BaseColor(13, 70, 132);
            BaseColor verde = new BaseColor(15, 100, 28);

            iTextSharp.text.Font _headingFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 16, iTextSharp.text.Font.NORMAL,azul);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font fuenteDetalles = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL);



            //IMAGEN
            iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imgRuta);
            image.ScaleAbsolute(75f, 75f);  // Set image size.
            image.SetAbsolutePosition(0,0); // Set image position.

            //INFO
            Paragraph paragraph = new Paragraph("Reporte de Facturación " +
                "\nProyecto Fase 3: Punto de Ventas " +
                "\nManejo e implementación de archivos", _headingFont);

            //TABLA
            PdfPTable header = new PdfPTable(2);
            header.WidthPercentage = 100;
            header.DefaultCell.Border = 0;
            header.DefaultCell.BorderWidth = 0;
            header.DefaultCell.BorderColor = BaseColor.WHITE;

            PdfPCell info = new PdfPCell(paragraph);
            PdfPCell img = new PdfPCell(image);
            info.BorderColor = BaseColor.WHITE;
            img.Border = 0;
            img.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

            header.AddCell(info);
            header.AddCell(img);    


            doc.Add(header);
            doc.Add(new Paragraph("\n",_standardFont));





            //CICLO PARA LA FACTURACION Y EL DETALLE DE FACTURAS
            for ( int i = 0; i < dataFacturas.Rows.Count-1; i++ )
            {
                LineSeparator line = new LineSeparator(1f, 100f, verde, Element.ALIGN_LEFT, 1);
                doc.Add(line);
                doc.Add(new Phrase("REGISTRO "+(i+1)+" "));
                
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);


                idFacturaRegistroActual = int.Parse(dataFacturas.Rows[i].Cells["id_factura"].Value.ToString());
                buscarDetalles(idFacturaRegistroActual);


                PdfPTable tablaFactura = new PdfPTable(6);
                tablaFactura.WidthPercentage = 100;

                // Configuramos el título de las columnas de la tabla
                PdfPCell clIdFactura = new PdfPCell(new Paragraph("FACTURA", _standardFont));
                clIdFactura.BorderWidth = 0.5f;
                

                PdfPCell clIdUsuario = new PdfPCell(new Phrase("USUARIO", _standardFont));
                clIdUsuario.BorderWidth = 0.5f;
                

                PdfPCell clFechaEmision = new PdfPCell(new Phrase("FECHA DE EMISION", _standardFont));
                clFechaEmision.BorderWidth = 0.5f;

                PdfPCell clIdCliente = new PdfPCell(new Phrase("CLIENTE", _standardFont));
                clIdCliente.BorderWidth = 0.5f;

                PdfPCell clNitCliente = new PdfPCell(new Phrase("NIT", _standardFont));
                clNitCliente.BorderWidth = 0.5f;

                PdfPCell clTotalFactura = new PdfPCell(new Phrase("TOTAL FACTURA", _standardFont));
                clTotalFactura.BorderWidth = 0.5f;

                // Añadimos las celdas a la tabla
                tablaFactura.AddCell(clIdFactura);
                tablaFactura.AddCell(clIdUsuario);
                tablaFactura.AddCell(clFechaEmision);
                tablaFactura.AddCell(clIdCliente);
                tablaFactura.AddCell(clNitCliente);
                tablaFactura.AddCell(clTotalFactura);

                // Llenamos la tabla con información
                clIdFactura = new PdfPCell(new Phrase(dataFacturas.Rows[i].Cells["id_factura"].Value.ToString(), _standardFont));
                clIdFactura.BorderWidth = 0.75f;

                clIdUsuario = new PdfPCell(new Phrase(dataFacturas.Rows[i].Cells["id_usuario"].Value.ToString(), _standardFont));
                clIdUsuario.BorderWidth = 0.75f;

                clFechaEmision = new PdfPCell(new Phrase(dataFacturas.Rows[i].Cells["fecha_emision"].Value.ToString(), _standardFont));
                clFechaEmision.BorderWidth = 0.75f;

                clIdCliente = new PdfPCell(new Phrase(dataFacturas.Rows[i].Cells["id_cliente"].Value.ToString(), _standardFont));
                clIdCliente.BorderWidth = 0.75f;

                clNitCliente = new PdfPCell(new Phrase(dataFacturas.Rows[i].Cells["nit_cliente"].Value.ToString(), _standardFont));
                clNitCliente.BorderWidth = 0.75f;

                clTotalFactura = new PdfPCell(new Phrase(dataFacturas.Rows[i].Cells["total_factura"].Value.ToString(), _standardFont));
                clTotalFactura.BorderWidth = 0.75f;

                // Añadimos las celdas a la tabla
                tablaFactura.AddCell(clIdFactura);
                tablaFactura.AddCell(clIdUsuario);
                tablaFactura.AddCell(clFechaEmision);
                tablaFactura.AddCell(clIdCliente);
                tablaFactura.AddCell(clNitCliente); 
                tablaFactura.AddCell(clTotalFactura);


                doc.Add(tablaFactura);


                doc.Add(Chunk.NEWLINE);


                doc.Add(new Paragraph($"DETALLES DE FACTURA", fuenteDetalles) { Alignment = Element.ALIGN_CENTER});

                

                //TERMINA TABLA FACTURAS Y COMIENZA TABLA DETALLES

                PdfPTable tablaDetalles = new PdfPTable(3);
                tablaDetalles.WidthPercentage = 100;

                // Configuramos el título de las columnas de la tabla
                PdfPCell clNombreProducto = new PdfPCell(new Phrase("PRODUCTO", _standardFont));
                clNombreProducto.BorderWidth = 0;
                clNombreProducto.BorderWidthLeft = 0.75f;
                clNombreProducto.BorderWidthBottom = 0.75f;

                PdfPCell clCantidad = new PdfPCell(new Phrase("CANTIDAD", _standardFont));
                clCantidad.BorderWidth = 0;
                clCantidad.BorderWidthLeft = 0.75f;
                clCantidad.BorderWidthBottom = 0.75f;

                PdfPCell clSubtotal = new PdfPCell(new Phrase("SUBTOTAL", _standardFont));
                clSubtotal.BorderWidth = 0;
                clSubtotal.BorderWidthLeft = 0.75f;
                clSubtotal.BorderWidthBottom = 0.75f;

                // Añadimos las celdas a la tabla
                tablaDetalles.AddCell(clNombreProducto);
                tablaDetalles.AddCell(clCantidad);
                tablaDetalles.AddCell(clSubtotal);
                


                // ---------- ####### INICIA DETALLE DE FACTURACION ####### -----------

                for (int j  = 0; j < dataDetalles.Rows.Count-1; j++)
                {
                    nombreProductoRow = dataDetalles.Rows[j].Cells["nombre_producto"].Value.ToString();
                    cantidadRow = dataDetalles.Rows[j].Cells["cantidad"].Value.ToString();
                    subtotalRow = dataDetalles.Rows[j].Cells["subtotal"].Value.ToString();


                    // Llenamos la tabla con información
                    clNombreProducto = new PdfPCell(new Phrase(nombreProductoRow, _standardFont));
                    clNombreProducto.BorderWidth = 0;
                    clNombreProducto.BorderWidthLeft = 0.75f;


                    clCantidad = new PdfPCell(new Phrase(cantidadRow, _standardFont));
                    clCantidad.BorderWidth = 0;
                    clCantidad.BorderWidthLeft = 0.75f;

                    clSubtotal = new PdfPCell(new Phrase(subtotalRow, _standardFont));
                    clSubtotal.BorderWidth = 0;
                    clSubtotal.BorderWidthLeft = 0.75f;


                    if (j == (dataDetalles.Rows.Count-2))
                    {
                        doc.Add(Chunk.NEWLINE);
                        clNombreProducto.BorderWidthBottom = 0.75f;
                        clCantidad.BorderWidthBottom = 0.75f;
                        clSubtotal.BorderWidthBottom = 0.75f;
                        
                    }

                    // Añadimos las celdas a la tabla
                    tablaDetalles.AddCell(clNombreProducto);
                    tablaDetalles.AddCell(clCantidad);
                    tablaDetalles.AddCell(clSubtotal);



                }
                
                doc.Add(tablaDetalles);

                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);
                doc.Add(Chunk.NEWLINE);

                contadorFacturas++;

                if( contadorFacturas == 3 )
                {
                    doc.Add(Chunk.NEXTPAGE);
                    contadorFacturas = 0;
                }

            }

            //CERRANDO DOCUMENTO

            doc.Close();
            writer.Close();

            MessageBox.Show("Reporte generado con éxito");

        }

    }
}

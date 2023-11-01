namespace PuntoDeVentas
{
    partial class ReporteFacturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltrarNit = new System.Windows.Forms.TextBox();
            this.btnFiltrarNit = new System.Windows.Forms.Button();
            this.dataFacturas = new System.Windows.Forms.DataGridView();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnFiltrarFecha = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.dataDetalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE FACTURAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIT CLIENTE:";
            // 
            // txtFiltrarNit
            // 
            this.txtFiltrarNit.Location = new System.Drawing.Point(80, 245);
            this.txtFiltrarNit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltrarNit.Name = "txtFiltrarNit";
            this.txtFiltrarNit.Size = new System.Drawing.Size(268, 26);
            this.txtFiltrarNit.TabIndex = 2;
            this.txtFiltrarNit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFiltrarNit
            // 
            this.btnFiltrarNit.Location = new System.Drawing.Point(130, 302);
            this.btnFiltrarNit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrarNit.Name = "btnFiltrarNit";
            this.btnFiltrarNit.Size = new System.Drawing.Size(152, 52);
            this.btnFiltrarNit.TabIndex = 3;
            this.btnFiltrarNit.Text = "FILTRAR";
            this.btnFiltrarNit.UseVisualStyleBackColor = true;
            this.btnFiltrarNit.Click += new System.EventHandler(this.btnFiltrarNit_Click);
            // 
            // dataFacturas
            // 
            this.dataFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFacturas.Location = new System.Drawing.Point(64, 429);
            this.dataFacturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataFacturas.Name = "dataFacturas";
            this.dataFacturas.RowHeadersWidth = 62;
            this.dataFacturas.Size = new System.Drawing.Size(1059, 588);
            this.dataFacturas.TabIndex = 4;
            // 
            // btnPdf
            // 
            this.btnPdf.Location = new System.Drawing.Point(1161, 689);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(152, 52);
            this.btnPdf.TabIndex = 5;
            this.btnPdf.Text = "GENERAR PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Location = new System.Drawing.Point(528, 302);
            this.btnFiltrarFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(152, 52);
            this.btnFiltrarFecha.TabIndex = 8;
            this.btnFiltrarFecha.Text = "FILTRAR";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "FECHA EMISION:";
            // 
            // btnFiltrarProducto
            // 
            this.btnFiltrarProducto.Location = new System.Drawing.Point(904, 302);
            this.btnFiltrarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrarProducto.Name = "btnFiltrarProducto";
            this.btnFiltrarProducto.Size = new System.Drawing.Size(152, 52);
            this.btnFiltrarProducto.TabIndex = 11;
            this.btnFiltrarProducto.Text = "FILTRAR";
            this.btnFiltrarProducto.UseVisualStyleBackColor = true;
            this.btnFiltrarProducto.Click += new System.EventHandler(this.btnFiltrarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(854, 245);
            this.txtBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(268, 26);
            this.txtBuscarProducto.TabIndex = 10;
            this.txtBuscarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(898, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "NOMBRE PRODUCTO:";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(464, 245);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(298, 26);
            this.txtFecha.TabIndex = 12;
            // 
            // dataDetalles
            // 
            this.dataDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetalles.Location = new System.Drawing.Point(1048, 1054);
            this.dataDetalles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDetalles.Name = "dataDetalles";
            this.dataDetalles.RowHeadersWidth = 62;
            this.dataDetalles.Size = new System.Drawing.Size(75, 32);
            this.dataDetalles.TabIndex = 13;
            this.dataDetalles.Visible = false;
            // 
            // ReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 1050);
            this.Controls.Add(this.dataDetalles);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnFiltrarProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFiltrarFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.dataFacturas);
            this.Controls.Add(this.btnFiltrarNit);
            this.Controls.Add(this.txtFiltrarNit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReporteFacturas";
            this.Text = "ReporteFacturas";
            this.Load += new System.EventHandler(this.ReporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltrarNit;
        private System.Windows.Forms.Button btnFiltrarNit;
        private System.Windows.Forms.DataGridView dataFacturas;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnFiltrarFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrarProducto;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.DataGridView dataDetalles;
    }
}
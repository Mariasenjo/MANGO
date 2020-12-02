namespace MANGO
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MangoDBDataSet = new MANGO.MangoDBDataSet();
            this.mangoDBDataSet1 = new MANGO.MangoDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductosTableAdapter = new MANGO.MangoDBDataSetTableAdapters.ProductosTableAdapter();
            this.DatosClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MangoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangoDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Productos";
            this.ProductosBindingSource.DataSource = this.MangoDBDataSet;
            // 
            // MangoDBDataSet
            // 
            this.MangoDBDataSet.DataSetName = "MangoDBDataSet";
            this.MangoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mangoDBDataSet1
            // 
            this.mangoDBDataSet1.DataSetName = "MangoDBDataSet";
            this.mangoDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DatosClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MANGO.Ventanas.Informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(833, 599);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ProductosTableAdapter
            // 
            this.ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // DatosClienteBindingSource
            // 
            this.DatosClienteBindingSource.DataSource = typeof(MANGO.Clases.DatosCliente);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MANGO.Properties.Resources.cierre_color_nude_arrugado_fondo_textura_cuero_7189_1881;
            this.ClientSize = new System.Drawing.Size(833, 599);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MangoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangoDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MangoDBDataSet mangoDBDataSet1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private MangoDBDataSet MangoDBDataSet;
        private MangoDBDataSetTableAdapters.ProductosTableAdapter ProductosTableAdapter;
        private System.Windows.Forms.BindingSource DatosClienteBindingSource;
    }
}
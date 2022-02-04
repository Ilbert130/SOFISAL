
namespace CapaPresentacion
{
    partial class rptCotizacion_FacturaNCF
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TodosReportes = new CapaPresentacion.TodosReportes();
            this.spreporte_cotizacion_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spreporte_cotizacion_facturaTableAdapter = new CapaPresentacion.TodosReportesTableAdapters.spreporte_cotizacion_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_cotizacion_facturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spreporte_cotizacion_facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptCotizacion_FacturaNCF.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // TodosReportes
            // 
            this.TodosReportes.DataSetName = "TodosReportes";
            this.TodosReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spreporte_cotizacion_facturaBindingSource
            // 
            this.spreporte_cotizacion_facturaBindingSource.DataMember = "spreporte_cotizacion_factura";
            this.spreporte_cotizacion_facturaBindingSource.DataSource = this.TodosReportes;
            // 
            // spreporte_cotizacion_facturaTableAdapter
            // 
            this.spreporte_cotizacion_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // rptCotizacion_FacturaNCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptCotizacion_FacturaNCF";
            this.Text = "rptCotizacion_FacturaNCF";
            this.Load += new System.EventHandler(this.rptCotizacion_FacturaNCF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spreporte_cotizacion_facturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spreporte_cotizacion_facturaBindingSource;
        private TodosReportes TodosReportes;
        private TodosReportesTableAdapters.spreporte_cotizacion_facturaTableAdapter spreporte_cotizacion_facturaTableAdapter;
    }
}
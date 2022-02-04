namespace CapaPresentacion
{
    partial class ReporteCategoria
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
            this.spmostrar_categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmostrar_categoriaTableAdapter = new CapaPresentacion.TodosReportesTableAdapters.spmostrar_categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spmostrar_categoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptCategoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(548, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // TodosReportes
            // 
            this.TodosReportes.DataSetName = "TodosReportes";
            this.TodosReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spmostrar_categoriaBindingSource
            // 
            this.spmostrar_categoriaBindingSource.DataMember = "spmostrar_categoria";
            this.spmostrar_categoriaBindingSource.DataSource = this.TodosReportes;
            // 
            // spmostrar_categoriaTableAdapter
            // 
            this.spmostrar_categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 376);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCategoria";
            this.Text = "ReporteCategoria";
            this.Load += new System.EventHandler(this.ReporteCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrar_categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spmostrar_categoriaBindingSource;
        private TodosReportes TodosReportes;
        private TodosReportesTableAdapters.spmostrar_categoriaTableAdapter spmostrar_categoriaTableAdapter;
    }
}
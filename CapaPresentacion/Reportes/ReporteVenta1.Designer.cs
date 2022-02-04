
namespace CapaPresentacion
{
    partial class ReporteVenta1
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
            this.spbuscar_venta_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TodosReportes = new CapaPresentacion.TodosReportes();
            this.spbuscar_venta_fechaTableAdapter = new CapaPresentacion.TodosReportesTableAdapters.spbuscar_venta_fechaTableAdapter();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTPfinal = new System.Windows.Forms.DateTimePicker();
            this.dateTP_Inicio = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_venta_fechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // spbuscar_venta_fechaBindingSource
            // 
            this.spbuscar_venta_fechaBindingSource.DataMember = "spbuscar_venta_fecha";
            this.spbuscar_venta_fechaBindingSource.DataSource = this.TodosReportes;
            // 
            // TodosReportes
            // 
            this.TodosReportes.DataSetName = "TodosReportes";
            this.TodosReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spbuscar_venta_fechaTableAdapter
            // 
            this.spbuscar_venta_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Black;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(350, 35);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(77, 36);
            this.btn_buscar.TabIndex = 32;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(193, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Desde ";
            // 
            // dateTPfinal
            // 
            this.dateTPfinal.CustomFormat = "yyyy-MM-dd";
            this.dateTPfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPfinal.Location = new System.Drawing.Point(193, 40);
            this.dateTPfinal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTPfinal.Name = "dateTPfinal";
            this.dateTPfinal.Size = new System.Drawing.Size(128, 21);
            this.dateTPfinal.TabIndex = 29;
            // 
            // dateTP_Inicio
            // 
            this.dateTP_Inicio.CustomFormat = "yyyy-MM-dd";
            this.dateTP_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTP_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP_Inicio.Location = new System.Drawing.Point(11, 40);
            this.dateTP_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTP_Inicio.Name = "dateTP_Inicio";
            this.dateTP_Inicio.Size = new System.Drawing.Size(128, 21);
            this.dateTP_Inicio.TabIndex = 28;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spbuscar_venta_fechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptVenta1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 98);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(899, 644);
            this.reportViewer1.TabIndex = 33;
            // 
            // ReporteVenta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(899, 742);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTPfinal);
            this.Controls.Add(this.dateTP_Inicio);
            this.Name = "ReporteVenta1";
            this.Text = "ReporteVenta1";
            this.Load += new System.EventHandler(this.ReporteVenta1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_venta_fechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource spbuscar_venta_fechaBindingSource;
        private TodosReportes TodosReportes;
        private TodosReportesTableAdapters.spbuscar_venta_fechaTableAdapter spbuscar_venta_fechaTableAdapter;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTPfinal;
        private System.Windows.Forms.DateTimePicker dateTP_Inicio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
namespace CapaPresentacion
{
    partial class ReporteVenta
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
            this.dateTP_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dateTPfinal = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spbuscar_venta_fechaTableAdapter = new CapaPresentacion.TodosReportesTableAdapters.spbuscar_venta_fechaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
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
            // dateTP_Inicio
            // 
            this.dateTP_Inicio.CustomFormat = "yyyy-MM-dd";
            this.dateTP_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTP_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP_Inicio.Location = new System.Drawing.Point(12, 32);
            this.dateTP_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTP_Inicio.Name = "dateTP_Inicio";
            this.dateTP_Inicio.Size = new System.Drawing.Size(128, 21);
            this.dateTP_Inicio.TabIndex = 16;
            this.dateTP_Inicio.ValueChanged += new System.EventHandler(this.dateTP_Inicio_ValueChanged);
            // 
            // dateTPfinal
            // 
            this.dateTPfinal.CustomFormat = "yyyy-MM-dd";
            this.dateTPfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPfinal.Location = new System.Drawing.Point(194, 32);
            this.dateTPfinal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTPfinal.Name = "dateTPfinal";
            this.dateTPfinal.Size = new System.Drawing.Size(128, 21);
            this.dateTPfinal.TabIndex = 17;
            this.dateTPfinal.ValueChanged += new System.EventHandler(this.dateTPfinal_ValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spbuscar_venta_fechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 93);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(791, 449);
            this.reportViewer1.TabIndex = 20;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // spbuscar_venta_fechaTableAdapter
            // 
            this.spbuscar_venta_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Hasta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Desde ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Black;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(351, 27);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(77, 36);
            this.btn_buscar.TabIndex = 27;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(791, 537);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTPfinal);
            this.Controls.Add(this.dateTP_Inicio);
            this.Name = "ReporteVenta";
            this.Text = "ReporteVenta";
            this.Load += new System.EventHandler(this.ReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_venta_fechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTP_Inicio;
        private System.Windows.Forms.DateTimePicker dateTPfinal;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spbuscar_venta_fechaBindingSource;
        private TodosReportes TodosReportes;
        private TodosReportesTableAdapters.spbuscar_venta_fechaTableAdapter spbuscar_venta_fechaTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
    }
}
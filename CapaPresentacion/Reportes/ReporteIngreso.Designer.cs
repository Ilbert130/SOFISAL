namespace CapaPresentacion
{
    partial class ReporteIngreso
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
            this.spbuscar_ingreso_fechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TodosReportes = new CapaPresentacion.TodosReportes();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTPfinal = new System.Windows.Forms.DateTimePicker();
            this.dateTP_Inicio = new System.Windows.Forms.DateTimePicker();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spbuscar_ingreso_fechaTableAdapter = new CapaPresentacion.TodosReportesTableAdapters.spbuscar_ingreso_fechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_ingreso_fechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // spbuscar_ingreso_fechaBindingSource
            // 
            this.spbuscar_ingreso_fechaBindingSource.DataMember = "spbuscar_ingreso_fecha";
            this.spbuscar_ingreso_fechaBindingSource.DataSource = this.TodosReportes;
            // 
            // TodosReportes
            // 
            this.TodosReportes.DataSetName = "TodosReportes";
            this.TodosReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "Desde ";
            // 
            // dateTPfinal
            // 
            this.dateTPfinal.CustomFormat = "yyyy-MM-dd";
            this.dateTPfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPfinal.Location = new System.Drawing.Point(191, 32);
            this.dateTPfinal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTPfinal.Name = "dateTPfinal";
            this.dateTPfinal.Size = new System.Drawing.Size(128, 21);
            this.dateTPfinal.TabIndex = 22;
            // 
            // dateTP_Inicio
            // 
            this.dateTP_Inicio.CustomFormat = "yyyy-MM-dd";
            this.dateTP_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTP_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTP_Inicio.Location = new System.Drawing.Point(16, 32);
            this.dateTP_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTP_Inicio.Name = "dateTP_Inicio";
            this.dateTP_Inicio.Size = new System.Drawing.Size(128, 21);
            this.dateTP_Inicio.TabIndex = 21;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.Black;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(339, 24);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(77, 36);
            this.btn_buscar.TabIndex = 20;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spbuscar_ingreso_fechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptIngreso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 71);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(834, 583);
            this.reportViewer1.TabIndex = 25;
            // 
            // spbuscar_ingreso_fechaTableAdapter
            // 
            this.spbuscar_ingreso_fechaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(832, 654);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTPfinal);
            this.Controls.Add(this.dateTP_Inicio);
            this.Controls.Add(this.btn_buscar);
            this.Name = "ReporteIngreso";
            this.ShowIcon = false;
            this.Text = "ReporteIngreso";
            this.Load += new System.EventHandler(this.ReporteIngreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spbuscar_ingreso_fechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TodosReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTPfinal;
        private System.Windows.Forms.DateTimePicker dateTP_Inicio;
        private System.Windows.Forms.Button btn_buscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spbuscar_ingreso_fechaBindingSource;
        private TodosReportes TodosReportes;
        private TodosReportesTableAdapters.spbuscar_ingreso_fechaTableAdapter spbuscar_ingreso_fechaTableAdapter;
    }
}
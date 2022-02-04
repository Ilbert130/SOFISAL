namespace CapaPresentacion.Consultas
{
    partial class ConsultaVentas
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
            this.lb_totalPagado = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_correlativo = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Serie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IdVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt_mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_sumVentas = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_SumGanancias = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_imprimir = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.btn_comprobante = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.btn_buscar = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.data_Listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lb_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.lb_totalGanado = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_idArticulo = new System.Windows.Forms.TextBox();
            this.txt_IGV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Tipo_Comprobante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_totalPagado
            // 
            this.lb_totalPagado.AutoSize = true;
            this.lb_totalPagado.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_totalPagado.Location = new System.Drawing.Point(142, 411);
            this.lb_totalPagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_totalPagado.Name = "lb_totalPagado";
            this.lb_totalPagado.Size = new System.Drawing.Size(31, 19);
            this.lb_totalPagado.TabIndex = 36;
            this.lb_totalPagado.Text = "0.0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(10, 411);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 19);
            this.label16.TabIndex = 35;
            this.label16.Text = "Total Pagado: S/.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.label17.Location = new System.Drawing.Point(23, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 34);
            this.label17.TabIndex = 15;
            this.label17.Text = "Ventas";
            // 
            // txt_correlativo
            // 
            this.txt_correlativo.Location = new System.Drawing.Point(490, 81);
            this.txt_correlativo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_correlativo.Name = "txt_correlativo";
            this.txt_correlativo.Size = new System.Drawing.Size(77, 21);
            this.txt_correlativo.TabIndex = 4;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(679, 52);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(103, 21);
            this.dtFecha.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(622, 55);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Fecha:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(412, 53);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(195, 21);
            this.txt_cliente.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(348, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cliente:";
            // 
            // txt_Serie
            // 
            this.txt_Serie.Location = new System.Drawing.Point(409, 81);
            this.txt_Serie.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Serie.Name = "txt_Serie";
            this.txt_Serie.Size = new System.Drawing.Size(77, 21);
            this.txt_Serie.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comprobante:";
            // 
            // txt_IdVenta
            // 
            this.txt_IdVenta.Location = new System.Drawing.Point(105, 53);
            this.txt_IdVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdVenta.Name = "txt_IdVenta";
            this.txt_IdVenta.Size = new System.Drawing.Size(109, 21);
            this.txt_IdVenta.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(23, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo:";
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // tt_mensaje
            // 
            this.tt_mensaje.IsBalloon = true;
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Location = new System.Drawing.Point(412, 27);
            this.txt_IdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(53, 21);
            this.txt_IdCliente.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.ventasicon;
            this.pictureBox1.Location = new System.Drawing.Point(130, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // dtFecha1
            // 
            this.dtFecha1.CustomFormat = "yyyy-MM-dd";
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha1.Location = new System.Drawing.Point(23, 40);
            this.dtFecha1.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(127, 27);
            this.dtFecha1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(19, 83);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1082, 503);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.tabPage1.Controls.Add(this.lb_sumVentas);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.lb_SumGanancias);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.btn_imprimir);
            this.tabPage1.Controls.Add(this.btn_comprobante);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.dtFecha1);
            this.tabPage1.Controls.Add(this.dtFecha2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.data_Listado);
            this.tabPage1.Controls.Add(this.lb_total);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1074, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lb_sumVentas
            // 
            this.lb_sumVentas.AutoSize = true;
            this.lb_sumVentas.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_sumVentas.ForeColor = System.Drawing.Color.White;
            this.lb_sumVentas.Location = new System.Drawing.Point(163, 440);
            this.lb_sumVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sumVentas.Name = "lb_sumVentas";
            this.lb_sumVentas.Size = new System.Drawing.Size(31, 19);
            this.lb_sumVentas.TabIndex = 48;
            this.lb_sumVentas.Text = "0.0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(7, 440);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 19);
            this.label20.TabIndex = 47;
            this.label20.Text = "Total por Ventas: S/.";
            // 
            // lb_SumGanancias
            // 
            this.lb_SumGanancias.AutoSize = true;
            this.lb_SumGanancias.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_SumGanancias.ForeColor = System.Drawing.Color.White;
            this.lb_SumGanancias.Location = new System.Drawing.Point(517, 440);
            this.lb_SumGanancias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_SumGanancias.Name = "lb_SumGanancias";
            this.lb_SumGanancias.Size = new System.Drawing.Size(31, 19);
            this.lb_SumGanancias.TabIndex = 46;
            this.lb_SumGanancias.Text = "0.0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(391, 440);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 19);
            this.label19.TabIndex = 45;
            this.label19.Text = "Total Gando: S/.";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BorderColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(956, 31);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_imprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_imprimir.Size = new System.Drawing.Size(98, 40);
            this.btn_imprimir.TabIndex = 4;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextColor = System.Drawing.Color.White;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_comprobante
            // 
            this.btn_comprobante.BorderColor = System.Drawing.Color.Transparent;
            this.btn_comprobante.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_comprobante.FlatAppearance.BorderSize = 0;
            this.btn_comprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprobante.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprobante.Location = new System.Drawing.Point(827, 31);
            this.btn_comprobante.Name = "btn_comprobante";
            this.btn_comprobante.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_comprobante.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_comprobante.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_comprobante.Size = new System.Drawing.Size(123, 40);
            this.btn_comprobante.TabIndex = 3;
            this.btn_comprobante.Text = "Comprobante";
            this.btn_comprobante.TextColor = System.Drawing.Color.White;
            this.btn_comprobante.UseVisualStyleBackColor = true;
            this.btn_comprobante.Click += new System.EventHandler(this.btn_comprobante_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_buscar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(335, 31);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_buscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_buscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buscar.Size = new System.Drawing.Size(83, 40);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextColor = System.Drawing.Color.White;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // dtFecha2
            // 
            this.dtFecha2.CustomFormat = "yyyy-MM-dd";
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha2.Location = new System.Drawing.Point(181, 40);
            this.dtFecha2.Margin = new System.Windows.Forms.Padding(2);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(127, 27);
            this.dtFecha2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(185, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha Fin:";
            // 
            // data_Listado
            // 
            this.data_Listado.AllowUserToAddRows = false;
            this.data_Listado.AllowUserToDeleteRows = false;
            this.data_Listado.AllowUserToOrderColumns = true;
            this.data_Listado.BackgroundColor = System.Drawing.Color.White;
            this.data_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.data_Listado.Location = new System.Drawing.Point(23, 108);
            this.data_Listado.Margin = new System.Windows.Forms.Padding(2);
            this.data_Listado.MultiSelect = false;
            this.data_Listado.Name = "data_Listado";
            this.data_Listado.ReadOnly = true;
            this.data_Listado.RowTemplate.Height = 28;
            this.data_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Listado.Size = new System.Drawing.Size(1031, 315);
            this.data_Listado.TabIndex = 5;
            this.data_Listado.DoubleClick += new System.EventHandler(this.data_Listado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.lb_total.ForeColor = System.Drawing.Color.White;
            this.lb_total.Location = new System.Drawing.Point(837, 80);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(57, 16);
            this.lb_total.TabIndex = 6;
            this.lb_total.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Inicio:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1074, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataListadoDetalle);
            this.groupBox1.Controls.Add(this.lb_totalGanado);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lb_totalPagado);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_idArticulo);
            this.groupBox1.Controls.Add(this.txt_IGV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_correlativo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cb_Tipo_Comprobante);
            this.groupBox1.Controls.Add(this.dtFecha);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_IdCliente);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Serie);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_IdVenta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1034, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ventas";
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Location = new System.Drawing.Point(25, 142);
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.Size = new System.Drawing.Size(981, 253);
            this.dataListadoDetalle.TabIndex = 7;
            // 
            // lb_totalGanado
            // 
            this.lb_totalGanado.AutoSize = true;
            this.lb_totalGanado.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_totalGanado.Location = new System.Drawing.Point(459, 411);
            this.lb_totalGanado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_totalGanado.Name = "lb_totalGanado";
            this.lb_totalGanado.Size = new System.Drawing.Size(31, 19);
            this.lb_totalGanado.TabIndex = 44;
            this.lb_totalGanado.Text = "0.0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(327, 411);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 19);
            this.label18.TabIndex = 43;
            this.label18.Text = "Total Gando: S/.";
            // 
            // txt_idArticulo
            // 
            this.txt_idArticulo.Location = new System.Drawing.Point(25, 103);
            this.txt_idArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_idArticulo.Name = "txt_idArticulo";
            this.txt_idArticulo.Size = new System.Drawing.Size(53, 21);
            this.txt_idArticulo.TabIndex = 21;
            // 
            // txt_IGV
            // 
            this.txt_IGV.Location = new System.Drawing.Point(663, 78);
            this.txt_IGV.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IGV.Name = "txt_IGV";
            this.txt_IGV.Size = new System.Drawing.Size(77, 21);
            this.txt_IGV.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(615, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Itbis:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(338, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Numero:";
            // 
            // cb_Tipo_Comprobante
            // 
            this.cb_Tipo_Comprobante.FormattingEnabled = true;
            this.cb_Tipo_Comprobante.Items.AddRange(new object[] {
            "FACTURA POR DEPOSITO",
            "FACTURA POR EFECTIVO"});
            this.cb_Tipo_Comprobante.Location = new System.Drawing.Point(132, 78);
            this.cb_Tipo_Comprobante.Margin = new System.Windows.Forms.Padding(2);
            this.cb_Tipo_Comprobante.Name = "cb_Tipo_Comprobante";
            this.cb_Tipo_Comprobante.Size = new System.Drawing.Size(157, 22);
            this.cb_Tipo_Comprobante.TabIndex = 1;
            this.cb_Tipo_Comprobante.Text = "FACTURA POR EFECTIVO";
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1121, 597);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ConsultaVentas";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ConsultaVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_totalPagado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_correlativo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Serie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_IdVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_imprimir;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_comprobante;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_buscar;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView data_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_idArticulo;
        private System.Windows.Forms.TextBox txt_IGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Tipo_Comprobante;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.ToolTip tt_mensaje;
        private System.Windows.Forms.Label lb_SumGanancias;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_sumVentas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.Label lb_totalGanado;
    }
}
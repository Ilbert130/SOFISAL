namespace CapaPresentacion.Consultas
{
    partial class Consulta_Stock_Articulos
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_imprimir = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.data_Listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lb_total = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt_mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_buscar = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_stockIngreso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_stockVendido = new System.Windows.Forms.Label();
            this.lb_stockActual = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.tabPage1.Controls.Add(this.lb_stockActual);
            this.tabPage1.Controls.Add(this.lb_stockVendido);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.lb_stockIngreso);
            this.tabPage1.Controls.Add(this.cb_buscar);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.txt_buscar);
            this.tabPage1.Controls.Add(this.btn_imprimir);
            this.tabPage1.Controls.Add(this.data_Listado);
            this.tabPage1.Controls.Add(this.lb_total);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1066, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BorderColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.Location = new System.Drawing.Point(925, 17);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_imprimir.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_imprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_imprimir.Size = new System.Drawing.Size(98, 40);
            this.btn_imprimir.TabIndex = 0;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.TextColor = System.Drawing.Color.White;
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.boton_Redondo2_Click);
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
            this.data_Listado.Location = new System.Drawing.Point(24, 74);
            this.data_Listado.Margin = new System.Windows.Forms.Padding(2);
            this.data_Listado.MultiSelect = false;
            this.data_Listado.Name = "data_Listado";
            this.data_Listado.ReadOnly = true;
            this.data_Listado.RowTemplate.Height = 28;
            this.data_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Listado.Size = new System.Drawing.Size(1019, 388);
            this.data_Listado.TabIndex = 1;
            this.data_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Listado_CellContentClick);
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
            this.lb_total.Location = new System.Drawing.Point(720, 41);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(57, 16);
            this.lb_total.TabIndex = 6;
            this.lb_total.Text = "Nombre:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(23, 61);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 545);
            this.tabControl1.TabIndex = 9;
            // 
            // error_icono
            // 
            this.error_icono.ContainerControl = this;
            // 
            // tt_mensaje
            // 
            this.tt_mensaje.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.data_warehouse__1_;
            this.pictureBox1.Location = new System.Drawing.Point(269, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(17, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stock de Articulos";
            // 
            // cb_buscar
            // 
            this.cb_buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_buscar.FormattingEnabled = true;
            this.cb_buscar.Items.AddRange(new object[] {
            "Nombre",
            "Codigo"});
            this.cb_buscar.Location = new System.Drawing.Point(34, 24);
            this.cb_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.cb_buscar.Name = "cb_buscar";
            this.cb_buscar.Size = new System.Drawing.Size(95, 27);
            this.cb_buscar.TabIndex = 7;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_buscar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(292, 15);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_buscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_buscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buscar.Size = new System.Drawing.Size(83, 40);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextColor = System.Drawing.Color.White;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(148, 24);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(115, 27);
            this.txt_buscar.TabIndex = 8;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(20, 477);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(190, 19);
            this.label20.TabIndex = 50;
            this.label20.Text = "Total de Stock Ingresado: ";
            // 
            // lb_stockIngreso
            // 
            this.lb_stockIngreso.AutoSize = true;
            this.lb_stockIngreso.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_stockIngreso.ForeColor = System.Drawing.Color.White;
            this.lb_stockIngreso.Location = new System.Drawing.Point(206, 477);
            this.lb_stockIngreso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_stockIngreso.Name = "lb_stockIngreso";
            this.lb_stockIngreso.Size = new System.Drawing.Size(18, 19);
            this.lb_stockIngreso.TabIndex = 49;
            this.lb_stockIngreso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 477);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "Total de Stock Actual: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(708, 477);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Total de Stock Vendido: ";
            // 
            // lb_stockVendido
            // 
            this.lb_stockVendido.AutoSize = true;
            this.lb_stockVendido.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_stockVendido.ForeColor = System.Drawing.Color.White;
            this.lb_stockVendido.Location = new System.Drawing.Point(881, 477);
            this.lb_stockVendido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_stockVendido.Name = "lb_stockVendido";
            this.lb_stockVendido.Size = new System.Drawing.Size(18, 19);
            this.lb_stockVendido.TabIndex = 53;
            this.lb_stockVendido.Text = "0";
            // 
            // lb_stockActual
            // 
            this.lb_stockActual.AutoSize = true;
            this.lb_stockActual.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb_stockActual.ForeColor = System.Drawing.Color.White;
            this.lb_stockActual.Location = new System.Drawing.Point(536, 477);
            this.lb_stockActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_stockActual.Name = "lb_stockActual";
            this.lb_stockActual.Size = new System.Drawing.Size(18, 19);
            this.lb_stockActual.TabIndex = 54;
            this.lb_stockActual.Text = "0";
            this.lb_stockActual.Click += new System.EventHandler(this.lb_stockActual_Click);
            // 
            // Consulta_Stock_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Consulta_Stock_Articulos";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Consulta_Stock_Articulos_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView data_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.ToolTip tt_mensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_imprimir;
        private System.Windows.Forms.ComboBox cb_buscar;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label lb_stockActual;
        private System.Windows.Forms.Label lb_stockVendido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lb_stockIngreso;
    }
}
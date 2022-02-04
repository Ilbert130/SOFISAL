namespace CapaPresentacion
{
    partial class Categoria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.boton_Redondo2 = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.btn_eliminar = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.btn_buscar = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.data_Listado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lb_total = new System.Windows.Forms.Label();
            this.chk_eliminar = new System.Windows.Forms.CheckBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_guardar = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.btn_editar = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.btn_cancelar = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.btn_nuevo = new Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_Idcategoria = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error_icono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tt_mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(12, 68);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(651, 303);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.tabPage1.Controls.Add(this.boton_Redondo2);
            this.tabPage1.Controls.Add(this.btn_eliminar);
            this.tabPage1.Controls.Add(this.btn_buscar);
            this.tabPage1.Controls.Add(this.data_Listado);
            this.tabPage1.Controls.Add(this.lb_total);
            this.tabPage1.Controls.Add(this.chk_eliminar);
            this.tabPage1.Controls.Add(this.txt_buscar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(643, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            // 
            // boton_Redondo2
            // 
            this.boton_Redondo2.BorderColor = System.Drawing.Color.Transparent;
            this.boton_Redondo2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.boton_Redondo2.FlatAppearance.BorderSize = 0;
            this.boton_Redondo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton_Redondo2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_Redondo2.Location = new System.Drawing.Point(442, 12);
            this.boton_Redondo2.Name = "boton_Redondo2";
            this.boton_Redondo2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.boton_Redondo2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.boton_Redondo2.OnHoverTextColor = System.Drawing.Color.White;
            this.boton_Redondo2.Size = new System.Drawing.Size(98, 40);
            this.boton_Redondo2.TabIndex = 3;
            this.boton_Redondo2.Text = "Imprimir";
            this.boton_Redondo2.TextColor = System.Drawing.Color.White;
            this.boton_Redondo2.UseVisualStyleBackColor = true;
            this.boton_Redondo2.Click += new System.EventHandler(this.boton_Redondo2_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(334, 12);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_eliminar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_eliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_eliminar.Size = new System.Drawing.Size(88, 40);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextColor = System.Drawing.Color.White;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.boton_Redondo1_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_buscar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(230, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_buscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_buscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buscar.Size = new System.Drawing.Size(83, 40);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.TextColor = System.Drawing.Color.White;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.boton_Redondo3_Click);
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
            this.data_Listado.Location = new System.Drawing.Point(20, 94);
            this.data_Listado.Margin = new System.Windows.Forms.Padding(2);
            this.data_Listado.MultiSelect = false;
            this.data_Listado.Name = "data_Listado";
            this.data_Listado.ReadOnly = true;
            this.data_Listado.RowTemplate.Height = 28;
            this.data_Listado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Listado.Size = new System.Drawing.Size(574, 167);
            this.data_Listado.TabIndex = 5;
            this.data_Listado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Listado_CellContentClick);
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
            this.lb_total.Location = new System.Drawing.Point(389, 70);
            this.lb_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(57, 16);
            this.lb_total.TabIndex = 6;
            this.lb_total.Text = "Nombre:";
            // 
            // chk_eliminar
            // 
            this.chk_eliminar.AutoSize = true;
            this.chk_eliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.chk_eliminar.ForeColor = System.Drawing.Color.White;
            this.chk_eliminar.Location = new System.Drawing.Point(20, 69);
            this.chk_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chk_eliminar.Name = "chk_eliminar";
            this.chk_eliminar.Size = new System.Drawing.Size(71, 20);
            this.chk_eliminar.TabIndex = 4;
            this.chk_eliminar.Text = "Eliminar";
            this.chk_eliminar.UseVisualStyleBackColor = true;
            this.chk_eliminar.CheckedChanged += new System.EventHandler(this.chk_eliminar_CheckedChanged);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(101, 22);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(115, 27);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(70)))));
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(643, 271);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guardar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.txt_descripcion);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.txt_Idcategoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(624, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorias";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_guardar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(157, 188);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_guardar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_guardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_guardar.Size = new System.Drawing.Size(83, 40);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextColor = System.Drawing.Color.White;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.boton_Redondo1_Click_1);
            // 
            // btn_editar
            // 
            this.btn_editar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_editar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.Location = new System.Drawing.Point(253, 188);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_editar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_editar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_editar.Size = new System.Drawing.Size(83, 40);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "Editar";
            this.btn_editar.TextColor = System.Drawing.Color.White;
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.boton_Redondo3_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(352, 188);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_cancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancelar.Size = new System.Drawing.Size(83, 40);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextColor = System.Drawing.Color.White;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.boton_Redondo4_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BorderColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(137)))));
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Image = global::CapaPresentacion.Properties.Resources.nuevo;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(68, 188);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(160)))));
            this.btn_nuevo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_nuevo.Size = new System.Drawing.Size(83, 40);
            this.btn_nuevo.TabIndex = 3;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextColor = System.Drawing.Color.White;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.boton_Redondo5_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(128, 98);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descripcion.Size = new System.Drawing.Size(264, 85);
            this.txt_descripcion.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(128, 64);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(264, 21);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_Idcategoria
            // 
            this.txt_Idcategoria.Location = new System.Drawing.Point(128, 27);
            this.txt_Idcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Idcategoria.Name = "txt_Idcategoria";
            this.txt_Idcategoria.Size = new System.Drawing.Size(109, 21);
            this.txt_Idcategoria.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(27, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 28);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 34);
            this.label6.TabIndex = 9;
            this.label6.Text = "Categorias";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.categoria1;
            this.pictureBox1.Location = new System.Drawing.Point(169, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Categoria";
            this.ShowIcon = false;
            this.Text = "                       ";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_icono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView data_Listado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.CheckBox chk_eliminar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_Idcategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider error_icono;
        private System.Windows.Forms.ToolTip tt_mensaje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo boton_Redondo2;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_eliminar;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_buscar;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_guardar;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_editar;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_cancelar;
        private Sistema_de_Facturacion_Tienda_de_Ropa.Boton_Redondo btn_nuevo;
    }
}
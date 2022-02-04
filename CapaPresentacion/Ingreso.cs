using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;


namespace CapaPresentacion
{
    public partial class Ingreso : Form
    {
        public int IdTrabajador;
        private bool IsNuevo;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private decimal totalGanado = 0;
        private decimal sumGanado = 0;
        private decimal sumIngreso = 0;
        public static string Acceso;

        private static Ingreso _instancia;
        public static Ingreso instancia
        {
            get { return _instancia; }
            set { _instancia = value; }
        }
        public static Ingreso GetInstancia()
        {
            if(_instancia==null)
            {
                _instancia = new Ingreso();
            }
            return _instancia;
        }

        public void setProveedor(string idProveedor, string nombre)
        {
            this.txt_idProveedor.Text = idProveedor;
            this.txt_proveedor.Text = nombre;
        }

        public void setArticulo(string idArticulo,string nombre)
        {
            this.txt_idArticulo.Text = idArticulo;
            this.txt_articulo.Text = nombre;
        }

        public Ingreso()
        {
            InitializeComponent();
            this.tt_mensaje.SetToolTip(this.txt_proveedor, "Seleccione el Proveedor");
            this.tt_mensaje.SetToolTip(this.txt_Serie, "Ingrese la serie del comprobante");
            this.tt_mensaje.SetToolTip(this.txt_correlativo, "Ingrese el numero del comprobante");
            this.tt_mensaje.SetToolTip(this.txt_Stock, "Ingrese la cantidad de compra");
            this.tt_mensaje.SetToolTip(this.txt_articulo, "Seleccione el Articulo de compra");
            this.txt_idProveedor.Visible = false;
            this.txt_idArticulo.Visible = false;
            this.txt_proveedor.ReadOnly = true;
            this.txt_articulo.ReadOnly = true;
        }

        //Metodo para quitar el errorProvider detalle
        private void BorrarMensajeErrorDetalle()
        {
            error_icono.SetError(txt_idArticulo, "");
            error_icono.SetError(txt_Stock, "");
            error_icono.SetError(txt_precioCompra, "");
            error_icono.SetError(txt_precioVenta, "");
        }

        //Metodo para quitar el errorProvider 
        private void BorrarMensajeError()
        {
            error_icono.SetError(txt_idArticulo, "");
            error_icono.SetError(txt_Stock, "");
            error_icono.SetError(txt_precioCompra, "");
            error_icono.SetError(txt_precioVenta, "");
            error_icono.SetError(txt_idProveedor, "");
            error_icono.SetError(txt_Serie, "");
            error_icono.SetError(txt_correlativo, "");
            error_icono.SetError(txt_IGV, "");
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txt_IdIngreso.Text = string.Empty;
            this.txt_idProveedor.Text = string.Empty;
            this.txt_proveedor.Text = string.Empty;
            this.txt_Serie.Text = string.Empty;
            this.txt_correlativo.Text = string.Empty;
            this.txt_IGV.Text = string.Empty;
            this.lb_totalPagado.Text = "0,0";
            this.lb_totalGanado.Text = "0,0";
            this.txt_IGV.Text = "18";
            this.crearTabla();
        }

        //Metodo para limpiar
        private void limpiarDetalle()
        {
            this.txt_idArticulo.Text = string.Empty;
            this.txt_articulo.Text = string.Empty;
            this.txt_Stock.Text = string.Empty;
            this.txt_precioCompra.Text = string.Empty;
            this.txt_precioVenta.Text = string.Empty;
        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txt_IdIngreso.ReadOnly = !valor;
            this.txt_Serie.ReadOnly = !valor;
            this.txt_correlativo.ReadOnly = !valor;
            this.txt_IGV.ReadOnly = !valor;
            this.dtFecha.Enabled = valor;
            this.cb_Tipo_Comprobante.Enabled = valor;
            this.txt_Stock.ReadOnly = !valor;
            this.txt_precioCompra.ReadOnly = !valor;
            this.txt_precioVenta.ReadOnly = !valor;
            this.dtFecha_Produccion.Enabled = valor;
            this.dtFecha_Vencimiento.Enabled = valor;

            this.btn_BuscarArticulo.Enabled = valor;
            this.btn_buscarProveedor.Enabled = valor;
            this.btn_agregarItems.Enabled = valor;
            this.btn_quitarItems.Enabled = valor;
        }

        //Metodo para habilitar los botones 
        private void Botones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btn_nuevo.Enabled = false;
                this.btn_guardar.Enabled = true;
                this.btn_cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btn_nuevo.Enabled = true;
                this.btn_guardar.Enabled = false;
                this.btn_cancelar.Enabled = false;
            }
        }


        //Metodo para ocultar columnas del datagridveiw
        private void OcultarColumnas()
        {
            if (Acceso == "Administrador")
            {
                this.data_Listado.Columns[0].Visible = false;
                this.data_Listado.Columns[1].Visible = false;
                this.data_Listado.Columns[6].Visible = false;
                this.data_Listado.Columns[7].Visible = false;
            }
            else if (Acceso == "Almacenero")
            {
                this.data_Listado.Columns[0].Visible = false;
                this.data_Listado.Columns[1].Visible = false;
                this.data_Listado.Columns[6].Visible = false;
                this.data_Listado.Columns[7].Visible = false;
                this.data_Listado.Columns[10].Visible = false;
            }
            this.data_Listado.Columns[9].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.data_Listado.Columns[10].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[10].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");

        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NIngreso.Mostrar();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el fechas
        private void BuscarFechas()
        {
            this.data_Listado.DataSource = NIngreso.BuscarFechas(this.dtFecha1.Value.ToString("yyyy-MM-dd"), this.dtFecha2.Value.ToString("yyyy-MM-dd"));
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para Mostras los detalles de los ingresos
        private void MostrarDetalle()
        {
            this.dataListadoDetalle.DataSource = NIngreso.MostrarDetalle(this.txt_IdIngreso.Text);
        }

        //Este metodo espara llenar los detalles del ingrso y se vean en el datagriview de mantenimiento 
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("IdArticulo", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Precio_compra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Stock_inicial", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Fecha_produccion", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("Fecha_vencimiento", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Ganancias", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGridView con nuestro DataTable 
            this.dataListadoDetalle.DataSource = this.dtDetalle;
            if (Acceso == "Almacenero")
            {
                this.dataListadoDetalle.Columns[8].Visible = false;
            }
            this.dataListadoDetalle.Columns[2].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[2].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.dataListadoDetalle.Columns[3].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.dataListadoDetalle.Columns[7].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.dataListadoDetalle.Columns[8].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }
        private void GestionUsuario()
        {
            if (Acceso == "Almacenero")
            {
                this.label20.Visible = false;
                this.lb_totalGanado.Visible = false;
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.crearTabla();
            this.dataListadoDetalle.DefaultCellStyle.ForeColor = Color.Black;
            GestionUsuario();

        }

        private void Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btn_buscarProveedor_Click(object sender, EventArgs e)
        {
            VistaProveedor_Ingreso vista = new VistaProveedor_Ingreso();
            vista.ShowDialog();
        }

        private void btn_BuscarArticulo_Click(object sender, EventArgs e)
        {
            VistaArticulo_Ingreso vista = new VistaArticulo_Ingreso();
            vista.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void chk_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_eliminar.Checked)
            {
                this.data_Listado.Columns[0].Visible = true;
            }
            else
            {
                this.data_Listado.Columns[0].Visible = false;
            }
        }

        private void data_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //este codigo hace referencia al indice de las columnas haciendo una comparacion con la que se va a eliminar
            if (e.ColumnIndex == data_Listado.Columns["Eliminar"].Index)
            {
                //Es para determinar el checkbox que se va a elimnar atraves de las filas y celdas 
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)data_Listado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_agregarItems_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.txt_idArticulo.Text == string.Empty || this.txt_Stock.Text == string.Empty || this.txt_precioCompra.Text == string.Empty
                    || this.txt_precioVenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_idArticulo, "Ingrese un valor");
                    error_icono.SetError(txt_Stock, "Ingrese un valor");
                    error_icono.SetError(txt_precioCompra, "Ingrese un valor");
                    error_icono.SetError(txt_precioVenta, "Ingrese un valor");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["IdArticulo"])==Convert.ToInt32(this.txt_idArticulo.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra el articulo en el detalle");
                        }
                    }
                    if (registrar)
                    {
                        decimal ganancias = Convert.ToDecimal(((Convert.ToDecimal(txt_precioVenta.Text))-(Convert.ToDecimal(txt_precioCompra.Text)))*Convert.ToDecimal(txt_Stock.Text));
                        decimal subtotal =Convert.ToDecimal((this.txt_Stock.Text)) * Convert.ToDecimal(this.txt_precioCompra.Text);
                        totalPagado = totalPagado + subtotal;
                        totalGanado = totalGanado + ganancias;
                        this.lb_totalPagado.Text = totalPagado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                        this.lb_totalGanado.Text = totalGanado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                        //Agregar ese detalle al datalistadoDetalle
                        DataRow row = this.dtDetalle.NewRow();
                        row["IdArticulo"] = Convert.ToInt32(this.txt_idArticulo.Text);
                        row["Articulo"] = this.txt_articulo.Text;
                        row["Precio_compra"] = Convert.ToDecimal(this.txt_precioCompra.Text);
                        row["Precio_venta"] = Convert.ToDecimal(this.txt_precioVenta.Text);
                        row["Stock_inicial"] = Convert.ToInt32(this.txt_Stock.Text);
                        row["Fecha_produccion"] = dtFecha_Produccion.Value;
                        row["Fecha_vencimiento"] = dtFecha_Vencimiento.Value;
                        row["Subtotal"] = subtotal;
                        row["Ganancias"] = ganancias;
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();
                    }
                    this.BorrarMensajeErrorDetalle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_quitarItems_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.dataListadoDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuir el total pagado
                this.totalPagado = this.totalPagado - Convert.ToDecimal(row["Subtotal"].ToString());
                this.totalGanado = this.totalGanado - Convert.ToDecimal(row["Ganancias"].ToString());
                this.lb_totalGanado.Text = totalPagado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                this.lb_totalPagado.Text = totalPagado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {

                MensajeError("No hay fila para remover");
            }
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            string lbGanado, lbPagado;
            decimal lbGanado1, lbPagado1;
            this.txt_IdIngreso.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdIngreso"].Value);
            this.txt_proveedor.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Proveedor"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.data_Listado.CurrentRow.Cells["Fecha"].Value);
            this.cb_Tipo_Comprobante.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Tipo_comprobante"].Value);
            this.txt_Serie.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Serie"].Value);
            this.txt_correlativo.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Correlativo"].Value);

            lbPagado= Convert.ToString(this.data_Listado.CurrentRow.Cells["Total"].Value);
            lbPagado1 = Convert.ToDecimal(lbPagado);
            this.lb_totalPagado.Text = lbPagado1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            lbGanado= Convert.ToString(this.data_Listado.CurrentRow.Cells["Ganancias"].Value);
            lbGanado1 = Convert.ToDecimal(lbGanado);
            this.lb_totalGanado.Text = lbGanado1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Redondo3_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea Anular los resgistros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respuesta = NIngreso.Anular(Convert.ToInt32(Codigo));

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se Anulo correctamente el Ingreso");
                            }
                            else
                            {
                                this.MensajeError(Respuesta);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void boton_Redondo2_Click(object sender, EventArgs e)
        {
            ReporteIngreso frm = new ReporteIngreso();
            frm.ShowDialog();
        }

        private void boton_Redondo3_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txt_Serie.Focus();
            this.limpiarDetalle();
            this.data_Listado.Enabled = false;
        }

        private void boton_Redondo1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txt_idProveedor.Text == string.Empty || this.txt_Serie.Text == string.Empty || this.txt_correlativo.Text == string.Empty
                    || this.txt_IGV.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_idProveedor, "Ingrese un valor");
                    error_icono.SetError(txt_Serie, "Ingrese un valor");
                    error_icono.SetError(txt_correlativo, "Ingrese un valor");
                    error_icono.SetError(txt_IGV, "Ingrese un valor");
                }
                else
                {

                    if (this.IsNuevo)
                    {
                        respuesta = NIngreso.Insertar(IdTrabajador, Convert.ToInt32(this.txt_idProveedor.Text), dtFecha.Value, cb_Tipo_Comprobante.Text,
                            txt_Serie.Text, txt_correlativo.Text, Convert.ToDecimal(txt_IGV.Text), "EMITIDO", dtDetalle);
                    }

                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se inserto de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    totalPagado = 0;
                    totalGanado = 0;
                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Mostrar();
                    this.BorrarMensajeError();
                    this.data_Listado.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void boton_Redondo2_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.limpiarDetalle();
            this.BorrarMensajeError();
            this.data_Listado.Enabled = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void lb_totalPagado_Click(object sender, EventArgs e)
        {

        }

        private void txt_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_precioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_precioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_IdIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

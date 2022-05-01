using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Venta : Form
    {
        private bool IsNuevo = false;
        public int IdTrabajador;
        private DataTable dtDetalle; 
        private decimal totalPagado = 0;
        private decimal totalPagado2 = 0;
        private decimal totalGanado = 0;
        private decimal sumGanado = 0;
        private decimal sumVentas = 0;
        private int converString;
        private string comprobanteFiscal;
        private string correlativo;
        string valor2;
        public static string Acceso;

        private static Venta _instancia;

        public static Venta instancia
        {
            get
            {
                return _instancia;
            }
            set
            {
                _instancia = value;
            }
        }

        public static Venta GetInstancia()
        {
            if (_instancia==null)
            {
                _instancia = new Venta();
            }
            return _instancia;
        }

        public void setCliente(string idCliente, string nombre)
        {
            this.txt_IdCliente.Text = idCliente;
            this.txt_cliente.Text = nombre;
        }

        public void setArticulo(string idDetalle_ingreso,string nombre, decimal precio_compra, decimal precio_venta,
            int stock, DateTime fecha_vencimiento)
        {
            this.txt_idArticulo.Text = idDetalle_ingreso;
            this.txt_articulo.Text = nombre;
            this.txt_precioCompra.Text = Convert.ToString(precio_compra);
            this.txt_precioVenta.Text = Convert.ToString(precio_venta);
            this.txt_stockFinal.Text = Convert.ToString(stock);
            this.dtFecha_Vencimiento.Value = fecha_vencimiento;

            //this.data_Listado.Columns[11].DefaultCellStyle.Format = "c";
            //this.data_Listado.Columns[11].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        public Venta()
        {
            InitializeComponent();
            this.tt_mensaje.SetToolTip(this.txt_cliente, "Seleccione un Cliente");
            this.tt_mensaje.SetToolTip(this.txt_Serie, "Ingrese una Serie del comprobante");
            this.tt_mensaje.SetToolTip(this.txt_correlativo, "Ingrese el numero del comprobante");
            this.tt_mensaje.SetToolTip(this.txt_cantidad, "Ingrese la cantidad del Articulo a vender");
            this.tt_mensaje.SetToolTip(this.txt_articulo, "Seleccione un Articulo");
            this.tt_mensaje.SetToolTip(this.txt_pago, "Ingrese el pago");
            this.txt_IdCliente.Visible = false;
            this.txt_idArticulo.Visible = false;
            this.txt_cliente.ReadOnly = true;
            this.txt_articulo.ReadOnly = true;
            this.dtFecha_Vencimiento.Enabled = false;
            this.txt_precioCompra.ReadOnly = true;
            this.txt_stockFinal.ReadOnly = true;
        }

        //Metodo para quitar el errorProvider detalle
        private void BorrarMensajeErrorDetalle()
        {
            error_icono.SetError(txt_idArticulo, "");
            error_icono.SetError(txt_cantidad, "");
            error_icono.SetError(txt_descuento, "");
            error_icono.SetError(txt_precioVenta, "");
        }

        //Metodo para quitar el errorProvider 
        private void BorrarMensajeError()
        {
            error_icono.SetError(txt_idArticulo, "");
            error_icono.SetError(txt_cantidad, "");
            error_icono.SetError(txt_descuento, "");
            error_icono.SetError(txt_precioVenta, "");
            error_icono.SetError(txt_IdCliente, "");
            error_icono.SetError(txt_Serie, "");
            error_icono.SetError(txt_correlativo, "");
            error_icono.SetError(txt_IGV, "");
            error_icono.SetError(txt_pago, "");
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
            this.txt_IdVenta.Text = string.Empty;
            this.txt_IdCliente.Text = string.Empty;
            this.txt_cliente.Text = string.Empty;
            this.txt_Serie.Text = string.Empty;
            this.txt_correlativo.Text = string.Empty;
            this.txt_IGV.Text = string.Empty;
            this.lb_totalPagado.Text = "0,0";
            this.lb_totalGanado.Text = "0,0";
            this.txt_IGV.Text = "18";
            this.txt_ComprobanteFiscal.Text = string.Empty;
            this.checkBoxComprobanteFiscal.Checked = false;
            this.cb_cotizacion.Checked = false;
            this.crearTabla();
        }

        //Metodo para limpiar
        private void limpiarDetalle()
        {
            this.txt_idArticulo.Text = string.Empty;
            this.txt_articulo.Text = string.Empty;
            this.txt_stockFinal.Text = string.Empty;
            this.txt_cantidad.Text = string.Empty;
            this.txt_precioCompra.Text = string.Empty;
            this.txt_precioVenta.Text = string.Empty;
            this.txt_descuento.Text = string.Empty;
            this.txt_pago.Text = string.Empty;
        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            
            if (Acceso== "Administrador")
            {
                this.txt_Serie.ReadOnly = true;
                this.txt_correlativo.ReadOnly = true;
                this.cb_Tipo_Comprobante.Enabled = valor;
                this.txt_cantidad.ReadOnly = !valor;
                this.txt_precioVenta.ReadOnly = !valor;
                this.txt_descuento.ReadOnly = !valor;
                this.dtFecha_Vencimiento.Enabled = !valor;
                this.txt_pago.ReadOnly = !valor;
                this.dtFecha.Enabled = valor;
                this.txt_IGV.ReadOnly = valor;
                this.txt_precioCompra.ReadOnly = valor;
                this.txt_articulo.ReadOnly = valor;
                this.txt_stockFinal.ReadOnly = valor;
                this.txt_precioVenta.ReadOnly = valor;
                this.btn_BuscarArticulo.Enabled = valor;
                this.btn_buscarCliente.Enabled = valor;
                this.btn_agregarItems.Enabled = valor;
                this.btn_quitarItems.Enabled = valor;
                this.checkBoxComprobanteFiscal.Enabled = valor;
                this.txt_ComprobanteFiscal.ReadOnly = true;
                this.cb_cotizacion.Enabled = valor;
            }
            else if(Acceso== "Vendedor")
            {
                this.txt_Serie.ReadOnly = true;
                this.txt_correlativo.ReadOnly = true;
                this.cb_Tipo_Comprobante.Enabled = valor;
                this.txt_cantidad.ReadOnly = !valor;
                this.txt_precioVenta.ReadOnly = valor;
                this.txt_descuento.ReadOnly = !valor;
                this.dtFecha_Vencimiento.Enabled = valor;
                this.txt_pago.ReadOnly = !valor;
                this.dtFecha.Enabled = !valor;
                this.txt_IGV.ReadOnly = valor;
                this.txt_precioCompra.ReadOnly = valor;
                this.txt_precioVenta.ReadOnly = valor;
                this.txt_articulo.ReadOnly = valor;
                this.txt_stockFinal.ReadOnly = valor;
                this.checkBoxComprobanteFiscal.Enabled = valor;
                this.txt_ComprobanteFiscal.ReadOnly = true;
                this.cb_cotizacion.Enabled = valor; 
                this.btn_BuscarArticulo.Enabled = valor;
                this.btn_buscarCliente.Enabled = valor;
                this.btn_agregarItems.Enabled = valor;
                this.btn_quitarItems.Enabled = valor;
            }
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
                this.dgv_cotizacion.Columns[0].Visible = false;
                this.dgv_cotizacion.Columns[1].Visible = false;
                this.dgv_cotizacion.Columns[7].Visible = false;
                this.data_Listado.Columns[0].Visible = false;
                this.data_Listado.Columns[1].Visible = false;
                this.data_Listado.Columns[5].Visible = false;
                this.data_Listado.Columns[6].Visible = false;
                this.data_Listado.Columns[7].Visible = false;
                this.data_Listado.Columns[12].Visible = true;
                this.data_Listado.Columns[13].Visible = false;
            }
            else if (Acceso == "Vendedor")
            {
                this.dgv_cotizacion.Columns[0].Visible = false;
                this.dgv_cotizacion.Columns[1].Visible = false;
                this.dgv_cotizacion.Columns[7].Visible = false;
                this.data_Listado.Columns[0].Visible = false;
                this.data_Listado.Columns[1].Visible = false;
                this.data_Listado.Columns[5].Visible = false;
                this.data_Listado.Columns[6].Visible = false;
                this.data_Listado.Columns[7].Visible = false;
                this.data_Listado.Columns[9].Visible = false;
                this.data_Listado.Columns[12].Visible = true;
                this.data_Listado.Columns[13].Visible = false;
            }

            //Aqui se estea arreglando el formato de la columna, volviendolo a money $110.000,00
            this.dgv_cotizacion.Columns[5].DefaultCellStyle.Format = "c";
            this.dgv_cotizacion.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.data_Listado.Columns[8].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.data_Listado.Columns[9].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.data_Listado.Columns[10].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[10].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.data_Listado.Columns[11].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[11].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NVenta.Mostrar();
            this.dgv_cotizacion.DataSource = NCotizacion.Mostrar();

            this.OcultarColumnas();
            lb_totalCotizacion.Text= "Total de Registros: " + Convert.ToString(dgv_cotizacion.Rows.Count);
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
            
        }

        //Metodo para buscar por el fechas
        private void BuscarFechas()
        {
            this.data_Listado.DataSource = NVenta.BuscarFechas(this.dtFecha1.Value.ToString("yyyy-MM-dd"), this.dtFecha2.Value.ToString("yyyy-MM-dd"));
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el fechas
        private void BuscarFechasCotizacion()
        {
            this.dgv_cotizacion.DataSource = NCotizacion.BuscarFechas(this.dtFecha_cotizacion1.Value.ToString("yyyy-MM-dd"), this.dtFecha_cotizacion2.Value.ToString("yyyy-MM-dd"));
            this.OcultarColumnas();
            lb_totalCotizacion.Text = "Total de Registros: " + Convert.ToString(dgv_cotizacion.Rows.Count);
        }

        //Metodo para Mostras los detalles de los ingresos
        private void MostrarDetalle()
        {
            this.dataListadoDetalle.DataSource = NVenta.MostrarDetalle(this.txt_IdVenta.Text);
        }

        private void MostrarDetalleCotizacion()
        {
            
            this.dataListadoDetalle.DataSource = NCotizacion.MostrarDetalle(dgv_cotizacion.CurrentRow.Cells["IdCotizacion"].Value.ToString());
        }

        //Este metodo espara llenar los detalles del ingrso y se vean en el datagriview de mantenimiento 
        private void crearTabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("IdDetalle_ingreso", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Ganancia", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGridView con nuestro DataTable 
            this.dataListadoDetalle.DataSource = this.dtDetalle;
            if (Acceso=="Vendedor")
            {
                this.dataListadoDetalle.Columns[6].Visible = false;
            }
            this.dataListadoDetalle.Columns[3].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.dataListadoDetalle.Columns[4].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.dataListadoDetalle.Columns[5].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.dataListadoDetalle.Columns[6].DefaultCellStyle.Format = "c";
            this.dataListadoDetalle.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        private void GestionUsuario()
        {
            if (Acceso == "Administrador")
            {
                this.label19.Visible = true;
                this.label18.Visible = true;
                this.lb_totalGanado.Visible = true;
                this.lb_SumGanancias.Visible = true;
                this.label12.Visible = true;

            }
            else if (Acceso == "Vendedor")
            {
                this.label19.Visible = false;
                this.lb_SumGanancias.Visible = false;
                this.label18.Visible = false;
                this.lb_totalGanado.Visible = false;
                this.label12.Visible = false;
                this.txt_precioCompra.Visible = false;
                this.chk_eliminar.Enabled = false;
                this.btn_eliminar.Enabled = false;
                this.chk_eliminar.Visible = false;
                this.btn_eliminar.Visible = false;
                this.txt_descuento.Enabled = false;
                
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            GestionUsuario();
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.crearTabla();
            this.dataListadoDetalle.DefaultCellStyle.ForeColor = Color.Black;

            //Codigo para que se muestre la suma de las ganancia y venta en el formulario de venta
            if (sumGanado == 0 && sumVentas == 0)
            {
                foreach (DataGridViewRow row in data_Listado.Rows)
                {
                    sumGanado += Convert.ToDecimal(row.Cells["Ganancia"].Value);
                    sumVentas += Convert.ToDecimal(row.Cells["Total"].Value);

                }
                lb_SumGanancias.Text = sumGanado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                lb_sumVentas.Text = sumVentas.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
            else
            {
                sumGanado = 0;
                sumVentas = 0;
                foreach (DataGridViewRow row in data_Listado.Rows)
                {
                    sumGanado += Convert.ToDecimal(row.Cells["Ganancia"].Value);
                    sumVentas += Convert.ToDecimal(row.Cells["Total"].Value);
                }
                lb_SumGanancias.Text = sumGanado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                lb_sumVentas.Text = sumVentas.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void Venta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            VistaCliente_Venta vista = new VistaCliente_Venta();
            vista.ShowDialog();
        }

        private void btn_BuscarArticulo_Click(object sender, EventArgs e)
        {
            VistaArticulo_Venta vista = new VistaArticulo_Venta();
            vista.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
            limpiarDetalle();
            string pago, lbGanado, lbPagado;
            decimal pago1,lbGanado1,lbPagado1;
            this.txt_IdVenta.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdVenta"].Value);
            this.txt_cliente.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Cliente"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.data_Listado.CurrentRow.Cells["Fecha"].Value);
            this.cb_Tipo_Comprobante.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Tipo_comprobante"].Value);
            this.txt_Serie.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Serie"].Value);
            this.txt_correlativo.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Correlativo"].Value);
            this.txt_ComprobanteFiscal.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["ComprobanteFiscal"].Value);

            pago = Convert.ToString(this.data_Listado.CurrentRow.Cells["Total"].Value);
            pago1 = Convert.ToDecimal(pago);
            this.lb_totalPagado.Text = pago1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            lbGanado = Convert.ToString(this.data_Listado.CurrentRow.Cells["Ganancia"].Value);
            lbGanado1 = Convert.ToDecimal(lbGanado);
            this.lb_totalGanado.Text = lbGanado1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            lbPagado = Convert.ToString(this.data_Listado.CurrentRow.Cells["Pago"].Value);
            lbPagado1 = Convert.ToDecimal(lbPagado);
            this.txt_pago.Text = lbPagado1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            this.txt_IGV.Text = "18";
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 2;

            if (Acceso=="Vendedor")
            {
                this.txt_IGV.ReadOnly = false;
                this.btn_agregarItems.Enabled = false;
                this.btn_quitarItems.Enabled = false;
                this.btn_BuscarArticulo.Enabled = false;
            }
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

                if (this.txt_idArticulo.Text == string.Empty || this.txt_cantidad.Text == string.Empty || this.txt_descuento.Text == string.Empty
                    || this.txt_precioVenta.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_idArticulo, "Ingrese un valor");
                    error_icono.SetError(txt_cantidad, "Ingrese un valor");
                    error_icono.SetError(txt_descuento, "Ingrese un valor");
                    error_icono.SetError(txt_precioVenta, "Ingrese un valor");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["IdDetalle_ingreso"]) == Convert.ToInt32(this.txt_idArticulo.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra el articulo en el detalle");
                        }
                    }
                    if (registrar && Convert.ToInt32(txt_cantidad.Text) <= Convert.ToInt32(txt_stockFinal.Text) &&
                        Convert.ToDecimal(txt_precioVenta.Text) - Convert.ToDecimal(txt_precioCompra.Text) >= Convert.ToDecimal(txt_descuento.Text))
                    {
                        decimal subtotal = Convert.ToDecimal((this.txt_cantidad.Text)) * Convert.ToDecimal(this.txt_precioVenta.Text) - Convert.ToDecimal(this.txt_descuento.Text);
                        decimal ganancias = Convert.ToDecimal(((Convert.ToDecimal(txt_precioVenta.Text) - Convert.ToDecimal(txt_precioCompra.Text)) * Convert.ToDecimal(txt_cantidad.Text)) - Convert.ToDecimal(txt_descuento.Text));
                        totalPagado += subtotal;

                        if (checkBoxComprobanteFiscal.Checked)
                        {
                            totalPagado2 = totalPagado + (totalPagado * 18 / 100);
                        }
                        else
                        {
                            //totalPagado2 = totalPagado;
                            totalPagado2 += subtotal;
                        }

                        totalGanado = totalGanado + ganancias;
                        this.lb_totalPagado.Text = Math.Round(totalPagado2).ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                        this.lb_totalGanado.Text = totalGanado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                        //Agregar ese detalle al datalistadoDetalle
                        DataRow row = this.dtDetalle.NewRow();
                        row["IdDetalle_ingreso"] = Convert.ToInt32(this.txt_idArticulo.Text);
                        row["Articulo"] = this.txt_articulo.Text;
                        row["Cantidad"] = Convert.ToInt32(this.txt_cantidad.Text);
                        row["Precio_venta"] = Convert.ToDecimal(this.txt_precioVenta.Text);
                        row["Descuento"] = Convert.ToDecimal(this.txt_descuento.Text);
                        row["Subtotal"] = subtotal;
                        row["Ganancia"] = ganancias;
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();
                    }
                    else
                    {
                        MensajeError("No hay Stock Suficiente o el descuento a realizar es mayor que el precio de compra");
                    }
                    this.BorrarMensajeErrorDetalle();
                }
                this.txt_descuento.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_quitarItems_Click(object sender, EventArgs e)
        {//Arreglar cuando se quita un alticulo con el comprobante fiscal
            try
            {
                
                int indiceFila = this.dataListadoDetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuir el total pagado

                //this.totalPagado -=  Convert.ToDecimal(row["Subtotal"].ToString());

                //TODO: Arreglar 
                if (checkBoxComprobanteFiscal.Checked)
                {
                    totalPagado -= Convert.ToDecimal(row["Subtotal"].ToString());

                    if (totalPagado != 0)
                    {
                        totalPagado2 = totalPagado + (totalPagado * 18 / 100);
                    }
                    else
                    {
                        totalPagado2 = totalPagado;
                    }
                }
                else
                {
                    this.totalPagado -= Convert.ToDecimal(row["Subtotal"].ToString());
                    totalPagado2 = totalPagado;
                }

                this.totalGanado = this.totalGanado - Convert.ToDecimal(row["Ganancia"].ToString());
                this.lb_totalGanado.Text = totalGanado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                this.lb_totalPagado.Text = totalPagado2.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                //Removemos la fila
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {

                MensajeError("No hay fila para remover");
            }
        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Redondo3_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
            if (sumGanado == 0 && sumVentas==0)
            {
                foreach (DataGridViewRow row in data_Listado.Rows)
                {
                    sumGanado += Convert.ToDecimal(row.Cells["Ganancia"].Value);
                    sumVentas += Convert.ToDecimal(row.Cells["Total"].Value);

                }
                lb_SumGanancias.Text = sumGanado.ToString("C",CultureInfo.CreateSpecificCulture("en-US"));
                lb_sumVentas.Text = sumVentas.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
            else
            {
                sumGanado = 0;
                sumVentas = 0;
                foreach (DataGridViewRow row in data_Listado.Rows)
                {
                    sumGanado += Convert.ToDecimal(row.Cells["Ganancia"].Value);
                    sumVentas += Convert.ToDecimal(row.Cells["Total"].Value);
                }
                lb_SumGanancias.Text = sumGanado.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                lb_sumVentas.Text = sumVentas.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
            }
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea Eliminar los resgistros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respuesta = NVenta.Eliminar(Convert.ToInt32(Codigo));

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino correctamente la venta");
                            }
                            else
                            {
                                this.MensajeError(Respuesta);
                            }
                        }
                    }
                    this.Mostrar();
                }

                if (sumGanado == 0)
                {
                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumGanado += Convert.ToDecimal(row.Cells["Ganancia"].Value);
                        sumVentas += Convert.ToDecimal(row.Cells["Total"].Value);

                    }
                    lb_SumGanancias.Text = Convert.ToString(sumGanado);
                    lb_sumVentas.Text = Convert.ToString(sumVentas);
                }
                else
                {
                    sumGanado = 0;
                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumGanado += Convert.ToDecimal(row.Cells["Ganancia"].Value);
                        sumVentas += Convert.ToDecimal(row.Cells["Total"].Value);
                    }
                    lb_SumGanancias.Text = Convert.ToString(sumGanado);
                    lb_sumVentas.Text = Convert.ToString(sumVentas);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void boton_Redondo2_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobanteFiscal = this.data_Listado.CurrentRow.Cells["ComprobanteFiscal"].Value.ToString();
                if ( comprobanteFiscal=="Sin NCF")
                {
                    FrmReporteFactura frm = new FrmReporteFactura();
                    frm.IdVenta = Convert.ToInt32(this.data_Listado.CurrentRow.Cells["IdVenta"].Value);
                    frm.ShowDialog();
                }
                else
                {
                    FrmReporteFacturaNFC frm = new FrmReporteFacturaNFC();
                    frm.Idventa = Convert.ToInt32(this.data_Listado.CurrentRow.Cells["IdVenta"].Value);
                    frm.ShowDialog();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Por favor realizar una venta para poder hacer el comprobante.", "Nota Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_Redondo4_Click(object sender, EventArgs e)
        {
            if (Acceso=="Administrador")
            {
                ReporteVenta1 frm1 = new ReporteVenta1();
                frm1.ShowDialog();
            }
            else
            {
                ReporteVenta frm = new ReporteVenta();
                frm.ShowDialog();
            }
            
        }

        private void boton_Redondo5_Click(object sender, EventArgs e)
        {

        }

        private void boton_Redondo3_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(true);
            this.txt_Serie.Focus();
            this.data_Listado.Enabled = false;
            this.dgv_cotizacion.Enabled = true;
            this.txt_descuento.Text = "0";
            this.txt_correlativo.Text = String.Format("{0:0000000}", NVenta.NumFactura());
            this.txt_Serie.Text = "FACT";


        }

        private void boton_Redondo1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cb_cotizacion.Checked)
                {
                    string respuesta = "";
                    if (this.txt_IdCliente.Text == string.Empty)
                    {
                        MensajeError("Falta ingresar algunos datos, seran remarcados");
                        //asi se habilita el error provider al lado de un texbox
                        error_icono.SetError(txt_cliente, "Ingrese un valor");
                    }
                    else
                    {

                        if (this.IsNuevo)
                        {
                            //Todo: Correlativo
                            if (checkBoxComprobanteFiscal.Checked)
                            {
                                comprobanteFiscal = "Con comprobante fiscal";
                            }

                            if (comprobanteFiscal == string.Empty || comprobanteFiscal == null)
                            {
                                comprobanteFiscal = "Sin NCF";
                            }
                            correlativo = txt_correlativo.Text; //
                            respuesta = NCotizacion.Insertar(Convert.ToInt32(this.txt_IdCliente.Text), IdTrabajador, dtFecha.Value, Convert.ToDecimal(txt_IGV.Text), dtDetalle, checkBoxComprobanteFiscal.Checked, comprobanteFiscal);
                            comprobanteFiscal = "";
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
                else
                {
                    decimal pago = Convert.ToDecimal(txt_pago.Text);
                    if (totalPagado > pago)
                    {
                        MessageBox.Show("El valor ingresado es menor que el pago. Por favor inserte el mismo valor o mayor");
                        error_icono.SetError(txt_pago, "Ingrese el valor correspondiente");
                    }
                    else
                    {

                        string respuesta = "";
                        if (this.txt_IdCliente.Text == string.Empty || this.txt_IGV.Text == string.Empty || this.txt_pago.Text == string.Empty)
                        {
                            MensajeError("Falta ingresar algunos datos, seran remarcados");
                            //asi se habilita el error provider al lado de un texbox
                            error_icono.SetError(txt_cliente, "Ingrese un valor");
                            error_icono.SetError(txt_IGV, "Ingrese un valor");
                            error_icono.SetError(txt_pago, "Ingrese un valor");
                        }
                        else
                        {
                            valor2 = txt_Serie.Text;

                            if (this.IsNuevo)
                            {
                                //Todo: Correlativo
                                comprobanteFiscal = txt_ComprobanteFiscal.Text;
                                if (comprobanteFiscal == string.Empty)
                                {
                                    comprobanteFiscal = "Sin NCF";
                                }
                                correlativo = txt_correlativo.Text;
                                respuesta = NVenta.Insertar(Convert.ToInt32(this.txt_IdCliente.Text), IdTrabajador, dtFecha.Value, cb_Tipo_Comprobante.Text,
                                valor2, correlativo, Convert.ToDecimal(txt_IGV.Text), Convert.ToDecimal(txt_pago.Text), dtDetalle, checkBoxComprobanteFiscal.Checked, comprobanteFiscal);

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
            this.limpiarDetalle();
            this.Habilitar(false);
            this.BorrarMensajeError();
            this.data_Listado.Enabled = true;
        }

        private void lb_SumGanancias_Click(object sender, EventArgs e)
        {

        }

        private void dataListadoDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_codigoArticulo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void boton_Redondo1_Click_2(object sender, EventArgs e)
        {
            try
            {
                string comprobanteFiscal = this.data_Listado.CurrentRow.Cells["ComprobanteFiscal"].Value.ToString();
                if (comprobanteFiscal == "Sin NCF")
                {
                    Factura frm = new Factura();
                    frm.IdVenta = Convert.ToInt32(this.data_Listado.CurrentRow.Cells["IdVenta"].Value);
                    frm.ShowDialog();
                }
                else
                {
                    FacturaNCF frm = new FacturaNCF();
                    frm.IdVenta = Convert.ToInt32(this.data_Listado.CurrentRow.Cells["IdVenta"].Value);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor realizar una venta para poder hacer el comprobante.", "Nota Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBoxComprobanteFiscal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxComprobanteFiscal.Checked)
            {
                txt_ComprobanteFiscal.ReadOnly = false;
            }
            else
            {
                txt_ComprobanteFiscal.ReadOnly = true;
            }
        }

        private void txt_IGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cb_cotizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cotizacion.Checked == true)
            {
                txt_IdVenta.Enabled = false;
                cb_Tipo_Comprobante.Enabled = false;
                txt_Serie.Enabled = false;
                txt_correlativo.Enabled = false;
                txt_ComprobanteFiscal.Enabled = false;
                txt_IGV.ReadOnly = true;
                txt_pago.Enabled = false;
            }

            if (cb_cotizacion.Checked == false)
            {
                txt_IdVenta.Enabled = true;
                cb_Tipo_Comprobante.Enabled = true;
                txt_Serie.Enabled = true;
                txt_correlativo.Enabled = true;
                txt_ComprobanteFiscal.Enabled = true;
                txt_IGV.ReadOnly = false;
                txt_pago.Enabled = true;
            }
            
        }

        private void cb_eliminarCotizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_eliminarCotizacion.Checked)
            {
                this.dgv_cotizacion.Columns[0].Visible = true;
            }
            else
            {
                this.dgv_cotizacion.Columns[0].Visible = false;
            }
        }

        private void btn_eliminarCotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea Eliminar los resgistros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in dgv_cotizacion.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respuesta = NCotizacion.Eliminar(Convert.ToInt32(Codigo));

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se Elimino correctamente la venta");
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

        private void dgv_cotizacion_DoubleClick(object sender, EventArgs e)
        {
            Limpiar();
            limpiarDetalle();
            this.txt_cliente.Text = Convert.ToString(this.dgv_cotizacion.CurrentRow.Cells["Cliente"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.dgv_cotizacion.CurrentRow.Cells["Fecha"].Value);
            this.txt_ComprobanteFiscal.Text = Convert.ToString(this.dgv_cotizacion.CurrentRow.Cells["ComprobanteFiscal"].Value);


            this.txt_IGV.Text = "18";
            this.MostrarDetalleCotizacion();
            this.tabControl1.SelectedIndex = 2;

            if (Acceso == "Vendedor")
            {
                this.txt_IGV.ReadOnly = false;
                this.btn_agregarItems.Enabled = false;
                this.btn_quitarItems.Enabled = false;
                this.btn_BuscarArticulo.Enabled = false;
            }
        }

        private void dgv_cotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //este codigo hace referencia al indice de las columnas haciendo una comparacion con la que se va a eliminar
            if (e.ColumnIndex == dgv_cotizacion.Columns[0].Index)
            {
                //Es para determinar el checkbox que se va a elimnar atraves de las filas y celdas 
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgv_cotizacion.Rows[e.RowIndex].Cells[0];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btn_buscarCotizacion_Click(object sender, EventArgs e)
        {
            this.BuscarFechasCotizacion();
        }

        private void btn_cotizacion_Click(object sender, EventArgs e)
        {
            try
            {
                string comprobanteFiscal = this.dgv_cotizacion.CurrentRow.Cells[6].Value.ToString();
                if (comprobanteFiscal == "Sin NCF")
                {
                    rptCotizacion_Factura frm = new rptCotizacion_Factura();
                    frm.IdCotizacion = Convert.ToInt32(this.dgv_cotizacion.CurrentRow.Cells[1].Value);
                    frm.ShowDialog();
                }
                else
                {
                    rptCotizacion_FacturaNCF frm = new rptCotizacion_FacturaNCF();
                    frm.IdCotizacion = Convert.ToInt32(this.dgv_cotizacion.CurrentRow.Cells[1].Value);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor realizar una cotizacion para poder hacer el comprobante.", "Nota Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

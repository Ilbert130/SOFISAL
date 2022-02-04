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

namespace CapaPresentacion.Consultas
{
    public partial class ConsultaVentas : Form
    {
        private bool IsNuevo = false;
        public int IdTrabajador;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private decimal totalGanado = 0;
        private decimal sumGanado = 0;
        private decimal sumVentas = 0;
        public static string Acceso = Venta.Acceso;

        public ConsultaVentas()
        {
            InitializeComponent();
            this.txt_IdCliente.Visible = false;
            this.txt_idArticulo.Visible = false;
            this.txt_cliente.ReadOnly = true;
            this.txt_IdVenta.ReadOnly = true;
            this.txt_Serie.ReadOnly = true;
            this.txt_correlativo.ReadOnly = true;
            this.txt_IGV.ReadOnly = true;
            this.dtFecha.Enabled = false;
            this.cb_Tipo_Comprobante.Enabled = false;
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
            else if (Acceso == "Vendedor")
            {
                this.data_Listado.Columns[0].Visible = false;
                this.data_Listado.Columns[1].Visible = false;
                this.data_Listado.Columns[6].Visible = false;
                this.data_Listado.Columns[7].Visible = false;
                this.data_Listado.Columns[9].Visible = false;
            }
            //Aqui se estea arreglando el formato de la columna, volviendolo a money $110.000,00
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
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el fechas
        private void BuscarFechas()
        {
            this.data_Listado.DataSource = NVenta.BuscarFechas(this.dtFecha1.Value.ToString("yyyy-MM-dd"), this.dtFecha2.Value.ToString("yyyy-MM-dd"));
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para Mostras los detalles de los ingresos
        private void MostrarDetalle()
        {
            this.dataListadoDetalle.DataSource = NVenta.MostrarDetalle(this.txt_IdVenta.Text);
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
            if (Acceso == "Vendedor")
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
            }
            else if (Acceso == "Vendedor")
            {
                this.label19.Visible = false;
                this.lb_SumGanancias.Visible = false;
                this.label18.Visible = false;
                this.lb_totalGanado.Visible = false;
            }
        }

        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
            GestionUsuario();
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.crearTabla();
            this.dataListadoDetalle.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            string pago, lbGanado;
            decimal pago1, lbGanado1;

            this.txt_IdVenta.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdVenta"].Value);
            this.txt_cliente.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Cliente"].Value);
            this.dtFecha.Value = Convert.ToDateTime(this.data_Listado.CurrentRow.Cells["Fecha"].Value);
            this.cb_Tipo_Comprobante.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Tipo_comprobante"].Value);
            this.txt_Serie.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Serie"].Value);
            this.txt_correlativo.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Correlativo"].Value);

            pago = Convert.ToString(this.data_Listado.CurrentRow.Cells["Total"].Value);
            pago1 = Convert.ToDecimal(pago);
            this.lb_totalPagado.Text = pago1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            lbGanado = Convert.ToString(this.data_Listado.CurrentRow.Cells["Ganancia"].Value);
            lbGanado1 = Convert.ToDecimal(lbGanado);
            this.lb_totalGanado.Text = lbGanado1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void btn_comprobante_Click(object sender, EventArgs e)
        {
            FrmReporteFactura frm = new FrmReporteFactura();
            frm.IdVenta = Convert.ToInt32(this.data_Listado.CurrentRow.Cells["IdVenta"].Value);
            frm.ShowDialog();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
            if (sumGanado == 0 && sumVentas==0)
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (Acceso == "Administrador")
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ConsultaCompras : Form
    {
        public int IdTrabajador;
        private bool IsNuevo;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        public static string Acceso = Ingreso.Acceso;

        public ConsultaCompras()
        {
            InitializeComponent();
            this.txt_idProveedor.Visible = false;
            this.txt_idArticulo.Visible = false;
            this.txt_proveedor.ReadOnly = true;
            this.txt_Serie.ReadOnly = true;
            this.txt_correlativo.ReadOnly = true;
            this.txt_IGV.ReadOnly = true;
            this.dtFecha.Enabled = false;
            this.txt_IdIngreso.ReadOnly = true;
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

        private void ConsultaCompras_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.crearTabla();
            this.dataListadoDetalle.DefaultCellStyle.ForeColor = Color.Black;
            GestionUsuario();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
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
            this.lb_totalPagado.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Total"].Value);
            this.lb_totalGanado.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Ganancias"].Value);

            lbPagado = Convert.ToString(this.data_Listado.CurrentRow.Cells["Total"].Value);
            lbPagado1 = Convert.ToDecimal(lbPagado);
            this.lb_totalPagado.Text = lbPagado1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            lbGanado = Convert.ToString(this.data_Listado.CurrentRow.Cells["Ganancias"].Value);
            lbGanado1 = Convert.ToDecimal(lbGanado);
            this.lb_totalGanado.Text = lbGanado1.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));

            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            ReporteIngreso frm = new ReporteIngreso();
            frm.ShowDialog();
        }
    }
}

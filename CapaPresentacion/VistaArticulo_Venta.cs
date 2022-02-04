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
    public partial class VistaArticulo_Venta : Form
    {
        public VistaArticulo_Venta()
        {
            InitializeComponent();
        }

        //Metodo para ocultar columnas del datagridveiw
        private void OcultarColumnas()
        {
            this.data_Listado.Columns[0].Visible = false;
            this.data_Listado.Columns[1].Visible = false;
            this.data_Listado.Columns[7].Visible = false;
            this.data_Listado.Columns[7].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[7].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            this.data_Listado.Columns[8].DefaultCellStyle.Format = "c";
            this.data_Listado.Columns[8].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
        }

        
        //Metodo para Mostrar por el nombre
        private void MostrarArticulo_Venta_Nombre()
        {
            this.data_Listado.DataSource = NVenta.MostrarArticulo_Venta_Nombre(this.txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para Mostrar por el nombre
        private void MostrarArticulo_Venta_Codigo()
        {
            this.data_Listado.DataSource = NVenta.MostrarArticulo_Venta_Codigo(this.txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void VistaArticulo_Venta_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Venta form = Venta.GetInstancia();
                string par1, par2;
                decimal par3, par4;
                int par5;
                DateTime par6;
                par1 = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdDetalle_ingreso"].Value);
                par2 = Convert.ToString(this.data_Listado.CurrentRow.Cells["Nombre"].Value);
                par3 = Convert.ToDecimal(this.data_Listado.CurrentRow.Cells["Precio_compra"].Value);
                par4 = Convert.ToDecimal(this.data_Listado.CurrentRow.Cells["Precio_venta"].Value);
                par5 = Convert.ToInt32(this.data_Listado.CurrentRow.Cells["Stock_final"].Value);
                par6 = Convert.ToDateTime(this.data_Listado.CurrentRow.Cells["Fecha_vencimiento"].Value);
                form.setArticulo(par1, par2, par3, par4, par5, par6);
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Aviso", "No puedes realizar esta acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.MostrarArticulo_Venta_Codigo();
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.MostrarArticulo_Venta_Nombre();
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.MostrarArticulo_Venta_Codigo();
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.MostrarArticulo_Venta_Nombre();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion.Consultas
{
    public partial class Consulta_Stock_Articulos : Form
    {
        private int sumStockIngreso = 0;
        private int sumStockActual = 0;
        private int sumStockVendido = 0;

        public Consulta_Stock_Articulos()
        {
            InitializeComponent();
        }

        //Metodo para ocultar columnas del datagridveiw
        private void OcultarColumnas()
        {
            this.data_Listado.Columns[0].Visible = false;
        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NArticulo.Stock_Articulos();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void Consulta_Stock_Articulos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();

            if (sumStockIngreso == 0 && sumStockActual == 0 && sumStockVendido == 0)
            {
                foreach (DataGridViewRow row in data_Listado.Rows)
                {
                    sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                    sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                    sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);

                }

                lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                lb_stockActual.Text = Convert.ToString(sumStockActual);
                lb_stockVendido.Text = Convert.ToString(sumStockVendido);
            }
            else
            {
                sumStockIngreso = 0;
                sumStockActual = 0;
                sumStockVendido = 0;

                foreach (DataGridViewRow row in data_Listado.Rows)
                {
                    sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                    sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                    sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);
                }
                lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                lb_stockActual.Text = Convert.ToString(sumStockActual);
                lb_stockVendido.Text = Convert.ToString(sumStockVendido);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Redondo2_Click(object sender, EventArgs e)
        {
            ReporteStock frm = new ReporteStock();
            frm.ShowDialog();
        }

        private void data_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Metodo para buscar por el nombre
        private void BuscarNombre()
        {
            this.data_Listado.DataSource = NArticulo.BuscarStockArticuloNombre(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el codigo
        private void BuscarCodgio()
        {
            this.data_Listado.DataSource = NArticulo.BuscarStockArticuloCodigo(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.BuscarCodgio();
                if (sumStockIngreso == 0 && sumStockActual == 0 && sumStockVendido == 0)
                {
                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);

                    }

                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
                else
                {
                    sumStockIngreso = 0;
                    sumStockActual = 0;
                    sumStockVendido = 0;

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);
                    }
                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
                if (sumStockIngreso == 0 && sumStockActual == 0 && sumStockVendido == 0)
                {
                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);

                    }

                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
                else
                {
                    sumStockIngreso = 0;
                    sumStockActual = 0;
                    sumStockVendido = 0;

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);
                    }
                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.BuscarCodgio();
                if (sumStockIngreso == 0 && sumStockActual == 0 && sumStockVendido == 0)
                {
                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);

                    }

                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
                else
                {
                    sumStockIngreso = 0;
                    sumStockActual = 0;
                    sumStockVendido = 0;

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);
                    }
                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
                if (sumStockIngreso == 0 && sumStockActual == 0 && sumStockVendido == 0)
                {
                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);

                    }

                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
                else
                {
                    sumStockIngreso = 0;
                    sumStockActual = 0;
                    sumStockVendido = 0;

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        sumStockIngreso += Convert.ToInt32(row.Cells["Cantidad_Ingreso"].Value);
                        sumStockActual += Convert.ToInt32(row.Cells["Cantidad_Stock"].Value);
                        sumStockVendido += Convert.ToInt32(row.Cells["Cantidad_Venta"].Value);
                    }
                    lb_stockIngreso.Text = Convert.ToString(sumStockIngreso);
                    lb_stockActual.Text = Convert.ToString(sumStockActual);
                    lb_stockVendido.Text = Convert.ToString(sumStockVendido);
                }
            }
        }

        private void lb_stockActual_Click(object sender, EventArgs e)
        {

        }
    }
}

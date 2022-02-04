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

namespace CapaPresentacion
{
    public partial class VistaCliente_Venta : Form
    {
        public VistaCliente_Venta()
        {
            InitializeComponent();
        }

        private void VistaCliente_Venta_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        //Metodo para ocultar columnas del datagridveiw
        private void OcultarColumnas()
        {
            this.data_Listado.Columns[0].Visible = false;
            this.data_Listado.Columns[1].Visible = false;
        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por la Razon_social
        private void BuscarApellidos()
        {
            this.data_Listado.DataSource = NCliente.BuscarApellidos(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por Num_Documento
        private void BuscarNum_Documento()
        {
            this.data_Listado.DataSource = NCliente.BuscarNum_Documento(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            Venta form = Venta.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdCliente"].Value);
            par2 = Convert.ToString(this.data_Listado.CurrentRow.Cells["Apellidos"].Value)+ " "+
            Convert.ToString(this.data_Listado.CurrentRow.Cells["Nombre"].Value);
            form.setCliente(par1, par2);
            this.Hide();
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Apellidos"))
            {
                this.BuscarApellidos();
            }
            else if (cb_buscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }
    }
}

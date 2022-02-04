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
    public partial class VistaArticulo_Ingreso : Form
    {
        public VistaArticulo_Ingreso()
        {
            InitializeComponent();
        }

        private void VistaArticulo_Ingreso_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        //Metodo para ocultar columnas del datagridveiw
        private void OcultarColumnas()
        {
            this.data_Listado.Columns[0].Visible = false;
            this.data_Listado.Columns[1].Visible = false;
            this.data_Listado.Columns[6].Visible = false;
            this.data_Listado.Columns[8].Visible = false;

        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NArticulo.Mostrar();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el nombre
        private void BuscarNombre()
        {
            this.data_Listado.DataSource = NArticulo.BuscarNombre(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el codigo
        private void BuscarCodgio()
        {
            this.data_Listado.DataSource = NArticulo.BuscarCodgio(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            Ingreso form = Ingreso.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdArticulo"].Value);
            par2 = Convert.ToString(this.data_Listado.CurrentRow.Cells["Nombre"].Value);
            form.setArticulo(par1,par2);
            this.Hide();
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.BuscarCodgio();
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.BuscarCodgio();
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
        }

        private void data_Listado_DockChanged(object sender, EventArgs e)
        {

        }
    }
}

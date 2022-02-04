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
    public partial class VistaCategoria_Articulo : Form
    {
        public VistaCategoria_Articulo()
        {
            InitializeComponent();
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
            this.data_Listado.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el nombre
        private void BuscarNombre()
        {
            this.data_Listado.DataSource = NCategoria.BuscarNombre(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void VistaCategoria_Articulo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            Articulo form = Articulo.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdCategoria"].Value);
            par2 = Convert.ToString(this.data_Listado.CurrentRow.Cells["Nombre"].Value);
            form.serCategoria(par1, par2);
            this.Hide();
        }
        
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }
    }
}

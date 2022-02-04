using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class ReporteArticulo : Form
    {
        public ReporteArticulo()
        {
            InitializeComponent();
        }

        private void ReporteArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spmostrar_articulo' Puede moverla o quitarla según sea necesario.
            this.spmostrar_articuloTableAdapter.Fill(this.TodosReportes.spmostrar_articulo);

            this.reportViewer1.RefreshReport();
        }
    }
}

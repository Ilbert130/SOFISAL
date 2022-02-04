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
    public partial class ReporteStock : Form
    {
        public ReporteStock()
        {
            InitializeComponent();
        }

        private void ReporteStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spstock_articulos' Puede moverla o quitarla según sea necesario.
            this.spstock_articulosTableAdapter.Fill(this.TodosReportes.spstock_articulos);

            this.reportViewer1.RefreshReport();
        }
    }
}

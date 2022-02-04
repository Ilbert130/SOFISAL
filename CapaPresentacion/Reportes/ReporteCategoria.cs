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
    public partial class ReporteCategoria : Form
    {
        public ReporteCategoria()
        {
            InitializeComponent();
        }

        private void ReporteCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spmostrar_categoria' Puede moverla o quitarla según sea necesario.
            this.spmostrar_categoriaTableAdapter.Fill(this.TodosReportes.spmostrar_categoria);

            this.reportViewer1.RefreshReport();
        }
    }
}

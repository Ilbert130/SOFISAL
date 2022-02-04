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
    public partial class FacturaNCF : Form
    {
        private int _IdVenta;
        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        public FacturaNCF()
        {
            InitializeComponent();
        }

        private void FacturaNCF_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spreporte_factura' Puede moverla o quitarla según sea necesario.
            this.spreporte_facturaTableAdapter.Fill(this.TodosReportes.spreporte_factura,IdVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class rptCotizacion_Factura : Form
    {
        private int _IdCotizacion;
        public int IdCotizacion
        {
            get { return _IdCotizacion; }
            set { _IdCotizacion = value; }
        }
        public rptCotizacion_Factura()
        {
            InitializeComponent();
        }

        private void rptCotizacion_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spreporte_cotizacion_factura' Puede moverla o quitarla según sea necesario.
            this.spreporte_cotizacion_facturaTableAdapter.Fill(this.TodosReportes.spreporte_cotizacion_factura,IdCotizacion);

            this.reportViewer1.RefreshReport();
        }
    }
}

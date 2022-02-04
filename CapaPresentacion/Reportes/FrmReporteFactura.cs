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
    public partial class FrmReporteFactura : Form
    {
        private int _IdVenta;
        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spreporte_factura' Puede moverla o quitarla según sea necesario.
            this.spreporte_facturaTableAdapter.Fill(this.TodosReportes.spreporte_factura, IdVenta);
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spreporte_factura_comprobante' Puede moverla o quitarla según sea necesario.
            //this.spreporte_factura.Fill(this.dsPrincipal.spreporte_factura_comprobante,IdVenta);
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

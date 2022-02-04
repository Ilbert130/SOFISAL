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
    public partial class FrmReporteFacturaNFC : Form
    {
        private int _Idventa;
        public int Idventa
        {
            get
            {
                return _Idventa;
            }
            set
            {
                _Idventa = value;  
            }
        }
        public FrmReporteFacturaNFC()
        {
            InitializeComponent();
        }

        private void FrmReporteFacturaNFC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spreporte_factura' Puede moverla o quitarla según sea necesario.
            this.spreporte_facturaTableAdapter.Fill(this.TodosReportes.spreporte_factura,Idventa);

            this.reportViewer1.RefreshReport();
        }
    }
}

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
    public partial class ReporteVenta : Form
    {
        public ReporteVenta()
        {
            InitializeComponent();
        }

        public string Fecha1 { get; set; }
        public string Fecha2 { get; set; }

        //this.dtFecha1.Value.ToString("dd/MM/yyyy"), this.dtFecha2.Value.ToString("dd/MM/yyyy")

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReporteVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spbuscar_venta_fecha' Puede moverla o quitarla según sea necesario.
            this.spbuscar_venta_fechaTableAdapter.Fill(this.TodosReportes.spbuscar_venta_fecha,Fecha1,Fecha2);

            this.reportViewer1.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fecha1 = dateTP_Inicio.Value.ToString("yyyy-MM-dd");
            Fecha2 = dateTPfinal.Value.ToString("yyyy-MM-dd");
            this.spbuscar_venta_fechaTableAdapter.Fill(this.TodosReportes.spbuscar_venta_fecha, Fecha1, Fecha2);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTPfinal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTP_Inicio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

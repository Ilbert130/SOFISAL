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
    public partial class ReporteIngreso : Form
    {
        public ReporteIngreso()
        {
            InitializeComponent();
        }

        public string Fecha1 { get; set; }
        public string Fecha2 { get; set; }

        private void ReporteIngreso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TodosReportes.spbuscar_ingreso_fecha' Puede moverla o quitarla según sea necesario.
            this.spbuscar_ingreso_fechaTableAdapter.Fill(this.TodosReportes.spbuscar_ingreso_fecha,Fecha1,Fecha2);

            this.reportViewer1.RefreshReport();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Fecha1 = dateTP_Inicio.Value.ToString("yyyy-MM-dd");
            Fecha2 = dateTPfinal.Value.ToString("yyyy-MM-dd");
            this.spbuscar_ingreso_fechaTableAdapter.Fill(this.TodosReportes.spbuscar_ingreso_fecha, Fecha1, Fecha2);
            this.reportViewer1.RefreshReport();
        }
    }
}

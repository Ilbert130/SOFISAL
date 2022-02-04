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
    public partial class Principal : Form
    {
        private int childFormNumber = 0;
        //Estas variable van a recibir los datos del formulario Login
        public string IdTrabajador = "";
        public string Apellido = "";
        public string Nombre = "";
        public string Acceso = "";
        public string Cnombre;
        
        
        public Principal()
        {
            InitializeComponent();
            customizeDesing();
        }


        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion presentacion = new Presentacion();
            presentacion.MdiParent = this;
            presentacion.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo articulo = Articulo.GetInstancia();
            articulo.MdiParent = this;
            articulo.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.MdiParent = this;
            proveedor.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trabajador trabajador = new Trabajador();
            trabajador.MdiParent = this;
            trabajador.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            GestionUsuario();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
            string nombre1 = Nombre + " " + Apellido;
            lb_nombre.Text = nombre1;
        }

        private void customizeDesing()
        {
            panelAlmacenSubMenu.Visible = false;
            panelComprasubMenu.Visible = false;
            panelMantenimientoSubMenu.Visible = false;
            panelStockArticulosSubMenu.Visible = false;
            panelVentasSubMenu.Visible = false;
            panelSalirSubMenu.Visible = false;
            panelAyudaSubMenu.Visible = false;
            
        }

        private void hideSubMenu()
        {
            if (panelAlmacenSubMenu.Visible == true)
            {
                panelAlmacenSubMenu.Visible = false;
            }
            if (panelComprasubMenu.Visible == true)
            {
                panelComprasubMenu.Visible = false;
            }
            if (panelMantenimientoSubMenu.Visible == true)
            {
                panelMantenimientoSubMenu.Visible = false;
            }
            if (panelStockArticulosSubMenu.Visible == true)
            {
                panelStockArticulosSubMenu.Visible = false;
            }
            if (panelVentasSubMenu.Visible == true)
            {
                panelVentasSubMenu.Visible = false;
            }
            if (panelSalirSubMenu.Visible == true)
            {
                panelSalirSubMenu.Visible = false;
            }
            if (panelAyudaSubMenu.Visible == true)
            {
                panelAyudaSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        //Metodo para gestionar el acceso de los usarios
        private void GestionUsuario()
        {
            if (Acceso=="Administrador")
            {
                this.btn_Almacen.Enabled = true;
                this.btn_compras.Enabled = true;
                this.btn_ventas.Enabled = true;
                this.btn_mantenimiento.Enabled = true;
                this.btn_consultar.Enabled = true;
            }
            else if (Acceso == "Vendedor")
            {
                this.btn_Almacen.Enabled = false;
                this.btn_compras.Enabled = false;
                this.btn_ventas.Enabled = true;
                this.btn_mantenimiento.Enabled = false;
                this.btn_consultar.Enabled = true;
                this.button3.Enabled = false;
            }
            else if (Acceso == "Almacenero")
            {
                this.btn_Almacen.Enabled = true;
                this.btn_compras.Enabled = true;
                this.btn_ventas.Enabled = false;
                this.btn_mantenimiento.Enabled = false;
                this.btn_consultar.Enabled = true;
                this.button1.Enabled = false;
            }
            else
            {
                this.btn_Almacen.Enabled = false;
                this.btn_compras.Enabled = false;
                this.btn_mantenimiento.Enabled = false;
                this.btn_mantenimiento.Enabled = false;
                this.btn_consultar.Enabled = false;
            }
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso frm = Ingreso.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.IdTrabajador = Convert.ToInt32(this.IdTrabajador);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Venta frm = Venta.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.IdTrabajador = Convert.ToInt32(this.IdTrabajador);
        }

        private void stockDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.Consulta_Stock_Articulos frm = new Consultas.Consulta_Stock_Articulos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btn_Almacen_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAlmacenSubMenu);
        }

        private void btn_articulos_Click(object sender, EventArgs e)
        {
            Articulo frm = Articulo.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            //
            hideSubMenu();
        }

        private void btn_categorias_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            categoria.MdiParent = this;
            categoria.Show();
            ///
            //
            hideSubMenu();
        }

        private void btn_presentacion_Click(object sender, EventArgs e)
        {
            Presentacion presentacion = new Presentacion();
            presentacion.MdiParent = this;
            presentacion.Show();
            ///
            //
            hideSubMenu();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelComprasubMenu);
        }

        private void btn_ingresos_Click(object sender, EventArgs e)
        {
            Ingreso frm = Ingreso.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.IdTrabajador = Convert.ToInt32(this.IdTrabajador);
            ///
            //
            hideSubMenu();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.MdiParent = this;
            proveedor.Show();
            ///
            //
            hideSubMenu();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelVentasSubMenu);
        }

        private void btn_sventas_Click(object sender, EventArgs e)
        {
            Venta frm = Venta.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.IdTrabajador = Convert.ToInt32(this.IdTrabajador);
            ///
            //
            hideSubMenu();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.MdiParent = this;
            cliente.Show();
            ///
            //
            hideSubMenu();
        }

        private void btn_mantenimiento_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMantenimientoSubMenu);
        }

        private void btn_trabajadores_Click(object sender, EventArgs e)
        {
            Trabajador trabajador = new Trabajador();
            trabajador.MdiParent = this;
            trabajador.Show();
            ///
            //
            hideSubMenu();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStockArticulosSubMenu);
        }

        private void btn_stockArticulos_Click(object sender, EventArgs e)
        {
            Consultas.Consulta_Stock_Articulos frm = new Consultas.Consulta_Stock_Articulos();
            frm.MdiParent = this;
            frm.Show();
            ///
            //
            hideSubMenu();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_SOFISAL_Click(object sender, EventArgs e)
        {
            Articulo.instancia = null;
            Ingreso.instancia = null;
            Venta.instancia = null;


            Login login = new Login();
            login.Show();
            this.Hide();
            this.Dispose();
            ///
            //
            hideSubMenu();
        }

        private void ptb_abajo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAyudaSubMenu);
        }

        private void btn_manualAyuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/15ZvhfxxdSXirZES3nAcvxFlOobsSSgof/view?usp=sharing");
            //
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InfoAPP frm = new InfoAPP();
            frm.ShowDialog();
            ///
            //
            hideSubMenu();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaVentas frm = new Consultas.ConsultaVentas();
            frm.MdiParent = this;
            frm.Show();
            frm.IdTrabajador = Convert.ToInt32(this.IdTrabajador);
            ///
            //
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaCompras frm = new Consultas.ConsultaCompras();
            frm.MdiParent = this;
            frm.Show();
            frm.IdTrabajador = Convert.ToInt32(this.IdTrabajador);
            ///
            //
            hideSubMenu();
        }

        private void panelSalirSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ///
            //
            hideSubMenu();
        }

        private void lb_nombre_Click(object sender, EventArgs e)
        {
            

        }
    }
}

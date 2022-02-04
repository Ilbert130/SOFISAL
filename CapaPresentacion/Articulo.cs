using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class Articulo : Form
    {

        //Estas variables me van a indicar si voy a insertar un articulo o lo voy a editar
        private bool IsNuevo = false;
        private bool IsEditar = false;

        private static Articulo _instancia;

        public static Articulo instancia
        {
            get { return _instancia; }
            set { _instancia = value; }
        }
        public static Articulo GetInstancia()
        {

            if (_instancia == null)
            {
                _instancia = new Articulo();
            }
            return _instancia;
        }


        //metodo para enviar los valores resivido a la caja de texto desde vistacategoria_articulo ha articulo
        public void serCategoria(string idCategoria, string nombre)
        {
            this.txt_idcategoria.Text = idCategoria;
            this.txt_categoria.Text = nombre;
        }

        public Articulo()
        {
            InitializeComponent();
            //asi se pone el tooltip para ayudar el usuario 
            this.tt_mensaje.SetToolTip(this.txt_nombre, "Ingrese el nombre del Articulo ");
            this.tt_mensaje.SetToolTip(this.px_imagen, "Seleccione la imagen del Articulo ");
            this.tt_mensaje.SetToolTip(this.txt_categoria, "La categoria del Articulo ");
            this.tt_mensaje.SetToolTip(this.cb_idpresentacion, "Seleccionar la presentacion del Articulo ");

            this.txt_idcategoria.Visible = false;
            this.txt_categoria.ReadOnly = true;
            this.LlenarComboPresentacion();
        }

        //Metodo para quitar el errorProvider
        private void BorrarMensajeError()
        {
            error_icono.SetError(txt_nombre, "");
            error_icono.SetError(txt_codigo, "");
            error_icono.SetError(txt_categoria, "");
        }

        //Mostrar mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo para limpiar todos los controles del formulario
        private void Limpiar()
        {
            this.txt_codigo.Text = string.Empty;
            this.txt_nombre.Text = string.Empty;
            this.txt_descripcion.Text = string.Empty;
            this.txt_categoria.Text = string.Empty;
            this.txt_IdArticulo.Text = string.Empty;
            this.px_imagen.Image = global::CapaPresentacion.Properties.Resources.file;
        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txt_codigo.ReadOnly = !valor;
            this.txt_nombre.ReadOnly = !valor;
            this.txt_descripcion.ReadOnly = !valor;
            this.btn_buscarCategoria.Enabled = valor;
            this.cb_idpresentacion.Enabled = valor;
            this.btn_cargar.Enabled = valor;
            this.btn_limpirarimg.Enabled = valor;
            this.txt_IdArticulo.ReadOnly = !valor;
        }

        //Metodo para habilitar los botones 
        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btn_nuevo.Enabled = false;
                this.btn_guardar.Enabled = true;
                this.btn_editar.Enabled = false;
                this.btn_cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btn_nuevo.Enabled = true;
                this.btn_guardar.Enabled = false;
                this.btn_editar.Enabled = true;
                this.btn_cancelar.Enabled = false;
            }
        }


        //Metodo para ocultar columnas del datagridveiw
        private void OcultarColumnas()
        {
            this.data_Listado.Columns[0].Visible = false;
            this.data_Listado.Columns[1].Visible = false;
            this.data_Listado.Columns[6].Visible = false;
            this.data_Listado.Columns[8].Visible = false;

        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NArticulo.Mostrar();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el nombre
        private void BuscarNombre()
        {
            this.data_Listado.DataSource = NArticulo.BuscarNombre(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por el codigo
        private void BuscarCodgio()
        {
            this.data_Listado.DataSource = NArticulo.BuscarCodgio(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Este metodo es para llenar el comboboxPresentacion desde la tablas
        private void LlenarComboPresentacion()
        {
            cb_idpresentacion.DataSource = NPresentacion.Mostrar();//en el datasource se estan cargando los datos 
            cb_idpresentacion.ValueMember = "IdPresentacion";//Los datos se estan filtrando por el idPresentacion
            cb_idpresentacion.DisplayMember = "Nombre";//Los datos que queremos mostrar de presentacion en el combobox
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            DialogResult result = dialog.ShowDialog();//variable sera el resultado cuando mostremos el cuadro de dialogo 
            
            if (result==DialogResult.OK)
            {
                this.px_imagen.SizeMode = PictureBoxSizeMode.StretchImage;//para adecuar la imagen al picture box
                this.px_imagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void Articulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            
        }

        private void btn_limpirarimg_Click(object sender, EventArgs e)
        {
            this.px_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.px_imagen.Image = global::CapaPresentacion.Properties.Resources.file;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.BuscarCodgio();
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            
        }

        

        private void chk_eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_eliminar.Checked)
            {
                this.data_Listado.Columns[0].Visible = true;
            }
            else
            {
                this.data_Listado.Columns[0].Visible = false;
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los resgistros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respuesta = NArticulo.Eliminar(Convert.ToInt32(Codigo));

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Respuesta);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btn_buscarCategoria_Click(object sender, EventArgs e)
        {
            VistaCategoria_Articulo form = new VistaCategoria_Articulo();
            form.ShowDialog();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Codigo"))
            {
                this.BuscarCodgio();
            }
            else if (cb_buscar.Text.Equals("Nombre"))
            {
                this.BuscarNombre();
            }
        }

        private void boton_Redondo1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar los resgistros", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    string Codigo;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in data_Listado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Respuesta = NArticulo.Eliminar(Convert.ToInt32(Codigo));

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Se elimino correctamente el registro");
                            }
                            else
                            {
                                this.MensajeError(Respuesta);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El Articulo seleccionado esta en uso, No se puede eliminar.", "Nota Importante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_Redondo2_Click(object sender, EventArgs e)
        {
            ReporteArticulo frm = new ReporteArticulo();
            frm.ShowDialog();
        }

        private void boton_Redondo3_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txt_codigo.Focus();
            this.data_Listado.Enabled = false;
        }

        private void boton_Redondo6_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txt_nombre.Text == string.Empty || this.txt_idcategoria.Text == string.Empty || this.txt_codigo.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_nombre, "Ingrese un valor");
                    error_icono.SetError(txt_codigo, "Ingrese un valor");
                    error_icono.SetError(txt_categoria, "Ingrese un valor");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();//estamos creando un espacio en la memoria atraves de un objeto
                    this.px_imagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);//aqui se esta almacenando la imagen en el buffer

                    byte[] imagen = ms.GetBuffer();//Se esta obteniendo lo que se almaceno el buffer



                    if (this.IsNuevo)
                    {
                        respuesta = NArticulo.Insertar(this.txt_codigo.Text, this.txt_nombre.Text.Trim().ToUpper(), this.txt_descripcion.Text.Trim(),
                            imagen, Convert.ToInt32(this.txt_idcategoria.Text), Convert.ToInt32(this.cb_idpresentacion.SelectedValue));
                    }
                    else
                    {
                        respuesta = NArticulo.Editar(Convert.ToInt32(this.txt_IdArticulo.Text), this.txt_codigo.Text, this.txt_nombre.Text.Trim().ToUpper(),
                            this.txt_descripcion.Text.Trim(), imagen, Convert.ToInt32(this.txt_idcategoria.Text), Convert.ToInt32(this.cb_idpresentacion.SelectedValue));
                    }

                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se inserto de forma correcta el registro");
                        }
                        else
                        {
                            this.MensajeOk("Se actualizo de forma correcta el registro");
                        }
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                    this.BorrarMensajeError();
                    this.data_Listado.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void boton_Redondo5_Click(object sender, EventArgs e)
        {
            if (!this.txt_IdArticulo.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
                this.data_Listado.Enabled = false;
            }
            else
            {
                this.MensajeError("Debe de selecionar el registro a Modificar");
            }
        }

        private void boton_Redondo4_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
            this.BorrarMensajeError();
            this.data_Listado.Enabled = true;
        }

        private void Articulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instancia = null;
        }

        private void data_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {

        }

        private void data_Listado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == data_Listado.Columns["Eliminar"].Index)
            {
                //Es para determinar el checkbox que se va a elimnar atraves de las filas y celdas 
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)data_Listado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void data_Listado_DoubleClick_1(object sender, EventArgs e)
        {
            this.txt_IdArticulo.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdArticulo"].Value);
            this.txt_codigo.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Codigo"].Value);
            this.txt_nombre.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Nombre"].Value);
            this.txt_descripcion.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Descripcion"].Value);

            byte[] imagenBuffer = (byte[])this.data_Listado.CurrentRow.Cells["Imagen"].Value;//Estamos almacenando en una variable el la imagen que esta en el datagriwiew
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);//Estamos haciendo un espacio en la memoria y le estamos pasando la imagen 

            this.px_imagen.Image = Image.FromStream(ms);//aqui estamos pasando el buffer donde esta la imagen al pictorebox
            this.px_imagen.SizeMode = PictureBoxSizeMode.StretchImage;//aqui estamos adactando la pamaje a la longitud del picturebox

            this.txt_idcategoria.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdCategoria"].Value);
            this.txt_categoria.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Categoria"].Value);
            this.cb_idpresentacion.SelectedValue = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdPresentacion"].Value);


            this.tabControl1.SelectedIndex = 1;
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_buscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

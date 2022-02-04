using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Cliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public Cliente()
        {
            InitializeComponent();
            this.tt_mensaje.SetToolTip(this.txt_nombre, "Ingrese el nombre del cliente");
            this.tt_mensaje.SetToolTip(this.txt_apellidos, "Ingrese los apellidos del cliente");
            this.tt_mensaje.SetToolTip(this.txt_direccion, "Ingrese la direccion del cliente");
            this.tt_mensaje.SetToolTip(this.txt_num_documentos, "Ingrese el numero de documento del cliente");
        }

        //Metodo para quitar el errorProvider
        private void BorrarMensajeError()
        {
            error_icono.SetError(txt_nombre, "");
            //asi se habilita el error provider al lado de un texbox
            error_icono.SetError(txt_apellidos, "");
            //asi se habilita el error provider al lado de un texbox
            error_icono.SetError(txt_num_documentos, "");
            //asi se habilita el error provider al lado de un texbox
            error_icono.SetError(txt_direccion, "");
        }
    

        //Metodos 
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
            this.txt_nombre.Text = string.Empty;
            this.txt_apellidos.Text = string.Empty;
            this.txt_num_documentos.Text = string.Empty;
            this.txt_direccion.Text = string.Empty;
            this.txt_telefono.Text = string.Empty;
            this.txt_email.Text = string.Empty;
            this.txt_Idcliente.Text = string.Empty;
        }

        //Metodo para habilitar los controles del formulario
        private void Habilitar(bool valor)
        {
            this.txt_nombre.ReadOnly = !valor;
            this.txt_apellidos.ReadOnly = !valor;
            this.txt_direccion.ReadOnly = !valor;
            this.cb_tipo_documento.Enabled = valor;
            this.txt_num_documentos.ReadOnly = !valor;
            this.txt_telefono.ReadOnly = !valor;
            this.txt_email.ReadOnly = !valor;
            this.txt_Idcliente.ReadOnly = !valor;
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
        }

        //Metodo mostrar
        private void Mostrar()
        {
            this.data_Listado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por Apellidos
        private void BuscarApellidos()
        {
            this.data_Listado.DataSource = NCliente.BuscarApellidos(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        //Metodo para buscar por Num_Documento
        private void BuscarNum_Documento()
        {
            this.data_Listado.DataSource = NCliente.BuscarNum_Documento(txt_buscar.Text);
            this.OcultarColumnas();
            lb_total.Text = "Total de Registros: " + Convert.ToString(data_Listado.Rows.Count);
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
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

        private void data_Listado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //este codigo hace referencia al indice de las columnas haciendo una comparacion con la que se va a eliminar
            if (e.ColumnIndex == data_Listado.Columns["Eliminar"].Index)
            {
                //Es para determinar el checkbox que se va a elimnar atraves de las filas y celdas 
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)data_Listado.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void data_Listado_DoubleClick(object sender, EventArgs e)
        {
            this.txt_Idcliente.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["IdCliente"].Value);
            this.txt_nombre.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Nombre"].Value);
            this.txt_apellidos.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Apellidos"].Value);
            this.cb_sexo.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Sexo"].Value);
            this.dt_fechaNacimiento.Value = Convert.ToDateTime(this.data_Listado.CurrentRow.Cells["Fecha_nacimiento"].Value);
            this.cb_tipo_documento.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Tipo_documento"].Value);
            this.txt_num_documentos.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Num_documento"].Value);
            this.txt_direccion.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Direccion"].Value);
            this.txt_telefono.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Telefono"].Value);
            this.txt_email.Text = Convert.ToString(this.data_Listado.CurrentRow.Cells["Email"].Value);

            this.tabControl1.SelectedIndex = 1;
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

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void boton_Redondo3_Click(object sender, EventArgs e)
        {
            if (cb_buscar.Text.Equals("Apellidos"))
            {
                this.BuscarApellidos();
            }
            else if (cb_buscar.Text.Equals("Documento"))
            {
                this.BuscarNum_Documento();
            }
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
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
                            Respuesta = NCliente.Eliminar(Convert.ToInt32(Codigo));

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

        private void boton_Redondo2_Click(object sender, EventArgs e)
        {
            ReporteClientes frm = new ReporteClientes();
            frm.ShowDialog();
        }

        private void boton_Redondo4_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txt_nombre.Focus();
            this.data_Listado.Enabled = false;
        }

        private void boton_Redondo1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txt_nombre.Text == string.Empty || this.txt_apellidos.Text == string.Empty ||
                    this.txt_num_documentos.Text == string.Empty || this.txt_direccion.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, seran remarcados");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_nombre, "Ingrese un valor");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_apellidos, "Ingrese un valor");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_num_documentos, "Ingrese un valor");
                    //asi se habilita el error provider al lado de un texbox
                    error_icono.SetError(txt_direccion, "Ingrese un valor");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = NCliente.Insertar(this.txt_nombre.Text.Trim().ToUpper(), this.txt_apellidos.Text.Trim().ToUpper(), this.cb_sexo.Text,
                             dt_fechaNacimiento.Value, cb_tipo_documento.Text, txt_num_documentos.Text, txt_direccion.Text, txt_telefono.Text, txt_email.Text);
                    }
                    else
                    {
                        respuesta = NCliente.Editar(Convert.ToInt32(this.txt_Idcliente.Text), this.txt_nombre.Text.Trim().ToUpper(), this.txt_apellidos.Text.Trim().ToUpper(), this.cb_sexo.Text,
                             dt_fechaNacimiento.Value, cb_tipo_documento.Text, txt_num_documentos.Text, txt_direccion.Text, txt_telefono.Text, txt_email.Text);
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

        private void boton_Redondo2_Click_1(object sender, EventArgs e)
        {
            if (!this.txt_Idcliente.Text.Equals(""))
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

        private void boton_Redondo3_Click_1(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Habilitar(false);
            this.Limpiar();
            this.BorrarMensajeError();
            this.data_Listado.Enabled = true;
            this.txt_Idcliente.Text = string.Empty;
        }

        private void txt_num_documentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >=32&&e.KeyChar<=47)||(e.KeyChar>=58&&e.KeyChar<=255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

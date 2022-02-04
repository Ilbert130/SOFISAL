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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //Metodo para quitar el errorProvider 
        private void BorrarMensajeError()
        {
            errorProvider1.SetError(txt_usario, "");
            errorProvider1.SetError(txt_password, "");
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.NTrabajador.Login(this.txt_usario.Text,txt_password.Text);
            //Evaluar si realmente existe el usuario
            if (Datos.Rows.Count==0)
            {
                MessageBox.Show("No tiene Acceso al Sistema","Sistema SOFISAL",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                Principal principal = new Principal();
                //Se estan llenando las variables que se encuentran en el formulario principal encima del constructor del formulario
                principal.IdTrabajador = Datos.Rows[0][0].ToString();
                principal.Apellido = Datos.Rows[0][1].ToString();
                principal.Nombre = Datos.Rows[0][2].ToString();
                principal.Acceso = Datos.Rows[0][3].ToString();


                principal.Show();
                this.Hide();
            }
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.NTrabajador.Login(this.txt_usario.Text, txt_password.Text);
            //Evaluar si realmente existe el usuario
            if (Datos.Rows.Count == 0)
            {
                if (txt_usario.Text==""||txt_password.Text=="")
                {
                    errorProvider1.SetError(txt_usario,"Ingrese el usuario");
                    errorProvider1.SetError(txt_password, "Ingrese la contraseña");
                    
                }
                MessageBox.Show("No tiene Acceso al Sistema", "Sistema SOFISAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_usario.Text = "";
                txt_password.Text = "";
            }
            else
            {
                
                Principal principal = new Principal();
                //Se estan llenando las variables que se encuentran en el formulario principal encima del constructor del formulario
                principal.IdTrabajador = Datos.Rows[0][0].ToString();
                principal.Apellido = Datos.Rows[0][1].ToString();
                principal.Nombre = Datos.Rows[0][2].ToString();
                principal.Acceso = Datos.Rows[0][3].ToString();
                Venta.Acceso=Datos.Rows[0][3].ToString();
                Ingreso.Acceso = Datos.Rows[0][3].ToString();
                this.BorrarMensajeError();

                principal.Show();
                this.Hide();
            }
        }

        private void boton_Redondo1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using GuarderiaCanina.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuarderiaCanina.InterfacesUsuario.Login
{
    public partial class FrmLogin : Form
    {
        private readonly EmpleadoServicio empleadoServicio;
       
        public FrmLogin()
        {
            InitializeComponent();
            empleadoServicio = new EmpleadoServicio();
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            if (TxtUsuario.Text.Trim().Length != 0 && TxtUsuario.Text.Trim().Length != 0)
            {
                if (isNumericDNI() && isNumericPass())
                {
                    empleado.Id = int.Parse(TxtUsuario.Text.Trim());
                    empleado.Contrasenia = TxtContrasenia.Text.Trim();
                }
            else if (isNumericDNI())
                {
                    MessageBox.Show("Ingrese informacion valida para iniciar sesion", "Datos no ingresados", MessageBoxButtons.OK);
                    return;
                }
            else if (isNumericPass())
                {
                    MessageBox.Show("Ingrese informacion valida para iniciar sesion", "Datos no ingresados", MessageBoxButtons.OK);
                    return;
                }                  
            }
            else 
            {
                MessageBox.Show("Ingrese informacion valida para iniciar sesion", "Datos no ingresados", MessageBoxButtons.OK);
                return;
            }


            if (empleadoServicio.Login(empleado))
            {

                this.Hide();
                var frmPrincipal = new FrmPrincipal();
                frmPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña inválidas", "Información", MessageBoxButtons.OK);
                new FrmLogin();
            }
        }
            
            private bool isNumericDNI()
        {
            bool isNumeric = int.TryParse(TxtUsuario.Text.Trim(), out _);
            return isNumeric;
        }
        private bool isNumericPass()
        {
            bool isNumeric = int.TryParse(TxtContrasenia.Text.Trim(), out _);
            return isNumeric;
        }

        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }


    }
}

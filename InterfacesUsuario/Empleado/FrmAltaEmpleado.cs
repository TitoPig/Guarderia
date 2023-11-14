using GuarderiaCanina.Entidades;
using GuarderiaCanina.Servicios;
using System;
using System.Windows.Forms;

namespace GuarderiaCanina.InterfacesUsuario
{
    public partial class FrmAltaEmpleado : Form
    {
        public readonly EmpleadoServicio empleadoServicio;
        public FrmAltaEmpleado()
        {
            InitializeComponent();
            empleadoServicio = new EmpleadoServicio();
        }

        private void BtnEGuardar_Click(object sender, EventArgs e)
        {
            var empleado = new Empleado();
            empleado.Nombre = TxtENombre.Text.Trim();
            empleado.Apellido = TxtEApellido.Text.Trim();
            empleado.Id = int.Parse(TxtENDoc.Text.Trim());
            empleado.Telefono = int.Parse(TxtETelefono.Text.Trim());
            empleado.Direccion = TxtEDir.Text.Trim();
            empleado.Rol = CMBRol.SelectedItem.ToString();
            empleado.Contrasenia = TxtContraseña.Text.Trim();

            if (empleado.Nombre == null)
            {
                MessageBox.Show("Faltan datos", "Informacion", MessageBoxButtons.OK);
                return;

            }

            if (empleadoServicio.AgregarEmpleado(empleado))
            {
                MessageBox.Show("Empleado Agregado correctamente, ID:" + $"{empleado.Id}", "Informacion", MessageBoxButtons.OK);
                
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Empleado incorrecto", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void BtnECancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void CMBRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

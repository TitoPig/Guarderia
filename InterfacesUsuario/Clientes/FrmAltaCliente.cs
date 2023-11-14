using GuarderiaCanina.Entidades;
using GuarderiaCanina.Servicios;
using System;
using System.Windows.Forms;

namespace GuarderiaCanina.InterfacesUsuario
{
    public partial class FrmAltaCliente : Form
    {
        private readonly ClienteServicio clienteServicio;
        private readonly int dniCliente;


        public FrmAltaCliente(int dniCli)
        {
            this.dniCliente = dniCli;
            InitializeComponent();
            clienteServicio = new ClienteServicio();
        }
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            cliente.Nombre = TxtCNombre.Text.Trim();
            cliente.Apellido = TxtCApellido.Text.Trim();
            cliente.DniCliente = int.Parse(TxtCDNI.Text.Trim());
            cliente.Telefono = int.Parse(TxtCTelefono.Text.Trim());
            cliente.Direccion = TxtCDir.Text.Trim();
            if (clienteServicio.AgregarCliente(cliente))
            {
                MessageBox.Show("Cliente agregado", "Informacion", MessageBoxButtons.OK);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Faltan datos", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmACliente_Load(object sender, EventArgs e)
        {
            TxtCDNI.Text = dniCliente.ToString();
        }

        private void TxtCTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

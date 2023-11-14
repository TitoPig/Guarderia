using GuarderiaCanina.Entidades;
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

namespace GuarderiaCanina.InterfacesUsuario
{
    public partial class FrmModificarCliente : Form
    {
        private readonly ClienteServicio clienteServicio;
        private readonly int dni;

        public FrmModificarCliente(int dni)
        {
            this.dni = dni;
            InitializeComponent();
            clienteServicio = new ClienteServicio();
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            var cli = clienteServicio.GetCliente(dni);
            TxtCDNI.Text = cli.DniCliente.ToString();
            TxtCNombre.Text = cli.Nombre;
            TxtCApellido.Text = cli.Apellido;
            TxtCDir.Text = cli.Direccion;
            TxtCTelefono.Text = cli.Telefono.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
        }

        private void ModificarCliente()
        {
            var cliente = new Cliente
            {
                DniCliente = int.Parse(TxtCDNI.Text.Trim()),
                Nombre = TxtCNombre.Text.Trim(),
                Apellido = TxtCApellido.Text.Trim(),
                Telefono = int.Parse(TxtCTelefono.Text.Trim()),
                Direccion = TxtCDir.Text.Trim()
            };

            clienteServicio.ModificarCliente(cliente);
            this.Dispose();
        }
    }
}

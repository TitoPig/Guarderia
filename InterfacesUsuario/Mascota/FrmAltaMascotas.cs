using GuarderiaCanina.Entidades;
using GuarderiaCanina.Servicios;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GuarderiaCanina.InterfacesUsuario
{
    public partial class FrmAltaMascotas : Form
    {
        private readonly MascotaServicio mascotasServicio;
        private readonly int dniCliente;
         
        public FrmAltaMascotas(int dniCli)
        {
            InitializeComponent();
            this.dniCliente = dniCli;
            mascotasServicio = new MascotaServicio();
        }

        //Eventos
        private void FrmAMascotas_Load(object sender, EventArgs e)
        {
            TxtCliente.Text = dniCliente.ToString();
        }
        private void BtnMFinalizar_Click(object sender, EventArgs e)
        {
 
            var mascota = new Entidades.Mascota();
            mascota.Nombre = TxtMNombre.Text.Trim();
            mascota.Edad = int.Parse(TxtMEdad.Text);
            mascota.Sexo = CmbMSexo.Text.Trim();
            mascota.Raza = TxtMRaza.Text.Trim();
            mascota.Peso = int.Parse(NumMPeso.Text.Trim());
            mascota.DniDuenio = int.Parse(TxtCliente.Text);

            if (mascotasServicio.AgregarMascota(mascota))
            {
                MessageBox.Show("Mascota agregada correctamente, ID:" + $"{mascota.Id}", "Informacion", MessageBoxButtons.OK);
                this.Dispose();
                
            }
            else
            {
                MessageBox.Show("Faltan datos", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void BtnECancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

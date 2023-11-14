using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuarderiaCanina.Servicios;

namespace GuarderiaCanina.InterfacesUsuario.Mascota
{
    public partial class FrmConsultaMascotas : Form
    {
        //Inicializacion de variables
        private readonly Cliente c;
        private readonly MascotaServicio mascotaServicio;

        public FrmConsultaMascotas(Cliente cli)
        {
            c = cli;
            mascotaServicio = new MascotaServicio();
            //InitializeComponent();
        }

        //Metodos
        private Form activofrm = null;
        private void OpenForm(Form form)
        {
            //nos estamos asegurando que no existe un form abierto, por eso 1ro el if

            //aqui cerramos el formulario activo para generar uno nuevo
            if (activofrm != null)
            {
                activofrm.Close();
            }
            activofrm = form;

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            //FrmContConsulta.Controls.Add(form);
            //FrmContConsulta.Visible = true;
            //FrmContConsulta.BringToFront();
            form.BringToFront();
            form.Show();


        }

        private void ConsultarTodasMascotasCliente() {
            //DGVConsulta.Rows.Clear();
            var mascotas = mascotaServicio.GetMascotasDuenio(c.DniCliente);
            foreach (var mascota in mascotas)
            {
                var fila = new string[]
                    {
                        mascota.Id.ToString(),
                        mascota.Nombre.ToString(),
                        mascota.Edad.ToString(),
                        mascota.Sexo.ToString(),
                        mascota.Raza.ToString(),
                        mascota.Peso.ToString() + " kg",
                        mascota.DniDuenio.ToString(),
                    };
                //DGVConsulta.Rows.Add(fila);
            }
        }

        //Eventos
        private void BtnECancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaMascotas_Load(object sender, EventArgs e)
        {
            //lblNombreDuenio.Text = "El nombre del dueño es: " + c.Nombre.ToString();
            ConsultarTodasMascotasCliente();

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

        }

        private void TxtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            // para descomentar ctrl + k + u
            //if (TxtConsulta.Text.Length != 0)
            //{
            //    DGVConsulta.Rows.Clear();
            //    var mas = mascotaServicio.GetMascotasNombre(TxtConsulta.Text.Trim());
            //    foreach (Entidades.Mascota mascota in mas) {
            //        var fila = new string[] {
            //            mascota.Id.ToString(),
            //            mascota.Nombre.ToString(),
            //            mascota.Edad.ToString(),
            //            mascota.Sexo.ToString(),
            //            mascota.Raza.ToString(),
            //            mascota.Peso.ToString() + " kg",
            //            mascota.DniDuenio.ToString(),
            //        };
            //        DGVConsulta.Rows.Add(fila);
            //    }
            //}
            //else {
            //    ConsultarTodasMascotasCliente();
            //}
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            var dniCli = c.DniCliente;
            OpenForm( new FrmAltaMascotas(dniCli));
        }
    }
}

using GuarderiaCanina.Repositorio;
using GuarderiaCanina.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GuarderiaCanina.InterfacesUsuario
{
    public partial class FrmCobro : Form
    {
        private readonly TurnosServicio turnoServicio;
        private readonly CobroServicio cobroServicio;
        private readonly DetalleTurnoServicio detalleTurnoServicio;
        private readonly ServiciosServicio serviciosServicio;
        private readonly long IdTurno;

        public FrmCobro(long idTurno)
        {
            turnoServicio = new TurnosServicio();
            cobroServicio = new CobroServicio();
            detalleTurnoServicio = new DetalleTurnoServicio();
            this.IdTurno = idTurno; 
            InitializeComponent();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCobro_Load(object sender, EventArgs e)
        {
            var c = new Entidades.Cobro();
            var t = new Entidades.Turno();
            t.Id = IdTurno;
            var turno = turnoServicio.ObtenerTurnoPorId(t.Id);
            var fecha = DateTime.Now;
            turno.FechaSalida = fecha.ToString();
            turno.Estado = 5;
            c.IdTurno = turno.Id;

            c.Monto = turno.Monto;
            c.FechaCobro = turno.FechaSalida;

            turnoServicio.CambiarMontoTurno(turno.Id, c.Monto);
            turnoServicio.CambiarEstadoTurnoFinalizado(turno.Id);
            cobroServicio.AgregarCobro(c);

            var cobro = cobroServicio.ObtenerCobroPorId(turno.Id);

            LblFCobro.Text = turno.FechaSalida;
            LblFInicio.Text = turno.FechaDesde;
            LblFFin.Text = turno.FechaHasta;
            LblCDNI.Text = turno.IdCliente.ToString();
            LblidM.Text = turno.IdMascota.ToString();
            LblidC.Text = cobro.Id.ToString();
            LblidT.Text = turno.Id.ToString();
            LblMontoB.Text = turno.Monto.ToString();

            /*LblSerc.Text = turno.Monto.ToString();
            LblSerb.Text = turno.Monto.ToString();
            LblSerp.Text = turno.Monto.ToString();
            LblServ.Text = turno.Monto.ToString();*/


        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }
    }
}

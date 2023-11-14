using GuarderiaCanina.Servicios;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuarderiaCanina.InterfacesUsuario.Informes.Clientes_por_demora
{
    public partial class FrmClientesIncum : Form
    {
        private readonly ReportesServicio reportesServicio;
        public FrmClientesIncum()
        {
            reportesServicio = new ReportesServicio();
            InitializeComponent();
        }

        private void FrmClientesIncum_Load(object sender, EventArgs e)
        {
            ObtenerReporte();
            LblFH.ForeColor = Color.Black;
            LblFD.ForeColor = Color.Black;
        }

        public void CargarReporte(Entidades.Turno turno)
        {
            this.RWClienteIncum.LocalReport.DataSources.Clear();
            var datos = reportesServicio.ClientesPorTurno(turno);

            var datasource = new ReportDataSource("ClientesIncumplidores", datos);

            this.RWClienteIncum.LocalReport.DataSources.Add(datasource);

            var hoy = DateTime.Now;

            var parametro = new List<ReportParameter>() {
                new ReportParameter("FechaD", hoy.ToString("dd/MM/yyyy")),
                new ReportParameter("FechaH", hoy.ToString("dd/MM/yyyy")),
                new ReportParameter("FechaA",hoy.ToString("dd/MM/yyyy"))
            };

            this.RWClienteIncum.LocalReport.SetParameters(parametro);
            this.RWClienteIncum.RefreshReport();
        }

        public void ObtenerReporte()
        {
            var turno = new Entidades.Turno();
            turno.FechaDesde = fechaDesde.Value.ToString("dd/MM/yyyy");
            turno.FechaHasta = fechaHasta.Value.ToString("dd/MM/yyyy");
            CargarReporte(turno);
        }

        private void btnCrearDT_Click(object sender, EventArgs e)
        {
            ObtenerReporte();
        }
    }
}

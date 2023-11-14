using GuarderiaCanina.Entidades;
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

namespace GuarderiaCanina.InterfacesUsuario.Informes.ClientesFrecuentes
{
    public partial class FrmClientesPorMascota : Form
    {
        private readonly ReportesServicio reportesServicio;

        public FrmClientesPorMascota()
        {
            reportesServicio = new ReportesServicio();
            InitializeComponent();
        }

        private void FrmClientesPorMascota_Load(object sender, EventArgs e)
        {
            ObtenerReporte();
        }


        public void CargarReporte(Entidades.Turno turno)
        {
            this.RWClienteFrec.LocalReport.DataSources.Clear();
            var datos = reportesServicio.ClientesPorMascota(turno);

            var datasource = new ReportDataSource("ClientesFrecuentes", datos);

            this.RWClienteFrec.LocalReport.DataSources.Add(datasource);

            var hoy = DateTime.Now;
            var parametros = new List<ReportParameter>() {
                new ReportParameter("FechaActual", hoy.ToString("dd/MM/yyyy")),
                new ReportParameter("FechaDesde", turno.FechaDesde),
                new ReportParameter("FechaHasta", turno.FechaHasta)
            };

            this.RWClienteFrec.LocalReport.SetParameters(parametros);
            this.RWClienteFrec.RefreshReport();
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

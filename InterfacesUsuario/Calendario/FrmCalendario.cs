using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuarderiaCanina.Entidades;
using GuarderiaCanina.Servicios;

namespace GuarderiaCanina.InterfacesUsuario.Calendario
{
    public partial class FrmCalendario : Form
    {
        private readonly CalendarioServicio calendarioServicio;

        public FrmCalendario()
        {
            InitializeComponent();
            calendarioServicio = new CalendarioServicio();
        }

        private void FrmCalendario_Load(object sender, EventArgs e)
        {
            var diasCalendario = calendarioServicio.ObtenerCalendario();
            DGVConsulta.ForeColor = Color.Black;
            foreach (DiaCalendario diaC in diasCalendario) {
                var fila = new string[]{
                    diaC.fecha.ToString("dd/MM/yyyy"),
                    diaC.lugaresDisponibles.ToString(),
                    diaC.lugaresOcupados.ToString(),
                    (diaC.lugaresDisponibles - diaC.lugaresOcupados).ToString()
                };
                DGVConsulta.Rows.Add(fila);
            }
        }
    }
}

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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GuarderiaCanina.InterfacesUsuario
{
    public partial class FrmConsultarTurno : Form
    {
        private readonly TurnosServicio turnoServicio;
        private readonly EstadoServicio estadoServicio;
        public FrmConsultarTurno()
        {
            InitializeComponent();
            turnoServicio = new TurnosServicio();
            estadoServicio = new EstadoServicio();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultarTurno_Load(object sender, EventArgs e)
        {
            ConsultarTodosTurnos();
            turnoServicio.CheckTurnosDemorados();
            LblTDCliente.ForeColor = Color.Black;
            DGVTurnocons.ForeColor = Color.Black;
        }

        private void BtnTConsultarTurno_Click(object sender, EventArgs e)
        {
            ConsultarTurno();
        }
        private bool isNumericTurno()
        {
            bool isNumeric = int.TryParse(TxtTurnoConsulta.Text.Trim(), out _);
            return isNumeric;
        }
        private void ConsultarTurno()
        {
            var t = new Entidades.Turno();
            if (TxtTurnoConsulta.Text.Length != 0)
            {
                if (isNumericTurno())
                {
                    t.Id = long.Parse(TxtTurnoConsulta.Text.Trim());
                    var turnos = turnoServicio.ConsultarTurno(t);
                    DGVTurnocons.Rows.Clear();
                    foreach (var turno in turnos)
                    {
                        var fila = new string[]
                        {
                            turno.Id.ToString(),
                            turno.FechaDesde.ToString(),
                            turno.FechaHasta.ToString(),
                            turno.IdCliente.ToString(),
                            turno.IdMascota.ToString(),
                            turno.IdEmpleado.ToString(),
                            turno.Monto.ToString(),
                            estadoServicio.BuscarEstadoXId(turno.Estado).Nombre
                        };
                        DGVTurnocons.Rows.Add(fila);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero como parametro", "Informacion", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un numero como parametro", "Informacion", MessageBoxButtons.OK);
                ConsultarTodosTurnos();
            }
        }
        private void ConsultarTodosTurnos()
        {
            var turn = new Entidades.Turno();
            if (TxtTurnoConsulta.Text.Length == 0)
            {
                turn.Id = 0;
            }
            else
            {
                turn.Id = int.Parse(TxtTurnoConsulta.Text.Trim());
            }
            var turnos = turnoServicio.ObtenerTodosTurnos(turn);
            DGVTurnocons.Rows.Clear();

            foreach (var turno in turnos)
            {
                var fila = new string[]
                {
                    turno.Id.ToString(),
                    turno.FechaDesde.ToString(),
                    turno.FechaHasta.ToString(),
                    turno.FechaSalida.ToString(),
                    turno.IdCliente.ToString(),
                    turno.IdMascota.ToString(),
                    turno.IdEmpleado.ToString(),
                    turno.Monto.ToString(),
                    estadoServicio.BuscarEstadoXId(turno.Estado).Nombre
                };
                DGVTurnocons.Rows.Add(fila);
            }
        }

        private void BtnCCancelar_Click(object sender, EventArgs e)
        {
            var id = long.Parse(DGVTurnocons.CurrentRow.Cells[0].Value.ToString());
            turnoServicio.CambiarEstadoTurnoCancelar(id);
            MessageBox.Show("Turno Cancelado Correctamente", "Informacion", MessageBoxButtons.OK);

        }

        private void BtnCCobrar_Click(object sender, EventArgs e)
        {
            var id = long.Parse(DGVTurnocons.CurrentRow.Cells[0].Value.ToString());
            var frmCobroTurno = new FrmCobro(id);
            frmCobroTurno.Show();
        }

        private void BtnCRecepcion_Click(object sender, EventArgs e)
        {
            var id = long.Parse(DGVTurnocons.CurrentRow.Cells[0].Value.ToString());
            turnoServicio.CambiarEstadoTurnoRecepcion(id);
            MessageBox.Show("Cambio en el estado del turno realizado correctamente: Mascota Recibida", "Informacion", MessageBoxButtons.OK);
        }

        private void BtnAct_Click(object sender, EventArgs e)
        {
            ConsultarTodosTurnos();
        }
    }
}

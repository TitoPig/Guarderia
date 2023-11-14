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
    public partial class FrmConsultaCobro : Form
    {
        private CobroServicio cobroServicio;
        private readonly TurnosServicio turnoServicio;

        public FrmConsultaCobro()
        {
            cobroServicio = new CobroServicio();
            InitializeComponent();
            turnoServicio = new TurnosServicio();
        }

        private void FrmCobroConsulta_Load(object sender, EventArgs e)
        {
            ConsultarTodosCobros();
            DGVcobroConsulta.ForeColor = Color.Black;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCobro();
        }
        private void ConsultarCobro()
        {
            bool isNumeric = int.TryParse(TxtIdConsulta.Text.Trim(), out _);

            if (TxtIdConsulta.Text.Length != 0)
            {
                if (isNumeric)
                {
                    var txtIdCliente = int.Parse(TxtIdConsulta.Text.Trim());

                    var cobrosTodos = cobroServicio.ObtenerTodosCobros();
                    DGVcobroConsulta.Rows.Clear();

                    foreach (var cobr in cobrosTodos)
                    {
                        var t = new Entidades.Turno();
                        t.IdCliente = txtIdCliente;
                        var turnos = turnoServicio.ConsultarTurno(t);

                        foreach (var turno in turnos)
                        {
                            var fila = new string[]
                            {
                                cobr.Id.ToString(),
                                turno.IdEmpleado.ToString(),
                                cobr.IdTurno.ToString(),
                                turno.IdCliente.ToString(),
                                turno.IdMascota.ToString(),
                                turno.FechaDesde.ToString(),
                                turno.FechaHasta.ToString(),
                                cobr.FechaCobro.ToString(),
                                cobr.Monto.ToString()
                            };
                            DGVcobroConsulta.Rows.Add(fila);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero como parametro por favor", "Informacion", MessageBoxButtons.OK);
                }
            }
            else
            {
                ConsultarTodosCobros();
            }
        }

        private void ConsultarTodosCobros()
        {
            var cobros = cobroServicio.ObtenerTodosCobros();
            DGVcobroConsulta.Rows.Clear();

            foreach (var cobr in cobros)
            {
                var t = new Entidades.Turno();
                t.Id = cobr.IdTurno;
                var turnos = turnoServicio.ConsultarTurno(t);

                foreach (var turno in turnos)
                {
                    var fila = new string[]
                    {
                        cobr.Id.ToString(),
                        turno.IdEmpleado.ToString(),
                        cobr.IdTurno.ToString(),
                        turno.IdCliente.ToString(),
                        turno.IdMascota.ToString(),
                        turno.FechaDesde.ToString(),
                        turno.FechaHasta.ToString(),
                        cobr.FechaCobro.ToString(),
                        cobr.Monto.ToString()
                    };
                    DGVcobroConsulta.Rows.Add(fila);
                }
            }
        }
    }
}

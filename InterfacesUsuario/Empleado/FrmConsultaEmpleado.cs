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
    public partial class FrmConsultaEmpleado : Form
    {
        private EmpleadoServicio empleadoServicio;
        //private FrmPrincipal principal;
        private bool isNumericDNI()
        {
            bool isNumeric = int.TryParse(TxtDNIConsulta.Text.Trim(), out _);
            return isNumeric;
        }
        public FrmConsultaEmpleado()
        {
            empleadoServicio = new EmpleadoServicio();
            InitializeComponent();

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarUsuarios();

        }

        private void ConsultarUsuarios()
        {
            var empl = new Empleado();
            if (TxtDNIConsulta.Text.Length != 0)
            {
                if (isNumericDNI())
                {
                    empl.Id = int.Parse(TxtDNIConsulta.Text.Trim());
                    var empleados = empleadoServicio.ObtenerEmpleados(empl);
                    DGVConsulta.Rows.Clear();

                    foreach (var empleado in empleados)
                    {
                        var fila = new string[]
                        {
                            empleado.Id.ToString(),
                            empleado.Nombre.ToString(),
                            empleado.Apellido.ToString(),
                            empleado.Telefono.ToString(),
                            empleado.Direccion.ToString(),
                            empleado.Rol.ToString(),
                        };
                        DGVConsulta.Rows.Add(fila);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero como parametro", "Informacion", MessageBoxButtons.OK);
                }
            }
            else
            {
                ConsultarTodosUsuarios();
            }
        }
        private void ConsultarTodosUsuarios()
        {
            var empl = new Empleado();
            if (TxtDNIConsulta.Text.Length == 0)
            {
                empl.Id = 0;
            }
            else
            {
                empl.Id = int.Parse(TxtDNIConsulta.Text.Trim());
            }



            var empleados = empleadoServicio.ObtenerTodosEmpleados();
            DGVConsulta.Rows.Clear();

            foreach (var empleado in empleados)
            {
                var fila = new string[]
                {
                    empleado.Id.ToString(),
                    empleado.Nombre.ToString(),
                    empleado.Apellido.ToString(),
                    empleado.Telefono.ToString(),
                    empleado.Direccion.ToString(),
                    empleado.Rol.ToString(),
                };
                DGVConsulta.Rows.Add(fila);
            }
        }

        private void BtnECancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmAEmpleadoConsulta_Load(object sender, EventArgs e)
        {
            ConsultarTodosUsuarios();
            DGVConsulta.ForeColor = Color.Black;

        }

        private void pnlELogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblEEmpleadoConsulta_Click(object sender, EventArgs e)
        {

        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado();
        }
        private void EliminarEmpleado()
        {
            var empleado = new Empleado();
            empleado.Id = long.Parse(DGVConsulta.CurrentRow.Cells[0].Value.ToString());                     
             
                    if (empleado.Id == null)

                    {
                        MessageBox.Show("Ingrese datos", "Informacion", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        var empl = empleadoServicio.EliminarEmpleado(empleado);
                    }                 
                }                            

        private void TxtDNIConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

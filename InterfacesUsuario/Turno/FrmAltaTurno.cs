
using GuarderiaCanina.Entidades;
using GuarderiaCanina.InterfacesUsuario.Turno;
using GuarderiaCanina.Repositorio;
using GuarderiaCanina.Servicios;
using GuarderiaCanina.Utils;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GuarderiaCanina.InterfacesUsuario
{
    public partial class FrmAltaTurno : Form
    {
        private readonly TurnosServicio turnoServicio;
        private readonly FrmPrincipal frmPrincipal;
        private readonly EmpleadoServicio empleadoServicio;
        private readonly MascotaServicio mascotaServicio;
        private readonly ClienteServicio clienteServicio;
        private readonly ServiciosServicio serviciosServicio;
        private readonly EstadoServicio estadoServicio;
        private readonly DetalleTurnoServicio detalleTurnoServicio;
        private readonly CalendarioServicio calendarioServicio;
       

        public FrmAltaTurno()
        {
            InitializeComponent();
            turnoServicio = new TurnosServicio();
            frmPrincipal = new FrmPrincipal(); 
            empleadoServicio = new EmpleadoServicio();
            mascotaServicio = new MascotaServicio();
            clienteServicio = new ClienteServicio();
            serviciosServicio = new ServiciosServicio();
            estadoServicio = new EstadoServicio();
            detalleTurnoServicio = new DetalleTurnoServicio();
            calendarioServicio = new CalendarioServicio();
        }

        //Metodos
        private int sumarTotal()
        {
            var total = 0;

            foreach (DataGridViewRow dr in DGVDT.Rows)
            {
                total += Convert.ToInt32(dr.Cells["precioTotal"].Value);
            }

            DateTime fechaH = fechaHasta.Value;
            DateTime fechaD = fechaDesde.Value;
           
            int diferencia = Convert.ToInt32((fechaH - fechaD).TotalDays);
            var hospedaje = serviciosServicio.ObtenerTodosServicios().Find(servicio => servicio.Nombre == "Hospedaje").Precio;
            var montoHospedaje = diferencia == 0 ? hospedaje : hospedaje * diferencia;
            total += montoHospedaje;
            return total;
        }

        private void comidaElegida()
        {
            if (comboBoxServicios.SelectedItem.ToString() == "Comida")
            {
                DateTime fechaH = fechaHasta.Value;
                DateTime fechaD = fechaDesde.Value;

                int diferencia = Convert.ToInt32((fechaH - fechaD).TotalDays);
                if (diferencia > 0)
                {
                    numericServicios.Value = diferencia;
                    numericServicios.Enabled = false;
                }
                else
                {
                    return;
                }

            }
            else
            {
                return;
            }
        }

        private bool isNumericDNI()
        {
            bool isNumeric = int.TryParse(idCliente.Text.Trim(), out _);
            return isNumeric;
        }

        private void ConsultarClienteTurno()
        {
            var c = new Cliente();
            //primero me fijo si el txtbox tiene algo escrito
            if (idCliente.Text.Length != 0)
            {
                //luego llamo a la isnumeric para saber si tiene un numero entero escrito
                if (isNumericDNI())
                {
                    c.DniCliente = int.Parse(idCliente.Text.Trim());
                    var clientes = clienteServicio.ObtenerClientes(c);
                    DGVCliente.Rows.Clear();
                    //recorro clientes que me trae una lista de objetos y por cada uno hago una lista de strings
                    foreach (var cliente in clientes)
                    {
                        var fila = new string[]
                        {
                    cliente.DniCliente.ToString(),
                    cliente.Nombre.ToString(),
                    cliente.Apellido.ToString(),
                    cliente.Telefono.ToString(),
                    cliente.Direccion.ToString(),
                        };
                        DGVCliente.Rows.Add(fila);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero como parametro", "Informacion", MessageBoxButtons.OK);
                }
            }
            if (DGVCliente.Rows.Count == 0)
            {
                MessageBox.Show("No existen clientes con el dni ingresado", "Informacion", MessageBoxButtons.OK);
            }

        }

        private void CargarCombos()
        {
            var empleados = empleadoServicio.ObtenerTodosEmpleados();

            var empleadosxDefecto = new Empleado()
            {
                Nombre = "Seleccionar"
            };

            empleados.Add(empleadosxDefecto);

            var servicios = serviciosServicio.ObtenerTodosServicios();
            servicios = servicios.FindAll(servicio => servicio.Nombre != "Hospedaje");
            var serviciosXDefecto = new Entidades.Servicios()
            {
                Nombre = "Seleccionar..."
            };
            servicios.Add(serviciosXDefecto);


            var conectorEmpleados = new BindingSource();
            conectorEmpleados.DataSource = empleados;
            var conectorServicios = new BindingSource();
            conectorServicios.DataSource = servicios;

            ComboUtils.CargarCombo(ref CmbTEmpleado, conectorEmpleados);
            CmbTEmpleado.SelectedItem = empleadosxDefecto;
            ComboUtils.CargarCombo(ref comboBoxServicios, conectorServicios);
            comboBoxServicios.SelectedItem = serviciosXDefecto;
        }

        private void CargarMascotas()
        {
            var mascotas = mascotaServicio.Obtener(int.Parse(idCliente.Text.Trim()));

            var mascotasxDefecto = new Entidades.Mascota()
            {
                Nombre = "Seleccionar"
            };

            mascotas.Add(mascotasxDefecto);
            var conectorMascotas = new BindingSource();
            conectorMascotas.DataSource = mascotas;

            ComboUtils.CargarComboM(ref CmbIdPerro, conectorMascotas);
            CmbIdPerro.SelectedItem = mascotasxDefecto;
        }

        private bool buscarServicioElegido(Entidades.Servicios servicioElegido)
        {
            foreach (DataGridViewRow servicio in DGVDT.Rows) {
                if (servicioElegido.Nombre == servicio.Cells["nombreServicio"].Value.ToString()) {
                    return true;
                };
            }
            return false;
        }
        //Eventos
        private void BtnTCrearMascota_Click_1(object sender, EventArgs e)
        {
            var frmAltaMascotas = new FrmAltaMascotas(int.Parse(idCliente.Text.Trim()));
            frmAltaMascotas.Show();

        }

        private void BtnTCrearCliente_Click(object sender, EventArgs e)
        {
            var frmAltaCliente = new FrmAltaCliente(int.Parse(idCliente.Text.Trim()));
            frmAltaCliente.Show();
        }

        private void BtnTCrearTurno_Click(object sender, EventArgs e)
        {
            if (idCliente.Text.Length == 0 ||
                CmbIdPerro.SelectedItem == null ||
                CmbTEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Falta completar datos", "Informacion", MessageBoxButtons.OK);
            }
            else
            {
                var turno = new Entidades.Turno();
                turno.FechaDesde = fechaDesde.Text;
                turno.FechaHasta = fechaHasta.Text;
                turno.IdCliente = int.Parse(idCliente.Text.Trim());
                turno.IdMascota = int.Parse(CmbIdPerro.SelectedValue.ToString());
                turno.IdEmpleado = int.Parse(CmbTEmpleado.SelectedValue.ToString());
                turno.Monto = sumarTotal();
                turno.Estado = 3; //se agrega el turno como reservado

                if (turnoServicio.AgregarTurno(turno))
                {
                    foreach (DataGridViewRow fila in DGVDT.Rows) {
                        var dt = new DetalleTurno()
                        {
                            IdServicio = Convert.ToInt64(fila.Cells[4].Value.ToString()),
                            IdTurno = turno.Id,
                            Cantidad = Convert.ToInt32(fila.Cells[1].Value.ToString()),
                            TotalDetalle = Convert.ToInt32(fila.Cells[3].Value.ToString()),

                        };

                        detalleTurnoServicio.AgregarDetalleTurno(dt);
                    }
                    
                    MessageBox.Show("Turno agregado", "Informacion", MessageBoxButtons.OK);
                    this.Dispose();
                  
                    
                }
                else
                {
                    MessageBox.Show("Faltan datos", "Informacion", MessageBoxButtons.OK);
                }

                calendarioServicio.ModificarLugaresOcupados(DateTime.Parse(turno.FechaDesde), DateTime.Parse(turno.FechaHasta), "+");
            }


        }
        private void BtnTVolverMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmATurno_Load(object sender, EventArgs e)
        { 
            CargarCombos();
        }


         private void button1_Click(object sender, EventArgs e)
        {
            //aqui debemos verificar si existe el cliente aparte de cargar el combo de mascotas
            ConsultarClienteTurno();
            CargarMascotas();

        }


        private void btnCrearDT_Click(object sender, EventArgs e)
        {
            var servicioElegido = (Entidades.Servicios)comboBoxServicios.SelectedItem;
            if (servicioElegido.Nombre != "Seleccionar...") {
                if (!buscarServicioElegido(servicioElegido))
                {
                    var fila = new string[]
                            {
                            servicioElegido.Nombre,
                            numericServicios.Value.ToString(),
                            servicioElegido.Precio.ToString(),
                            (servicioElegido.Precio * numericServicios.Value).ToString(),
                            servicioElegido.Id.ToString()
                            };
                    DGVDT.Rows.Add(fila);
                    comboBoxServicios.Text = "Seleccionar...";
                    numericServicios.Value = 1;
                    numericServicios.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El servicio ya fue añadido", "Informacion", MessageBoxButtons.OK);
                }
            }
        }

        private void fechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedItem == null)
            {
                return;
            }
            else
            {
                comidaElegida();
            }
        }

        private void fechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedItem == null)
            {
                return;
            }
            else
            {
                comidaElegida();
            }
        }



        private void comboBoxServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxServicios.SelectedItem == null)
            {
                return;
            }
            else
            {
                comidaElegida();
            }
        }

        private void idCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnQuitarServicio_Click(object sender, EventArgs e)
        {
            if (DGVDT.CurrentCell != null)
            {
                var celdaSel = DGVDT.CurrentCell.RowIndex;
                DGVDT.Rows.RemoveAt(celdaSel);
                //MessageBox.Show("Se borro el servicio de la lista", "Servicio borrado", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("No se selecciono una celda para borrar", "Error", MessageBoxButtons.OK);
            }

        }

        private void CmbTEmpleado_Format(object sender, ListControlConvertEventArgs e)
        {
            string nombre = ((Empleado)e.ListItem).Nombre;
            string apellido = ((Empleado)e.ListItem).Apellido;
            e.Value = nombre + " " + apellido;
        }

        private void CmbIdPerro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbTEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

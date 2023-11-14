using GuarderiaCanina.Entidades;
using GuarderiaCanina.InterfacesUsuario;
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
    public partial class FrmConsultaCliente : Form
    {
        //Inicializacion de variables
        private readonly FrmAltaCliente frmAltaCliente;
        private readonly ClienteServicio clienteServicio;

        //Inicializacion del formulario
        public FrmConsultaCliente()
        {
            frmAltaCliente = new FrmAltaCliente(0);
            clienteServicio = new ClienteServicio();
            InitializeComponent();
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
            FrmContConsulta.Controls.Add(form);
            FrmContConsulta.Visible = true;
            FrmContConsulta.BringToFront();
            form.BringToFront();
            form.Show();


        }
        private bool isNumericDNI() {
            bool isNumeric = int.TryParse(TxtDNIConsulta.Text.Trim(), out _);
            return isNumeric;
        }

        private void EliminarCliente()
        {
            var cliente = new Cliente();
            cliente.DniCliente = int.Parse(DGVConsulta.CurrentRow.Cells[0].Value.ToString());

            if (cliente.DniCliente == 0)
            {
                MessageBox.Show("Ingrese datos", "Informacion", MessageBoxButtons.OK);
                return;
            }

            var cl = clienteServicio.EliminarCliente(cliente);
        }





        //Eventos
        private void BtnECancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }

        private void ConsultarClientes()
        {
            var c = new Cliente();
            //primero me fijo si el txtbox tiene algo escrito
            if (TxtDNIConsulta.Text.Length != 0)
            {
                //luego llamo a la isnumeric para saber si tiene un numero entero escrito
                if (isNumericDNI())
                {
                    c.DniCliente = int.Parse(TxtDNIConsulta.Text.Trim());
                    var clientes = clienteServicio.ObtenerClientes(c);
                    DGVConsulta.Rows.Clear();
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
                        DGVConsulta.Rows.Add(fila);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un numero como parametro", "Informacion", MessageBoxButtons.OK);
                }
            }
            else {
                ConsultarTodosClientes();
            }
                

        }

        private void ConsultarTodosClientes()
        {
            var clientes = clienteServicio.ObtenerTodosClientes();
            DGVConsulta.Rows.Clear();

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
                DGVConsulta.Rows.Add(fila);
            }
        }

        private void FrmClienteConsulta_Load(object sender, EventArgs e)
        {
            ConsultarTodosClientes();
            DGVConsulta.ForeColor = Color.Black;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente();
        }



        private void BtnMod_Click(object sender, EventArgs e)
        {
            var seleccionadas = DGVConsulta.SelectedRows;
            if (seleccionadas.Count > 1)
            {
                MessageBox.Show("Seleccione solo un cliente", "Informacion", MessageBoxButtons.OK);
            }
            else if (seleccionadas.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente", "Informacion", MessageBoxButtons.OK);
            }
            else
            {
                foreach (DataGridViewRow row in seleccionadas)
                {
                    string filaSeleccionada = (string)row.Cells[0].Value;
                    var dniCli = int.Parse(filaSeleccionada);
                    OpenForm(new FrmModificarCliente(dniCli));
                }
            }

        }

        private void btn_CrearCliente_Click(object sender, EventArgs e)
        {
            OpenForm(frmAltaCliente);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }
    }
    }


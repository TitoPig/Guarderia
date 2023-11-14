using System;
using System.Windows.Forms;
using GuarderiaCanina.InterfacesUsuario;
using GuarderiaCanina.InterfacesUsuario.Calendario;
using GuarderiaCanina.InterfacesUsuario.Informes;
using GuarderiaCanina.InterfacesUsuario.Informes.Clientes_por_demora;
using GuarderiaCanina.InterfacesUsuario.Informes.ClientesFrecuentes;
using GuarderiaCanina.InterfacesUsuario.Login;
using GuarderiaCanina.Servicios;


//los formularios creados e invocados son a modo de ejemplo, la idea es tener 1 form por cada boton
//cree 2 para que se visualiazara pero la idea es crealos de 0

namespace GuarderiaCanina
{
    public partial class FrmPrincipal : Form
    {
        private readonly TurnosServicio turnoServicio;
        public FrmPrincipal()
        {
            InitializeComponent();
            CustomizeDesing();
            turnoServicio = new TurnosServicio();
        }

            private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // validar el tipo de usuario
            turnoServicio.CheckTurnosDemorados();


            if (EmpleadoServicio.EmpleadoLogueado.Rol == null) {
                this.Close();
            }
            if (EmpleadoServicio.EmpleadoLogueado.Rol != "administrador") {

                showMessage("Se ingresará en modo Empleado", 1500);
                BtnEmpleados.Visible = false;
                BtnCalendario.Visible = false;
            }
            else
            {
                showMessage("Se ingresará en modo Administrador", 1500);
            }
        }
        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg , "Información", MessageBoxButtons.OK);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }

        //dividi la visualizacion del codigo por regiones
        //esto es para que sea mas claro trabajar, aun asi si existen mas cosas podemos crearlas
        //si en clientes necesitamos 4 botones se crean y listo, lo mismo con las demas

        #region Visualizacion Menus
        //esta region contiene la visualizacion, es decir,cuando se selecciona un form,
        //se cierran las demas opciones de la barra lateral
        private void CustomizeDesing()
        {
            PnlClientes.Visible = false;
            PnlInformes.Visible = false;
            PnlCobro.Visible = false;
            PnlTurnos.Visible = false;
            PnlEmpleados.Visible = false;
            PnlCalendario.Visible = false;
        }
        private void HideSubMenu()
        {
            if (PnlClientes.Visible == true)
            {
                PnlClientes.Visible = false;
            }
            if (PnlInformes.Visible == true)
            {
                PnlInformes.Visible = false;
            }
            if (PnlCobro.Visible == true)
            {
                PnlCobro.Visible = false;
            }
            if (PnlTurnos.Visible == true)
            {
                PnlTurnos.Visible = false;
            }
            if (PnlEmpleados.Visible == true)
            {
                PnlEmpleados.Visible = false;
            }
            if (PnlCalendario.Visible == true)
            {
                PnlCalendario.Visible = false;
            }
        }
        private void ShowSubMenu(Panel Pnlsubmenu)
        {
            if (Pnlsubmenu.Visible == false)
            {
                HideSubMenu();
                Pnlsubmenu.Visible = true;
            }
            else
                Pnlsubmenu.Visible = false;
        }
        #endregion

        #region clientes
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlClientes);
        }
        private void BtnClientesAlt_Click(object sender, EventArgs e)
        {
            //con el boton crear cliente estamos llamando al formulario 2

            //aqui abrimos el formulario crear clientes
            HideSubMenu();
        }
        private void BtnClientesCons_Click(object sender, EventArgs e)
        {
            if (EmpleadoServicio.EmpleadoLogueado != null)
            {
                //con el boton consultar cliente estamos llamando al formulario 3
                OpenForm(new FrmConsultaCliente(), null);
                //aqui abrimos el formulario consultar clientes
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Ingrese sesion", "Informacion",MessageBoxButtons.OK);
            }
        }
        #endregion

        #region Turnos
        private void BtnTurnos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlTurnos);
        }

        private void BtnTurnosReserva_Click(object sender, EventArgs e)
        {
            if (EmpleadoServicio.EmpleadoLogueado != null)
            {
                //aqui abrimos el formulario crear turnos
                OpenForm(new InterfacesUsuario.FrmAltaTurno(), null);
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Ingrese sesion", "Informacion", MessageBoxButtons.OK);
            }
        }

        private void BtnTurnosConsulta_Click(object sender, EventArgs e)
        {
            if (EmpleadoServicio.EmpleadoLogueado != null)
            {
                //aqui abrimos el formulario consultar turnos
                OpenForm(new FrmConsultarTurno(), null);
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Ingrese sesion", "Informacion", MessageBoxButtons.OK);
            }
            
        }
        #endregion

        #region Cobros
        private void BtnCobros_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlCobro);
        }

        private void BtnCobrosConsulta_Click(object sender, EventArgs e)
        {
            if (EmpleadoServicio.EmpleadoLogueado != null)
            {
                //aqui abrimos el formulario consultar facturas
                OpenForm(new FrmConsultaCobro(), null);
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Ingrese sesion", "Informacion", MessageBoxButtons.OK);
            }
            
        }
        #endregion

        #region Estadisticas
        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlInformes);
        }

        private void BtnEstadisticasAlt_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmClientesPorMascota(), null);
            //aqui abrimos el formulario crear estadisticas
            HideSubMenu();
        }

        private void BtnEstadisticasConsulta_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmClientesIncum(), null);
            //aqui abrimos el formulario consultar estadisticas
            HideSubMenu();
        }

        private void BtnInfSemanas_Click(object sender, EventArgs e)
        {
            //aqui abrimos el formulario consultar estadisticas
            HideSubMenu();
        }
        #endregion

        #region Empleados
        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlEmpleados);
        }

        private void BtnGenEmpleados_Click(object sender, EventArgs e)
        {
            if (EmpleadoServicio.EmpleadoLogueado != null)
            {
                OpenForm(new FrmAltaEmpleado(), null);
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Ingrese sesion", "Informacion", MessageBoxButtons.OK);
            }
            
        }

        private void BtnConsEmpleados_Click(object sender, EventArgs e)
        {
            if (EmpleadoServicio.EmpleadoLogueado != null)
            {
                OpenForm(new FrmConsultaEmpleado(), null);
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Ingrese sesion", "Informacion", MessageBoxButtons.OK);
            }
            
        }
        #endregion

        #region Un solo Frm Activo
        //esta parte puede ser un poco mas compleja pero la idea es que no existan mil forms abiertos
        //solo uno que se invoca cuando se necesita y luego se elimina, permitiendo no gastar recursos

        //estamos creando un unico formulario activo que se estara visualizando

        private Form activofrm = null;
        public void OpenForm(Form form, Form antform)
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
            PnlContenedorFrm.Controls.Add(form);
            form.Show();
            form.BringToFront();

            if (antform != null)
            {
                antform.Close();
            }
        }

        #endregion

        #region Calendario

        private void BtnCalendario_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PnlCalendario);

        }

        private void BtnVerCalendario_Click_1(object sender, EventArgs e)
        {
            if (EmpleadoServicio.EmpleadoLogueado != null)
            {
                OpenForm(new FrmCalendario(), null);
                HideSubMenu();
            }
            else
            {
                MessageBox.Show("Ingrese sesion", "Informacion", MessageBoxButtons.OK);
            }
        }

        #endregion


        private void pnlLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }

}

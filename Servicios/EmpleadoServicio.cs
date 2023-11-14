using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class EmpleadoServicio
    {
        private readonly EmpleadoRepositorio empleadoRepositorio;
        public static Empleado EmpleadoAgregado;
        public static Empleado EmpleadoLogueado;

        public EmpleadoServicio()
        {
            empleadoRepositorio = new EmpleadoRepositorio();
        }
        public bool AgregarEmpleado(Empleado empleado)
        {
            var empleadoAgregado = empleadoRepositorio.AgregarEmpleado(empleado);
            if (empleadoAgregado != null)
                return false;
            EmpleadoAgregado = empleadoAgregado;
            return true;
        }
        public List<Empleado> ObtenerEmpleados(Empleado e)
        {
            return empleadoRepositorio.ObtenerEmpleados(e);
        }
        public List<Empleado> ObtenerTodosEmpleados()
        {
            return empleadoRepositorio.ObtenerTodosEmpleados();
        }
        public bool EliminarEmpleado(Empleado empleado)
        {
            var empleadoEliminado = empleadoRepositorio.EliminarEmpleado(empleado);
            if (empleadoEliminado == null)
                return true;
            empleadoEliminado = empleadoEliminado;
            return true;
        }

        public bool Login(Empleado empleado)
        {
            var empleadoLogueado = empleadoRepositorio.LoginBD(empleado);
            if (empleadoLogueado == null)
                return false;
            EmpleadoLogueado = empleadoLogueado;
            return true;
        }
       // public void ValidarEmpleado(Empleado empleado)
       // {
        //    empleado.ValidarNombre();       
        //empleado.ValidarPassword();      
       // }

    }
}

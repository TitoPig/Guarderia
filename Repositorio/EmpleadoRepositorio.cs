using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuarderiaCanina.Repositorio
{
    public class EmpleadoRepositorio
    {

        public Empleado AgregarEmpleado(Empleado empleado)
        {
            var sql = "insert into Empleados(id_empleado, nombre, apellido, telefono, direccion, estado, rol, contraseña)" +
                "values" + " (" + empleado.Id + ", '" + empleado.Nombre + "', '" + empleado.Apellido + "', " + empleado.Telefono + ", '" + empleado.Direccion + "'," +
                " " + 1 + ", '" +empleado.Rol + "', '" +empleado.Contrasenia + "');";
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Empleado empleadoAgregado = null;
            return empleadoAgregado;
        }

        public List<Empleado> ObtenerEmpleados(Empleado e)
        {
            var empleados = new List<Empleado>();
            var sql = $"SELECT e.* from Empleados e where e.id_empleado = {e.Id} and e.estado = 1";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                var empleado = new Empleado();
                empleado.Id = (int)fila["id_empleado"];
                empleado.Nombre = fila["nombre"].ToString();
                empleado.Apellido = fila["apellido"].ToString();
                empleado.Telefono = (int)fila["telefono"];
                empleado.Direccion = fila["direccion"].ToString();
                empleado.Rol = fila["rol"].ToString();

                empleados.Add(empleado);
            }


            return empleados;
        }
        public List<Empleado> ObtenerTodosEmpleados()
        {
            var empleados = new List<Empleado>();
            var sql = $"SELECT * from Empleados where estado=1";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                var empleado = new Empleado();
                empleado.Id = (int)fila["id_empleado"];
                empleado.Nombre = fila["nombre"].ToString();
                empleado.Apellido = fila["apellido"].ToString();
                empleado.Telefono = (int)fila["telefono"];
                empleado.Direccion = fila["direccion"].ToString();
                empleado.Rol = fila["rol"].ToString();

                empleados.Add(empleado);
            }


            return empleados;
        }
        public Empleado EliminarEmpleado(Empleado empleado)
        {                               
                var sql = $"update Empleados set estado = 2 where id_empleado={empleado.Id}";
                var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);

                MessageBox.Show("Empleado Eliminado", "Informacion", MessageBoxButtons.OK);            
            Empleado empleadoEliminado = null;
            return empleadoEliminado;


        }

        public Empleado LoginBD(Empleado empleado)
        {
            var sql = $"Select id_empleado, rol, contraseña from empleados where id_empleado='{empleado.Id}' and contraseña='{empleado.Contrasenia}' and estado=1";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Empleado empleadoLogueado = null;
            if (tablaResultado.Rows.Count == 1)
            {
                empleadoLogueado = new Empleado();
                var fila = tablaResultado.Rows[0];
                empleadoLogueado.Id = Convert.ToInt64(fila["id_empleado"].ToString());
                empleadoLogueado.Contrasenia = fila["contraseña"].ToString();
                empleadoLogueado.Rol = fila["rol"].ToString();               
            }
            return empleadoLogueado;

        }

    }
}

using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Repositorio
{
    internal class TurnosRepositorio
    {
        private Turno Mapear(DataRow fila) {
            var turno = new Turno();
            turno.Id = (int)fila["id_turno"];
            turno.FechaDesde = fila["fecha_desde"].ToString();
            turno.FechaHasta = fila["fecha_hasta"].ToString();
            turno.FechaSalida = fila["fecha_salida"].ToString();
            turno.IdCliente = (int)fila["id_cliente"];
            turno.IdMascota = (int)fila["id_mascota"];
            turno.IdEmpleado = (int)fila["id_empleado"];
            turno.Monto = (int)fila["monto"];
            turno.Estado = (int)fila["estado"];

            return turno;
        }

        public Turno AgregarTU(Turno turno)
        {
            var sql = "insert into Turno(fecha_desde, fecha_hasta, id_cliente, id_mascota, id_empleado, fecha_salida, estado, monto)" +
                "values" + "('" + turno.FechaDesde + "', '" + turno.FechaHasta + "', " + turno.IdCliente + ", " + turno.IdMascota + ", " + turno.IdEmpleado + ",'" + turno.FechaHasta + "', " + turno.Estado + "," + turno.Monto + ");";
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    turno.Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(sql);
                    tx.Commit();
                }
                catch {
                    tx.Rollback();
                    throw new ApplicationException("Hubo un problema al registrar. Intente nuevamente");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
            Turno TurnoAg = null;
            return TurnoAg;
        }
        public List<Turno> ConsultarTurno(Turno t)
        {
            var turnos = new List<Turno>();
            var sql = $"Select * from Turno where id_turno={t.Id} AND (estado = 3 or estado = 4 or estado = 6)";
            DataTable res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in res.Rows)
            {
                var turno = Mapear(fila);
                turnos.Add(turno);
            }
            return turnos;
        }
        public List<Turno> ObtenerTodosTurnos(Turno t)
        {
            var turnos = new List<Turno>();
            var sql = $"select t.* from Turno t where t.estado = 3 OR t.estado = 4 OR t.estado = 6";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                var turno = Mapear(fila);

                turnos.Add(turno);
            }

            return turnos;
        }

        public Turno ObtenerTurnoPorId(long id) {
            var sql = $" select * from Turno where id_turno = {id}";
            
            DataTable res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var turno = Mapear(res.Rows[0]);
            return turno;
        }
        public bool CambiarEstadoRecepcion(long id)
        {
            var sql = $"UPDATE turno SET estado = 4 WHERE id_turno = {id}";
            DataTable res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            if (res != null)
            {
                return true;
            }
            else
                return false;

        }

        public bool CambiarEstadoCancelar(long id)
        {
            var sql = $"UPDATE turno SET estado = 7 WHERE id_turno = {id}";
            DataTable res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            if (res != null)
            {
                return true;
            }
            else
                return false;
        }

        public void CambiarEstadoFinalizado(long id)
        {
            var sql = $"UPDATE turno SET estado = 5 WHERE id_turno = {id}";
            DBHelper.GetDBHelper().ConsultaSQL(sql);
        }

        public void CambiarMontoTurno(long id,int monto)
        {
            var sql = $"UPDATE turno SET monto = {monto} WHERE id_turno = {id}";
            DBHelper.GetDBHelper().ConsultaSQL(sql);
        }


        public void CheckTurnosDemorados()
        {
            var hoy = DateTime.Now;
            hoy.ToString("yyyy-MM-dd");
            var sql = $"UPDATE Turno SET estado = 6, fecha_salida = '{hoy}' where '{hoy}' > fecha_hasta";
            
            DBHelper.GetDBHelper().ConsultaSQL(sql);
        }
    }
}


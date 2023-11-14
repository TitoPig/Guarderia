using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace GuarderiaCanina.Repositorio
{
    public class ReportesRepositorio
    {

        public DataTable ObtenerClientesporMascota(Turno turno)
        {
            //sentencia para obtener aquelos clientes frecuentes (clientes que hayan hecho mas de una reserva entre las fechas marcadas)
            var sql = $"select c.id,c.nombre,c.apellido,c.telefono,c.direccion from Clientes c where(select count(*) as total from turno t where c.id = t.id_cliente AND(t.fecha_desde BETWEEN('" + turno.FechaDesde + "') AND('" + turno.FechaHasta + "')) AND (t.fecha_hasta BETWEEN('" + turno.FechaDesde + "') AND('" + turno.FechaHasta + "')) AND c.estado = 1 AND (t.estado = 3 OR t.estado = 4 OR t.estado = 6  )) > 1";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return tabla;

        }

        public DataTable ObtenerClientesporTurno(Turno turno)
        {
            //sentencia para obtener aquellos clientes demorados (turnos ya finalizados en los cuales su salida prevista es distinta a su salida real)
            var sql = $"select c.id,c.nombre,c.apellido,c.telefono,c.direccion from Clientes c where(select count(*) as total from turno t where c.id = t.id_cliente AND(t.fecha_desde BETWEEN('" + turno.FechaDesde + "') AND('" + turno.FechaHasta + "')) AND (t.fecha_hasta BETWEEN('" + turno.FechaDesde + "') AND('" + turno.FechaHasta + "')) AND c.estado = 1 AND (t.estado = 5 or t.estado = 6) AND t.fecha_hasta != t.fecha_salida) > 1";

            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            return tabla;

        }
    }
}

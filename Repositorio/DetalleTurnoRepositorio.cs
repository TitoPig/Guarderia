using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Repositorio
{
    public class DetalleTurnoRepositorio
    {

        private DetalleTurno Mapear(DataRow fila)
        {
            var dt = new DetalleTurno();
            dt.IdTurno = (int)fila["id_turno"];
            dt.IdServicio = (int)fila["id_servicio"];
            dt.Cantidad = (int)fila["cantidad"];
            dt.TotalDetalle = (int)fila["totaldetalle"];
            return dt;
        }

        public void AgregarDetalleTurno(DetalleTurno dt)
        {
            var detTurno = new DetalleTurno();
            var sql = $"insert into DetalleTurno(id_turno, id_servicio, cantidad, totaldetalle) values ({dt.IdTurno}, {dt.IdServicio}, {dt.Cantidad}, {dt.TotalDetalle})";
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
        }

        public DetalleTurno ConsultarDetalleTurnoPorT(long id)
        {
            var sql = $"select dt.* from DetalleTurno dt where dt.id_turno = {id}";
            DataTable res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var detTurno = Mapear(res.Rows[0]);
            return detTurno;
        }

    }
}

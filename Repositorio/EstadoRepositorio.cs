using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace GuarderiaCanina.Repositorio
{
    public class EstadoRepositorio
    {
        private Estado Mapear(DataRow fila)
        {
            var e = new Estado();
            e.Id = (int)fila["id"];
            e.Nombre = fila["nombre"].ToString();
            e.Descripcion = fila["descripcion"].ToString();
            return e;
        }

        public Estado BuscarEstadoXId(long id) {
            var estado = new Estado();
            var sql = $"select * from Estado where id = {id}";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            estado = Mapear(resultado.Rows[0]);
            return estado;
        }
    }
}

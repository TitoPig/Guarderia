using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Repositorio
{
    public class ServiciosRepositorio
    {
        private Entidades.Servicios Mapear(DataRow fila)
        {
            var servicio = new Entidades.Servicios
            {
                Id = (int)fila["id"],
                Nombre = fila["nombre"].ToString(),
                Descripcion = fila["descripcion"].ToString(),
                Precio = (int)fila["precio"]

            };
            return servicio;
        }

        public List<Entidades.Servicios> ObtenerTodosServicios() {
            var servicios = new List<Entidades.Servicios>();
            var sql = $"SELECT * from Servicios";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                var servicio = new Entidades.Servicios();
                servicio = Mapear(fila);

                servicios.Add(servicio);
            }
            return servicios;
        }
    }
}

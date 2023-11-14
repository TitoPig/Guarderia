using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Repositorio
{
    public class CobroRepositorio
    {
        public List<Cobro> ConsultarCobro(Cobro c)
        {
            var cobros = new List<Cobro>();
            var sql = $"SELECT * From Cobros where id_turno = {c.IdTurno}";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                Cobro cobro = Mapear(fila);
                cobros.Add(cobro);
            }
            return cobros; 
        }
        private Cobro Mapear(DataRow fila) {
            var cobro = new Cobro();
            cobro.Id = (int)fila["id"];
            cobro.IdTurno = (int)fila["id_turno"];
            cobro.FechaCobro = fila["fecha_cobro"].ToString();
            cobro.Monto = (int)fila["monto"];
            return cobro;
        }

        public Cobro AgregarCobro(Cobro cobro)
        {
            var sql = "insert into Cobros(id_turno, fecha_cobro, monto) " +
                "values" + " (" + cobro.IdTurno + ", '" + cobro.FechaCobro + "', " + cobro.Monto + ")";
            Console.WriteLine(sql);
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Cobro cobroAg = null;
            return cobroAg;
        }

        public List<Cobro> ObtenerTodosCobros()
        {
            var cobros = new List<Cobro>();
            var sql = $"SELECT * from Cobros";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                var cobro = new Cobro();
                cobro.Id = (int)fila["id"];
                cobro.IdTurno = (int)fila["id_turno"];
                cobro.FechaCobro = fila["fecha_cobro"].ToString();
                cobro.Monto = (int)fila["monto"];

                cobros.Add(cobro);
            }


            return cobros;
        }

        public Cobro ObtenerCobroPorId(long id)
        {
            var sql = $"select * from Cobros where id_turno = {id}";
            Console.WriteLine(sql);
            DataTable res = DBHelper.GetDBHelper().ConsultaSQL(sql);
            var cobro = Mapear(res.Rows[0]);
            return cobro;
        }
    }
}

using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace GuarderiaCanina.Repositorio
{
    public class CalendarioRepositorio
    {
        public DiaCalendario Mapear(DataRow fila) {
            var diaC = new DiaCalendario()
            {
                fecha = Convert.ToDateTime(fila["fecha"]),
                lugaresDisponibles = Convert.ToInt32(fila["lugaresDisponibles"]),
                lugaresOcupados = Convert.ToInt32(fila["lugaresOcupados"]),
            };
            return diaC;
        }
        public void AgregarDiasCalendario(DateTime fecha)
        {
            
        }

        public void ModificarLugaresOcupados(DateTime fechaDesde,DateTime fechaHasta, string operador) {
            var sql = $"update Calendario set" +
                $" lugaresOcupados = lugaresOcupados {operador} 1 where fecha between CONVERT(date, '{fechaDesde.ToString("yyyy-MM-dd")}', 23) " +
                $"and CONVERT(date, '{fechaHasta.ToString("yyyy-MM-dd")}',23)";
            DBHelper.GetDBHelper().ConsultaSQL(sql);
        }

        internal List<DiaCalendario> ObtenerCalendario()
        {
            var diasCalendario = new List<DiaCalendario>();
            var sql = $"select * from Calendario";
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultados.Rows)
            {
                var diaC = Mapear(fila);
                diasCalendario.Add(diaC);
            }
            return diasCalendario;
        }

    }
}

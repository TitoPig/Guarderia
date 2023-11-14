using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class CalendarioServicio {
        private readonly CalendarioRepositorio calendarioRepositorio;
        private readonly DateTime inicioPeriodo;
        private readonly DateTime finPeriodo;

        public CalendarioServicio() {
            calendarioRepositorio = new CalendarioRepositorio();
            inicioPeriodo = DateTime.Parse("2022-10-01");
            finPeriodo = DateTime.Parse("2023-03-01");
        }

        public List<DiaCalendario> ObtenerCalendario() {
            return calendarioRepositorio.ObtenerCalendario();
        }

        /*public List<DiaCalendario> ObtenerCalendarioIntervalo(DateTime fechaDesde, DateTime fechaHasta) {
            return calendarioRepositorio.ObtenerCalendarioIntervalo(fechaDesde, fechaHasta);
        }*/

        public void ModificarLugaresOcupados(DateTime fechaDesde, DateTime fechaHasta, string operador) {
            calendarioRepositorio.ModificarLugaresOcupados(fechaDesde, fechaHasta, operador);
        }

        /*public List<DiaCalendario> ObtenerCalendarioIntervalo()
        {
            return calendarioRepositorio.ObtenerCalendario();
        }*/
    }
}

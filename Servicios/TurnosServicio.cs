using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class TurnosServicio
    {
        private readonly TurnosRepositorio turnoRepositorio;
        public static Turno TurnoAg;

        public TurnosServicio()
        {
            turnoRepositorio = new TurnosRepositorio();
        }

        public bool AgregarTurno(Turno turno)
        {
            var turnoAg = turnoRepositorio.AgregarTU(turno);
            if (turnoAg == null)
                return true;
            TurnoAg = turnoAg;
            return true;
        }

        public Turno ObtenerTurnoPorId(long id) {
            return turnoRepositorio.ObtenerTurnoPorId(id);
        }

        public List<Turno> ConsultarTurno(Turno t)
        {
            return turnoRepositorio.ConsultarTurno(t);
        }
        public List<Turno> ObtenerTodosTurnos(Turno t)
        {
            return turnoRepositorio.ObtenerTodosTurnos(t);
        }

        public bool CambiarEstadoTurnoCancelar(long id)
        {
            return turnoRepositorio.CambiarEstadoCancelar(id);
        }
        public bool CambiarEstadoTurnoRecepcion(long id)
        {
            return turnoRepositorio.CambiarEstadoRecepcion(id);
        }
        public void CambiarEstadoTurnoFinalizado(long id)
        {
            turnoRepositorio.CambiarEstadoFinalizado(id);
        }

        public void CambiarMontoTurno(long id,int monto)
        {
            turnoRepositorio.CambiarMontoTurno(id,monto);
        }
        public void CheckTurnosDemorados()
        {
            turnoRepositorio.CheckTurnosDemorados();
        }


    }
}



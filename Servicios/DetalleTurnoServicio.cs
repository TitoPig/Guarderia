using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class DetalleTurnoServicio
    {
        private readonly DetalleTurnoRepositorio detalleTurnoRepositorio;

        public DetalleTurnoServicio()
        {
            detalleTurnoRepositorio = new DetalleTurnoRepositorio();
        }

        public void AgregarDetalleTurno(DetalleTurno dt) {
            detalleTurnoRepositorio.AgregarDetalleTurno(dt);
        }

        public DetalleTurno ConsultarDetalleTurnoPorT(long id)
        {
            return detalleTurnoRepositorio.ConsultarDetalleTurnoPorT(id);
        }

    }
}

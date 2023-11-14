using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class ReportesServicio
    {
        private readonly ReportesRepositorio repositorio;

        public ReportesServicio()
        {
            this.repositorio = new ReportesRepositorio();
        }


        //aqui van los metodos que llaman a el repositorio

        public DataTable ClientesPorMascota(Turno t)
        {
            return repositorio.ObtenerClientesporMascota(t);
        }

        public DataTable ClientesPorTurno(Turno t)
        {
            return repositorio.ObtenerClientesporTurno(t);
        }

    }
}

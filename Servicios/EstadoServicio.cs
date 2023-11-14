using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class EstadoServicio
    {
        private readonly EstadoRepositorio estadoRepositorio;

        public EstadoServicio() { 
            estadoRepositorio = new EstadoRepositorio();
        }

        public Estado BuscarEstadoXId(long id) {
            return estadoRepositorio.BuscarEstadoXId(id);
        }
    }
}

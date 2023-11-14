using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class ServiciosServicio
    {
        private readonly ServiciosRepositorio serviciosRepositorio;

        public ServiciosServicio(){
            serviciosRepositorio = new ServiciosRepositorio();
        }

        public List<Entidades.Servicios> ObtenerTodosServicios() {
            return serviciosRepositorio.ObtenerTodosServicios();
        }
    }
}


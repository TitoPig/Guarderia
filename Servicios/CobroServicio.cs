using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class CobroServicio
    {
        private readonly CobroRepositorio cobroRepositorio;
        public static Cobro CobroAg;

        public CobroServicio()
        {
            cobroRepositorio = new CobroRepositorio();  
        }

        public bool AgregarCobro(Cobro cobro)
        {
            var cobroAg = cobroRepositorio.AgregarCobro(cobro);
            if (cobroAg == null)
                return true;
            CobroAg = cobroAg;
            return true;
        }

        public List<Cobro> ConsultarCobro(Cobro c)
        {
            return cobroRepositorio.ConsultarCobro(c);
        }

        public List<Cobro> ObtenerTodosCobros()
        {
            return cobroRepositorio.ObtenerTodosCobros();
        }

        public Cobro ObtenerCobroPorId(long id)
        {
            return cobroRepositorio.ObtenerCobroPorId(id);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Entidades
{
    public class Cobro : EntidadBase
    {
        public long IdTurno { get; set; }
        public string FechaCobro { get; set; }
        public  int Monto {get; set;}

    }
}

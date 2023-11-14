using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Entidades
{
    public class DetalleTurno
    {
        public long IdTurno { get; set; }
        public long IdServicio { get; set; }
        public int Cantidad { get; set; }
        public int TotalDetalle { get; set; }
    }
}

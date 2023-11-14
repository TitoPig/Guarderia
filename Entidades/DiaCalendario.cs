using System;

namespace GuarderiaCanina.Entidades
{
    public class DiaCalendario
    {
        public DateTime fecha { get; set; }
        public int lugaresDisponibles { get; set; }
        public int lugaresOcupados { get; set; }
    }
}

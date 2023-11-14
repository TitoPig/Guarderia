using System;

namespace GuarderiaCanina.Entidades
{
    public class Turno : EntidadBase
    {
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public int IdCliente { get; set; }
        public int IdMascota { get; set; }
        public int IdEmpleado { get; set; }
        public string FechaSalida { get; set; }
        public int Estado { get; set; }
        public int Monto { get; set; }
    }
}

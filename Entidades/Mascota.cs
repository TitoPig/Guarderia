namespace GuarderiaCanina.Entidades
{
    public class Mascota : EntidadBase
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Raza { get; set; }
        public int Peso { get; set; }
        public int DniDuenio { get; set; }
        public int Estado { get; set; }
    }
}

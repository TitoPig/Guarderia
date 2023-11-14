using System;

namespace GuarderiaCanina.Entidades
{
    public class Empleado : Persona
    {
        public long Id { set; get; }

        public string Contrasenia { set; get; }

        public string Rol { set; get; }

    }

    //public void ValidarId()
}

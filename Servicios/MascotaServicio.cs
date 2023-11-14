using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class MascotaServicio
    {
        private readonly MascotasRepositorio mascotasRepositorio;
        public static Mascota MascotaAg;
        public static Mascota MascotaEliminado;
        public static Mascota MascotaModificado;
        public MascotaServicio()
        {
            mascotasRepositorio = new MascotasRepositorio(); 
        }

        public bool AgregarMascota(Mascota mascota)
        {

            var mascotaAg = mascotasRepositorio.AgregarMs(mascota);
            if (mascotaAg == null)
                return true;
            MascotaAg = mascotaAg;
            return true;
        }

        public List<Mascota> GetMascotasNombre(string nom) {
            return mascotasRepositorio.GetMascotasNombre(nom);
        }

        public List<Mascota> GetMascotasDuenio(int dniDuenio) {
            return mascotasRepositorio.GetMascotasDuenio(dniDuenio);
        }

        public List<Mascota> Obtener(int duenio)
        {
            return mascotasRepositorio.Get(duenio);
        }
    }
    
}

using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace GuarderiaCanina.Repositorio
{
    public class MascotasRepositorio
    {
        private Mascota Mapear(DataRow fila)
        {
            var m = new Mascota();
            m.Id = (int)fila["id_mascota"];
            m.Nombre = fila["nombre"].ToString();
            m.Edad = (int)fila["edad"];
            m.Sexo = fila["sexo"].ToString();
            m.Raza = fila["raza"].ToString();
            m.Peso = (int)fila["peso"];
            m.DniDuenio = (int)fila["id_duenio"];
            return m;
        }
    public Mascota AgregarMs(Mascota mascota)
        {
            try
            {
                var sql = "insert into Mascotas(nombre, edad, sexo, raza, peso, id_duenio,estado)" +
                "values" + " ( '" + mascota.Nombre + "', " +
                mascota.Edad + ", '" + mascota.Sexo + "', '" + mascota.Raza + "'," +
                mascota.Peso + "," + mascota.DniDuenio + ", " + 1 + " )";
                var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
                return mascota;
            }
            catch (Exception ex)
            {
                Mascota mascotaAg = null;
                return mascotaAg;
            }
        }

        public List<Mascota> GetMascotasNombre(string nom) {
            var mas = new List<Mascota>();
            var sql = $"SELECT * FROM Mascotas WHERE nombre='{nom}'";
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultados.Rows)
            {
                var m = Mapear(fila);
                mas.Add(m);
            }
            return mas;
        }

        public List<Mascota> GetMascotasDuenio(int dniDuenio) { 
            var mas = new List<Mascota>();
            var sql = $"SELECT * FROM Mascotas WHERE id_duenio={dniDuenio}";
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultados.Rows) {
                var m = Mapear(fila);
                mas.Add(m);
            }
            return mas;
        }
        public List<Mascota> Get(int duenio)
        {
            var items = new List<Mascota>();
            var sql = $"SELECT m.id_mascota, m.nombre from mascotas m WHERE id_duenio={duenio}";
            Console.WriteLine(sql);
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in tabla.Rows){
                var objeto = new Mascota();
                objeto.Id = (int)Convert.ToInt64(fila["id_mascota"].ToString());
                objeto.Nombre = fila["nombre"].ToString();
                items.Add(objeto);
            }
            return items;
        }
    }
}

    

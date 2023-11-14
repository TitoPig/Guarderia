using GuarderiaCanina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace GuarderiaCanina.Repositorio
{
    public class ClientesRepositorio
    {
        public Cliente AgregarCl(Cliente cliente)
        {
            var sql = "insert into Clientes(id, nombre, apellido, telefono, direccion, estado)" +
                "values" + " (" + cliente.DniCliente + ", '" + cliente.Nombre + "', '" + cliente.Apellido + "', " + cliente.Telefono + ", '" + cliente.Direccion + "', " + 1 +" )";
            Console.WriteLine(sql);
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Cliente clienteAg = null;
            return clienteAg;
        }

        public List<Cliente> ObtenerClientes(Cliente c)
        {
            var clientes = new List<Cliente>();
            var sql = $"SELECT c.* from Clientes c where c.id={c.DniCliente} and c.estado = 1";           
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                var cliente = new Cliente();
                cliente.DniCliente = (int)fila["id"];
                cliente.Nombre = fila["nombre"].ToString();
                cliente.Telefono = (int)fila["telefono"];
                cliente.Apellido = fila["apellido"].ToString();
                cliente.Direccion = fila["direccion"].ToString();
                clientes.Add(cliente);
            }

            return clientes;

        }

        //Cambiar las los mapeos hechos en los datarows por este metodo, asi reutilizamos y modularizamos
        //codigo
        private Cliente Mapear(DataRow fila) {
            var cli = new Cliente
            {
                DniCliente = (int)fila["id"],
                Nombre = fila["nombre"].ToString(),
                Apellido = fila["Apellido"].ToString(),
                Telefono = (int)fila["Telefono"],
                Direccion = fila["direccion"].ToString()
            };
            return cli;
        }

        public Cliente GetCliente(int dni)
        {
            var cliente = new Cliente();
            var sql = $"SELECT c.* from Clientes c where c.id={dni} AND c.Estado = 1";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                cliente = Mapear(fila);
            }
            return cliente;
        }

        public List<Cliente> ObtenerTodosClientes()
        {
            var clientes = new List<Cliente>();
            var sql = $"SELECT c.* from Clientes c WHERE c.Estado = 1";
            DataTable resultado = DBHelper.GetDBHelper().ConsultaSQL(sql);
            foreach (DataRow fila in resultado.Rows)
            {
                var cliente = new Cliente
                {
                    DniCliente = (int)fila["id"],
                    Nombre = fila["nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    Telefono = (int)fila["Telefono"],
                    Direccion = fila["direccion"].ToString()
                };

                clientes.Add(cliente);
            }


            return clientes;
        }

        public Cliente EliminarCliente(Cliente cliente)
        {
            var comprobacion = $"select c.estado from Clientes c where c.estado = 1";
            var resComprobacion = DBHelper.GetDBHelper().ConsultaSQL(comprobacion);
            if (comprobacion != cliente.DniCliente.ToString())
            {
                var sql = $"update Clientes SET estado = 2 where id = {cliente.DniCliente}";
                var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
                MessageBox.Show("Usuario Eliminado", "Informacion", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("El usuario no existe", "Informacion", MessageBoxButtons.OK);
            }
            Cliente clienteEliminado = null;
            return clienteEliminado;

        }

        public Cliente ModificarCliente(Cliente cliente)
        {
            var sql = $"update Clientes SET nombre = '{cliente.Nombre}', apellido = '{cliente.Apellido}', telefono = {cliente.Telefono}, direccion = '{cliente.Direccion}' where id = {cliente.DniCliente}";
            var resultados = DBHelper.GetDBHelper().ConsultaSQL(sql);
            Cliente clienteMod = null;
            return clienteMod;

        }
        
    }
}

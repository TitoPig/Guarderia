using GuarderiaCanina.Entidades;
using GuarderiaCanina.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuarderiaCanina.Servicios
{
    public class ClienteServicio
    {
        private readonly ClientesRepositorio clientesRepositorio;
        public static Cliente ClienteAg;
        public static Cliente ClienteEliminado;
        public static Cliente ClienteModificado;

        public ClienteServicio()
        {
            clientesRepositorio = new ClientesRepositorio();
        }

        public bool AgregarCliente(Cliente cliente)
        {
            var clienteAg = clientesRepositorio.AgregarCl(cliente);
            if (clienteAg == null)
                return true;
            ClienteAg = clienteAg;
            return true;
        }

        public List<Cliente> ObtenerClientes(Cliente c)
        {
            return clientesRepositorio.ObtenerClientes(c);
        }
        public List<Cliente> ObtenerTodosClientes()
        {
            return clientesRepositorio.ObtenerTodosClientes();
        }
        public bool EliminarCliente(Cliente cliente)
        {
            var clienteEliminado = clientesRepositorio.EliminarCliente(cliente);
            if (clienteEliminado == null)
                return true;
            ClienteEliminado = clienteEliminado;
            return true;

        }
        public bool ModificarCliente(Cliente cliente)
        {
            var clienteMod = clientesRepositorio.ModificarCliente(cliente);
            if (clienteMod == null)
                return true;
            ClienteModificado = clienteMod;
            return true;
        }

        public Cliente GetCliente(int dni) {
            return clientesRepositorio.GetCliente(dni);
        }
    }
}

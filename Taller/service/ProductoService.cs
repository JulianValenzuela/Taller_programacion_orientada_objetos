using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.service
{
    internal class ProductoService
    {
        public void IngresarDatos(List<Cliente> clientes, Cliente cliente)
        {
            Console.WriteLine("------------------------CREAR UN PRODUCTO--------------------------------");
            Console.WriteLine("Ingrese : ");
            cliente.Cedula = Console.ReadLine();
            //cliente.SetNombre(Console.ReadLine());

            Cliente resultado = clientes.Find(dato => dato.Cedula == cliente.Cedula);
            if (resultado != null)
            {
                Console.WriteLine("ERROR Cedula duplicada");
                return;
            }

            Console.WriteLine("Ingrese su nombre: ");
            cliente.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su dirección: ");
            cliente.Direccion = Console.ReadLine();

            Console.WriteLine("Ingrese su número de telefono: ");
            cliente.Telefono = Console.ReadLine();

            clientes.Add(cliente);

        }
        public void BuscarDatos(List<Cliente> clientes)
        {
            Console.WriteLine("------------------------BUSCAR UN CLIENTE--------------------------------");
            Console.WriteLine("Ingrese el número de identificación del cliente que desea buscar: ");
            string cedula = Console.ReadLine();

            Cliente cliente = clientes.Find(cliente => cliente.Cedula == cedula);
            if (cliente == null)
            {
                Console.WriteLine("El usuario no esta registrado en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
            }
            else
            {
                Console.WriteLine(cliente.Cedula + " " + cliente.Nombre + " " + cliente.Direccion + " " + cliente.Telefono);
            }

        }

        public void ModificarDatos(List<Cliente> clientes)
        {
            Console.WriteLine("------------------------MODIFICAR UN CLIENTE--------------------------------");
            Console.WriteLine("Ingrese el número de identificación que desea editar: ");
            string cedula = Console.ReadLine();
            Cliente cliente = clientes.Find(cliente => cliente.Cedula == cedula);
            if (cliente == null)
            {
                Console.WriteLine("El usuario no esta registrado en el sistema");
            }
            else
            {
                clientes.Remove(cliente);
                IngresarDatos(clientes, new Cliente());
                Console.WriteLine(cliente.Cedula + " " + cliente.Nombre + " " + cliente.Direccion + " " + cliente.Telefono);
            }
        }

        public void ListarDatos(List<Cliente> clientes)
        {
            Console.WriteLine("------------------------LISTAR LOS CLIENTES--------------------------------");
            Console.WriteLine("           Cedula           Nombre           Dirección           Telefono           ");

            clientes.ForEach(cliente =>
            {
                if (cliente.Activo)
                    Console.WriteLine("           " + cliente.Cedula + "           " + cliente.Nombre + "           "
                   + cliente.Direccion + "           " + cliente.Telefono + "           ");
            });

        }

        public void ActivarDesactivar(List<Cliente> clientes)
        {
            Console.WriteLine("------------------------ACTIVAR O DESACTIVAR UN CLIENTE--------------------------------");
            Console.WriteLine("Ingrese su numero de identificación: ");
            string cedula = Console.ReadLine();
            Cliente cliente = clientes.Find(cliente => cliente.Cedula == cedula);
            if (cliente == null)
            {
                Console.WriteLine("El usuario no esta registrado en el sistema");
            }
            else
            {
                cliente.Activo = !cliente.Activo;
                Console.WriteLine(cliente.Cedula + " " + cliente.Nombre + " " + cliente.Direccion + " " + cliente.Telefono);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller.Service
{
    internal class ClienteService
    {

        public void IngresarDatos(List<Cliente> clientes, Cliente cliente)
        {
            Console.WriteLine("------------------------CREAR UN CLIENTE--------------------------------");
            Console.WriteLine("Ingrese su cedula: ");
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
        public void BuscarDatos(List<Cliente> clientes, Cliente cliente)
        {

            
            Console.WriteLine("------------------------BUSCAR UN CLIENTE--------------------------------");
            Console.WriteLine("Ingrese el número de identificación del cliente que desea buscar: ");

            Encontrar(clientes);

            Datos(cliente);


        }

        public void ModificarDatos(List<Cliente> clientes, Cliente cliente)
        {
            Console.WriteLine("------------------------MODIFICAR UN CLIENTE--------------------------------");
            Console.WriteLine("Ingrese el número de identificación que desea editar: ");

            Encontrar(clientes);

            clientes.Remove(cliente);
            IngresarDatos(clientes, new Cliente());
            Datos(cliente);

        }

        public void ListarDatos(List<Cliente> clientes)
        {
            Console.WriteLine("------------------------LISTAR LOS CLIENTES--------------------------------");
            Console.WriteLine("           Cedula           Nombre           Dirección           Telefono           ");

            clientes.ForEach(cliente =>
            {
                if (cliente.Activo)
                    Datos(cliente);
                   
            });


        }

        public void ActivarDesactivar(List<Cliente> clientes, Cliente cliente)
        {
            Console.WriteLine("------------------------ACTIVAR O DESACTIVAR UN CLIENTE--------------------------------");
            Console.WriteLine("Ingrese su numero de identificación: ");

            Encontrar(clientes);

            cliente.Activo = !cliente.Activo;
            Datos(cliente);


        }

        public void Encontrar(List<Cliente> clientes)
        {
            string cedula = Console.ReadLine();

            Cliente cliente = clientes.Find(cliente => cliente.Cedula == cedula);
            if (cliente == null)
            {
                Console.WriteLine("El usuario no esta registrado en el sistema");
                Console.WriteLine("Vuelva a intentarlo");
                return;
            }
        }

        public void Datos(Cliente cliente)
        {
            Console.WriteLine("           " + cliente.Cedula + "           " + cliente.Nombre + "           "
                  + cliente.Direccion + "           " + cliente.Telefono + "           ");
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller.Service;

namespace Taller.Vista
{
    internal class VistaCliente
    {
       public void MenuCliente() {

            ClienteService clienteService = new ClienteService();

            List<Cliente> clientes = new();

            while (true)
            {

                Console.WriteLine("--------------------Menu de opciones------------------------");
                Console.WriteLine("1.Crear un cliente");
                Console.WriteLine("2.Buscar un cliente");
                Console.WriteLine("3.Editar un cliente");
                Console.WriteLine("4.Listar un cliente");
                Console.WriteLine("5.Activar o desactivar un cliente");
                Console.WriteLine("6.Salir del sistema");
                Console.WriteLine("-----------------------------------------------");


                Console.WriteLine("Ingrese una opcion: ");
                string opcion = Console.ReadLine();

                Cliente cliente = new();
                switch (opcion)
                {
                    case "1":

                        clienteService.IngresarDatos(clientes, cliente);
                        break;
                    case "2":
                        clienteService.BuscarDatos(clientes, cliente);
                        break;
                    case "3":
                        clienteService.ModificarDatos(clientes, cliente);
                        break;
                    case "4":
                        clienteService.ListarDatos(clientes);
                        break;
                    case "5":
                        clienteService.ActivarDesactivar(clientes, cliente);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error esta opcion no existe");
                        break;


                }
            }


        }
    }
}

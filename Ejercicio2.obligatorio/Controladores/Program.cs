using Ejercicio2.obligatorio.Dtos;
using Ejercicio2.obligatorio.Servicios;

namespace Ejercicio2.obligatorio.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();

            MenuInterfaz alpha = new MenuImplementacion();
            OperativaInterfaz omega = new OperativaImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            while (!cerrarMenu)
            {
                opcionSeleccionada = alpha.menuYSeleccion();

                    switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("Menu cerrado");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Agregar cliente");
                        omega.anadirNuevoCliente(listaClientes);
                        break; 
                    case 2:
                        Console.WriteLine("Clientes ordenados por edad");
                        omega.ordenarPorEdad(listaClientes);
                        foreach(ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opcion");
                        break;
                            
                }
            }

        }
    }
}
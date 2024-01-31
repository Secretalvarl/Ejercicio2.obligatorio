using Ejercicio2.obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.obligatorio.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void anadirNuevoCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto nuevoCliente = crearNuevoCliente();

            listaAntigua.Add(nuevoCliente);
        }

        private ClienteDto crearNuevoCliente()
        {
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Escriba el id");
            nuevoCliente.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba su nombre");
            nuevoCliente.Nombre1 = Console.ReadLine();

            Console.WriteLine("Escriba sus apellidos");
            nuevoCliente.Apellidos1 = Console.ReadLine();

            Console.WriteLine("Escriba la edad");
            nuevoCliente.Edad1 = Convert.ToInt32(Console.ReadLine());

            return nuevoCliente;
        }

        public void ordenarPorEdad(List<ClienteDto> listaAntigua)
        {
            for (int i = 0; i < listaAntigua.Count; i++)
            {
                for (int j = 0; j < listaAntigua.Count - 1 - i; j++)
                {
                    if (listaAntigua[j + 1].Edad1 > listaAntigua[j].Edad1)
                    {
                        ClienteDto aux = listaAntigua[j];
                        listaAntigua[j] = listaAntigua[j + 1];
                        listaAntigua[j + 1] = aux;
                    }

                }
            }
        }
    }
}

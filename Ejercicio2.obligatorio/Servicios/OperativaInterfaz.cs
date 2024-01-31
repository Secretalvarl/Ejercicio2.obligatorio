using Ejercicio2.obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.obligatorio.Servicios
{
    internal interface OperativaInterfaz
    {
        public void anadirNuevoCliente(List<ClienteDto> listaAntigua);

        public void ordenarPorEdad(List<ClienteDto> listaAntigua);
    }
}

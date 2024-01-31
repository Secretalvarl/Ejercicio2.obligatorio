using Ejercicio2.obligatorio.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.obligatorio.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuYSeleccion()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("|0. Cerrar menu                  |");
            Console.WriteLine("|1. Añadir nuevo cliente         |");
            Console.WriteLine("|2.  Ordenar por edad los clientes|");
            Console.WriteLine("----------------------------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}

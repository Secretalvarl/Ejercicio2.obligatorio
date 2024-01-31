using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.obligatorio.Dtos
{
    internal class ClienteDto
    {
        long id;

        string Nombre;

        string Apellidos;

        int Edad;

        public long Id { get => id; set => id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Apellidos1 { get => Apellidos; set => Apellidos = value; }
        public int Edad1 { get => Edad; set => Edad = value; }

        public ClienteDto(long id, string Nombre, string Apellidos, int Edad) 
        { 
            this.id = id;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Edad = Edad;
        }

        public ClienteDto() 
        {

        }

        public string ToString() 
        {
            string[] apellidos = Apellidos.Split(' ');

            string Apellido1 = apellidos[0];
            string Apellido2 = apellidos[1];

            string nombreCompleto = Apellido1 + Apellido2 + "," + Nombre;

            string pantalla = Id + "\n" + nombreCompleto + "\n" + Edad;

            return pantalla;

        }
    }
}

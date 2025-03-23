using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__POO
{
    class Contacto
    {
        private string nombre;
        private string telefono;
        private string direccion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        //Constructor
        public Contacto(string nombre, string telefono, string direccion)
        {
            Nombre = nombre;
            Telefono = telefono;
            Direccion = direccion;
        }

        public void MostrarContacto()
        {
            Console.WriteLine($"nombre:{nombre}, telefono: {telefono}, direccion: {direccion}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace C__POO
{
    class Agenda  //Clase que gestiona la lista de contactos
    {
        //Creo lista "contactos" de tipo Contacto.
        public List<Contacto> contactos = new List<Contacto>();

        //Agrego contacto a la lista "contactos"
        public void AgregarContacto(string nombre, string telefono, string direccion)
        {
            contactos.Add(new Contacto(nombre, telefono, direccion));
            Console.WriteLine("Contacto agregado correctamente.");
        }

        //Recorro lista "contactos" 
        public void MostrarContactos()
        {
            Console.WriteLine("Lista de contactos");
            if (contactos.Count == 0)
            {
                Console.WriteLine("Agenda vacia. No hay contactos");
            }
            else 
            {
                Console.WriteLine("Lista de contactos");
                foreach (var contacto in contactos)
                {
                    contacto.MostrarContacto();
                }
            }

        }
    }
}

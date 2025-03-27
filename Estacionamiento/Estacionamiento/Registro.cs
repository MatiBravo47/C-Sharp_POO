using System;
using System.Collections.Generic;

namespace Estacionamiento
{
    internal class Registro
    {
        List<Auto> autos = new List<Auto>();
        public void agregarAuto()
        {
            Console.Write("Ingrese patente: ");
            string patente = Console.ReadLine().ToUpper();
            foreach (Auto auto in autos)
            {
                if (auto.Patente == patente)
                {
                    Console.WriteLine("Ya existe un auto con esa patente");
                    Console.ReadLine();
                    return;
                }
            }

            Console.Write("Ingrese marca: ");
            string marca = Console.ReadLine();

            Auto nuevoAuto = new Auto(patente, marca);
            autos.Add(nuevoAuto);
        }

        public void mostrarAutos() 
        {
            if (autos.Count == 0)
            {
                Console.WriteLine("No hay autos registrados");
            }
            else 
            {
                Console.WriteLine("Lista de Autos Registrados:");
                Console.WriteLine("───────────────────────────────────");
                Console.WriteLine("| Nº  |   Patente   |   Marca     |");
                Console.WriteLine("───────────────────────────────────");
                int contador = 0;
                foreach (Auto auto in autos)
                {

                    contador++;
                    Console.WriteLine($"|Auto {contador} | {auto.Patente} | {auto.Marca}  |");
                    Console.WriteLine("───────────────────────────────────");
                }
            }
        }

        public void eliminarAutoPorPatente()
        {
            Console.WriteLine("Escriba patente de auto que desea eliminar");
            string patenteIngresada = Console.ReadLine().ToUpper();
            foreach (Auto auto in autos)
            {
                if (auto.Patente == patenteIngresada)
                {
                    autos.Remove(auto);
                    Console.WriteLine("Auto eliminado");
                    return;
                }
            }
        }

        public void eliminarAutoPorNumero()
        {
            Console.WriteLine("Ingrese el numero del auto que desea eliminar");
            if (int.TryParse(Console.ReadLine(), out int numeroAuto))
            {
                if (numeroAuto > 0 && numeroAuto <= autos.Count)
                {
                    autos.RemoveAt(numeroAuto - 1);
                    Console.WriteLine("Auto eliminado");
                }
                else
                {
                    Console.WriteLine("Número de auto inválido");
                }
            }
            else
            {
                Console.WriteLine("Número de auto inválido");
            }
        }
    }
}

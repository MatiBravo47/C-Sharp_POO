using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * semana es como un "administrador" que posee herramientas(métodos y propiedades) para gestionar
             * las temperaturas registradas, mientras que ListaTemperatura es simplemente el lugar donde se guardan esas temperaturas.
            */
           TemperaturasSemana semana = new TemperaturasSemana();
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Ingrese temperatura dia {i + 1}:");
                double temp = Double.Parse(Console.ReadLine());
                semana.agregarTemperatura(temp);
            }
            Console.WriteLine($"\nTemperatura más alta: {semana.ObtenerTemperaturaMaxima()}°C");
            Console.WriteLine($"\nTemperatura más baja: {semana.ObtenerTemperaturaMinima()}°C");
            Console.WriteLine($"\nTemperatura promedio: {semana.ObtenerTemperaturaPromedio()}°C");
            Console.ReadLine();
        }
    }
}

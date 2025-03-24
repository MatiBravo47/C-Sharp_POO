using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Administra una lista de objetos .
namespace RegistroTemperaturas
{

    class TemperaturasSemana
    {
        public List<Temperatura> ListaTemperatura = new List<Temperatura>();

        public void agregarTemperatura(double temperatura)
        {
            ListaTemperatura.Add(new Temperatura(temperatura));
        }

        public double ObtenerTemperaturaMaxima() 
        {
            double max = ListaTemperatura[0].Valor;

            foreach (var temp in ListaTemperatura)
            {
                if (temp.Valor > max)
                {
                    max = temp.Valor;
                }
            }
            return max;
        }

        public double ObtenerTemperaturaMinima()
        {
            double min = ListaTemperatura[0].Valor;
            foreach (var temp in ListaTemperatura)
            {
                if (temp.Valor < min)
                {
                    min = temp.Valor;
                }
            }
            return min;
        }

        public double ObtenerTemperaturaPromedio()
        {
            double total = 0;
            foreach (var temp in ListaTemperatura)
            {
                total += temp.Valor;
            }
            return total/7;
        }
      
    }
}

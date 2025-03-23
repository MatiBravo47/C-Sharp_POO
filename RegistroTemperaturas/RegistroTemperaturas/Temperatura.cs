using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Representa un objeto que contiene un valor de temperatura.
namespace RegistroTemperaturas
{
    class Temperatura
    {
        public double Valor { get; set; }

        //Constructor
        public Temperatura(double temperatura) 
        {
            Valor = temperatura;
        }
    }
}

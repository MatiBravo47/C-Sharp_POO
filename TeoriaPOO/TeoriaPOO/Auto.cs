using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaPOO
{
    internal class Auto
    {
        //Atributos 
        public string color;
        public int velocidad;
        
        //Metodos
        public void acelerar()
        {
            this.velocidad += 10;
        }
    }
}

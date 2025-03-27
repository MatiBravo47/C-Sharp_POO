using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaPOO
{
    internal class Animal
    {
        //Al ser public, puede ser accesido por su hijo.
        //private: No puede ser accedido por su hijo
        //protected: Solo puede ser accedido por su hijo

        public void comer() 
        {
            Console.WriteLine("Estoy comiendo");
        }
    }

    internal class Perro : Animal
    {
        public void ladrar()
        {
            Console.WriteLine("Guau guau");
        }
    }
}

//No se puede heredar de clases distintas, solo de una clase a la vez.
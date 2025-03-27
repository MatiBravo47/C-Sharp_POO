using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaPOO
{
    //Clase abstracta: No puede ser instanciada, se usa de modelo para que la usen las clases hijas
    public abstract class AbsAnimal 
    {
        public string nombre { get; set; }

        public void respirar()
        {
            Console.WriteLine("Estoy respirando");
        }

        //Metodo abstracto: No tiene cuerpo, se implementa en las clases hijas
        public abstract void hacerSonido(); //Debe implementarse(ser llamado) en el codigo si o si. 

        //Metodo virtual: Debe tener codigo, pero puede ser sobreescrito(override) en las clases hijas 
        public virtual void hacerSonido2()
        {
            Console.WriteLine("Hago un sonido");
        }
    }

    public class Perro2 : AbsAnimal
    {
        public override void hacerSonido()
        {
            Console.WriteLine("Guau guau");
        }
    }


}

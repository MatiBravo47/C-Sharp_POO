using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Revista : MaterialBibliografico
    {
        private int volumen { get; set; }

        public Revista(string titulo, string autor, int año, int volumen) :base(titulo, autor, año) 
        {
            this.volumen = volumen;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.Write($", Volumen: {volumen}");
            Console.WriteLine();
        }
    }
}

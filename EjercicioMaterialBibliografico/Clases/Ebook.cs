using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Ebook : MaterialBibliografico
    {
        public Ebook(string titulo, string autor, int año, int pesoMB) : base(titulo, autor, año)
        {
            this.pesoMB = pesoMB;
        }


        private int pesoMB { get; set; }


        public override void mostrarInformacion()
        {
            Console.WriteLine($"PesoMB: {pesoMB}");
        }
    }
}

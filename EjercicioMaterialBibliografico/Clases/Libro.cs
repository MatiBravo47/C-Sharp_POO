using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Libro : MaterialBibliografico
    {
        private int paginas { get; set; }

        public Libro(string titulo, string autor, int año, int paginas) : base(titulo, autor, año)
        {
            paginas = this.paginas;
        }

        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine($"Paginas: {paginas}");
        }
    }
}

using System;

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
            base.mostrarInformacion();
            Console.Write($", Peso: {pesoMB}");
            Console.WriteLine();
        }
    }
}

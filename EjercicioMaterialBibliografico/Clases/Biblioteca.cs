using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class MaterialBibliografico
    {
        protected string titulo { get; set; }
        protected string autor { get; set; }
        protected int año { get; set; }
        private List<Ebook> ebooks = new List<Ebook>();
        private List<Libro> libros = new List<Libro>();

        public MaterialBibliografico(string titulo, string autor, int año)
        {
            titulo = this.titulo;
            autor = this.autor;
            año = this.año;
        }

        public MaterialBibliografico()
        {
        }

        public virtual void mostrarInformacion()
        {
            Console.WriteLine($"Titulo:{titulo}, autor:{autor}, año: {año}");
        }

        public void agregarLibro()
        {
            Console.WriteLine("Ingrese titulo de libro");
            string nombreLibro = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del autor");
            string nombreAutor = Console.ReadLine();
            Console.WriteLine("Ingrese el año del libro");
            int añoLibro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad de paginas");
            int cantidadPaginas = int.Parse(Console.ReadLine());
            Libro libro = new Libro(nombreLibro, nombreAutor, añoLibro, cantidadPaginas);
            libros.Add(libro);
        }

        public void mostrarLibros()
        {
            foreach (var libro in libros)
            {
                libro.mostrarInformacion();
            }
        }


    }
}

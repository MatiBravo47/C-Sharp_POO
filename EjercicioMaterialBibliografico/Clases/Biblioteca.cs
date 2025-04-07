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
            this.titulo = titulo;
            this.autor = autor;
            this.año = año;
        }

        public MaterialBibliografico()
        {
        }

        public virtual void mostrarInformacion()
        {
            Console.Write($"Titulo: {titulo}, Autor: {autor}, Año: {año}");
        }

        public void agregarLibro()
        {
            Console.Write("Ingrese titulo de libro: ");
            string nombreLibro = Console.ReadLine();
            Console.Write("Ingrese nombre del autor: ");
            string nombreAutor = Console.ReadLine();
            Console.Write("Ingrese el año del libro: ");
            int añoLibro = int.Parse(Console.ReadLine());
            Console.Write("Ingrese cantidad de paginas: ");
            int cantidadPaginas = int.Parse(Console.ReadLine());
            Libro libro = new Libro(nombreLibro, nombreAutor, añoLibro, cantidadPaginas);
            libros.Add(libro);
        }

        public void agregarEbook()
        {
            Console.Write("Ingrese titulo de ebook: ");
            string nombreEbook = Console.ReadLine();
            Console.Write("Ingrese nombre del autor: ");
            string autorEbook = Console.ReadLine();
            Console.Write("Ingrese el año del ebook: ");
            int añoEbook = int.Parse(Console.ReadLine());
            Console.Write("Ingrese peso ebook: ");
            int pesoMBEbook = int.Parse(Console.ReadLine());
            Ebook ebook = new Ebook(nombreEbook, autorEbook, añoEbook, pesoMBEbook);
            ebooks.Add(ebook);
        }

        public void eliminarLibro()
        {
            Console.WriteLine("Ingrese el indice del libro que desea eliminar");
            int indice = int.Parse(Console.ReadLine()) - 1;
            if ((indice >= 0 ) && (indice <= libros.Count))
            {
                libros.Remove(libros[indice]);
            } 
        }

        public void eliminarEbook() 
        {
            Console.WriteLine("Ingrese el indice del ebook que desea eliminar");
            int indice = int.Parse(Console.ReadLine()) - 1;
            if ((indice >= 0) && (indice <= ebooks.Count))
            {
                ebooks.Remove(ebooks[indice]);
            }
        }

        public void mostrarLibros()
        {
            int indice = 1;
            foreach (var libro in libros)
            {
                Console.Write($"Libro {indice} - ");
                libro.mostrarInformacion();
                indice++;
            }
        }

        public void mostrarEbooks()
        {
            int indice = 1;
            foreach (var ebook in ebooks)
            {
                Console.Write($"ebook {indice} - ");
                ebook.mostrarInformacion();
                indice++;
            }
        }
    }
}

using System;

namespace TeoriaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 principios de la POO

            //1. Encapsulamiento: Elegir como se comparte y modifica los atributos.

            //Public: Accesible desde cualquier parte del programa.
            //Private: Solo accesible desde la misma clase.
            //Protected: Solo accesible desde la misma clase y sus clases hijas.
            
            {
                Encapsulamiento obj = new Encapsulamiento();

                //Metodos publicos accesibles desde cualquier parte del programa
                obj.SetNombre("Matias");
                Console.WriteLine("Nombre: " + obj.GetNombre());

                // 📌 Accediendo a Internal desde el mismo ensamblado
                Console.WriteLine("Mensaje interno: " + obj.MensajeInterno);

                // ❌ ERROR: No podemos acceder directamente a "nombre" porque es privado
                // Console.WriteLine(obj.nombre); // ❌ Esto no compila

                ClaseHija objHija = new ClaseHija();
                objHija.MostrarMensajeProtegido(); // ✅ Llamando el método que imprime los mensajes protegidos


                //Herencia
                Perro perrito = new Perro();
                perrito.comer();
                perrito.ladrar();
            }

        }
    }
}

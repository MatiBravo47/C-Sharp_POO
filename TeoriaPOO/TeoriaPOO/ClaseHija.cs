using System;

namespace TeoriaPOO
{
    // 🔵 Clase hija que hereda de Encapsulamiento para demostrar "protected"
    internal class ClaseHija : Encapsulamiento
    {
        public void MostrarMensajeProtegido()
        {
            // ✅ Podemos acceder porque MensajeProtegido es "protected"
            Console.WriteLine(MensajeProtegido);

            // ✅ Podemos acceder porque MensajeProtegidoInterno es "protected internal"
            Console.WriteLine(MensajeProtegidoInterno);
        }
    }
}

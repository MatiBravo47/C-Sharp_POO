namespace TeoriaPOO
{
    internal class Encapsulamiento
    {
        // 🔴 1. PRIVATE: Solo accesible dentro de esta clase
        private string nombre;

        // 🔵 Métodos públicos para acceder a "nombre"

        //Formas de escribir getter y setter en C#
        
        //1. Forma tradicional
        //Esta es la forma más antigua y es similar a cómo se haría en Java.
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        //🔴 Desventaja: No sigue la convención de C# y el código es más largo.
        //🟢 Cuándo usarlo: Si necesitas compatibilidad con código heredado o si quieres una estructura similar a Java.

        //2. Propiedades con get y set estándar
        //Esta es la forma más común en C#.

        /*
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        */

        //✔ Ventaja: Sigue la convención de C#, código más limpio.
        //❌ Desventaja: Puede ser un poco más largo que una auto-propiedad.

        //3. Auto-properties ({ get; set; })
        //Esta es la forma más moderna y recomendada si no necesitas lógica adicional.

        //public string Nombre { get; set; } // ✅ Auto-property

        //✔ Ventaja: Código más corto y limpio.
        //❌ Desventaja: No permite validaciones o lógica adicional.

        //4. Propiedades con lógica en set o get
        /*
        public int Edad
        {
            get { return _edad; }
            set
            {
                if (value > 0) // ✅ Validación en el setter
                    _edad = value;
            }
        }
        */

        // 🟠 2. PROTECTED: Solo accesible en esta clase y sus subclases
        protected string MensajeProtegido = "Soy un atributo protegido";

        // 🟡 3. INTERNAL: Accesible solo dentro del mismo ensamblado (proyecto)
        internal string MensajeInterno = "Soy un atributo interno";

        // 🟢 4. PROTECTED INTERNAL: Accesible en el mismo ensamblado o en clases derivadas de otros ensamblados
        protected internal string MensajeProtegidoInterno = "Soy un atributo protegido interno";
    }
}

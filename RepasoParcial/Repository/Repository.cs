using System.Collections.Generic;
using System;
using System.Text.Json;
using System.IO;

namespace Repository
{
    public static class Repository<T> where T : class, new()
    {
        private static readonly JsonSerializerOptions options = new
        JsonSerializerOptions
        { WriteIndented = true };
        public static void Agregar(string archivo, T entidad)
        {
            var datos = Cargar(archivo);
            datos.Add(entidad);
            Guardar(archivo, datos);
        }
        public static List<T> ObtenerTodos(string archivo) =>
        Cargar(archivo);
        public static void Eliminar(string archivo, Predicate<T>
        predicado)
        {
            var datos = Cargar(archivo);
            datos.RemoveAll(predicado);
            Guardar(archivo, datos);
        }
        public static void Actualizar(string archivo, Predicate<T>
        predicado, T nuevaEntidad)
        {
            var datos = Cargar(archivo);
            int index = datos.FindIndex(predicado);
            if (index != -1)
            {
                datos[index] = nuevaEntidad;
                Guardar(archivo, datos);
            }
        }
        private static void Guardar(string archivo, List<T> datos)
        {
            File.WriteAllText($"Repository/Data/{archivo}.json",

            JsonSerializer.Serialize(datos, options));
        }
        private static List<T> Cargar(string archivo)
        {
            string path = $"Repository/Data/{archivo}.json";
            if (!File.Exists(path)) return new List<T>();
            return

            JsonSerializer.Deserialize<List<T>>(File.ReadAllText(path), options)
            ?? new List<T>();
        }
    }
}

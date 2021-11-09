using System;
using System.IO;
using System.Text.Json;
using Biblioteca;
namespace PracticaSerializacionJSon
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "personaje.json");

            //Personaje personaje = DeserializarJson<Personaje>(rutaArchivo);
            //Console.WriteLine(personaje.ToString());
            Mago personaje = new Mago(120, "Mago Electrico", 1200);
            SerializarJson(rutaArchivo, personaje);
        }

        private static void SerializarJson<T>(string ruta, T objeto)
        {
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;

            string personajeJSON = JsonSerializer.Serialize(objeto, jsonSerializerOptions);
            File.WriteAllText(ruta, personajeJSON);
        }

        private static T DeserializarJson<T>(string ruta)
        {
            string objetoJson = File.ReadAllText(ruta);

            T objeto = JsonSerializer.Deserialize<T>(objetoJson);
            return objeto;
        }
    }
}

using System;
using System.IO;
using System.Xml.Serialization;
using Biblioteca;
namespace Practica_Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje = new Mago(100, "Batman",590);

            string rutaDirectorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string ruta = Path.Combine(rutaDirectorio, "Personaje.xml");
            
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Personaje));
                xmlSerializer.Serialize(streamWriter, personaje);
            }


        }
    }

}

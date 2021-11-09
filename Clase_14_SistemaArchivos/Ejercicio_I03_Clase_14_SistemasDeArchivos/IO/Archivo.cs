using System;
using System.IO;

namespace IO
{
    public abstract class Archivo
    {

        public abstract string Extension { get; }
        
        public bool ValidarExtension(string ruta)
        {
            if(!String.IsNullOrWhiteSpace(ruta) && Path.GetExtension(ruta) == Extension)
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoExcepcion($"El archivo no tiene la extension {Extension}");

            }
        }

        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if(File.Exists(ruta))
            {
                return true;
            }
            else
            {
                throw new ArchivoIncorrectoExcepcion("El archivo no se encontro");

            }
        }


    }
}

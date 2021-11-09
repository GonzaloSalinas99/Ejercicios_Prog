using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IO
{
    public class PuntoXml<T> : Archivo
    where T : class
    {
        public override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta)&&ValidarSiExisteElArchivo(ruta))
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, contenido);

                }
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta))
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, contenido);

                }
            }
        }

        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta)&&ValidarSiExisteElArchivo(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {

                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    T contenido = xmlSerializer.Deserialize(streamReader) as T;
                    return contenido;

                }
            }
            return null;
        }
    }
}

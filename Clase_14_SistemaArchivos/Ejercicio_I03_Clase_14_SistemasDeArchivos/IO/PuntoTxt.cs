using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace IO
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        public override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                if (ValidarSiExisteElArchivo(ruta))
                {
                    using (StreamWriter streamWriter1 = new StreamWriter(ruta))
                    {
                        
                    }
                }
            }
        }

        public void GuardarComo(string ruta, string contenido)
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                string contenido = streamReader.ReadToEnd();
                return contenido;
            }

        }
    }
}

using System;
using System.IO;
​
namespace Clase_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //VerificarSistemaOperativo();
            //ObtenerInformacionOS();
            //ObtenerInformacionMediosAlmacenamiento();
​
            // --
​
            //TrabajarConDirectorios();
            //TrabajarConRutasAbsolutasYRelativas();
            //TrabajarConNombresDeRutas();
​
            // --
            try
            {
                //EscribirArchivoTextoConStreamWriterYFinally();
                //LeerArchivoTextoConStreamReaderYFinally();
                //EscribirArchivoTextoConStreamWriterYUsing();
                //LeerArchivoTextoConStreamReaderYUsing();
                //EscribirArchivoTextoConFile();
                LeerArchivoTextoConFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
​
        static void EscribirArchivoTextoConStreamWriterYFinally()
        {
            StreamWriter streamWriter = null;
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos");
​
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
​
                ruta = Path.Combine(ruta, "HolaMundo.txt");
​
                streamWriter = new StreamWriter(ruta, true);
                streamWriter.WriteLine("¡Esto es 2do D!");
            }
            finally
            {
                if (streamWriter is not null)
                {
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
        }
​
        static void LeerArchivoTextoConStreamReaderYFinally()
        {
            StreamReader streamReader = null;
​
            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "Archivos", "HolaMundo.txt");
​
                streamReader = new StreamReader(ruta);
​
                while (!streamReader.EndOfStream)
                {
                    string lineaTexto = streamReader.ReadLine();
                    Console.WriteLine(lineaTexto);
                }
            }
            finally
            {
                if (streamReader is not null)
                {
                    streamReader.Close();
                    streamReader.Dispose();
                }
            }
        }
​
        static void EscribirArchivoTextoConStreamWriterYUsing()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundo.txt");
​
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.WriteLine("¡HolaMundo!");
                streamWriter.WriteLine("¡Esto es 2do D!");
                streamWriter.WriteLine("Aprendemos a trabajar con archivos.");
            }
        }
​
        static void LeerArchivoTextoConStreamReaderYUsing()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundo.txt");
​
            using StreamReader streamReader = new StreamReader(ruta);
            Console.WriteLine(streamReader.ReadToEnd());
        }
​
        static void EscribirArchivoTextoConFile()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundo.txt");
​
            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
​
            File.WriteAllText(ruta, "HOLA MUNDO EN C#");
            File.AppendAllText(ruta, "Comisión: 2doD");
​
            string rutaCopia = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundoCopia.txt");
            File.Copy(ruta, rutaCopia);
​
            File.WriteAllText(rutaCopia, "PISÉ EL HOLA MUNDO");
            string rutaAlt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundoRenombrado.txt");
            File.Move(rutaCopia, rutaAlt);
        }
​
        static void LeerArchivoTextoConFile()
        {
            string rutaCopia = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundoCopia.txt");
​
            if (File.Exists(rutaCopia))
            {
                string textoLeido = File.ReadAllText(rutaCopia);
                Console.WriteLine(textoLeido);
            }
​
            string rutaAlt = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundo.txt");
​
            if (File.Exists(rutaAlt))
            {
                string textoLeido = File.ReadAllText(rutaAlt);
                Console.WriteLine(textoLeido);
            }
        }
​
        static void TrabajarConNombresDeRutas()
        {
            //string ruta = Path.Join(@"C:\\",@"Repositories\");
            //Console.WriteLine(ruta);
​
            //bool terminaConSeparadorDirectorios = Path.EndsInDirectorySeparator(ruta);
​
            //Console.WriteLine($"¿Termina con separador de dirs? {terminaConSeparadorDirectorios}");
​
            //ruta = Path.Join(@"C:\\", @"Repositories");
            //Console.WriteLine(ruta);
            //terminaConSeparadorDirectorios = Path.EndsInDirectorySeparator(ruta);
            //Console.WriteLine($"¿Termina con separador de dirs? {terminaConSeparadorDirectorios}");
​
            //ruta = ".";
            //string[] archivos = Directory.GetFiles(ruta);
            //foreach (string archivo in archivos)
            //{
            //    Console.WriteLine(archivo);
            //}
​
            string ruta = Path.Combine(".", "Clase_Archivos.exe");
​
            string extension = Path.GetExtension(ruta);
            string nombreArchivoConExt = Path.GetFileName(ruta);
            string nombreArchivoSinExt = Path.GetFileNameWithoutExtension(ruta);
            bool tieneExtension = Path.HasExtension(ruta);
            string nombreRandom = Path.GetRandomFileName();
​
            Console.WriteLine(ruta);
            Console.WriteLine($"Extension: {extension}");
            Console.WriteLine($"Nombre archivo con ext: {nombreArchivoConExt}");
            Console.WriteLine($"Nombre archivo SIN ext: {nombreArchivoSinExt}");
            Console.WriteLine($"¿Tiene extensión?: {tieneExtension}");
            Console.WriteLine($"Nombre aleatorio: {nombreRandom}");
        }
​
        static void TrabajarConRutasAbsolutasYRelativas()
        {
            string rutaAbsoluta = Path.GetFullPath(".");
            Console.WriteLine($"Ruta absoluta: {rutaAbsoluta}");
​
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaRelativa = Path.GetRelativePath(rutaEscritorio, ".");
            Console.WriteLine($"Ruta relativa escritorio a app: {rutaRelativa}");
​
            string rutaRelativa2 = Path.GetRelativePath(".", rutaEscritorio);
            Console.WriteLine($"Ruta relativa app a escritorio: {rutaRelativa2}");
​
            string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaRelativa3 = Path.GetRelativePath(rutaEscritorio, rutaMisDocumentos);
            Console.WriteLine($"Ruta relativa escritorio a app: {rutaRelativa3}");
        }
​
        static void TrabajarConDirectorios()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine($"Ruta escritorio: {rutaEscritorio}");
​
            string rutaNuevoDirectorio = Path.Combine(rutaEscritorio, "Prueba");
            Console.WriteLine($"Ruta nuevo directorio: {rutaNuevoDirectorio}");
​
            VerificarSiExisteDirectorio(rutaNuevoDirectorio);
​
            Console.WriteLine($"Creo un directorio...");
            Directory.CreateDirectory(rutaNuevoDirectorio);
​
            VerificarSiExisteDirectorio(rutaNuevoDirectorio);
​
            string rutaRenombrada = Path.Combine(rutaEscritorio, "PruebaRenombrada");
            Console.WriteLine($"Ruta renombrada: {rutaRenombrada}");
​
            VerificarSiExisteDirectorio(rutaRenombrada);
​
            Console.WriteLine($"Muevo/renombro...");
            Directory.Move(rutaNuevoDirectorio, rutaRenombrada);
​
            VerificarSiExisteDirectorio(rutaRenombrada);
            VerificarSiExisteDirectorio(rutaNuevoDirectorio);
        }
​
        static void VerificarSiExisteDirectorio(string ruta)
        {
            bool existeDirectorio = Directory.Exists(ruta);
            Console.WriteLine($"¿Existe directorio?: {existeDirectorio}");
        }
​
        static void VerificarSistemaOperativo()
        {
            Console.WriteLine("¿Es Windows?: {0}", OperatingSystem.IsWindows());
            Console.WriteLine("¿Es Linux?: {0}", OperatingSystem.IsLinux());
            Console.WriteLine("¿Es MacOS?: {0}", OperatingSystem.IsMacOS());
            Console.WriteLine("¿Es IOS?: {0}", OperatingSystem.IsIOS());
            Console.WriteLine("¿Es Android?: {0}", OperatingSystem.IsAndroid());
        }
​
        static void ObtenerInformacionOS()
        {
            Console.WriteLine("Sistema Operativo: {0}", Environment.OSVersion);
            Console.WriteLine("Plataforma: {0}", Environment.OSVersion.Platform);
            Console.WriteLine("Version: {0}", Environment.OSVersion.Version);
            Console.WriteLine("Cantidad procesadores lógicos: {0}",
                Environment.ProcessorCount);
            Console.WriteLine("¿Arq 64 bits?: {0}",
                Environment.Is64BitProcess);
            Console.WriteLine("Usuario OS: {0}",
                Environment.UserName);
            Console.WriteLine($"Texto {Environment.NewLine} salto de línea");
        }
​
        static void ObtenerInformacionMediosAlmacenamiento()
        {
            DriveInfo[] volumenes = DriveInfo.GetDrives();
​
            foreach (DriveInfo unidad in volumenes)
            {
                Console.WriteLine($"{unidad.Name}");
                Console.WriteLine($"{unidad.DriveType}");
                Console.WriteLine($"{unidad.DriveFormat}");
                Console.WriteLine($"{unidad.TotalSize}");
                Console.WriteLine($"{unidad.AvailableFreeSpace}");
                Console.WriteLine($"----------------------------{Environment.NewLine}");
            }
        }
    }
}
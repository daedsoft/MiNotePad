using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNotePad.CLASES
{
    public static class MiNotePadAcciones
    {
        public static string Titulo { get; set; }
        public static string Estado { get; set; }
        public static string RutaRecibida { get; set; }
        public static string ArchivoOriginal { get; set; }
        public static string ArchivoLeido { get; set; }

        public static string GetTitulo() 
        {
            return Titulo;
        }

        public static string GetArchivoLeido()
        {
            return ArchivoLeido;
        }

        public static string GetEstado()
        {
            return Estado;
        }

        public static void SetEstado(string NuevoEstado)
        {
            Estado = NuevoEstado;
        }

        public static string GetArchivoOriginal()
        {
            return ArchivoOriginal;
        }

        public static void SetArchivoOriginal(string Ruta)
        {
            ArchivoOriginal = File.ReadAllText(Ruta);
            Titulo = $"Mi NotePad {Ruta}";
        }

        public static string GetRutaRecibida()
        {
            return RutaRecibida;
        }

        public static void SetRutaRecibida(string Ruta)
        {
            RutaRecibida = Ruta;
        }


        public static void Abrir()
        {
            try
            {
                string Ruta = string.Empty;
                
                OpenFileDialog ofdAbrir = new OpenFileDialog();

                if (ofdAbrir.ShowDialog() == DialogResult.OK)
                {
                    Ruta = ofdAbrir.InitialDirectory + ofdAbrir.FileName;
                    ArchivoLeido = File.ReadAllText(Ruta);
                    RutaRecibida = Ruta;                    
                    Titulo = $"Mi NotePad {Ruta}";
                    Estado = "Sin cambios.";
                    ArchivoOriginal = File.ReadAllText(ArchivoLeido);                                       
                }
                
            }
            catch {  }
        }


        public static void Guardar(string RutaRecibida, string ContenidoTextBox)
        {
            try
            {
                if (File.Exists(RutaRecibida))
                {
                    using (StreamWriter MiArchivo = File.CreateText(RutaRecibida))
                    {
                        MiArchivo.Write(ContenidoTextBox);
                        MiArchivo.Close();
                        Estado = "Guardado.";
                    }
                }
                else
                {
                    SaveFileDialog sfdGuardar = new SaveFileDialog();
                    sfdGuardar.DefaultExt = "txt";
                    sfdGuardar.Filter = "Archivos de Texto (*.txt)|*.txt|All files (*.*)|*.*";

                    if (sfdGuardar.ShowDialog() == DialogResult.OK)
                    {
                        string MiNuevoArchivo = sfdGuardar.FileName;
                        using (StreamWriter MiArchivo = File.CreateText(MiNuevoArchivo))
                        {
                            MiArchivo.Write(ContenidoTextBox);
                            MiArchivo.Close();
                            Estado = "Guardado.";
                            Titulo = $"Mi NotePad {MiNuevoArchivo}";
                            RutaRecibida = sfdGuardar.InitialDirectory + sfdGuardar.FileName; ;
                        }
                    }
                }
            }
            catch
            {
                Estado = "Error";
                Titulo = "Error";
            }
        }

        public static void Nuevo()
        {
            string RutaApp = Application.StartupPath;
            Process.Start(RutaApp + "\\MiNotePad.exe");
        }

        public static int Buscar(string texto, int inicio, RichTextBox TextBox)
        {
            int returnValue = -1;

            if (texto.Length > 0 && inicio >= 0)
            {
                int indexToText = TextBox.Find(texto, inicio, RichTextBoxFinds.None);

                if (indexToText >= 0)
                {
                    returnValue = indexToText;
                }
            }

            return returnValue;
        }        
    }
}


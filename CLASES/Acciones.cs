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
    public static class Acciones
    {
        public static void Abrir()
        {
            try
            {
                string Ruta = string.Empty;
                
                OpenFileDialog ofdAbrir = new OpenFileDialog();

                if (ofdAbrir.ShowDialog() == DialogResult.OK)
                {
                    Ruta = ofdAbrir.InitialDirectory + ofdAbrir.FileName;
                    Propiedades.ArchivoLeido = File.ReadAllText(Ruta);
                    Propiedades.RutaRecibida = Ruta;
                    Propiedades.Titulo = $"Mi NotePad {Ruta}";
                    Propiedades.Estado = "Sin cambios.";
                    Propiedades.ArchivoOriginal = File.ReadAllText(Propiedades.ArchivoLeido);                                       
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
                        Propiedades.Estado = "Guardado.";
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
                            Propiedades.Estado = "Guardado.";
                            Propiedades.Titulo = $"Mi NotePad {MiNuevoArchivo}";
                            Propiedades.RutaRecibida = sfdGuardar.InitialDirectory + sfdGuardar.FileName; ;
                        }
                    }
                }
            }
            catch
            {
                Propiedades.Estado = "Error";
                Propiedades.Titulo = "Error";
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


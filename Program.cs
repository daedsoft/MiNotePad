using MiNotePad.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNotePad
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]

        static void Main(string[] args)
        {            
            if (args.Length > 0){
                CLASES.MiNotePadAcciones.SetRutaRecibida(args[0]);
                CLASES.MiNotePadAcciones.SetEstado("Sin cambios.");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEDITOR());
        }
    }
}


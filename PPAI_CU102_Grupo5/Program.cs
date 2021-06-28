using PPAI_CU102_Grupo5.Controladores;
using PPAI_CU102_Grupo5.Pantallas;
using PPAI_CU102_Grupo5.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_CU102_Grupo5
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
           

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RepositorioSesion repositorioSesion = new RepositorioSesion();
            GestorRegistrarVenta gestorRegistrarVenta = new GestorRegistrarVenta(new Impresora(),new PantallaEntrada(),new PantallaSala());
            Application.Run(new PantallaRegistrarVenta(gestorRegistrarVenta,repositorioSesion));
        }
    }
}

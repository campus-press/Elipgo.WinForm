using Examen.Elipgo.Presentation.Forms.Splash;
using System;
using System.Windows.Forms;

namespace Examen.Elipgo.Presentation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplashScreen());
        }
    }
}

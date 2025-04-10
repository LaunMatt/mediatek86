using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86
{
    /// <summary>
    /// Application MediaTek86
    /// </summary>
    internal class NamespaceDoc
    {

    }
    /// <summary>
    /// Classe servant de point d'entrée principal de l'application.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new view.FrmConnexion());
        }
    }
}

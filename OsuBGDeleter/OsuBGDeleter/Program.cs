using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsuBGDeleter
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /// Version: 2.0.0
            /// By: Vinetta
            /// https://github.com/naquino14/osubgdeleter

            /// Argument format: (might not add this...)
            /// osubgdeleter.exe 0: -type 1: png|jpg|both 2: -igmapskins 3: t|f|true|false|y|n|yes|no 4: "folder"

            /*if (args == null)
             {
                 Application.SetHighDpiMode(HighDpiMode.SystemAware);
                 Application.EnableVisualStyles();
                 Application.SetCompatibleTextRenderingDefault(false);
                 Application.Run(new OsuBgDeleterMain());
             } else
             {
                 // cli
             }*/

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OsuBgDeleterMain());
        }
    }
}

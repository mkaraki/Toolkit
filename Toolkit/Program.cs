using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toolkit
{
    static class Program
    {
        static string ApplicationDir;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationDir = System.IO.Directory.GetParent(Application.ExecutablePath).FullName;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Launcher());
        }

        public static string GetExternalFilePath(string FileName)
        {
            return System.IO.Path.Combine(ApplicationDir, "Files", FileName);
        }
    }
}

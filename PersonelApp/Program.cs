using System;
using System.IO;
using System.Windows.Forms;

namespace PersonelApp
{
    internal static class Program
    {
        public static string FilePath = Path.Combine(Environment.CurrentDirectory, "persons.txt");
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}

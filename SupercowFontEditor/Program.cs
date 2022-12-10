using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SupercowFontEditor
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(ExceptionHandler);
            if (Process.GetProcesses().Count(p => p.ProcessName ==
                Process.GetCurrentProcess().ProcessName) > 1)
                return;
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }

        private static void ExceptionHandler(object s, ThreadExceptionEventArgs t)
        {
            MessageBox.Show($"{t.Exception.Message}\n{t.Exception.StackTrace}", t.Exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

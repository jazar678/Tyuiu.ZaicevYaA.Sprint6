using System;
using System.Windows.Forms;

namespace Tyuiu.ZaicevYaA.Sprint6.Task7.V28
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
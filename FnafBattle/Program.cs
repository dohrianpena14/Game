using System;
using System.Windows.Forms;
using FnafBattle.Forms;

namespace FnafBattle
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new StartForm());
        }
    }
}
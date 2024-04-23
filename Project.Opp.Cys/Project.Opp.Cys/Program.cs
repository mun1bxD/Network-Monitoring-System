using System;
using System.Windows.Forms;
namespace Project.Opp.Cys { 
internal static class Program
{
    [STAThread]
    static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            Application.Run(new Form1());
        }
    }
}


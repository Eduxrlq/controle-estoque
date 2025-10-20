using System;
using System.Windows.Forms;
using ControleEstoque.Views;

namespace ControleEstoque
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}

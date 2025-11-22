
using GerenciamentoProduto.Telas;
using System;
using System.Windows.Forms;

namespace GerenciamentoProduto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCadastro());
        }
    }
}

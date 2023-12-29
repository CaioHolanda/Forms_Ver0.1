using Alura.Filmes.App.Forms;
using System;
using System.Windows.Forms;
namespace Forms_Ver01.App
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Inicial());
        }
    }
}
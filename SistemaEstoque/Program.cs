using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEstoque
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frm = new FrmLogin();
            if (frm.ShowDialog()== DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }
           
        }
    }
}

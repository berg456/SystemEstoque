using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = @"DESKTOP-OJPN3JR";
        public static String banco = "ControleDeEstoque";
        public static String usuario = "sa";
        public static String senha = "123456";
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=" + servidor + ";Initial Catalog=" + banco + ";User ID=" + usuario + ";Password=" + senha;
            }
        }
        /*public static String StringDeConexao
        {
            get { return "Data Source=DESKTOP-OJPN3JR;Initial Catalog=ControleDeEstoque;Integrated Security=True;Encrypt=False"; }

        }*/

    }
}

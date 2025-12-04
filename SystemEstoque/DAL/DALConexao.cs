using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DALConexao
    {
        private String _stringConexao;
        private SqlConnection _conexao;

        public DALConexao(String dadosConexao)
        {
            _conexao = new SqlConnection();
            _stringConexao = dadosConexao;
            _conexao.ConnectionString = dadosConexao;
        }

        public String StringConexao
        {
            get { return _stringConexao; }
            set { _stringConexao = value; }
        }
        public SqlConnection ObjetoConexao
        {
            get { return _conexao; }
            set { _conexao = value; }
        }
        public void Conectar()
        {
            _conexao.Open();
        }
        public void Desconectar()
        {
            _conexao.Close();
        }
    }
}

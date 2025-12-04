using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
namespace ConexFirebird
{
    public class Conexao
    {
        public string strConexao = @"DataSource=localhost; Database=C:\Projeto_Pdv\Install\PROJETO_PDV.FDB; username= SYSDBA; password = masterkey";
        public FbConnection con;
        //A propriedade “strConexao” será responsável por informar algumas propriedades, tais como:
        //- DataSource: O servidor onde o banco de dados está localizado.
        //- Database: Local onde o Banco de Dados “EMPLOYEE.FDB” está localizado.
        //- Username: Usuário padrão do Firebird.
        //- Password: Senha padrão do Firebird.
        //Já a propriedade “con” criará um objeto “FbConnection” o qual fará a instância do mesmo utilizando os dados de conexão informado na propriedade “strConexao”.

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ConexFirebird
{
    public partial class Form1 : Form
    {
        public string strConexao = @"DataSource=localhost; Database=C:\Projeto_Pdv\Banco de Dados\PROJETO_PDV.FDB; username= SYSDBA; password = masterkey";
        public FbConnection con;
        //A propriedade “strConexao” será responsável por informar algumas propriedades, tais como:
        //- DataSource: O servidor onde o banco de dados está localizado.
        //- Database: Local onde o Banco de Dados “EMPLOYEE.FDB” está localizado.
        //- Username: Usuário padrão do Firebird.
        //- Password: Senha padrão do Firebird.
        //Já a propriedade “con” criará um objeto “FbConnection” o qual fará a instância do mesmo utilizando os dados de conexão informado na propriedade “strConexao”.

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void btnConectar_Click(object sender, EventArgs e)
        //{
        //    con = new FbConnection(strConexao);
        //    FbCommand comando = new FbCommand("SELECT * FROM TAB_CLIENTES", con);
        //    FbDataAdapter data = new FbDataAdapter(comando);
        //    DataSet dataset = new DataSet();
        //    con.Open();
        //    data.Fill(dataset, "TAB_CLIENTES");
        //    dataGridViewEmployee.DataSource = dataset;
        //    dataGridViewEmployee.DataMember = "TAB_CLIENTES";
        //    con.Close();
        //}
    }
}
    


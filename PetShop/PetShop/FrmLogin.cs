using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PetShop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static string usuario;
        public static string codUsuario;

        //Estabelecendo conexão com o banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-OJPN3JR;Initial Catalog=PetShop;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos vazios", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where ds_Login = ('" + txtUsuario.Text + "') and ds_Senha = ('" + txtSenha.Text + "')";
                    cm.Connection = cn;
                    SqlDataAdapter da = new SqlDataAdapter(cm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        usuario = dt.Rows[0]["nm_atendente"].ToString();
                        codUsuario = dt.Rows[0]["cd_atendente"].ToString();
                        FrmPrincipal menu = new FrmPrincipal();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("usuario ou senha invalido", "Erro !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtUsuario.Focus();
                    }
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // SqlDataReader dt;
    }
}

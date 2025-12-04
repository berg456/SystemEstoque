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

namespace Livraria
{
    public partial class UCFuncionarios : UserControl
    {
        public UCFuncionarios()
        {
            InitializeComponent();
        }
        //Estabelecendo conexão com o banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-V2TTUHA\SQLEXPRESS;Initial Catalog=db_livraria;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        private void desabilitaCampo()
        {
            txtNome.Enabled = false;
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            //btnNovo.Enabled = false;
        }
        private void habilitaCampo()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            btnCancelar.Enabled = true;
            // btnAlterar.Enabled = true;
            btnSalvar.Enabled = true;
            // btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            txtNome.Focus();
        }
        private void limparCampo()
        {
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            lblCod.Text = string.Empty;
            txtNome.Focus();
        }
        private void manipularDados()
        {
            label1.Visible = true;
            lblCod.Visible = true;
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void UCFuncionarios_Load(object sender, EventArgs e)
        {
            desabilitaCampo();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampo();
            desabilitaCampo();
            btnNovo.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show(" Informe o seu Usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show(" Informe a sua Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show(" O campo Senha deve conter 8 digítos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }
            else if (rdbInativo.Checked)
            {
                MessageBox.Show(" Impossível cadastrar alguém com o status Inativo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string usuario = txtUsuario.Text;
                    string senha = txtSenha.Text;

                    string strsql = "insert into tbl_atendente(ds_login,ds_senha,nm_atendente,ds_status)values(@login,@senha,@atendente,1)";
                    cm.CommandText = strsql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = usuario;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show(" Dados Salvos com Sucesso!!", "Inserção de Dados Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                    limparCampo();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                { cn.Close(); }

            }
        }



        private void txtSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void txtSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void lblSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void lblSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_atendente where nm_atendente like ('" + txtBusca.Text + "%')";
                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    da.Fill(dt);//preenchendo o datatable
                    dgvfunc.DataSource = dt;
                    cn.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                dgvfunc.DataSource = null;
            }

        }
        private void carregaAtendente()
        {
            lblCod.Text = dgvfunc.SelectedRows[0].Cells[0].Value.ToString();
            txtUsuario.Text = dgvfunc.SelectedRows[0].Cells[1].Value.ToString();
            txtSenha.Text = dgvfunc.SelectedRows[0].Cells[2].Value.ToString();
            txtNome.Text = dgvfunc.SelectedRows[0].Cells[3].Value.ToString();
            string valor = dgvfunc.SelectedRows[0].Cells[4].Value.ToString();

            if (valor == "True")
            {
                rbAtivo.Checked = true;
            }
            else
            {
                rdbInativo.Checked = true;
            }
            manipularDados();
        }

        private void dgvfunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaAtendente();
            if (rbAtivo.Checked)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show(" Informe o seu Usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show(" Informe a sua Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show(" O campo Senha deve conter 8 digítos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }

            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string usuario = txtUsuario.Text;
                    string senha = txtSenha.Text;
                    int cd = Convert.ToInt32(lblCod.Text);

                    string strsql = "update tbl_atendente set ds_Login=@login,ds_Senha=@senha,nm_Atendente=@atendente where cd_Atendente=@cd";
                    cm.CommandText = strsql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = usuario;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@atendente", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show(" Dados Alterados com Sucesso!!", "Alteração de Dados Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                    limparCampo();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally
                { cn.Close(); }

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show(" Informe o seu Usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show(" Informe a sua Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show(" O campo Senha deve conter 8 digítos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }
            else if (rbAtivo.Checked)
            {
                MessageBox.Show(" Para remover o registro você precisa alterar o status para INATIVO.", "Erro ao tentar excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult exclusao = MessageBox.Show("Tem Certaza que deseja remover o registro?", "exclusão de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (exclusao == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        int cd = Convert.ToInt32(lblCod.Text);
                        cn.Open();
                        string strSql = "update tbl_atendente set ds_status = 0 where cd_atendente = @cd";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show(" Dados Excluidos com Sucesso!!", "Alteração de Dados Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenha.Focus();
                        limparCampo();
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show(erro.Message);
                        cn.Close();
                    }
                    finally
                    { cn.Close(); }
                }

            }


        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Livraria
{
    public partial class UCCliente : UserControl
    {
        string cpfAntigo;
        public UCCliente()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        //Estabelecendo conexão com o banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-V2TTUHA\SQLEXPRESS;Initial Catalog=db_livraria;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();

        private void desabilitaCampos()
        {
            label1.Visible = false;
            lbl_Cod.Visible = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefone.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            txtCnpj.Visible = false;
            txtCpf.Enabled = false;
            txtComplemeto.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            cbxPessoa.Enabled = false;
            cbxUf.Enabled = false;
            lblCnpj.Visible = false;
        }

        private void habilitaCampos()
        {
            label1.Visible = false;
            lbl_Cod.Visible = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtCidade.Enabled = true;
            txtCnpj.Visible = false;
            txtCpf.Enabled = true;
            txtComplemeto.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            cbxPessoa.Enabled = true;
            cbxUf.Enabled = true;
            lblCnpj.Visible = false;

            btnNovo.Enabled = false;
            txtNome.Focus();
            txtBusca.Text = "";
            dgvcli.DataSource = null;
        }

        private void LimparCampos()
        {
            //label1.Visible = false;
            // lbl_Cod.Visible = false;
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtBairro.Text = "";
            txtCep.Text = "";
            txtCidade.Text = "";
            txtCnpj.Text = "";
            txtCpf.Text = "";
            txtComplemeto.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            cbxPessoa.SelectedIndex = -1;
            cbxUf.SelectedIndex = -1;
            txtBusca.Text = "";
            dgvcli.DataSource = null;
            rbAtivo.Checked = true;
            txtNome.Focus();

        }
        private void manipularDados()
        {
            label1.Visible = true;
            lbl_Cod.Visible = true;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            cbxPessoa.Enabled = true;
            txtCpf.Enabled = true;
            txtCnpj.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemeto.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbxUf.Enabled = true;
            txtCep.Enabled = true;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }
        private void carregaDados()
        {
            manipularDados();
            lbl_Cod.Text = dgvcli.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dgvcli.SelectedRows[0].Cells[1].Value.ToString();
            txtTelefone.Text = dgvcli.SelectedRows[0].Cells[14].Value.ToString();
            string pessoa = dgvcli.SelectedRows[0].Cells[13].Value.ToString();
            if (pessoa == "F")
            {
                cbxPessoa.SelectedIndex = 0;
            }
            else
            {
                cbxPessoa.SelectedIndex = 1;
            }
            txtCpf.Text = dgvcli.SelectedRows[0].Cells[2].Value.ToString();
            txtCnpj.Text = dgvcli.SelectedRows[0].Cells[3].Value.ToString();
            txtLogradouro.Text = dgvcli.SelectedRows[0].Cells[4].Value.ToString();
            txtNumero.Text = dgvcli.SelectedRows[0].Cells[5].Value.ToString();
            txtComplemeto.Text = dgvcli.SelectedRows[0].Cells[6].Value.ToString();
            txtBairro.Text = dgvcli.SelectedRows[0].Cells[7].Value.ToString();
            txtCidade.Text = dgvcli.SelectedRows[0].Cells[8].Value.ToString();

            string uf = dgvcli.SelectedRows[0].Cells[9].Value.ToString();
            if (uf == "AC")
            {
                cbxUf.SelectedIndex = 0;
            }
            else if (uf == "AL")
            {
                cbxUf.SelectedIndex = 1;
            }
            else if (uf == "AP")
            {
                cbxUf.SelectedIndex = 2;
            }
            else if (uf == "AM")
            {
                cbxUf.SelectedIndex = 3;
            }
            else if (uf == "BA")
            {
                cbxUf.SelectedIndex = 4;
            }
            else if (uf == "CE")
            {
                cbxUf.SelectedIndex = 5;
            }
            else if (uf == "ES")
            {
                cbxUf.SelectedIndex = 6;
            }
            else if (uf == "GO")
            {
                cbxUf.SelectedIndex = 7;
            }
            else if (uf == "MA")
            {
                cbxUf.SelectedIndex = 8;
            }
            else if (uf == "MT")
            {
                cbxUf.SelectedIndex = 9;
            }
            else if (uf == "MS")
            {
                cbxUf.SelectedIndex = 10;
            }
            else if (uf == "MG")
            {
                cbxUf.SelectedIndex = 11;
            }
            else if (uf == "PA")
            {
                cbxUf.SelectedIndex = 12;
            }
            else if (uf == "PB")
            {
                cbxUf.SelectedIndex = 13;
            }
            else if (uf == "PR")
            {
                cbxUf.SelectedIndex = 14;
            }
            else if (uf == "PE")
            {
                cbxUf.SelectedIndex = 15;
            }
            else if (uf == "PI")
            {
                cbxUf.SelectedIndex = 16;
            }
            else if (uf == "RJ")
            {
                cbxUf.SelectedIndex = 17;
            }
            else if (uf == "RN")
            {
                cbxUf.SelectedIndex = 18;
            }
            else if (uf == "RS")
            {
                cbxUf.SelectedIndex = 19;
            }
            else if (uf == "RO")
            {
                cbxUf.SelectedIndex = 20;
            }
            else if (uf == "RR")
            {
                cbxUf.SelectedIndex = 21;
            }
            else if (uf == "SC")
            {
                cbxUf.SelectedIndex = 22;
            }
            else if (uf == "SP")
            {
                cbxUf.SelectedIndex = 23;
            }
            else if (uf == "SE")
            {
                cbxUf.SelectedIndex = 24;
            }
            else if (uf == "TO")
            {
                cbxUf.SelectedIndex = 25;
            }
            else
            {
                cbxUf.SelectedIndex = 26;
            }
            txtCep.Text = dgvcli.SelectedRows[0].Cells[10].Value.ToString();
            txtEmail.Text = dgvcli.SelectedRows[0].Cells[11].Value.ToString();
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
        }

        private void UCCliente_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
        }

        private void cbxPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPessoa.SelectedIndex == -1) // se não houver nada selecionado
            {
                lblCnpj.Visible = false;
                txtCnpj.Visible = false;
            }
            else if (cbxPessoa.SelectedIndex == 0) // se  houver  selecionado fisica
            {
                lblCnpj.Visible = false;
                txtCnpj.Visible = false;
            }
            else
            {
                lblCnpj.Visible = true;
                txtCnpj.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitaCampos();
            LimparCampos();
            btnNovo.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdbInativo.Checked)
            {
                MessageBox.Show(" Para cadastrar um Cliente marque Ativo no status.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbAtivo.Checked = true;

            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Telefone.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
            }
            else if (txtTelefone.Text.Length < 11)
            {
                MessageBox.Show(" Telefone invalido tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTelefone.Focus();
            }
            else if (cbxPessoa.SelectedIndex == -1)
            {
                MessageBox.Show("Obrigatório informar o tipo de pessoa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (cbxPessoa.SelectedIndex == 0 && txtCpf.Text.Length < 11)
            {
                MessageBox.Show("Informe um CPF válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
            }
            else if (cbxPessoa.SelectedIndex == 1 && txtCnpj.Text.Length < 14)
            {
                MessageBox.Show("Informe um CNPJ válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCnpj.Focus();
            }
            else if (txtLogradouro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Logradouro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogradouro.Focus();
            }
            else if (txtNumero.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo Número.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNumero.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o nome do Bairro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBairro.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informa o nome da Cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCidade.Focus();
            }
            else if (txtCep.Text.Length < 8)
            {
                MessageBox.Show("Obrigatório informa o campo CEP.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCep.Focus();
            }
            else if (cbxUf.SelectedIndex == 1)
            {
                MessageBox.Show("Obrigatório informa o Estado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório informar o E-mail.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Focus();
            }
            else
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;
                string cpf;
                string cnpj;
                string pessoa;
                if (cbxPessoa.SelectedIndex == 0)
                {
                    pessoa = "F";
                    cpf = txtCpf.Text;
                    cnpj = "";
                }
                else
                {
                    pessoa = "J";
                    cnpj = txtCnpj.Text;
                    cpf = "";
                }

                string logradouro = txtLogradouro.Text;
                string numero = txtNumero.Text;
                string complemento = txtComplemeto.Text;
                string bairro = txtBairro.Text;
                string cidade = txtCidade.Text;
                string cep = txtCep.Text;
                string uf = cbxUf.SelectedItem.ToString();

                try
                {
                    string strSql = "insert into tbl_Cliente(nm_Cliente,no_CPF,no_CNPJ,nm_Logradouro,no_Logradouro,ds_Complemento,nm_Bairro,nm_Cidade,sg_UF,no_CEP,ds_Email,ds_Status,)" +
                        "values(@nm_Cliente,@no_CPF,@no_CNPJ,@nm_Logradouro,@no_Logradouro,@ds_Complemento,@nm_Bairro,@nm_Cidade,@sg_UF,@no_CEP,@ds_Email,1) set @cd = SCOPE_IDENTITY()";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@nm_Cliente", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@no_CPF", SqlDbType.VarChar).Value = cpf;
                    cm.Parameters.Add("@no_CNPJ", SqlDbType.VarChar).Value = cnpj;
                    cm.Parameters.Add("@nm_Logradouro", SqlDbType.VarChar).Value = logradouro;
                    cm.Parameters.Add("@no_Logradouro", SqlDbType.VarChar).Value = numero;
                    cm.Parameters.Add("@ds_Complemento", SqlDbType.VarChar).Value = complemento;
                    cm.Parameters.Add("@nm_Bairro", SqlDbType.VarChar).Value = bairro;
                    cm.Parameters.Add("@nm_Cidade", SqlDbType.VarChar).Value = cidade;
                    cm.Parameters.Add("@sg_UF", SqlDbType.VarChar).Value = uf;
                    cm.Parameters.Add("@no_CEP", SqlDbType.VarChar).Value = cep;
                    cm.Parameters.Add("@ds_Email", SqlDbType.VarChar).Value = email;

                    //cm.Parameters.Add("@ds_pessoa", SqlDbType.Char).Value = pessoa;
                    cm.Parameters.AddWithValue("@cd", 0).Direction = ParameterDirection.Output;

                    cn.Open();
                    cm.ExecuteNonQuery();

                    int cd = Convert.ToInt32(cm.Parameters["@cd"].Value);
                    string celular = txtTelefone.Text;

                    cm.CommandText = "insert into tbl_telefone(cd_Cliente,no_Telefone)values('" + cd + "','" + celular + "')";
                    cm.Connection = cn;
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();

                    MessageBox.Show("Os dados do cliente foram inseridos com sucesso!!", "Dados Inseridos");

                    LimparCampos();
                    cn.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                    cn.Close();
                }
                finally { cn.Close(); }



            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from tbl_cliente where nm_Cliente like ('" + txtBusca.Text + "%')";

                    cm.Connection = cn;

                    SqlDataAdapter da = new SqlDataAdapter();

                    DataTable dt = new DataTable();

                    da.SelectCommand = cm;
                    da.Fill(dt);//preenchendo o datatable
                    dgvcli.DataSource = dt;
                    cn.Close();
                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                }

            }
            else
            {
                dgvcli.DataSource = null;
            }
        }

        private void dgvcli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaDados();
        }
    }
}

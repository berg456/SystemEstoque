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
using System.IO;

namespace PetShop
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        //Estabelecendo conexão com o banco de dados sql server
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-OJPN3JR;Initial Catalog=PetShop;Integrated Security=True;Encrypt=False");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        private void desabilitaCampo()
        {
            txtNome.Enabled = false;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtFoto.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
            //btnNovo.Enabled = false;
        }
        private void habilitaCampo()
        {
            txtNome.Enabled = true;
            txtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtCpf.Enabled = true;
            txtEndereco.Enabled = true;
            txtFoto.Enabled = true;
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
            txtCelular.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            txtFoto.Clear();
            lblCod.Text = string.Empty;
            txtNome.Focus();
        }
        private void manipularDados()
        {
            //label1.Visible = true;
            lblCod.Visible = true;
            txtNome.Enabled = true;
            txtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtCpf.Enabled = false;
            txtEndereco.Enabled = false;
            txtFoto.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = true;
            btnAlterar.Enabled = true;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
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
             if (txtCelular.Text == "")
            {
                MessageBox.Show(" Informe o seu Celular.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCelular.Focus();
            }
             if (txtCpf.Text == "")
            {
                MessageBox.Show(" Informe a seu Cpf.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
            }
             if (txtEndereco.Text == "")
            {
                MessageBox.Show(" Informe a seu Endereço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Focus();
            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string celular = txtCelular.Text;
                    string email = txtEmail.Text;
                    string cpf = txtCpf.Text;
                    string endereco = txtEndereco.Text;
                    
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pbCliente.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagem = ms.GetBuffer();
                    

                    string strsql = "insert into cliente(nome,celular,email,cpf,endereco,foto)values(@nome,@celular,@email,@cpf,@endereco,1)";
                    cm.CommandText = strsql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                    cm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
                    


                    cn.Open(); 
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show(" Dados Salvos com Sucesso!!", "Inserção de Dados Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "select * from cliente where nome like ('" + txtBusca.Text + "%')";
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
        private void carregaCliente()
        {
            lblCod.Text = dgvfunc.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dgvfunc.SelectedRows[0].Cells[1].Value.ToString();
            txtCelular.Text = dgvfunc.SelectedRows[0].Cells[2].Value.ToString();
            txtEmail.Text = dgvfunc.SelectedRows[0].Cells[3].Value.ToString();
            txtCpf.Text = dgvfunc.SelectedRows[0].Cells[4].Value.ToString();
            txtEndereco.Text = dgvfunc.SelectedRows[0].Cells[5].Value.ToString();
            //txtFoto.Text = dgvfunc.SelectedRows[0].Cells[6].Value.ToString();
            byte[] imagenBuffer = (byte[])this.dgvfunc.CurrentRow.Cells["imagem"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            this.pbCliente.Image = Image.FromStream(ms);
            this.pbCliente.SizeMode = PictureBoxSizeMode.StretchImage;

            manipularDados();
        }

        private void dgvfunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregaCliente();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informa o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else if (txtCelular.Text == "")
            {
                MessageBox.Show(" Informe o seu Celular.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCelular.Focus();
            }
            else if (txtCpf.Text == "")
            {
                MessageBox.Show(" Informe a seu Cpf.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpf.Focus();
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show(" Informe a seu Endereço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndereco.Focus();
            }
            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string celular = txtCelular.Text;
                    string email = txtEmail.Text;
                    string cpf = txtCpf.Text;
                    string endereco = txtEndereco.Text;
                    string foto = txtFoto.Text;
                    int cd = Convert.ToInt32(lblCod.Text);

                    string strsql = "update cliente set nome=@nome,celular=@celular,email=@email,cpf=@cpf,endereco@endereco,foto=@foto where codigo=@cd";
                    cm.CommandText = strsql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@celular", SqlDbType.VarChar).Value = celular;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                    cm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;
                    cm.Parameters.Add("@foto", SqlDbType.Image).Value = foto;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show(" Dados Alterados com Sucesso!!", "Alteração de Dados Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
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
                        string strSql = "update cliente set  where codigo = @cd";
                        cm.CommandText = strSql;
                        cm.Connection = cn;
                        cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
                        cm.ExecuteNonQuery();
                        cm.Parameters.Clear();
                        MessageBox.Show(" Dados Excluidos com Sucesso!!", "Alteração de Dados Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();
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

        private void button_upload_Click(object sender, EventArgs e)
        {
            //browse photo from your computer
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select photo(*.jpg;*.png;*.gif) |*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
                pbCliente.Image = Image.FromFile(opf.FileName);
        }
    }
}

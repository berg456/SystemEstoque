using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FrmCategoria : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        public FrmCategoria()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txtNome, "Insira o nome da Categoria");
        }
        //Mostrar mensagem de confirmação
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Comércio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Mostrar mensagem de erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Comércio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Limpar Campos
        private void Limpar()
        {
            this.txtNome.Text = String.Empty;
            this.txtIdCategoria.Text = String.Empty;
            this.txtDescricao.Text = String.Empty;
        }

        //Habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtNome.ReadOnly = !valor; 
            this.txtIdCategoria.ReadOnly = !valor;
            this.txtDescricao.ReadOnly = !valor;
        }
        //Habilitar os button
        private void botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }

        //Ocultar colunas do Grid
        private void ocultarColunas()
        {
            this.DataLista.Columns[0].Visible = false;
            this.DataLista.Columns[1].Visible = false;
        }

        //Mostrar no grid
        private void Mostrar()
        {
            this.DataLista.DataSource = NCategoria.Mostrar();
            this.ocultarColunas();
            //lblTotal.Text = "Total de Registros: " + DataLista.Rows.Count.ToString();
            lblTotal.Text = "Total de Registros: " + Convert.ToString (DataLista.Rows.Count);
        }

        //Buscar pelo nome
        private void BuscarNome()
        {
            this.DataLista.DataSource = NCategoria.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();
            // lblTotal.Text = "Total de Registros: " + DataLista.Rows.Count.ToString();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(DataLista.Rows.Count);
        }
        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.botoes();
            this.eEditar = false;
            this.Limpar();
            this.Habilitar(true);
            this.txtNome.Focus();
            this.txtIdCategoria.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtNome.Text == string.Empty)
                {
                    MensagemErro("Preencha os campos");
                    errorIcone.SetError(txtNome, "Insira o nome");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NCategoria.Inserir(this.txtNome.Text.Trim().ToUpper(), this.txtDescricao.Text.Trim());
                    }
                    else
                    {
                        resp = NCategoria.Editar(Convert.ToInt32( this.txtIdCategoria.Text), this.txtNome.Text.Trim().ToUpper(),
                            this.txtDescricao.Text.Trim());
                    }
                    if (resp.Equals("Ok"))

                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro Salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOk("Registro Editado com sucesso");
                        }

                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }
                    this.eNovo = false;
                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdCategoria.Text = Convert.ToString( this.DataLista.CurrentRow.Cells["idcategoria"].Value);
            this.txtNome.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["nome"].Value);
            this.txtDescricao.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["descricao"].Value);
            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtIdCategoria.Text.Equals(""))
            {
                this.MensagemErro("Selecione um registro para inserir");
            }
            else
            {
                this.eEditar = true;
                this.botoes();
                this.Habilitar(true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.botoes();
            this.Habilitar(false);
            this.Limpar();
        }

        private void chkDeletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletar.Checked)
            {
                this.DataLista.Columns[0].Visible = true;
            }
            else
            {
                this.DataLista.Columns[0].Visible = false;
            }
        }

        private void DataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell) DataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar os Registros?", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row  in DataLista.Rows)
                    {
                        if (Convert.ToBoolean (row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NCategoria.Excluir(Convert.ToInt32(Codigo));

                            if (Resp.Equals("Ok"))
                            {
                                this.MensagemOk("Registro(s) Excluido(s) com sucesso!");
                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}

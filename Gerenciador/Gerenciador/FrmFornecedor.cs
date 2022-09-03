using System.Windows.Forms;
using DTO;
using BLL;
using DbaCon;
using System.Linq;
using System;

namespace Gerenciador
{
    public partial class FrmFornecedor : Form
    {
        DataConexao dataConexao = new DataConexao();
        public FrmFornecedor(AcaoTela acaoTela, Fornecedor fornecedorSelecionado)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            CarregaEstado(AcaoTela.Adicionar);
            CarregaBairro(AcaoTela.Adicionar);
            rBtnCNPJFornecedor.Checked = true;
            cbxCidadeFornecedor.Enabled = false;
            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Fornecedor";

            }
            else if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Fornecedor";
                try
                {

                    if (fornecedorSelecionado.CPF_CNPJ.Length.Equals(14))
                    {
                        rBtnCPFFornecedor.Checked = true;
                        mTxtCPFFornecedor.Text = fornecedorSelecionado.CPF_CNPJ.ToString();
                    }
                    else
                    {
                        mTxtCNPJFornecedor.Text = fornecedorSelecionado.CPF_CNPJ.ToString();
                    }
                  
                    txtRazaoSocialFornecedor.Text = fornecedorSelecionado.Razao_Social.ToString();
                    txtNomeFantasiaFornecedor.Text = fornecedorSelecionado.Nome_Fantasia.ToString();
                    cbxEstadoFornecedor.SelectedIndex = cbxEstadoFornecedor.FindStringExact(fornecedorSelecionado.EstadoFornecedor.Nome_Estado.ToString());
                    cbxCidadeFornecedor.SelectedIndex = cbxCidadeFornecedor.FindStringExact(fornecedorSelecionado.CidadeFornecedor.Nome_Cidade.ToString());
                    cbxBairroFornecedor.SelectedIndex = cbxBairroFornecedor.FindStringExact(fornecedorSelecionado.BairroFornecedor.Nome_Bairro.ToString());
                    txtEnderecoFornecedor.Text = fornecedorSelecionado.Endereco_Fornecedor.ToString();
                    mTxtTelFixoFornecedor.Text = fornecedorSelecionado.Tel_Fixo_Fornecedor.ToString();
                    mTxtTelCelFornecedor.Text = fornecedorSelecionado.Tel_Cel_Fornecedor.ToString();
                    txtContatoFornecedor.Text = fornecedorSelecionado.Contato.ToString();
                    txtEmailFornecedor.Text = fornecedorSelecionado.Email_Fornecedor.ToString();
                    toolStripStatusIdFornecedor.Text = fornecedorSelecionado.Id_Fornecedor.ToString();

                }
                catch
                {
                    MessageBox.Show("Nenhum Fornecedor Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void LimparCampos()
        {
            txtRazaoSocialFornecedor.Clear();
            txtNomeFantasiaFornecedor.Clear();
            txtEnderecoFornecedor.Clear();
            txtEmailFornecedor.Clear();
            txtContatoFornecedor.Clear();
            mTxtCNPJFornecedor.Clear();
            mTxtCPFFornecedor.Clear();
            mTxtTelCelFornecedor.Clear();
            mTxtTelFixoFornecedor.Clear();
            cbxBairroFornecedor.SelectedValue = "";
            cbxEstadoFornecedor.SelectedValue = "";
            cbxCidadeFornecedor.Enabled = false;
            txtRazaoSocialFornecedor.Focus();
        }
        private void CarregaEstado(AcaoTela acaoTela)
        {
            EstadoNegocios estadoNegocios = new EstadoNegocios();
            EstadoColecao estadoColecao = new EstadoColecao();

            estadoColecao = estadoNegocios.ConsultarEstadosPorNome("");
            cbxEstadoFornecedor.DataSource = null;
            cbxEstadoFornecedor.DataSource = estadoColecao;

            cbxEstadoFornecedor.ValueMember = "Id_Estado";
            cbxEstadoFornecedor.DisplayMember = "Nome_Estado";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxEstadoFornecedor.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                cbxEstadoFornecedor.SelectedValue = estadoColecao.Max(e => e.Id_Estado);
            }

            cbxEstadoFornecedor.Update();
            cbxEstadoFornecedor.Refresh();

        }
        private void CarregaCidade(int idEstado)
        {
            CidadeNegocios cidadeNegocios = new CidadeNegocios();
            CidadeColecao cidadeColecao = new CidadeColecao();

            cidadeColecao = cidadeNegocios.ConsultarCidadePorIdEstado(idEstado);
            cbxCidadeFornecedor.DataSource = null;
            cbxCidadeFornecedor.DataSource = cidadeColecao;

            cbxCidadeFornecedor.ValueMember = "Id_Cidade";
            cbxCidadeFornecedor.DisplayMember = "Nome_Cidade";


            cbxCidadeFornecedor.Update();
            cbxCidadeFornecedor.Refresh();

        }
        private void CarregaBairro(AcaoTela acaoTela)
        {
            BairroNegocios bairroNegocios = new BairroNegocios();
            BairroColecao bairroColecao = new BairroColecao();

            bairroColecao = bairroNegocios.ConsultarBairroPorNome("");
            cbxBairroFornecedor.DataSource = null;
            cbxBairroFornecedor.DataSource = bairroColecao;

            cbxBairroFornecedor.ValueMember = "Id_Bairro";
            cbxBairroFornecedor.DisplayMember = "Nome_Bairro";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxBairroFornecedor.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (bairroColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxBairroFornecedor.SelectedValue = bairroColecao.Max(b => b.Id_Bairro);
                }
            }

            cbxBairroFornecedor.Update();
            cbxBairroFornecedor.Refresh();

        }
        private void ExecutarButoes(int acao, object idfornecedor, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtRazaoSocialFornecedor, ePrRazaoSocial) && FrmLogin.validarCampo(txtNomeFantasiaFornecedor, ePrNomeFantasia) &&
                FrmLogin.validarComboBox(cbxEstadoFornecedor, ePrEstado) && FrmLogin.validarComboBox(cbxCidadeFornecedor, ePrCidade) &&
                FrmLogin.validarComboBox(cbxBairroFornecedor, ePrBairro) && FrmLogin.validarCampo(txtEnderecoFornecedor, ePrEndereco) &&
                FrmLogin.validarMTextbox(mTxtTelFixoFornecedor, ePrTelFixo) && FrmLogin.validarMTextbox(mTxtTelCelFornecedor, ePrTelCel) &&
                FrmLogin.validarCampo(txtContatoFornecedor, ePrContato)).Equals(true))
            {
                try
                {

                    Fornecedor fornecedor = new Fornecedor();

                    fornecedor.Acao = acao;
                    fornecedor.Id_Fornecedor = Convert.ToInt32(idfornecedor);
                    fornecedor.Razao_Social = txtRazaoSocialFornecedor.Text;
                    fornecedor.Nome_Fantasia = txtNomeFantasiaFornecedor.Text;

                    if (rBtnCNPJFornecedor.Checked.Equals(true))
                    {
                        if (FrmLogin.IsCnpj(mTxtCNPJFornecedor.Text.ToString()))
                        {
                            fornecedor.CPF_CNPJ = mTxtCNPJFornecedor.Text;
                        }
                        else
                        {
                            MessageBox.Show("CNPJ Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                            
                        }
                    }
                    else
                    {
                        if (FrmLogin.IsCpf(mTxtCPFFornecedor.Text.ToString()))
                        {
                            fornecedor.CPF_CNPJ = mTxtCPFFornecedor.Text;
                        }
                        else
                        {
                            MessageBox.Show("CPF Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            return;
                        }
                    }

                    fornecedor.Endereco_Fornecedor = txtEnderecoFornecedor.Text;
                    fornecedor.Tel_Fixo_Fornecedor = mTxtTelFixoFornecedor.Text;
                    fornecedor.Tel_Cel_Fornecedor = mTxtTelCelFornecedor.Text;
                    fornecedor.Contato = txtContatoFornecedor.Text;
                    fornecedor.Email_Fornecedor = txtEmailFornecedor.Text;

                    fornecedor.EstadoFornecedor = new Estado();

                    fornecedor.EstadoFornecedor.Id_Estado = Convert.ToInt32(cbxEstadoFornecedor.SelectedValue);

                    fornecedor.CidadeFornecedor = new Cidade();

                    fornecedor.CidadeFornecedor.Id_Cidade = Convert.ToInt32(cbxCidadeFornecedor.SelectedValue);

                    fornecedor.BairroFornecedor = new Bairro();

                    fornecedor.BairroFornecedor.Id_Bairro = Convert.ToInt32(cbxBairroFornecedor.SelectedValue);

                    FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();


                    string retorno = fornecedorNegocios.ManterFornecedor(fornecedor);

                    try
                    {
                        int idFornecedor = Convert.ToInt32(retorno);

                        MessageBox.Show("Fornecedor " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Fornecedor!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Fornecedor!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Fornecedor!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdFornecedor.Text != "0")
            {
                btnEditarFornecedor.Enabled = true;
                btnExcluirFornecedor.Enabled = true;
                btnAdcionarFornecedor.Enabled = false;
                btnPesquisarFornecedor.Enabled = false;
            }
        }

        private void rBtnCNPJFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnCNPJFornecedor.Checked.Equals(true))
            {
                mTxtCNPJFornecedor.Enabled = true;
                mTxtCNPJFornecedor.Visible = true;
                mTxtCPFFornecedor.Enabled = false;
                mTxtCPFFornecedor.Visible = false;
                mTxtCNPJFornecedor.Focus();
            }
            else
            {
                mTxtCNPJFornecedor.Enabled = false;
                mTxtCNPJFornecedor.Visible = false;
                mTxtCPFFornecedor.Enabled = true;
                mTxtCPFFornecedor.Visible = true;
                mTxtCPFFornecedor.Focus();
            }
        }

        private void cbxEstadoFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEstadoFornecedor.SelectedIndex != -1)
            {
                int idEstado;
                if (Int32.TryParse(cbxEstadoFornecedor.SelectedValue.ToString(), out idEstado).Equals(true))
                {
                    cbxCidadeFornecedor.Enabled = true;
                    CarregaCidade(Convert.ToInt32(cbxEstadoFornecedor.SelectedValue));
                }
            }
                
            }

        private void btnAdcionarFornecedor_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }

        private void btnEditarFornecedor_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdFornecedor.Text), "Alterado", "Alterar");
        }

        private void btnExcluirFornecedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir O Fornecedor?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdFornecedor.Text), "Excluído", "Excluir");
        }

        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedorPesquisa frmFornecedorPesquisa = new FrmFornecedorPesquisa();
            frmFornecedorPesquisa.MdiParent = this.MdiParent;
            frmFornecedorPesquisa.Show();
            this.Close();
        }

        private void btnCancelarFornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionarBairroFornecedor_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro(AcaoTela.Adicionar, null);
            frmBairro.ShowDialog();
            CarregaBairro(AcaoTela.Recarregar);
        }

        private void FrmFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }
    }
}


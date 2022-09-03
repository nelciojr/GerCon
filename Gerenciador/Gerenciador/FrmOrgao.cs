using System.Windows.Forms;
using DTO;
using BLL;
using DbaCon;
using System.Linq;
using System;
namespace Gerenciador
{
    public partial class FrmOrgao : Form
    {
        DataConexao dataConexao = new DataConexao();
        public FrmOrgao(AcaoTela acaoTela, Orgao orgaoSelecionado)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            cbxCidadeOrgao.Enabled = false;
            CarregaEstado(AcaoTela.Adicionar);
            CarregaBairro(AcaoTela.Adicionar);
            CarregaResponsavel(AcaoTela.Adicionar);

            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Orgão";

            }
            else if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Orgão";

                try
                {
                    txtNomeOrgao.Text = orgaoSelecionado.Nome_Orgao.ToString();
                    cbxEstadoOrgao.SelectedIndex = cbxEstadoOrgao.FindStringExact(orgaoSelecionado.EstadoOrgao.Nome_Estado.ToString());
                    cbxCidadeOrgao.SelectedIndex = cbxCidadeOrgao.FindStringExact(orgaoSelecionado.CidadeOrgao.Nome_Cidade.ToString());
                    cbxBairroOrgao.SelectedIndex = cbxBairroOrgao.FindStringExact(orgaoSelecionado.BairroOrgao.Nome_Bairro.ToString());
                    txtEnderecoOrgao.Text = orgaoSelecionado.Endereco_Orgao.ToString();
                    mTxtTelFixoOrgao.Text = orgaoSelecionado.Tel_Fixo_Orgao.ToString();
                    cbxResponsavelOrgao.SelectedIndex = cbxResponsavelOrgao.FindStringExact(orgaoSelecionado.ResponsavelOrgao.Nome_Responsavel.ToString());
                    toolStripStatusIdOrgao.Text = orgaoSelecionado.Id_Orgao.ToString();

                }
                catch
                {
                    MessageBox.Show("Nenhum Orgão Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void LimparCampos()
        {
            txtNomeOrgao.Clear();
            txtEnderecoOrgao.Clear();
            mTxtTelFixoOrgao.Clear();
            cbxBairroOrgao.SelectedValue = "";
            cbxEstadoOrgao.SelectedValue = "";
            cbxCidadeOrgao.SelectedValue = "";
            cbxResponsavelOrgao.SelectedValue = "";
            cbxCidadeOrgao.Enabled = false;
            txtNomeOrgao.Focus();
        }
        private void CarregaEstado(AcaoTela acaoTela)
        {
            EstadoNegocios estadoNegocios = new EstadoNegocios();
            EstadoColecao estadoColecao = new EstadoColecao();

            estadoColecao = estadoNegocios.ConsultarEstadosPorNome("");
            cbxEstadoOrgao.DataSource = null;
            cbxEstadoOrgao.DataSource = estadoColecao;

            cbxEstadoOrgao.ValueMember = "Id_Estado";
            cbxEstadoOrgao.DisplayMember = "Nome_Estado";
           

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxEstadoOrgao.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                cbxEstadoOrgao.SelectedValue = estadoColecao.Max(e => e.Id_Estado);
            }

            cbxEstadoOrgao.Update();
            cbxEstadoOrgao.Refresh();

        }
        private void CarregaCidade(int idEstado)
        {
            CidadeNegocios cidadeNegocios = new CidadeNegocios();
            CidadeColecao cidadeColecao = new CidadeColecao();

            cidadeColecao = cidadeNegocios.ConsultarCidadePorIdEstado(idEstado);
            cbxCidadeOrgao.DataSource = null;
            cbxCidadeOrgao.DataSource = cidadeColecao;

            cbxCidadeOrgao.ValueMember = "Id_Cidade";
            cbxCidadeOrgao.DisplayMember = "Nome_Cidade";
            

            cbxCidadeOrgao.Update();
            cbxCidadeOrgao.Refresh();

        }
        private void CarregaBairro(AcaoTela acaoTela)
        {
            BairroNegocios bairroNegocios = new BairroNegocios();
            BairroColecao bairroColecao = new BairroColecao();

            bairroColecao = bairroNegocios.ConsultarBairroPorNome("");
            cbxBairroOrgao.DataSource = null;
            cbxBairroOrgao.DataSource = bairroColecao;

            cbxBairroOrgao.ValueMember = "Id_Bairro";
            cbxBairroOrgao.DisplayMember = "Nome_Bairro";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxBairroOrgao.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (bairroColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxBairroOrgao.SelectedValue = bairroColecao.Max(b => b.Id_Bairro);
                }
            }

            cbxBairroOrgao.Update();
            cbxBairroOrgao.Refresh();

        }
        private void CarregaResponsavel(AcaoTela acaoTela)
        {
            ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();
            ResponsavelColecao responsavelColecao = new ResponsavelColecao();

            responsavelColecao = responsavelNegocios.ConsultarResponsavelPorNome("");
            cbxResponsavelOrgao.DataSource = null;
            cbxResponsavelOrgao.DataSource = responsavelColecao;

            cbxResponsavelOrgao.ValueMember = "Id_Responsavel";
            cbxResponsavelOrgao.DisplayMember = "Nome_Responsavel";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxResponsavelOrgao.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (responsavelColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxResponsavelOrgao.SelectedValue = responsavelColecao.Max(r => r.Id_Responsavel);
                }
            }

            cbxResponsavelOrgao.Update();
            cbxResponsavelOrgao.Refresh();

        }
        private void ExecutarButoes(int acao, object idorgao, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtNomeOrgao, ePrNomeOrgao) && FrmLogin.validarComboBox(cbxEstadoOrgao,ePrEstadoOrgao) && 
                FrmLogin.validarComboBox(cbxCidadeOrgao, ePrCidadeOrgao) && FrmLogin.validarComboBox(cbxBairroOrgao, ePrBairroOrgao) && 
                FrmLogin.validarCampo(txtEnderecoOrgao, ePrEnderecoOrgao) && FrmLogin.validarMTextbox(mTxtTelFixoOrgao, ePrTelFixoOrgao) &&
                FrmLogin.validarComboBox(cbxResponsavelOrgao,ePrResponsavelOrgao).Equals(true)))
            {
                try
                {

                    Orgao orgao = new Orgao();

                    orgao.Acao = acao;
                    orgao.Id_Orgao = Convert.ToInt32(idorgao);
                    orgao.Nome_Orgao = txtNomeOrgao.Text;
                    orgao.Endereco_Orgao = txtEnderecoOrgao.Text;
                    orgao.Tel_Fixo_Orgao = mTxtTelFixoOrgao.Text;

                    orgao.EstadoOrgao = new Estado();

                    orgao.EstadoOrgao.Id_Estado = Convert.ToInt32(cbxEstadoOrgao.SelectedValue);
                    
                    orgao.CidadeOrgao = new Cidade();

                    orgao.CidadeOrgao.Id_Cidade = Convert.ToInt32(cbxCidadeOrgao.SelectedValue);

                    orgao.BairroOrgao = new Bairro();

                    orgao.BairroOrgao.Id_Bairro = Convert.ToInt32(cbxBairroOrgao.SelectedValue);

                    orgao.ResponsavelOrgao = new Responsavel();

                    orgao.ResponsavelOrgao.Id_Responsavel = Convert.ToInt32(cbxResponsavelOrgao.SelectedValue);

                    OrgaoNegocios orgaoNegocios = new OrgaoNegocios();


                    string retorno = orgaoNegocios.ManterOrgao(orgao);

                    try
                    {
                        int idOrgao = Convert.ToInt32(retorno);

                        MessageBox.Show("Orgão " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Orgão!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Orgão!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Orgão!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmOrgao_Load(object sender, EventArgs e)
        {
            
            if (toolStripStatusIdOrgao.Text != "0")
            {
                btnEditarOrgao.Enabled = true;
                btnExcluirOrgao.Enabled = true;
                btnAdicionarOrgao.Enabled = false;
                btnPesquisarOrgao.Enabled = false;
            }
        }

        private void cbxEstadoOrgao_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxEstadoOrgao.SelectedIndex != -1)
            {
                int idEstado;
                if (Int32.TryParse(cbxEstadoOrgao.SelectedValue.ToString(), out idEstado).Equals(true))
                {
                    cbxCidadeOrgao.Enabled = true;
                    CarregaCidade(Convert.ToInt32(cbxEstadoOrgao.SelectedValue));
                }
            }
        }

        private void btnAdicionarOrgao_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }

        private void btnEditarOrgao_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdOrgao.Text), "Alterado", "Alterar");
        }

        private void btnExcluirOrgao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir O Orgão?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdOrgao.Text), "Excluído", "Excluir");
        }

        private void btnPesquisarOrgao_Click(object sender, EventArgs e)
        {
            FrmOrgaoPesquisa frmOrgaoPesquisa = new FrmOrgaoPesquisa();
            frmOrgaoPesquisa.MdiParent = this.MdiParent;
            frmOrgaoPesquisa.Show();
            this.Close();
        }

        private void btnAdicionarBairroOrgao_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro(AcaoTela.Adicionar, null);
            frmBairro.ShowDialog();
            CarregaBairro(AcaoTela.Recarregar);

        }
          private void btnAdicionarResponsavelOrgao_Click(object sender, EventArgs e)
        {
            FrmResponsavel frmResponsavel = new FrmResponsavel(AcaoTela.Adicionar, null);
            frmResponsavel.ShowDialog();
            CarregaResponsavel(AcaoTela.Recarregar);
        }
        private void btnCancelarOrgao_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOrgao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }

       
    }

}

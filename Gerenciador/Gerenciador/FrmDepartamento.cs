using System.Windows.Forms;
using DTO;
using BLL;
using DbaCon;
using System.Linq;
using System;


namespace Gerenciador
{
    
    public partial class FrmDepartamento : Form
    {
        DataConexao dataConexao = new DataConexao();
        public FrmDepartamento(AcaoTela acaoTela, Departamento departamentoSelecionado)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            cbxCidadeDepartamento.Enabled = false;
            CarregaEstado(AcaoTela.Adicionar);
            CarregaBairro(AcaoTela.Adicionar);
            CarregaOrgao(AcaoTela.Adicionar);

            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Departamento";

            }
            else if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Departamento";

                try
                {
                    
                    txtNomeDepartamento.Text = departamentoSelecionado.Nome_Departamento.ToString();
                    cbxEstadoDepartamento.SelectedIndex = cbxEstadoDepartamento.FindStringExact(departamentoSelecionado.EstadoDepartamento.Nome_Estado.ToString());
                    cbxCidadeDepartamento.SelectedIndex = cbxCidadeDepartamento.FindStringExact(departamentoSelecionado.CidadeDepartamento.Nome_Cidade.ToString());
                    cbxBairroDepartamento.SelectedIndex = cbxBairroDepartamento.FindStringExact(departamentoSelecionado.BairroDepartamento.Nome_Bairro.ToString());
                    txtEnderecoDepartamento.Text = departamentoSelecionado.Endereco_Departamento.ToString();
                    mTxtTelFixoDepartamento.Text = departamentoSelecionado.Tel_Fixo_Departamento.ToString();
                    cbxOrgaoDepartamento.SelectedIndex = cbxOrgaoDepartamento.FindStringExact(departamentoSelecionado.OrgaoDepartamento.Nome_Orgao.ToString());
                    toolStripStatusIdDepartamento.Text = departamentoSelecionado.Id_Departamento.ToString();

                }
                catch
                {
                    MessageBox.Show("Nenhum Departamento Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void LimparCampos()
        {
            txtNomeDepartamento.Clear();
            txtEnderecoDepartamento.Clear();
            mTxtTelFixoDepartamento.Clear();
            cbxBairroDepartamento.SelectedValue = "";
            cbxEstadoDepartamento.SelectedValue = "";
            cbxCidadeDepartamento.SelectedValue = "";
            cbxCidadeDepartamento.Enabled = false;
            txtNomeDepartamento.Focus();
        }
        private void CarregaEstado(AcaoTela acaoTela)
        {
            EstadoNegocios estadoNegocios = new EstadoNegocios();
            EstadoColecao estadoColecao = new EstadoColecao();

            estadoColecao = estadoNegocios.ConsultarEstadosPorNome("");
            cbxEstadoDepartamento.DataSource = null;
            cbxEstadoDepartamento.DataSource = estadoColecao;

            cbxEstadoDepartamento.ValueMember = "Id_Estado";
            cbxEstadoDepartamento.DisplayMember = "Nome_Estado";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxEstadoDepartamento.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                cbxEstadoDepartamento.SelectedValue = estadoColecao.Max(e => e.Id_Estado);
            }

            cbxEstadoDepartamento.Update();
            cbxEstadoDepartamento.Refresh();

        }
        private void CarregaCidade(int idEstado)
        {
            CidadeNegocios cidadeNegocios = new CidadeNegocios();
            CidadeColecao cidadeColecao = new CidadeColecao();

            cidadeColecao = cidadeNegocios.ConsultarCidadePorIdEstado(idEstado);
            cbxCidadeDepartamento.DataSource = null;
            cbxCidadeDepartamento.DataSource = cidadeColecao;

            cbxCidadeDepartamento.ValueMember = "Id_Cidade";
            cbxCidadeDepartamento.DisplayMember = "Nome_Cidade";

            cbxCidadeDepartamento.Update();
            cbxCidadeDepartamento.Refresh();

        }
        private void CarregaBairro(AcaoTela acaoTela)
        {
            BairroNegocios bairroNegocios = new BairroNegocios();
            BairroColecao bairroColecao = new BairroColecao();

            bairroColecao = bairroNegocios.ConsultarBairroPorNome("");
            cbxBairroDepartamento.DataSource = null;
            cbxBairroDepartamento.DataSource = bairroColecao;

            cbxBairroDepartamento.ValueMember = "Id_Bairro";
            cbxBairroDepartamento.DisplayMember = "Nome_Bairro";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxBairroDepartamento.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (bairroColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxBairroDepartamento.SelectedValue = bairroColecao.Max(b => b.Id_Bairro);
                }
            }

            cbxBairroDepartamento.Update();
            cbxBairroDepartamento.Refresh();

        }
        private void CarregaOrgao(AcaoTela acaoTela)
        {
            OrgaoNegocios orgaoNegocios = new OrgaoNegocios();
            OrgaoColecao orgaoColecao = new OrgaoColecao();

            orgaoColecao = orgaoNegocios.ConsultarOrgaoPorNome("");
            cbxOrgaoDepartamento.DataSource = null;
            cbxOrgaoDepartamento.DataSource = orgaoColecao;

            cbxOrgaoDepartamento.ValueMember = "Id_Orgao";
            cbxOrgaoDepartamento.DisplayMember = "Nome_Orgao";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxOrgaoDepartamento.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (orgaoColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxOrgaoDepartamento.SelectedValue = orgaoColecao.Max(o => o.Id_Orgao);
                }
            }

            cbxOrgaoDepartamento.Update();
            cbxOrgaoDepartamento.Refresh();

        }
        private void ExecutarButoes(int acao, object iddepartamento, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtNomeDepartamento, ePrNomeDepartamento) && FrmLogin.validarComboBox(cbxEstadoDepartamento, ePrEstadoDepartamento) &&
                FrmLogin.validarComboBox(cbxCidadeDepartamento, ePrCidadeDepartamento) && FrmLogin.validarComboBox(cbxBairroDepartamento, ePrBairroDepartamento) &&
                FrmLogin.validarCampo(txtEnderecoDepartamento, ePrEnderecoDepartamento) && FrmLogin.validarMTextbox(mTxtTelFixoDepartamento, ePrTelFixoDepartamento) &&
                FrmLogin.validarComboBox(cbxOrgaoDepartamento, ePrOrgaoDepartamento).Equals(true)))
            {
                try
                {

                   Departamento departamento = new Departamento();

                    departamento.Acao = acao;
                    departamento.Id_Departamento = Convert.ToInt32(iddepartamento);
                    departamento.Nome_Departamento = txtNomeDepartamento.Text;
                    departamento.Endereco_Departamento = txtEnderecoDepartamento.Text;
                    departamento.Tel_Fixo_Departamento = mTxtTelFixoDepartamento.Text;

                    departamento.EstadoDepartamento = new Estado();

                    departamento.EstadoDepartamento.Id_Estado = Convert.ToInt32(cbxEstadoDepartamento.SelectedValue);

                    departamento.CidadeDepartamento = new Cidade();

                    departamento.CidadeDepartamento.Id_Cidade = Convert.ToInt32(cbxCidadeDepartamento.SelectedValue);

                    departamento.BairroDepartamento = new Bairro();

                    departamento.BairroDepartamento.Id_Bairro = Convert.ToInt32(cbxBairroDepartamento.SelectedValue);

                    departamento.OrgaoDepartamento = new Orgao();

                    departamento.OrgaoDepartamento.Id_Orgao = Convert.ToInt32(cbxOrgaoDepartamento.SelectedValue);

                    DepartamentoNegocios departamentoNegocios = new DepartamentoNegocios();


                    string retorno = departamentoNegocios.ManterDepartamento(departamento);

                    try
                    {
                        int idDepartamento = Convert.ToInt32(retorno);

                        MessageBox.Show("Departamento " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Departamento!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Departamento!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Departamento!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdDepartamento.Text != "0")
            {
                btnEditarDepartamento.Enabled = true;
                btnExcluirDepartamento.Enabled = true;
                btnAdicionarDepartamento.Enabled = false;
                btnPesquisarDepartamento.Enabled = false;
            }
        }

        private void cbxEstadoDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstadoDepartamento.SelectedIndex != -1)
            {
                int idEstado;
                if (Int32.TryParse(cbxEstadoDepartamento.SelectedValue.ToString(), out idEstado).Equals(true))
                {
                    cbxCidadeDepartamento.Enabled = true;
                    CarregaCidade(Convert.ToInt32(cbxEstadoDepartamento.SelectedValue));
                }
            }
        }

        private void btnAdicionarDepartamento_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdDepartamento.Text), "Alterado", "Alterar");
        }

        private void btnExcluirDepartamento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir O Departamento?", "Atenção",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdDepartamento.Text), "Excluído", "Excluir");
        }

        private void btnPesquisarDepartamento_Click(object sender, EventArgs e)
        {
            FrmDepartamentoPesquisa frmDepartamentoPesquisa = new FrmDepartamentoPesquisa();
            frmDepartamentoPesquisa.MdiParent = this.MdiParent;
            frmDepartamentoPesquisa.Show();
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
            FrmOrgao frmOrgao = new FrmOrgao(AcaoTela.Adicionar, null);
            frmOrgao.ShowDialog();
            CarregaOrgao(AcaoTela.Recarregar);
        }

        private void btnCancelarDepartamento_Click(object sender, EventArgs e)
        {
                Close();
            
        }

        private void FrmDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }
    }
}

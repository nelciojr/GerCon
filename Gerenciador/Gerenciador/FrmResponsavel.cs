using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmResponsavel : Form
    {
        public FrmResponsavel(AcaoTela acaoTela, Responsavel responsavelSelecionado)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
           
            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Responsável";

                
            }
            if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Responsável";

                try
                {

                    txtResponsavel.Text = responsavelSelecionado.Nome_Responsavel.ToString();
                    mTxtCPF.Text = responsavelSelecionado.CPF_Resposavel.ToString();
                    mTxtTelFixo.Text = responsavelSelecionado.Tel_Fixo_Responsavel.ToString();
                    mTxtTelCel.Text = responsavelSelecionado.Tel_Cel_Responsavel.ToString();
                    toolStripStatusIdResponsavel.Text = responsavelSelecionado.Id_Responsavel.ToString();

                    
                    
                }
                catch
                {
                    MessageBox.Show("Nenhum Responsável Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }

        }

        private void FrmResponsavel_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdResponsavel.Text != "0")
            {
                btnEditarResponsavel.Enabled = true;
                btnExcluirResponsavel.Enabled = true;
                btnAdcionarResponsavel.Enabled = false;
                btnPesquisarResponsavel.Enabled = false;

            }
        }
        private void LimparCampos()
        {
            txtResponsavel.Clear();
            mTxtCPF.Clear();
            mTxtTelFixo.Clear();
            mTxtTelCel.Clear();
            txtResponsavel.Focus();
        }
        private void ExecutarButoes(int acao, object idresponsavel, string msg, string msg2)
        {

            if ((FrmLogin.validarCampo(txtResponsavel, errorProviderResponsavel) && FrmLogin.validarMTextbox(mTxtCPF, errorProviderCPF) && FrmLogin.validarMTextbox(mTxtTelFixo, errorProviderTelFixo) && FrmLogin.validarMTextbox(mTxtTelCel, errorProviderTelCelular).Equals(true)))
            {

                try
                {
                    Responsavel responsavel = new Responsavel();

                    responsavel.Acao = acao;
                    responsavel.Id_Responsavel = Convert.ToInt32(idresponsavel);
                    responsavel.Nome_Responsavel = txtResponsavel.Text;
                   
                    responsavel.Tel_Fixo_Responsavel = mTxtTelFixo.Text;
                    responsavel.Tel_Cel_Responsavel = mTxtTelCel.Text;

                    if (FrmLogin.IsCpf(mTxtCPF.Text.ToString()))
                    {
                         responsavel.CPF_Resposavel = mTxtCPF.Text;
                    }
                    else
                    {
                        MessageBox.Show("CPF Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                   ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();

                    string retorno = responsavelNegocios.ManterResponsavel(responsavel);

                    try
                    {
                        int idResponsavel = Convert.ToInt32(retorno);

                        MessageBox.Show("Responsável " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o(a) Responsável!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o(a) Responsável!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o(a) Responsável!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdcionarResponsavel_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }

        private void btnEditarResponsavel_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdResponsavel.Text), "Alterado", "Alterar");
        }

        private void btnExcluirResponsavel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir O(A) Responsável?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdResponsavel.Text), "Excluído", "Excluir");
        }

        private void btnPesquisarResponsavel_Click(object sender, EventArgs e)
        {
            FrmResponsavelPesquisa frmResponsavelPesquisa = new FrmResponsavelPesquisa();
            frmResponsavelPesquisa.MdiParent = this.MdiParent;
            frmResponsavelPesquisa.Show();
            this.Close();
        }

        private void FrmResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }
    }
}

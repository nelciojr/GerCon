using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmUnidMedida : Form
    {
        public FrmUnidMedida(AcaoTela acaoTela, UnidMedida unidMedidaSelecionada)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Unidade de Medida";
            }
            if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Unidade de Medida";
                try
                {
                    txtUnidMedidaDescricao.Text = unidMedidaSelecionada.Descricao.ToString();
                    txtUnidMedidaLegenda.Text = unidMedidaSelecionada.Legenda.ToString();
                    toolStripStatusIdUnidMedida.Text = unidMedidaSelecionada.Id_UnidMedida.ToString();

                }
                catch
                {
                    MessageBox.Show("Nenhuma Unidade de Medida Selecionada! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void FrmUnidMedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }
        private void FrmUnidMedida_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdUnidMedida.Text != "0")
            {
                btnEditarUnidMedida.Enabled = true;
                btnExcluirUnidMedida.Enabled = true;
                btnAdcionarUnidMedida.Enabled = false;
                btnPesquisarUnidMedida.Enabled = false;
            }
        }
        private void LimparCampos()
        {
            txtUnidMedidaDescricao.Clear();
            txtUnidMedidaLegenda.Clear();
        
        }
        private void ExecutarButoes(int acao, object idunidmedida, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtUnidMedidaDescricao, errorProviderUnidMedidaDescricao) && FrmLogin.validarCampo(txtUnidMedidaLegenda, errorProviderUnidMedidaLegenda).Equals(true)))
            {
                try
                {
                    UnidMedida unidMedida = new UnidMedida();

                    unidMedida.Acao = acao;
                    unidMedida.Id_UnidMedida = Convert.ToInt32(idunidmedida);
                    unidMedida.Descricao = txtUnidMedidaDescricao.Text;
                    unidMedida.Legenda = txtUnidMedidaLegenda.Text;

                    UnidMedidaNegocios unidMedidaNegocios = new UnidMedidaNegocios();

                    string retorno = unidMedidaNegocios.ManterUnidMedida(unidMedida);

                    try
                    {
                        int idUnidMedida = Convert.ToInt32(retorno);
                        MessageBox.Show("Unidade de Medida " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionada"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        if (retorno.Contains("FOREIGN KEY"))
                           MessageBox.Show("Não foi Possível " + msg2 + " a Unidade de Medida!\n Detalhes: Esse Unidade de Medida Esta Sendo Utilizada na Tabela de Produto!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Não foi Possível " + msg2 + " a Unidade de Medida!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Usuário!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Usuário!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }
        private void btnAdcionarUnidMedida_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionada", "Adicionar");
        }
        private void btnEditarUnidMedida_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdUnidMedida.Text), "Alterada", "Alterar");
        }
        private void btnExcluirUnidMedida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir A Unidade de Medida?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdUnidMedida.Text), "Excluída", "Excluir");
        }
        private void btnPesquisarUnidMedida_Click(object sender, EventArgs e)
        {
            FrmUnidMedidaPesquisa frmUnidMedidaPesquisa = new FrmUnidMedidaPesquisa();
            frmUnidMedidaPesquisa.MdiParent = this.MdiParent;
            frmUnidMedidaPesquisa.Show();
            this.Close();
        }

        
    }
}

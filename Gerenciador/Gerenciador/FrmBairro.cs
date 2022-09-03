using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmBairro : Form
    {
        public FrmBairro(AcaoTela acaoTela, Bairro bairroSelecionado)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Bairro";
            }
            if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Bairro";
                try
                {
                    txtBairro.Text = bairroSelecionado.Nome_Bairro.ToString();
                    toolStripStatusIdBairro.Text = bairroSelecionado.Id_Bairro.ToString();
                    
                }
                catch
                {
                    MessageBox.Show("Nenhum Bairro Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void FrmBairro_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdBairro.Text != "0")
            {
                btnEditarBairro.Enabled = true;
                btnExcluirBairro.Enabled = true;
                btnAdcionarBairro.Enabled = false;
                btnPesquisarBairro.Enabled = false;
            }
        }
        private void ExecutarButoes(int acao, object idbairro, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtBairro, errorProviderBairro).Equals(true)))
            {
                try
                {

                    Bairro bairro = new Bairro();

                    bairro.Acao = acao;
                    bairro.Id_Bairro = Convert.ToInt32(idbairro);
                    bairro.Nome_Bairro = txtBairro.Text;

                    BairroNegocios bairroNegocios = new BairroNegocios();


                    string retorno = bairroNegocios.ManterBairro(bairro);

                    try
                    {
                        int idBairro = Convert.ToInt32(retorno);
                        MessageBox.Show("Bairro " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Bairro!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Bairro!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Bairro!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExcluirBairro_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem Certeza Que Deseja Excluir O Bairro?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            
            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdBairro.Text), "Excluído", "Excluir");
        }

        private void FrmBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }
        private void LimparCampos()
        {
            txtBairro.Clear();

        }

        private void btnPesquisarBairro_Click(object sender, EventArgs e)
        {
            FrmBairroPesquisa frmBairroPesquisa = new FrmBairroPesquisa();
            frmBairroPesquisa.MdiParent = this.MdiParent;
            frmBairroPesquisa.Show();
            this.Close();
        }

        private void btnEditarBairro_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdBairro.Text), "Alterado", "Alterar");
        }
               

        private void btnAdcionarBairro_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }
    }
}

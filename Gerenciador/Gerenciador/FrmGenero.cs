using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmGenero : Form
    {
        public FrmGenero(AcaoTela acaoTela, Genero generoSelecionado)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Genero";
            }
            if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Genero";
                try
                {
                    txtGenero.Text = generoSelecionado.Nome_Genero.ToString();
                    toolStripStatusIdGenero.Text = generoSelecionado.Id_Genero.ToString();

                }
                catch
                {
                    MessageBox.Show("Nenhum Genero Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void LimparCampos()
        {
            txtGenero.Clear();

        }
        private void ExecutarButoes(int acao, object idgenero, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtGenero, errorProviderGenero).Equals(true)))
            {
                try
                {

                    Genero genero = new Genero();

                    genero.Acao = acao;
                    genero.Id_Genero = Convert.ToInt32(idgenero);
                    genero.Nome_Genero = txtGenero.Text;
                   

                    GeneroNegocios generoNegocios = new GeneroNegocios();


                    string retorno = generoNegocios.ManterGenero(genero);

                    try
                    {
                        int idGenero = Convert.ToInt32(retorno);

                        MessageBox.Show("Genero " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Genero!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Genero!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Genero!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FrmGenero_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdGenero.Text != "0")
            {
                btnEditarGenero.Enabled = true;
                btnExcluirGenero.Enabled = true;
                btnAdcionarGenero.Enabled = false;
                btnPesquisarGenero.Enabled = false;
            }
        }

        private void btnAdcionarGenero_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }

        private void btnEditarGenero_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdGenero.Text), "Alterado", "Alterar");
        }

        private void btnExcluirGenero_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir O Genero?", "Atenção",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdGenero.Text), "Excluído", "Excluir");
        }
        private void btnPesquisarGenero_Click(object sender, EventArgs e)
        {
            FrmGeneroPesquisa frmGeneroPesquisa = new FrmGeneroPesquisa();
            frmGeneroPesquisa.MdiParent = this.MdiParent;
            frmGeneroPesquisa.Show();
            this.Close();
        }

        private void FrmGenero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }
    }

}

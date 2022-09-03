using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmMarca : Form
    {
        public FrmMarca(AcaoTela acaoTela, Marca marcaSelecionada)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Marca";
            }
            if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Marca";
                try
                {
                    txtMarca.Text = marcaSelecionada.Nome_Marca.ToString();
                    toolStripStatusIdMarca.Text = marcaSelecionada.Id_Marca.ToString();

                }
                catch
                {
                    MessageBox.Show("Nenhuma Marca Selecionada! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void LimparCampos()
        {
            txtMarca.Clear();

        }
        private void ExecutarButoes(int acao, object idmarca, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtMarca, errorProviderMarca).Equals(true)))
            {
                try
                {

                    Marca marca = new Marca();

                    marca.Acao = acao;
                    marca.Id_Marca = Convert.ToInt32(idmarca);
                    marca.Nome_Marca = txtMarca.Text;

                    MarcaNegocios marcaNegocios = new MarcaNegocios();


                    string retorno = marcaNegocios.ManterMarca(marca);

                    try
                    {
                        int idMarca = Convert.ToInt32(retorno);
                        MessageBox.Show("Marca " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionada"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " a Marca!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " a Marca!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " a Marca!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdMarca.Text != "0")
            {
                btnEditarMarca.Enabled = true;
                btnExcluirMarca.Enabled = true;
                btnAdcionarMarca.Enabled = false;
                btnPesquisarMarca.Enabled = false;
            }
        }

        private void btnAdcionarMarca_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionada", "Adicionar");
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdMarca.Text), "Alterada", "Alterar");
        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir A Marca?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdMarca.Text), "Excluída", "Excluir");
        }

        private void btnPesquisarMarca_Click(object sender, EventArgs e)
        {
            FrmMarcaPesquisa frmMarcaPesquisa = new FrmMarcaPesquisa();
            frmMarcaPesquisa.MdiParent = this.MdiParent;
            frmMarcaPesquisa.Show();
            this.Close();
        }

        private void FrmMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }
    }
}

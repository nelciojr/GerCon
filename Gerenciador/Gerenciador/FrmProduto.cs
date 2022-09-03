using System;
using System.Windows.Forms;
using DTO;
using BLL;
using DbaCon;
using System.Linq;

namespace Gerenciador
{
    public partial class FrmProduto : Form
    {
        DataConexao dataConexao = new DataConexao();
        public FrmProduto(AcaoTela acaoTela, Produto produtoSelecionado)
        {

            InitializeComponent();
            CarregaUnidMedida(AcaoTela.Adicionar);
            CarregaMarca(AcaoTela.Adicionar);
            CarregaGenero(AcaoTela.Adicionar);
            FrmLogin.percorrerControles(this);

            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Produto";
          
            }
             else if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Produto";
                try
                {
                    txtDescricaoProduto.Text = produtoSelecionado.Descricao.ToString();
                    txtDetalhesProduto.Text = produtoSelecionado.Detalhe.ToString();
                    cbxUnidMedidaProduto.SelectedIndex = cbxUnidMedidaProduto.FindStringExact(produtoSelecionado.UnidMedidaProduto.Descricao.ToString());
                    cbxMarcaProduto.SelectedIndex = cbxMarcaProduto.FindStringExact(produtoSelecionado.MarcaProduto.Nome_Marca.ToString());
                    cbxGeneroProduto.SelectedIndex = cbxGeneroProduto.FindStringExact(produtoSelecionado.GeneroProduto.Nome_Genero.ToString());
                    toolStripStatusIdProduto.Text = produtoSelecionado.Id_Produto.ToString();

                }
                catch
                {
                    MessageBox.Show("Nenhum Produto Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        private void FrmProduto_Load(object sender, EventArgs e)
        {
            if (toolStripStatusIdProduto.Text != "0")
            {
                btnEditarProduto.Enabled = true;
                btnExcluirProduto.Enabled = true;
                btnAdcionarProduto.Enabled = false;
                btnPesquisarProduto.Enabled = false;
            
            }
        }
        private void LimparCampos()
        {
            txtDescricaoProduto.Clear();
            txtDetalhesProduto.Clear();
            cbxGeneroProduto.SelectedValue = "";
            cbxMarcaProduto.SelectedValue = "";
            cbxUnidMedidaProduto.SelectedValue = "";

        }
        private void CarregaUnidMedida(AcaoTela acaoTela)
        {
            UnidMedidaNegocios unidMedidaNegocios = new UnidMedidaNegocios();
            UnidMedidaColecao unidMedidaColecao = new UnidMedidaColecao();

            unidMedidaColecao = unidMedidaNegocios.ConsultarUnidMedidaPorNome("");
            cbxUnidMedidaProduto.DataSource = null;
            cbxUnidMedidaProduto.DataSource = unidMedidaColecao;

            cbxUnidMedidaProduto.ValueMember = "Id_UnidMedida";
            cbxUnidMedidaProduto.DisplayMember = "Descricao";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxUnidMedidaProduto.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (unidMedidaColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxUnidMedidaProduto.SelectedValue = unidMedidaColecao.Max(u => u.Id_UnidMedida);
                }
            }

            cbxMarcaProduto.Update();
            cbxMarcaProduto.Refresh();

        }

        private void CarregaMarca(AcaoTela acaoTela)
        {
            MarcaNegocios marcaNegocios = new MarcaNegocios();
            MarcaColecao marcaColecao = new MarcaColecao();

            marcaColecao = marcaNegocios.ConsultarMarcaPorNome("");
            cbxMarcaProduto.DataSource = null;
            cbxMarcaProduto.DataSource = marcaColecao;

            cbxMarcaProduto.ValueMember = "Id_Marca";
            cbxMarcaProduto.DisplayMember = "Nome_Marca";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxMarcaProduto.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (marcaColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxMarcaProduto.SelectedValue = marcaColecao.Max(m => m.Id_Marca);
                }
            }

            cbxMarcaProduto.Update();
            cbxMarcaProduto.Refresh();

        }
        private void CarregaGenero(AcaoTela acaoTela)
        {
            GeneroNegocios generoNegocios = new GeneroNegocios();
            GeneroColecao generoColecao = new GeneroColecao();

            generoColecao = generoNegocios.ConsultarGeneroPorNome("");
            cbxGeneroProduto.DataSource = null;
            cbxGeneroProduto.DataSource = generoColecao;

            cbxGeneroProduto.ValueMember = "Id_Genero";
            cbxGeneroProduto.DisplayMember = "Nome_Genero";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxGeneroProduto.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (generoColecao.Count.Equals(0))
                {
                    return;
                }
                else
                { 
                cbxGeneroProduto.SelectedValue = generoColecao.Max(g => g.Id_Genero);
                }
            }

            cbxGeneroProduto.Update();
            cbxGeneroProduto.Refresh();

        }
        private void ExecutarButoes(int acao, object idproduto, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtDescricaoProduto, errorProviderDescricao) && FrmLogin.validarCampo(txtDetalhesProduto, errorProviderDetalhes) && FrmLogin.validarComboBox(cbxUnidMedidaProduto, errorProviderUnidMedida) && FrmLogin.validarComboBox(cbxMarcaProduto, errorProviderMarca) && FrmLogin.validarComboBox(cbxGeneroProduto, errorProviderGenero)).Equals(true))
            {
                try
                {

                    Produto produto = new Produto();

                    produto.Acao = acao;
                    produto.Id_Produto = Convert.ToInt32(idproduto);
                    produto.Descricao = txtDescricaoProduto.Text;
                    produto.Detalhe = txtDetalhesProduto.Text;

                    produto.UnidMedidaProduto = new UnidMedida();

                    produto.UnidMedidaProduto.Id_UnidMedida = Convert.ToInt32(cbxUnidMedidaProduto.SelectedValue);

                    produto.MarcaProduto = new Marca();

                    produto.MarcaProduto.Id_Marca = Convert.ToInt32(cbxMarcaProduto.SelectedValue);

                    produto.GeneroProduto = new Genero();

                    produto.GeneroProduto.Id_Genero = Convert.ToInt32(cbxGeneroProduto.SelectedValue);

                    
                    ProdutoNegocios produtoNegocios = new ProdutoNegocios();


                    string retorno = produtoNegocios.ManterProduto(produto);

                    try
                    {
                        int idProduto = Convert.ToInt32(retorno);

                        MessageBox.Show("Produto " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                            LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Produto!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Produto!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Produto!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdcionarProduto_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdProduto.Text), "Alterado", "Alterar");
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza Que Deseja Excluir O Usuário?", "Atenção",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            ExecutarButoes(3, Convert.ToInt32(toolStripStatusIdProduto.Text), "Excluído", "Excluir");
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            FrmProdutoPesquisa frmProdutoPesquisa = new FrmProdutoPesquisa();
            frmProdutoPesquisa.MdiParent = this.MdiParent;
            frmProdutoPesquisa.Show();
            this.Close();
        }

        private void btnCancelarProduto_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionarUnidMedida_Click(object sender, EventArgs e)
        {
            FrmUnidMedida frmUnidMedida = new FrmUnidMedida(AcaoTela.Adicionar, null);
            frmUnidMedida.ShowDialog();
            CarregaUnidMedida(AcaoTela.Recarregar);
            
        }

        private void btnAdicionarMarca_Click(object sender, EventArgs e)
        {

            FrmMarca frmMarca = new FrmMarca(AcaoTela.Adicionar, null);
            frmMarca.ShowDialog();
            CarregaMarca(AcaoTela.Recarregar);
            
        }

        private void btnAdicionarGenero_Click(object sender, EventArgs e)
        {
            FrmGenero frmGenero = new FrmGenero(AcaoTela.Adicionar, null);
            frmGenero.ShowDialog();
            CarregaGenero(AcaoTela.Recarregar);
            
        }

        private void FrmProduto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }
    }
}

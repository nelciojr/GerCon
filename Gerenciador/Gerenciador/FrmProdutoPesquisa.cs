using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmProdutoPesquisa : Form
    {
        public FrmProdutoPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewProduto.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ProdutoColecao produtoColecao = new ProdutoColecao();


            produtoColecao = produtoNegocios.ConsultarProdutoPorNome(txtProdutoPesquisa.Text);
            dataGridViewProduto.DataSource = null;
            dataGridViewProduto.DataSource = produtoColecao;

            dataGridViewProduto.Update();
            dataGridViewProduto.Refresh();
        }

        private void SelecionaProduto()
        {
            if (dataGridViewProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProdutoPesquisa.Focus();
                return;
            }

            try
            {
                Produto produtoSelecionado = (dataGridViewProduto.SelectedRows[0].DataBoundItem as Produto);
                FrmProduto frmProduto = new FrmProduto(AcaoTela.Alterar, produtoSelecionado);
                frmProduto.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtProdutoPesquisa.Focus();
            }

        }

        private void txtProdutoPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtProdutoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnProdutoPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaProduto();
        }

        private void dataGridViewProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaProduto();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnProdutoSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaProduto();
        }

        private void btnProdutoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProdutoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void dataGridViewProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Produto data = dataGridViewProduto.Rows[e.RowIndex].DataBoundItem as Produto;

            dataGridViewProduto.Rows[e.RowIndex].Cells["UnidMedidaProduto"].Value = data.UnidMedidaProduto.Descricao;
            dataGridViewProduto.Rows[e.RowIndex].Cells["MarcaProduto"].Value = data.MarcaProduto.Nome_Marca;
            dataGridViewProduto.Rows[e.RowIndex].Cells["GeneroProduto"].Value = data.GeneroProduto.Nome_Genero;
        }

    } 
}

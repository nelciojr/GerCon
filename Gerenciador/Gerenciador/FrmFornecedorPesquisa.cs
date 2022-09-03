using System;
using System.Windows.Forms;
using DTO;
using BLL;


namespace Gerenciador
{
    public partial class FrmFornecedorPesquisa : Form
    {
        public FrmFornecedorPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewFornecedor.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
            FornecedorColecao fornecedorColecao = new FornecedorColecao();


            fornecedorColecao = fornecedorNegocios.ConsultarFornecedorPorNome(txtFornecedorPesquisa.Text);
            dataGridViewFornecedor.DataSource = null;
            dataGridViewFornecedor.DataSource = fornecedorColecao;

            dataGridViewFornecedor.Update();
            dataGridViewFornecedor.Refresh();
        }

        private void SelecionaFornecedor()
        {
            if (dataGridViewFornecedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Fornecedor Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFornecedorPesquisa.Focus();
                return;
            }

            try
            {
                Fornecedor fornecedorSelecionado = (dataGridViewFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);
                FrmFornecedor frmFornecedor = new FrmFornecedor(AcaoTela.Alterar, fornecedorSelecionado);
                frmFornecedor.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtFornecedorPesquisa.Focus();
            }

        }

        private void txtFornecedorPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtFornecedorPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnFornecedorPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnFornecedorSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaFornecedor();
        }

        private void dataGridViewFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaFornecedor();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void dataGridViewFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaFornecedor();
        }

        private void btnFornecedorCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmFornecedorPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }
    }
}

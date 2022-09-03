using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmUnidMedidaPesquisa : Form
    {
        public FrmUnidMedidaPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewUnidMedida.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            UnidMedidaNegocios unidMedidaNegocios = new UnidMedidaNegocios();
            UnidMedidaColecao unidMedidaColecao = new UnidMedidaColecao();

            unidMedidaColecao = unidMedidaNegocios.ConsultarUnidMedidaPorNome(txtUnidMedidaPesquisa.Text);
            dataGridViewUnidMedida.DataSource = null;
            dataGridViewUnidMedida.DataSource = unidMedidaColecao;


            dataGridViewUnidMedida.Update();
            dataGridViewUnidMedida.Refresh();
        }

        private void SelecionaUnidMedida()
        {
            if (dataGridViewUnidMedida.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Unidade de Medida Selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnidMedidaPesquisa.Focus();
                return;
            }

            try
            {

                UnidMedida unidMedidaSelecionada = (dataGridViewUnidMedida.SelectedRows[0].DataBoundItem as UnidMedida);
                FrmUnidMedida frmUnidMedida = new FrmUnidMedida(AcaoTela.Alterar, unidMedidaSelecionada);
                frmUnidMedida.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtUnidMedidaPesquisa.Focus();
            }

        }

        private void txtUnidMedidaPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtUnidMedidaPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnUnidMedidaPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewUnidMedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaUnidMedida();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void dataGridViewUnidMedida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaUnidMedida();
        }

        private void btnUnidMedidaSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaUnidMedida();
        }

        private void btnUnidMedidaCancelar_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void FrmUnidMedidaPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }
    }
}

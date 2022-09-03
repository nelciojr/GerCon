using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmMarcaPesquisa : Form
    {
        public FrmMarcaPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewMarca.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {

            MarcaNegocios marcaNegocios = new MarcaNegocios();
            MarcaColecao marcaColecao = new MarcaColecao();

            marcaColecao = marcaNegocios.ConsultarMarcaPorNome(txtMarcaPesquisa.Text);
            dataGridViewMarca.DataSource = null;
            dataGridViewMarca.DataSource = marcaColecao;


            dataGridViewMarca.Update();
            dataGridViewMarca.Refresh();
        }

        private void SelecionaMarca()
        {
            if (dataGridViewMarca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Marca Selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarcaPesquisa.Focus();
                return;
            }

            try
            {

                Marca marcaSelecionada = (dataGridViewMarca.SelectedRows[0].DataBoundItem as Marca);
                FrmMarca frmMarca = new FrmMarca(AcaoTela.Alterar, marcaSelecionada);
                frmMarca.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtMarcaPesquisa.Focus();
            }

        }

        private void txtMarcaPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtMarcaPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnMarcaPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewMarca_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaMarca();
        }

        private void dataGridViewMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaMarca();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnMarcaSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaMarca();
        }

        private void btnMarcaCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMarcaPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }
    }
}

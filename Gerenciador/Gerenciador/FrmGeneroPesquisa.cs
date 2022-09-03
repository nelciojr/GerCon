using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmGeneroPesquisa : Form
    {
        public FrmGeneroPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewGenero.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            GeneroNegocios generoNegocios = new GeneroNegocios();
            GeneroColecao generoColecao = new GeneroColecao();

            generoColecao = generoNegocios.ConsultarGeneroPorNome(txtGeneroPesquisa.Text);
            dataGridViewGenero.DataSource = null;
            dataGridViewGenero.DataSource = generoColecao;


            dataGridViewGenero.Update();
            dataGridViewGenero.Refresh();
        }

        private void SelecionaGenero()
        {
            if (dataGridViewGenero.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Genero Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGeneroPesquisa.Focus();
                return;
            }

            try
            {

                Genero generoSelecionado = (dataGridViewGenero.SelectedRows[0].DataBoundItem as Genero);
                FrmGenero frmGenero = new FrmGenero(AcaoTela.Alterar, generoSelecionado);
                frmGenero.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtGeneroPesquisa.Focus();
            }

        }

        private void btnGeneroPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtGeneroPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtGeneroPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnGeneroSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaGenero();
        }

        private void dataGridViewGenero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaGenero();
        }

        private void dataGridViewGenero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaGenero();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnGeneroCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmGeneroPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        
    }
    }
}

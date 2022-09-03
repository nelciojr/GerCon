using System;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Linq;

namespace Gerenciador
{
    public partial class FrmResponsavelPesquisa : Form
    {
        public FrmResponsavelPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewResponsavel.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            ResponsavelNegocios responsavelNegocios = new ResponsavelNegocios();
            ResponsavelColecao responsavelColecao = new ResponsavelColecao();


            responsavelColecao = responsavelNegocios.ConsultarResponsavelPorNome(txtResponsavelPesquisa.Text);
            dataGridViewResponsavel.DataSource = null;
            dataGridViewResponsavel.DataSource = responsavelColecao;

            dataGridViewResponsavel.Update();
            dataGridViewResponsavel.Refresh();
        }

        private void SelecionaResponsavel()
        {
            if (dataGridViewResponsavel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Responsável Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResponsavelPesquisa.Focus();
                return;
            }

            try
            {

                Responsavel responsavelSelecionado = (dataGridViewResponsavel.SelectedRows[0].DataBoundItem as Responsavel);
                FrmResponsavel frmResponsavel = new FrmResponsavel(AcaoTela.Alterar, responsavelSelecionado);
                frmResponsavel.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtResponsavelPesquisa.Focus();
            }

        }

        private void txtResponsavelPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtResponsavelPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnResponsavelPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaResponsavel();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void dataGridViewResponsavel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaResponsavel();
        }
        private void btnResponsavelSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaResponsavel();
        }

        private void btnResponsavelCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmResponsavelPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

       
    }
}

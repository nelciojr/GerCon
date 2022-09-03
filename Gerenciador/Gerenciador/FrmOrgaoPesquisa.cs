using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmOrgaoPesquisa : Form
    {
        public FrmOrgaoPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewOrgao.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            OrgaoNegocios orgaoNegocios = new OrgaoNegocios();
            OrgaoColecao orgaoColecao = new OrgaoColecao();


            orgaoColecao = orgaoNegocios.ConsultarOrgaoPorNome(txtOrgaoPesquisa.Text);
            dataGridViewOrgao.DataSource = null;
            dataGridViewOrgao.DataSource = orgaoColecao;

            dataGridViewOrgao.Update();
            dataGridViewOrgao.Refresh();
        }

        private void SelecionaOrgao()
        {
            if (dataGridViewOrgao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Orgão Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrgaoPesquisa.Focus();
                return;
            }

            try
            {
                Orgao orgaoSelecionado = (dataGridViewOrgao.SelectedRows[0].DataBoundItem as Orgao);
                FrmOrgao frmOrgao = new FrmOrgao(AcaoTela.Alterar, orgaoSelecionado);
                frmOrgao.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtOrgaoPesquisa.Focus();
            }

        }

        private void txtOrgaoPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtOrgaoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnOrgaoPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewOrgao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaOrgao();
        }

        private void dataGridViewOrgao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaOrgao();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnOrgaoSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaOrgao();
                
        }

        private void btnOrgaoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOrgaoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void dataGridViewOrgao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Orgao data = dataGridViewOrgao.Rows[e.RowIndex].DataBoundItem as Orgao;

            dataGridViewOrgao.Rows[e.RowIndex].Cells["ResponsavelOrgao"].Value = data.ResponsavelOrgao.Nome_Responsavel;
        }
    }
}

using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmBairroPesquisa : Form
    {
        public FrmBairroPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewBairro.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
           
            BairroNegocios bairroNegocios = new BairroNegocios();
            BairroColecao bairroColecao = new BairroColecao();

            bairroColecao = bairroNegocios.ConsultarBairroPorNome(txtBairroPesquisa.Text);
            dataGridViewBairro.DataSource = null;
            dataGridViewBairro.DataSource = bairroColecao;


            dataGridViewBairro.Update();
            dataGridViewBairro.Refresh();
        }

        private void SelecionaBairro()
        {
            if (dataGridViewBairro.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Bairro Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairroPesquisa.Focus();
                return;
            }

            try
            {

                Bairro bairroSelecionado = (dataGridViewBairro.SelectedRows[0].DataBoundItem as Bairro);
                FrmBairro frmBairro = new FrmBairro(AcaoTela.Alterar, bairroSelecionado);
                frmBairro.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtBairroPesquisa.Focus();
            }

        }

        private void btnBairroPesquisar_Click(object sender, EventArgs e)
        {
           AtualizarGrid();
        }

        private void txtBairroPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtBairroPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnBairroSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaBairro();
        }

        private void dataGridViewBairro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaBairro();
        }
        private void dataGridViewBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaBairro();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
        private void btnBairroCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmBairroPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

      
    }
}

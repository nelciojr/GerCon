using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmDepartamentoPesquisa : Form
    {
        public FrmDepartamentoPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewDepartamento.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            DepartamentoNegocios departamentoNegocios = new DepartamentoNegocios();
           DepartamentoColecao departamentoColecao = new DepartamentoColecao();


            departamentoColecao = departamentoNegocios.ConsultarDepartamentoPorNome(txtDepartamentoPesquisa.Text);
            dataGridViewDepartamento.DataSource = null;
            dataGridViewDepartamento.DataSource = departamentoColecao;

            dataGridViewDepartamento.Update();
            dataGridViewDepartamento.Refresh();
        }

        private void SelecionaDepartamento()
        {
            if (dataGridViewDepartamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Departamento Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDepartamentoPesquisa.Focus();
                return;
            }

            try
            {
                Departamento departamentoSelecionado = (dataGridViewDepartamento.SelectedRows[0].DataBoundItem as Departamento);
                FrmDepartamento frmDepartamento = new FrmDepartamento(AcaoTela.Alterar, departamentoSelecionado);
                frmDepartamento.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtDepartamentoPesquisa.Focus();
            }

        }

        private void txtDepartamentoPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtDepartamentoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnDepartamentoPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaDepartamento();
    
        }

        private void dataGridViewDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaDepartamento();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnDepartamentoSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaDepartamento();
        }

        private void btnDepartamentoCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDepartamentoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void dataGridViewDepartamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Departamento data = dataGridViewDepartamento.Rows[e.RowIndex].DataBoundItem as Departamento;

            dataGridViewDepartamento.Rows[e.RowIndex].Cells["OrgaoDepartamento"].Value = data.OrgaoDepartamento.Nome_Orgao ;
        }
    }
}

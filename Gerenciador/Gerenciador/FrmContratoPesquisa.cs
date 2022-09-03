using System;
using System.Windows.Forms;
using DTO;
using BLL;
namespace Gerenciador
{
    public partial class FrmContratoPesquisa : Form
    {
        public FrmContratoPesquisa(AcaoTela acaoTela, string idUsuario)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dgwContrato.AutoGenerateColumns = false;
            tSSIdUsuario.Text = idUsuario.ToString();
            if (acaoTela.Equals(AcaoTela.Adicionar))
            {
                btnBaixaItens.Enabled = false;
                btnContratoSelecionar.Enabled = false;
            }
            else if (acaoTela.Equals(AcaoTela.Alterar))
            {
                btnBaixaItens.Enabled = false;
                btnContratoItens.Enabled = false;
            }
            else if (acaoTela.Equals(AcaoTela.Excluir))
            {
                btnContratoSelecionar.Enabled = false;
                btnContratoItens.Enabled = false;
            }
        }
        private void AtualizarGrid()
        {

            ContratoNegocios contratoNegocios = new ContratoNegocios();
            ContratoColecao contratoColecao = new ContratoColecao();

            int valorDigitado;
            if (int.TryParse(txtContratoPesquisa.Text, out valorDigitado).Equals(true))
            {
                contratoColecao = contratoNegocios.ConsultarContratoPorNumero(txtContratoPesquisa.Text);
            }
            else
            {
                contratoColecao = contratoNegocios.ConsultarContratoPorFornecedor(txtContratoPesquisa.Text);
            }

            dgwContrato.DataSource = null;
            dgwContrato.DataSource = contratoColecao;


            dgwContrato.Update();
            dgwContrato.Refresh();
        }
        private void SelecionaContrato(AcaoTela acaoTela)
        {
            if (dgwContrato.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Contrato Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContratoPesquisa.Focus();
                return;
            }

            if (acaoTela.Equals(AcaoTela.Alterar))
            {
                try
                {

                    Contrato contratoSelecionado = (dgwContrato.SelectedRows[0].DataBoundItem as Contrato);
                    FrmContrato frmContrato = new FrmContrato(AcaoTela.Alterar, contratoSelecionado, tSSIdUsuario.ToString());
                    frmContrato.MdiParent = this.MdiParent;
                    frmContrato.Show();
                    Close();


                }
                catch
                {
                    txtContratoPesquisa.Focus();
                }
            }
            else if (acaoTela.Equals(AcaoTela.Adicionar))
            {
                try
                {
                    Contrato contratoSelecionado = (dgwContrato.SelectedRows[0].DataBoundItem as Contrato);
                    FrmItensContrato frmItensContrato = new FrmItensContrato(AcaoTela.Adicionar, contratoSelecionado, null,tSSIdUsuario.ToString());
                    frmItensContrato.MdiParent = this.MdiParent;
                    frmItensContrato.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    txtContratoPesquisa.Focus();
                    MessageBox.Show("Detalhe: " + ex);
                }
            }
            else if (acaoTela.Equals(AcaoTela.Excluir))
            {
                try
                {
                    Contrato contratoSelecionado = (dgwContrato.SelectedRows[0].DataBoundItem as Contrato);
                    FrmBaixaItens frmBaixaItens = new FrmBaixaItens(AcaoTela.Adicionar, contratoSelecionado, tSSIdUsuario.ToString());
                    frmBaixaItens.MdiParent = this.MdiParent;
                    frmBaixaItens.Show();
                    Close();
                }
                catch (Exception ex)
                {
                    txtContratoPesquisa.Focus();
                    MessageBox.Show("Detalhe: " + ex);
                }
            }
        }
        private void txtContratoPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtContratoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnContratoPesquisa_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dgwContrato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Contrato data = dgwContrato.Rows[e.RowIndex].DataBoundItem as Contrato;

            dgwContrato.Rows[e.RowIndex].Cells["FornecedorContrato"].Value = data.FornecedorContrato.Razao_Social;
            dgwContrato.Rows[e.RowIndex].Cells["GeneroContrato"].Value = data.GeneroContrato.Nome_Genero;
            dgwContrato.Rows[e.RowIndex].Cells["OrgaoContrato"].Value = data.OrgaoContrato.Nome_Orgao;
           
        }
        
        private void FrmContratoPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void btnContratoSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaContrato(AcaoTela.Alterar);
        }

        private void btnContratoItens_Click(object sender, EventArgs e)
        {
            SelecionaContrato(AcaoTela.Adicionar);
        }
        private void btnBaixaItens_Click(object sender, EventArgs e)
        {
            SelecionaContrato(AcaoTela.Excluir);
        }

        private void dgwContrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnContratoSelecionar.Enabled.Equals(true))
            {
                SelecionaContrato(AcaoTela.Alterar);
            }
           else if (btnContratoItens.Enabled.Equals(true))
            {
                SelecionaContrato(AcaoTela.Adicionar);
            }
            else if (btnBaixaItens.Enabled.Equals(true))
            {
                SelecionaContrato(AcaoTela.Excluir);
            }
        }

        private void dgwContrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btnContratoSelecionar.Enabled.Equals(true))
                {
                    SelecionaContrato(AcaoTela.Alterar);
                }
                else if (btnContratoItens.Enabled.Equals(true))
                {
                    SelecionaContrato(AcaoTela.Adicionar);
                }
                else if (btnBaixaItens.Enabled.Equals(true))
                {
                    SelecionaContrato(AcaoTela.Excluir);
                }
            }
        }

        private void btnCancelarItens_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}

using System.Windows.Forms;
using DTO;
using BLL;
using System.Linq;
using System;

namespace Gerenciador
{
    public partial class FrmEstornoItens : Form
    {
        public FrmEstornoItens(AcaoTela acaoTela, int idContrato, string idUsuario)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            try
            {
                dgwEstornoContrato.AutoGenerateColumns = false;
                tSSIdUsuario.Text = idUsuario.ToString();
                tSSIdContrato.Text = idContrato.ToString();
                AtualizarGrid(Convert.ToInt32(tSSIdContrato.Text), tSSIdContrato.Text);
            }
            catch
            {
                return;
            }
        }
        private void AtualizarGrid(int idContrato, string usuario)
        {

           
            BaixaItensNegocios baixaItensNegocios = new BaixaItensNegocios();
            BaixaItensColecao baixaItensColecao = new BaixaItensColecao();

            UsuariosNegocios usuariosNegocios = new UsuariosNegocios();
            UsuariosColecao usuariosColecao = new UsuariosColecao();

            usuariosColecao = usuariosNegocios.ConsultarUsuariosPorNome(tSSIdUsuario.Text);

            baixaItensColecao = baixaItensNegocios.ConsultarItensporIdCont(idContrato, usuariosColecao[0].Id_Usuario);

            if(baixaItensColecao.Count.Equals(0))
            {

                return;
                
            }
            else
            {
                dgwEstornoContrato.DataSource = null;
                dgwEstornoContrato.DataSource = baixaItensColecao;

                dgwEstornoContrato.Update();
                dgwEstornoContrato.Refresh();


                string valorTotalContrato = CarregaContTotaleSaldo(idContrato);

                tSSIdBaixaItem.Text = baixaItensColecao[0].Id_BaixaItem.ToString();
                tSSIdItem.Text = baixaItensColecao[0].Id_ItemBaixa.Id_Item.ToString();
                txtVMaxEstorno.Text = baixaItensColecao[0].Valor_Baixa.ToString("N2");
                txtQtdeEstorno.Text = baixaItensColecao[0].Qtde_BaixaItem.ToString();
                txtVTotalEstorno.Text = baixaItensColecao[0].Valor_Baixa.ToString("N2");
                txtVUnitEstorno.Text = (Convert.ToDecimal(baixaItensColecao[0].Valor_Baixa) / Convert.ToDecimal(baixaItensColecao[0].Qtde_BaixaItem)).ToString("N2");


                decimal Total = 0;

                for (int i = 0; i < dgwEstornoContrato.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dgwEstornoContrato.Rows[i].Cells["Saldo_BaixaItem"].Value);
                }

                txtTotalEstorno.Text = Total.ToString("N2");
            }
            

        }

        private void dgwEstornoContrato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            BaixaItens baixaItens = dgwEstornoContrato.Rows[e.RowIndex].DataBoundItem as BaixaItens;

            dgwEstornoContrato.Rows[e.RowIndex].Cells["ProdutoItem"].Value = baixaItens.ProdutoItem.Descricao;
            dgwEstornoContrato.Rows[e.RowIndex].Cells["DepartamentoItem"].Value = baixaItens.DepartamentoItem.Nome_Departamento;
        }

        private string CarregaContTotaleSaldo(int idContrato)
        {
            ContratoNegocios contratoNegocios = new ContratoNegocios();
            ContratoColecao contratoColecao = new ContratoColecao();

            contratoColecao = contratoNegocios.ConsultarContValoreSaldo(idContrato);


            txtTotalContrato.Text = contratoColecao[0].Valor_Contrato.ToString("N2");
            txtSaldoContrato.Text = contratoColecao[0].Saldo_Contrato.ToString("N2");

            
            string valorSaldoTotal = contratoColecao[0].Saldo_Contrato.ToString();

            return valorSaldoTotal;

        }
        private void ExecutarButoes(int acao, object idbaixa, string msg, string msg2)
        {
            if ((FrmLogin.validarCampo(txtQtdeEstorno,ePrQtdeEstorno)).Equals(true))
            {
                
                try
                {

                    BaixaItens baixaItens = new BaixaItens();

                    baixaItens.Acao = acao;

                    baixaItens.Id_BaixaItem = Convert.ToInt32(idbaixa);

                    baixaItens.Id_ItemBaixa = new ItensContrato();

                    baixaItens.Id_ItemBaixa.Id_Item = Convert.ToInt32(tSSIdItem.Text);
                    
                  
                    
                    if ((Convert.ToDecimal(txtVMaxEstorno.Text) - Convert.ToDecimal(txtVTotalEstorno.Text)) >= 0)
                    {

                        baixaItens.Qtde_BaixaItem = Convert.ToDecimal(txtQtdeEstorno.Text);
                        baixaItens.Valor_Baixa = Convert.ToDecimal(txtVTotalEstorno.Text);
                        baixaItens.QtdeSaldo_BaixaItem = (((Convert.ToDecimal(txtVMaxEstorno.Text) - Convert.ToDecimal(txtVTotalEstorno.Text))) / Convert.ToDecimal(txtVUnitEstorno.Text));
                        baixaItens.Saldo_BaixaItem = (Convert.ToDecimal(txtVMaxEstorno.Text) - Convert.ToDecimal(txtVTotalEstorno.Text));
                    }
                    else
                    {
                        MessageBox.Show("Valor Superior Ao Valor Máximo Permitido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQtdeEstorno.Clear();
                        txtQtdeEstorno.Focus();
                        return;
                    }

                    baixaItens.ContratoItem = new Contrato();

                    baixaItens.ContratoItem.Id_Contrato = Convert.ToInt32(tSSIdContrato.Text);

                    baixaItens.DepartamentoItem = new Departamento();

                    baixaItens.UsuarioItem = new Usuarios();

                    baixaItens.ProdutoItem = new Produto();

                    BaixaItensNegocios baixaItensNegocios = new BaixaItensNegocios();

                    string retorno = baixaItensNegocios.ManterBaixaItens(baixaItens);

                    try
                    {
                        int idBaixaItens = Convert.ToInt32(retorno);

                        MessageBox.Show(msg + " do Item Realizado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Close();


                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Item!\nDetalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Item!\nPreenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Item!\nPreenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdEstorno_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2,tSSIdBaixaItem.Text, "Estorno", "Estonar");
        }

        private void txtQtdeEstorno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        private void txtQtdeEstorno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtVTotalEstorno.Text = (Convert.ToDecimal(txtVUnitEstorno.Text) * Convert.ToDecimal(txtQtdeEstorno.Text)).ToString("N2");
            }
            catch
            {
                return;

            }
        }

        private void btnCancelarEstorno_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEstornoItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }
    }
}

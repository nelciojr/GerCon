using System.Windows.Forms;
using DTO;
using BLL;
using System.Linq;
using System;


namespace Gerenciador
{
    public partial class FrmBaixaItens : Form
    {
        public FrmBaixaItens(AcaoTela acaoTela, Contrato contratoSelecionado, string idUsuario)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dgwBaixaContrato.AutoGenerateColumns = false;
            txtNContratoBaixa.Text = contratoSelecionado.Numero_Contrato.ToString();
            tSSIdUsuario.Text = idUsuario.ToString();
            tSSIdContrato.Text = contratoSelecionado.Id_Contrato.ToString();
            CarregaDepartamento(contratoSelecionado.OrgaoContrato.Nome_Orgao.ToString());

            if (contratoSelecionado.Contrato_Aditivo.Equals("N"))
            {
                if (acaoTela == AcaoTela.Adicionar)
                {
                    this.Text = "Baixa Itens";
                    AtualizarGrid(AcaoTela.Adicionar, Convert.ToInt32(contratoSelecionado.Id_Contrato), cbxDepBaixa.SelectedText);
                    
                }
                else if (acaoTela == AcaoTela.Alterar)
                {

                }
            }
            else if (contratoSelecionado.Contrato_Aditivo.Equals("S"))
            {

                MessageBox.Show("Esse Contrato Possui Aditivo!", "Impossivel Executar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                chBDataBaixa.Enabled = false;
                mTxtDataBaixa.Enabled = false;
                chBDepBaixa.Enabled = false;
                cbxDepBaixa.Enabled = false;
                chBNNotaBaixa.Enabled = false;
                txtNNotaBaixa.Enabled = false;
                txtQtdeBaixa.Enabled = false;
                btnItensBaixa.Enabled = false;
                btnEstornoBaixa.Enabled = false;
                               
            }
        }
        
        private void LimparCampos()
        {

            txtQtdeBaixa.Clear();
            txtVUnitBaixa.Clear();
            txtVTotalBaixa.Clear();
            txtVMaxBaixa.Clear();
            if (chBDataBaixa.Checked.Equals(false))
                mTxtDataBaixa.Clear();
            if (chBDepBaixa.Checked.Equals(false))
                cbxDepBaixa.SelectedValue = "";
            if (chBNNotaBaixa.Checked.Equals(false))
                txtNNotaBaixa.Clear();
            mTxtDataBaixa.Focus();
        }
        private void AtualizarGrid(AcaoTela acaoTela, int idContrato, string departamento)
        {

            if (acaoTela == AcaoTela.Adicionar)
            {
                ItensContratoNegocios itensContratoNegocios = new ItensContratoNegocios();
                ItensContratoColecao itensContratoColecao = new ItensContratoColecao();

                itensContratoColecao = itensContratoNegocios.ConsultarItensPorIdCont(idContrato, departamento);
                dgwBaixaContrato.DataSource = null;
                dgwBaixaContrato.DataSource = itensContratoColecao;

                dgwBaixaContrato.Update();
                dgwBaixaContrato.Refresh();

               
                if (itensContratoColecao.Count.Equals(0))
                {
                    btnEstornoBaixa.Enabled = false;
                    btnItensBaixa.Enabled = false;
                 
                }
                else
                {
                  btnEstornoBaixa.Enabled = true;
                  btnItensBaixa.Enabled = true;
                    
                }
              
                string valorTotalContrato = CarregaContTotaleSaldo(idContrato);

                decimal Total = 0;

                for (int i = 0; i < dgwBaixaContrato.Rows.Count; i++)
                {
                    Total += Convert.ToDecimal(dgwBaixaContrato.Rows[i].Cells["Saldo_Item"].Value);
                }

                txtTotalBaixa.Text = Total.ToString("N2");
            } 
           else if(acaoTela == AcaoTela.Alterar)
            {
                MessageBox.Show("Esse Contrato Já Possui Aditivo!", "Impossível Continuar", MessageBoxButtons.OK, MessageBoxIcon.Information);            }  
        }

        private void CarregaDepartamento(string orgao)
        {
            DepartamentoNegocios departamentoNegocios = new DepartamentoNegocios();
            DepartamentoColecao departamentoColecao = new DepartamentoColecao();
            
            departamentoColecao = departamentoNegocios.ConsultarDepartamentoPorOrgao(orgao);
            cbxDepBaixa.DataSource = null;
            cbxDepBaixa.DataSource = departamentoColecao;

            cbxDepBaixa.ValueMember = "Id_Departamento";
            cbxDepBaixa.DisplayMember = "Nome_Departamento";
                  
            cbxDepBaixa.SelectedValue = "";
            
        }
        private string CarregaContTotaleSaldo(int idContrato)
        {
            ContratoNegocios contratoNegocios = new ContratoNegocios();
            ContratoColecao contratoColecao = new ContratoColecao();

            contratoColecao = contratoNegocios.ConsultarContValoreSaldo(idContrato);
            
            txtTotalContratoBaixa.Text = contratoColecao[0].Valor_Contrato.ToString("N2");
            txtSaldoContratoBaixa.Text = contratoColecao[0].Saldo_Contrato.ToString("N2");

            string valorSaldoTotal = contratoColecao[0].Saldo_Contrato.ToString();

            return valorSaldoTotal;

        }
        private void SelecionaItemBaixa()
        {
            if (dgwBaixaContrato.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Item Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mTxtDataBaixa.Focus();
                return;
            }

            try
            {
                
                txtQtdeBaixa.Text = dgwBaixaContrato.CurrentRow.Cells["Qtde_SaldoItem"].Value.ToString();
                txtVUnitBaixa.Text = Convert.ToDecimal(dgwBaixaContrato.CurrentRow.Cells["Valor_Unitario"].Value.ToString()).ToString("N2");
                txtVTotalBaixa.Text = Convert.ToDecimal(dgwBaixaContrato.CurrentRow.Cells["Saldo_Item"].Value.ToString()).ToString("N2");
                txtVMaxBaixa.Text = Convert.ToDecimal(dgwBaixaContrato.CurrentRow.Cells["Saldo_Item"].Value.ToString()).ToString("N2");
                tSSIdItem.Text = dgwBaixaContrato.CurrentRow.Cells["Id_Item"].Value.ToString();
                tSSIdDepartamento.Text = dgwBaixaContrato.CurrentRow.Cells["DepartamentoItem"].Value.ToString();
                tSSProduto.Text = dgwBaixaContrato.CurrentRow.Cells["ProdutoItem"].Value.ToString();
            }
            catch
            {
                mTxtDataBaixa.Focus();
                return;
            }

        }
        private void ExecutarButoes(int acao, object idbaixa, string msg, string msg2)
        {
            if ((FrmLogin.validarMTextbox(mTxtDataBaixa, ePrDataBaixa) && FrmLogin.validarComboBox(cbxDepBaixa, ePrDepBaixa) &&
                FrmLogin.validarCampo(txtNNotaBaixa, ePrNNotaBaixa) && FrmLogin.validarCampo(txtQtdeBaixa, ePrQtdeBaixa)).Equals(true))
            {

                UsuariosNegocios usuariosNegocios = new UsuariosNegocios();
                UsuariosColecao usuariosColecao = new UsuariosColecao();

                usuariosColecao = usuariosNegocios.ConsultarUsuariosPorNome(tSSIdUsuario.Text);

                ProdutoNegocios produtoNegocios = new ProdutoNegocios();
                ProdutoColecao produtoColecao = new ProdutoColecao();

                produtoColecao = produtoNegocios.ConsultarProdutoPorNome(tSSProduto.Text);

                DepartamentoNegocios departamentoNegocios = new DepartamentoNegocios();
                DepartamentoColecao departamentoColecao = new DepartamentoColecao();

                departamentoColecao = departamentoNegocios.ConsultarDepartamentoPorNome(tSSIdDepartamento.Text);
               

                try
                {

                    BaixaItens baixaItens = new BaixaItens();

                    baixaItens.Acao = acao;
                    baixaItens.Id_BaixaItem = Convert.ToInt32(idbaixa);

                    baixaItens.Id_ItemBaixa = new ItensContrato();

                    baixaItens.Id_ItemBaixa.Id_Item = Convert.ToInt32(tSSIdItem.Text);

                    baixaItens.Numero_Nota = Convert.ToInt32(txtNNotaBaixa.Text);

                    if (FrmContrato.isValidDate(mTxtDataBaixa.Text).Equals(true))
                    {
                        baixaItens.Data_BaixaItem = mTxtDataBaixa.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencha a Data Corretamente !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mTxtDataBaixa.Clear();
                        mTxtDataBaixa.Focus();
                        return;
                    }
                    
                    baixaItens.Qtde_BaixaItem = Convert.ToDecimal(txtQtdeBaixa.Text);
                    baixaItens.Valor_Baixa = Convert.ToDecimal(txtVTotalBaixa.Text);
                    
                    
                    if ((Convert.ToDecimal(txtVMaxBaixa.Text) - Convert.ToDecimal(txtVTotalBaixa.Text)) >= 0)
                    {

                        baixaItens.QtdeSaldo_BaixaItem = (((Convert.ToDecimal(txtVMaxBaixa.Text) - Convert.ToDecimal(txtVTotalBaixa.Text))) / Convert.ToDecimal(txtVUnitBaixa.Text));
                        baixaItens.Saldo_BaixaItem = (Convert.ToDecimal(txtVMaxBaixa.Text) - Convert.ToDecimal(txtVTotalBaixa.Text));
                    }
                    else
                    {
                        MessageBox.Show("Valor Superior Ao Valor Máximo Permitido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQtdeBaixa.Clear();
                        txtQtdeBaixa.Focus();
                        return;
                    }

                    baixaItens.ContratoItem = new Contrato();
                    
                    baixaItens.ContratoItem.Id_Contrato = Convert.ToInt32(tSSIdContrato.Text);

                    baixaItens.DepartamentoItem = new Departamento();

                    baixaItens.DepartamentoItem.Id_Departamento = departamentoColecao[0].Id_Departamento;

                    baixaItens.ProdutoItem = new Produto();

                    baixaItens.ProdutoItem.Id_Produto = produtoColecao[0].Id_Produto;

                    baixaItens.UsuarioItem = new Usuarios();

                    baixaItens.UsuarioItem.Id_Usuario = usuariosColecao[0].Id_Usuario;

                    BaixaItensNegocios baixaItensNegocios = new BaixaItensNegocios();

                    string retorno = baixaItensNegocios.ManterBaixaItens(baixaItens);

                    try
                    {
                        int idBaixaItens = Convert.ToInt32(retorno);

                        MessageBox.Show( msg +" do Item Realizada com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Baixa"))
                        {
                            departamentoColecao = departamentoNegocios.ConsultarDepartamentoPorId(Convert.ToInt32(cbxDepBaixa.SelectedValue));
                            AtualizarGrid(AcaoTela.Adicionar, Convert.ToInt32(tSSIdContrato.Text), departamentoColecao[0].Nome_Departamento.ToString());
                            LimparCampos();
                            
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível "+msg2+" o Item!\nDetalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgwBaixaContrato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ItensContrato itensContrato = dgwBaixaContrato.Rows[e.RowIndex].DataBoundItem as ItensContrato;

            dgwBaixaContrato.Rows[e.RowIndex].Cells["ProdutoItem"].Value = itensContrato.ProdutoItem.Descricao;
            dgwBaixaContrato.Rows[e.RowIndex].Cells["DepartamentoItem"].Value = itensContrato.DepartamentoItem.Nome_Departamento;
        
        }

        private void btnItensBaixa_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Baixa", "Baixar");
        }
        private void btnEstornoBaixa_Click(object sender, EventArgs e)
        {

            FrmEstornoItens frmEstornoItens = new FrmEstornoItens(AcaoTela.Adicionar, Convert.ToInt32(tSSIdContrato.Text), tSSIdUsuario.Text);
            frmEstornoItens.ShowDialog();
            AtualizarGrid(AcaoTela.Adicionar, Convert.ToInt32(tSSIdContrato.Text), cbxDepBaixa.SelectedText);
            
        }

        private void dgwBaixaContrato_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionaItemBaixa();

        }
        private void dgwBaixaContrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaItemBaixa();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
        private void txtQtdeBaixa_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNNotaBaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtQtdeBaixa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtVTotalBaixa.Text = (Convert.ToDecimal(txtVUnitBaixa.Text) * Convert.ToDecimal(txtQtdeBaixa.Text)).ToString("N2");
            }
            catch
            {
                return;

            }
        }

        private void btnCancelarBaixa_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBaixaItens_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void cbxDepBaixa_SelectedIndexChanged( object sender, EventArgs e)
        {
            if(cbxDepBaixa.SelectedIndex != -1)
            {
                int idDepartamento;
                if (Int32.TryParse(cbxDepBaixa.SelectedValue.ToString(), out idDepartamento).Equals(true))
                {
                    DepartamentoNegocios departamentoNegocios = new DepartamentoNegocios();
                    DepartamentoColecao departamentoColecao = new DepartamentoColecao();

                    departamentoColecao = departamentoNegocios.ConsultarDepartamentoPorId(Convert.ToInt32(cbxDepBaixa.SelectedValue));
                    if (this.Text.Equals("Baixa Itens"))
                    {
                        AtualizarGrid(AcaoTela.Adicionar, Convert.ToInt32(tSSIdContrato.Text), departamentoColecao[0].Nome_Departamento.ToString());
                    }
                    else if(this.Text.Equals("Estorna Itens"))
                    {
                        AtualizarGrid(AcaoTela.Alterar, Convert.ToInt32(tSSIdContrato.Text), departamentoColecao[0].Nome_Departamento.ToString());
                    }
                }

            }
        }

        
        
    }
}

using System.Windows.Forms;
using DTO;
using BLL;
using System.Linq;
using System;

namespace Gerenciador
{
    public partial class FrmItensContrato : Form
    {
        
        public FrmItensContrato(AcaoTela acaoTela, Contrato contratoSelecionado, ItensContrato itenscontratoSelecionado, string idUsuario)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dgwItensContrato.AutoGenerateColumns = false;
            tSSIdUsuario.Text = idUsuario.ToString();
            tSSIdContrato.Text = contratoSelecionado.Id_Contrato.ToString();
            tSSIdGenero.Text = contratoSelecionado.GeneroContrato.Nome_Genero.ToString();
            tSSIdOrgao.Text = contratoSelecionado.OrgaoContrato.Nome_Orgao.ToString();
            
            if (acaoTela.Equals(AcaoTela.Adicionar))
            {
                this.Text = "Adicionar Itens Contrato";
                txtNContratoItens.Text = contratoSelecionado.Numero_Contrato.ToString();
                CarregaDepartamento(AcaoTela.Adicionar, contratoSelecionado.OrgaoContrato.Nome_Orgao.ToString());
                CarregaProduto(AcaoTela.Adicionar, contratoSelecionado.GeneroContrato.Nome_Genero.ToString());
                AtualizarGrid(Convert.ToInt32(contratoSelecionado.Id_Contrato), cbxDepItens.Text);
            
            }
            else if (acaoTela.Equals(AcaoTela.Alterar))
            {
                this.Text = "Editar Contrato";
                try
                {
                }
                catch
                {
                }

            }


        }
        private void LimparCampos()
        {
            cbxProdItens.SelectedValue = "";
            txtQtdeItens.Clear();
            txtValorUnitItens.Clear();
            txtVTotalItens.Clear();
            if (chBDataItens.Checked.Equals(false))
                mTxtDataItens.Clear();
            if (chBDepItens.Checked.Equals(false))
                cbxDepItens.SelectedValue = "";
            mTxtDataItens.Focus();
        }
        private void AtualizarGrid(int idContrato, string departamento)
        {
            ItensContratoNegocios itensContratoNegocios = new ItensContratoNegocios();
            ItensContratoColecao itensContratoColecao = new ItensContratoColecao();

            itensContratoColecao = itensContratoNegocios.ConsultarItensPorIdConteDep(idContrato, departamento);
            dgwItensContrato.DataSource = null;
            dgwItensContrato.DataSource = itensContratoColecao;

            dgwItensContrato.Update();
            dgwItensContrato.Refresh();
            
            if (itensContratoColecao.Count.Equals(0))
            {
                tSSNItem.Text = "0";
                btnBaixaItens.Enabled = false;
            }
            else {

                tSSNItem.Text = (itensContratoColecao.Max(i => i.Numero_Item)).ToString();
                btnBaixaItens.Enabled = true;
            }

            string valorTotalContrato = CarregaContTotaleSaldo(idContrato);

            decimal Total = 0;

            for (int i = 0; i < dgwItensContrato.Rows.Count; i++)
            {
                Total += Convert.ToDecimal(dgwItensContrato.Rows[i].Cells["Valor_Total"].Value);
            }
                        
            txtTotalItens.Text = Total.ToString("N2");

           try
            {
                
                txtVMaxItem.Text = (Convert.ToDecimal(txtItensContratoTotal.Text)- Convert.ToDecimal(txtTotalItens.Text)).ToString("N2");
                     
            }
            catch
            {
                return;
            }
        }
       
        private void CarregaDepartamento(AcaoTela acaoTela, string orgao)
        {
            DepartamentoNegocios departamentoNegocios = new DepartamentoNegocios();
            DepartamentoColecao departamentoColecao = new DepartamentoColecao();

            departamentoColecao = departamentoNegocios.ConsultarDepartamentoPorOrgao(orgao);
            cbxDepItens.DataSource = null;
            cbxDepItens.DataSource = departamentoColecao;

            cbxDepItens.ValueMember = "Id_Departamento";
            cbxDepItens.DisplayMember = "Nome_Departamento";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxDepItens.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (departamentoColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxDepItens.SelectedValue = departamentoColecao.Max(d => d.Id_Departamento);
                }
                    
            }

            cbxDepItens.Update();
            cbxDepItens.Refresh();
        }
        private void CarregaProduto(AcaoTela acaoTela, string genero)
        {
            ProdutoNegocios produtoNegocios = new ProdutoNegocios();
            ProdutoColecao produtoColecao = new ProdutoColecao();

            produtoColecao = produtoNegocios.ConsultarProdutoPorGenero(genero);
            cbxProdItens.DataSource = null;
            cbxProdItens.DataSource = produtoColecao;

            cbxProdItens.ValueMember = "Id_Produto";
            cbxProdItens.DisplayMember = "Descricao";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxProdItens.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (produtoColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxProdItens.SelectedValue = produtoColecao.Max(p => p.Id_Produto);
                }
            }

            cbxProdItens.Update();
            cbxProdItens.Refresh();
        }
        private string CarregaContTotaleSaldo(int idContrato)
        {
            ContratoNegocios contratoNegocios = new ContratoNegocios();
            ContratoColecao contratoColecao = new ContratoColecao();

            contratoColecao = contratoNegocios.ConsultarContValoreSaldo(idContrato);
            txtItensContratoTotal.Text = contratoColecao[0].Valor_Contrato.ToString("N2");
            txtItensContratoSaldo.Text = contratoColecao[0].Saldo_Contrato.ToString("N2");

            string valorSaldoTotal = contratoColecao[0].Saldo_Contrato.ToString();

            return valorSaldoTotal;

        }
        private void ExecutarButoes(int acao, object iditem, string msg, string msg2)
        {
            if ((FrmLogin.validarMTextbox(mTxtDataItens, ePrDataItens) && FrmLogin.validarComboBox(cbxDepItens, ePrDepItens) && 
                 FrmLogin.validarComboBox(cbxProdItens, ePrProdItens) && FrmLogin.validarCampo(txtQtdeItens,ePrQtdeItens) && 
                 FrmLogin.validarCampo(txtValorUnitItens,ePrVUnitItens)).Equals(true))
            {

                UsuariosNegocios usuariosNegocios = new UsuariosNegocios();
                UsuariosColecao usuariosColecao = new UsuariosColecao();

                usuariosColecao = usuariosNegocios.ConsultarUsuariosPorNome(tSSIdUsuario.Text);

                GeneroNegocios generoNegocios = new GeneroNegocios();
                GeneroColecao generoColecao = new GeneroColecao();

                generoColecao = generoNegocios.ConsultarGeneroPorNome(tSSIdGenero.Text);

                try
                {

                    ItensContrato itenscontrato = new ItensContrato();

                    itenscontrato.Acao = acao;
                    itenscontrato.Id_Item = Convert.ToInt32(iditem);                    
                    itenscontrato.Qtde_Item = Convert.ToDecimal(txtQtdeItens.Text);
                    itenscontrato.Preco_Unitario = Convert.ToDecimal(txtValorUnitItens.Text);
                                       
                    if ((Convert.ToDecimal(txtVMaxItem.Text) - Convert.ToDecimal(txtVTotalItens.Text)) >= 0)
                    {
                        itenscontrato.Preco_Total = Convert.ToDecimal(txtVTotalItens.Text);
                    }
                    else
                    {
                        MessageBox.Show("Valor Superior Ao Valor Máximo Permitido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtQtdeItens.Clear();
                        txtValorUnitItens.Clear();
                        txtVTotalItens.Clear();
                        txtQtdeItens.Focus();
                        return;
                    }


                    itenscontrato.Numero_Item = Convert.ToInt32(tSSNItem.Text) + 1;
                   
                    
                    if (FrmContrato.isValidDate(mTxtDataItens.Text).Equals(true))
                     {
                        itenscontrato.Data_Item = mTxtDataItens.Text;
                     }
                     else
                     {
                        MessageBox.Show("Preencha a Data Corretamente !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        mTxtDataItens.Clear();
                        mTxtDataItens.Focus();
                        return;
                     }
                    itenscontrato.Saldo_Item = Convert.ToDecimal(txtVTotalItens.Text);
                    itenscontrato.Qtde_SaldoItem = Convert.ToDecimal(txtQtdeItens.Text);

                    itenscontrato.ContratoItem = new Contrato();

                    itenscontrato.ContratoItem.Id_Contrato = Convert.ToInt32(tSSIdContrato.Text);

                    itenscontrato.ProdutoItem = new Produto();

                    itenscontrato.ProdutoItem.Id_Produto =  Convert.ToInt32(cbxProdItens.SelectedValue);

                    itenscontrato.DepartamentoItem = new Departamento();

                    itenscontrato.DepartamentoItem.Id_Departamento = Convert.ToInt32(cbxDepItens.SelectedValue);

                    itenscontrato.GeneroItem = new Genero();

                    itenscontrato.GeneroItem.Id_Genero = generoColecao[0].Id_Genero;

                    itenscontrato.UsuarioItem = new Usuarios();

                    itenscontrato.UsuarioItem.Id_Usuario = usuariosColecao[0].Id_Usuario;

                    ItensContratoNegocios itensContratoNegocios = new ItensContratoNegocios();

                    string retorno = itensContratoNegocios.ManterItensContrato(itenscontrato);

                    try
                    {
                        int idItensContrato = Convert.ToInt32(retorno);

                        MessageBox.Show("Item do Contrato " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                        {
                            AtualizarGrid(Convert.ToInt32(tSSIdContrato.Text), "");
                            LimparCampos();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Item do Contrato!\nDetalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                  MessageBox.Show("Não foi Possível " + msg2 + " o Item do Contrato!\nPreenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Item do Contrato!\nPreenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
       private void txtQtdeItens_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtVTotalItens.Text = (Convert.ToDecimal(txtValorUnitItens.Text) * Convert.ToDecimal(txtQtdeItens.Text)).ToString("N2");
            }
            catch
            {
                return;
              
            }
        }

        private void txtValorUnitItens_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtVTotalItens.Text = (Convert.ToDecimal(txtValorUnitItens.Text) * Convert.ToDecimal(txtQtdeItens.Text)).ToString("N2");
            }
            catch
            {
                return;
             
            }
        }

        private void btnAdDepItens_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmDepartamento = new FrmDepartamento(AcaoTela.Adicionar, null);
            frmDepartamento.ShowDialog();
            CarregaDepartamento(AcaoTela.Recarregar, tSSIdOrgao.Text);
        }

        private void btnAdProdItens_Click(object sender, EventArgs e)
        {
           FrmProduto frmProduto = new FrmProduto(AcaoTela.Adicionar, null);
           frmProduto.ShowDialog();
           CarregaProduto(AcaoTela.Recarregar, tSSIdGenero.Text);
        }

        private void txtQtdeItens_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValorUnitItens_KeyPress(object sender, KeyPressEventArgs e)
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
        private void btnAdItensContrato_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }
        private void btnBaixaItens_Click(object sender, EventArgs e)
        {
            ContratoNegocios contratoNegocios = new ContratoNegocios();
            ContratoColecao contratoSelecionado = new ContratoColecao();

            contratoSelecionado = contratoNegocios.ConsultarContratoPorID(Convert.ToInt32(tSSIdContrato.Text));
            
            FrmBaixaItens frmBaixaItens = new FrmBaixaItens(AcaoTela.Adicionar, contratoSelecionado[0], tSSIdUsuario.ToString());
            frmBaixaItens.MdiParent = this.MdiParent;
            frmBaixaItens.Show();
            Close();
        }

        private void dgwItensContrato_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ItensContrato itensContrato = dgwItensContrato.Rows[e.RowIndex].DataBoundItem as ItensContrato;

            dgwItensContrato.Rows[e.RowIndex].Cells["Id_Produto"].Value = itensContrato.ProdutoItem.Descricao;
            dgwItensContrato.Rows[e.RowIndex].Cells["DepartamentoItem"].Value = itensContrato.DepartamentoItem.Nome_Departamento;

        }
        private void btnCancelarItens_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmItensContrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

       
    }

}

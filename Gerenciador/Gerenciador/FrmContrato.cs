using System.Windows.Forms;
using DTO;
using BLL;
using DbaCon;
using System.Linq;
using System;
using System.Globalization;
using Microsoft.Reporting.WebForms;
using System.IO;
using System.Diagnostics;

namespace Gerenciador
{
    public partial class FrmContrato : Form
    {
        DataConexao dataConexao = new DataConexao();
        byte[] bytePdf { set; get; }
        public FrmContrato(AcaoTela acaoTela, Contrato contratoSelecionado, string idusario)
        {
            InitializeComponent();
            tSSIdUsuario.Text = idusario.ToString();
            FrmLogin.percorrerControles(this);
            AplicarEventos(txtContratoTotal);
            CarregaOrgao(AcaoTela.Adicionar);
            CarregaFornecedor(AcaoTela.Adicionar);
            CarregaModalidade();
            CarregaGenero(AcaoTela.Adicionar);
            
            if (acaoTela == AcaoTela.Adicionar) 
            {
                this.Text = "Adicionar Contrato";
                btnEditarContrato.Enabled = false;
                btnAdicionarItens.Enabled = false;

            }
            else if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar Contrato";
                try
                {
                    ItensContratoNegocios itensContratoNegocios = new ItensContratoNegocios();
                    ItensContratoColecao itensContratoColecao = new ItensContratoColecao();

                    itensContratoColecao = itensContratoNegocios.ConsultarItensPorIdCont(Convert.ToInt32(contratoSelecionado.Id_Contrato), "");

                    txtNContrato.Text = contratoSelecionado.Numero_Contrato.ToString();
                    cbxAnoExercicio.SelectedIndex = cbxAnoExercicio.FindStringExact(contratoSelecionado.Ano_Exercicio.ToString());
                    mTxtDataInicial.Text = contratoSelecionado.Data_Inicial.ToString();
                    mTxtDataFinal.Text = contratoSelecionado.Data_Final.ToString();
                    cbxOrgao.SelectedIndex = cbxOrgao.FindStringExact(contratoSelecionado.OrgaoContrato.Nome_Orgao.ToString());
                    cbxForncedor.SelectedIndex = cbxForncedor.FindStringExact(contratoSelecionado.FornecedorContrato.Razao_Social.ToString());
                    cbxModalidade.SelectedIndex = cbxModalidade.FindStringExact(contratoSelecionado.ModalidadeContrato.Nome_Modalidade.ToString());
                    cbxGenero.SelectedIndex = cbxGenero.FindStringExact(contratoSelecionado.GeneroContrato.Nome_Genero.ToString());
                    txtNLicitacao.Text = contratoSelecionado.Numero_Licitacao.ToString();
                    txtHistorico.Text = contratoSelecionado.Historico_Contrato.ToString();
                    txtLocalArquivo.Text = contratoSelecionado.Arquivo_Contrato.ToString();
                    txtContratoTotal.Text = double.Parse(contratoSelecionado.Valor_Contrato.ToString()).ToString("C2");
                    txtContratoSaldo.Text = double.Parse(contratoSelecionado.Saldo_Contrato.ToString()).ToString("C2");
                    tSSIdContrato.Text = contratoSelecionado.Id_Contrato.ToString();
                    bytePdf = contratoSelecionado.Contrato_Byte;
                   
                    if (itensContratoColecao.Count.Equals(0))
                    {
                        btnEditarContrato.Enabled = true;
                        btnAdicionarItens.Enabled = true;
                        btnAdicionarContrato.Enabled = false;
                    }
                    else
                    {
                       
                        txtNContrato.Enabled = false;
                        cbxAnoExercicio.Enabled = false;
                        mTxtDataInicial.Enabled = false;
                        mTxtDataFinal.Enabled = false;
                        cbxOrgao.Enabled = false;
                        cbxForncedor.Enabled = false;
                        cbxModalidade.Enabled = false;
                        cbxGenero.Enabled = false;
                        txtNLicitacao.Enabled = false;
                        txtContratoTotal.Enabled = false;
                        txtContratoSaldo.Enabled = false;
                        btnEditarContrato.Enabled = true;
                        btnAdicionarItens.Enabled = true;
                        btnAdicionarContrato.Enabled = false;
                        btnAdOrgaoContrato.Enabled = false;
                        btnAdFornecedorContrato.Enabled = false;
                        btnAdGeneroContrato.Enabled = false;
                    }

                }
                catch
                {
                    MessageBox.Show("Nenhum Contrato Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }


        }
       public static void RetornarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != "")
            {
                txt.Text = double.Parse(txt.Text).ToString("C2");
            }
            else
                return;
        }
        public String ValorReal(string txt)
        {
           txt = txt.Replace("R$", "").Trim();

            return txt;
        }
        public static void TirarMascara(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("R$", "").Trim();
        }
        public static void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }
        public static void AplicarEventos(TextBox txt)
        {
            txt.Enter += TirarMascara;
            txt.Leave += RetornarMascara;
            txt.KeyPress += ApenasValorNumerico;
        }

        private void LimparCampos()
        {
            txtNContrato.Clear();
            cbxAnoExercicio.SelectedItem = "";
            mTxtDataInicial.Clear();
            mTxtDataFinal.Clear();
            cbxOrgao.SelectedValue = "";
            cbxForncedor.SelectedValue = "";
            cbxModalidade.SelectedValue = "";
            cbxGenero.SelectedValue = "";
            txtNLicitacao.Clear();
            txtHistorico.Clear();
            txtLocalArquivo.Clear();
            txtContratoTotal.Clear();
            txtContratoSaldo.Clear();
        }
        private void CarregaOrgao(AcaoTela acaoTela)
        {
            OrgaoNegocios orgaoNegocios = new OrgaoNegocios();
            OrgaoColecao orgaoColecao = new OrgaoColecao();

            orgaoColecao = orgaoNegocios.ConsultarOrgaoPorNome("");
            cbxOrgao.DataSource = null;
            cbxOrgao.DataSource = orgaoColecao;

            cbxOrgao.ValueMember = "Id_Orgao";
            cbxOrgao.DisplayMember = "Nome_Orgao";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxOrgao.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (orgaoColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxOrgao.SelectedValue = orgaoColecao.Max(o => o.Id_Orgao);
                }
            }

            cbxOrgao.Update();
            cbxOrgao.Refresh();

        }
        private void CarregaFornecedor(AcaoTela acaoTela)
        {
            FornecedorNegocios fornecedorNegocios = new FornecedorNegocios();
            FornecedorColecao fornecedorColecao = new FornecedorColecao();

            fornecedorColecao = fornecedorNegocios.ConsultarFornecedorPorNome("");
            cbxForncedor.DataSource = null;
            cbxForncedor.DataSource = fornecedorColecao;

            cbxForncedor.ValueMember = "Id_Fornecedor";
            cbxForncedor.DisplayMember = "Razao_Social";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxForncedor.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (fornecedorColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxForncedor.SelectedValue = fornecedorColecao.Max(g => g.Id_Fornecedor);
                }
            }

            cbxForncedor.Update();
            cbxForncedor.Refresh();

        }
        private void CarregaModalidade()
        {
            ModalidadeNegocios modalidadeNegocios = new ModalidadeNegocios();
            ModalidadeColecao modalidadeColecao = new ModalidadeColecao();

            modalidadeColecao = modalidadeNegocios.ConsultarModalidadePorNome("");
            cbxModalidade.DataSource = null;
            cbxModalidade.DataSource = modalidadeColecao;

            cbxModalidade.ValueMember = "Id_Modalidade";
            cbxModalidade.DisplayMember = "Nome_Modalidade";

            cbxModalidade.SelectedValue = "";

            cbxModalidade.Update();
            cbxModalidade.Refresh();

        }
        private void CarregaGenero(AcaoTela acaoTela)
        {
            GeneroNegocios generoNegocios = new GeneroNegocios();
            GeneroColecao generoColecao = new GeneroColecao();

            generoColecao = generoNegocios.ConsultarGeneroPorNome("");
            cbxGenero.DataSource = null;
            cbxGenero.DataSource = generoColecao;

            cbxGenero.ValueMember = "Id_Genero";
            cbxGenero.DisplayMember = "Nome_Genero";

            if (acaoTela == AcaoTela.Adicionar)
            {
                cbxGenero.SelectedValue = "";
            }
            else if (acaoTela == AcaoTela.Recarregar)
            {
                if (generoColecao.Count.Equals(0))
                {
                    return;
                }
                else
                {
                    cbxGenero.SelectedValue = generoColecao.Max(g => g.Id_Genero);
                }
            }

            cbxGenero.Update();
            cbxGenero.Refresh();

        }
        private void txtNContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }

        }

        private void txtNLicitacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }
        public static bool isValidDate(string strDate)
        {
            DateTime date;
            if (DateTime.TryParseExact(strDate, "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out date))
             return true;

            else
             return false;
            
        }
        public static byte[] ContratoByte(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            byte[] bytecontrato = br.ReadBytes((int)fs.Length);

            br.Close();
            fs.Close();

            return bytecontrato;
        }

        public static string ContratoPDF(byte[] arquivoPDF)
        {

            FileStream fileStreamPDF = null;

            string nomeArquivoPDF = Path.GetTempPath() + "Contrato_" + DateTime.Now.ToString("dd_MM_yyy-HH_mm_ss")+".pdf";

            fileStreamPDF = new FileStream(nomeArquivoPDF, FileMode.Create);
            fileStreamPDF.Write(arquivoPDF, 0, arquivoPDF.Length);
            fileStreamPDF.Close();
            Process.Start(nomeArquivoPDF);
            return nomeArquivoPDF;
        }

        private void ExecutarButoes(int acao, object idcontrato, string msg, string msg2)
        {
           
            if ((FrmLogin.validarCampo(txtNContrato, ePrNContrato) && FrmLogin.validarComboBox(cbxAnoExercicio,ePrAnoExercicio) && 
                FrmLogin.validarMTextbox(mTxtDataInicial, ePrDataInicial) && FrmLogin.validarMTextbox(mTxtDataFinal, ePrDataFinal) && 
                FrmLogin.validarComboBox(cbxOrgao,ePrOrgao) && FrmLogin.validarComboBox(cbxForncedor, ePrFornecedor) &&
                FrmLogin.validarComboBox(cbxModalidade,ePrModalidade) && FrmLogin.validarComboBox(cbxGenero, ePrGenero) &&
                FrmLogin.validarCampo(txtContratoTotal, ePrContratoTotal)).Equals(true))
             {
           

                UsuariosNegocios usuariosNegocios = new UsuariosNegocios();
                UsuariosColecao usuariosColecao = new UsuariosColecao();

                usuariosColecao = usuariosNegocios.ConsultarUsuariosPorNome(tSSIdUsuario.Text);

                try
                {

                    

                    Contrato contrato = new Contrato();

                    contrato.Acao = acao;
                    
                    contrato.Id_Contrato = Convert.ToInt32(idcontrato);
                    
                    contrato.Contrato_Aditivo = "N";
                    
                    contrato.ModalidadeContrato = new Modalidade();

                    contrato.ModalidadeContrato.Id_Modalidade = Convert.ToInt32(cbxModalidade.SelectedValue);

                    contrato.Numero_Contrato = txtNContrato.Text;
                    contrato.Numero_Licitacao = txtNLicitacao.Text;
                    contrato.Ano_Exercicio = Convert.ToString(cbxAnoExercicio.SelectedItem);

                    if ((isValidDate(mTxtDataInicial.Text) && isValidDate(mTxtDataFinal.Text)).Equals(true))
                    {

                        DateTime dInicio = DateTime.ParseExact(mTxtDataInicial.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        DateTime dFinal = DateTime.ParseExact(mTxtDataFinal.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);


                        if (dInicio <= dFinal)
                        {
                            contrato.Data_Inicial = mTxtDataInicial.Text;
                            contrato.Data_Final = mTxtDataFinal.Text;
                        }
                        else
                        {
                            MessageBox.Show("Data Final Menor que a Data Inicial!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            mTxtDataInicial.Clear();
                            mTxtDataFinal.Clear();
                            mTxtDataInicial.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha a Data Inicial ou Final Corretamente !", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                     
                 
                    contrato.OrgaoContrato = new Orgao();

                    contrato.OrgaoContrato.Id_Orgao = Convert.ToInt32(cbxOrgao.SelectedValue);

                    contrato.FornecedorContrato = new Fornecedor();

                    contrato.FornecedorContrato.Id_Fornecedor = Convert.ToInt32(cbxForncedor.SelectedValue);

                    contrato.ModalidadeContrato = new Modalidade();

                    contrato.ModalidadeContrato.Id_Modalidade = Convert.ToInt32(cbxModalidade.SelectedValue);

                    contrato.GeneroContrato = new Genero();

                    contrato.GeneroContrato.Id_Genero = Convert.ToInt32(cbxGenero.SelectedValue);

                    contrato.Numero_Licitacao = txtNLicitacao.Text;
                    contrato.Historico_Contrato = txtHistorico.Text;
                    
                    if (File.Exists(txtLocalArquivo.Text))
                    {
                        contrato.Contrato_Byte = ContratoByte(txtLocalArquivo.Text);
                    }

                    var fileName = Path.GetFileName(txtLocalArquivo.Text);

                    contrato.Arquivo_Contrato = fileName.ToString();

                    contrato.Valor_Contrato = Convert.ToDecimal(ValorReal(txtContratoTotal.Text));
                    contrato.Saldo_Contrato = Convert.ToDecimal(ValorReal(txtContratoSaldo.Text));

                    contrato.UsuarioContrato = new Usuarios();
                                     
                    contrato.UsuarioContrato.Id_Usuario = usuariosColecao[0].Id_Usuario;

                    
                    ContratoNegocios contratoNegocios = new ContratoNegocios();


                    string retorno = contratoNegocios.ManterContrato(contrato);

                    try
                    {
                        int idContrato = Convert.ToInt32(retorno);

                        MessageBox.Show("Contrato " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                        {
                            LimparCampos();
                            txtNContrato.Focus();
                        }
                        else
                        {
                            LimparCampos();
                            txtNContrato.Focus();
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Contrato!\nDetalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Não foi Possível " + msg2 + " o Contrato!\nPreenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Contrato!\nPreenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAdicionarContrato_Click(object sender, EventArgs e)
        {
            
            ExecutarButoes(1, null, "Adicionado", "Adicionar");
        }
        private void btnEditarContrato_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(tSSIdContrato.Text), "Alterado", "Alterar");
        }
        private void btnAdOrgaoContrato_Click(object sender, EventArgs e)
        {
            FrmOrgao frmOrgao = new FrmOrgao(AcaoTela.Adicionar, null);
            frmOrgao.ShowDialog();
            CarregaOrgao(AcaoTela.Recarregar);
        }
        private void btnAdFornecedorContrato_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new FrmFornecedor(AcaoTela.Adicionar, null);
            frmFornecedor.ShowDialog();
            CarregaFornecedor(AcaoTela.Recarregar);
        }

        private void btnAdGeneroContrato_Click(object sender, EventArgs e)
        {
            FrmGenero frmGenero = new FrmGenero(AcaoTela.Adicionar, null);
            frmGenero.ShowDialog();
            CarregaGenero(AcaoTela.Recarregar);
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            ContratoNegocios contratoNegocios = new ContratoNegocios();
            ContratoColecao contratoSelecionado = new ContratoColecao();

            contratoSelecionado = contratoNegocios.ConsultarContratoPorID(Convert.ToInt32(tSSIdContrato.Text));

            FrmItensContrato frmItensContrato = new FrmItensContrato(AcaoTela.Adicionar, contratoSelecionado[0], null, tSSIdUsuario.ToString());
            frmItensContrato.MdiParent = this.MdiParent;
            frmItensContrato.Show();
            this.Close();
                    
        }

        private void btnPesquisarContrato_Click(object sender, EventArgs e)
        {
            FrmContratoPesquisa frmContratoPesquisa = new FrmContratoPesquisa(AcaoTela.Alterar ,tSSIdUsuario.ToString());
            frmContratoPesquisa.MdiParent = MdiParent;
            frmContratoPesquisa.Show();
            this.Close();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(bytePdf == null)
                return;
            else
                ContratoPDF(bytePdf);
        }
        private void txtContratoTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtContratoSaldo.Text = txtContratoTotal.Text;
            }
            catch
            {
                txtContratoSaldo.Text = "0,00";
                return;

            }
        }
     
        private void btnLocalArquivo_Click(object sender, EventArgs e)
        {
            oFDContratoPDF.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            oFDContratoPDF.Title = "Por favor selecione o Arquivo PDF!";
            if (oFDContratoPDF.ShowDialog().Equals(DialogResult.OK))
            {
                txtLocalArquivo.Text = oFDContratoPDF.FileName.ToString();
            }
        }
        private void btnCancelarContrato_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmContrato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }

      
    }
}

using BLL;
using DTO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            percorrerControles(this);
        }

        public void Gerenciador()
        {
            UsuariosNegocios usuariosNegocios = new UsuariosNegocios();
            UsuariosColecao usuariosColecao = new UsuariosColecao();

            if ((validarCampo(txtLogin, errorProviderLogin) && validarCampo(txtSenha, errorProviderSenha)).Equals(true))
            {
                usuariosColecao = usuariosNegocios.ConsultarUsuariosPorNome(txtLogin.Text);
               
                try
                {

                    if (txtLogin.Text.ToUpper().Equals(usuariosColecao[0].Login.ToUpper()) && txtSenha.Text.Equals(usuariosColecao[0].Senha))
                    {
                        

                        if (usuariosColecao[0].TipoUsuario.Nome_Tipo.Equals("Inativo"))
                        {
                            DialogResult senhalogin = MessageBox.Show("Usuário Inativo!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtLogin.Focus();

                        }
                        else
                        {
                            this.Hide();
                            FrmMenus frmMenus = new FrmMenus(CultureInfo.InvariantCulture.TextInfo.ToTitleCase(usuariosColecao[0].Login));
                            frmMenus.ShowDialog();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        DialogResult senhalogin = MessageBox.Show("Usuário e/ou Senha inválido(s)!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLogin.Focus();
                    }                   

                }

                catch
                {
                    DialogResult senhalogin = MessageBox.Show("Usuário e/ou Senha inválido(s)!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLogin.Focus();
                }



            }
            else
            {

                MessageBox.Show("Preencha todos os campos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void percorrerControles(Control _ctrl)
        {
            if (_ctrl.HasChildren)
            {
                foreach (Control _child in _ctrl.Controls)
                {
                    if (_ctrl.HasChildren)
                        percorrerControles(_child);
                }
            }
            else
            {
                ///Não funciona para Numeric Up Down
                if (_ctrl is TextBox ||
                _ctrl is MaskedTextBox ||
                _ctrl is ListBox ||
                _ctrl is CheckBox ||
                _ctrl is TabPage ||
                _ctrl is DateTimePicker ||
                _ctrl is ComboBox)
                {
                    /// inibe a ação do Enter para evitar o comportamento de
                    /// Accept em alguns casos
                    _ctrl.KeyDown += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                            e.SuppressKeyPress = true;
                    };
                    /// adiciona a tratativa à tecla Enter e envia o TAB para
                    /// promover a navegação
                    _ctrl.KeyUp += delegate (object sender, KeyEventArgs e)
                    {
                        if (e.KeyCode == Keys.Enter)
                        {
                            // SendKeys.Send("{TAB}");
                            _ctrl.FindForm().SelectNextControl(_ctrl, true, true, true, false);
                        }
                    };
                }
            }
        }
        public static bool validarCampo(TextBox textBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(textBox.Text))
            {
                errorProvider.SetError(textBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(textBox, "Preencha Todos os Campos!");
                return false;

            }
        }

        public static bool validarMTextbox(MaskedTextBox maskedTextBox, ErrorProvider errorProvider)
        {
            if ( maskedTextBox.Text.Contains(" ") )
            {
                errorProvider.SetError(maskedTextBox, "Preencha Todos os Campos!");
                return false;
                              
            }
            else
            {
                errorProvider.SetError(maskedTextBox, "");
                return true;

            }
        }

        public static bool validarComboBox(ComboBox comboBox, ErrorProvider errorProvider)
        {
            if (!String.IsNullOrWhiteSpace(comboBox.Text))
            {
                errorProvider.SetError(comboBox, "");
                return true;
            }
            else
            {
                errorProvider.SetError(comboBox, "Preencha Todos os Campos!");
                return false;

            }
        }
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {

            Gerenciador();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult fecharJanela = MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (fecharJanela == DialogResult.OK)
            {
                
                Application.Exit();
             }
            return;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Gerenciador();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }
    }
}

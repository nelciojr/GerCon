using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios(AcaoTela acaoTela, Usuarios usuarioSelecionado)
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            CarregaTipo("");

            if (acaoTela == AcaoTela.Adicionar)
            {
                this.Text = "Adicionar Usuário";

                cbxTipo.SelectedValue= "";

            }
            if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Editar ou Excluir Usuário";

                try
                {
                    
                    txtNome.Text = usuarioSelecionado.Nome_Usuario.ToString();
                    txtUsuario.Text = usuarioSelecionado.Login.ToString();
                    txtSenha.Text = usuarioSelecionado.Senha.ToString();
                    cbxTipo.SelectedIndex = cbxTipo.FindStringExact(usuarioSelecionado.TipoUsuario.Nome_Tipo.ToString());
                    toolStripStatusIdUsuario.Text = usuarioSelecionado.Id_Usuario.ToString();
                    
                }
                catch
                {
                    MessageBox.Show("Nenhum Usuário Selecionado! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            

        }
        private void FrmUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void CarregaTipo(string nomedotipo)
        {
            TipoNegocios tipoNegocios = new TipoNegocios();
            TipoColecao tipoColecao = new TipoColecao();
           
            tipoColecao = tipoNegocios.ConsultarTipoPorNome(nomedotipo);
            cbxTipo.Items.Clear();
            cbxTipo.DataSource = null;
            cbxTipo.DataSource = tipoColecao;

            cbxTipo.ValueMember = "Id_Tipo";
            cbxTipo.DisplayMember = "Nome_Tipo";
            
            cbxTipo.Update();
            cbxTipo.Refresh();
           
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
           
           
            if (toolStripStatusIdUsuario.Text != "0")
            {
                btnEditarUsuario.Enabled    = true;
                btnAdcionarUsuario.Enabled  = false;
                btnPesquisarUsuario.Enabled = false;
               
            }

        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            cbxTipo.SelectedValue = " ";
            txtNome.Focus();
        }
        private void ExecutarButoes(int acao, object idusuario, string msg, string msg2)
        {
            
            if ((FrmLogin.validarCampo(txtNome, errorProviderNome) && FrmLogin.validarCampo(txtUsuario, errorProviderUsuario) && FrmLogin.validarCampo(txtSenha, errorProviderSenha) && FrmLogin.validarComboBox(cbxTipo, errorProviderTipo).Equals(true)))
            {

                try
                {
                    Usuarios usuarios = new Usuarios();
                    

                    usuarios.Acao = acao;
                    usuarios.Id_Usuario = Convert.ToInt32(idusuario);
                    usuarios.Nome_Usuario = txtNome.Text;
                    usuarios.Login = txtUsuario.Text;
                    usuarios.Senha = txtSenha.Text;

                    usuarios.TipoUsuario = new Tipo();

                    usuarios.TipoUsuario.Id_Tipo = Convert.ToInt32(cbxTipo.SelectedValue);
                    
                    UsuariosNegocios usuariosNegocios = new UsuariosNegocios();

                    string retorno = usuariosNegocios.ManterUsuarios(usuarios);

                    try
                    {
                        int idUsuarios = Convert.ToInt32(retorno);

                        MessageBox.Show("Usuário " + msg + " com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        if (msg.Equals("Adicionado"))
                          LimparCampos();
                        else
                            this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi Possível " + msg2 + " o Usuário!\n Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               }
               catch
               {
                   MessageBox.Show("Não foi Possível " + msg2 + " o Usuário!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   cbxTipo.Focus();
                }

            }
            else
            {
                MessageBox.Show("Não foi Possível " + msg2 + " o Usuário!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdcionarUsuario_Click(object sender, EventArgs e)
        {
            ExecutarButoes(1, null, "Adicionado", "Adicionar");

        }
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            ExecutarButoes(2, Convert.ToInt32(toolStripStatusIdUsuario.Text), "Alterado", "Alterar");
        }
        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuariosPesquisa frmUsuariosPesquisa = new FrmUsuariosPesquisa();
            frmUsuariosPesquisa.MdiParent = this.MdiParent;
            frmUsuariosPesquisa.Show();
            this.Close();
        }

    
    }
}

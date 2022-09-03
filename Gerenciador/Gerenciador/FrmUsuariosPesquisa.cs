using System;
using System.Windows.Forms;
using DTO;
using BLL;

namespace Gerenciador
{
    public partial class FrmUsuariosPesquisa : Form
    {
        public FrmUsuariosPesquisa()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            dataGridViewUsuarios.AutoGenerateColumns = false;
        }
        private void AtualizarGrid()
        {
            UsuariosNegocios usuariosNegocios = new UsuariosNegocios();
            UsuariosColecao usuariosColecao = new UsuariosColecao();


            usuariosColecao = usuariosNegocios.ConsultarUsuariosPorNome(txtUsuariosPesquisa.Text);
            dataGridViewUsuarios.DataSource = null;
            dataGridViewUsuarios.DataSource = usuariosColecao;

            dataGridViewUsuarios.Update();
            dataGridViewUsuarios.Refresh();
        }

        private void SelecionaUsuario()
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Usuário Selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuariosPesquisa.Focus();
                return;
            }

            try
            {

                Usuarios usuariosSelecionado = (dataGridViewUsuarios.SelectedRows[0].DataBoundItem as Usuarios);
                FrmUsuarios frmUsuarios = new FrmUsuarios(AcaoTela.Alterar, usuariosSelecionado);
                frmUsuarios.ShowDialog();
                AtualizarGrid();

            }
            catch
            {
                txtUsuariosPesquisa.Focus();
            }

        }

        private void txtUsuariosPesquisa_TextChanged(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtUsuariosPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.AtualizarGrid();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnUsuariosPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void dataGridViewUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelecionaUsuario();

        }

        private void dataGridViewUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelecionaUsuario();
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void btnUsuarioSelecionar_Click(object sender, EventArgs e)
        {
            SelecionaUsuario();
        }

        private void btnUsuarioCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUsuariosPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                this.Close();
            }
        }

        private void dataGridViewUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            Usuarios data = dataGridViewUsuarios.Rows[e.RowIndex].DataBoundItem as Usuarios;

            dataGridViewUsuarios.Rows[e.RowIndex].Cells["Tipo"].Value = data.TipoUsuario.Nome_Tipo;
        }
    
        
       }
      
    }



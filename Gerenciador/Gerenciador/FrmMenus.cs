using System;
using System.Windows.Forms;

namespace Gerenciador
{
    public partial class FrmMenus : Form
    {
     

        public FrmMenus(string idusuario)
        {
            InitializeComponent();
            tSSidUsuario.Text = idusuario.ToString();
          //  MessageBox.Show(DateTime.Today.ToString());
    
        }
        private void FrmMenus_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    Control ctlMDI = (MdiClient)ctl;

                    tabInicial.BackColor = this.BackColor;

                    ctlMDI.BackColor = this.BackColor;
                }
                catch
                {
                    // DialogResult corFundoErrado = MessageBox.Show("Não Foi Possível Executar a Alteraçao da Cor de Fundo.\n Detalhes: " + ex.Message);
                }
            }
        }
        private bool checkFormOpen(Form openForm)
        {
            bool open = false;
            Form[] openForms = this.MdiChildren;
            foreach (Form form in openForms)
            {
                if (form.Name == openForm.Name)
                {
                    open = true;
                    break;
                }
            }
            return open;
        }
        private void btnAdicionarContrato_Click(object sender, EventArgs e)
        {
            FrmContrato frmContrato = new FrmContrato(AcaoTela.Adicionar, null, tSSidUsuario.ToString());
            if (!checkFormOpen(frmContrato))
            {
                frmContrato.MdiParent = this;
                frmContrato.Show();

            }
            else
            {
                frmContrato.WindowState = FormWindowState.Normal;
                frmContrato.BringToFront();
                frmContrato.Activate();
            }
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            FrmFornecedor frmFornecedor = new FrmFornecedor(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmFornecedor))
            {
                frmFornecedor.MdiParent = this;
                frmFornecedor.Show();

            }
            else
            {
                frmFornecedor.WindowState = FormWindowState.Normal;
                frmFornecedor.BringToFront();
                frmFornecedor.Activate();
            }
       }

          private void btnAdicionarOrgao_Click(object sender, EventArgs e)
        {
            FrmOrgao frmOrgao = new FrmOrgao(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmOrgao))
            {
                frmOrgao.MdiParent = this;
                frmOrgao.Show();

            }
            else
            {
                frmOrgao.WindowState = FormWindowState.Normal;
                frmOrgao.BringToFront();
                frmOrgao.Activate();
            }
        }

        private void btnAdicionarDepartamento_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmDepartamento = new FrmDepartamento(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmDepartamento))
            {
                frmDepartamento.MdiParent = this;
                frmDepartamento.Show();

            }
            else
            {
                frmDepartamento.WindowState = FormWindowState.Normal;
                frmDepartamento.BringToFront();
                frmDepartamento.Activate();


            }
        }
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmProduto))
            {
                frmProduto.MdiParent = this;
                frmProduto.Show();

            }
            else
            {
                frmProduto.WindowState = FormWindowState.Normal;
                frmProduto.BringToFront();
                frmProduto.Activate();


            }

        }

        private void btnAdicionarUnidMedida_Click(object sender, EventArgs e)
        {
            FrmUnidMedida frmUnidMedida = new FrmUnidMedida(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmUnidMedida))
            {
                frmUnidMedida.MdiParent = this;
                frmUnidMedida.Show();

            }
            else
            {
                frmUnidMedida.WindowState = FormWindowState.Normal;
                frmUnidMedida.BringToFront();
                frmUnidMedida.Activate();


            }
        }

      
        private void btnAdicionarGenero_Click(object sender, EventArgs e)
        {
            FrmGenero frmGenero = new FrmGenero(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmGenero))
            {
                frmGenero.MdiParent = this;
                frmGenero.Show();

            }
            else
            {
                frmGenero.WindowState = FormWindowState.Normal;
                frmGenero.BringToFront();
                frmGenero.Activate();

            }

        }
        private void btnAdicionarMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmMarca))
            {
                frmMarca.MdiParent = this;
                frmMarca.Show();

            }
            else
            {
                frmMarca.WindowState = FormWindowState.Normal;
                frmMarca.BringToFront();
                frmMarca.Activate();

            }
        }
        private void btnAdicionarBairros_Click(object sender, EventArgs e)
        {
            FrmBairro frmBairro = new FrmBairro(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmBairro))
            {
                frmBairro.MdiParent = this;
                frmBairro.Show();

            }
            else
            {
                frmBairro.WindowState = FormWindowState.Normal;
                frmBairro.BringToFront();
                frmBairro.Activate();

            }
        }


        private void btnItensContrato_Click(object sender, EventArgs e)
        {
            FrmContratoPesquisa frmContratoPesquisa = new FrmContratoPesquisa(AcaoTela.Adicionar, tSSidUsuario.ToString());
            if (!checkFormOpen(frmContratoPesquisa))
            {
                frmContratoPesquisa.MdiParent = this;
                frmContratoPesquisa.Show();

            }
            else
            {
                frmContratoPesquisa.WindowState = FormWindowState.Normal;
                frmContratoPesquisa.BringToFront();
                frmContratoPesquisa.Activate();

            }
        }

        private void btnBaixaItens_Click(object sender, EventArgs e)
        {
            FrmContratoPesquisa frmContratoPesquisa = new FrmContratoPesquisa(AcaoTela.Excluir, tSSidUsuario.ToString());
            if (!checkFormOpen(frmContratoPesquisa))
            {
                frmContratoPesquisa.MdiParent = this;
                frmContratoPesquisa.Show();

            }
            else
            {
                frmContratoPesquisa.WindowState = FormWindowState.Normal;
                frmContratoPesquisa.BringToFront();
                frmContratoPesquisa.Activate();

            }
        }

        private void btnRemanejamento_Click(object sender, EventArgs e)
        {

        }

        private void btnContratoAditivo_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoricoContratos_Click(object sender, EventArgs e)
        {

        }

        private void btnHistoricoItensContrato_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatórios_Click(object sender, EventArgs e)
        {

        }

        private void btnBackupRestaurar_Click(object sender, EventArgs e)
        {
            
            FrmBackupRestore frmBackupRestore = new FrmBackupRestore();
            if (!checkFormOpen(frmBackupRestore))
            {
                frmBackupRestore.MdiParent = this;
                frmBackupRestore.Show();
                
            }
            else 
            {
                frmBackupRestore.WindowState = FormWindowState.Normal;
                frmBackupRestore.BringToFront();
                frmBackupRestore.Activate();

                
            }
        }    
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           
            FrmUsuarios frmUsuarios = new FrmUsuarios(AcaoTela.Adicionar,null);
            if (!checkFormOpen(frmUsuarios))
            {
                frmUsuarios.MdiParent = this;
                frmUsuarios.Show();
            }
            else
            {
                frmUsuarios.WindowState = FormWindowState.Normal;
                frmUsuarios.BringToFront();
                frmUsuarios.Activate();
            }
        }
        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            FrmResponsavel frmResponsavel = new FrmResponsavel(AcaoTela.Adicionar, null);
            if (!checkFormOpen(frmResponsavel))
            {
                frmResponsavel.MdiParent = this;
                frmResponsavel.Show();
            }
            else
            {
                frmResponsavel.WindowState = FormWindowState.Normal;
                frmResponsavel.BringToFront();
                frmResponsavel.Activate();
            }
        }
        private void FrmMenus_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult fecharJanela = MessageBox.Show("Deseja Realmente Sair?", "Sair", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (fecharJanela == DialogResult.Cancel)
            {
                e.Cancel = true;
            }

            return;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        
    }
}

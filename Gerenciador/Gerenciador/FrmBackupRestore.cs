using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data.Services;


namespace Gerenciador
{
    public partial class FrmBackupRestore : Form
    {
        public FrmBackupRestore()
        {
            InitializeComponent();
            FrmLogin.percorrerControles(this);
            chBxIgnoreLimboBackup.Checked = true;
            chBxNonTransportableBackup.Checked = true;
            chBxIgnoreLimboRestore.Checked = true;
            chBxNonTransportableRestore.Checked = true;
        }

        private void btnCancelarBackup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarRestaurar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarOrigemBackup_Click(object sender, EventArgs e)
        {
           
            oFDialogOrigemBackup.Filter = "Banco de Dados Firebird (*.fdb)|*.fdb";
            oFDialogOrigemBackup.Title = "Por favor selecione o Banco de Dados.";
            if (oFDialogOrigemBackup.ShowDialog().Equals(DialogResult.OK))
            {
                txtOrigemBackup.Text = oFDialogOrigemBackup.FileName.ToString();
            }
        }

        private void btnSelecionarDestinoBackup_Click(object sender, EventArgs e)
        {
            sFDDestinoBackup.Filter = "Backup Firebird (*.fbk)|*.fbk";
            sFDDestinoBackup.Title = "Por favor escolha um Nome para o arquivo.";
           
            if (sFDDestinoBackup.ShowDialog().Equals(DialogResult.OK))
            {
                txtDestinoBackup.Text = sFDDestinoBackup.FileName.ToString();
            }
            
        }
        

        private void btnSalvarBackup_Click(object sender, EventArgs e)
        {
            if ((FrmLogin.validarCampo(txtOrigemBackup, errorProviderOrigemBackup) 
                && FrmLogin.validarCampo(txtDestinoBackup, errorProviderDestinoBackup).Equals(true)))
            {
                try
                {
                    lstBBackupBD.Items.Clear();
                    string DBName = txtOrigemBackup.Text;

                    FbConnectionStringBuilder fbConnectionStringBuilder = new FbConnectionStringBuilder
                    {
                        UserID = "SYSDBA",
                        Password = "masterkey",
                        Database = DBName
                    };

                    FbBackup fbBackup = new FbBackup { ConnectionString = fbConnectionStringBuilder.ToString() };

                    fbBackup.BackupFiles.Add(new FbBackupFile(txtDestinoBackup.Text, 2048));

                    fbBackup.Verbose = true;

                    if (chBxIgnoreChecksumsBackup.Checked.Equals(true))
                    {
                        fbBackup.Options = FbBackupFlags.IgnoreChecksums;
                    }
                    if (chBxIgnoreLimboBackup.Checked.Equals(true))
                    {
                        fbBackup.Options = FbBackupFlags.IgnoreLimbo;
                    }
                    if (chBxMetadataOnlyBackup.Checked.Equals(true))
                    {
                        fbBackup.Options = FbBackupFlags.MetaDataOnly;
                    }
                    if (chBxNoGarbageCollectionBackup.Checked.Equals(true))
                    {
                        fbBackup.Options = FbBackupFlags.NoGarbageCollect;
                    }
                    if (chBxConvertExtTablesBackup.Checked.Equals(true))
                    {
                        fbBackup.Options = FbBackupFlags.Convert;
                    }
                    if (chBxNonTransportableBackup.Checked.Equals(true))
                    {
                        fbBackup.Options = FbBackupFlags.NonTransportable;
                    }


                    fbBackup.ServiceOutput += ServiceOutputBackup;

                    fbBackup.Execute();



                    MessageBox.Show("Backup realizado com sucesso!", "Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Banco de Dados FireBird", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Não foi Possível Realizar o Backup!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ServiceOutputBackup(object sender, ServiceOutputEventArgs e)
        {
            
            lstBBackupBD.Items.Add(e.Message);
            processoBackup.Increment(1);
            Application.DoEvents();
            
        }
        
        private void btnSelecionarOrigemRestore_Click(object sender, EventArgs e)
        {
            oFDialogOrigemRestore.Filter = "Backup Firebird (*.fbk)|*.fbk";
            oFDialogOrigemRestore.Title = "Por favor selecione o Backup do Banco de Dados.";
            if (oFDialogOrigemRestore.ShowDialog().Equals(DialogResult.OK))
            {
                txtOrigemRestore.Text = oFDialogOrigemRestore.FileName.ToString();
            }
        }
        private void btnSelecionarDestinoRestore_Click(object sender, EventArgs e)
        {
            sFDDestinoRestore.Filter = "Banco de Dados Firebird (*.fdb)|*.fdb";
            sFDDestinoRestore.Title = "Por favor escolha um Nome para o Banco de Dados.";

            if (sFDDestinoRestore.ShowDialog().Equals(DialogResult.OK))
            {
                txtDestinoRestore.Text = sFDDestinoRestore.FileName.ToString();
            }
        }
        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            if ((FrmLogin.validarCampo(txtOrigemRestore, errorProviderOrigemRestore) 
                && FrmLogin.validarCampo(txtDestinoRestore, errorProviderDestinoRestore).Equals(true)))
            {

                try
                {

                    lstBRestoreBD.Items.Clear();
                    string DBName = txtOrigemRestore.Text;
                    
                    FbConnectionStringBuilder fbConnectionStringBuilder = new FbConnectionStringBuilder
                    {
                        UserID = "SYSDBA",
                        Password = "masterkey",
                        Database = DBName
                    };

                    FbConnection.ClearAllPools();
                    FbRestore fbRestore = new FbRestore { ConnectionString = fbConnectionStringBuilder.ToString() };
                    
                    fbRestore.BackupFiles.Add(new FbBackupFile(txtDestinoRestore.Text, int.MaxValue));
                    fbRestore.Verbose = true;
                    fbRestore.PageSize = 4096;
                    fbRestore.PageBuffers = 2048;

                    fbRestore.Options = FbRestoreFlags.Create | FbRestoreFlags.Replace | FbRestoreFlags.UseAllSpace;

                    fbRestore.ServiceOutput += ServiceOutputRestore;
                    
                    fbRestore.Execute();

                    MessageBox.Show("Restauração Realizada com Sucesso! \n O Gerenciador de Contratos será Reiniciado! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                   // Close();
                   // FrmLogin frmLogin = new FrmLogin();
                   // frmLogin.Show();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Não Foi Possível Realizar a Restauração do Banco de Dados!\n Detalhes: "+ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Não foi Possível Realizar a Restauração!\n Preenchimento Obrigatório Do Campo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ServiceOutputRestore(object sender, ServiceOutputEventArgs e)
        {
            
            lstBRestoreBD.Items.Add(e.Message);
            processoRestore.Increment(1);
            Application.DoEvents();
           
        }
        private void FrmBackupRestore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) //ESC
            {
                Close();
            }
        }

        
    }
 }

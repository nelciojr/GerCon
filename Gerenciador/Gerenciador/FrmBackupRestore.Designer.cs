namespace Gerenciador
{
    partial class FrmBackupRestore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupRestore));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCancelarBackup = new System.Windows.Forms.Button();
            this.btnSalvarBackup = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstBBackupBD = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.processoBackup = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBxNonTransportableBackup = new System.Windows.Forms.CheckBox();
            this.chBxConvertExtTablesBackup = new System.Windows.Forms.CheckBox();
            this.chBxNoGarbageCollectionBackup = new System.Windows.Forms.CheckBox();
            this.chBxMetadataOnlyBackup = new System.Windows.Forms.CheckBox();
            this.chBxIgnoreLimboBackup = new System.Windows.Forms.CheckBox();
            this.chBxIgnoreChecksumsBackup = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecionarDestinoBackup = new System.Windows.Forms.Button();
            this.btnSelecionarOrigemBackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestinoBackup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigemBackup = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelarRestaurar = new System.Windows.Forms.Button();
            this.btnRestaurarBackup = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstBRestoreBD = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.processoRestore = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chBxNonTransportableRestore = new System.Windows.Forms.CheckBox();
            this.chBxConvertExtTablesRestore = new System.Windows.Forms.CheckBox();
            this.chBxNoGarbageCollectionRestore = new System.Windows.Forms.CheckBox();
            this.chBxMetadataOnlyRestore = new System.Windows.Forms.CheckBox();
            this.chBxIgnoreLimboRestore = new System.Windows.Forms.CheckBox();
            this.chBxIgnoreChecksumsRestore = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelecionarDestinoRestore = new System.Windows.Forms.Button();
            this.btnSelecionarOrigemRestore = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinoRestore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrigemRestore = new System.Windows.Forms.TextBox();
            this.oFDialogOrigemBackup = new System.Windows.Forms.OpenFileDialog();
            this.errorProviderOrigemBackup = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDestinoBackup = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrigemRestore = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDestinoRestore = new System.Windows.Forms.ErrorProvider(this.components);
            this.oFDialogOrigemRestore = new System.Windows.Forms.OpenFileDialog();
            this.sFDDestinoBackup = new System.Windows.Forms.SaveFileDialog();
            this.sFDDestinoRestore = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigemBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestinoBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigemRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestinoRestore)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(484, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancelarBackup);
            this.tabPage1.Controls.Add(this.btnSalvarBackup);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup BD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancelarBackup
            // 
            this.btnCancelarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBackup.Image")));
            this.btnCancelarBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarBackup.Location = new System.Drawing.Point(398, 72);
            this.btnCancelarBackup.Name = "btnCancelarBackup";
            this.btnCancelarBackup.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarBackup.TabIndex = 1;
            this.btnCancelarBackup.Text = "Cancelar";
            this.btnCancelarBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarBackup.UseVisualStyleBackColor = true;
            this.btnCancelarBackup.Click += new System.EventHandler(this.btnCancelarBackup_Click);
            // 
            // btnSalvarBackup
            // 
            this.btnSalvarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarBackup.Image")));
            this.btnSalvarBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvarBackup.Location = new System.Drawing.Point(398, 6);
            this.btnSalvarBackup.Name = "btnSalvarBackup";
            this.btnSalvarBackup.Size = new System.Drawing.Size(70, 60);
            this.btnSalvarBackup.TabIndex = 0;
            this.btnSalvarBackup.Text = "Salvar";
            this.btnSalvarBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarBackup.UseVisualStyleBackColor = true;
            this.btnSalvarBackup.Click += new System.EventHandler(this.btnSalvarBackup_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstBBackupBD);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.processoBackup);
            this.groupBox3.Location = new System.Drawing.Point(8, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 187);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Verbose";
            // 
            // lstBBackupBD
            // 
            this.lstBBackupBD.FormattingEnabled = true;
            this.lstBBackupBD.Location = new System.Drawing.Point(7, 20);
            this.lstBBackupBD.Name = "lstBBackupBD";
            this.lstBBackupBD.Size = new System.Drawing.Size(368, 134);
            this.lstBBackupBD.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Processo:";
            // 
            // processoBackup
            // 
            this.processoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processoBackup.Location = new System.Drawing.Point(68, 162);
            this.processoBackup.Name = "processoBackup";
            this.processoBackup.Size = new System.Drawing.Size(310, 19);
            this.processoBackup.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chBxNonTransportableBackup);
            this.groupBox2.Controls.Add(this.chBxConvertExtTablesBackup);
            this.groupBox2.Controls.Add(this.chBxNoGarbageCollectionBackup);
            this.groupBox2.Controls.Add(this.chBxMetadataOnlyBackup);
            this.groupBox2.Controls.Add(this.chBxIgnoreLimboBackup);
            this.groupBox2.Controls.Add(this.chBxIgnoreChecksumsBackup);
            this.groupBox2.Location = new System.Drawing.Point(8, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opções";
            // 
            // chBxNonTransportableBackup
            // 
            this.chBxNonTransportableBackup.AutoSize = true;
            this.chBxNonTransportableBackup.Location = new System.Drawing.Point(257, 42);
            this.chBxNonTransportableBackup.Name = "chBxNonTransportableBackup";
            this.chBxNonTransportableBackup.Size = new System.Drawing.Size(111, 17);
            this.chBxNonTransportableBackup.TabIndex = 6;
            this.chBxNonTransportableBackup.Text = "NonTransportable";
            this.chBxNonTransportableBackup.UseVisualStyleBackColor = true;
            // 
            // chBxConvertExtTablesBackup
            // 
            this.chBxConvertExtTablesBackup.AutoSize = true;
            this.chBxConvertExtTablesBackup.Location = new System.Drawing.Point(258, 19);
            this.chBxConvertExtTablesBackup.Name = "chBxConvertExtTablesBackup";
            this.chBxConvertExtTablesBackup.Size = new System.Drawing.Size(110, 17);
            this.chBxConvertExtTablesBackup.TabIndex = 5;
            this.chBxConvertExtTablesBackup.Text = "ConvertExtTables";
            this.chBxConvertExtTablesBackup.UseVisualStyleBackColor = true;
            // 
            // chBxNoGarbageCollectionBackup
            // 
            this.chBxNoGarbageCollectionBackup.AutoSize = true;
            this.chBxNoGarbageCollectionBackup.Location = new System.Drawing.Point(124, 42);
            this.chBxNoGarbageCollectionBackup.Name = "chBxNoGarbageCollectionBackup";
            this.chBxNoGarbageCollectionBackup.Size = new System.Drawing.Size(127, 17);
            this.chBxNoGarbageCollectionBackup.TabIndex = 3;
            this.chBxNoGarbageCollectionBackup.Text = "NoGarbageCollection";
            this.chBxNoGarbageCollectionBackup.UseVisualStyleBackColor = true;
            // 
            // chBxMetadataOnlyBackup
            // 
            this.chBxMetadataOnlyBackup.AutoSize = true;
            this.chBxMetadataOnlyBackup.Location = new System.Drawing.Point(124, 19);
            this.chBxMetadataOnlyBackup.Name = "chBxMetadataOnlyBackup";
            this.chBxMetadataOnlyBackup.Size = new System.Drawing.Size(92, 17);
            this.chBxMetadataOnlyBackup.TabIndex = 2;
            this.chBxMetadataOnlyBackup.Text = "MetadataOnly";
            this.chBxMetadataOnlyBackup.UseVisualStyleBackColor = true;
            // 
            // chBxIgnoreLimboBackup
            // 
            this.chBxIgnoreLimboBackup.AutoSize = true;
            this.chBxIgnoreLimboBackup.Location = new System.Drawing.Point(7, 42);
            this.chBxIgnoreLimboBackup.Name = "chBxIgnoreLimboBackup";
            this.chBxIgnoreLimboBackup.Size = new System.Drawing.Size(84, 17);
            this.chBxIgnoreLimboBackup.TabIndex = 1;
            this.chBxIgnoreLimboBackup.Text = "IgnoreLimbo";
            this.chBxIgnoreLimboBackup.UseVisualStyleBackColor = true;
            // 
            // chBxIgnoreChecksumsBackup
            // 
            this.chBxIgnoreChecksumsBackup.AutoSize = true;
            this.chBxIgnoreChecksumsBackup.Location = new System.Drawing.Point(7, 20);
            this.chBxIgnoreChecksumsBackup.Name = "chBxIgnoreChecksumsBackup";
            this.chBxIgnoreChecksumsBackup.Size = new System.Drawing.Size(111, 17);
            this.chBxIgnoreChecksumsBackup.TabIndex = 0;
            this.chBxIgnoreChecksumsBackup.Text = "IgnoreChecksums";
            this.chBxIgnoreChecksumsBackup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSelecionarDestinoBackup);
            this.groupBox1.Controls.Add(this.btnSelecionarOrigemBackup);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDestinoBackup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOrigemBackup);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivos";
            // 
            // btnSelecionarDestinoBackup
            // 
            this.btnSelecionarDestinoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarDestinoBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarDestinoBackup.Image")));
            this.btnSelecionarDestinoBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarDestinoBackup.Location = new System.Drawing.Point(287, 78);
            this.btnSelecionarDestinoBackup.Name = "btnSelecionarDestinoBackup";
            this.btnSelecionarDestinoBackup.Size = new System.Drawing.Size(87, 30);
            this.btnSelecionarDestinoBackup.TabIndex = 3;
            this.btnSelecionarDestinoBackup.Text = "Selecionar";
            this.btnSelecionarDestinoBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarDestinoBackup.UseVisualStyleBackColor = true;
            this.btnSelecionarDestinoBackup.Click += new System.EventHandler(this.btnSelecionarDestinoBackup_Click);
            // 
            // btnSelecionarOrigemBackup
            // 
            this.btnSelecionarOrigemBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarOrigemBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarOrigemBackup.Image")));
            this.btnSelecionarOrigemBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarOrigemBackup.Location = new System.Drawing.Point(287, 26);
            this.btnSelecionarOrigemBackup.Name = "btnSelecionarOrigemBackup";
            this.btnSelecionarOrigemBackup.Size = new System.Drawing.Size(88, 30);
            this.btnSelecionarOrigemBackup.TabIndex = 2;
            this.btnSelecionarOrigemBackup.Text = "Selecionar";
            this.btnSelecionarOrigemBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarOrigemBackup.UseVisualStyleBackColor = true;
            this.btnSelecionarOrigemBackup.Click += new System.EventHandler(this.btnSelecionarOrigemBackup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Arquivo Destino (Ex: C:\\DataBasse\\BasedeDados.FBK)";
            // 
            // txtDestinoBackup
            // 
            this.txtDestinoBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinoBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinoBackup.Location = new System.Drawing.Point(6, 86);
            this.txtDestinoBackup.Name = "txtDestinoBackup";
            this.txtDestinoBackup.Size = new System.Drawing.Size(266, 22);
            this.txtDestinoBackup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Arquivo Origem (Ex: C:\\DataBasse\\BasedeDados.FDB)";
            // 
            // txtOrigemBackup
            // 
            this.txtOrigemBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigemBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemBackup.Location = new System.Drawing.Point(6, 34);
            this.txtOrigemBackup.Name = "txtOrigemBackup";
            this.txtOrigemBackup.Size = new System.Drawing.Size(267, 22);
            this.txtOrigemBackup.TabIndex = 0;
            this.txtOrigemBackup.Text = "C:\\Program Files (x86)\\Gerenciador de Contratos\\BASICO.FDB";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelarRestaurar);
            this.tabPage2.Controls.Add(this.btnRestaurarBackup);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restaurar BD";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelarRestaurar
            // 
            this.btnCancelarRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarRestaurar.Image")));
            this.btnCancelarRestaurar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarRestaurar.Location = new System.Drawing.Point(398, 72);
            this.btnCancelarRestaurar.Name = "btnCancelarRestaurar";
            this.btnCancelarRestaurar.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarRestaurar.TabIndex = 7;
            this.btnCancelarRestaurar.Text = "Cancelar";
            this.btnCancelarRestaurar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarRestaurar.UseVisualStyleBackColor = true;
            this.btnCancelarRestaurar.Click += new System.EventHandler(this.btnCancelarRestaurar_Click);
            // 
            // btnRestaurarBackup
            // 
            this.btnRestaurarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurarBackup.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarBackup.Image")));
            this.btnRestaurarBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRestaurarBackup.Location = new System.Drawing.Point(398, 6);
            this.btnRestaurarBackup.Name = "btnRestaurarBackup";
            this.btnRestaurarBackup.Size = new System.Drawing.Size(70, 60);
            this.btnRestaurarBackup.TabIndex = 6;
            this.btnRestaurarBackup.Text = "Restaurar";
            this.btnRestaurarBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestaurarBackup.UseVisualStyleBackColor = true;
            this.btnRestaurarBackup.Click += new System.EventHandler(this.btnRestaurarBackup_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lstBRestoreBD);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.processoRestore);
            this.groupBox6.Location = new System.Drawing.Point(8, 219);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(384, 187);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Verbose";
            // 
            // lstBRestoreBD
            // 
            this.lstBRestoreBD.FormattingEnabled = true;
            this.lstBRestoreBD.Location = new System.Drawing.Point(7, 20);
            this.lstBRestoreBD.Name = "lstBRestoreBD";
            this.lstBRestoreBD.Size = new System.Drawing.Size(368, 134);
            this.lstBRestoreBD.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Processo:";
            // 
            // processoRestore
            // 
            this.processoRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processoRestore.Location = new System.Drawing.Point(68, 160);
            this.processoRestore.Name = "processoRestore";
            this.processoRestore.Size = new System.Drawing.Size(310, 19);
            this.processoRestore.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.chBxNonTransportableRestore);
            this.groupBox5.Controls.Add(this.chBxConvertExtTablesRestore);
            this.groupBox5.Controls.Add(this.chBxNoGarbageCollectionRestore);
            this.groupBox5.Controls.Add(this.chBxMetadataOnlyRestore);
            this.groupBox5.Controls.Add(this.chBxIgnoreLimboRestore);
            this.groupBox5.Controls.Add(this.chBxIgnoreChecksumsRestore);
            this.groupBox5.Location = new System.Drawing.Point(8, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 70);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opções";
            // 
            // chBxNonTransportableRestore
            // 
            this.chBxNonTransportableRestore.AutoSize = true;
            this.chBxNonTransportableRestore.Location = new System.Drawing.Point(257, 42);
            this.chBxNonTransportableRestore.Name = "chBxNonTransportableRestore";
            this.chBxNonTransportableRestore.Size = new System.Drawing.Size(111, 17);
            this.chBxNonTransportableRestore.TabIndex = 6;
            this.chBxNonTransportableRestore.Text = "NonTransportable";
            this.chBxNonTransportableRestore.UseVisualStyleBackColor = true;
            // 
            // chBxConvertExtTablesRestore
            // 
            this.chBxConvertExtTablesRestore.AutoSize = true;
            this.chBxConvertExtTablesRestore.Location = new System.Drawing.Point(258, 19);
            this.chBxConvertExtTablesRestore.Name = "chBxConvertExtTablesRestore";
            this.chBxConvertExtTablesRestore.Size = new System.Drawing.Size(110, 17);
            this.chBxConvertExtTablesRestore.TabIndex = 5;
            this.chBxConvertExtTablesRestore.Text = "ConvertExtTables";
            this.chBxConvertExtTablesRestore.UseVisualStyleBackColor = true;
            // 
            // chBxNoGarbageCollectionRestore
            // 
            this.chBxNoGarbageCollectionRestore.AutoSize = true;
            this.chBxNoGarbageCollectionRestore.Location = new System.Drawing.Point(124, 42);
            this.chBxNoGarbageCollectionRestore.Name = "chBxNoGarbageCollectionRestore";
            this.chBxNoGarbageCollectionRestore.Size = new System.Drawing.Size(127, 17);
            this.chBxNoGarbageCollectionRestore.TabIndex = 3;
            this.chBxNoGarbageCollectionRestore.Text = "NoGarbageCollection";
            this.chBxNoGarbageCollectionRestore.UseVisualStyleBackColor = true;
            // 
            // chBxMetadataOnlyRestore
            // 
            this.chBxMetadataOnlyRestore.AutoSize = true;
            this.chBxMetadataOnlyRestore.Location = new System.Drawing.Point(124, 19);
            this.chBxMetadataOnlyRestore.Name = "chBxMetadataOnlyRestore";
            this.chBxMetadataOnlyRestore.Size = new System.Drawing.Size(92, 17);
            this.chBxMetadataOnlyRestore.TabIndex = 2;
            this.chBxMetadataOnlyRestore.Text = "MetadataOnly";
            this.chBxMetadataOnlyRestore.UseVisualStyleBackColor = true;
            // 
            // chBxIgnoreLimboRestore
            // 
            this.chBxIgnoreLimboRestore.AutoSize = true;
            this.chBxIgnoreLimboRestore.Location = new System.Drawing.Point(7, 42);
            this.chBxIgnoreLimboRestore.Name = "chBxIgnoreLimboRestore";
            this.chBxIgnoreLimboRestore.Size = new System.Drawing.Size(84, 17);
            this.chBxIgnoreLimboRestore.TabIndex = 1;
            this.chBxIgnoreLimboRestore.Text = "IgnoreLimbo";
            this.chBxIgnoreLimboRestore.UseVisualStyleBackColor = true;
            // 
            // chBxIgnoreChecksumsRestore
            // 
            this.chBxIgnoreChecksumsRestore.AutoSize = true;
            this.chBxIgnoreChecksumsRestore.Location = new System.Drawing.Point(7, 20);
            this.chBxIgnoreChecksumsRestore.Name = "chBxIgnoreChecksumsRestore";
            this.chBxIgnoreChecksumsRestore.Size = new System.Drawing.Size(111, 17);
            this.chBxIgnoreChecksumsRestore.TabIndex = 0;
            this.chBxIgnoreChecksumsRestore.Text = "IgnoreChecksums";
            this.chBxIgnoreChecksumsRestore.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnSelecionarDestinoRestore);
            this.groupBox4.Controls.Add(this.btnSelecionarOrigemRestore);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDestinoRestore);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtOrigemRestore);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 131);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arquivos";
            // 
            // btnSelecionarDestinoRestore
            // 
            this.btnSelecionarDestinoRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarDestinoRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarDestinoRestore.Image")));
            this.btnSelecionarDestinoRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarDestinoRestore.Location = new System.Drawing.Point(287, 78);
            this.btnSelecionarDestinoRestore.Name = "btnSelecionarDestinoRestore";
            this.btnSelecionarDestinoRestore.Size = new System.Drawing.Size(87, 30);
            this.btnSelecionarDestinoRestore.TabIndex = 3;
            this.btnSelecionarDestinoRestore.Text = "Selecionar";
            this.btnSelecionarDestinoRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarDestinoRestore.UseVisualStyleBackColor = true;
            this.btnSelecionarDestinoRestore.Click += new System.EventHandler(this.btnSelecionarDestinoRestore_Click);
            // 
            // btnSelecionarOrigemRestore
            // 
            this.btnSelecionarOrigemRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarOrigemRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnSelecionarOrigemRestore.Image")));
            this.btnSelecionarOrigemRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionarOrigemRestore.Location = new System.Drawing.Point(287, 26);
            this.btnSelecionarOrigemRestore.Name = "btnSelecionarOrigemRestore";
            this.btnSelecionarOrigemRestore.Size = new System.Drawing.Size(88, 30);
            this.btnSelecionarOrigemRestore.TabIndex = 2;
            this.btnSelecionarOrigemRestore.Text = "Selecionar";
            this.btnSelecionarOrigemRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelecionarOrigemRestore.UseVisualStyleBackColor = true;
            this.btnSelecionarOrigemRestore.Click += new System.EventHandler(this.btnSelecionarOrigemRestore_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Arquivo Destino (Ex: C:\\DataBasse\\BasedeDados.FDB)";
            // 
            // txtDestinoRestore
            // 
            this.txtDestinoRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinoRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinoRestore.Location = new System.Drawing.Point(6, 86);
            this.txtDestinoRestore.Name = "txtDestinoRestore";
            this.txtDestinoRestore.Size = new System.Drawing.Size(266, 22);
            this.txtDestinoRestore.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Arquivo Origem (Ex: C:\\DataBasse\\BasedeDados.FBK)";
            // 
            // txtOrigemRestore
            // 
            this.txtOrigemRestore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrigemRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrigemRestore.Location = new System.Drawing.Point(6, 34);
            this.txtOrigemRestore.Name = "txtOrigemRestore";
            this.txtOrigemRestore.Size = new System.Drawing.Size(267, 22);
            this.txtOrigemRestore.TabIndex = 0;
            // 
            // errorProviderOrigemBackup
            // 
            this.errorProviderOrigemBackup.ContainerControl = this;
            // 
            // errorProviderDestinoBackup
            // 
            this.errorProviderDestinoBackup.ContainerControl = this;
            // 
            // errorProviderOrigemRestore
            // 
            this.errorProviderOrigemRestore.ContainerControl = this;
            // 
            // errorProviderDestinoRestore
            // 
            this.errorProviderDestinoRestore.ContainerControl = this;
            // 
            // oFDialogOrigemRestore
            // 
            this.oFDialogOrigemRestore.FileName = ".gbk";
            // 
            // FrmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 444);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramentas - Banco de Dados";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBackupRestore_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigemBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestinoBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigemRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDestinoRestore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDestinoBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigemBackup;
        private System.Windows.Forms.OpenFileDialog oFDialogOrigemBackup;
        private System.Windows.Forms.Button btnSelecionarDestinoBackup;
        private System.Windows.Forms.Button btnSelecionarOrigemBackup;
        private System.Windows.Forms.CheckBox chBxNonTransportableBackup;
        private System.Windows.Forms.CheckBox chBxConvertExtTablesBackup;
        private System.Windows.Forms.CheckBox chBxNoGarbageCollectionBackup;
        private System.Windows.Forms.CheckBox chBxMetadataOnlyBackup;
        private System.Windows.Forms.CheckBox chBxIgnoreLimboBackup;
        private System.Windows.Forms.CheckBox chBxIgnoreChecksumsBackup;
        private System.Windows.Forms.ErrorProvider errorProviderOrigemBackup;
        private System.Windows.Forms.ErrorProvider errorProviderDestinoBackup;
        private System.Windows.Forms.Button btnCancelarBackup;
        private System.Windows.Forms.Button btnSalvarBackup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelecionarDestinoRestore;
        private System.Windows.Forms.Button btnSelecionarOrigemRestore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinoRestore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrigemRestore;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chBxNonTransportableRestore;
        private System.Windows.Forms.CheckBox chBxConvertExtTablesRestore;
        private System.Windows.Forms.CheckBox chBxNoGarbageCollectionRestore;
        private System.Windows.Forms.CheckBox chBxMetadataOnlyRestore;
        private System.Windows.Forms.CheckBox chBxIgnoreLimboRestore;
        private System.Windows.Forms.CheckBox chBxIgnoreChecksumsRestore;
        private System.Windows.Forms.Button btnCancelarRestaurar;
        private System.Windows.Forms.Button btnRestaurarBackup;
        private System.Windows.Forms.ErrorProvider errorProviderOrigemRestore;
        private System.Windows.Forms.ErrorProvider errorProviderDestinoRestore;
        private System.Windows.Forms.OpenFileDialog oFDialogOrigemRestore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar processoBackup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar processoRestore;
        private System.Windows.Forms.ListBox lstBBackupBD;
        private System.Windows.Forms.ListBox lstBRestoreBD;
        private System.Windows.Forms.SaveFileDialog sFDDestinoBackup;
        private System.Windows.Forms.SaveFileDialog sFDDestinoRestore;
    }
}
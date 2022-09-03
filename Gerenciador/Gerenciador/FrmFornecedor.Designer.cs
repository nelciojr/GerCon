namespace Gerenciador
{
    partial class FrmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.btnAdicionarBairroFornecedor = new System.Windows.Forms.Button();
            this.cbxBairroFornecedor = new System.Windows.Forms.ComboBox();
            this.cbxCidadeFornecedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelarFornecedor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeFantasiaFornecedor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazaoSocialFornecedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstadoFornecedor = new System.Windows.Forms.ComboBox();
            this.btnPesquisarFornecedor = new System.Windows.Forms.Button();
            this.btnExcluirFornecedor = new System.Windows.Forms.Button();
            this.btnEditarFornecedor = new System.Windows.Forms.Button();
            this.btnAdcionarFornecedor = new System.Windows.Forms.Button();
            this.mTxtCPFFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.rBtnCNPJFornecedor = new System.Windows.Forms.RadioButton();
            this.rBtnCPFFornecedor = new System.Windows.Forms.RadioButton();
            this.mTxtCNPJFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txtEnderecoFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mTxtTelFixoFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mTxtTelCelFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.txtContatoFornecedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdFornecedor = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtEmailFornecedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ePrRazaoSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrNomeFantasia = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrEstado = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrCidade = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrBairro = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrEndereco = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrTelFixo = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrTelCel = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrContato = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePR = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrRazaoSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNomeFantasia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrBairro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEndereco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelFixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelCel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrContato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarBairroFornecedor
            // 
            this.btnAdicionarBairroFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarBairroFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarBairroFornecedor.Image")));
            this.btnAdicionarBairroFornecedor.Location = new System.Drawing.Point(356, 181);
            this.btnAdicionarBairroFornecedor.Name = "btnAdicionarBairroFornecedor";
            this.btnAdicionarBairroFornecedor.Size = new System.Drawing.Size(50, 40);
            this.btnAdicionarBairroFornecedor.TabIndex = 17;
            this.btnAdicionarBairroFornecedor.UseVisualStyleBackColor = true;
            this.btnAdicionarBairroFornecedor.Click += new System.EventHandler(this.btnAdicionarBairroFornecedor_Click);
            // 
            // cbxBairroFornecedor
            // 
            this.cbxBairroFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBairroFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBairroFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBairroFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBairroFornecedor.FormattingEnabled = true;
            this.cbxBairroFornecedor.Location = new System.Drawing.Point(13, 190);
            this.cbxBairroFornecedor.Name = "cbxBairroFornecedor";
            this.cbxBairroFornecedor.Size = new System.Drawing.Size(324, 24);
            this.cbxBairroFornecedor.TabIndex = 6;
            // 
            // cbxCidadeFornecedor
            // 
            this.cbxCidadeFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCidadeFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCidadeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidadeFornecedor.FormattingEnabled = true;
            this.cbxCidadeFornecedor.Location = new System.Drawing.Point(188, 144);
            this.cbxCidadeFornecedor.Name = "cbxCidadeFornecedor";
            this.cbxCidadeFornecedor.Size = new System.Drawing.Size(198, 24);
            this.cbxCidadeFornecedor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Bairro";
            // 
            // btnCancelarFornecedor
            // 
            this.btnCancelarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarFornecedor.Image")));
            this.btnCancelarFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarFornecedor.Location = new System.Drawing.Point(412, 276);
            this.btnCancelarFornecedor.Name = "btnCancelarFornecedor";
            this.btnCancelarFornecedor.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarFornecedor.TabIndex = 16;
            this.btnCancelarFornecedor.Text = "Cancelar";
            this.btnCancelarFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarFornecedor.UseVisualStyleBackColor = true;
            this.btnCancelarFornecedor.Click += new System.EventHandler(this.btnCancelarFornecedor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Estado";
            // 
            // txtNomeFantasiaFornecedor
            // 
            this.txtNomeFantasiaFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeFantasiaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasiaFornecedor.Location = new System.Drawing.Point(12, 100);
            this.txtNomeFantasiaFornecedor.Name = "txtNomeFantasiaFornecedor";
            this.txtNomeFantasiaFornecedor.Size = new System.Drawing.Size(374, 22);
            this.txtNomeFantasiaFornecedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nome Fantasia";
            // 
            // txtRazaoSocialFornecedor
            // 
            this.txtRazaoSocialFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazaoSocialFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocialFornecedor.Location = new System.Drawing.Point(13, 56);
            this.txtRazaoSocialFornecedor.Name = "txtRazaoSocialFornecedor";
            this.txtRazaoSocialFornecedor.Size = new System.Drawing.Size(373, 22);
            this.txtRazaoSocialFornecedor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Razão Social";
            // 
            // cbxEstadoFornecedor
            // 
            this.cbxEstadoFornecedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEstadoFornecedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEstadoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoFornecedor.FormattingEnabled = true;
            this.cbxEstadoFornecedor.Location = new System.Drawing.Point(12, 144);
            this.cbxEstadoFornecedor.Name = "cbxEstadoFornecedor";
            this.cbxEstadoFornecedor.Size = new System.Drawing.Size(150, 24);
            this.cbxEstadoFornecedor.TabIndex = 4;
            this.cbxEstadoFornecedor.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoFornecedor_SelectedIndexChanged);
            // 
            // btnPesquisarFornecedor
            // 
            this.btnPesquisarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarFornecedor.Image")));
            this.btnPesquisarFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarFornecedor.Location = new System.Drawing.Point(412, 210);
            this.btnPesquisarFornecedor.Name = "btnPesquisarFornecedor";
            this.btnPesquisarFornecedor.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarFornecedor.TabIndex = 15;
            this.btnPesquisarFornecedor.Text = "Pesquisar";
            this.btnPesquisarFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarFornecedor.UseVisualStyleBackColor = true;
            this.btnPesquisarFornecedor.Click += new System.EventHandler(this.btnPesquisarFornecedor_Click);
            // 
            // btnExcluirFornecedor
            // 
            this.btnExcluirFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirFornecedor.Enabled = false;
            this.btnExcluirFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirFornecedor.Image")));
            this.btnExcluirFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirFornecedor.Location = new System.Drawing.Point(412, 144);
            this.btnExcluirFornecedor.Name = "btnExcluirFornecedor";
            this.btnExcluirFornecedor.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirFornecedor.TabIndex = 14;
            this.btnExcluirFornecedor.Text = "Excluir";
            this.btnExcluirFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirFornecedor.UseVisualStyleBackColor = true;
            this.btnExcluirFornecedor.Click += new System.EventHandler(this.btnExcluirFornecedor_Click);
            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarFornecedor.Enabled = false;
            this.btnEditarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarFornecedor.Image")));
            this.btnEditarFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarFornecedor.Location = new System.Drawing.Point(412, 78);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Size = new System.Drawing.Size(70, 60);
            this.btnEditarFornecedor.TabIndex = 13;
            this.btnEditarFornecedor.Text = "Editar";
            this.btnEditarFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarFornecedor.UseVisualStyleBackColor = true;
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);
            // 
            // btnAdcionarFornecedor
            // 
            this.btnAdcionarFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdcionarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionarFornecedor.Image")));
            this.btnAdcionarFornecedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdcionarFornecedor.Location = new System.Drawing.Point(412, 12);
            this.btnAdcionarFornecedor.Name = "btnAdcionarFornecedor";
            this.btnAdcionarFornecedor.Size = new System.Drawing.Size(70, 60);
            this.btnAdcionarFornecedor.TabIndex = 12;
            this.btnAdcionarFornecedor.Text = "Adicionar";
            this.btnAdcionarFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdcionarFornecedor.UseVisualStyleBackColor = true;
            this.btnAdcionarFornecedor.Click += new System.EventHandler(this.btnAdcionarFornecedor_Click);
            // 
            // mTxtCPFFornecedor
            // 
            this.mTxtCPFFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtCPFFornecedor.Location = new System.Drawing.Point(12, 12);
            this.mTxtCPFFornecedor.Mask = "000,000,000-00";
            this.mTxtCPFFornecedor.Name = "mTxtCPFFornecedor";
            this.mTxtCPFFornecedor.Size = new System.Drawing.Size(122, 22);
            this.mTxtCPFFornecedor.TabIndex = 1;
            // 
            // rBtnCNPJFornecedor
            // 
            this.rBtnCNPJFornecedor.AutoSize = true;
            this.rBtnCNPJFornecedor.Location = new System.Drawing.Point(140, 15);
            this.rBtnCNPJFornecedor.Name = "rBtnCNPJFornecedor";
            this.rBtnCNPJFornecedor.Size = new System.Drawing.Size(52, 17);
            this.rBtnCNPJFornecedor.TabIndex = 18;
            this.rBtnCNPJFornecedor.TabStop = true;
            this.rBtnCNPJFornecedor.Text = "CNPJ";
            this.rBtnCNPJFornecedor.UseVisualStyleBackColor = true;
            this.rBtnCNPJFornecedor.CheckedChanged += new System.EventHandler(this.rBtnCNPJFornecedor_CheckedChanged);
            // 
            // rBtnCPFFornecedor
            // 
            this.rBtnCPFFornecedor.AutoSize = true;
            this.rBtnCPFFornecedor.Location = new System.Drawing.Point(198, 15);
            this.rBtnCPFFornecedor.Name = "rBtnCPFFornecedor";
            this.rBtnCPFFornecedor.Size = new System.Drawing.Size(45, 17);
            this.rBtnCPFFornecedor.TabIndex = 19;
            this.rBtnCPFFornecedor.TabStop = true;
            this.rBtnCPFFornecedor.Text = "CPF";
            this.rBtnCPFFornecedor.UseVisualStyleBackColor = true;
            // 
            // mTxtCNPJFornecedor
            // 
            this.mTxtCNPJFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtCNPJFornecedor.Location = new System.Drawing.Point(12, 12);
            this.mTxtCNPJFornecedor.Mask = "00,000,000/0000-00";
            this.mTxtCNPJFornecedor.Name = "mTxtCNPJFornecedor";
            this.mTxtCNPJFornecedor.Size = new System.Drawing.Size(122, 22);
            this.mTxtCNPJFornecedor.TabIndex = 0;
            // 
            // txtEnderecoFornecedor
            // 
            this.txtEnderecoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnderecoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoFornecedor.Location = new System.Drawing.Point(13, 236);
            this.txtEnderecoFornecedor.Name = "txtEnderecoFornecedor";
            this.txtEnderecoFornecedor.Size = new System.Drawing.Size(373, 22);
            this.txtEnderecoFornecedor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Endereço";
            // 
            // mTxtTelFixoFornecedor
            // 
            this.mTxtTelFixoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtTelFixoFornecedor.Location = new System.Drawing.Point(12, 280);
            this.mTxtTelFixoFornecedor.Mask = "(00)0000-0000";
            this.mTxtTelFixoFornecedor.Name = "mTxtTelFixoFornecedor";
            this.mTxtTelFixoFornecedor.Size = new System.Drawing.Size(122, 22);
            this.mTxtTelFixoFornecedor.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Telefone Fixo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(153, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Telefone Celular";
            // 
            // mTxtTelCelFornecedor
            // 
            this.mTxtTelCelFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtTelCelFornecedor.Location = new System.Drawing.Point(156, 280);
            this.mTxtTelCelFornecedor.Mask = "(00)00000-0000";
            this.mTxtTelCelFornecedor.Name = "mTxtTelCelFornecedor";
            this.mTxtTelCelFornecedor.Size = new System.Drawing.Size(122, 22);
            this.mTxtTelCelFornecedor.TabIndex = 9;
            // 
            // txtContatoFornecedor
            // 
            this.txtContatoFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContatoFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContatoFornecedor.Location = new System.Drawing.Point(13, 324);
            this.txtContatoFornecedor.Name = "txtContatoFornecedor";
            this.txtContatoFornecedor.Size = new System.Drawing.Size(373, 22);
            this.txtContatoFornecedor.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Contato";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdFornecedor});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 30;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // toolStripStatusIdFornecedor
            // 
            this.toolStripStatusIdFornecedor.Name = "toolStripStatusIdFornecedor";
            this.toolStripStatusIdFornecedor.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdFornecedor.Text = "0";
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFornecedor.Location = new System.Drawing.Point(13, 368);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(373, 22);
            this.txtEmailFornecedor.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Email";
            // 
            // ePrRazaoSocial
            // 
            this.ePrRazaoSocial.ContainerControl = this;
            // 
            // ePrNomeFantasia
            // 
            this.ePrNomeFantasia.ContainerControl = this;
            // 
            // ePrEstado
            // 
            this.ePrEstado.ContainerControl = this;
            // 
            // ePrCidade
            // 
            this.ePrCidade.ContainerControl = this;
            // 
            // ePrBairro
            // 
            this.ePrBairro.ContainerControl = this;
            // 
            // ePrEndereco
            // 
            this.ePrEndereco.ContainerControl = this;
            // 
            // ePrTelFixo
            // 
            this.ePrTelFixo.ContainerControl = this;
            // 
            // ePrTelCel
            // 
            this.ePrTelCel.ContainerControl = this;
            // 
            // ePrContato
            // 
            this.ePrContato.ContainerControl = this;
            // 
            // ePR
            // 
            this.ePR.ContainerControl = this;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.Controls.Add(this.txtEmailFornecedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtContatoFornecedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mTxtTelCelFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mTxtTelFixoFornecedor);
            this.Controls.Add(this.txtEnderecoFornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mTxtCNPJFornecedor);
            this.Controls.Add(this.rBtnCPFFornecedor);
            this.Controls.Add(this.rBtnCNPJFornecedor);
            this.Controls.Add(this.mTxtCPFFornecedor);
            this.Controls.Add(this.btnAdicionarBairroFornecedor);
            this.Controls.Add(this.cbxBairroFornecedor);
            this.Controls.Add(this.cbxCidadeFornecedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelarFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeFantasiaFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRazaoSocialFornecedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoFornecedor);
            this.Controls.Add(this.btnPesquisarFornecedor);
            this.Controls.Add(this.btnExcluirFornecedor);
            this.Controls.Add(this.btnEditarFornecedor);
            this.Controls.Add(this.btnAdcionarFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFornecedor_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrRazaoSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNomeFantasia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrBairro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEndereco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelFixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelCel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrContato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarBairroFornecedor;
        private System.Windows.Forms.ComboBox cbxBairroFornecedor;
        private System.Windows.Forms.ComboBox cbxCidadeFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeFantasiaFornecedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazaoSocialFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstadoFornecedor;
        private System.Windows.Forms.Button btnPesquisarFornecedor;
        private System.Windows.Forms.Button btnExcluirFornecedor;
        private System.Windows.Forms.Button btnEditarFornecedor;
        private System.Windows.Forms.Button btnAdcionarFornecedor;
        private System.Windows.Forms.MaskedTextBox mTxtCPFFornecedor;
        private System.Windows.Forms.RadioButton rBtnCNPJFornecedor;
        private System.Windows.Forms.RadioButton rBtnCPFFornecedor;
        private System.Windows.Forms.MaskedTextBox mTxtCNPJFornecedor;
        private System.Windows.Forms.TextBox txtEnderecoFornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mTxtTelFixoFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mTxtTelCelFornecedor;
        private System.Windows.Forms.TextBox txtContatoFornecedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdFornecedor;
        private System.Windows.Forms.TextBox txtEmailFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider ePrRazaoSocial;
        private System.Windows.Forms.ErrorProvider ePrNomeFantasia;
        private System.Windows.Forms.ErrorProvider ePrEstado;
        private System.Windows.Forms.ErrorProvider ePrCidade;
        private System.Windows.Forms.ErrorProvider ePrBairro;
        private System.Windows.Forms.ErrorProvider ePrEndereco;
        private System.Windows.Forms.ErrorProvider ePrTelFixo;
        private System.Windows.Forms.ErrorProvider ePrTelCel;
        private System.Windows.Forms.ErrorProvider ePrContato;
        private System.Windows.Forms.ErrorProvider ePR;
    }
}
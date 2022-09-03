namespace Gerenciador
{
    partial class FrmContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContrato));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSIdContrato = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSIdUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHistorico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAnoExercicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mTxtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxOrgao = new System.Windows.Forms.ComboBox();
            this.cbxForncedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxModalidade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNLicitacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNContrato = new System.Windows.Forms.TextBox();
            this.txtLocalArquivo = new System.Windows.Forms.TextBox();
            this.txtContratoTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLocalArquivo = new System.Windows.Forms.Button();
            this.btnCancelarContrato = new System.Windows.Forms.Button();
            this.btnPesquisarContrato = new System.Windows.Forms.Button();
            this.btnAdicionarItens = new System.Windows.Forms.Button();
            this.btnEditarContrato = new System.Windows.Forms.Button();
            this.btnAdicionarContrato = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContratoSaldo = new System.Windows.Forms.TextBox();
            this.ePrNContrato = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrAnoExercicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrDataInicial = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrDataFinal = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrFornecedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrModalidade = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrGenero = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrNLicitacao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrContratoTotal = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrContratoSaldo = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdGeneroContrato = new System.Windows.Forms.Button();
            this.btnAdOrgaoContrato = new System.Windows.Forms.Button();
            this.btnAdFornecedorContrato = new System.Windows.Forms.Button();
            this.oFDContratoPDF = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrAnoExercicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrDataInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrDataFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrOrgao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrModalidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrGenero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNLicitacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrContratoTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrContratoSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.tSSIdContrato,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tSSIdUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // tSSIdContrato
            // 
            this.tSSIdContrato.Name = "tSSIdContrato";
            this.tSSIdContrato.Size = new System.Drawing.Size(13, 17);
            this.tSSIdContrato.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(21, 17);
            this.toolStripStatusLabel1.Text = " -  ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel2.Text = "Usuário: ";
            // 
            // tSSIdUsuario
            // 
            this.tSSIdUsuario.Name = "tSSIdUsuario";
            this.tSSIdUsuario.Size = new System.Drawing.Size(40, 17);
            this.tSSIdUsuario.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Histórico";
            // 
            // txtHistorico
            // 
            this.txtHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHistorico.Location = new System.Drawing.Point(12, 280);
            this.txtHistorico.Multiline = true;
            this.txtHistorico.Name = "txtHistorico";
            this.txtHistorico.Size = new System.Drawing.Size(512, 74);
            this.txtHistorico.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ano Exercício";
            // 
            // cbxAnoExercicio
            // 
            this.cbxAnoExercicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxAnoExercicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAnoExercicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAnoExercicio.FormattingEnabled = true;
            this.cbxAnoExercicio.Items.AddRange(new object[] {
            "",
            "2017",
            "2018",
            "2019"});
            this.cbxAnoExercicio.Location = new System.Drawing.Point(217, 28);
            this.cbxAnoExercicio.Name = "cbxAnoExercicio";
            this.cbxAnoExercicio.Size = new System.Drawing.Size(100, 24);
            this.cbxAnoExercicio.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(341, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Data Final";
            // 
            // mTxtDataFinal
            // 
            this.mTxtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtDataFinal.Location = new System.Drawing.Point(444, 30);
            this.mTxtDataFinal.Mask = "00/00/0000";
            this.mTxtDataFinal.Name = "mTxtDataFinal";
            this.mTxtDataFinal.Size = new System.Drawing.Size(80, 22);
            this.mTxtDataFinal.TabIndex = 3;
            this.mTxtDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // mTxtDataInicial
            // 
            this.mTxtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtDataInicial.Location = new System.Drawing.Point(344, 30);
            this.mTxtDataInicial.Mask = "00/00/0000";
            this.mTxtDataInicial.Name = "mTxtDataInicial";
            this.mTxtDataInicial.Size = new System.Drawing.Size(80, 22);
            this.mTxtDataInicial.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Orgão";
            // 
            // cbxOrgao
            // 
            this.cbxOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrgao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxOrgao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrgao.FormattingEnabled = true;
            this.cbxOrgao.Location = new System.Drawing.Point(12, 78);
            this.cbxOrgao.Name = "cbxOrgao";
            this.cbxOrgao.Size = new System.Drawing.Size(456, 24);
            this.cbxOrgao.TabIndex = 4;
            // 
            // cbxForncedor
            // 
            this.cbxForncedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxForncedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxForncedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxForncedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxForncedor.FormattingEnabled = true;
            this.cbxForncedor.Location = new System.Drawing.Point(12, 128);
            this.cbxForncedor.Name = "cbxForncedor";
            this.cbxForncedor.Size = new System.Drawing.Size(456, 24);
            this.cbxForncedor.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fornecedor";
            // 
            // cbxModalidade
            // 
            this.cbxModalidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxModalidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxModalidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModalidade.FormattingEnabled = true;
            this.cbxModalidade.Location = new System.Drawing.Point(12, 180);
            this.cbxModalidade.Name = "cbxModalidade";
            this.cbxModalidade.Size = new System.Drawing.Size(512, 24);
            this.cbxModalidade.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Modalidade";
            // 
            // cbxGenero
            // 
            this.cbxGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(12, 230);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(268, 24);
            this.cbxGenero.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Gênero";
            // 
            // txtNLicitacao
            // 
            this.txtNLicitacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNLicitacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNLicitacao.Location = new System.Drawing.Point(358, 230);
            this.txtNLicitacao.Name = "txtNLicitacao";
            this.txtNLicitacao.Size = new System.Drawing.Size(166, 22);
            this.txtNLicitacao.TabIndex = 8;
            this.txtNLicitacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNLicitacao_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(355, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Número Licitação";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Número Contrato";
            // 
            // txtNContrato
            // 
            this.txtNContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNContrato.Location = new System.Drawing.Point(12, 30);
            this.txtNContrato.Name = "txtNContrato";
            this.txtNContrato.Size = new System.Drawing.Size(184, 22);
            this.txtNContrato.TabIndex = 0;
            this.txtNContrato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNContrato_KeyPress);
            // 
            // txtLocalArquivo
            // 
            this.txtLocalArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocalArquivo.Location = new System.Drawing.Point(12, 358);
            this.txtLocalArquivo.Name = "txtLocalArquivo";
            this.txtLocalArquivo.Size = new System.Drawing.Size(245, 22);
            this.txtLocalArquivo.TabIndex = 18;
            // 
            // txtContratoTotal
            // 
            this.txtContratoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratoTotal.Location = new System.Drawing.Point(19, 25);
            this.txtContratoTotal.Name = "txtContratoTotal";
            this.txtContratoTotal.Size = new System.Drawing.Size(127, 22);
            this.txtContratoTotal.TabIndex = 0;
            this.txtContratoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtContratoTotal.TextChanged += new System.EventHandler(this.txtContratoTotal_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(170, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Saldo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(181, 386);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(35, 30);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLocalArquivo
            // 
            this.btnLocalArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocalArquivo.Image = global::Gerenciador.Properties.Resources.folder_open;
            this.btnLocalArquivo.Location = new System.Drawing.Point(222, 386);
            this.btnLocalArquivo.Name = "btnLocalArquivo";
            this.btnLocalArquivo.Size = new System.Drawing.Size(35, 30);
            this.btnLocalArquivo.TabIndex = 18;
            this.btnLocalArquivo.UseVisualStyleBackColor = true;
            this.btnLocalArquivo.Click += new System.EventHandler(this.btnLocalArquivo_Click);
            // 
            // btnCancelarContrato
            // 
            this.btnCancelarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarContrato.Image")));
            this.btnCancelarContrato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarContrato.Location = new System.Drawing.Point(542, 275);
            this.btnCancelarContrato.Name = "btnCancelarContrato";
            this.btnCancelarContrato.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarContrato.TabIndex = 17;
            this.btnCancelarContrato.Text = "Cancelar";
            this.btnCancelarContrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarContrato.UseVisualStyleBackColor = true;
            this.btnCancelarContrato.Click += new System.EventHandler(this.btnCancelarContrato_Click);
            // 
            // btnPesquisarContrato
            // 
            this.btnPesquisarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarContrato.Image")));
            this.btnPesquisarContrato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarContrato.Location = new System.Drawing.Point(542, 209);
            this.btnPesquisarContrato.Name = "btnPesquisarContrato";
            this.btnPesquisarContrato.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarContrato.TabIndex = 16;
            this.btnPesquisarContrato.Text = "Pesquisar";
            this.btnPesquisarContrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarContrato.UseVisualStyleBackColor = true;
            this.btnPesquisarContrato.Click += new System.EventHandler(this.btnPesquisarContrato_Click);
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarItens.Enabled = false;
            this.btnAdicionarItens.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarItens.Image")));
            this.btnAdicionarItens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarItens.Location = new System.Drawing.Point(542, 142);
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Size = new System.Drawing.Size(70, 60);
            this.btnAdicionarItens.TabIndex = 15;
            this.btnAdicionarItens.Text = "Itens";
            this.btnAdicionarItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarItens.UseVisualStyleBackColor = true;
            this.btnAdicionarItens.Click += new System.EventHandler(this.btnAdicionarItens_Click);
            // 
            // btnEditarContrato
            // 
            this.btnEditarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarContrato.Enabled = false;
            this.btnEditarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarContrato.Image")));
            this.btnEditarContrato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarContrato.Location = new System.Drawing.Point(542, 77);
            this.btnEditarContrato.Name = "btnEditarContrato";
            this.btnEditarContrato.Size = new System.Drawing.Size(70, 60);
            this.btnEditarContrato.TabIndex = 14;
            this.btnEditarContrato.Text = "Editar";
            this.btnEditarContrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarContrato.UseVisualStyleBackColor = true;
            this.btnEditarContrato.Click += new System.EventHandler(this.btnEditarContrato_Click);
            // 
            // btnAdicionarContrato
            // 
            this.btnAdicionarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarContrato.Image")));
            this.btnAdicionarContrato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarContrato.Location = new System.Drawing.Point(542, 11);
            this.btnAdicionarContrato.Name = "btnAdicionarContrato";
            this.btnAdicionarContrato.Size = new System.Drawing.Size(70, 60);
            this.btnAdicionarContrato.TabIndex = 10;
            this.btnAdicionarContrato.Text = "Adicionar";
            this.btnAdicionarContrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarContrato.UseVisualStyleBackColor = true;
            this.btnAdicionarContrato.Click += new System.EventHandler(this.btnAdicionarContrato_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtContratoSaldo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtContratoTotal);
            this.panel1.Location = new System.Drawing.Point(266, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 58);
            this.panel1.TabIndex = 9;
            // 
            // txtContratoSaldo
            // 
            this.txtContratoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratoSaldo.Location = new System.Drawing.Point(173, 25);
            this.txtContratoSaldo.Name = "txtContratoSaldo";
            this.txtContratoSaldo.ReadOnly = true;
            this.txtContratoSaldo.Size = new System.Drawing.Size(127, 22);
            this.txtContratoSaldo.TabIndex = 1;
            this.txtContratoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ePrNContrato
            // 
            this.ePrNContrato.ContainerControl = this;
            // 
            // ePrAnoExercicio
            // 
            this.ePrAnoExercicio.ContainerControl = this;
            // 
            // ePrDataInicial
            // 
            this.ePrDataInicial.ContainerControl = this;
            // 
            // ePrDataFinal
            // 
            this.ePrDataFinal.ContainerControl = this;
            // 
            // ePrOrgao
            // 
            this.ePrOrgao.ContainerControl = this;
            // 
            // ePrFornecedor
            // 
            this.ePrFornecedor.ContainerControl = this;
            // 
            // ePrModalidade
            // 
            this.ePrModalidade.ContainerControl = this;
            // 
            // ePrGenero
            // 
            this.ePrGenero.ContainerControl = this;
            // 
            // ePrNLicitacao
            // 
            this.ePrNLicitacao.ContainerControl = this;
            // 
            // ePrContratoTotal
            // 
            this.ePrContratoTotal.ContainerControl = this;
            // 
            // ePrContratoSaldo
            // 
            this.ePrContratoSaldo.ContainerControl = this;
            // 
            // btnAdGeneroContrato
            // 
            this.btnAdGeneroContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdGeneroContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnAdGeneroContrato.Image")));
            this.btnAdGeneroContrato.Location = new System.Drawing.Point(302, 221);
            this.btnAdGeneroContrato.Name = "btnAdGeneroContrato";
            this.btnAdGeneroContrato.Size = new System.Drawing.Size(50, 40);
            this.btnAdGeneroContrato.TabIndex = 34;
            this.btnAdGeneroContrato.UseVisualStyleBackColor = true;
            this.btnAdGeneroContrato.Click += new System.EventHandler(this.btnAdGeneroContrato_Click);
            // 
            // btnAdOrgaoContrato
            // 
            this.btnAdOrgaoContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdOrgaoContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnAdOrgaoContrato.Image")));
            this.btnAdOrgaoContrato.Location = new System.Drawing.Point(486, 69);
            this.btnAdOrgaoContrato.Name = "btnAdOrgaoContrato";
            this.btnAdOrgaoContrato.Size = new System.Drawing.Size(50, 40);
            this.btnAdOrgaoContrato.TabIndex = 35;
            this.btnAdOrgaoContrato.UseVisualStyleBackColor = true;
            this.btnAdOrgaoContrato.Click += new System.EventHandler(this.btnAdOrgaoContrato_Click);
            // 
            // btnAdFornecedorContrato
            // 
            this.btnAdFornecedorContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdFornecedorContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnAdFornecedorContrato.Image")));
            this.btnAdFornecedorContrato.Location = new System.Drawing.Point(486, 119);
            this.btnAdFornecedorContrato.Name = "btnAdFornecedorContrato";
            this.btnAdFornecedorContrato.Size = new System.Drawing.Size(50, 40);
            this.btnAdFornecedorContrato.TabIndex = 36;
            this.btnAdFornecedorContrato.UseVisualStyleBackColor = true;
            this.btnAdFornecedorContrato.Click += new System.EventHandler(this.btnAdFornecedorContrato_Click);
            // 
            // oFDContratoPDF
            // 
            this.oFDContratoPDF.FileName = "*.pdf";
            // 
            // FrmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnAdFornecedorContrato);
            this.Controls.Add(this.btnAdOrgaoContrato);
            this.Controls.Add(this.btnAdGeneroContrato);
            this.Controls.Add(this.btnCancelarContrato);
            this.Controls.Add(this.btnPesquisarContrato);
            this.Controls.Add(this.btnAdicionarItens);
            this.Controls.Add(this.btnEditarContrato);
            this.Controls.Add(this.btnAdicionarContrato);
            this.Controls.Add(this.btnLocalArquivo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtLocalArquivo);
            this.Controls.Add(this.txtNContrato);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNLicitacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbxModalidade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxForncedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxOrgao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTxtDataInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mTxtDataFinal);
            this.Controls.Add(this.cbxAnoExercicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHistorico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContrato_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrAnoExercicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrDataInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrDataFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrOrgao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrModalidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrGenero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNLicitacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrContratoTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrContratoSaldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel tSSIdContrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHistorico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAnoExercicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mTxtDataFinal;
        private System.Windows.Forms.MaskedTextBox mTxtDataInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxOrgao;
        private System.Windows.Forms.ComboBox cbxForncedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxModalidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNLicitacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNContrato;
        private System.Windows.Forms.TextBox txtLocalArquivo;
        private System.Windows.Forms.TextBox txtContratoTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLocalArquivo;
        private System.Windows.Forms.Button btnCancelarContrato;
        private System.Windows.Forms.Button btnPesquisarContrato;
        private System.Windows.Forms.Button btnAdicionarItens;
        private System.Windows.Forms.Button btnEditarContrato;
        private System.Windows.Forms.Button btnAdicionarContrato;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtContratoSaldo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tSSIdUsuario;
        private System.Windows.Forms.ErrorProvider ePrNContrato;
        private System.Windows.Forms.ErrorProvider ePrAnoExercicio;
        private System.Windows.Forms.ErrorProvider ePrDataInicial;
        private System.Windows.Forms.ErrorProvider ePrDataFinal;
        private System.Windows.Forms.ErrorProvider ePrOrgao;
        private System.Windows.Forms.ErrorProvider ePrFornecedor;
        private System.Windows.Forms.ErrorProvider ePrModalidade;
        private System.Windows.Forms.ErrorProvider ePrGenero;
        private System.Windows.Forms.ErrorProvider ePrNLicitacao;
        private System.Windows.Forms.ErrorProvider ePrContratoTotal;
        private System.Windows.Forms.ErrorProvider ePrContratoSaldo;
        private System.Windows.Forms.Button btnAdFornecedorContrato;
        private System.Windows.Forms.Button btnAdOrgaoContrato;
        private System.Windows.Forms.Button btnAdGeneroContrato;
        private System.Windows.Forms.OpenFileDialog oFDContratoPDF;
    }
}
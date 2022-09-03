namespace Gerenciador
{
    partial class FrmDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamento));
            this.label7 = new System.Windows.Forms.Label();
            this.mTxtTelFixoDepartamento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxOrgaoDepartamento = new System.Windows.Forms.ComboBox();
            this.btnAdicionarResponsavelOrgao = new System.Windows.Forms.Button();
            this.btnAdicionarBairroOrgao = new System.Windows.Forms.Button();
            this.cbxBairroDepartamento = new System.Windows.Forms.ComboBox();
            this.cbxCidadeDepartamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelarDepartamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstadoDepartamento = new System.Windows.Forms.ComboBox();
            this.btnPesquisarDepartamento = new System.Windows.Forms.Button();
            this.btnExcluirDepartamento = new System.Windows.Forms.Button();
            this.btnEditarDepartamento = new System.Windows.Forms.Button();
            this.btnAdicionarDepartamento = new System.Windows.Forms.Button();
            this.ePrNomeDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrEstadoDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdDepartamento = new System.Windows.Forms.ToolStripStatusLabel();
            this.ePrCidadeDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrBairroDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrTelFixoDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrOrgaoDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrEnderecoDepartamento = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ePrNomeDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEstadoDepartamento)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrCidadeDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrBairroDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelFixoDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrOrgaoDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEnderecoDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Telefone Fixo";
            // 
            // mTxtTelFixoDepartamento
            // 
            this.mTxtTelFixoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtTelFixoDepartamento.Location = new System.Drawing.Point(13, 251);
            this.mTxtTelFixoDepartamento.Mask = "(00)0000-0000";
            this.mTxtTelFixoDepartamento.Name = "mTxtTelFixoDepartamento";
            this.mTxtTelFixoDepartamento.Size = new System.Drawing.Size(110, 22);
            this.mTxtTelFixoDepartamento.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Orgão";
            // 
            // cbxOrgaoDepartamento
            // 
            this.cbxOrgaoDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxOrgaoDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxOrgaoDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOrgaoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrgaoDepartamento.FormattingEnabled = true;
            this.cbxOrgaoDepartamento.Location = new System.Drawing.Point(13, 301);
            this.cbxOrgaoDepartamento.Name = "cbxOrgaoDepartamento";
            this.cbxOrgaoDepartamento.Size = new System.Drawing.Size(258, 24);
            this.cbxOrgaoDepartamento.TabIndex = 27;
            // 
            // btnAdicionarResponsavelOrgao
            // 
            this.btnAdicionarResponsavelOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarResponsavelOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarResponsavelOrgao.Image")));
            this.btnAdicionarResponsavelOrgao.Location = new System.Drawing.Point(292, 292);
            this.btnAdicionarResponsavelOrgao.Name = "btnAdicionarResponsavelOrgao";
            this.btnAdicionarResponsavelOrgao.Size = new System.Drawing.Size(50, 40);
            this.btnAdicionarResponsavelOrgao.TabIndex = 34;
            this.btnAdicionarResponsavelOrgao.UseVisualStyleBackColor = true;
            this.btnAdicionarResponsavelOrgao.Click += new System.EventHandler(this.btnAdicionarResponsavelOrgao_Click);
            // 
            // btnAdicionarBairroOrgao
            // 
            this.btnAdicionarBairroOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarBairroOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarBairroOrgao.Image")));
            this.btnAdicionarBairroOrgao.Location = new System.Drawing.Point(292, 152);
            this.btnAdicionarBairroOrgao.Name = "btnAdicionarBairroOrgao";
            this.btnAdicionarBairroOrgao.Size = new System.Drawing.Size(50, 40);
            this.btnAdicionarBairroOrgao.TabIndex = 33;
            this.btnAdicionarBairroOrgao.UseVisualStyleBackColor = true;
            this.btnAdicionarBairroOrgao.Click += new System.EventHandler(this.btnAdicionarBairroOrgao_Click);
            // 
            // cbxBairroDepartamento
            // 
            this.cbxBairroDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBairroDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBairroDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBairroDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBairroDepartamento.FormattingEnabled = true;
            this.cbxBairroDepartamento.Location = new System.Drawing.Point(13, 161);
            this.cbxBairroDepartamento.Name = "cbxBairroDepartamento";
            this.cbxBairroDepartamento.Size = new System.Drawing.Size(260, 24);
            this.cbxBairroDepartamento.TabIndex = 24;
            // 
            // cbxCidadeDepartamento
            // 
            this.cbxCidadeDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCidadeDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCidadeDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCidadeDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidadeDepartamento.FormattingEnabled = true;
            this.cbxCidadeDepartamento.Location = new System.Drawing.Point(13, 115);
            this.cbxCidadeDepartamento.Name = "cbxCidadeDepartamento";
            this.cbxCidadeDepartamento.Size = new System.Drawing.Size(260, 24);
            this.cbxCidadeDepartamento.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Bairro";
            // 
            // btnCancelarDepartamento
            // 
            this.btnCancelarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarDepartamento.Image")));
            this.btnCancelarDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarDepartamento.Location = new System.Drawing.Point(348, 282);
            this.btnCancelarDepartamento.Name = "btnCancelarDepartamento";
            this.btnCancelarDepartamento.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarDepartamento.TabIndex = 32;
            this.btnCancelarDepartamento.Text = "Cancelar";
            this.btnCancelarDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarDepartamento.UseVisualStyleBackColor = true;
            this.btnCancelarDepartamento.Click += new System.EventHandler(this.btnCancelarDepartamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Estado";
            // 
            // txtEnderecoDepartamento
            // 
            this.txtEnderecoDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnderecoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoDepartamento.Location = new System.Drawing.Point(13, 207);
            this.txtEnderecoDepartamento.Name = "txtEnderecoDepartamento";
            this.txtEnderecoDepartamento.Size = new System.Drawing.Size(319, 22);
            this.txtEnderecoDepartamento.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Endereço";
            // 
            // txtNomeDepartamento
            // 
            this.txtNomeDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDepartamento.Location = new System.Drawing.Point(13, 25);
            this.txtNomeDepartamento.Name = "txtNomeDepartamento";
            this.txtNomeDepartamento.Size = new System.Drawing.Size(319, 22);
            this.txtNomeDepartamento.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Departamento";
            // 
            // cbxEstadoDepartamento
            // 
            this.cbxEstadoDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstadoDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEstadoDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEstadoDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoDepartamento.FormattingEnabled = true;
            this.cbxEstadoDepartamento.Location = new System.Drawing.Point(13, 69);
            this.cbxEstadoDepartamento.Name = "cbxEstadoDepartamento";
            this.cbxEstadoDepartamento.Size = new System.Drawing.Size(260, 24);
            this.cbxEstadoDepartamento.TabIndex = 22;
            this.cbxEstadoDepartamento.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoDepartamento_SelectedIndexChanged);
            // 
            // btnPesquisarDepartamento
            // 
            this.btnPesquisarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarDepartamento.Image")));
            this.btnPesquisarDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarDepartamento.Location = new System.Drawing.Point(348, 216);
            this.btnPesquisarDepartamento.Name = "btnPesquisarDepartamento";
            this.btnPesquisarDepartamento.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarDepartamento.TabIndex = 31;
            this.btnPesquisarDepartamento.Text = "Pesquisar";
            this.btnPesquisarDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarDepartamento.UseVisualStyleBackColor = true;
            this.btnPesquisarDepartamento.Click += new System.EventHandler(this.btnPesquisarDepartamento_Click);
            // 
            // btnExcluirDepartamento
            // 
            this.btnExcluirDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirDepartamento.Enabled = false;
            this.btnExcluirDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirDepartamento.Image")));
            this.btnExcluirDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirDepartamento.Location = new System.Drawing.Point(348, 150);
            this.btnExcluirDepartamento.Name = "btnExcluirDepartamento";
            this.btnExcluirDepartamento.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirDepartamento.TabIndex = 30;
            this.btnExcluirDepartamento.Text = "Excluir";
            this.btnExcluirDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirDepartamento.UseVisualStyleBackColor = true;
            this.btnExcluirDepartamento.Click += new System.EventHandler(this.btnExcluirDepartamento_Click);
            // 
            // btnEditarDepartamento
            // 
            this.btnEditarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarDepartamento.Enabled = false;
            this.btnEditarDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarDepartamento.Image")));
            this.btnEditarDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarDepartamento.Location = new System.Drawing.Point(348, 84);
            this.btnEditarDepartamento.Name = "btnEditarDepartamento";
            this.btnEditarDepartamento.Size = new System.Drawing.Size(70, 60);
            this.btnEditarDepartamento.TabIndex = 29;
            this.btnEditarDepartamento.Text = "Editar";
            this.btnEditarDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarDepartamento.UseVisualStyleBackColor = true;
            this.btnEditarDepartamento.Click += new System.EventHandler(this.btnEditarDepartamento_Click);
            // 
            // btnAdicionarDepartamento
            // 
            this.btnAdicionarDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarDepartamento.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarDepartamento.Image")));
            this.btnAdicionarDepartamento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarDepartamento.Location = new System.Drawing.Point(348, 18);
            this.btnAdicionarDepartamento.Name = "btnAdicionarDepartamento";
            this.btnAdicionarDepartamento.Size = new System.Drawing.Size(70, 60);
            this.btnAdicionarDepartamento.TabIndex = 28;
            this.btnAdicionarDepartamento.Text = "Adicionar";
            this.btnAdicionarDepartamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarDepartamento.UseVisualStyleBackColor = true;
            this.btnAdicionarDepartamento.Click += new System.EventHandler(this.btnAdicionarDepartamento_Click);
            // 
            // ePrNomeDepartamento
            // 
            this.ePrNomeDepartamento.ContainerControl = this;
            // 
            // ePrEstadoDepartamento
            // 
            this.ePrEstadoDepartamento.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdDepartamento});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(429, 22);
            this.statusStrip1.TabIndex = 42;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // toolStripStatusIdDepartamento
            // 
            this.toolStripStatusIdDepartamento.Name = "toolStripStatusIdDepartamento";
            this.toolStripStatusIdDepartamento.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdDepartamento.Text = "0";
            // 
            // ePrCidadeDepartamento
            // 
            this.ePrCidadeDepartamento.ContainerControl = this;
            // 
            // ePrBairroDepartamento
            // 
            this.ePrBairroDepartamento.ContainerControl = this;
            // 
            // ePrTelFixoDepartamento
            // 
            this.ePrTelFixoDepartamento.ContainerControl = this;
            // 
            // ePrOrgaoDepartamento
            // 
            this.ePrOrgaoDepartamento.ContainerControl = this;
            // 
            // ePrEnderecoDepartamento
            // 
            this.ePrEnderecoDepartamento.ContainerControl = this;
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mTxtTelFixoDepartamento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxOrgaoDepartamento);
            this.Controls.Add(this.btnAdicionarResponsavelOrgao);
            this.Controls.Add(this.btnAdicionarBairroOrgao);
            this.Controls.Add(this.cbxBairroDepartamento);
            this.Controls.Add(this.cbxCidadeDepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelarDepartamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnderecoDepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeDepartamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoDepartamento);
            this.Controls.Add(this.btnPesquisarDepartamento);
            this.Controls.Add(this.btnExcluirDepartamento);
            this.Controls.Add(this.btnEditarDepartamento);
            this.Controls.Add(this.btnAdicionarDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDepartamento_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ePrNomeDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEstadoDepartamento)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrCidadeDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrBairroDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelFixoDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrOrgaoDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEnderecoDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mTxtTelFixoDepartamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxOrgaoDepartamento;
        private System.Windows.Forms.Button btnAdicionarResponsavelOrgao;
        private System.Windows.Forms.Button btnAdicionarBairroOrgao;
        private System.Windows.Forms.ComboBox cbxBairroDepartamento;
        private System.Windows.Forms.ComboBox cbxCidadeDepartamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnderecoDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstadoDepartamento;
        private System.Windows.Forms.Button btnPesquisarDepartamento;
        private System.Windows.Forms.Button btnExcluirDepartamento;
        private System.Windows.Forms.Button btnEditarDepartamento;
        private System.Windows.Forms.Button btnAdicionarDepartamento;
        private System.Windows.Forms.ErrorProvider ePrNomeDepartamento;
        private System.Windows.Forms.ErrorProvider ePrEstadoDepartamento;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdDepartamento;
        private System.Windows.Forms.ErrorProvider ePrCidadeDepartamento;
        private System.Windows.Forms.ErrorProvider ePrBairroDepartamento;
        private System.Windows.Forms.ErrorProvider ePrTelFixoDepartamento;
        private System.Windows.Forms.ErrorProvider ePrOrgaoDepartamento;
        private System.Windows.Forms.ErrorProvider ePrEnderecoDepartamento;
    }
}
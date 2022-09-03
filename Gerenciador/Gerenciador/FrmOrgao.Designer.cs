namespace Gerenciador
{
    partial class FrmOrgao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrgao));
            this.btnAdicionarResponsavelOrgao = new System.Windows.Forms.Button();
            this.btnAdicionarBairroOrgao = new System.Windows.Forms.Button();
            this.cbxBairroOrgao = new System.Windows.Forms.ComboBox();
            this.cbxCidadeOrgao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelarOrgao = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoOrgao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeOrgao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstadoOrgao = new System.Windows.Forms.ComboBox();
            this.btnPesquisarOrgao = new System.Windows.Forms.Button();
            this.btnExcluirOrgao = new System.Windows.Forms.Button();
            this.btnEditarOrgao = new System.Windows.Forms.Button();
            this.btnAdicionarOrgao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxResponsavelOrgao = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdOrgao = new System.Windows.Forms.ToolStripStatusLabel();
            this.mTxtTelFixoOrgao = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ePrNomeOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrEstadoOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrCidadeOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrBairroOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrEnderecoOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrTelFixoOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.ePrResponsavelOrgao = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNomeOrgao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEstadoOrgao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrCidadeOrgao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrBairroOrgao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEnderecoOrgao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelFixoOrgao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrResponsavelOrgao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarResponsavelOrgao
            // 
            this.btnAdicionarResponsavelOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarResponsavelOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarResponsavelOrgao.Image")));
            this.btnAdicionarResponsavelOrgao.Location = new System.Drawing.Point(292, 292);
            this.btnAdicionarResponsavelOrgao.Name = "btnAdicionarResponsavelOrgao";
            this.btnAdicionarResponsavelOrgao.Size = new System.Drawing.Size(50, 40);
            this.btnAdicionarResponsavelOrgao.TabIndex = 13;
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
            this.btnAdicionarBairroOrgao.TabIndex = 12;
            this.btnAdicionarBairroOrgao.UseVisualStyleBackColor = true;
            this.btnAdicionarBairroOrgao.Click += new System.EventHandler(this.btnAdicionarBairroOrgao_Click);
            // 
            // cbxBairroOrgao
            // 
            this.cbxBairroOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxBairroOrgao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxBairroOrgao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxBairroOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxBairroOrgao.FormattingEnabled = true;
            this.cbxBairroOrgao.Location = new System.Drawing.Point(13, 161);
            this.cbxBairroOrgao.Name = "cbxBairroOrgao";
            this.cbxBairroOrgao.Size = new System.Drawing.Size(260, 24);
            this.cbxBairroOrgao.TabIndex = 3;
            // 
            // cbxCidadeOrgao
            // 
            this.cbxCidadeOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCidadeOrgao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCidadeOrgao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCidadeOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidadeOrgao.FormattingEnabled = true;
            this.cbxCidadeOrgao.Location = new System.Drawing.Point(13, 115);
            this.cbxCidadeOrgao.Name = "cbxCidadeOrgao";
            this.cbxCidadeOrgao.Size = new System.Drawing.Size(260, 24);
            this.cbxCidadeOrgao.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bairro";
            // 
            // btnCancelarOrgao
            // 
            this.btnCancelarOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOrgao.Image")));
            this.btnCancelarOrgao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarOrgao.Location = new System.Drawing.Point(348, 282);
            this.btnCancelarOrgao.Name = "btnCancelarOrgao";
            this.btnCancelarOrgao.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarOrgao.TabIndex = 11;
            this.btnCancelarOrgao.Text = "Cancelar";
            this.btnCancelarOrgao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarOrgao.UseVisualStyleBackColor = true;
            this.btnCancelarOrgao.Click += new System.EventHandler(this.btnCancelarOrgao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Estado";
            // 
            // txtEnderecoOrgao
            // 
            this.txtEnderecoOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnderecoOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoOrgao.Location = new System.Drawing.Point(13, 207);
            this.txtEnderecoOrgao.Name = "txtEnderecoOrgao";
            this.txtEnderecoOrgao.Size = new System.Drawing.Size(319, 22);
            this.txtEnderecoOrgao.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Endereço";
            // 
            // txtNomeOrgao
            // 
            this.txtNomeOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeOrgao.Location = new System.Drawing.Point(13, 25);
            this.txtNomeOrgao.Name = "txtNomeOrgao";
            this.txtNomeOrgao.Size = new System.Drawing.Size(319, 22);
            this.txtNomeOrgao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Orgão";
            // 
            // cbxEstadoOrgao
            // 
            this.cbxEstadoOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxEstadoOrgao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxEstadoOrgao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxEstadoOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstadoOrgao.FormattingEnabled = true;
            this.cbxEstadoOrgao.Location = new System.Drawing.Point(13, 69);
            this.cbxEstadoOrgao.Name = "cbxEstadoOrgao";
            this.cbxEstadoOrgao.Size = new System.Drawing.Size(260, 24);
            this.cbxEstadoOrgao.TabIndex = 1;
            this.cbxEstadoOrgao.SelectedIndexChanged += new System.EventHandler(this.cbxEstadoOrgao_SelectedIndexChanged);
            // 
            // btnPesquisarOrgao
            // 
            this.btnPesquisarOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarOrgao.Image")));
            this.btnPesquisarOrgao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarOrgao.Location = new System.Drawing.Point(348, 216);
            this.btnPesquisarOrgao.Name = "btnPesquisarOrgao";
            this.btnPesquisarOrgao.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarOrgao.TabIndex = 10;
            this.btnPesquisarOrgao.Text = "Pesquisar";
            this.btnPesquisarOrgao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarOrgao.UseVisualStyleBackColor = true;
            this.btnPesquisarOrgao.Click += new System.EventHandler(this.btnPesquisarOrgao_Click);
            // 
            // btnExcluirOrgao
            // 
            this.btnExcluirOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirOrgao.Enabled = false;
            this.btnExcluirOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirOrgao.Image")));
            this.btnExcluirOrgao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirOrgao.Location = new System.Drawing.Point(348, 150);
            this.btnExcluirOrgao.Name = "btnExcluirOrgao";
            this.btnExcluirOrgao.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirOrgao.TabIndex = 9;
            this.btnExcluirOrgao.Text = "Excluir";
            this.btnExcluirOrgao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirOrgao.UseVisualStyleBackColor = true;
            this.btnExcluirOrgao.Click += new System.EventHandler(this.btnExcluirOrgao_Click);
            // 
            // btnEditarOrgao
            // 
            this.btnEditarOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarOrgao.Enabled = false;
            this.btnEditarOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarOrgao.Image")));
            this.btnEditarOrgao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarOrgao.Location = new System.Drawing.Point(348, 84);
            this.btnEditarOrgao.Name = "btnEditarOrgao";
            this.btnEditarOrgao.Size = new System.Drawing.Size(70, 60);
            this.btnEditarOrgao.TabIndex = 8;
            this.btnEditarOrgao.Text = "Editar";
            this.btnEditarOrgao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarOrgao.UseVisualStyleBackColor = true;
            this.btnEditarOrgao.Click += new System.EventHandler(this.btnEditarOrgao_Click);
            // 
            // btnAdicionarOrgao
            // 
            this.btnAdicionarOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarOrgao.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarOrgao.Image")));
            this.btnAdicionarOrgao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarOrgao.Location = new System.Drawing.Point(348, 18);
            this.btnAdicionarOrgao.Name = "btnAdicionarOrgao";
            this.btnAdicionarOrgao.Size = new System.Drawing.Size(70, 60);
            this.btnAdicionarOrgao.TabIndex = 7;
            this.btnAdicionarOrgao.Text = "Adicionar";
            this.btnAdicionarOrgao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionarOrgao.UseVisualStyleBackColor = true;
            this.btnAdicionarOrgao.Click += new System.EventHandler(this.btnAdicionarOrgao_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Responsável";
            // 
            // cbxResponsavelOrgao
            // 
            this.cbxResponsavelOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxResponsavelOrgao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxResponsavelOrgao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxResponsavelOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxResponsavelOrgao.FormattingEnabled = true;
            this.cbxResponsavelOrgao.Location = new System.Drawing.Point(13, 301);
            this.cbxResponsavelOrgao.Name = "cbxResponsavelOrgao";
            this.cbxResponsavelOrgao.Size = new System.Drawing.Size(258, 24);
            this.cbxResponsavelOrgao.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdOrgao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(429, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // toolStripStatusIdOrgao
            // 
            this.toolStripStatusIdOrgao.Name = "toolStripStatusIdOrgao";
            this.toolStripStatusIdOrgao.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdOrgao.Text = "0";
            // 
            // mTxtTelFixoOrgao
            // 
            this.mTxtTelFixoOrgao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtTelFixoOrgao.Location = new System.Drawing.Point(13, 251);
            this.mTxtTelFixoOrgao.Mask = "(00)0000-0000";
            this.mTxtTelFixoOrgao.Name = "mTxtTelFixoOrgao";
            this.mTxtTelFixoOrgao.Size = new System.Drawing.Size(110, 22);
            this.mTxtTelFixoOrgao.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefone Fixo";
            // 
            // ePrNomeOrgao
            // 
            this.ePrNomeOrgao.ContainerControl = this;
            // 
            // ePrEstadoOrgao
            // 
            this.ePrEstadoOrgao.ContainerControl = this;
            // 
            // ePrCidadeOrgao
            // 
            this.ePrCidadeOrgao.ContainerControl = this;
            // 
            // ePrBairroOrgao
            // 
            this.ePrBairroOrgao.ContainerControl = this;
            // 
            // ePrEnderecoOrgao
            // 
            this.ePrEnderecoOrgao.ContainerControl = this;
            // 
            // ePrTelFixoOrgao
            // 
            this.ePrTelFixoOrgao.ContainerControl = this;
            // 
            // ePrResponsavelOrgao
            // 
            this.ePrResponsavelOrgao.ContainerControl = this;
            // 
            // FrmOrgao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mTxtTelFixoOrgao);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxResponsavelOrgao);
            this.Controls.Add(this.btnAdicionarResponsavelOrgao);
            this.Controls.Add(this.btnAdicionarBairroOrgao);
            this.Controls.Add(this.cbxBairroOrgao);
            this.Controls.Add(this.cbxCidadeOrgao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelarOrgao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnderecoOrgao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeOrgao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstadoOrgao);
            this.Controls.Add(this.btnPesquisarOrgao);
            this.Controls.Add(this.btnExcluirOrgao);
            this.Controls.Add(this.btnEditarOrgao);
            this.Controls.Add(this.btnAdicionarOrgao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmOrgao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orgão";
            this.Load += new System.EventHandler(this.FrmOrgao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOrgao_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePrNomeOrgao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEstadoOrgao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrCidadeOrgao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrBairroOrgao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrEnderecoOrgao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrTelFixoOrgao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrResponsavelOrgao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionarResponsavelOrgao;
        private System.Windows.Forms.Button btnAdicionarBairroOrgao;
        private System.Windows.Forms.ComboBox cbxBairroOrgao;
        private System.Windows.Forms.ComboBox cbxCidadeOrgao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarOrgao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnderecoOrgao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeOrgao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstadoOrgao;
        private System.Windows.Forms.Button btnPesquisarOrgao;
        private System.Windows.Forms.Button btnExcluirOrgao;
        private System.Windows.Forms.Button btnEditarOrgao;
        private System.Windows.Forms.Button btnAdicionarOrgao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxResponsavelOrgao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdOrgao;
        private System.Windows.Forms.MaskedTextBox mTxtTelFixoOrgao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider ePrNomeOrgao;
        private System.Windows.Forms.ErrorProvider ePrEstadoOrgao;
        private System.Windows.Forms.ErrorProvider ePrCidadeOrgao;
        private System.Windows.Forms.ErrorProvider ePrBairroOrgao;
        private System.Windows.Forms.ErrorProvider ePrEnderecoOrgao;
        private System.Windows.Forms.ErrorProvider ePrTelFixoOrgao;
        private System.Windows.Forms.ErrorProvider ePrResponsavelOrgao;
    }
}
namespace Gerenciador
{
    partial class FrmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdProduto = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalhesProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxUnidMedidaProduto = new System.Windows.Forms.ComboBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnAdcionarProduto = new System.Windows.Forms.Button();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxMarcaProduto = new System.Windows.Forms.ComboBox();
            this.cbxGeneroProduto = new System.Windows.Forms.ComboBox();
            this.btnAdicionarUnidMedida = new System.Windows.Forms.Button();
            this.btnAdicionarMarca = new System.Windows.Forms.Button();
            this.errorProviderDescricao = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDetalhes = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnidMedida = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderGenero = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdicionarGenero = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetalhes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnidMedida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdProduto});
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(429, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // toolStripStatusIdProduto
            // 
            this.toolStripStatusIdProduto.Name = "toolStripStatusIdProduto";
            this.toolStripStatusIdProduto.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdProduto.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Unid de Medida";
            // 
            // txtDetalhesProduto
            // 
            this.txtDetalhesProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDetalhesProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhesProduto.Location = new System.Drawing.Point(12, 98);
            this.txtDetalhesProduto.Name = "txtDetalhesProduto";
            this.txtDetalhesProduto.Size = new System.Drawing.Size(319, 22);
            this.txtDetalhesProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Detalhes";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(12, 33);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(319, 22);
            this.txtDescricaoProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Descrição";
            // 
            // cbxUnidMedidaProduto
            // 
            this.cbxUnidMedidaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxUnidMedidaProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxUnidMedidaProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxUnidMedidaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnidMedidaProduto.FormattingEnabled = true;
            this.cbxUnidMedidaProduto.Location = new System.Drawing.Point(12, 163);
            this.cbxUnidMedidaProduto.Name = "cbxUnidMedidaProduto";
            this.cbxUnidMedidaProduto.Size = new System.Drawing.Size(260, 24);
            this.cbxUnidMedidaProduto.TabIndex = 2;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.Image")));
            this.btnPesquisarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(347, 207);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarProduto.TabIndex = 8;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirProduto.Enabled = false;
            this.btnExcluirProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirProduto.Image")));
            this.btnExcluirProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirProduto.Location = new System.Drawing.Point(347, 141);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirProduto.TabIndex = 7;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarProduto.Enabled = false;
            this.btnEditarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarProduto.Image")));
            this.btnEditarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarProduto.Location = new System.Drawing.Point(347, 75);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(70, 60);
            this.btnEditarProduto.TabIndex = 6;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnAdcionarProduto
            // 
            this.btnAdcionarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdcionarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionarProduto.Image")));
            this.btnAdcionarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdcionarProduto.Location = new System.Drawing.Point(347, 9);
            this.btnAdcionarProduto.Name = "btnAdcionarProduto";
            this.btnAdcionarProduto.Size = new System.Drawing.Size(70, 60);
            this.btnAdcionarProduto.TabIndex = 5;
            this.btnAdcionarProduto.Text = "Adicionar";
            this.btnAdcionarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdcionarProduto.UseVisualStyleBackColor = true;
            this.btnAdcionarProduto.Click += new System.EventHandler(this.btnAdcionarProduto_Click);
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarProduto.Image")));
            this.btnCancelarProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarProduto.Location = new System.Drawing.Point(347, 273);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarProduto.TabIndex = 9;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarProduto.UseVisualStyleBackColor = true;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gênero";
            // 
            // cbxMarcaProduto
            // 
            this.cbxMarcaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxMarcaProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMarcaProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMarcaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarcaProduto.FormattingEnabled = true;
            this.cbxMarcaProduto.Location = new System.Drawing.Point(12, 230);
            this.cbxMarcaProduto.Name = "cbxMarcaProduto";
            this.cbxMarcaProduto.Size = new System.Drawing.Size(260, 24);
            this.cbxMarcaProduto.TabIndex = 3;
            // 
            // cbxGeneroProduto
            // 
            this.cbxGeneroProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxGeneroProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxGeneroProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxGeneroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGeneroProduto.FormattingEnabled = true;
            this.cbxGeneroProduto.Location = new System.Drawing.Point(12, 297);
            this.cbxGeneroProduto.Name = "cbxGeneroProduto";
            this.cbxGeneroProduto.Size = new System.Drawing.Size(260, 24);
            this.cbxGeneroProduto.TabIndex = 4;
            // 
            // btnAdicionarUnidMedida
            // 
            this.btnAdicionarUnidMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarUnidMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarUnidMedida.Image")));
            this.btnAdicionarUnidMedida.Location = new System.Drawing.Point(291, 154);
            this.btnAdicionarUnidMedida.Name = "btnAdicionarUnidMedida";
            this.btnAdicionarUnidMedida.Size = new System.Drawing.Size(50, 40);
            this.btnAdicionarUnidMedida.TabIndex = 16;
            this.btnAdicionarUnidMedida.UseVisualStyleBackColor = true;
            this.btnAdicionarUnidMedida.Click += new System.EventHandler(this.btnAdicionarUnidMedida_Click);
            // 
            // btnAdicionarMarca
            // 
            this.btnAdicionarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarMarca.Image")));
            this.btnAdicionarMarca.Location = new System.Drawing.Point(291, 221);
            this.btnAdicionarMarca.Name = "btnAdicionarMarca";
            this.btnAdicionarMarca.Size = new System.Drawing.Size(50, 40);
            this.btnAdicionarMarca.TabIndex = 17;
            this.btnAdicionarMarca.UseVisualStyleBackColor = true;
            this.btnAdicionarMarca.Click += new System.EventHandler(this.btnAdicionarMarca_Click);
            // 
            // errorProviderDescricao
            // 
            this.errorProviderDescricao.ContainerControl = this;
            // 
            // errorProviderDetalhes
            // 
            this.errorProviderDetalhes.ContainerControl = this;
            // 
            // errorProviderUnidMedida
            // 
            this.errorProviderUnidMedida.ContainerControl = this;
            // 
            // errorProviderMarca
            // 
            this.errorProviderMarca.ContainerControl = this;
            // 
            // errorProviderGenero
            // 
            this.errorProviderGenero.ContainerControl = this;
            // 
            // btnAdicionarGenero
            // 
            this.btnAdicionarGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarGenero.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarGenero.Image")));
            this.btnAdicionarGenero.Location = new System.Drawing.Point(291, 288);
            this.btnAdicionarGenero.Name = "btnAdicionarGenero";
            this.btnAdicionarGenero.Size = new System.Drawing.Size(50, 40);
            this.btnAdicionarGenero.TabIndex = 18;
            this.btnAdicionarGenero.UseVisualStyleBackColor = true;
            this.btnAdicionarGenero.Click += new System.EventHandler(this.btnAdicionarGenero_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 366);
            this.Controls.Add(this.btnAdicionarGenero);
            this.Controls.Add(this.btnAdicionarMarca);
            this.Controls.Add(this.btnAdicionarUnidMedida);
            this.Controls.Add(this.cbxGeneroProduto);
            this.Controls.Add(this.cbxMarcaProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelarProduto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDetalhesProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxUnidMedidaProduto);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnAdcionarProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduto_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDetalhes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnidMedida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalhesProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxUnidMedidaProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnAdcionarProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxMarcaProduto;
        private System.Windows.Forms.ComboBox cbxGeneroProduto;
        private System.Windows.Forms.Button btnAdicionarUnidMedida;
        private System.Windows.Forms.Button btnAdicionarMarca;
        private System.Windows.Forms.ErrorProvider errorProviderDescricao;
        private System.Windows.Forms.ErrorProvider errorProviderDetalhes;
        private System.Windows.Forms.ErrorProvider errorProviderUnidMedida;
        private System.Windows.Forms.ErrorProvider errorProviderMarca;
        private System.Windows.Forms.ErrorProvider errorProviderGenero;
        private System.Windows.Forms.Button btnAdicionarGenero;
    }
}
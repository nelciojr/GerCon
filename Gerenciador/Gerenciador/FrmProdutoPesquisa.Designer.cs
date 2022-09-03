namespace Gerenciador
{
    partial class FrmProdutoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnProdutoCancelar = new System.Windows.Forms.Button();
            this.btnProdutoSelecionar = new System.Windows.Forms.Button();
            this.btnProdutoPesquisa = new System.Windows.Forms.Button();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.txtProdutoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidMedidaProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProdutoCancelar
            // 
            this.btnProdutoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdutoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnProdutoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutoCancelar.Image")));
            this.btnProdutoCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutoCancelar.Location = new System.Drawing.Point(602, 147);
            this.btnProdutoCancelar.Name = "btnProdutoCancelar";
            this.btnProdutoCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnProdutoCancelar.TabIndex = 23;
            this.btnProdutoCancelar.Text = "Cancelar";
            this.btnProdutoCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutoCancelar.UseVisualStyleBackColor = true;
            this.btnProdutoCancelar.Click += new System.EventHandler(this.btnProdutoCancelar_Click);
            // 
            // btnProdutoSelecionar
            // 
            this.btnProdutoSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdutoSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutoSelecionar.Image")));
            this.btnProdutoSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutoSelecionar.Location = new System.Drawing.Point(602, 81);
            this.btnProdutoSelecionar.Name = "btnProdutoSelecionar";
            this.btnProdutoSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnProdutoSelecionar.TabIndex = 22;
            this.btnProdutoSelecionar.Text = "Selecionar";
            this.btnProdutoSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutoSelecionar.UseVisualStyleBackColor = true;
            this.btnProdutoSelecionar.Click += new System.EventHandler(this.btnProdutoSelecionar_Click);
            // 
            // btnProdutoPesquisa
            // 
            this.btnProdutoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProdutoPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutoPesquisa.Image")));
            this.btnProdutoPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProdutoPesquisa.Location = new System.Drawing.Point(602, 15);
            this.btnProdutoPesquisa.Name = "btnProdutoPesquisa";
            this.btnProdutoPesquisa.Size = new System.Drawing.Size(70, 60);
            this.btnProdutoPesquisa.TabIndex = 21;
            this.btnProdutoPesquisa.Text = "Pesquisar";
            this.btnProdutoPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProdutoPesquisa.UseVisualStyleBackColor = true;
            this.btnProdutoPesquisa.Click += new System.EventHandler(this.btnProdutoPesquisa_Click);
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Produto,
            this.Descricao,
            this.Detalhe,
            this.MarcaProduto,
            this.UnidMedidaProduto,
            this.GeneroProduto});
            this.dataGridViewProduto.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProduto.Location = new System.Drawing.Point(10, 44);
            this.dataGridViewProduto.MultiSelect = false;
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduto.Size = new System.Drawing.Size(584, 206);
            this.dataGridViewProduto.TabIndex = 20;
            this.dataGridViewProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduto_CellDoubleClick);
            this.dataGridViewProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewProduto_CellFormatting);
            this.dataGridViewProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewProduto_KeyDown);
            // 
            // txtProdutoPesquisa
            // 
            this.txtProdutoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProdutoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutoPesquisa.Location = new System.Drawing.Point(68, 12);
            this.txtProdutoPesquisa.Name = "txtProdutoPesquisa";
            this.txtProdutoPesquisa.Size = new System.Drawing.Size(526, 22);
            this.txtProdutoPesquisa.TabIndex = 19;
            this.txtProdutoPesquisa.TextChanged += new System.EventHandler(this.txtProdutoPesquisa_TextChanged);
            this.txtProdutoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProdutoPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Produto";
            // 
            // Id_Produto
            // 
            this.Id_Produto.DataPropertyName = "Id_Produto";
            this.Id_Produto.HeaderText = "Id Produto";
            this.Id_Produto.Name = "Id_Produto";
            this.Id_Produto.ReadOnly = true;
            this.Id_Produto.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 200;
            // 
            // Detalhe
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalhe.DefaultCellStyle = dataGridViewCellStyle4;
            this.Detalhe.HeaderText = "Detalhe";
            this.Detalhe.Name = "Detalhe";
            this.Detalhe.ReadOnly = true;
            this.Detalhe.Visible = false;
            // 
            // MarcaProduto
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.MarcaProduto.HeaderText = "Marca";
            this.MarcaProduto.Name = "MarcaProduto";
            this.MarcaProduto.ReadOnly = true;
            this.MarcaProduto.Width = 120;
            // 
            // UnidMedidaProduto
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnidMedidaProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.UnidMedidaProduto.HeaderText = "Unidade";
            this.UnidMedidaProduto.Name = "UnidMedidaProduto";
            this.UnidMedidaProduto.ReadOnly = true;
            this.UnidMedidaProduto.Width = 90;
            // 
            // GeneroProduto
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroProduto.DefaultCellStyle = dataGridViewCellStyle7;
            this.GeneroProduto.HeaderText = "Gênero";
            this.GeneroProduto.Name = "GeneroProduto";
            this.GeneroProduto.ReadOnly = true;
            this.GeneroProduto.Width = 120;
            // 
            // FrmProdutoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.btnProdutoCancelar);
            this.Controls.Add(this.btnProdutoSelecionar);
            this.Controls.Add(this.btnProdutoPesquisa);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.txtProdutoPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmProdutoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProdutoPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProdutoCancelar;
        private System.Windows.Forms.Button btnProdutoSelecionar;
        private System.Windows.Forms.Button btnProdutoPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.TextBox txtProdutoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidMedidaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroProduto;
    }
}
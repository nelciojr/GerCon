namespace Gerenciador
{
    partial class FrmFornecedorPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedorPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFornecedorCancelar = new System.Windows.Forms.Button();
            this.btnFornecedorSelecionar = new System.Windows.Forms.Button();
            this.btnFornecedorPesquisa = new System.Windows.Forms.Button();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.txtFornecedorPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razao_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Fantasia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF_CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Fixo_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Cel_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFornecedorCancelar
            // 
            this.btnFornecedorCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFornecedorCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFornecedorCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedorCancelar.Image")));
            this.btnFornecedorCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedorCancelar.Location = new System.Drawing.Point(672, 144);
            this.btnFornecedorCancelar.Name = "btnFornecedorCancelar";
            this.btnFornecedorCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnFornecedorCancelar.TabIndex = 29;
            this.btnFornecedorCancelar.Text = "Cancelar";
            this.btnFornecedorCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedorCancelar.UseVisualStyleBackColor = true;
            this.btnFornecedorCancelar.Click += new System.EventHandler(this.btnFornecedorCancelar_Click);
            // 
            // btnFornecedorSelecionar
            // 
            this.btnFornecedorSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFornecedorSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedorSelecionar.Image")));
            this.btnFornecedorSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedorSelecionar.Location = new System.Drawing.Point(672, 78);
            this.btnFornecedorSelecionar.Name = "btnFornecedorSelecionar";
            this.btnFornecedorSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnFornecedorSelecionar.TabIndex = 28;
            this.btnFornecedorSelecionar.Text = "Selecionar";
            this.btnFornecedorSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedorSelecionar.UseVisualStyleBackColor = true;
            this.btnFornecedorSelecionar.Click += new System.EventHandler(this.btnFornecedorSelecionar_Click);
            // 
            // btnFornecedorPesquisa
            // 
            this.btnFornecedorPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFornecedorPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedorPesquisa.Image")));
            this.btnFornecedorPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFornecedorPesquisa.Location = new System.Drawing.Point(672, 12);
            this.btnFornecedorPesquisa.Name = "btnFornecedorPesquisa";
            this.btnFornecedorPesquisa.Size = new System.Drawing.Size(70, 60);
            this.btnFornecedorPesquisa.TabIndex = 27;
            this.btnFornecedorPesquisa.Text = "Pesquisar";
            this.btnFornecedorPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFornecedorPesquisa.UseVisualStyleBackColor = true;
            this.btnFornecedorPesquisa.Click += new System.EventHandler(this.btnFornecedorPesquisa_Click);
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.AllowUserToAddRows = false;
            this.dataGridViewFornecedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFornecedor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Fornecedor,
            this.Razao_Social,
            this.Nome_Fantasia,
            this.CPF_CNPJ,
            this.Contato,
            this.Tel_Fixo_Fornecedor,
            this.Tel_Cel_Fornecedor,
            this.Email_Fornecedor});
            this.dataGridViewFornecedor.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(15, 39);
            this.dataGridViewFornecedor.MultiSelect = false;
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(651, 206);
            this.dataGridViewFornecedor.TabIndex = 26;
            this.dataGridViewFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedor_CellDoubleClick);
            this.dataGridViewFornecedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewFornecedor_KeyDown);
            // 
            // txtFornecedorPesquisa
            // 
            this.txtFornecedorPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFornecedorPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedorPesquisa.Location = new System.Drawing.Point(96, 11);
            this.txtFornecedorPesquisa.Name = "txtFornecedorPesquisa";
            this.txtFornecedorPesquisa.Size = new System.Drawing.Size(570, 22);
            this.txtFornecedorPesquisa.TabIndex = 25;
            this.txtFornecedorPesquisa.TextChanged += new System.EventHandler(this.txtFornecedorPesquisa_TextChanged);
            this.txtFornecedorPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFornecedorPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Fornecedor";
            // 
            // Id_Fornecedor
            // 
            this.Id_Fornecedor.DataPropertyName = "Id_Fornecedor";
            this.Id_Fornecedor.HeaderText = "Id Fornecedor";
            this.Id_Fornecedor.Name = "Id_Fornecedor";
            this.Id_Fornecedor.ReadOnly = true;
            this.Id_Fornecedor.Visible = false;
            // 
            // Razao_Social
            // 
            this.Razao_Social.DataPropertyName = "Razao_Social";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Razao_Social.DefaultCellStyle = dataGridViewCellStyle3;
            this.Razao_Social.HeaderText = "Razão Social";
            this.Razao_Social.Name = "Razao_Social";
            this.Razao_Social.ReadOnly = true;
            this.Razao_Social.Width = 200;
            // 
            // Nome_Fantasia
            // 
            this.Nome_Fantasia.DataPropertyName = "Nome_Fantasia";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Fantasia.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nome_Fantasia.HeaderText = "Nome Fantasia";
            this.Nome_Fantasia.Name = "Nome_Fantasia";
            this.Nome_Fantasia.ReadOnly = true;
            this.Nome_Fantasia.Width = 140;
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.DataPropertyName = "CPF_CNPJ";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF_CNPJ.DefaultCellStyle = dataGridViewCellStyle5;
            this.CPF_CNPJ.HeaderText = "CPF / CNPJ";
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.ReadOnly = true;
            this.CPF_CNPJ.Width = 110;
            // 
            // Contato
            // 
            this.Contato.DataPropertyName = "Contato";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contato.DefaultCellStyle = dataGridViewCellStyle6;
            this.Contato.HeaderText = "Contato";
            this.Contato.Name = "Contato";
            this.Contato.ReadOnly = true;
            this.Contato.Width = 120;
            // 
            // Tel_Fixo_Fornecedor
            // 
            this.Tel_Fixo_Fornecedor.DataPropertyName = "Tel_Fixo_Fornecedor";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_Fixo_Fornecedor.DefaultCellStyle = dataGridViewCellStyle7;
            this.Tel_Fixo_Fornecedor.HeaderText = "Tel Fixo";
            this.Tel_Fixo_Fornecedor.Name = "Tel_Fixo_Fornecedor";
            this.Tel_Fixo_Fornecedor.ReadOnly = true;
            this.Tel_Fixo_Fornecedor.Width = 120;
            // 
            // Tel_Cel_Fornecedor
            // 
            this.Tel_Cel_Fornecedor.DataPropertyName = "Tel_Cel_Fornecedor";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_Cel_Fornecedor.DefaultCellStyle = dataGridViewCellStyle8;
            this.Tel_Cel_Fornecedor.HeaderText = "Tel Cel";
            this.Tel_Cel_Fornecedor.Name = "Tel_Cel_Fornecedor";
            this.Tel_Cel_Fornecedor.ReadOnly = true;
            // 
            // Email_Fornecedor
            // 
            this.Email_Fornecedor.DataPropertyName = "Email_Fornecedor";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Fornecedor.DefaultCellStyle = dataGridViewCellStyle9;
            this.Email_Fornecedor.HeaderText = "Email";
            this.Email_Fornecedor.Name = "Email_Fornecedor";
            this.Email_Fornecedor.ReadOnly = true;
            // 
            // FrmFornecedorPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 261);
            this.Controls.Add(this.btnFornecedorCancelar);
            this.Controls.Add(this.btnFornecedorSelecionar);
            this.Controls.Add(this.btnFornecedorPesquisa);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Controls.Add(this.txtFornecedorPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmFornecedorPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFornecedorPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFornecedorCancelar;
        private System.Windows.Forms.Button btnFornecedorSelecionar;
        private System.Windows.Forms.Button btnFornecedorPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
        private System.Windows.Forms.TextBox txtFornecedorPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razao_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Fantasia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF_CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Fixo_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Cel_Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Fornecedor;
    }
}
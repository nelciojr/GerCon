namespace Gerenciador
{
    partial class FrmContratoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContratoPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtContratoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContratoItens = new System.Windows.Forms.Button();
            this.btnContratoPesquisa = new System.Windows.Forms.Button();
            this.btnContratoSelecionar = new System.Windows.Forms.Button();
            this.dgwContrato = new System.Windows.Forms.DataGridView();
            this.Id_Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FornecedorContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgaoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeneroContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSIdUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelarContrato = new System.Windows.Forms.Button();
            this.btnBaixaItens = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwContrato)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtContratoPesquisa
            // 
            this.txtContratoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContratoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContratoPesquisa.Location = new System.Drawing.Point(172, 12);
            this.txtContratoPesquisa.Name = "txtContratoPesquisa";
            this.txtContratoPesquisa.Size = new System.Drawing.Size(425, 22);
            this.txtContratoPesquisa.TabIndex = 0;
            this.txtContratoPesquisa.TextChanged += new System.EventHandler(this.txtContratoPesquisa_TextChanged);
            this.txtContratoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContratoPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nº Contrato / Fornecedor";
            // 
            // btnContratoItens
            // 
            this.btnContratoItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContratoItens.Image = ((System.Drawing.Image)(resources.GetObject("btnContratoItens.Image")));
            this.btnContratoItens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContratoItens.Location = new System.Drawing.Point(603, 78);
            this.btnContratoItens.Name = "btnContratoItens";
            this.btnContratoItens.Size = new System.Drawing.Size(70, 60);
            this.btnContratoItens.TabIndex = 3;
            this.btnContratoItens.Text = "Itens";
            this.btnContratoItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContratoItens.UseVisualStyleBackColor = true;
            this.btnContratoItens.Click += new System.EventHandler(this.btnContratoItens_Click);
            // 
            // btnContratoPesquisa
            // 
            this.btnContratoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContratoPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnContratoPesquisa.Image")));
            this.btnContratoPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContratoPesquisa.Location = new System.Drawing.Point(603, 12);
            this.btnContratoPesquisa.Name = "btnContratoPesquisa";
            this.btnContratoPesquisa.Size = new System.Drawing.Size(70, 60);
            this.btnContratoPesquisa.TabIndex = 2;
            this.btnContratoPesquisa.Text = "Pesquisar";
            this.btnContratoPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContratoPesquisa.UseVisualStyleBackColor = true;
            this.btnContratoPesquisa.Click += new System.EventHandler(this.btnContratoPesquisa_Click);
            // 
            // btnContratoSelecionar
            // 
            this.btnContratoSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContratoSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnContratoSelecionar.Image")));
            this.btnContratoSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContratoSelecionar.Location = new System.Drawing.Point(603, 210);
            this.btnContratoSelecionar.Name = "btnContratoSelecionar";
            this.btnContratoSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnContratoSelecionar.TabIndex = 4;
            this.btnContratoSelecionar.Text = "Selecionar";
            this.btnContratoSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContratoSelecionar.UseVisualStyleBackColor = true;
            this.btnContratoSelecionar.Click += new System.EventHandler(this.btnContratoSelecionar_Click);
            // 
            // dgwContrato
            // 
            this.dgwContrato.AllowUserToAddRows = false;
            this.dgwContrato.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwContrato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwContrato.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwContrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Contrato,
            this.Numero_Contrato,
            this.FornecedorContrato,
            this.OrgaoContrato,
            this.GeneroContrato,
            this.ValorContrato,
            this.SaldoContrato,
            this.DataInicial,
            this.DataFinal});
            this.dgwContrato.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwContrato.Location = new System.Drawing.Point(12, 40);
            this.dgwContrato.MultiSelect = false;
            this.dgwContrato.Name = "dgwContrato";
            this.dgwContrato.ReadOnly = true;
            this.dgwContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwContrato.Size = new System.Drawing.Size(584, 296);
            this.dgwContrato.TabIndex = 1;
            this.dgwContrato.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwContrato_CellDoubleClick);
            this.dgwContrato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwContrato_CellFormatting);
            this.dgwContrato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgwContrato_KeyDown);
            // 
            // Id_Contrato
            // 
            this.Id_Contrato.DataPropertyName = "Id_Contrato";
            this.Id_Contrato.HeaderText = "Id Contrato";
            this.Id_Contrato.Name = "Id_Contrato";
            this.Id_Contrato.ReadOnly = true;
            this.Id_Contrato.Visible = false;
            // 
            // Numero_Contrato
            // 
            this.Numero_Contrato.DataPropertyName = "Numero_Contrato";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero_Contrato.DefaultCellStyle = dataGridViewCellStyle3;
            this.Numero_Contrato.HeaderText = "Número";
            this.Numero_Contrato.Name = "Numero_Contrato";
            this.Numero_Contrato.ReadOnly = true;
            // 
            // FornecedorContrato
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FornecedorContrato.DefaultCellStyle = dataGridViewCellStyle4;
            this.FornecedorContrato.HeaderText = "Fonecedor";
            this.FornecedorContrato.Name = "FornecedorContrato";
            this.FornecedorContrato.ReadOnly = true;
            this.FornecedorContrato.Width = 200;
            // 
            // OrgaoContrato
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrgaoContrato.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrgaoContrato.HeaderText = "Orgão";
            this.OrgaoContrato.Name = "OrgaoContrato";
            this.OrgaoContrato.ReadOnly = true;
            this.OrgaoContrato.Width = 120;
            // 
            // GeneroContrato
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneroContrato.DefaultCellStyle = dataGridViewCellStyle6;
            this.GeneroContrato.HeaderText = "Gênero";
            this.GeneroContrato.Name = "GeneroContrato";
            this.GeneroContrato.ReadOnly = true;
            this.GeneroContrato.Width = 90;
            // 
            // ValorContrato
            // 
            this.ValorContrato.DataPropertyName = "Valor_Contrato";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.ValorContrato.DefaultCellStyle = dataGridViewCellStyle7;
            this.ValorContrato.HeaderText = "Valor";
            this.ValorContrato.Name = "ValorContrato";
            this.ValorContrato.ReadOnly = true;
            // 
            // SaldoContrato
            // 
            this.SaldoContrato.DataPropertyName = "Saldo_Contrato";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.SaldoContrato.DefaultCellStyle = dataGridViewCellStyle8;
            this.SaldoContrato.HeaderText = "Saldo";
            this.SaldoContrato.Name = "SaldoContrato";
            this.SaldoContrato.ReadOnly = true;
            // 
            // DataInicial
            // 
            this.DataInicial.DataPropertyName = "Data_Inicial";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.DataInicial.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataInicial.HeaderText = "D. Início";
            this.DataInicial.Name = "DataInicial";
            this.DataInicial.ReadOnly = true;
            // 
            // DataFinal
            // 
            this.DataFinal.DataPropertyName = "Data_Final";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Format = "d";
            dataGridViewCellStyle10.NullValue = null;
            this.DataFinal.DefaultCellStyle = dataGridViewCellStyle10;
            this.DataFinal.HeaderText = "D. Final";
            this.DataFinal.Name = "DataFinal";
            this.DataFinal.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tSSIdUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
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
            // btnCancelarContrato
            // 
            this.btnCancelarContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarContrato.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarContrato.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarContrato.Image")));
            this.btnCancelarContrato.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarContrato.Location = new System.Drawing.Point(603, 276);
            this.btnCancelarContrato.Name = "btnCancelarContrato";
            this.btnCancelarContrato.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarContrato.TabIndex = 8;
            this.btnCancelarContrato.Text = "Cancelar";
            this.btnCancelarContrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarContrato.UseVisualStyleBackColor = true;
            this.btnCancelarContrato.Click += new System.EventHandler(this.btnCancelarItens_Click);
            // 
            // btnBaixaItens
            // 
            this.btnBaixaItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaixaItens.Image = ((System.Drawing.Image)(resources.GetObject("btnBaixaItens.Image")));
            this.btnBaixaItens.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBaixaItens.Location = new System.Drawing.Point(603, 144);
            this.btnBaixaItens.Name = "btnBaixaItens";
            this.btnBaixaItens.Size = new System.Drawing.Size(70, 60);
            this.btnBaixaItens.TabIndex = 11;
            this.btnBaixaItens.Text = "Baixa";
            this.btnBaixaItens.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaixaItens.UseVisualStyleBackColor = true;
            this.btnBaixaItens.Click += new System.EventHandler(this.btnBaixaItens_Click);
            // 
            // FrmContratoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.btnBaixaItens);
            this.Controls.Add(this.btnCancelarContrato);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgwContrato);
            this.Controls.Add(this.btnContratoSelecionar);
            this.Controls.Add(this.btnContratoItens);
            this.Controls.Add(this.btnContratoPesquisa);
            this.Controls.Add(this.txtContratoPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmContratoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContratoPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwContrato)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnContratoItens;
        private System.Windows.Forms.Button btnContratoPesquisa;
        private System.Windows.Forms.TextBox txtContratoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContratoSelecionar;
        private System.Windows.Forms.DataGridView dgwContrato;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tSSIdUsuario;
        private System.Windows.Forms.Button btnCancelarContrato;
        private System.Windows.Forms.Button btnBaixaItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgaoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeneroContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFinal;
    }
}
namespace Gerenciador
{
    partial class FrmOrgaoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrgaoPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOrgaoCancelar = new System.Windows.Forms.Button();
            this.btnOrgaoSelecionar = new System.Windows.Forms.Button();
            this.btnOrgaoPesquisa = new System.Windows.Forms.Button();
            this.dataGridViewOrgao = new System.Windows.Forms.DataGridView();
            this.txtOrgaoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Orgao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Orgao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Fixo_Orgao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResponsavelOrgao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrgao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrgaoCancelar
            // 
            this.btnOrgaoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrgaoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOrgaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnOrgaoCancelar.Image")));
            this.btnOrgaoCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrgaoCancelar.Location = new System.Drawing.Point(605, 146);
            this.btnOrgaoCancelar.Name = "btnOrgaoCancelar";
            this.btnOrgaoCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnOrgaoCancelar.TabIndex = 29;
            this.btnOrgaoCancelar.Text = "Cancelar";
            this.btnOrgaoCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrgaoCancelar.UseVisualStyleBackColor = true;
            this.btnOrgaoCancelar.Click += new System.EventHandler(this.btnOrgaoCancelar_Click);
            // 
            // btnOrgaoSelecionar
            // 
            this.btnOrgaoSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrgaoSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnOrgaoSelecionar.Image")));
            this.btnOrgaoSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrgaoSelecionar.Location = new System.Drawing.Point(605, 80);
            this.btnOrgaoSelecionar.Name = "btnOrgaoSelecionar";
            this.btnOrgaoSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnOrgaoSelecionar.TabIndex = 28;
            this.btnOrgaoSelecionar.Text = "Selecionar";
            this.btnOrgaoSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrgaoSelecionar.UseVisualStyleBackColor = true;
            this.btnOrgaoSelecionar.Click += new System.EventHandler(this.btnOrgaoSelecionar_Click);
            // 
            // btnOrgaoPesquisa
            // 
            this.btnOrgaoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrgaoPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnOrgaoPesquisa.Image")));
            this.btnOrgaoPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrgaoPesquisa.Location = new System.Drawing.Point(605, 14);
            this.btnOrgaoPesquisa.Name = "btnOrgaoPesquisa";
            this.btnOrgaoPesquisa.Size = new System.Drawing.Size(70, 60);
            this.btnOrgaoPesquisa.TabIndex = 27;
            this.btnOrgaoPesquisa.Text = "Pesquisar";
            this.btnOrgaoPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrgaoPesquisa.UseVisualStyleBackColor = true;
            this.btnOrgaoPesquisa.Click += new System.EventHandler(this.btnOrgaoPesquisa_Click);
            // 
            // dataGridViewOrgao
            // 
            this.dataGridViewOrgao.AllowUserToAddRows = false;
            this.dataGridViewOrgao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewOrgao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrgao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrgao.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrgao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrgao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrgao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Orgao,
            this.Nome_Orgao,
            this.Tel_Fixo_Orgao,
            this.ResponsavelOrgao});
            this.dataGridViewOrgao.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrgao.Location = new System.Drawing.Point(13, 43);
            this.dataGridViewOrgao.MultiSelect = false;
            this.dataGridViewOrgao.Name = "dataGridViewOrgao";
            this.dataGridViewOrgao.ReadOnly = true;
            this.dataGridViewOrgao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrgao.Size = new System.Drawing.Size(584, 206);
            this.dataGridViewOrgao.TabIndex = 26;
            this.dataGridViewOrgao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrgao_CellDoubleClick);
            this.dataGridViewOrgao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewOrgao_CellFormatting);
            this.dataGridViewOrgao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewOrgao_KeyDown);
            // 
            // txtOrgaoPesquisa
            // 
            this.txtOrgaoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrgaoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgaoPesquisa.Location = new System.Drawing.Point(62, 11);
            this.txtOrgaoPesquisa.Name = "txtOrgaoPesquisa";
            this.txtOrgaoPesquisa.Size = new System.Drawing.Size(537, 22);
            this.txtOrgaoPesquisa.TabIndex = 25;
            this.txtOrgaoPesquisa.TextChanged += new System.EventHandler(this.txtOrgaoPesquisa_TextChanged);
            this.txtOrgaoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrgaoPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Orgão";
            // 
            // Id_Orgao
            // 
            this.Id_Orgao.DataPropertyName = "Id_Orgao";
            this.Id_Orgao.HeaderText = "Id Orgão";
            this.Id_Orgao.Name = "Id_Orgao";
            this.Id_Orgao.ReadOnly = true;
            this.Id_Orgao.Visible = false;
            // 
            // Nome_Orgao
            // 
            this.Nome_Orgao.DataPropertyName = "Nome_Orgao";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Orgao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nome_Orgao.HeaderText = "Orgão";
            this.Nome_Orgao.Name = "Nome_Orgao";
            this.Nome_Orgao.ReadOnly = true;
            this.Nome_Orgao.Width = 220;
            // 
            // Tel_Fixo_Orgao
            // 
            this.Tel_Fixo_Orgao.DataPropertyName = "Tel_Fixo_Orgao";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_Fixo_Orgao.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tel_Fixo_Orgao.HeaderText = "Telefone";
            this.Tel_Fixo_Orgao.Name = "Tel_Fixo_Orgao";
            this.Tel_Fixo_Orgao.ReadOnly = true;
            this.Tel_Fixo_Orgao.Width = 150;
            // 
            // ResponsavelOrgao
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResponsavelOrgao.DefaultCellStyle = dataGridViewCellStyle5;
            this.ResponsavelOrgao.HeaderText = "Responsável";
            this.ResponsavelOrgao.Name = "ResponsavelOrgao";
            this.ResponsavelOrgao.ReadOnly = true;
            this.ResponsavelOrgao.Width = 170;
            // 
            // FrmOrgaoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.btnOrgaoCancelar);
            this.Controls.Add(this.btnOrgaoSelecionar);
            this.Controls.Add(this.btnOrgaoPesquisa);
            this.Controls.Add(this.dataGridViewOrgao);
            this.Controls.Add(this.txtOrgaoPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmOrgaoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orgão Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOrgaoPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrgao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrgaoCancelar;
        private System.Windows.Forms.Button btnOrgaoSelecionar;
        private System.Windows.Forms.Button btnOrgaoPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewOrgao;
        private System.Windows.Forms.TextBox txtOrgaoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Orgao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Orgao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Fixo_Orgao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResponsavelOrgao;
    }
}
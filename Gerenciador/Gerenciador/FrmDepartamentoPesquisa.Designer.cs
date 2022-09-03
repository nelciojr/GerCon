namespace Gerenciador
{
    partial class FrmDepartamentoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamentoPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDepartamentoCancelar = new System.Windows.Forms.Button();
            this.btnDepartamentoSelecionar = new System.Windows.Forms.Button();
            this.btnDepartamentoPesquisa = new System.Windows.Forms.Button();
            this.dataGridViewDepartamento = new System.Windows.Forms.DataGridView();
            this.Id_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Fixo_Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrgaoDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDepartamentoPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDepartamentoCancelar
            // 
            this.btnDepartamentoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartamentoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDepartamentoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartamentoCancelar.Image")));
            this.btnDepartamentoCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentoCancelar.Location = new System.Drawing.Point(605, 146);
            this.btnDepartamentoCancelar.Name = "btnDepartamentoCancelar";
            this.btnDepartamentoCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnDepartamentoCancelar.TabIndex = 35;
            this.btnDepartamentoCancelar.Text = "Cancelar";
            this.btnDepartamentoCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentoCancelar.UseVisualStyleBackColor = true;
            this.btnDepartamentoCancelar.Click += new System.EventHandler(this.btnDepartamentoCancelar_Click);
            // 
            // btnDepartamentoSelecionar
            // 
            this.btnDepartamentoSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartamentoSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartamentoSelecionar.Image")));
            this.btnDepartamentoSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentoSelecionar.Location = new System.Drawing.Point(605, 80);
            this.btnDepartamentoSelecionar.Name = "btnDepartamentoSelecionar";
            this.btnDepartamentoSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnDepartamentoSelecionar.TabIndex = 34;
            this.btnDepartamentoSelecionar.Text = "Selecionar";
            this.btnDepartamentoSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentoSelecionar.UseVisualStyleBackColor = true;
            this.btnDepartamentoSelecionar.Click += new System.EventHandler(this.btnDepartamentoSelecionar_Click);
            // 
            // btnDepartamentoPesquisa
            // 
            this.btnDepartamentoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDepartamentoPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartamentoPesquisa.Image")));
            this.btnDepartamentoPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentoPesquisa.Location = new System.Drawing.Point(605, 14);
            this.btnDepartamentoPesquisa.Name = "btnDepartamentoPesquisa";
            this.btnDepartamentoPesquisa.Size = new System.Drawing.Size(70, 60);
            this.btnDepartamentoPesquisa.TabIndex = 33;
            this.btnDepartamentoPesquisa.Text = "Pesquisar";
            this.btnDepartamentoPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartamentoPesquisa.UseVisualStyleBackColor = true;
            this.btnDepartamentoPesquisa.Click += new System.EventHandler(this.btnDepartamentoPesquisa_Click);
            // 
            // dataGridViewDepartamento
            // 
            this.dataGridViewDepartamento.AllowUserToAddRows = false;
            this.dataGridViewDepartamento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDepartamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDepartamento.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDepartamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Departamento,
            this.Nome_Departamento,
            this.Tel_Fixo_Departamento,
            this.OrgaoDepartamento});
            this.dataGridViewDepartamento.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDepartamento.Location = new System.Drawing.Point(13, 43);
            this.dataGridViewDepartamento.MultiSelect = false;
            this.dataGridViewDepartamento.Name = "dataGridViewDepartamento";
            this.dataGridViewDepartamento.ReadOnly = true;
            this.dataGridViewDepartamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartamento.Size = new System.Drawing.Size(584, 206);
            this.dataGridViewDepartamento.TabIndex = 32;
            this.dataGridViewDepartamento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartamento_CellDoubleClick);
            this.dataGridViewDepartamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDepartamento_CellFormatting);
            this.dataGridViewDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewDepartamento_KeyDown);
            // 
            // Id_Departamento
            // 
            this.Id_Departamento.DataPropertyName = "Id_Departamento";
            this.Id_Departamento.HeaderText = "Id Departamento";
            this.Id_Departamento.Name = "Id_Departamento";
            this.Id_Departamento.ReadOnly = true;
            this.Id_Departamento.Visible = false;
            // 
            // Nome_Departamento
            // 
            this.Nome_Departamento.DataPropertyName = "Nome_Departamento";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Departamento.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nome_Departamento.HeaderText = "Departamento";
            this.Nome_Departamento.Name = "Nome_Departamento";
            this.Nome_Departamento.ReadOnly = true;
            this.Nome_Departamento.Width = 220;
            // 
            // Tel_Fixo_Departamento
            // 
            this.Tel_Fixo_Departamento.DataPropertyName = "Tel_Fixo_Departamento";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_Fixo_Departamento.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tel_Fixo_Departamento.HeaderText = "Telefone";
            this.Tel_Fixo_Departamento.Name = "Tel_Fixo_Departamento";
            this.Tel_Fixo_Departamento.ReadOnly = true;
            this.Tel_Fixo_Departamento.Width = 150;
            // 
            // OrgaoDepartamento
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrgaoDepartamento.DefaultCellStyle = dataGridViewCellStyle5;
            this.OrgaoDepartamento.HeaderText = "Orgão";
            this.OrgaoDepartamento.Name = "OrgaoDepartamento";
            this.OrgaoDepartamento.ReadOnly = true;
            this.OrgaoDepartamento.Width = 170;
            // 
            // txtDepartamentoPesquisa
            // 
            this.txtDepartamentoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartamentoPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamentoPesquisa.Location = new System.Drawing.Point(110, 11);
            this.txtDepartamentoPesquisa.Name = "txtDepartamentoPesquisa";
            this.txtDepartamentoPesquisa.Size = new System.Drawing.Size(489, 22);
            this.txtDepartamentoPesquisa.TabIndex = 31;
            this.txtDepartamentoPesquisa.TextChanged += new System.EventHandler(this.txtDepartamentoPesquisa_TextChanged);
            this.txtDepartamentoPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDepartamentoPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Departamento";
            // 
            // FrmDepartamentoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.btnDepartamentoCancelar);
            this.Controls.Add(this.btnDepartamentoSelecionar);
            this.Controls.Add(this.btnDepartamentoPesquisa);
            this.Controls.Add(this.dataGridViewDepartamento);
            this.Controls.Add(this.txtDepartamentoPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmDepartamentoPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamento Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDepartamentoPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepartamentoCancelar;
        private System.Windows.Forms.Button btnDepartamentoSelecionar;
        private System.Windows.Forms.Button btnDepartamentoPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewDepartamento;
        private System.Windows.Forms.TextBox txtDepartamentoPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Fixo_Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrgaoDepartamento;
    }
}
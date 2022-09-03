namespace Gerenciador
{
    partial class FrmResponsavelPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResponsavelPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnResponsavelCancelar = new System.Windows.Forms.Button();
            this.btnResponsavelSelecionar = new System.Windows.Forms.Button();
            this.btnResponsavelPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewResponsavel = new System.Windows.Forms.DataGridView();
            this.txtResponsavelPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Fixo_Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_Cel_Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsavel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResponsavelCancelar
            // 
            this.btnResponsavelCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResponsavelCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnResponsavelCancelar.Image")));
            this.btnResponsavelCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResponsavelCancelar.Location = new System.Drawing.Point(394, 146);
            this.btnResponsavelCancelar.Name = "btnResponsavelCancelar";
            this.btnResponsavelCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnResponsavelCancelar.TabIndex = 23;
            this.btnResponsavelCancelar.Text = "Cancelar";
            this.btnResponsavelCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResponsavelCancelar.UseVisualStyleBackColor = true;
            this.btnResponsavelCancelar.Click += new System.EventHandler(this.btnResponsavelCancelar_Click);
            // 
            // btnResponsavelSelecionar
            // 
            this.btnResponsavelSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResponsavelSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnResponsavelSelecionar.Image")));
            this.btnResponsavelSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResponsavelSelecionar.Location = new System.Drawing.Point(394, 80);
            this.btnResponsavelSelecionar.Name = "btnResponsavelSelecionar";
            this.btnResponsavelSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnResponsavelSelecionar.TabIndex = 22;
            this.btnResponsavelSelecionar.Text = "Selecionar";
            this.btnResponsavelSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResponsavelSelecionar.UseVisualStyleBackColor = true;
            this.btnResponsavelSelecionar.Click += new System.EventHandler(this.btnResponsavelSelecionar_Click);
            // 
            // btnResponsavelPesquisar
            // 
            this.btnResponsavelPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResponsavelPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnResponsavelPesquisar.Image")));
            this.btnResponsavelPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnResponsavelPesquisar.Location = new System.Drawing.Point(394, 14);
            this.btnResponsavelPesquisar.Name = "btnResponsavelPesquisar";
            this.btnResponsavelPesquisar.Size = new System.Drawing.Size(70, 60);
            this.btnResponsavelPesquisar.TabIndex = 21;
            this.btnResponsavelPesquisar.Text = "Pesquisar";
            this.btnResponsavelPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResponsavelPesquisar.UseVisualStyleBackColor = true;
            this.btnResponsavelPesquisar.Click += new System.EventHandler(this.btnResponsavelPesquisar_Click);
            // 
            // dataGridViewResponsavel
            // 
            this.dataGridViewResponsavel.AllowUserToAddRows = false;
            this.dataGridViewResponsavel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewResponsavel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResponsavel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResponsavel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResponsavel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Responsavel,
            this.Nome_Responsavel,
            this.CPF,
            this.Tel_Fixo_Responsavel,
            this.Tel_Cel_Responsavel});
            this.dataGridViewResponsavel.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewResponsavel.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewResponsavel.MultiSelect = false;
            this.dataGridViewResponsavel.Name = "dataGridViewResponsavel";
            this.dataGridViewResponsavel.ReadOnly = true;
            this.dataGridViewResponsavel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResponsavel.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewResponsavel.TabIndex = 20;
            this.dataGridViewResponsavel.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResponsavel_CellDoubleClick);
            this.dataGridViewResponsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewResponsavel_KeyDown);
            // 
            // txtResponsavelPesquisa
            // 
            this.txtResponsavelPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponsavelPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavelPesquisa.Location = new System.Drawing.Point(106, 11);
            this.txtResponsavelPesquisa.Name = "txtResponsavelPesquisa";
            this.txtResponsavelPesquisa.Size = new System.Drawing.Size(273, 22);
            this.txtResponsavelPesquisa.TabIndex = 19;
            this.txtResponsavelPesquisa.TextChanged += new System.EventHandler(this.txtResponsavelPesquisa_TextChanged);
            this.txtResponsavelPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResponsavelPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Responsável";
            // 
            // Id_Responsavel
            // 
            this.Id_Responsavel.DataPropertyName = "Id_Responsavel";
            this.Id_Responsavel.HeaderText = "Id Responsavel";
            this.Id_Responsavel.Name = "Id_Responsavel";
            this.Id_Responsavel.ReadOnly = true;
            this.Id_Responsavel.Visible = false;
            // 
            // Nome_Responsavel
            // 
            this.Nome_Responsavel.DataPropertyName = "Nome_Responsavel";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Responsavel.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nome_Responsavel.HeaderText = "Nome Completo";
            this.Nome_Responsavel.Name = "Nome_Responsavel";
            this.Nome_Responsavel.ReadOnly = true;
            this.Nome_Responsavel.Width = 130;
            // 
            // CPF
            // 
            this.CPF.DataPropertyName = "CPF_Resposavel";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.DefaultCellStyle = dataGridViewCellStyle4;
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 90;
            // 
            // Tel_Fixo_Responsavel
            // 
            this.Tel_Fixo_Responsavel.DataPropertyName = "Tel_Fixo_Responsavel";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_Fixo_Responsavel.DefaultCellStyle = dataGridViewCellStyle5;
            this.Tel_Fixo_Responsavel.HeaderText = "Telefone";
            this.Tel_Fixo_Responsavel.Name = "Tel_Fixo_Responsavel";
            this.Tel_Fixo_Responsavel.ReadOnly = true;
            this.Tel_Fixo_Responsavel.Width = 90;
            // 
            // Tel_Cel_Responsavel
            // 
            this.Tel_Cel_Responsavel.DataPropertyName = "Tel_Cel_Responsavel";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tel_Cel_Responsavel.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tel_Cel_Responsavel.HeaderText = "Celular";
            this.Tel_Cel_Responsavel.Name = "Tel_Cel_Responsavel";
            this.Tel_Cel_Responsavel.ReadOnly = true;
            this.Tel_Cel_Responsavel.Width = 90;
            // 
            // FrmResponsavelPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.btnResponsavelCancelar);
            this.Controls.Add(this.btnResponsavelSelecionar);
            this.Controls.Add(this.btnResponsavelPesquisar);
            this.Controls.Add(this.dataGridViewResponsavel);
            this.Controls.Add(this.txtResponsavelPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmResponsavelPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsável Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmResponsavelPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResponsavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResponsavelCancelar;
        private System.Windows.Forms.Button btnResponsavelSelecionar;
        private System.Windows.Forms.Button btnResponsavelPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewResponsavel;
        private System.Windows.Forms.TextBox txtResponsavelPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Fixo_Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_Cel_Responsavel;
    }
}
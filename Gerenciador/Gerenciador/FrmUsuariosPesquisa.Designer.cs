namespace Gerenciador
{
    partial class FrmUsuariosPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuariosPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUsuarioCancelar = new System.Windows.Forms.Button();
            this.btnUsuarioSelecionar = new System.Windows.Forms.Button();
            this.btnUsuariosPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.txtUsuariosPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsuarioCancelar
            // 
            this.btnUsuarioCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarioCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarioCancelar.Image")));
            this.btnUsuarioCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarioCancelar.Location = new System.Drawing.Point(394, 146);
            this.btnUsuarioCancelar.Name = "btnUsuarioCancelar";
            this.btnUsuarioCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnUsuarioCancelar.TabIndex = 17;
            this.btnUsuarioCancelar.Text = "Cancelar";
            this.btnUsuarioCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarioCancelar.UseVisualStyleBackColor = true;
            this.btnUsuarioCancelar.Click += new System.EventHandler(this.btnUsuarioCancelar_Click);
            // 
            // btnUsuarioSelecionar
            // 
            this.btnUsuarioSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuarioSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarioSelecionar.Image")));
            this.btnUsuarioSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuarioSelecionar.Location = new System.Drawing.Point(394, 80);
            this.btnUsuarioSelecionar.Name = "btnUsuarioSelecionar";
            this.btnUsuarioSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnUsuarioSelecionar.TabIndex = 16;
            this.btnUsuarioSelecionar.Text = "Selecionar";
            this.btnUsuarioSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuarioSelecionar.UseVisualStyleBackColor = true;
            this.btnUsuarioSelecionar.Click += new System.EventHandler(this.btnUsuarioSelecionar_Click);
            // 
            // btnUsuariosPesquisar
            // 
            this.btnUsuariosPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsuariosPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuariosPesquisar.Image")));
            this.btnUsuariosPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuariosPesquisar.Location = new System.Drawing.Point(394, 14);
            this.btnUsuariosPesquisar.Name = "btnUsuariosPesquisar";
            this.btnUsuariosPesquisar.Size = new System.Drawing.Size(70, 60);
            this.btnUsuariosPesquisar.TabIndex = 15;
            this.btnUsuariosPesquisar.Text = "Pesquisar";
            this.btnUsuariosPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuariosPesquisar.UseVisualStyleBackColor = true;
            this.btnUsuariosPesquisar.Click += new System.EventHandler(this.btnUsuariosPesquisar_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Usuario,
            this.Nome,
            this.Login,
            this.Senha,
            this.Tipo});
            this.dataGridViewUsuarios.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewUsuarios.MultiSelect = false;
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewUsuarios.TabIndex = 14;
            this.dataGridViewUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUsuarios_CellFormatting);
            this.dataGridViewUsuarios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUsuarios_CellMouseDoubleClick);
            this.dataGridViewUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewUsuarios_KeyDown);
            // 
            // txtUsuariosPesquisa
            // 
            this.txtUsuariosPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuariosPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuariosPesquisa.Location = new System.Drawing.Point(72, 11);
            this.txtUsuariosPesquisa.Name = "txtUsuariosPesquisa";
            this.txtUsuariosPesquisa.Size = new System.Drawing.Size(307, 22);
            this.txtUsuariosPesquisa.TabIndex = 13;
            this.txtUsuariosPesquisa.TextChanged += new System.EventHandler(this.txtUsuariosPesquisa_TextChanged);
            this.txtUsuariosPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuariosPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário";
            // 
            // Id_Usuario
            // 
            this.Id_Usuario.DataPropertyName = "Id_Usuario";
            this.Id_Usuario.HeaderText = "Id Usuario";
            this.Id_Usuario.Name = "Id_Usuario";
            this.Id_Usuario.ReadOnly = true;
            this.Id_Usuario.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome_Usuario";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nome.HeaderText = "Nome Completo";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.DefaultCellStyle = dataGridViewCellStyle4;
            this.Login.HeaderText = "Usuário";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "Senha";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.DefaultCellStyle = dataGridViewCellStyle5;
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // Tipo
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 80;
            // 
            // FrmUsuariosPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.btnUsuarioCancelar);
            this.Controls.Add(this.btnUsuarioSelecionar);
            this.Controls.Add(this.btnUsuariosPesquisar);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.txtUsuariosPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmUsuariosPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUsuariosPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUsuarioCancelar;
        private System.Windows.Forms.Button btnUsuarioSelecionar;
        private System.Windows.Forms.Button btnUsuariosPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.TextBox txtUsuariosPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}
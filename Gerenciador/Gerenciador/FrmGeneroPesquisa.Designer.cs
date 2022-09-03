namespace Gerenciador
{
    partial class FrmGeneroPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneroPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGeneroCancelar = new System.Windows.Forms.Button();
            this.btnGeneroSelecionar = new System.Windows.Forms.Button();
            this.btnGeneroPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewGenero = new System.Windows.Forms.DataGridView();
            this.txtGeneroPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneroCancelar
            // 
            this.btnGeneroCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneroCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneroCancelar.Image")));
            this.btnGeneroCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeneroCancelar.Location = new System.Drawing.Point(394, 146);
            this.btnGeneroCancelar.Name = "btnGeneroCancelar";
            this.btnGeneroCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnGeneroCancelar.TabIndex = 17;
            this.btnGeneroCancelar.Text = "Cancelar";
            this.btnGeneroCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneroCancelar.UseVisualStyleBackColor = true;
            this.btnGeneroCancelar.Click += new System.EventHandler(this.btnGeneroCancelar_Click);
            // 
            // btnGeneroSelecionar
            // 
            this.btnGeneroSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneroSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneroSelecionar.Image")));
            this.btnGeneroSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeneroSelecionar.Location = new System.Drawing.Point(394, 80);
            this.btnGeneroSelecionar.Name = "btnGeneroSelecionar";
            this.btnGeneroSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnGeneroSelecionar.TabIndex = 16;
            this.btnGeneroSelecionar.Text = "Selecionar";
            this.btnGeneroSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneroSelecionar.UseVisualStyleBackColor = true;
            this.btnGeneroSelecionar.Click += new System.EventHandler(this.btnGeneroSelecionar_Click);
            // 
            // btnGeneroPesquisar
            // 
            this.btnGeneroPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneroPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneroPesquisar.Image")));
            this.btnGeneroPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGeneroPesquisar.Location = new System.Drawing.Point(394, 14);
            this.btnGeneroPesquisar.Name = "btnGeneroPesquisar";
            this.btnGeneroPesquisar.Size = new System.Drawing.Size(70, 60);
            this.btnGeneroPesquisar.TabIndex = 15;
            this.btnGeneroPesquisar.Text = "Pesquisar";
            this.btnGeneroPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeneroPesquisar.UseVisualStyleBackColor = true;
            this.btnGeneroPesquisar.Click += new System.EventHandler(this.btnGeneroPesquisar_Click);
            // 
            // dataGridViewGenero
            // 
            this.dataGridViewGenero.AllowUserToAddRows = false;
            this.dataGridViewGenero.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewGenero.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGenero.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGenero.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Genero,
            this.Genero});
            this.dataGridViewGenero.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewGenero.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewGenero.MultiSelect = false;
            this.dataGridViewGenero.Name = "dataGridViewGenero";
            this.dataGridViewGenero.ReadOnly = true;
            this.dataGridViewGenero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGenero.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewGenero.TabIndex = 14;
            this.dataGridViewGenero.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenero_CellDoubleClick);
            this.dataGridViewGenero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewGenero_KeyDown);
            // 
            // txtGeneroPesquisa
            // 
            this.txtGeneroPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneroPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneroPesquisa.Location = new System.Drawing.Point(70, 11);
            this.txtGeneroPesquisa.Name = "txtGeneroPesquisa";
            this.txtGeneroPesquisa.Size = new System.Drawing.Size(309, 22);
            this.txtGeneroPesquisa.TabIndex = 13;
            this.txtGeneroPesquisa.TextChanged += new System.EventHandler(this.txtGeneroPesquisa_TextChanged);
            this.txtGeneroPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGeneroPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gênero";
            // 
            // Id_Genero
            // 
            this.Id_Genero.DataPropertyName = "Id_Genero";
            this.Id_Genero.HeaderText = "Id Genero";
            this.Id_Genero.Name = "Id_Genero";
            this.Id_Genero.ReadOnly = true;
            this.Id_Genero.Visible = false;
            // 
            // Genero
            // 
            this.Genero.DataPropertyName = "Nome_Genero";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genero.DefaultCellStyle = dataGridViewCellStyle3;
            this.Genero.HeaderText = "Gênero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 300;
            // 
            // FrmGeneroPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.btnGeneroCancelar);
            this.Controls.Add(this.btnGeneroSelecionar);
            this.Controls.Add(this.btnGeneroPesquisar);
            this.Controls.Add(this.dataGridViewGenero);
            this.Controls.Add(this.txtGeneroPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmGeneroPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genero Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGeneroPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneroCancelar;
        private System.Windows.Forms.Button btnGeneroSelecionar;
        private System.Windows.Forms.Button btnGeneroPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewGenero;
        private System.Windows.Forms.TextBox txtGeneroPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
    }
}
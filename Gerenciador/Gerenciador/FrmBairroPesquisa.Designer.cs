namespace Gerenciador
{
    partial class FrmBairroPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBairroPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBairroCancelar = new System.Windows.Forms.Button();
            this.btnBairroSelecionar = new System.Windows.Forms.Button();
            this.btnBairroPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewBairro = new System.Windows.Forms.DataGridView();
            this.Id_Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBairroPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBairro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBairroCancelar
            // 
            this.btnBairroCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBairroCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnBairroCancelar.Image")));
            this.btnBairroCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBairroCancelar.Location = new System.Drawing.Point(394, 146);
            this.btnBairroCancelar.Name = "btnBairroCancelar";
            this.btnBairroCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnBairroCancelar.TabIndex = 11;
            this.btnBairroCancelar.Text = "Cancelar";
            this.btnBairroCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBairroCancelar.UseVisualStyleBackColor = true;
            this.btnBairroCancelar.Click += new System.EventHandler(this.btnBairroCancelar_Click);
            // 
            // btnBairroSelecionar
            // 
            this.btnBairroSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBairroSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnBairroSelecionar.Image")));
            this.btnBairroSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBairroSelecionar.Location = new System.Drawing.Point(394, 80);
            this.btnBairroSelecionar.Name = "btnBairroSelecionar";
            this.btnBairroSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnBairroSelecionar.TabIndex = 10;
            this.btnBairroSelecionar.Text = "Selecionar";
            this.btnBairroSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBairroSelecionar.UseVisualStyleBackColor = true;
            this.btnBairroSelecionar.Click += new System.EventHandler(this.btnBairroSelecionar_Click);
            // 
            // btnBairroPesquisar
            // 
            this.btnBairroPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBairroPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnBairroPesquisar.Image")));
            this.btnBairroPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBairroPesquisar.Location = new System.Drawing.Point(394, 14);
            this.btnBairroPesquisar.Name = "btnBairroPesquisar";
            this.btnBairroPesquisar.Size = new System.Drawing.Size(70, 60);
            this.btnBairroPesquisar.TabIndex = 9;
            this.btnBairroPesquisar.Text = "Pesquisar";
            this.btnBairroPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBairroPesquisar.UseVisualStyleBackColor = true;
            this.btnBairroPesquisar.Click += new System.EventHandler(this.btnBairroPesquisar_Click);
            // 
            // dataGridViewBairro
            // 
            this.dataGridViewBairro.AllowUserToAddRows = false;
            this.dataGridViewBairro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewBairro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBairro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBairro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBairro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Bairro,
            this.Bairro});
            this.dataGridViewBairro.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewBairro.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewBairro.MultiSelect = false;
            this.dataGridViewBairro.Name = "dataGridViewBairro";
            this.dataGridViewBairro.ReadOnly = true;
            this.dataGridViewBairro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBairro.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewBairro.TabIndex = 8;
            this.dataGridViewBairro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBairro_CellDoubleClick);
            this.dataGridViewBairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewBairro_KeyDown);
            // 
            // Id_Bairro
            // 
            this.Id_Bairro.DataPropertyName = "Id_Bairro";
            this.Id_Bairro.HeaderText = "Id Bairro";
            this.Id_Bairro.Name = "Id_Bairro";
            this.Id_Bairro.ReadOnly = true;
            this.Id_Bairro.Visible = false;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Nome_Bairro";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro.DefaultCellStyle = dataGridViewCellStyle3;
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 300;
            // 
            // txtBairroPesquisa
            // 
            this.txtBairroPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairroPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroPesquisa.Location = new System.Drawing.Point(61, 11);
            this.txtBairroPesquisa.Name = "txtBairroPesquisa";
            this.txtBairroPesquisa.Size = new System.Drawing.Size(318, 22);
            this.txtBairroPesquisa.TabIndex = 7;
            this.txtBairroPesquisa.TextChanged += new System.EventHandler(this.txtBairroPesquisa_TextChanged);
            this.txtBairroPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBairroPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bairro";
            // 
            // FrmBairroPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.btnBairroCancelar);
            this.Controls.Add(this.btnBairroSelecionar);
            this.Controls.Add(this.btnBairroPesquisar);
            this.Controls.Add(this.dataGridViewBairro);
            this.Controls.Add(this.txtBairroPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmBairroPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bairro Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBairroPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBairro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBairroCancelar;
        private System.Windows.Forms.Button btnBairroSelecionar;
        private System.Windows.Forms.Button btnBairroPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewBairro;
        private System.Windows.Forms.TextBox txtBairroPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
    }
}
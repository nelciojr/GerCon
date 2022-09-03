namespace Gerenciador
{
    partial class FrmMarcaPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarcaPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMarcaCancelar = new System.Windows.Forms.Button();
            this.btnMarcaSelecionar = new System.Windows.Forms.Button();
            this.btnMarcaPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewMarca = new System.Windows.Forms.DataGridView();
            this.txtMarcaPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMarcaCancelar
            // 
            this.btnMarcaCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcaCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcaCancelar.Image")));
            this.btnMarcaCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcaCancelar.Location = new System.Drawing.Point(394, 146);
            this.btnMarcaCancelar.Name = "btnMarcaCancelar";
            this.btnMarcaCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnMarcaCancelar.TabIndex = 17;
            this.btnMarcaCancelar.Text = "Cancelar";
            this.btnMarcaCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcaCancelar.UseVisualStyleBackColor = true;
            this.btnMarcaCancelar.Click += new System.EventHandler(this.btnMarcaCancelar_Click);
            // 
            // btnMarcaSelecionar
            // 
            this.btnMarcaSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcaSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcaSelecionar.Image")));
            this.btnMarcaSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcaSelecionar.Location = new System.Drawing.Point(394, 80);
            this.btnMarcaSelecionar.Name = "btnMarcaSelecionar";
            this.btnMarcaSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnMarcaSelecionar.TabIndex = 16;
            this.btnMarcaSelecionar.Text = "Selecionar";
            this.btnMarcaSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcaSelecionar.UseVisualStyleBackColor = true;
            this.btnMarcaSelecionar.Click += new System.EventHandler(this.btnMarcaSelecionar_Click);
            // 
            // btnMarcaPesquisar
            // 
            this.btnMarcaPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarcaPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnMarcaPesquisar.Image")));
            this.btnMarcaPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMarcaPesquisar.Location = new System.Drawing.Point(394, 14);
            this.btnMarcaPesquisar.Name = "btnMarcaPesquisar";
            this.btnMarcaPesquisar.Size = new System.Drawing.Size(70, 60);
            this.btnMarcaPesquisar.TabIndex = 15;
            this.btnMarcaPesquisar.Text = "Pesquisar";
            this.btnMarcaPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarcaPesquisar.UseVisualStyleBackColor = true;
            this.btnMarcaPesquisar.Click += new System.EventHandler(this.btnMarcaPesquisar_Click);
            // 
            // dataGridViewMarca
            // 
            this.dataGridViewMarca.AllowUserToAddRows = false;
            this.dataGridViewMarca.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMarca.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMarca.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarca.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Marca,
            this.Marca});
            this.dataGridViewMarca.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewMarca.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewMarca.MultiSelect = false;
            this.dataGridViewMarca.Name = "dataGridViewMarca";
            this.dataGridViewMarca.ReadOnly = true;
            this.dataGridViewMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMarca.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewMarca.TabIndex = 14;
            this.dataGridViewMarca.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarca_CellDoubleClick);
            this.dataGridViewMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewMarca_KeyDown);
            // 
            // txtMarcaPesquisa
            // 
            this.txtMarcaPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarcaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaPesquisa.Location = new System.Drawing.Point(64, 15);
            this.txtMarcaPesquisa.Name = "txtMarcaPesquisa";
            this.txtMarcaPesquisa.Size = new System.Drawing.Size(315, 22);
            this.txtMarcaPesquisa.TabIndex = 13;
            this.txtMarcaPesquisa.TextChanged += new System.EventHandler(this.txtMarcaPesquisa_TextChanged);
            this.txtMarcaPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarcaPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Marca";
            // 
            // Id_Marca
            // 
            this.Id_Marca.DataPropertyName = "Id_Marca";
            this.Id_Marca.HeaderText = "Id Marca";
            this.Id_Marca.Name = "Id_Marca";
            this.Id_Marca.ReadOnly = true;
            this.Id_Marca.Visible = false;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Nome_Marca";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.DefaultCellStyle = dataGridViewCellStyle3;
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 300;
            // 
            // FrmMarcaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.btnMarcaCancelar);
            this.Controls.Add(this.btnMarcaSelecionar);
            this.Controls.Add(this.btnMarcaPesquisar);
            this.Controls.Add(this.dataGridViewMarca);
            this.Controls.Add(this.txtMarcaPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMarcaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMarcaPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarcaCancelar;
        private System.Windows.Forms.Button btnMarcaSelecionar;
        private System.Windows.Forms.Button btnMarcaPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewMarca;
        private System.Windows.Forms.TextBox txtMarcaPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
    }
}
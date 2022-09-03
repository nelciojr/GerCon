namespace Gerenciador
{
    partial class FrmUnidMedidaPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnidMedidaPesquisa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnUnidMedidaCancelar = new System.Windows.Forms.Button();
            this.btnUnidMedidaSelecionar = new System.Windows.Forms.Button();
            this.btnUnidMedidaPesquisa = new System.Windows.Forms.Button();
            this.dataGridViewUnidMedida = new System.Windows.Forms.DataGridView();
            this.txtUnidMedidaPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id_UnidMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnidMedidaCancelar
            // 
            this.btnUnidMedidaCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnidMedidaCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUnidMedidaCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnUnidMedidaCancelar.Image")));
            this.btnUnidMedidaCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnidMedidaCancelar.Location = new System.Drawing.Point(394, 146);
            this.btnUnidMedidaCancelar.Name = "btnUnidMedidaCancelar";
            this.btnUnidMedidaCancelar.Size = new System.Drawing.Size(70, 60);
            this.btnUnidMedidaCancelar.TabIndex = 17;
            this.btnUnidMedidaCancelar.Text = "Cancelar";
            this.btnUnidMedidaCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnidMedidaCancelar.UseVisualStyleBackColor = true;
            this.btnUnidMedidaCancelar.Click += new System.EventHandler(this.btnUnidMedidaCancelar_Click);
            // 
            // btnUnidMedidaSelecionar
            // 
            this.btnUnidMedidaSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnidMedidaSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("btnUnidMedidaSelecionar.Image")));
            this.btnUnidMedidaSelecionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnidMedidaSelecionar.Location = new System.Drawing.Point(394, 80);
            this.btnUnidMedidaSelecionar.Name = "btnUnidMedidaSelecionar";
            this.btnUnidMedidaSelecionar.Size = new System.Drawing.Size(70, 60);
            this.btnUnidMedidaSelecionar.TabIndex = 16;
            this.btnUnidMedidaSelecionar.Text = "Selecionar";
            this.btnUnidMedidaSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnidMedidaSelecionar.UseVisualStyleBackColor = true;
            this.btnUnidMedidaSelecionar.Click += new System.EventHandler(this.btnUnidMedidaSelecionar_Click);
            // 
            // btnUnidMedidaPesquisa
            // 
            this.btnUnidMedidaPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUnidMedidaPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btnUnidMedidaPesquisa.Image")));
            this.btnUnidMedidaPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUnidMedidaPesquisa.Location = new System.Drawing.Point(394, 14);
            this.btnUnidMedidaPesquisa.Name = "btnUnidMedidaPesquisa";
            this.btnUnidMedidaPesquisa.Size = new System.Drawing.Size(70, 60);
            this.btnUnidMedidaPesquisa.TabIndex = 15;
            this.btnUnidMedidaPesquisa.Text = "Pesquisar";
            this.btnUnidMedidaPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnidMedidaPesquisa.UseVisualStyleBackColor = true;
            this.btnUnidMedidaPesquisa.Click += new System.EventHandler(this.btnUnidMedidaPesquisa_Click);
            // 
            // dataGridViewUnidMedida
            // 
            this.dataGridViewUnidMedida.AllowUserToAddRows = false;
            this.dataGridViewUnidMedida.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewUnidMedida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUnidMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUnidMedida.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUnidMedida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUnidMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnidMedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_UnidMedida,
            this.Descricao,
            this.Legenda});
            this.dataGridViewUnidMedida.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewUnidMedida.Location = new System.Drawing.Point(14, 43);
            this.dataGridViewUnidMedida.MultiSelect = false;
            this.dataGridViewUnidMedida.Name = "dataGridViewUnidMedida";
            this.dataGridViewUnidMedida.ReadOnly = true;
            this.dataGridViewUnidMedida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnidMedida.Size = new System.Drawing.Size(365, 163);
            this.dataGridViewUnidMedida.TabIndex = 14;
            this.dataGridViewUnidMedida.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnidMedida_CellDoubleClick);
            this.dataGridViewUnidMedida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewUnidMedida_KeyDown);
            // 
            // txtUnidMedidaPesquisa
            // 
            this.txtUnidMedidaPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidMedidaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidMedidaPesquisa.Location = new System.Drawing.Point(102, 11);
            this.txtUnidMedidaPesquisa.Name = "txtUnidMedidaPesquisa";
            this.txtUnidMedidaPesquisa.Size = new System.Drawing.Size(277, 22);
            this.txtUnidMedidaPesquisa.TabIndex = 13;
            this.txtUnidMedidaPesquisa.TextChanged += new System.EventHandler(this.txtUnidMedidaPesquisa_TextChanged);
            this.txtUnidMedidaPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnidMedidaPesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Unid Medida";
            // 
            // Id_UnidMedida
            // 
            this.Id_UnidMedida.DataPropertyName = "Id_UnidMedida";
            this.Id_UnidMedida.HeaderText = "Id Unid Medida";
            this.Id_UnidMedida.Name = "Id_UnidMedida";
            this.Id_UnidMedida.ReadOnly = true;
            this.Id_UnidMedida.Visible = false;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Legenda
            // 
            this.Legenda.DataPropertyName = "Legenda";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Legenda.DefaultCellStyle = dataGridViewCellStyle4;
            this.Legenda.HeaderText = "Legenda";
            this.Legenda.Name = "Legenda";
            this.Legenda.ReadOnly = true;
            // 
            // FrmUnidMedidaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnUnidMedidaCancelar;
            this.ClientSize = new System.Drawing.Size(474, 216);
            this.Controls.Add(this.btnUnidMedidaCancelar);
            this.Controls.Add(this.btnUnidMedidaSelecionar);
            this.Controls.Add(this.btnUnidMedidaPesquisa);
            this.Controls.Add(this.dataGridViewUnidMedida);
            this.Controls.Add(this.txtUnidMedidaPesquisa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmUnidMedidaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidade de Medida Pesquisa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUnidMedidaPesquisa_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnidMedida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnidMedidaCancelar;
        private System.Windows.Forms.Button btnUnidMedidaSelecionar;
        private System.Windows.Forms.Button btnUnidMedidaPesquisa;
        private System.Windows.Forms.DataGridView dataGridViewUnidMedida;
        private System.Windows.Forms.TextBox txtUnidMedidaPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_UnidMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legenda;
    }
}
namespace Gerenciador
{
    partial class FrmUnidMedida
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnidMedida));
            this.btnPesquisarUnidMedida = new System.Windows.Forms.Button();
            this.btnExcluirUnidMedida = new System.Windows.Forms.Button();
            this.btnEditarUnidMedida = new System.Windows.Forms.Button();
            this.btnAdcionarUnidMedida = new System.Windows.Forms.Button();
            this.statusStripUnidMedida = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdUnidMedida = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnidMedidaDescricao = new System.Windows.Forms.TextBox();
            this.txtUnidMedidaLegenda = new System.Windows.Forms.TextBox();
            this.errorProviderUnidMedidaDescricao = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnidMedidaLegenda = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStripUnidMedida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnidMedidaDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnidMedidaLegenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarUnidMedida
            // 
            this.btnPesquisarUnidMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarUnidMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarUnidMedida.Image")));
            this.btnPesquisarUnidMedida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarUnidMedida.Location = new System.Drawing.Point(303, 207);
            this.btnPesquisarUnidMedida.Name = "btnPesquisarUnidMedida";
            this.btnPesquisarUnidMedida.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarUnidMedida.TabIndex = 5;
            this.btnPesquisarUnidMedida.Text = "Pesquisar";
            this.btnPesquisarUnidMedida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarUnidMedida.UseVisualStyleBackColor = true;
            this.btnPesquisarUnidMedida.Click += new System.EventHandler(this.btnPesquisarUnidMedida_Click);
            // 
            // btnExcluirUnidMedida
            // 
            this.btnExcluirUnidMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirUnidMedida.Enabled = false;
            this.btnExcluirUnidMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirUnidMedida.Image")));
            this.btnExcluirUnidMedida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirUnidMedida.Location = new System.Drawing.Point(303, 141);
            this.btnExcluirUnidMedida.Name = "btnExcluirUnidMedida";
            this.btnExcluirUnidMedida.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirUnidMedida.TabIndex = 4;
            this.btnExcluirUnidMedida.Text = "Excluir";
            this.btnExcluirUnidMedida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirUnidMedida.UseVisualStyleBackColor = true;
            this.btnExcluirUnidMedida.Click += new System.EventHandler(this.btnExcluirUnidMedida_Click);
            // 
            // btnEditarUnidMedida
            // 
            this.btnEditarUnidMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarUnidMedida.Enabled = false;
            this.btnEditarUnidMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarUnidMedida.Image")));
            this.btnEditarUnidMedida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarUnidMedida.Location = new System.Drawing.Point(303, 75);
            this.btnEditarUnidMedida.Name = "btnEditarUnidMedida";
            this.btnEditarUnidMedida.Size = new System.Drawing.Size(70, 60);
            this.btnEditarUnidMedida.TabIndex = 3;
            this.btnEditarUnidMedida.Text = "Editar";
            this.btnEditarUnidMedida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarUnidMedida.UseVisualStyleBackColor = true;
            this.btnEditarUnidMedida.Click += new System.EventHandler(this.btnEditarUnidMedida_Click);
            // 
            // btnAdcionarUnidMedida
            // 
            this.btnAdcionarUnidMedida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdcionarUnidMedida.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionarUnidMedida.Image")));
            this.btnAdcionarUnidMedida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdcionarUnidMedida.Location = new System.Drawing.Point(303, 9);
            this.btnAdcionarUnidMedida.Name = "btnAdcionarUnidMedida";
            this.btnAdcionarUnidMedida.Size = new System.Drawing.Size(70, 60);
            this.btnAdcionarUnidMedida.TabIndex = 2;
            this.btnAdcionarUnidMedida.Text = "Adicionar";
            this.btnAdcionarUnidMedida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdcionarUnidMedida.UseVisualStyleBackColor = true;
            this.btnAdcionarUnidMedida.Click += new System.EventHandler(this.btnAdcionarUnidMedida_Click);
            // 
            // statusStripUnidMedida
            // 
            this.statusStripUnidMedida.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdUnidMedida});
            this.statusStripUnidMedida.Location = new System.Drawing.Point(0, 279);
            this.statusStripUnidMedida.Name = "statusStripUnidMedida";
            this.statusStripUnidMedida.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStripUnidMedida.Size = new System.Drawing.Size(384, 22);
            this.statusStripUnidMedida.TabIndex = 8;
            this.statusStripUnidMedida.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // toolStripStatusIdUnidMedida
            // 
            this.toolStripStatusIdUnidMedida.Name = "toolStripStatusIdUnidMedida";
            this.toolStripStatusIdUnidMedida.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdUnidMedida.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidade de Medida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Legenda";
            // 
            // txtUnidMedidaDescricao
            // 
            this.txtUnidMedidaDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidMedidaDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidMedidaDescricao.Location = new System.Drawing.Point(15, 69);
            this.txtUnidMedidaDescricao.Name = "txtUnidMedidaDescricao";
            this.txtUnidMedidaDescricao.Size = new System.Drawing.Size(272, 22);
            this.txtUnidMedidaDescricao.TabIndex = 0;
            // 
            // txtUnidMedidaLegenda
            // 
            this.txtUnidMedidaLegenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidMedidaLegenda.Location = new System.Drawing.Point(15, 138);
            this.txtUnidMedidaLegenda.MaxLength = 4;
            this.txtUnidMedidaLegenda.Name = "txtUnidMedidaLegenda";
            this.txtUnidMedidaLegenda.Size = new System.Drawing.Size(62, 22);
            this.txtUnidMedidaLegenda.TabIndex = 1;
            // 
            // errorProviderUnidMedidaDescricao
            // 
            this.errorProviderUnidMedidaDescricao.ContainerControl = this;
            // 
            // errorProviderUnidMedidaLegenda
            // 
            this.errorProviderUnidMedidaLegenda.ContainerControl = this;
            // 
            // FrmUnidMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.txtUnidMedidaLegenda);
            this.Controls.Add(this.txtUnidMedidaDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStripUnidMedida);
            this.Controls.Add(this.btnPesquisarUnidMedida);
            this.Controls.Add(this.btnExcluirUnidMedida);
            this.Controls.Add(this.btnEditarUnidMedida);
            this.Controls.Add(this.btnAdcionarUnidMedida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmUnidMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unidade de Medida";
            this.Load += new System.EventHandler(this.FrmUnidMedida_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUnidMedida_KeyDown);
            this.statusStripUnidMedida.ResumeLayout(false);
            this.statusStripUnidMedida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnidMedidaDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnidMedidaLegenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarUnidMedida;
        private System.Windows.Forms.Button btnExcluirUnidMedida;
        private System.Windows.Forms.Button btnEditarUnidMedida;
        private System.Windows.Forms.Button btnAdcionarUnidMedida;
        private System.Windows.Forms.StatusStrip statusStripUnidMedida;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdUnidMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidMedidaDescricao;
        private System.Windows.Forms.TextBox txtUnidMedidaLegenda;
        private System.Windows.Forms.ErrorProvider errorProviderUnidMedidaDescricao;
        private System.Windows.Forms.ErrorProvider errorProviderUnidMedidaLegenda;
    }
}
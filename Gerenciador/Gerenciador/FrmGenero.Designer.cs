namespace Gerenciador
{
    partial class FrmGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenero));
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripBairro = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdGenero = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPesquisarGenero = new System.Windows.Forms.Button();
            this.btnExcluirGenero = new System.Windows.Forms.Button();
            this.btnEditarGenero = new System.Windows.Forms.Button();
            this.btnAdcionarGenero = new System.Windows.Forms.Button();
            this.errorProviderGenero = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStripBairro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenero
            // 
            this.txtGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(15, 65);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(272, 22);
            this.txtGenero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gênero";
            // 
            // statusStripBairro
            // 
            this.statusStripBairro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdGenero});
            this.statusStripBairro.Location = new System.Drawing.Point(0, 279);
            this.statusStripBairro.Name = "statusStripBairro";
            this.statusStripBairro.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStripBairro.Size = new System.Drawing.Size(384, 22);
            this.statusStripBairro.TabIndex = 6;
            this.statusStripBairro.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // toolStripStatusIdGenero
            // 
            this.toolStripStatusIdGenero.Name = "toolStripStatusIdGenero";
            this.toolStripStatusIdGenero.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdGenero.Text = "0";
            // 
            // btnPesquisarGenero
            // 
            this.btnPesquisarGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarGenero.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarGenero.Image")));
            this.btnPesquisarGenero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarGenero.Location = new System.Drawing.Point(303, 203);
            this.btnPesquisarGenero.Name = "btnPesquisarGenero";
            this.btnPesquisarGenero.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarGenero.TabIndex = 4;
            this.btnPesquisarGenero.Text = "Pesquisar";
            this.btnPesquisarGenero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarGenero.UseVisualStyleBackColor = true;
            this.btnPesquisarGenero.Click += new System.EventHandler(this.btnPesquisarGenero_Click);
            // 
            // btnExcluirGenero
            // 
            this.btnExcluirGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirGenero.Enabled = false;
            this.btnExcluirGenero.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirGenero.Image")));
            this.btnExcluirGenero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirGenero.Location = new System.Drawing.Point(303, 137);
            this.btnExcluirGenero.Name = "btnExcluirGenero";
            this.btnExcluirGenero.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirGenero.TabIndex = 3;
            this.btnExcluirGenero.Text = "Excluir";
            this.btnExcluirGenero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirGenero.UseVisualStyleBackColor = true;
            this.btnExcluirGenero.Click += new System.EventHandler(this.btnExcluirGenero_Click);
            // 
            // btnEditarGenero
            // 
            this.btnEditarGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarGenero.Enabled = false;
            this.btnEditarGenero.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarGenero.Image")));
            this.btnEditarGenero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarGenero.Location = new System.Drawing.Point(303, 71);
            this.btnEditarGenero.Name = "btnEditarGenero";
            this.btnEditarGenero.Size = new System.Drawing.Size(70, 60);
            this.btnEditarGenero.TabIndex = 2;
            this.btnEditarGenero.Text = "Editar";
            this.btnEditarGenero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarGenero.UseVisualStyleBackColor = true;
            this.btnEditarGenero.Click += new System.EventHandler(this.btnEditarGenero_Click);
            // 
            // btnAdcionarGenero
            // 
            this.btnAdcionarGenero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdcionarGenero.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionarGenero.Image")));
            this.btnAdcionarGenero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdcionarGenero.Location = new System.Drawing.Point(303, 5);
            this.btnAdcionarGenero.Name = "btnAdcionarGenero";
            this.btnAdcionarGenero.Size = new System.Drawing.Size(70, 60);
            this.btnAdcionarGenero.TabIndex = 1;
            this.btnAdcionarGenero.Text = "Adicionar";
            this.btnAdcionarGenero.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdcionarGenero.UseVisualStyleBackColor = true;
            this.btnAdcionarGenero.Click += new System.EventHandler(this.btnAdcionarGenero_Click);
            // 
            // errorProviderGenero
            // 
            this.errorProviderGenero.ContainerControl = this;
            // 
            // FrmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStripBairro);
            this.Controls.Add(this.btnPesquisarGenero);
            this.Controls.Add(this.btnExcluirGenero);
            this.Controls.Add(this.btnEditarGenero);
            this.Controls.Add(this.btnAdcionarGenero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genero";
            this.Load += new System.EventHandler(this.FrmGenero_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGenero_KeyDown);
            this.statusStripBairro.ResumeLayout(false);
            this.statusStripBairro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStripBairro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdGenero;
        private System.Windows.Forms.Button btnPesquisarGenero;
        private System.Windows.Forms.Button btnExcluirGenero;
        private System.Windows.Forms.Button btnEditarGenero;
        private System.Windows.Forms.Button btnAdcionarGenero;
        private System.Windows.Forms.ErrorProvider errorProviderGenero;
    }
}
namespace Gerenciador
{
    partial class FrmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripBairro = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdMarca = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPesquisarMarca = new System.Windows.Forms.Button();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnAdcionarMarca = new System.Windows.Forms.Button();
            this.errorProviderMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStripBairro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(15, 65);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(272, 22);
            this.txtMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Marca";
            // 
            // statusStripBairro
            // 
            this.statusStripBairro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdMarca});
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
            // toolStripStatusIdMarca
            // 
            this.toolStripStatusIdMarca.Name = "toolStripStatusIdMarca";
            this.toolStripStatusIdMarca.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdMarca.Text = "0";
            // 
            // btnPesquisarMarca
            // 
            this.btnPesquisarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarMarca.Image")));
            this.btnPesquisarMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarMarca.Location = new System.Drawing.Point(303, 203);
            this.btnPesquisarMarca.Name = "btnPesquisarMarca";
            this.btnPesquisarMarca.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarMarca.TabIndex = 4;
            this.btnPesquisarMarca.Text = "Pesquisar";
            this.btnPesquisarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarMarca.UseVisualStyleBackColor = true;
            this.btnPesquisarMarca.Click += new System.EventHandler(this.btnPesquisarMarca_Click);
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirMarca.Enabled = false;
            this.btnExcluirMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirMarca.Image")));
            this.btnExcluirMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirMarca.Location = new System.Drawing.Point(303, 137);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirMarca.TabIndex = 3;
            this.btnExcluirMarca.Text = "Excluir";
            this.btnExcluirMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirMarca.UseVisualStyleBackColor = true;
            this.btnExcluirMarca.Click += new System.EventHandler(this.btnExcluirMarca_Click);
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarMarca.Enabled = false;
            this.btnEditarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarMarca.Image")));
            this.btnEditarMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarMarca.Location = new System.Drawing.Point(303, 71);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(70, 60);
            this.btnEditarMarca.TabIndex = 2;
            this.btnEditarMarca.Text = "Editar";
            this.btnEditarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
            // 
            // btnAdcionarMarca
            // 
            this.btnAdcionarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdcionarMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionarMarca.Image")));
            this.btnAdcionarMarca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdcionarMarca.Location = new System.Drawing.Point(303, 5);
            this.btnAdcionarMarca.Name = "btnAdcionarMarca";
            this.btnAdcionarMarca.Size = new System.Drawing.Size(70, 60);
            this.btnAdcionarMarca.TabIndex = 1;
            this.btnAdcionarMarca.Text = "Adicionar";
            this.btnAdcionarMarca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdcionarMarca.UseVisualStyleBackColor = true;
            this.btnAdcionarMarca.Click += new System.EventHandler(this.btnAdcionarMarca_Click);
            // 
            // errorProviderMarca
            // 
            this.errorProviderMarca.ContainerControl = this;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStripBairro);
            this.Controls.Add(this.btnPesquisarMarca);
            this.Controls.Add(this.btnExcluirMarca);
            this.Controls.Add(this.btnEditarMarca);
            this.Controls.Add(this.btnAdcionarMarca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMarca_KeyDown);
            this.statusStripBairro.ResumeLayout(false);
            this.statusStripBairro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStripBairro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdMarca;
        private System.Windows.Forms.Button btnPesquisarMarca;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnAdcionarMarca;
        private System.Windows.Forms.ErrorProvider errorProviderMarca;
    }
}
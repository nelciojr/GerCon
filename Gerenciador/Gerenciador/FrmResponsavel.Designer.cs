namespace Gerenciador
{
    partial class FrmResponsavel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResponsavel));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisarResponsavel = new System.Windows.Forms.Button();
            this.btnExcluirResponsavel = new System.Windows.Forms.Button();
            this.btnEditarResponsavel = new System.Windows.Forms.Button();
            this.btnAdcionarResponsavel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mTxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTelFixo = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTelCel = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusIdResponsavel = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProviderResponsavel = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCPF = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelFixo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelFixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefone Fixo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "CPF";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavel.Location = new System.Drawing.Point(13, 45);
            this.txtResponsavel.MaxLength = 50;
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(265, 22);
            this.txtResponsavel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome Completo";
            // 
            // btnPesquisarResponsavel
            // 
            this.btnPesquisarResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarResponsavel.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarResponsavel.Image")));
            this.btnPesquisarResponsavel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarResponsavel.Location = new System.Drawing.Point(304, 219);
            this.btnPesquisarResponsavel.Name = "btnPesquisarResponsavel";
            this.btnPesquisarResponsavel.Size = new System.Drawing.Size(70, 60);
            this.btnPesquisarResponsavel.TabIndex = 7;
            this.btnPesquisarResponsavel.Text = "Pesquisar";
            this.btnPesquisarResponsavel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarResponsavel.UseVisualStyleBackColor = true;
            this.btnPesquisarResponsavel.Click += new System.EventHandler(this.btnPesquisarResponsavel_Click);
            // 
            // btnExcluirResponsavel
            // 
            this.btnExcluirResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirResponsavel.Enabled = false;
            this.btnExcluirResponsavel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirResponsavel.Image")));
            this.btnExcluirResponsavel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirResponsavel.Location = new System.Drawing.Point(304, 153);
            this.btnExcluirResponsavel.Name = "btnExcluirResponsavel";
            this.btnExcluirResponsavel.Size = new System.Drawing.Size(70, 60);
            this.btnExcluirResponsavel.TabIndex = 6;
            this.btnExcluirResponsavel.Text = "Excluir";
            this.btnExcluirResponsavel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirResponsavel.UseVisualStyleBackColor = true;
            this.btnExcluirResponsavel.Click += new System.EventHandler(this.btnExcluirResponsavel_Click);
            // 
            // btnEditarResponsavel
            // 
            this.btnEditarResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarResponsavel.Enabled = false;
            this.btnEditarResponsavel.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarResponsavel.Image")));
            this.btnEditarResponsavel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarResponsavel.Location = new System.Drawing.Point(304, 87);
            this.btnEditarResponsavel.Name = "btnEditarResponsavel";
            this.btnEditarResponsavel.Size = new System.Drawing.Size(70, 60);
            this.btnEditarResponsavel.TabIndex = 5;
            this.btnEditarResponsavel.Text = "Editar";
            this.btnEditarResponsavel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarResponsavel.UseVisualStyleBackColor = true;
            this.btnEditarResponsavel.Click += new System.EventHandler(this.btnEditarResponsavel_Click);
            // 
            // btnAdcionarResponsavel
            // 
            this.btnAdcionarResponsavel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdcionarResponsavel.Image = ((System.Drawing.Image)(resources.GetObject("btnAdcionarResponsavel.Image")));
            this.btnAdcionarResponsavel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdcionarResponsavel.Location = new System.Drawing.Point(304, 21);
            this.btnAdcionarResponsavel.Name = "btnAdcionarResponsavel";
            this.btnAdcionarResponsavel.Size = new System.Drawing.Size(70, 60);
            this.btnAdcionarResponsavel.TabIndex = 4;
            this.btnAdcionarResponsavel.Text = "Adicionar";
            this.btnAdcionarResponsavel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdcionarResponsavel.UseVisualStyleBackColor = true;
            this.btnAdcionarResponsavel.Click += new System.EventHandler(this.btnAdcionarResponsavel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefone Celular";
            // 
            // mTxtCPF
            // 
            this.mTxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtCPF.Location = new System.Drawing.Point(13, 111);
            this.mTxtCPF.Mask = "000,000,000-00";
            this.mTxtCPF.Name = "mTxtCPF";
            this.mTxtCPF.Size = new System.Drawing.Size(104, 22);
            this.mTxtCPF.TabIndex = 1;
            // 
            // mTxtTelFixo
            // 
            this.mTxtTelFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtTelFixo.Location = new System.Drawing.Point(13, 177);
            this.mTxtTelFixo.Mask = "(00)0000-0000";
            this.mTxtTelFixo.Name = "mTxtTelFixo";
            this.mTxtTelFixo.Size = new System.Drawing.Size(104, 22);
            this.mTxtTelFixo.TabIndex = 2;
            // 
            // mTxtTelCel
            // 
            this.mTxtTelCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtTelCel.Location = new System.Drawing.Point(13, 238);
            this.mTxtTelCel.Mask = "(00)00000-0000";
            this.mTxtTelCel.Name = "mTxtTelCel";
            this.mTxtTelCel.Size = new System.Drawing.Size(104, 22);
            this.mTxtTelCel.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.toolStripStatusIdResponsavel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(384, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // toolStripStatusIdResponsavel
            // 
            this.toolStripStatusIdResponsavel.Name = "toolStripStatusIdResponsavel";
            this.toolStripStatusIdResponsavel.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusIdResponsavel.Text = "0";
            // 
            // errorProviderResponsavel
            // 
            this.errorProviderResponsavel.ContainerControl = this;
            // 
            // errorProviderCPF
            // 
            this.errorProviderCPF.ContainerControl = this;
            // 
            // errorProviderTelFixo
            // 
            this.errorProviderTelFixo.ContainerControl = this;
            // 
            // errorProviderTelCelular
            // 
            this.errorProviderTelCelular.ContainerControl = this;
            // 
            // FrmResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mTxtTelCel);
            this.Controls.Add(this.mTxtTelFixo);
            this.Controls.Add(this.mTxtCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisarResponsavel);
            this.Controls.Add(this.btnExcluirResponsavel);
            this.Controls.Add(this.btnEditarResponsavel);
            this.Controls.Add(this.btnAdcionarResponsavel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responsável";
            this.Load += new System.EventHandler(this.FrmResponsavel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmResponsavel_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelFixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelCelular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisarResponsavel;
        private System.Windows.Forms.Button btnExcluirResponsavel;
        private System.Windows.Forms.Button btnEditarResponsavel;
        private System.Windows.Forms.Button btnAdcionarResponsavel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mTxtCPF;
        private System.Windows.Forms.MaskedTextBox mTxtTelFixo;
        private System.Windows.Forms.MaskedTextBox mTxtTelCel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusIdResponsavel;
        private System.Windows.Forms.ErrorProvider errorProviderResponsavel;
        private System.Windows.Forms.ErrorProvider errorProviderCPF;
        private System.Windows.Forms.ErrorProvider errorProviderTelFixo;
        private System.Windows.Forms.ErrorProvider errorProviderTelCelular;
    }
}
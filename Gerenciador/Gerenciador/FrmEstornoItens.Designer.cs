namespace Gerenciador
{
    partial class FrmEstornoItens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstornoItens));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusID = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSIdContrato = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSIdUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSIdBaixaItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalEstorno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVMaxEstorno = new System.Windows.Forms.TextBox();
            this.txtVTotalEstorno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVUnitEstorno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdeEstorno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSaldoContrato = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalContrato = new System.Windows.Forms.TextBox();
            this.dgwEstornoContrato = new System.Windows.Forms.DataGridView();
            this.btnCancelarEstorno = new System.Windows.Forms.Button();
            this.btnAdEstorno = new System.Windows.Forms.Button();
            this.Id_BaixaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdutoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtde_BaixaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Baixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdeSaldo_ItemBaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo_BaixaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartamentoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePrQtdeEstorno = new System.Windows.Forms.ErrorProvider(this.components);
            this.tSSIdItem = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEstornoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrQtdeEstorno)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusID,
            this.tSSIdContrato,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tSSIdUsuario,
            this.tSSIdBaixaItem,
            this.tSSIdItem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 220);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
            this.statusStrip1.TabIndex = 72;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusID
            // 
            this.toolStripStatusID.Name = "toolStripStatusID";
            this.toolStripStatusID.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusID.Text = "Cód.:";
            // 
            // tSSIdContrato
            // 
            this.tSSIdContrato.Name = "tSSIdContrato";
            this.tSSIdContrato.Size = new System.Drawing.Size(13, 17);
            this.tSSIdContrato.Text = "0";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(21, 17);
            this.toolStripStatusLabel1.Text = " -  ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel2.Text = "Usuário: ";
            // 
            // tSSIdUsuario
            // 
            this.tSSIdUsuario.Name = "tSSIdUsuario";
            this.tSSIdUsuario.Size = new System.Drawing.Size(40, 17);
            this.tSSIdUsuario.Text = "Nome";
            // 
            // tSSIdBaixaItem
            // 
            this.tSSIdBaixaItem.Name = "tSSIdBaixaItem";
            this.tSSIdBaixaItem.Size = new System.Drawing.Size(58, 17);
            this.tSSIdBaixaItem.Text = "BaixaItem";
            this.tSSIdBaixaItem.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtTotalEstorno);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtVMaxEstorno);
            this.panel2.Location = new System.Drawing.Point(420, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 74);
            this.panel2.TabIndex = 67;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Estorno";
            // 
            // txtTotalEstorno
            // 
            this.txtTotalEstorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEstorno.Location = new System.Drawing.Point(166, 46);
            this.txtTotalEstorno.Name = "txtTotalEstorno";
            this.txtTotalEstorno.ReadOnly = true;
            this.txtTotalEstorno.Size = new System.Drawing.Size(148, 22);
            this.txtTotalEstorno.TabIndex = 1;
            this.txtTotalEstorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "V. Máx. Permitido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(163, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total";
            // 
            // txtVMaxEstorno
            // 
            this.txtVMaxEstorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVMaxEstorno.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVMaxEstorno.Location = new System.Drawing.Point(12, 46);
            this.txtVMaxEstorno.Name = "txtVMaxEstorno";
            this.txtVMaxEstorno.ReadOnly = true;
            this.txtVMaxEstorno.Size = new System.Drawing.Size(148, 22);
            this.txtVMaxEstorno.TabIndex = 0;
            this.txtVMaxEstorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVTotalEstorno
            // 
            this.txtVTotalEstorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVTotalEstorno.Location = new System.Drawing.Point(198, 28);
            this.txtVTotalEstorno.Name = "txtVTotalEstorno";
            this.txtVTotalEstorno.ReadOnly = true;
            this.txtVTotalEstorno.Size = new System.Drawing.Size(101, 22);
            this.txtVTotalEstorno.TabIndex = 63;
            this.txtVTotalEstorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "V. Total";
            // 
            // txtVUnitEstorno
            // 
            this.txtVUnitEstorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVUnitEstorno.Location = new System.Drawing.Point(95, 28);
            this.txtVUnitEstorno.Name = "txtVUnitEstorno";
            this.txtVUnitEstorno.ReadOnly = true;
            this.txtVUnitEstorno.Size = new System.Drawing.Size(85, 22);
            this.txtVUnitEstorno.TabIndex = 62;
            this.txtVUnitEstorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(92, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 69;
            this.label6.Text = "V. Unitário";
            // 
            // txtQtdeEstorno
            // 
            this.txtQtdeEstorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEstorno.Location = new System.Drawing.Point(12, 28);
            this.txtQtdeEstorno.Name = "txtQtdeEstorno";
            this.txtQtdeEstorno.Size = new System.Drawing.Size(65, 22);
            this.txtQtdeEstorno.TabIndex = 61;
            this.txtQtdeEstorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtdeEstorno.TextChanged += new System.EventHandler(this.txtQtdeEstorno_TextChanged);
            this.txtQtdeEstorno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeEstorno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 68;
            this.label5.Text = "Qtde";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtSaldoContrato);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtTotalContrato);
            this.panel1.Location = new System.Drawing.Point(12, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 74);
            this.panel1.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Contrato";
            // 
            // txtSaldoContrato
            // 
            this.txtSaldoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoContrato.Location = new System.Drawing.Point(165, 46);
            this.txtSaldoContrato.Name = "txtSaldoContrato";
            this.txtSaldoContrato.ReadOnly = true;
            this.txtSaldoContrato.Size = new System.Drawing.Size(148, 22);
            this.txtSaldoContrato.TabIndex = 1;
            this.txtSaldoContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(162, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Saldo";
            // 
            // txtTotalContrato
            // 
            this.txtTotalContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalContrato.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalContrato.Location = new System.Drawing.Point(11, 46);
            this.txtTotalContrato.Name = "txtTotalContrato";
            this.txtTotalContrato.ReadOnly = true;
            this.txtTotalContrato.Size = new System.Drawing.Size(148, 22);
            this.txtTotalContrato.TabIndex = 0;
            this.txtTotalContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgwEstornoContrato
            // 
            this.dgwEstornoContrato.AllowUserToAddRows = false;
            this.dgwEstornoContrato.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwEstornoContrato.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwEstornoContrato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwEstornoContrato.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwEstornoContrato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgwEstornoContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEstornoContrato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_BaixaItem,
            this.ProdutoItem,
            this.Qtde_BaixaItem,
            this.Valor_Baixa,
            this.QtdeSaldo_ItemBaixa,
            this.Saldo_BaixaItem,
            this.DepartamentoItem});
            this.dgwEstornoContrato.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgwEstornoContrato.Location = new System.Drawing.Point(12, 56);
            this.dgwEstornoContrato.MultiSelect = false;
            this.dgwEstornoContrato.Name = "dgwEstornoContrato";
            this.dgwEstornoContrato.ReadOnly = true;
            this.dgwEstornoContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEstornoContrato.Size = new System.Drawing.Size(734, 81);
            this.dgwEstornoContrato.TabIndex = 71;
            this.dgwEstornoContrato.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwEstornoContrato_CellFormatting);
            // 
            // btnCancelarEstorno
            // 
            this.btnCancelarEstorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEstorno.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarEstorno.Image")));
            this.btnCancelarEstorno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarEstorno.Location = new System.Drawing.Point(752, 94);
            this.btnCancelarEstorno.Name = "btnCancelarEstorno";
            this.btnCancelarEstorno.Size = new System.Drawing.Size(70, 60);
            this.btnCancelarEstorno.TabIndex = 65;
            this.btnCancelarEstorno.Text = "Cancelar";
            this.btnCancelarEstorno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarEstorno.UseVisualStyleBackColor = true;
            this.btnCancelarEstorno.Click += new System.EventHandler(this.btnCancelarEstorno_Click);
            // 
            // btnAdEstorno
            // 
            this.btnAdEstorno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdEstorno.Image = ((System.Drawing.Image)(resources.GetObject("btnAdEstorno.Image")));
            this.btnAdEstorno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdEstorno.Location = new System.Drawing.Point(752, 28);
            this.btnAdEstorno.Name = "btnAdEstorno";
            this.btnAdEstorno.Size = new System.Drawing.Size(70, 60);
            this.btnAdEstorno.TabIndex = 64;
            this.btnAdEstorno.Text = "Estorno";
            this.btnAdEstorno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdEstorno.UseVisualStyleBackColor = true;
            this.btnAdEstorno.Click += new System.EventHandler(this.btnAdEstorno_Click);
            // 
            // Id_BaixaItem
            // 
            this.Id_BaixaItem.DataPropertyName = "Id_BaixaItem";
            this.Id_BaixaItem.HeaderText = "Id Baixa Item";
            this.Id_BaixaItem.Name = "Id_BaixaItem";
            this.Id_BaixaItem.ReadOnly = true;
            this.Id_BaixaItem.Visible = false;
            // 
            // ProdutoItem
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdutoItem.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProdutoItem.HeaderText = "Produto";
            this.ProdutoItem.Name = "ProdutoItem";
            this.ProdutoItem.ReadOnly = true;
            this.ProdutoItem.Width = 150;
            // 
            // Qtde_BaixaItem
            // 
            this.Qtde_BaixaItem.DataPropertyName = "Qtde_BaixaItem";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qtde_BaixaItem.DefaultCellStyle = dataGridViewCellStyle12;
            this.Qtde_BaixaItem.HeaderText = "Qtde";
            this.Qtde_BaixaItem.Name = "Qtde_BaixaItem";
            this.Qtde_BaixaItem.ReadOnly = true;
            this.Qtde_BaixaItem.Width = 90;
            // 
            // Valor_Baixa
            // 
            this.Valor_Baixa.DataPropertyName = "Valor_Baixa";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.Format = "C2";
            dataGridViewCellStyle13.NullValue = null;
            this.Valor_Baixa.DefaultCellStyle = dataGridViewCellStyle13;
            this.Valor_Baixa.HeaderText = "V. Total";
            this.Valor_Baixa.Name = "Valor_Baixa";
            this.Valor_Baixa.ReadOnly = true;
            this.Valor_Baixa.Width = 150;
            // 
            // QtdeSaldo_ItemBaixa
            // 
            this.QtdeSaldo_ItemBaixa.DataPropertyName = "QtdeSaldo_BaixaItem";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtdeSaldo_ItemBaixa.DefaultCellStyle = dataGridViewCellStyle14;
            this.QtdeSaldo_ItemBaixa.HeaderText = "Qtde Saldo Item";
            this.QtdeSaldo_ItemBaixa.Name = "QtdeSaldo_ItemBaixa";
            this.QtdeSaldo_ItemBaixa.ReadOnly = true;
            this.QtdeSaldo_ItemBaixa.Width = 130;
            // 
            // Saldo_BaixaItem
            // 
            this.Saldo_BaixaItem.DataPropertyName = "Saldo_BaixaItem";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.Saldo_BaixaItem.DefaultCellStyle = dataGridViewCellStyle15;
            this.Saldo_BaixaItem.HeaderText = "Saldo Item";
            this.Saldo_BaixaItem.Name = "Saldo_BaixaItem";
            this.Saldo_BaixaItem.ReadOnly = true;
            this.Saldo_BaixaItem.Width = 150;
            // 
            // DepartamentoItem
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartamentoItem.DefaultCellStyle = dataGridViewCellStyle16;
            this.DepartamentoItem.HeaderText = "Departamento";
            this.DepartamentoItem.Name = "DepartamentoItem";
            this.DepartamentoItem.ReadOnly = true;
            this.DepartamentoItem.Width = 200;
            // 
            // ePrQtdeEstorno
            // 
            this.ePrQtdeEstorno.ContainerControl = this;
            // 
            // tSSIdItem
            // 
            this.tSSIdItem.Name = "tSSIdItem";
            this.tSSIdItem.Size = new System.Drawing.Size(31, 17);
            this.tSSIdItem.Text = "Item";
            this.tSSIdItem.Visible = false;
            // 
            // FrmEstornoItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 242);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtVTotalEstorno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVUnitEstorno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQtdeEstorno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgwEstornoContrato);
            this.Controls.Add(this.btnCancelarEstorno);
            this.Controls.Add(this.btnAdEstorno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmEstornoItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estorno Itens";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstornoItens_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEstornoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePrQtdeEstorno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusID;
        private System.Windows.Forms.ToolStripStatusLabel tSSIdContrato;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tSSIdUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tSSIdBaixaItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalEstorno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVMaxEstorno;
        private System.Windows.Forms.TextBox txtVTotalEstorno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVUnitEstorno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQtdeEstorno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSaldoContrato;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalContrato;
        private System.Windows.Forms.DataGridView dgwEstornoContrato;
        private System.Windows.Forms.Button btnCancelarEstorno;
        private System.Windows.Forms.Button btnAdEstorno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_BaixaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtde_BaixaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Baixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdeSaldo_ItemBaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo_BaixaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartamentoItem;
        private System.Windows.Forms.ErrorProvider ePrQtdeEstorno;
        private System.Windows.Forms.ToolStripStatusLabel tSSIdItem;
    }
}
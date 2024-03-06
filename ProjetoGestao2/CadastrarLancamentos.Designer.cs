namespace ProjetoGestao2
{
    partial class fmCadastrarLancamentos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCadastrarLancamentos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtCpfLancamento = new MaskedTextBox();
            txtDataCompra = new MaskedTextBox();
            txtDataEntrada = new MaskedTextBox();
            txtNome = new TextBox();
            txtID = new TextBox();
            txtBanco = new TextBox();
            txtValor = new TextBox();
            txtHistorico = new TextBox();
            btGravar = new Button();
            imageList1 = new ImageList(components);
            btAlterar = new Button();
            btDeletar = new Button();
            gpBoxPesquisar = new GroupBox();
            cbFiltro = new ComboBox();
            btLimpar = new Button();
            btPesquisar = new Button();
            txtFiltro = new TextBox();
            dtGrid = new DataGridView();
            gpBoxPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F);
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 0;
            label1.Text = "CPF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F);
            label2.Location = new Point(171, 19);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F);
            label3.Location = new Point(298, 19);
            label3.Name = "label3";
            label3.Size = new Size(24, 17);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F);
            label4.Location = new Point(355, 18);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 6;
            label4.Text = "Banco";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F);
            label5.Location = new Point(493, 18);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 8;
            label5.Text = "Valor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F);
            label6.Location = new Point(33, 87);
            label6.Name = "label6";
            label6.Size = new Size(106, 17);
            label6.TabIndex = 10;
            label6.Text = "Data da Compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F);
            label7.Location = new Point(171, 87);
            label7.Name = "label7";
            label7.Size = new Size(105, 17);
            label7.TabIndex = 12;
            label7.Text = "Data da Entrada";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11.25F);
            label8.Location = new Point(298, 87);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 14;
            label8.Text = "Historico";
            // 
            // txtCpfLancamento
            // 
            txtCpfLancamento.Font = new Font("Times New Roman", 11.25F);
            txtCpfLancamento.Location = new Point(33, 37);
            txtCpfLancamento.Mask = "000,000,000-00";
            txtCpfLancamento.Name = "txtCpfLancamento";
            txtCpfLancamento.Size = new Size(113, 25);
            txtCpfLancamento.TabIndex = 1;
            txtCpfLancamento.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCpfLancamento.KeyDown += txtCpfLancamento_KeyDown;
            // 
            // txtDataCompra
            // 
            txtDataCompra.Font = new Font("Times New Roman", 11.25F);
            txtDataCompra.Location = new Point(33, 107);
            txtDataCompra.Mask = "00/00/0000";
            txtDataCompra.Name = "txtDataCompra";
            txtDataCompra.Size = new Size(113, 25);
            txtDataCompra.TabIndex = 11;
            txtDataCompra.ValidatingType = typeof(DateTime);
            // 
            // txtDataEntrada
            // 
            txtDataEntrada.Font = new Font("Times New Roman", 11.25F);
            txtDataEntrada.Location = new Point(171, 107);
            txtDataEntrada.Mask = "00/00/0000";
            txtDataEntrada.Name = "txtDataEntrada";
            txtDataEntrada.Size = new Size(113, 25);
            txtDataEntrada.TabIndex = 13;
            txtDataEntrada.ValidatingType = typeof(DateTime);
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Times New Roman", 11.25F);
            txtNome.Location = new Point(170, 38);
            txtNome.Name = "txtNome";
            txtNome.ReadOnly = true;
            txtNome.Size = new Size(113, 25);
            txtNome.TabIndex = 3;
            // 
            // txtID
            // 
            txtID.Font = new Font("Times New Roman", 11.25F);
            txtID.Location = new Point(301, 38);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(38, 25);
            txtID.TabIndex = 5;
            // 
            // txtBanco
            // 
            txtBanco.Font = new Font("Times New Roman", 11.25F);
            txtBanco.Location = new Point(355, 38);
            txtBanco.MaxLength = 15;
            txtBanco.Name = "txtBanco";
            txtBanco.Size = new Size(113, 25);
            txtBanco.TabIndex = 7;
            // 
            // txtValor
            // 
            txtValor.Font = new Font("Times New Roman", 11.25F);
            txtValor.Location = new Point(493, 38);
            txtValor.MaxLength = 7;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(112, 25);
            txtValor.TabIndex = 9;
            // 
            // txtHistorico
            // 
            txtHistorico.Font = new Font("Times New Roman", 11.25F);
            txtHistorico.Location = new Point(298, 107);
            txtHistorico.MaxLength = 45;
            txtHistorico.Name = "txtHistorico";
            txtHistorico.Size = new Size(307, 25);
            txtHistorico.TabIndex = 15;
            // 
            // btGravar
            // 
            btGravar.Font = new Font("Times New Roman", 11.25F);
            btGravar.ImageAlign = ContentAlignment.MiddleLeft;
            btGravar.ImageKey = "disquete.png";
            btGravar.ImageList = imageList1;
            btGravar.Location = new Point(33, 165);
            btGravar.Name = "btGravar";
            btGravar.Padding = new Padding(15, 0, 5, 0);
            btGravar.Size = new Size(113, 47);
            btGravar.TabIndex = 16;
            btGravar.Text = "Gravar";
            btGravar.TextAlign = ContentAlignment.MiddleRight;
            btGravar.UseVisualStyleBackColor = true;
            btGravar.Click += btGravar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "borracha.png");
            imageList1.Images.SetKeyName(1, "lapis.png");
            imageList1.Images.SetKeyName(2, "lupa.png");
            imageList1.Images.SetKeyName(3, "lixeira.png");
            imageList1.Images.SetKeyName(4, "disquete.png");
            // 
            // btAlterar
            // 
            btAlterar.Font = new Font("Times New Roman", 11.25F);
            btAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btAlterar.ImageKey = "lapis.png";
            btAlterar.ImageList = imageList1;
            btAlterar.Location = new Point(243, 165);
            btAlterar.Name = "btAlterar";
            btAlterar.Padding = new Padding(15, 0, 5, 0);
            btAlterar.Size = new Size(113, 47);
            btAlterar.TabIndex = 17;
            btAlterar.Text = "Alterar";
            btAlterar.TextAlign = ContentAlignment.MiddleRight;
            btAlterar.UseVisualStyleBackColor = true;
            btAlterar.Click += btAlterar_Click;
            // 
            // btDeletar
            // 
            btDeletar.Font = new Font("Times New Roman", 11.25F);
            btDeletar.ImageAlign = ContentAlignment.MiddleLeft;
            btDeletar.ImageKey = "lixeira.png";
            btDeletar.ImageList = imageList1;
            btDeletar.Location = new Point(437, 165);
            btDeletar.Name = "btDeletar";
            btDeletar.Padding = new Padding(15, 0, 5, 0);
            btDeletar.Size = new Size(113, 47);
            btDeletar.TabIndex = 18;
            btDeletar.Text = "Excluir";
            btDeletar.TextAlign = ContentAlignment.MiddleRight;
            btDeletar.UseVisualStyleBackColor = true;
            btDeletar.Click += btDeletar_Click;
            // 
            // gpBoxPesquisar
            // 
            gpBoxPesquisar.Controls.Add(cbFiltro);
            gpBoxPesquisar.Controls.Add(btLimpar);
            gpBoxPesquisar.Controls.Add(btPesquisar);
            gpBoxPesquisar.Controls.Add(txtFiltro);
            gpBoxPesquisar.Font = new Font("Times New Roman", 11.25F);
            gpBoxPesquisar.Location = new Point(653, 14);
            gpBoxPesquisar.Name = "gpBoxPesquisar";
            gpBoxPesquisar.Size = new Size(250, 198);
            gpBoxPesquisar.TabIndex = 19;
            gpBoxPesquisar.TabStop = false;
            gpBoxPesquisar.Text = "Pesquisar";
            // 
            // cbFiltro
            // 
            cbFiltro.FormattingEnabled = true;
            cbFiltro.Items.AddRange(new object[] { "cpf_lancamentos", "id", "banco", "valor", "historico" });
            cbFiltro.Location = new Point(32, 36);
            cbFiltro.Name = "cbFiltro";
            cbFiltro.Size = new Size(191, 25);
            cbFiltro.TabIndex = 0;
            // 
            // btLimpar
            // 
            btLimpar.ImageAlign = ContentAlignment.MiddleLeft;
            btLimpar.ImageKey = "borracha.png";
            btLimpar.ImageList = imageList1;
            btLimpar.Location = new Point(135, 124);
            btLimpar.Name = "btLimpar";
            btLimpar.Padding = new Padding(15, 0, 5, 0);
            btLimpar.Size = new Size(113, 47);
            btLimpar.TabIndex = 3;
            btLimpar.Text = "Limpar";
            btLimpar.TextAlign = ContentAlignment.MiddleRight;
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btPesquisar
            // 
            btPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btPesquisar.ImageIndex = 2;
            btPesquisar.ImageList = imageList1;
            btPesquisar.Location = new Point(16, 124);
            btPesquisar.Name = "btPesquisar";
            btPesquisar.Padding = new Padding(8, 0, 4, 0);
            btPesquisar.Size = new Size(113, 47);
            btPesquisar.TabIndex = 2;
            btPesquisar.Text = "Pesquisar";
            btPesquisar.TextAlign = ContentAlignment.MiddleRight;
            btPesquisar.UseVisualStyleBackColor = true;
            btPesquisar.Click += btPesquisar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(32, 87);
            txtFiltro.MaxLength = 45;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(191, 25);
            txtFiltro.TabIndex = 1;
            // 
            // dtGrid
            // 
            dtGrid.AllowUserToAddRows = false;
            dtGrid.AllowUserToDeleteRows = false;
            dtGrid.AllowUserToOrderColumns = true;
            dtGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dtGrid.Location = new Point(12, 274);
            dtGrid.Name = "dtGrid";
            dtGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGrid.Size = new Size(891, 235);
            dtGrid.TabIndex = 20;
            dtGrid.CellMouseDoubleClick += dtGrid_CellMouseDoubleClick;
            // 
            // fmCadastrarLancamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 530);
            Controls.Add(gpBoxPesquisar);
            Controls.Add(btDeletar);
            Controls.Add(btAlterar);
            Controls.Add(btGravar);
            Controls.Add(txtHistorico);
            Controls.Add(txtValor);
            Controls.Add(txtBanco);
            Controls.Add(txtID);
            Controls.Add(txtNome);
            Controls.Add(txtDataEntrada);
            Controls.Add(txtDataCompra);
            Controls.Add(txtCpfLancamento);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtGrid);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fmCadastrarLancamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Lancamentos";
            Load += fmCadastrarLancamentos_Load;
            gpBoxPesquisar.ResumeLayout(false);
            gpBoxPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private MaskedTextBox txtCpfLancamento;
        private MaskedTextBox txtDataCompra;
        private MaskedTextBox txtDataEntrada;
        private TextBox txtNome;
        private TextBox txtID;
        private TextBox txtBanco;
        private TextBox txtValor;
        private TextBox txtHistorico;
        private Button btGravar;
        private Button btAlterar;
        private Button btDeletar;
        private GroupBox gpBoxPesquisar;
        private Button btLimpar;
        private Button btPesquisar;
        private TextBox txtFiltro;
        private ComboBox cbFiltro;
        private ImageList imageList1;
    }
}
namespace ProjetoGestao2
{
    partial class fmCadastrarPessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmCadastrarPessoas));
            txtCpfCadastro = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            txtNomeCadastro = new TextBox();
            btGravarPessoa = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // txtCpfCadastro
            // 
            txtCpfCadastro.Font = new Font("Times New Roman", 11.25F);
            txtCpfCadastro.Location = new Point(98, 69);
            txtCpfCadastro.Mask = "000,000,000-00";
            txtCpfCadastro.Name = "txtCpfCadastro";
            txtCpfCadastro.Size = new Size(109, 25);
            txtCpfCadastro.TabIndex = 0;
            txtCpfCadastro.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F);
            label1.Location = new Point(43, 161);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F);
            label2.Location = new Point(43, 77);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 3;
            label2.Text = "CPF";
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.Font = new Font("Times New Roman", 11.25F);
            txtNomeCadastro.Location = new Point(98, 153);
            txtNomeCadastro.MaxLength = 30;
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.Size = new Size(109, 25);
            txtNomeCadastro.TabIndex = 4;
            // 
            // btGravarPessoa
            // 
            btGravarPessoa.Font = new Font("Times New Roman", 11.25F);
            btGravarPessoa.ImageAlign = ContentAlignment.MiddleLeft;
            btGravarPessoa.ImageKey = "disquete.png";
            btGravarPessoa.ImageList = imageList1;
            btGravarPessoa.Location = new Point(69, 229);
            btGravarPessoa.Name = "btGravarPessoa";
            btGravarPessoa.Padding = new Padding(15, 0, 12, 0);
            btGravarPessoa.Size = new Size(148, 71);
            btGravarPessoa.TabIndex = 5;
            btGravarPessoa.Text = "Gravar";
            btGravarPessoa.TextAlign = ContentAlignment.MiddleRight;
            btGravarPessoa.UseVisualStyleBackColor = true;
            btGravarPessoa.Click += btGravarPessoa_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "disquete.png");
            // 
            // fmCadastrarPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 394);
            Controls.Add(btGravarPessoa);
            Controls.Add(txtNomeCadastro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCpfCadastro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "fmCadastrarPessoas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Pessoas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtCpfCadastro;
        private Label label1;
        private Label label2;
        private TextBox txtNomeCadastro;
        private Button btGravarPessoa;
        private ImageList imageList1;
    }
}
namespace Atron
{
    partial class frmPopUpDetalhesProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopUpDetalhesProduto));
            picImagem = new PictureBox();
            lblCodigoTitulo = new Label();
            lblNomeTitulo = new Label();
            lblNome = new Label();
            lblContinuaNome = new Label();
            lblCodigo = new Label();
            lblTamanho = new Label();
            lblTamanhoTitulo = new Label();
            lblEstoque = new Label();
            lblEstoqueTitulo = new Label();
            btnMudarProduto = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            SuspendLayout();
            // 
            // picImagem
            // 
            picImagem.Image = (Image)resources.GetObject("picImagem.Image");
            picImagem.Location = new Point(12, 35);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(361, 199);
            picImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagem.TabIndex = 0;
            picImagem.TabStop = false;
            // 
            // lblCodigoTitulo
            // 
            lblCodigoTitulo.AutoSize = true;
            lblCodigoTitulo.Font = new Font("Bebas Neue", 17F);
            lblCodigoTitulo.ForeColor = Color.FromArgb(9, 28, 128);
            lblCodigoTitulo.Location = new Point(388, 33);
            lblCodigoTitulo.Name = "lblCodigoTitulo";
            lblCodigoTitulo.Size = new Size(57, 38);
            lblCodigoTitulo.TabIndex = 1;
            lblCodigoTitulo.Text = "Cod:";
            // 
            // lblNomeTitulo
            // 
            lblNomeTitulo.AutoSize = true;
            lblNomeTitulo.Font = new Font("Bebas Neue", 17F);
            lblNomeTitulo.ForeColor = Color.FromArgb(9, 28, 128);
            lblNomeTitulo.Location = new Point(388, 84);
            lblNomeTitulo.Name = "lblNomeTitulo";
            lblNomeTitulo.Size = new Size(73, 38);
            lblNomeTitulo.TabIndex = 2;
            lblNomeTitulo.Text = "nome:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Lato", 15F);
            lblNome.Location = new Point(457, 84);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(240, 30);
            lblNome.TabIndex = 3;
            lblNome.Text = "Tênis Puma MB 0.2 - ";
            lblNome.Click += label1_Click;
            // 
            // lblContinuaNome
            // 
            lblContinuaNome.AutoSize = true;
            lblContinuaNome.Font = new Font("Lato", 15F);
            lblContinuaNome.Location = new Point(388, 114);
            lblContinuaNome.Name = "lblContinuaNome";
            lblContinuaNome.Size = new Size(275, 30);
            lblContinuaNome.TabIndex = 4;
            lblContinuaNome.Text = "Masculino Roxo e Verde";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Lato", 15F);
            lblCodigo.Location = new Point(457, 35);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 30);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "224";
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Font = new Font("Lato", 15F);
            lblTamanho.Location = new Point(485, 160);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(43, 30);
            lblTamanho.TabIndex = 7;
            lblTamanho.Text = "42";
            // 
            // lblTamanhoTitulo
            // 
            lblTamanhoTitulo.AutoSize = true;
            lblTamanhoTitulo.Font = new Font("Bebas Neue", 17F);
            lblTamanhoTitulo.ForeColor = Color.FromArgb(9, 28, 128);
            lblTamanhoTitulo.Location = new Point(382, 158);
            lblTamanhoTitulo.Name = "lblTamanhoTitulo";
            lblTamanhoTitulo.Size = new Size(108, 38);
            lblTamanhoTitulo.TabIndex = 6;
            lblTamanhoTitulo.Text = "tamanho:";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Lato", 15F);
            lblEstoque.Location = new Point(485, 204);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(28, 30);
            lblEstoque.TabIndex = 9;
            lblEstoque.Text = "4";
            lblEstoque.Click += label5_Click;
            // 
            // lblEstoqueTitulo
            // 
            lblEstoqueTitulo.AutoSize = true;
            lblEstoqueTitulo.Font = new Font("Bebas Neue", 17F);
            lblEstoqueTitulo.ForeColor = Color.FromArgb(9, 28, 128);
            lblEstoqueTitulo.Location = new Point(382, 202);
            lblEstoqueTitulo.Name = "lblEstoqueTitulo";
            lblEstoqueTitulo.Size = new Size(102, 38);
            lblEstoqueTitulo.TabIndex = 8;
            lblEstoqueTitulo.Text = "estoque:";
            // 
            // btnMudarProduto
            // 
            btnMudarProduto.BackColor = Color.FromArgb(9, 28, 128);
            btnMudarProduto.Font = new Font("Bebas Neue", 22.2F);
            btnMudarProduto.ForeColor = Color.White;
            btnMudarProduto.Location = new Point(382, 258);
            btnMudarProduto.Name = "btnMudarProduto";
            btnMudarProduto.Size = new Size(265, 74);
            btnMudarProduto.TabIndex = 11;
            btnMudarProduto.Text = "Mudar Produto";
            btnMudarProduto.UseVisualStyleBackColor = false;
            btnMudarProduto.Click += btnMudarProduto_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(255, 164, 86);
            btnVoltar.Font = new Font("Bebas Neue", 22.2F);
            btnVoltar.ForeColor = Color.Black;
            btnVoltar.Location = new Point(73, 258);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(265, 74);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // frmPopUpDetalhesProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 344);
            Controls.Add(btnMudarProduto);
            Controls.Add(btnVoltar);
            Controls.Add(lblEstoque);
            Controls.Add(lblEstoqueTitulo);
            Controls.Add(lblTamanho);
            Controls.Add(lblTamanhoTitulo);
            Controls.Add(lblCodigo);
            Controls.Add(lblContinuaNome);
            Controls.Add(lblNome);
            Controls.Add(lblNomeTitulo);
            Controls.Add(lblCodigoTitulo);
            Controls.Add(picImagem);
            Name = "frmPopUpDetalhesProduto";
            Text = "frmPopUpDetalhesProduto";
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImagem;
        private Label lblCodigoTitulo;
        private Label lblNomeTitulo;
        private Label lblNome;
        private Label lblContinuaNome;
        private Label lblCodigo;
        private Label lblTamanho;
        private Label lblTamanhoTitulo;
        private Label lblEstoque;
        private Label lblEstoqueTitulo;
        private Button btnMudarProduto;
        private Button btnVoltar;
    }
}
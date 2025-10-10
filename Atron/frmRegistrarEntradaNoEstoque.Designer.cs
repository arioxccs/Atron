namespace Atron
{
    partial class frmRegistrarEntradaNoEstoque
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
            txtObservacao = new TextBox();
            btnMais = new Button();
            txtMotivosParaDiferenca = new TextBox();
            lblMotivoParaDiferenca = new Label();
            lblImagem = new Label();
            btnImagem = new Button();
            pcbImagem = new PictureBox();
            txtFornecedor = new TextBox();
            lblFornecedor = new Label();
            lblMarca = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnRegistrarEntradaNoEstoque = new Button();
            cxtProdutosSolicitados = new ComboBox();
            txtAjusteDeQuantidade = new TextBox();
            txtMarca = new TextBox();
            lblAjusteQuant = new Label();
            lblObs = new Label();
            lblProdutosSolicitados = new Label();
            lblNumPedido = new Label();
            txtNomeProduto = new TextBox();
            lblRegistrarNovoPedido = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
            SuspendLayout();
            // 
            // txtObservacao
            // 
            txtObservacao.BackColor = Color.FromArgb(255, 180, 100);
            txtObservacao.ForeColor = Color.Black;
            txtObservacao.Location = new Point(128, 294);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(300, 66);
            txtObservacao.TabIndex = 145;
            // 
            // btnMais
            // 
            btnMais.BackColor = Color.FromArgb(255, 180, 100);
            btnMais.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMais.ImageAlign = ContentAlignment.MiddleLeft;
            btnMais.Location = new Point(658, 157);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(25, 23);
            btnMais.TabIndex = 144;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = false;
            // 
            // txtMotivosParaDiferenca
            // 
            txtMotivosParaDiferenca.BackColor = Color.FromArgb(255, 180, 100);
            txtMotivosParaDiferenca.ForeColor = Color.Gray;
            txtMotivosParaDiferenca.Location = new Point(481, 294);
            txtMotivosParaDiferenca.Multiline = true;
            txtMotivosParaDiferenca.Name = "txtMotivosParaDiferenca";
            txtMotivosParaDiferenca.Size = new Size(202, 66);
            txtMotivosParaDiferenca.TabIndex = 143;
            txtMotivosParaDiferenca.Text = "Produto danificado, pedido incompleto, erro no envio";
            // 
            // lblMotivoParaDiferenca
            // 
            lblMotivoParaDiferenca.AutoSize = true;
            lblMotivoParaDiferenca.Font = new Font("Microsoft Sans Serif", 9F);
            lblMotivoParaDiferenca.ForeColor = Color.FromArgb(42, 97, 141);
            lblMotivoParaDiferenca.Location = new Point(481, 277);
            lblMotivoParaDiferenca.Name = "lblMotivoParaDiferenca";
            lblMotivoParaDiferenca.Size = new Size(136, 15);
            lblMotivoParaDiferenca.TabIndex = 142;
            lblMotivoParaDiferenca.Text = "Motivos para Diferença:";
            // 
            // lblImagem
            // 
            lblImagem.AutoSize = true;
            lblImagem.Font = new Font("Microsoft Sans Serif", 9F);
            lblImagem.ForeColor = Color.FromArgb(42, 97, 141);
            lblImagem.Location = new Point(481, 140);
            lblImagem.Name = "lblImagem";
            lblImagem.Size = new Size(56, 15);
            lblImagem.TabIndex = 141;
            lblImagem.Text = "Imagem:";
            lblImagem.Click += lblImagem_Click;
            // 
            // btnImagem
            // 
            btnImagem.BackColor = Color.FromArgb(255, 180, 100);
            btnImagem.Location = new Point(481, 158);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(202, 23);
            btnImagem.TabIndex = 140;
            btnImagem.UseVisualStyleBackColor = false;
            // 
            // pcbImagem
            // 
            pcbImagem.BackColor = Color.White;
            pcbImagem.Location = new Point(491, 158);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(134, 23);
            pcbImagem.TabIndex = 139;
            pcbImagem.TabStop = false;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(255, 180, 100);
            txtFornecedor.ForeColor = Color.Black;
            txtFornecedor.Location = new Point(481, 202);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(202, 23);
            txtFornecedor.TabIndex = 138;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Microsoft Sans Serif", 9F);
            lblFornecedor.ForeColor = Color.FromArgb(42, 97, 141);
            lblFornecedor.Location = new Point(481, 185);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(73, 15);
            lblFornecedor.TabIndex = 137;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 9F);
            lblMarca.ForeColor = Color.FromArgb(42, 97, 141);
            lblMarca.Location = new Point(481, 234);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(45, 15);
            lblMarca.TabIndex = 136;
            lblMarca.Text = "Marca:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 71);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 134;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 180, 100);
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1229, 748);
            label3.Name = "label3";
            label3.Size = new Size(26, 28);
            label3.TabIndex = 133;
            label3.Text = ">";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 180, 100);
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1208, 748);
            label1.Name = "label1";
            label1.Size = new Size(26, 28);
            label1.TabIndex = 132;
            label1.Text = ">";
            label1.Click += label1_Click;
            // 
            // btnRegistrarEntradaNoEstoque
            // 
            btnRegistrarEntradaNoEstoque.BackColor = Color.FromArgb(255, 180, 100);
            btnRegistrarEntradaNoEstoque.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarEntradaNoEstoque.ForeColor = Color.White;
            btnRegistrarEntradaNoEstoque.Location = new Point(1014, 675);
            btnRegistrarEntradaNoEstoque.Name = "btnRegistrarEntradaNoEstoque";
            btnRegistrarEntradaNoEstoque.Size = new Size(246, 104);
            btnRegistrarEntradaNoEstoque.TabIndex = 131;
            btnRegistrarEntradaNoEstoque.Text = "Registrar Entrada No Estoque";
            btnRegistrarEntradaNoEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntradaNoEstoque.UseVisualStyleBackColor = false;
            btnRegistrarEntradaNoEstoque.Click += btnRegistrarEntradaNoEstoque_Click;
            // 
            // cxtProdutosSolicitados
            // 
            cxtProdutosSolicitados.BackColor = Color.FromArgb(255, 180, 100);
            cxtProdutosSolicitados.ForeColor = Color.Black;
            cxtProdutosSolicitados.FormattingEnabled = true;
            cxtProdutosSolicitados.Location = new Point(128, 202);
            cxtProdutosSolicitados.Name = "cxtProdutosSolicitados";
            cxtProdutosSolicitados.Size = new Size(300, 23);
            cxtProdutosSolicitados.TabIndex = 130;
            // 
            // txtAjusteDeQuantidade
            // 
            txtAjusteDeQuantidade.BackColor = Color.FromArgb(255, 180, 100);
            txtAjusteDeQuantidade.ForeColor = Color.Black;
            txtAjusteDeQuantidade.Location = new Point(128, 251);
            txtAjusteDeQuantidade.Name = "txtAjusteDeQuantidade";
            txtAjusteDeQuantidade.Size = new Size(300, 23);
            txtAjusteDeQuantidade.TabIndex = 129;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(255, 180, 100);
            txtMarca.ForeColor = Color.Black;
            txtMarca.Location = new Point(481, 251);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(202, 23);
            txtMarca.TabIndex = 128;
            // 
            // lblAjusteQuant
            // 
            lblAjusteQuant.AutoSize = true;
            lblAjusteQuant.Font = new Font("Microsoft Sans Serif", 9F);
            lblAjusteQuant.ForeColor = Color.FromArgb(42, 97, 141);
            lblAjusteQuant.Location = new Point(128, 234);
            lblAjusteQuant.Name = "lblAjusteQuant";
            lblAjusteQuant.Size = new Size(127, 15);
            lblAjusteQuant.TabIndex = 127;
            lblAjusteQuant.Text = "Ajuste de Quantidade:";
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Microsoft Sans Serif", 9F);
            lblObs.ForeColor = Color.FromArgb(42, 97, 141);
            lblObs.Location = new Point(128, 277);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(75, 15);
            lblObs.TabIndex = 126;
            lblObs.Text = "Observação:";
            // 
            // lblProdutosSolicitados
            // 
            lblProdutosSolicitados.AutoSize = true;
            lblProdutosSolicitados.Font = new Font("Microsoft Sans Serif", 9F);
            lblProdutosSolicitados.ForeColor = Color.FromArgb(42, 97, 141);
            lblProdutosSolicitados.Location = new Point(128, 185);
            lblProdutosSolicitados.Name = "lblProdutosSolicitados";
            lblProdutosSolicitados.Size = new Size(122, 15);
            lblProdutosSolicitados.TabIndex = 125;
            lblProdutosSolicitados.Text = "Produtos Solicitados:";
            // 
            // lblNumPedido
            // 
            lblNumPedido.AutoSize = true;
            lblNumPedido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumPedido.ForeColor = Color.FromArgb(42, 97, 141);
            lblNumPedido.Location = new Point(128, 140);
            lblNumPedido.Name = "lblNumPedido";
            lblNumPedido.Size = new Size(114, 15);
            lblNumPedido.TabIndex = 124;
            lblNumPedido.Text = "Número do Pedido:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = Color.FromArgb(255, 180, 100);
            txtNomeProduto.ForeColor = Color.Black;
            txtNomeProduto.Location = new Point(128, 159);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(300, 23);
            txtNomeProduto.TabIndex = 123;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // lblRegistrarNovoPedido
            // 
            lblRegistrarNovoPedido.AutoSize = true;
            lblRegistrarNovoPedido.Font = new Font("Bebas Neue", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarNovoPedido.ForeColor = Color.FromArgb(255, 122, 0);
            lblRegistrarNovoPedido.Location = new Point(251, 7);
            lblRegistrarNovoPedido.Name = "lblRegistrarNovoPedido";
            lblRegistrarNovoPedido.Size = new Size(844, 104);
            lblRegistrarNovoPedido.TabIndex = 122;
            lblRegistrarNovoPedido.Text = "REGISTRAR ENTRADA NO ESTOQUE";
            lblRegistrarNovoPedido.TextAlign = ContentAlignment.MiddleCenter;
            lblRegistrarNovoPedido.Click += lblRegistrarNovoPedido_Click;
            // 
            // frmRegistrarEntradaNoEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 791);
            Controls.Add(txtObservacao);
            Controls.Add(btnMais);
            Controls.Add(txtMotivosParaDiferenca);
            Controls.Add(lblMotivoParaDiferenca);
            Controls.Add(lblImagem);
            Controls.Add(btnImagem);
            Controls.Add(pcbImagem);
            Controls.Add(txtFornecedor);
            Controls.Add(lblFornecedor);
            Controls.Add(lblMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnRegistrarEntradaNoEstoque);
            Controls.Add(cxtProdutosSolicitados);
            Controls.Add(txtAjusteDeQuantidade);
            Controls.Add(txtMarca);
            Controls.Add(lblAjusteQuant);
            Controls.Add(lblObs);
            Controls.Add(lblProdutosSolicitados);
            Controls.Add(lblNumPedido);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblRegistrarNovoPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrarEntradaNoEstoque";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmRegistrarEntradaNoEstoque";
            Load += frmRegistrarEntradaNoEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObservacao;
        private Button btnMais;
        private TextBox txtMotivosParaDiferenca;
        private Label lblMotivoParaDiferenca;
        private Label lblImagem;
        private Button btnImagem;
        private PictureBox pcbImagem;
        private TextBox txtFornecedor;
        private Label lblFornecedor;
        private Label lblMarca;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnRegistrarEntradaNoEstoque;
        private ComboBox cxtProdutosSolicitados;
        private TextBox txtAjusteDeQuantidade;
        private TextBox txtMarca;
        private Label lblAjusteQuant;
        private Label lblObs;
        private Label lblProdutosSolicitados;
        private Label lblNumPedido;
        private TextBox txtNomeProduto;
        private Label lblRegistrarNovoPedido;
    }
}
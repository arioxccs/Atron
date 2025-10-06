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
            panel1 = new Panel();
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
            txtObservacao.Location = new Point(65, 336);
            txtObservacao.Margin = new Padding(3, 4, 3, 4);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(342, 87);
            txtObservacao.TabIndex = 145;
            // 
            // btnMais
            // 
            btnMais.BackColor = Color.FromArgb(255, 180, 100);
            btnMais.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMais.ImageAlign = ContentAlignment.MiddleLeft;
            btnMais.Location = new Point(671, 153);
            btnMais.Margin = new Padding(3, 4, 3, 4);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(29, 31);
            btnMais.TabIndex = 144;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = false;
            // 
            // txtMotivosParaDiferenca
            // 
            txtMotivosParaDiferenca.BackColor = Color.FromArgb(255, 180, 100);
            txtMotivosParaDiferenca.ForeColor = Color.Gray;
            txtMotivosParaDiferenca.Location = new Point(469, 336);
            txtMotivosParaDiferenca.Margin = new Padding(3, 4, 3, 4);
            txtMotivosParaDiferenca.Multiline = true;
            txtMotivosParaDiferenca.Name = "txtMotivosParaDiferenca";
            txtMotivosParaDiferenca.Size = new Size(230, 87);
            txtMotivosParaDiferenca.TabIndex = 143;
            txtMotivosParaDiferenca.Text = "Produto danificado, pedido incompleto, erro no envio";
            // 
            // lblMotivoParaDiferenca
            // 
            lblMotivoParaDiferenca.AutoSize = true;
            lblMotivoParaDiferenca.Font = new Font("Microsoft Sans Serif", 9F);
            lblMotivoParaDiferenca.ForeColor = Color.FromArgb(42, 97, 141);
            lblMotivoParaDiferenca.Location = new Point(469, 313);
            lblMotivoParaDiferenca.Name = "lblMotivoParaDiferenca";
            lblMotivoParaDiferenca.Size = new Size(165, 18);
            lblMotivoParaDiferenca.TabIndex = 142;
            lblMotivoParaDiferenca.Text = "Motivos para Diferença:";
            // 
            // lblImagem
            // 
            lblImagem.AutoSize = true;
            lblImagem.Font = new Font("Microsoft Sans Serif", 9F);
            lblImagem.ForeColor = Color.FromArgb(42, 97, 141);
            lblImagem.Location = new Point(469, 131);
            lblImagem.Name = "lblImagem";
            lblImagem.Size = new Size(65, 18);
            lblImagem.TabIndex = 141;
            lblImagem.Text = "Imagem:";
            // 
            // btnImagem
            // 
            btnImagem.BackColor = Color.FromArgb(255, 180, 100);
            btnImagem.Location = new Point(469, 155);
            btnImagem.Margin = new Padding(3, 4, 3, 4);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(231, 31);
            btnImagem.TabIndex = 140;
            btnImagem.UseVisualStyleBackColor = false;
            // 
            // pcbImagem
            // 
            pcbImagem.BackColor = Color.White;
            pcbImagem.Location = new Point(480, 155);
            pcbImagem.Margin = new Padding(3, 4, 3, 4);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(153, 31);
            pcbImagem.TabIndex = 139;
            pcbImagem.TabStop = false;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(255, 180, 100);
            txtFornecedor.ForeColor = Color.Black;
            txtFornecedor.Location = new Point(469, 213);
            txtFornecedor.Margin = new Padding(3, 4, 3, 4);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(230, 27);
            txtFornecedor.TabIndex = 138;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Microsoft Sans Serif", 9F);
            lblFornecedor.ForeColor = Color.FromArgb(42, 97, 141);
            lblFornecedor.Location = new Point(469, 191);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(89, 18);
            lblFornecedor.TabIndex = 137;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Microsoft Sans Serif", 9F);
            lblMarca.ForeColor = Color.FromArgb(42, 97, 141);
            lblMarca.Location = new Point(469, 256);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(54, 18);
            lblMarca.TabIndex = 136;
            lblMarca.Text = "Marca:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(437, 105);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 10);
            panel1.TabIndex = 135;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 95);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 134;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 180, 100);
            label3.ForeColor = Color.White;
            label3.Location = new Point(821, 525);
            label3.Name = "label3";
            label3.Size = new Size(19, 20);
            label3.TabIndex = 133;
            label3.Text = ">";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 180, 100);
            label1.ForeColor = Color.White;
            label1.Location = new Point(807, 525);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 132;
            label1.Text = ">";
            // 
            // btnRegistrarEntradaNoEstoque
            // 
            btnRegistrarEntradaNoEstoque.BackColor = Color.FromArgb(255, 180, 100);
            btnRegistrarEntradaNoEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarEntradaNoEstoque.ForeColor = Color.White;
            btnRegistrarEntradaNoEstoque.Location = new Point(711, 472);
            btnRegistrarEntradaNoEstoque.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarEntradaNoEstoque.Name = "btnRegistrarEntradaNoEstoque";
            btnRegistrarEntradaNoEstoque.Size = new Size(138, 84);
            btnRegistrarEntradaNoEstoque.TabIndex = 131;
            btnRegistrarEntradaNoEstoque.Text = "Registrar Entrada No Estoque";
            btnRegistrarEntradaNoEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntradaNoEstoque.UseVisualStyleBackColor = false;
            // 
            // cxtProdutosSolicitados
            // 
            cxtProdutosSolicitados.BackColor = Color.FromArgb(255, 180, 100);
            cxtProdutosSolicitados.ForeColor = Color.Black;
            cxtProdutosSolicitados.FormattingEnabled = true;
            cxtProdutosSolicitados.Location = new Point(65, 213);
            cxtProdutosSolicitados.Margin = new Padding(3, 4, 3, 4);
            cxtProdutosSolicitados.Name = "cxtProdutosSolicitados";
            cxtProdutosSolicitados.Size = new Size(342, 28);
            cxtProdutosSolicitados.TabIndex = 130;
            // 
            // txtAjusteDeQuantidade
            // 
            txtAjusteDeQuantidade.BackColor = Color.FromArgb(255, 180, 100);
            txtAjusteDeQuantidade.ForeColor = Color.Black;
            txtAjusteDeQuantidade.Location = new Point(65, 279);
            txtAjusteDeQuantidade.Margin = new Padding(3, 4, 3, 4);
            txtAjusteDeQuantidade.Name = "txtAjusteDeQuantidade";
            txtAjusteDeQuantidade.Size = new Size(342, 27);
            txtAjusteDeQuantidade.TabIndex = 129;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(255, 180, 100);
            txtMarca.ForeColor = Color.Black;
            txtMarca.Location = new Point(469, 279);
            txtMarca.Margin = new Padding(3, 4, 3, 4);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(230, 27);
            txtMarca.TabIndex = 128;
            // 
            // lblAjusteQuant
            // 
            lblAjusteQuant.AutoSize = true;
            lblAjusteQuant.Font = new Font("Microsoft Sans Serif", 9F);
            lblAjusteQuant.ForeColor = Color.FromArgb(42, 97, 141);
            lblAjusteQuant.Location = new Point(65, 256);
            lblAjusteQuant.Name = "lblAjusteQuant";
            lblAjusteQuant.Size = new Size(151, 18);
            lblAjusteQuant.TabIndex = 127;
            lblAjusteQuant.Text = "Ajuste de Quantidade:";
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Microsoft Sans Serif", 9F);
            lblObs.ForeColor = Color.FromArgb(42, 97, 141);
            lblObs.Location = new Point(65, 313);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(93, 18);
            lblObs.TabIndex = 126;
            lblObs.Text = "Observação:";
            // 
            // lblProdutosSolicitados
            // 
            lblProdutosSolicitados.AutoSize = true;
            lblProdutosSolicitados.Font = new Font("Microsoft Sans Serif", 9F);
            lblProdutosSolicitados.ForeColor = Color.FromArgb(42, 97, 141);
            lblProdutosSolicitados.Location = new Point(65, 191);
            lblProdutosSolicitados.Name = "lblProdutosSolicitados";
            lblProdutosSolicitados.Size = new Size(150, 18);
            lblProdutosSolicitados.TabIndex = 125;
            lblProdutosSolicitados.Text = "Produtos Solicitados:";
            // 
            // lblNumPedido
            // 
            lblNumPedido.AutoSize = true;
            lblNumPedido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumPedido.ForeColor = Color.FromArgb(42, 97, 141);
            lblNumPedido.Location = new Point(65, 131);
            lblNumPedido.Name = "lblNumPedido";
            lblNumPedido.Size = new Size(137, 18);
            lblNumPedido.TabIndex = 124;
            lblNumPedido.Text = "Número do Pedido:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = Color.FromArgb(255, 180, 100);
            txtNomeProduto.ForeColor = Color.Black;
            txtNomeProduto.Location = new Point(65, 155);
            txtNomeProduto.Margin = new Padding(3, 4, 3, 4);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(342, 27);
            txtNomeProduto.TabIndex = 123;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // lblRegistrarNovoPedido
            // 
            lblRegistrarNovoPedido.AutoSize = true;
            lblRegistrarNovoPedido.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarNovoPedido.ForeColor = Color.FromArgb(255, 122, 0);
            lblRegistrarNovoPedido.Location = new Point(378, 52);
            lblRegistrarNovoPedido.Name = "lblRegistrarNovoPedido";
            lblRegistrarNovoPedido.Size = new Size(628, 39);
            lblRegistrarNovoPedido.TabIndex = 122;
            lblRegistrarNovoPedido.Text = "REGISTRAR ENTRADA NO ESTOQUE";
            lblRegistrarNovoPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmRegistrarEntradaNoEstoque
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 1055);
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
            Controls.Add(panel1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRegistrarEntradaNoEstoque";
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
        private Panel panel1;
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
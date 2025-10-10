namespace Atron
{
    partial class frmRegistrarNovoProduto
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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnRegistraProduto = new Button();
            mktdata = new MaskedTextBox();
            txtQuantidadeMinima = new TextBox();
            txtMarca = new TextBox();
            txtCodProduto = new TextBox();
            lblCodProduto = new Label();
            lblQuantidadeMínima = new Label();
            lblDescricao = new Label();
            lblCategoria = new Label();
            lblData = new Label();
            lbNomedoProduto = new Label();
            txtNomeProduto = new TextBox();
            lblRegistrarNovoPedido = new Label();
            cxtCategoria = new ComboBox();
            lblMarca = new Label();
            lblFornecedor = new Label();
            txtFornecedor = new TextBox();
            txtDescricao = new TextBox();
            lblPrecoDaCompra = new Label();
            txtPrecoCompra = new TextBox();
            txtValorTotal = new TextBox();
            lblValorTotal = new Label();
            pcbImagem = new PictureBox();
            btnImagem = new Button();
            lblImagem = new Label();
            lblTamanho = new Label();
            txtTamanho = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbImagem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(179, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 2);
            panel1.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 68);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 180, 100);
            label3.ForeColor = Color.White;
            label3.Location = new Point(710, 390);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 68;
            label3.Text = ">";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 180, 100);
            label1.ForeColor = Color.White;
            label1.Location = new Point(721, 390);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 67;
            label1.Text = ">";
            // 
            // btnRegistraProduto
            // 
            btnRegistraProduto.BackColor = Color.FromArgb(255, 180, 100);
            btnRegistraProduto.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistraProduto.ForeColor = Color.White;
            btnRegistraProduto.Location = new Point(649, 373);
            btnRegistraProduto.Name = "btnRegistraProduto";
            btnRegistraProduto.Size = new Size(95, 47);
            btnRegistraProduto.TabIndex = 66;
            btnRegistraProduto.Text = "Registrar Produto";
            btnRegistraProduto.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistraProduto.UseVisualStyleBackColor = false;
            btnRegistraProduto.Click += btnRegistraProduto_Click;
            // 
            // mktdata
            // 
            mktdata.BackColor = Color.FromArgb(255, 180, 100);
            mktdata.ForeColor = Color.Black;
            mktdata.Location = new Point(248, 206);
            mktdata.Mask = "00/00/0000";
            mktdata.Name = "mktdata";
            mktdata.Size = new Size(140, 23);
            mktdata.TabIndex = 62;
            mktdata.ValidatingType = typeof(DateTime);
            mktdata.MaskInputRejected += mktdata_MaskInputRejected;
            // 
            // txtQuantidadeMinima
            // 
            txtQuantidadeMinima.BackColor = Color.FromArgb(255, 180, 100);
            txtQuantidadeMinima.ForeColor = Color.Black;
            txtQuantidadeMinima.Location = new Point(57, 157);
            txtQuantidadeMinima.Name = "txtQuantidadeMinima";
            txtQuantidadeMinima.Size = new Size(166, 23);
            txtQuantidadeMinima.TabIndex = 57;
            // 
            // txtMarca
            // 
            txtMarca.BackColor = Color.FromArgb(255, 180, 100);
            txtMarca.ForeColor = Color.Black;
            txtMarca.Location = new Point(248, 157);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(140, 23);
            txtMarca.TabIndex = 55;
            // 
            // txtCodProduto
            // 
            txtCodProduto.BackColor = Color.FromArgb(255, 180, 100);
            txtCodProduto.ForeColor = Color.Black;
            txtCodProduto.Location = new Point(420, 112);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(159, 23);
            txtCodProduto.TabIndex = 53;
            txtCodProduto.TextChanged += txtCodProduto_TextChanged;
            // 
            // lblCodProduto
            // 
            lblCodProduto.AutoSize = true;
            lblCodProduto.Font = new Font("Roboto", 9F);
            lblCodProduto.ForeColor = Color.FromArgb(42, 97, 141);
            lblCodProduto.Location = new Point(420, 95);
            lblCodProduto.Name = "lblCodProduto";
            lblCodProduto.Size = new Size(113, 14);
            lblCodProduto.TabIndex = 52;
            lblCodProduto.Text = "Código do Produto:";
            // 
            // lblQuantidadeMínima
            // 
            lblQuantidadeMínima.AutoSize = true;
            lblQuantidadeMínima.Font = new Font("Roboto", 9F);
            lblQuantidadeMínima.ForeColor = Color.FromArgb(42, 97, 141);
            lblQuantidadeMínima.Location = new Point(57, 140);
            lblQuantidadeMínima.Name = "lblQuantidadeMínima";
            lblQuantidadeMínima.Size = new Size(117, 14);
            lblQuantidadeMínima.TabIndex = 51;
            lblQuantidadeMínima.Text = "Quantidade Mínima:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Roboto", 9F);
            lblDescricao.ForeColor = Color.FromArgb(42, 97, 141);
            lblDescricao.Location = new Point(57, 232);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(63, 14);
            lblDescricao.TabIndex = 47;
            lblDescricao.Text = "Descrição:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Roboto", 9F);
            lblCategoria.ForeColor = Color.FromArgb(42, 97, 141);
            lblCategoria.Location = new Point(57, 189);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(63, 14);
            lblCategoria.TabIndex = 46;
            lblCategoria.Text = "Categoria:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Roboto", 9F);
            lblData.ForeColor = Color.FromArgb(42, 97, 141);
            lblData.Location = new Point(248, 189);
            lblData.Name = "lblData";
            lblData.Size = new Size(36, 14);
            lblData.TabIndex = 45;
            lblData.Text = "Data:";
            // 
            // lbNomedoProduto
            // 
            lbNomedoProduto.AutoSize = true;
            lbNomedoProduto.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNomedoProduto.ForeColor = Color.FromArgb(42, 97, 141);
            lbNomedoProduto.Location = new Point(57, 95);
            lbNomedoProduto.Name = "lbNomedoProduto";
            lbNomedoProduto.Size = new Size(107, 14);
            lbNomedoProduto.TabIndex = 44;
            lbNomedoProduto.Text = "Nome do Produto:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = Color.FromArgb(255, 180, 100);
            txtNomeProduto.ForeColor = Color.Black;
            txtNomeProduto.Location = new Point(57, 113);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(331, 23);
            txtNomeProduto.TabIndex = 43;
            // 
            // lblRegistrarNovoPedido
            // 
            lblRegistrarNovoPedido.AutoSize = true;
            lblRegistrarNovoPedido.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarNovoPedido.ForeColor = Color.FromArgb(255, 122, 0);
            lblRegistrarNovoPedido.Location = new Point(248, 30);
            lblRegistrarNovoPedido.Name = "lblRegistrarNovoPedido";
            lblRegistrarNovoPedido.Size = new Size(232, 35);
            lblRegistrarNovoPedido.TabIndex = 42;
            lblRegistrarNovoPedido.Text = "REGISTRAR NOVO PRODUTO";
            lblRegistrarNovoPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cxtCategoria
            // 
            cxtCategoria.BackColor = Color.FromArgb(255, 180, 100);
            cxtCategoria.ForeColor = Color.Black;
            cxtCategoria.FormattingEnabled = true;
            cxtCategoria.Location = new Point(57, 206);
            cxtCategoria.Name = "cxtCategoria";
            cxtCategoria.Size = new Size(166, 23);
            cxtCategoria.TabIndex = 63;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Roboto", 9F);
            lblMarca.ForeColor = Color.FromArgb(42, 97, 141);
            lblMarca.Location = new Point(248, 140);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(44, 14);
            lblMarca.TabIndex = 76;
            lblMarca.Text = "Marca:";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Roboto", 9F);
            lblFornecedor.ForeColor = Color.FromArgb(42, 97, 141);
            lblFornecedor.Location = new Point(420, 140);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(71, 14);
            lblFornecedor.TabIndex = 77;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(255, 180, 100);
            txtFornecedor.ForeColor = Color.Black;
            txtFornecedor.Location = new Point(420, 157);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(159, 23);
            txtFornecedor.TabIndex = 78;
            // 
            // txtDescricao
            // 
            txtDescricao.BackColor = Color.FromArgb(255, 180, 100);
            txtDescricao.ForeColor = Color.Black;
            txtDescricao.Location = new Point(57, 249);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(331, 23);
            txtDescricao.TabIndex = 79;
            // 
            // lblPrecoDaCompra
            // 
            lblPrecoDaCompra.AutoSize = true;
            lblPrecoDaCompra.Font = new Font("Roboto", 9F);
            lblPrecoDaCompra.ForeColor = Color.FromArgb(42, 97, 141);
            lblPrecoDaCompra.Location = new Point(57, 275);
            lblPrecoDaCompra.Name = "lblPrecoDaCompra";
            lblPrecoDaCompra.Size = new Size(105, 14);
            lblPrecoDaCompra.TabIndex = 80;
            lblPrecoDaCompra.Text = "Preço da Compra:";
            // 
            // txtPrecoCompra
            // 
            txtPrecoCompra.BackColor = Color.FromArgb(255, 180, 100);
            txtPrecoCompra.ForeColor = Color.Black;
            txtPrecoCompra.Location = new Point(57, 292);
            txtPrecoCompra.Name = "txtPrecoCompra";
            txtPrecoCompra.Size = new Size(166, 23);
            txtPrecoCompra.TabIndex = 81;
            // 
            // txtValorTotal
            // 
            txtValorTotal.BackColor = Color.FromArgb(255, 180, 100);
            txtValorTotal.ForeColor = Color.Black;
            txtValorTotal.Location = new Point(248, 292);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(140, 23);
            txtValorTotal.TabIndex = 83;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Roboto", 9F);
            lblValorTotal.ForeColor = Color.FromArgb(42, 97, 141);
            lblValorTotal.Location = new Point(248, 275);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(69, 14);
            lblValorTotal.TabIndex = 82;
            lblValorTotal.Text = "Valor Total:";
            // 
            // pcbImagem
            // 
            pcbImagem.BackColor = Color.White;
            pcbImagem.Location = new Point(432, 218);
            pcbImagem.Name = "pcbImagem";
            pcbImagem.Size = new Size(134, 41);
            pcbImagem.TabIndex = 84;
            pcbImagem.TabStop = false;
            // 
            // btnImagem
            // 
            btnImagem.BackColor = Color.FromArgb(255, 180, 100);
            btnImagem.Location = new Point(420, 206);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(159, 66);
            btnImagem.TabIndex = 85;
            btnImagem.UseVisualStyleBackColor = false;
            // 
            // lblImagem
            // 
            lblImagem.AutoSize = true;
            lblImagem.Font = new Font("Roboto", 9F);
            lblImagem.ForeColor = Color.FromArgb(42, 97, 141);
            lblImagem.Location = new Point(420, 189);
            lblImagem.Name = "lblImagem";
            lblImagem.Size = new Size(55, 14);
            lblImagem.TabIndex = 86;
            lblImagem.Text = "Imagem:";
            // 
            // lblTamanho
            // 
            lblTamanho.AutoSize = true;
            lblTamanho.Font = new Font("Roboto", 9F);
            lblTamanho.ForeColor = Color.FromArgb(42, 97, 141);
            lblTamanho.Location = new Point(420, 275);
            lblTamanho.Name = "lblTamanho";
            lblTamanho.Size = new Size(62, 14);
            lblTamanho.TabIndex = 87;
            lblTamanho.Text = "Tamanho:";
            lblTamanho.Click += label2_Click;
            // 
            // txtTamanho
            // 
            txtTamanho.BackColor = Color.FromArgb(255, 180, 100);
            txtTamanho.ForeColor = Color.Black;
            txtTamanho.Location = new Point(420, 292);
            txtTamanho.Name = "txtTamanho";
            txtTamanho.Size = new Size(159, 23);
            txtTamanho.TabIndex = 88;
            txtTamanho.TextChanged += textBox1_TextChanged;
            // 
            // frmRegistrarNovoProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTamanho);
            Controls.Add(lblTamanho);
            Controls.Add(lblImagem);
            Controls.Add(btnImagem);
            Controls.Add(pcbImagem);
            Controls.Add(txtValorTotal);
            Controls.Add(lblValorTotal);
            Controls.Add(txtPrecoCompra);
            Controls.Add(lblPrecoDaCompra);
            Controls.Add(txtDescricao);
            Controls.Add(txtFornecedor);
            Controls.Add(lblFornecedor);
            Controls.Add(lblMarca);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnRegistraProduto);
            Controls.Add(cxtCategoria);
            Controls.Add(mktdata);
            Controls.Add(txtQuantidadeMinima);
            Controls.Add(txtMarca);
            Controls.Add(txtCodProduto);
            Controls.Add(lblCodProduto);
            Controls.Add(lblQuantidadeMínima);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategoria);
            Controls.Add(lblData);
            Controls.Add(lbNomedoProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblRegistrarNovoPedido);
            Name = "frmRegistrarNovoProduto";
            WindowState = FormWindowState.Maximized;
            Load += frmRegistrarNovoProduto_Load;
            ((System.ComponentModel.ISupportInitialize)pcbImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnRegistraProduto;
        private MaskedTextBox mktdata;
        private TextBox txtQuantidadeMinima;
        private TextBox txtMarca;
        private TextBox txtCodProduto;
        private Label lblCodProduto;
        private Label lblQuantidadeMínima;
        private Label lblDescricao;
        private Label lblCategoria;
        private Label lblData;
        private Label lbNomedoProduto;
        private TextBox txtNomeProduto;
        private Label lblRegistrarNovoPedido;
        private ComboBox cxtCategoria;
        private Label lblMarca;
        private Label lblFornecedor;
        private TextBox txtFornecedor;
        private TextBox txtDescricao;
        private Label lblPrecoDaCompra;
        private TextBox txtPrecoCompra;
        private TextBox txtValorTotal;
        private Label lblValorTotal;
        private PictureBox pcbImagem;
        private Button btnImagem;
        private Label lblImagem;
        private Label lblTamanho;
        private TextBox txtTamanho;
    }
}
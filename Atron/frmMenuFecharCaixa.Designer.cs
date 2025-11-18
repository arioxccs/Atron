namespace Atron
{
    partial class frmMenuFecharCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuFecharCaixa));
            lblTitulo = new Label();
            pctAbrirCaixa = new PictureBox();
            gpbValorVendas = new GroupBox();
            lblValor = new Label();
            btnRegistrarVenda = new Button();
            btnCadastrarCliente = new Button();
            btnBuscaEstoque = new Button();
            lblTituloHistorico = new Label();
            lblCodigo5 = new Label();
            lblNomeCliente5 = new Label();
            lblNomeProduto5 = new Label();
            lblValorProduto5 = new Label();
            lblHorario5 = new Label();
            lblCodigo4 = new Label();
            lblNomeCliente4 = new Label();
            lblNomeProduto4 = new Label();
            lblValorProduto4 = new Label();
            lblHorario4 = new Label();
            lblCodigo3 = new Label();
            lblNomeCliente3 = new Label();
            lblNomeProduto3 = new Label();
            lblValorProduto3 = new Label();
            lblHorario3 = new Label();
            lblCodigo2 = new Label();
            lblNomeCliente2 = new Label();
            lblNomeProduto2 = new Label();
            lblValorProduto2 = new Label();
            lblHorario2 = new Label();
            lblCodigo1 = new Label();
            lblNomeCliente1 = new Label();
            lblNomeProduto1 = new Label();
            lblValorProduto1 = new Label();
            lblHorario1 = new Label();
            lblNomeCliente = new Label();
            lblProduto = new Label();
            lblValorProduto = new Label();
            lblHorario = new Label();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pctAbrirCaixa).BeginInit();
            gpbValorVendas.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 90F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.ForeColor = Color.FromArgb(34, 95, 226);
            lblTitulo.Location = new Point(-1, -47);
            lblTitulo.MinimumSize = new Size(1312, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1312, 102);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "VENDAS";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pctAbrirCaixa
            // 
            pctAbrirCaixa.Image = (Image)resources.GetObject("pctAbrirCaixa.Image");
            pctAbrirCaixa.Location = new Point(-1, 78);
            pctAbrirCaixa.Name = "pctAbrirCaixa";
            pctAbrirCaixa.Size = new Size(706, 122);
            pctAbrirCaixa.SizeMode = PictureBoxSizeMode.Zoom;
            pctAbrirCaixa.TabIndex = 3;
            pctAbrirCaixa.TabStop = false;
            pctAbrirCaixa.Click += pctAbrirCaixa_Click;
            // 
            // gpbValorVendas
            // 
            gpbValorVendas.BackColor = Color.FromArgb(34, 95, 226);
            gpbValorVendas.Controls.Add(lblValor);
            gpbValorVendas.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            gpbValorVendas.ForeColor = Color.White;
            gpbValorVendas.Location = new Point(727, 78);
            gpbValorVendas.Name = "gpbValorVendas";
            gpbValorVendas.Size = new Size(427, 122);
            gpbValorVendas.TabIndex = 4;
            gpbValorVendas.TabStop = false;
            gpbValorVendas.Text = "Valor de Vendas";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            lblValor.Location = new Point(178, 51);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(235, 46);
            lblValor.TabIndex = 0;
            lblValor.Text = "R$1.250,00";
            // 
            // btnRegistrarVenda
            // 
            btnRegistrarVenda.BackColor = Color.FromArgb(34, 95, 226);
            btnRegistrarVenda.Font = new Font("Microsoft Sans Serif", 20F);
            btnRegistrarVenda.ForeColor = Color.White;
            btnRegistrarVenda.Image = (Image)resources.GetObject("btnRegistrarVenda.Image");
            btnRegistrarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarVenda.Location = new Point(39, 241);
            btnRegistrarVenda.Name = "btnRegistrarVenda";
            btnRegistrarVenda.Size = new Size(378, 100);
            btnRegistrarVenda.TabIndex = 5;
            btnRegistrarVenda.Text = "REGISTRAR VENDA";
            btnRegistrarVenda.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarVenda.UseVisualStyleBackColor = false;
            btnRegistrarVenda.Click += btnRegistrarVenda_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.BackColor = Color.FromArgb(34, 95, 226);
            btnCadastrarCliente.Font = new Font("Microsoft Sans Serif", 18F);
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Image = (Image)resources.GetObject("btnCadastrarCliente.Image");
            btnCadastrarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarCliente.Location = new Point(458, 242);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(378, 100);
            btnCadastrarCliente.TabIndex = 7;
            btnCadastrarCliente.Text = "CADASTRAR CLIENTE";
            btnCadastrarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnBuscaEstoque
            // 
            btnBuscaEstoque.BackColor = Color.FromArgb(34, 95, 226);
            btnBuscaEstoque.Font = new Font("Microsoft Sans Serif", 18F);
            btnBuscaEstoque.ForeColor = Color.White;
            btnBuscaEstoque.Image = (Image)resources.GetObject("btnBuscaEstoque.Image");
            btnBuscaEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscaEstoque.Location = new Point(867, 242);
            btnBuscaEstoque.Name = "btnBuscaEstoque";
            btnBuscaEstoque.Size = new Size(378, 100);
            btnBuscaEstoque.TabIndex = 8;
            btnBuscaEstoque.Text = "BUSCA NO ESTOQUE";
            btnBuscaEstoque.TextAlign = ContentAlignment.MiddleRight;
            btnBuscaEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscaEstoque.UseVisualStyleBackColor = false;
            btnBuscaEstoque.Click += btnBuscaEstoque_Click;
            // 
            // lblTituloHistorico
            // 
            lblTituloHistorico.AutoSize = true;
            lblTituloHistorico.Font = new Font("Microsoft Sans Serif", 50F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTituloHistorico.ForeColor = Color.FromArgb(34, 95, 226);
            lblTituloHistorico.Location = new Point(39, 424);
            lblTituloHistorico.Name = "lblTituloHistorico";
            lblTituloHistorico.Size = new Size(602, 58);
            lblTituloHistorico.TabIndex = 16;
            lblTituloHistorico.Text = "HISTÓRICO DE VENDAS";
            lblTituloHistorico.Click += lblTituloHistorico_Click;
            // 
            // lblCodigo5
            // 
            lblCodigo5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo5.AutoSize = true;
            lblCodigo5.BackColor = Color.Transparent;
            lblCodigo5.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo5.Location = new Point(122, 819);
            lblCodigo5.MinimumSize = new Size(100, 40);
            lblCodigo5.Name = "lblCodigo5";
            lblCodigo5.Size = new Size(100, 40);
            lblCodigo5.TabIndex = 74;
            lblCodigo5.Text = "XXXX";
            lblCodigo5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente5
            // 
            lblNomeCliente5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente5.AutoSize = true;
            lblNomeCliente5.BackColor = Color.Transparent;
            lblNomeCliente5.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente5.Location = new Point(332, 819);
            lblNomeCliente5.MinimumSize = new Size(100, 40);
            lblNomeCliente5.Name = "lblNomeCliente5";
            lblNomeCliente5.Size = new Size(149, 40);
            lblNomeCliente5.TabIndex = 75;
            lblNomeCliente5.Text = "XXXXXXXX";
            lblNomeCliente5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto5
            // 
            lblNomeProduto5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto5.AutoSize = true;
            lblNomeProduto5.BackColor = Color.Transparent;
            lblNomeProduto5.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto5.Location = new Point(542, 819);
            lblNomeProduto5.MinimumSize = new Size(100, 40);
            lblNomeProduto5.Name = "lblNomeProduto5";
            lblNomeProduto5.Size = new Size(149, 40);
            lblNomeProduto5.TabIndex = 76;
            lblNomeProduto5.Text = "XXXXXXXX";
            lblNomeProduto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto5
            // 
            lblValorProduto5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto5.AutoSize = true;
            lblValorProduto5.BackColor = Color.Transparent;
            lblValorProduto5.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto5.Location = new Point(752, 819);
            lblValorProduto5.MinimumSize = new Size(100, 40);
            lblValorProduto5.Name = "lblValorProduto5";
            lblValorProduto5.Size = new Size(149, 40);
            lblValorProduto5.TabIndex = 77;
            lblValorProduto5.Text = "XXXXXXXX";
            lblValorProduto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario5
            // 
            lblHorario5.AutoSize = true;
            lblHorario5.BackColor = Color.Transparent;
            lblHorario5.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario5.Location = new Point(962, 819);
            lblHorario5.MinimumSize = new Size(200, 55);
            lblHorario5.Name = "lblHorario5";
            lblHorario5.Size = new Size(200, 55);
            lblHorario5.TabIndex = 78;
            lblHorario5.Text = "XX:XX";
            lblHorario5.TextAlign = ContentAlignment.MiddleCenter;
            lblHorario5.Click += lblHorario5_Click;
            // 
            // lblCodigo4
            // 
            lblCodigo4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo4.AutoSize = true;
            lblCodigo4.BackColor = Color.Transparent;
            lblCodigo4.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo4.Location = new Point(124, 764);
            lblCodigo4.MinimumSize = new Size(100, 40);
            lblCodigo4.Name = "lblCodigo4";
            lblCodigo4.Size = new Size(100, 40);
            lblCodigo4.TabIndex = 69;
            lblCodigo4.Text = "XXXX";
            lblCodigo4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente4
            // 
            lblNomeCliente4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente4.AutoSize = true;
            lblNomeCliente4.BackColor = Color.Transparent;
            lblNomeCliente4.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente4.Location = new Point(334, 764);
            lblNomeCliente4.MinimumSize = new Size(100, 40);
            lblNomeCliente4.Name = "lblNomeCliente4";
            lblNomeCliente4.Size = new Size(149, 40);
            lblNomeCliente4.TabIndex = 70;
            lblNomeCliente4.Text = "XXXXXXXX";
            lblNomeCliente4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto4
            // 
            lblNomeProduto4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto4.AutoSize = true;
            lblNomeProduto4.BackColor = Color.Transparent;
            lblNomeProduto4.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto4.Location = new Point(544, 764);
            lblNomeProduto4.MinimumSize = new Size(100, 40);
            lblNomeProduto4.Name = "lblNomeProduto4";
            lblNomeProduto4.Size = new Size(149, 40);
            lblNomeProduto4.TabIndex = 71;
            lblNomeProduto4.Text = "XXXXXXXX";
            lblNomeProduto4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto4
            // 
            lblValorProduto4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto4.AutoSize = true;
            lblValorProduto4.BackColor = Color.Transparent;
            lblValorProduto4.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto4.Location = new Point(754, 764);
            lblValorProduto4.MinimumSize = new Size(100, 40);
            lblValorProduto4.Name = "lblValorProduto4";
            lblValorProduto4.Size = new Size(149, 40);
            lblValorProduto4.TabIndex = 72;
            lblValorProduto4.Text = "XXXXXXXX";
            lblValorProduto4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario4
            // 
            lblHorario4.AutoSize = true;
            lblHorario4.BackColor = Color.Transparent;
            lblHorario4.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario4.Location = new Point(964, 764);
            lblHorario4.MinimumSize = new Size(200, 55);
            lblHorario4.Name = "lblHorario4";
            lblHorario4.Size = new Size(200, 55);
            lblHorario4.TabIndex = 73;
            lblHorario4.Text = "XX:XX";
            lblHorario4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo3
            // 
            lblCodigo3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo3.AutoSize = true;
            lblCodigo3.BackColor = Color.Transparent;
            lblCodigo3.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo3.Location = new Point(124, 703);
            lblCodigo3.MinimumSize = new Size(100, 40);
            lblCodigo3.Name = "lblCodigo3";
            lblCodigo3.Size = new Size(100, 40);
            lblCodigo3.TabIndex = 64;
            lblCodigo3.Text = "XXXX";
            lblCodigo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente3
            // 
            lblNomeCliente3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente3.AutoSize = true;
            lblNomeCliente3.BackColor = Color.Transparent;
            lblNomeCliente3.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente3.Location = new Point(334, 703);
            lblNomeCliente3.MinimumSize = new Size(100, 40);
            lblNomeCliente3.Name = "lblNomeCliente3";
            lblNomeCliente3.Size = new Size(149, 40);
            lblNomeCliente3.TabIndex = 65;
            lblNomeCliente3.Text = "XXXXXXXX";
            lblNomeCliente3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto3
            // 
            lblNomeProduto3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto3.AutoSize = true;
            lblNomeProduto3.BackColor = Color.Transparent;
            lblNomeProduto3.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto3.Location = new Point(544, 703);
            lblNomeProduto3.MinimumSize = new Size(100, 40);
            lblNomeProduto3.Name = "lblNomeProduto3";
            lblNomeProduto3.Size = new Size(149, 40);
            lblNomeProduto3.TabIndex = 66;
            lblNomeProduto3.Text = "XXXXXXXX";
            lblNomeProduto3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto3
            // 
            lblValorProduto3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto3.AutoSize = true;
            lblValorProduto3.BackColor = Color.Transparent;
            lblValorProduto3.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto3.Location = new Point(754, 703);
            lblValorProduto3.MinimumSize = new Size(100, 40);
            lblValorProduto3.Name = "lblValorProduto3";
            lblValorProduto3.Size = new Size(149, 40);
            lblValorProduto3.TabIndex = 67;
            lblValorProduto3.Text = "XXXXXXXX";
            lblValorProduto3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario3
            // 
            lblHorario3.AutoSize = true;
            lblHorario3.BackColor = Color.Transparent;
            lblHorario3.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario3.Location = new Point(964, 703);
            lblHorario3.MinimumSize = new Size(200, 55);
            lblHorario3.Name = "lblHorario3";
            lblHorario3.Size = new Size(200, 55);
            lblHorario3.TabIndex = 68;
            lblHorario3.Text = "XX:XX";
            lblHorario3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo2
            // 
            lblCodigo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo2.AutoSize = true;
            lblCodigo2.BackColor = Color.Transparent;
            lblCodigo2.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo2.Location = new Point(124, 641);
            lblCodigo2.MinimumSize = new Size(100, 40);
            lblCodigo2.Name = "lblCodigo2";
            lblCodigo2.Size = new Size(100, 40);
            lblCodigo2.TabIndex = 59;
            lblCodigo2.Text = "1032";
            lblCodigo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente2
            // 
            lblNomeCliente2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente2.AutoSize = true;
            lblNomeCliente2.BackColor = Color.Transparent;
            lblNomeCliente2.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente2.Location = new Point(334, 641);
            lblNomeCliente2.MinimumSize = new Size(100, 40);
            lblNomeCliente2.Name = "lblNomeCliente2";
            lblNomeCliente2.Size = new Size(113, 40);
            lblNomeCliente2.TabIndex = 60;
            lblNomeCliente2.Text = "Pessoa 2";
            lblNomeCliente2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto2
            // 
            lblNomeProduto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto2.AutoSize = true;
            lblNomeProduto2.BackColor = Color.Transparent;
            lblNomeProduto2.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto2.Location = new Point(544, 641);
            lblNomeProduto2.MinimumSize = new Size(100, 40);
            lblNomeProduto2.Name = "lblNomeProduto2";
            lblNomeProduto2.Size = new Size(119, 40);
            lblNomeProduto2.TabIndex = 61;
            lblNomeProduto2.Text = "Produto A";
            lblNomeProduto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto2
            // 
            lblValorProduto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto2.AutoSize = true;
            lblValorProduto2.BackColor = Color.Transparent;
            lblValorProduto2.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto2.Location = new Point(754, 641);
            lblValorProduto2.MinimumSize = new Size(100, 40);
            lblValorProduto2.Name = "lblValorProduto2";
            lblValorProduto2.Size = new Size(101, 40);
            lblValorProduto2.TabIndex = 62;
            lblValorProduto2.Text = "R$14,99";
            lblValorProduto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario2
            // 
            lblHorario2.AutoSize = true;
            lblHorario2.BackColor = Color.Transparent;
            lblHorario2.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario2.Location = new Point(964, 641);
            lblHorario2.MinimumSize = new Size(200, 55);
            lblHorario2.Name = "lblHorario2";
            lblHorario2.Size = new Size(200, 55);
            lblHorario2.TabIndex = 63;
            lblHorario2.Text = "13:12";
            lblHorario2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo1
            // 
            lblCodigo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo1.AutoSize = true;
            lblCodigo1.BackColor = Color.Transparent;
            lblCodigo1.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo1.Location = new Point(124, 580);
            lblCodigo1.MinimumSize = new Size(100, 40);
            lblCodigo1.Name = "lblCodigo1";
            lblCodigo1.Size = new Size(100, 40);
            lblCodigo1.TabIndex = 54;
            lblCodigo1.Text = "1001";
            lblCodigo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente1
            // 
            lblNomeCliente1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente1.AutoSize = true;
            lblNomeCliente1.BackColor = Color.Transparent;
            lblNomeCliente1.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente1.Location = new Point(334, 580);
            lblNomeCliente1.MinimumSize = new Size(100, 40);
            lblNomeCliente1.Name = "lblNomeCliente1";
            lblNomeCliente1.Size = new Size(113, 40);
            lblNomeCliente1.TabIndex = 55;
            lblNomeCliente1.Text = "Pessoa 1";
            lblNomeCliente1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto1
            // 
            lblNomeProduto1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto1.AutoSize = true;
            lblNomeProduto1.BackColor = Color.Transparent;
            lblNomeProduto1.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto1.Location = new Point(544, 580);
            lblNomeProduto1.MinimumSize = new Size(100, 40);
            lblNomeProduto1.Name = "lblNomeProduto1";
            lblNomeProduto1.Size = new Size(119, 40);
            lblNomeProduto1.TabIndex = 56;
            lblNomeProduto1.Text = "Produto A";
            lblNomeProduto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto1
            // 
            lblValorProduto1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto1.AutoSize = true;
            lblValorProduto1.BackColor = Color.Transparent;
            lblValorProduto1.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto1.Location = new Point(754, 580);
            lblValorProduto1.MinimumSize = new Size(100, 40);
            lblValorProduto1.Name = "lblValorProduto1";
            lblValorProduto1.Size = new Size(101, 40);
            lblValorProduto1.TabIndex = 57;
            lblValorProduto1.Text = "R$14,99";
            lblValorProduto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario1
            // 
            lblHorario1.AutoSize = true;
            lblHorario1.BackColor = Color.Transparent;
            lblHorario1.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario1.Location = new Point(964, 580);
            lblHorario1.MinimumSize = new Size(200, 55);
            lblHorario1.Name = "lblHorario1";
            lblHorario1.Size = new Size(200, 55);
            lblHorario1.TabIndex = 58;
            lblHorario1.Text = "13:30";
            lblHorario1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.BackColor = Color.Transparent;
            lblNomeCliente.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblNomeCliente.Location = new Point(334, 518);
            lblNomeCliente.MinimumSize = new Size(100, 40);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(116, 40);
            lblNomeCliente.TabIndex = 50;
            lblNomeCliente.Text = "Nome Cliente";
            lblNomeCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduto
            // 
            lblProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblProduto.Location = new Point(544, 518);
            lblProduto.MinimumSize = new Size(100, 40);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(100, 40);
            lblProduto.TabIndex = 51;
            lblProduto.Text = "Produto";
            lblProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto
            // 
            lblValorProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto.AutoSize = true;
            lblValorProduto.BackColor = Color.Transparent;
            lblValorProduto.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblValorProduto.Location = new Point(754, 518);
            lblValorProduto.MinimumSize = new Size(100, 40);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(100, 40);
            lblValorProduto.TabIndex = 52;
            lblValorProduto.Text = "Valor";
            lblValorProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblHorario.Location = new Point(964, 518);
            lblHorario.MinimumSize = new Size(200, 60);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(200, 60);
            lblHorario.TabIndex = 53;
            lblHorario.Text = "Horário";
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblCodigo.Location = new Point(124, 518);
            lblCodigo.MinimumSize = new Size(100, 40);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 40);
            lblCodigo.TabIndex = 49;
            lblCodigo.Text = "Código";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMenuFecharCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1500);
            AutoSize = true;
            ClientSize = new Size(1297, 491);
            Controls.Add(lblCodigo5);
            Controls.Add(lblNomeCliente5);
            Controls.Add(lblNomeProduto5);
            Controls.Add(lblValorProduto5);
            Controls.Add(lblHorario5);
            Controls.Add(lblCodigo4);
            Controls.Add(lblNomeCliente4);
            Controls.Add(lblNomeProduto4);
            Controls.Add(lblValorProduto4);
            Controls.Add(lblHorario4);
            Controls.Add(lblCodigo3);
            Controls.Add(lblNomeCliente3);
            Controls.Add(lblNomeProduto3);
            Controls.Add(lblValorProduto3);
            Controls.Add(lblHorario3);
            Controls.Add(lblCodigo2);
            Controls.Add(lblNomeCliente2);
            Controls.Add(lblNomeProduto2);
            Controls.Add(lblValorProduto2);
            Controls.Add(lblHorario2);
            Controls.Add(lblCodigo1);
            Controls.Add(lblNomeCliente1);
            Controls.Add(lblNomeProduto1);
            Controls.Add(lblValorProduto1);
            Controls.Add(lblHorario1);
            Controls.Add(lblNomeCliente);
            Controls.Add(lblProduto);
            Controls.Add(lblValorProduto);
            Controls.Add(lblHorario);
            Controls.Add(lblCodigo);
            Controls.Add(lblTituloHistorico);
            Controls.Add(btnBuscaEstoque);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(btnRegistrarVenda);
            Controls.Add(gpbValorVendas);
            Controls.Add(pctAbrirCaixa);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMenuFecharCaixa";
            Text = "frmMenuFecharCaixa";
            ((System.ComponentModel.ISupportInitialize)pctAbrirCaixa).EndInit();
            gpbValorVendas.ResumeLayout(false);
            gpbValorVendas.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pctAbrirCaixa;
        private GroupBox gpbValorVendas;
        private Label lblValor;
        private Button btnRegistrarVenda;
        private Button btnCadastrarCliente;
        private Button btnBuscaEstoque;
        private Label lblTituloHistorico;
        private Label lblCodigo5;
        private Label lblNomeCliente5;
        private Label lblNomeProduto5;
        private Label lblValorProduto5;
        private Label lblHorario5;
        private Label lblCodigo4;
        private Label lblNomeCliente4;
        private Label lblNomeProduto4;
        private Label lblValorProduto4;
        private Label lblHorario4;
        private Label lblCodigo3;
        private Label lblNomeCliente3;
        private Label lblNomeProduto3;
        private Label lblValorProduto3;
        private Label lblHorario3;
        private Label lblCodigo2;
        private Label lblNomeCliente2;
        private Label lblNomeProduto2;
        private Label lblValorProduto2;
        private Label lblHorario2;
        private Label lblCodigo1;
        private Label lblNomeCliente1;
        private Label lblNomeProduto1;
        private Label lblValorProduto1;
        private Label lblHorario1;
        private Label lblNomeCliente;
        private Label lblProduto;
        private Label lblValorProduto;
        private Label lblHorario;
        private Label lblCodigo;
    }
}
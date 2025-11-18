namespace Atron
{
    partial class frmMenuAbrirCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAbrirCaixa));
            lblTitulo = new Label();
            pctAbrirCaixa = new PictureBox();
            gpbValorVendas = new GroupBox();
            lblValor = new Label();
            txtBusca = new TextBox();
            button2 = new Button();
            button3 = new Button();
            btnBuscaEstoque = new Button();
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
            lblTituloHistorico = new Label();
            ((System.ComponentModel.ISupportInitialize)pctAbrirCaixa).BeginInit();
            gpbValorVendas.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("ST-Komsomol", 90F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.ForeColor = Color.FromArgb(34, 95, 226);
            lblTitulo.Location = new Point(-1, -47);
            lblTitulo.MinimumSize = new Size(1312, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1312, 145);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "VENDAS";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pctAbrirCaixa
            // 
            pctAbrirCaixa.Image = (Image)resources.GetObject("pctAbrirCaixa.Image");
            pctAbrirCaixa.Location = new Point(-1, 104);
            pctAbrirCaixa.Name = "pctAbrirCaixa";
            pctAbrirCaixa.Size = new Size(706, 122);
            pctAbrirCaixa.SizeMode = PictureBoxSizeMode.Zoom;
            pctAbrirCaixa.TabIndex = 2;
            pctAbrirCaixa.TabStop = false;
            pctAbrirCaixa.Click += pctAbrirCaixa_Click;
            // 
            // gpbValorVendas
            // 
            gpbValorVendas.BackColor = Color.FromArgb(34, 95, 226);
            gpbValorVendas.Controls.Add(lblValor);
            gpbValorVendas.Font = new Font("Lato", 18F, FontStyle.Bold);
            gpbValorVendas.ForeColor = Color.White;
            gpbValorVendas.Location = new Point(727, 104);
            gpbValorVendas.Name = "gpbValorVendas";
            gpbValorVendas.Size = new Size(427, 122);
            gpbValorVendas.TabIndex = 3;
            gpbValorVendas.TabStop = false;
            gpbValorVendas.Text = "Valor de Vendas";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Lato", 30F, FontStyle.Bold);
            lblValor.Location = new Point(178, 50);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(233, 48);
            lblValor.TabIndex = 0;
            lblValor.Text = "R$1.250,00";
            // 
            // txtBusca
            // 
            txtBusca.ForeColor = SystemColors.WindowText;
            txtBusca.Location = new Point(87, 948);
            txtBusca.MaximumSize = new Size(4, 100);
            txtBusca.Multiline = true;
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(4, 43);
            txtBusca.TabIndex = 16;
            txtBusca.Text = "\r\n";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 95, 226);
            button2.Font = new Font("Bebas Neue", 18F);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(451, 242);
            button2.Name = "button2";
            button2.Size = new Size(396, 100);
            button2.TabIndex = 20;
            button2.Text = "CADASTRAR CLIENTE";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 95, 226);
            button3.Font = new Font("Bebas Neue", 20F);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(39, 241);
            button3.Name = "button3";
            button3.Size = new Size(396, 100);
            button3.TabIndex = 19;
            button3.Text = "REGISTRAR VENDA";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnBuscaEstoque
            // 
            btnBuscaEstoque.BackColor = Color.FromArgb(34, 95, 226);
            btnBuscaEstoque.Font = new Font("Bebas Neue", 18F);
            btnBuscaEstoque.ForeColor = Color.White;
            btnBuscaEstoque.Image = (Image)resources.GetObject("btnBuscaEstoque.Image");
            btnBuscaEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscaEstoque.Location = new Point(862, 241);
            btnBuscaEstoque.Name = "btnBuscaEstoque";
            btnBuscaEstoque.Size = new Size(396, 100);
            btnBuscaEstoque.TabIndex = 21;
            btnBuscaEstoque.Text = "BUSCA NO ESTOQUE";
            btnBuscaEstoque.TextAlign = ContentAlignment.MiddleRight;
            btnBuscaEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscaEstoque.UseVisualStyleBackColor = false;
            // 
            // lblCodigo5
            // 
            lblCodigo5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo5.AutoSize = true;
            lblCodigo5.BackColor = Color.Transparent;
            lblCodigo5.Font = new Font("Lato", 18F);
            lblCodigo5.Location = new Point(109, 833);
            lblCodigo5.MinimumSize = new Size(100, 40);
            lblCodigo5.Name = "lblCodigo5";
            lblCodigo5.Size = new Size(100, 40);
            lblCodigo5.TabIndex = 105;
            lblCodigo5.Text = "XXXX";
            lblCodigo5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente5
            // 
            lblNomeCliente5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente5.AutoSize = true;
            lblNomeCliente5.BackColor = Color.Transparent;
            lblNomeCliente5.Font = new Font("Lato", 18F);
            lblNomeCliente5.Location = new Point(319, 833);
            lblNomeCliente5.MinimumSize = new Size(100, 40);
            lblNomeCliente5.Name = "lblNomeCliente5";
            lblNomeCliente5.Size = new Size(133, 40);
            lblNomeCliente5.TabIndex = 106;
            lblNomeCliente5.Text = "XXXXXXXX";
            lblNomeCliente5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto5
            // 
            lblNomeProduto5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto5.AutoSize = true;
            lblNomeProduto5.BackColor = Color.Transparent;
            lblNomeProduto5.Font = new Font("Lato", 18F);
            lblNomeProduto5.Location = new Point(529, 833);
            lblNomeProduto5.MinimumSize = new Size(100, 40);
            lblNomeProduto5.Name = "lblNomeProduto5";
            lblNomeProduto5.Size = new Size(133, 40);
            lblNomeProduto5.TabIndex = 107;
            lblNomeProduto5.Text = "XXXXXXXX";
            lblNomeProduto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto5
            // 
            lblValorProduto5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto5.AutoSize = true;
            lblValorProduto5.BackColor = Color.Transparent;
            lblValorProduto5.Font = new Font("Lato", 18F);
            lblValorProduto5.Location = new Point(739, 833);
            lblValorProduto5.MinimumSize = new Size(100, 40);
            lblValorProduto5.Name = "lblValorProduto5";
            lblValorProduto5.Size = new Size(133, 40);
            lblValorProduto5.TabIndex = 108;
            lblValorProduto5.Text = "XXXXXXXX";
            lblValorProduto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario5
            // 
            lblHorario5.AutoSize = true;
            lblHorario5.BackColor = Color.Transparent;
            lblHorario5.Font = new Font("Lato", 18F);
            lblHorario5.Location = new Point(949, 833);
            lblHorario5.MinimumSize = new Size(200, 55);
            lblHorario5.Name = "lblHorario5";
            lblHorario5.Size = new Size(200, 55);
            lblHorario5.TabIndex = 109;
            lblHorario5.Text = "XX:XX";
            lblHorario5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo4
            // 
            lblCodigo4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo4.AutoSize = true;
            lblCodigo4.BackColor = Color.Transparent;
            lblCodigo4.Font = new Font("Lato", 18F);
            lblCodigo4.Location = new Point(109, 772);
            lblCodigo4.MinimumSize = new Size(100, 40);
            lblCodigo4.Name = "lblCodigo4";
            lblCodigo4.Size = new Size(100, 40);
            lblCodigo4.TabIndex = 100;
            lblCodigo4.Text = "XXXX";
            lblCodigo4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente4
            // 
            lblNomeCliente4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente4.AutoSize = true;
            lblNomeCliente4.BackColor = Color.Transparent;
            lblNomeCliente4.Font = new Font("Lato", 18F);
            lblNomeCliente4.Location = new Point(319, 772);
            lblNomeCliente4.MinimumSize = new Size(100, 40);
            lblNomeCliente4.Name = "lblNomeCliente4";
            lblNomeCliente4.Size = new Size(133, 40);
            lblNomeCliente4.TabIndex = 101;
            lblNomeCliente4.Text = "XXXXXXXX";
            lblNomeCliente4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto4
            // 
            lblNomeProduto4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto4.AutoSize = true;
            lblNomeProduto4.BackColor = Color.Transparent;
            lblNomeProduto4.Font = new Font("Lato", 18F);
            lblNomeProduto4.Location = new Point(529, 772);
            lblNomeProduto4.MinimumSize = new Size(100, 40);
            lblNomeProduto4.Name = "lblNomeProduto4";
            lblNomeProduto4.Size = new Size(133, 40);
            lblNomeProduto4.TabIndex = 102;
            lblNomeProduto4.Text = "XXXXXXXX";
            lblNomeProduto4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto4
            // 
            lblValorProduto4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto4.AutoSize = true;
            lblValorProduto4.BackColor = Color.Transparent;
            lblValorProduto4.Font = new Font("Lato", 18F);
            lblValorProduto4.Location = new Point(739, 772);
            lblValorProduto4.MinimumSize = new Size(100, 40);
            lblValorProduto4.Name = "lblValorProduto4";
            lblValorProduto4.Size = new Size(133, 40);
            lblValorProduto4.TabIndex = 103;
            lblValorProduto4.Text = "XXXXXXXX";
            lblValorProduto4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario4
            // 
            lblHorario4.AutoSize = true;
            lblHorario4.BackColor = Color.Transparent;
            lblHorario4.Font = new Font("Lato", 18F);
            lblHorario4.Location = new Point(949, 772);
            lblHorario4.MinimumSize = new Size(200, 55);
            lblHorario4.Name = "lblHorario4";
            lblHorario4.Size = new Size(200, 55);
            lblHorario4.TabIndex = 104;
            lblHorario4.Text = "XX:XX";
            lblHorario4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo3
            // 
            lblCodigo3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo3.AutoSize = true;
            lblCodigo3.BackColor = Color.Transparent;
            lblCodigo3.Font = new Font("Lato", 18F);
            lblCodigo3.Location = new Point(109, 710);
            lblCodigo3.MinimumSize = new Size(100, 40);
            lblCodigo3.Name = "lblCodigo3";
            lblCodigo3.Size = new Size(100, 40);
            lblCodigo3.TabIndex = 95;
            lblCodigo3.Text = "XXXX";
            lblCodigo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente3
            // 
            lblNomeCliente3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente3.AutoSize = true;
            lblNomeCliente3.BackColor = Color.Transparent;
            lblNomeCliente3.Font = new Font("Lato", 18F);
            lblNomeCliente3.Location = new Point(319, 710);
            lblNomeCliente3.MinimumSize = new Size(100, 40);
            lblNomeCliente3.Name = "lblNomeCliente3";
            lblNomeCliente3.Size = new Size(133, 40);
            lblNomeCliente3.TabIndex = 96;
            lblNomeCliente3.Text = "XXXXXXXX";
            lblNomeCliente3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto3
            // 
            lblNomeProduto3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto3.AutoSize = true;
            lblNomeProduto3.BackColor = Color.Transparent;
            lblNomeProduto3.Font = new Font("Lato", 18F);
            lblNomeProduto3.Location = new Point(529, 710);
            lblNomeProduto3.MinimumSize = new Size(100, 40);
            lblNomeProduto3.Name = "lblNomeProduto3";
            lblNomeProduto3.Size = new Size(133, 40);
            lblNomeProduto3.TabIndex = 97;
            lblNomeProduto3.Text = "XXXXXXXX";
            lblNomeProduto3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto3
            // 
            lblValorProduto3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto3.AutoSize = true;
            lblValorProduto3.BackColor = Color.Transparent;
            lblValorProduto3.Font = new Font("Lato", 18F);
            lblValorProduto3.Location = new Point(739, 710);
            lblValorProduto3.MinimumSize = new Size(100, 40);
            lblValorProduto3.Name = "lblValorProduto3";
            lblValorProduto3.Size = new Size(133, 40);
            lblValorProduto3.TabIndex = 98;
            lblValorProduto3.Text = "XXXXXXXX";
            lblValorProduto3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario3
            // 
            lblHorario3.AutoSize = true;
            lblHorario3.BackColor = Color.Transparent;
            lblHorario3.Font = new Font("Lato", 18F);
            lblHorario3.Location = new Point(949, 710);
            lblHorario3.MinimumSize = new Size(200, 55);
            lblHorario3.Name = "lblHorario3";
            lblHorario3.Size = new Size(200, 55);
            lblHorario3.TabIndex = 99;
            lblHorario3.Text = "XX:XX";
            lblHorario3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo2
            // 
            lblCodigo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo2.AutoSize = true;
            lblCodigo2.BackColor = Color.Transparent;
            lblCodigo2.Font = new Font("Lato", 18F);
            lblCodigo2.Location = new Point(109, 649);
            lblCodigo2.MinimumSize = new Size(100, 40);
            lblCodigo2.Name = "lblCodigo2";
            lblCodigo2.Size = new Size(100, 40);
            lblCodigo2.TabIndex = 90;
            lblCodigo2.Text = "1032";
            lblCodigo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente2
            // 
            lblNomeCliente2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente2.AutoSize = true;
            lblNomeCliente2.BackColor = Color.Transparent;
            lblNomeCliente2.Font = new Font("Lato", 18F);
            lblNomeCliente2.Location = new Point(319, 649);
            lblNomeCliente2.MinimumSize = new Size(100, 40);
            lblNomeCliente2.Name = "lblNomeCliente2";
            lblNomeCliente2.Size = new Size(105, 40);
            lblNomeCliente2.TabIndex = 91;
            lblNomeCliente2.Text = "Pessoa 2";
            lblNomeCliente2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto2
            // 
            lblNomeProduto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto2.AutoSize = true;
            lblNomeProduto2.BackColor = Color.Transparent;
            lblNomeProduto2.Font = new Font("Lato", 18F);
            lblNomeProduto2.Location = new Point(529, 649);
            lblNomeProduto2.MinimumSize = new Size(100, 40);
            lblNomeProduto2.Name = "lblNomeProduto2";
            lblNomeProduto2.Size = new Size(120, 40);
            lblNomeProduto2.TabIndex = 92;
            lblNomeProduto2.Text = "Produto A";
            lblNomeProduto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto2
            // 
            lblValorProduto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto2.AutoSize = true;
            lblValorProduto2.BackColor = Color.Transparent;
            lblValorProduto2.Font = new Font("Lato", 18F);
            lblValorProduto2.Location = new Point(739, 649);
            lblValorProduto2.MinimumSize = new Size(100, 40);
            lblValorProduto2.Name = "lblValorProduto2";
            lblValorProduto2.Size = new Size(103, 40);
            lblValorProduto2.TabIndex = 93;
            lblValorProduto2.Text = "R$14,99";
            lblValorProduto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario2
            // 
            lblHorario2.AutoSize = true;
            lblHorario2.BackColor = Color.Transparent;
            lblHorario2.Font = new Font("Lato", 18F);
            lblHorario2.Location = new Point(949, 649);
            lblHorario2.MinimumSize = new Size(200, 55);
            lblHorario2.Name = "lblHorario2";
            lblHorario2.Size = new Size(200, 55);
            lblHorario2.TabIndex = 94;
            lblHorario2.Text = "13:12";
            lblHorario2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo1
            // 
            lblCodigo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo1.AutoSize = true;
            lblCodigo1.BackColor = Color.Transparent;
            lblCodigo1.Font = new Font("Lato", 18F);
            lblCodigo1.Location = new Point(109, 587);
            lblCodigo1.MinimumSize = new Size(100, 40);
            lblCodigo1.Name = "lblCodigo1";
            lblCodigo1.Size = new Size(100, 40);
            lblCodigo1.TabIndex = 85;
            lblCodigo1.Text = "1001";
            lblCodigo1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente1
            // 
            lblNomeCliente1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente1.AutoSize = true;
            lblNomeCliente1.BackColor = Color.Transparent;
            lblNomeCliente1.Font = new Font("Lato", 18F);
            lblNomeCliente1.Location = new Point(319, 587);
            lblNomeCliente1.MinimumSize = new Size(100, 40);
            lblNomeCliente1.Name = "lblNomeCliente1";
            lblNomeCliente1.Size = new Size(105, 40);
            lblNomeCliente1.TabIndex = 86;
            lblNomeCliente1.Text = "Pessoa 1";
            lblNomeCliente1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto1
            // 
            lblNomeProduto1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto1.AutoSize = true;
            lblNomeProduto1.BackColor = Color.Transparent;
            lblNomeProduto1.Font = new Font("Lato", 18F);
            lblNomeProduto1.Location = new Point(529, 587);
            lblNomeProduto1.MinimumSize = new Size(100, 40);
            lblNomeProduto1.Name = "lblNomeProduto1";
            lblNomeProduto1.Size = new Size(120, 40);
            lblNomeProduto1.TabIndex = 87;
            lblNomeProduto1.Text = "Produto A";
            lblNomeProduto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto1
            // 
            lblValorProduto1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto1.AutoSize = true;
            lblValorProduto1.BackColor = Color.Transparent;
            lblValorProduto1.Font = new Font("Lato", 18F);
            lblValorProduto1.Location = new Point(739, 587);
            lblValorProduto1.MinimumSize = new Size(100, 40);
            lblValorProduto1.Name = "lblValorProduto1";
            lblValorProduto1.Size = new Size(103, 40);
            lblValorProduto1.TabIndex = 88;
            lblValorProduto1.Text = "R$14,99";
            lblValorProduto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario1
            // 
            lblHorario1.AutoSize = true;
            lblHorario1.BackColor = Color.Transparent;
            lblHorario1.Font = new Font("Lato", 18F);
            lblHorario1.Location = new Point(949, 587);
            lblHorario1.MinimumSize = new Size(200, 55);
            lblHorario1.Name = "lblHorario1";
            lblHorario1.Size = new Size(200, 55);
            lblHorario1.TabIndex = 89;
            lblHorario1.Text = "13:30";
            lblHorario1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.BackColor = Color.Transparent;
            lblNomeCliente.Font = new Font("Lato", 11.9999981F, FontStyle.Bold);
            lblNomeCliente.Location = new Point(319, 526);
            lblNomeCliente.MinimumSize = new Size(100, 40);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(116, 40);
            lblNomeCliente.TabIndex = 81;
            lblNomeCliente.Text = "Nome Cliente";
            lblNomeCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduto
            // 
            lblProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Lato", 11.9999981F, FontStyle.Bold);
            lblProduto.Location = new Point(529, 526);
            lblProduto.MinimumSize = new Size(100, 40);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(100, 40);
            lblProduto.TabIndex = 82;
            lblProduto.Text = "Produto";
            lblProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto
            // 
            lblValorProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto.AutoSize = true;
            lblValorProduto.BackColor = Color.Transparent;
            lblValorProduto.Font = new Font("Lato", 11.9999981F, FontStyle.Bold);
            lblValorProduto.Location = new Point(739, 526);
            lblValorProduto.MinimumSize = new Size(100, 40);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(100, 40);
            lblValorProduto.TabIndex = 83;
            lblValorProduto.Text = "Valor";
            lblValorProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.Font = new Font("Lato", 11.9999981F, FontStyle.Bold);
            lblHorario.Location = new Point(949, 526);
            lblHorario.MinimumSize = new Size(200, 60);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(200, 60);
            lblHorario.TabIndex = 84;
            lblHorario.Text = "Horário";
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Lato", 11.9999981F, FontStyle.Bold);
            lblCodigo.Location = new Point(109, 525);
            lblCodigo.MinimumSize = new Size(100, 40);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 40);
            lblCodigo.TabIndex = 80;
            lblCodigo.Text = "Código";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloHistorico
            // 
            lblTituloHistorico.Font = new Font("ST-Komsomol", 50F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTituloHistorico.ForeColor = Color.FromArgb(34, 95, 226);
            lblTituloHistorico.Location = new Point(39, 392);
            lblTituloHistorico.Name = "lblTituloHistorico";
            lblTituloHistorico.Size = new Size(473, 81);
            lblTituloHistorico.TabIndex = 79;
            lblTituloHistorico.Text = "HISTÓRICO DE VENDAS";
            // 
            // frmMenuAbrirCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1500);
            BackColor = Color.White;
            ClientSize = new Size(1296, 788);
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
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(txtBusca);
            Controls.Add(gpbValorVendas);
            Controls.Add(pctAbrirCaixa);
            Controls.Add(lblTitulo);
            Name = "frmMenuAbrirCaixa";
            Text = "frmMenuAbrirCaixa";
            Load += frmMenuAbrirCaixa_Load;
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
        private TextBox txtBusca;
        private Button button2;
        private Button button3;
        private Button btnBuscaEstoque;
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
        private Label lblTituloHistorico;
    }
}
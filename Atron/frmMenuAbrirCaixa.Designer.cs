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
            btnBuscaEstoque = new Button();
            btnCadastrarCliente = new Button();
            btnRegistrarVenda = new Button();
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
            lblTitulo.Font = new Font("Microsoft Sans Serif", 90F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.ForeColor = Color.FromArgb(34, 95, 226);
            lblTitulo.Location = new Point(-1, -63);
            lblTitulo.MinimumSize = new Size(1499, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1499, 102);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "VENDAS";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pctAbrirCaixa
            // 
            pctAbrirCaixa.Image = (Image)resources.GetObject("pctAbrirCaixa.Image");
            pctAbrirCaixa.Location = new Point(-1, 104);
            pctAbrirCaixa.Margin = new Padding(3, 4, 3, 4);
            pctAbrirCaixa.Name = "pctAbrirCaixa";
            pctAbrirCaixa.Size = new Size(807, 163);
            pctAbrirCaixa.SizeMode = PictureBoxSizeMode.Zoom;
            pctAbrirCaixa.TabIndex = 2;
            pctAbrirCaixa.TabStop = false;
            pctAbrirCaixa.Click += pctAbrirCaixa_Click;
            // 
            // gpbValorVendas
            // 
            gpbValorVendas.BackColor = Color.FromArgb(34, 95, 226);
            gpbValorVendas.Controls.Add(lblValor);
            gpbValorVendas.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            gpbValorVendas.ForeColor = Color.White;
            gpbValorVendas.Location = new Point(831, 104);
            gpbValorVendas.Margin = new Padding(3, 4, 3, 4);
            gpbValorVendas.Name = "gpbValorVendas";
            gpbValorVendas.Padding = new Padding(3, 4, 3, 4);
            gpbValorVendas.Size = new Size(488, 163);
            gpbValorVendas.TabIndex = 3;
            gpbValorVendas.TabStop = false;
            gpbValorVendas.Text = "Valor de Vendas";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold);
            lblValor.Location = new Point(203, 67);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(295, 58);
            lblValor.TabIndex = 0;
            lblValor.Text = "R$1.250,00";
            // 
            // btnBuscaEstoque
            // 
            btnBuscaEstoque.BackColor = Color.FromArgb(34, 95, 226);
            btnBuscaEstoque.Font = new Font("Microsoft Sans Serif", 18F);
            btnBuscaEstoque.ForeColor = Color.White;
            btnBuscaEstoque.Image = (Image)resources.GetObject("btnBuscaEstoque.Image");
            btnBuscaEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscaEstoque.Location = new Point(940, 340);
            btnBuscaEstoque.Margin = new Padding(3, 4, 3, 4);
            btnBuscaEstoque.Name = "btnBuscaEstoque";
            btnBuscaEstoque.Size = new Size(432, 133);
            btnBuscaEstoque.TabIndex = 21;
            btnBuscaEstoque.Text = "BUSCA NO ESTOQUE";
            btnBuscaEstoque.TextAlign = ContentAlignment.MiddleRight;
            btnBuscaEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBuscaEstoque.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.BackColor = Color.FromArgb(34, 95, 226);
            btnCadastrarCliente.Font = new Font("Microsoft Sans Serif", 18F);
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Image = (Image)resources.GetObject("btnCadastrarCliente.Image");
            btnCadastrarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btnCadastrarCliente.Location = new Point(489, 339);
            btnCadastrarCliente.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(432, 133);
            btnCadastrarCliente.TabIndex = 20;
            btnCadastrarCliente.Text = "CADASTRAR CLIENTE";
            btnCadastrarCliente.TextAlign = ContentAlignment.MiddleRight;
            btnCadastrarCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrarCliente.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarVenda
            // 
            btnRegistrarVenda.BackColor = Color.FromArgb(34, 95, 226);
            btnRegistrarVenda.Font = new Font("Microsoft Sans Serif", 20F);
            btnRegistrarVenda.ForeColor = Color.White;
            btnRegistrarVenda.Image = (Image)resources.GetObject("btnRegistrarVenda.Image");
            btnRegistrarVenda.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarVenda.Location = new Point(34, 339);
            btnRegistrarVenda.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarVenda.Name = "btnRegistrarVenda";
            btnRegistrarVenda.Size = new Size(432, 133);
            btnRegistrarVenda.TabIndex = 19;
            btnRegistrarVenda.Text = "REGISTRAR VENDA";
            btnRegistrarVenda.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarVenda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegistrarVenda.UseVisualStyleBackColor = false;
            // 
            // lblCodigo5
            // 
            lblCodigo5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo5.AutoSize = true;
            lblCodigo5.BackColor = Color.Transparent;
            lblCodigo5.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo5.Location = new Point(139, 1119);
            lblCodigo5.MinimumSize = new Size(114, 53);
            lblCodigo5.Name = "lblCodigo5";
            lblCodigo5.Size = new Size(114, 53);
            lblCodigo5.TabIndex = 104;
            lblCodigo5.Text = "XXXX";
            lblCodigo5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente5
            // 
            lblNomeCliente5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente5.AutoSize = true;
            lblNomeCliente5.BackColor = Color.Transparent;
            lblNomeCliente5.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente5.Location = new Point(379, 1119);
            lblNomeCliente5.MinimumSize = new Size(114, 53);
            lblNomeCliente5.Name = "lblNomeCliente5";
            lblNomeCliente5.Size = new Size(183, 53);
            lblNomeCliente5.TabIndex = 105;
            lblNomeCliente5.Text = "XXXXXXXX";
            lblNomeCliente5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto5
            // 
            lblNomeProduto5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto5.AutoSize = true;
            lblNomeProduto5.BackColor = Color.Transparent;
            lblNomeProduto5.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto5.Location = new Point(619, 1119);
            lblNomeProduto5.MinimumSize = new Size(114, 53);
            lblNomeProduto5.Name = "lblNomeProduto5";
            lblNomeProduto5.Size = new Size(183, 53);
            lblNomeProduto5.TabIndex = 106;
            lblNomeProduto5.Text = "XXXXXXXX";
            lblNomeProduto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto5
            // 
            lblValorProduto5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto5.AutoSize = true;
            lblValorProduto5.BackColor = Color.Transparent;
            lblValorProduto5.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto5.Location = new Point(859, 1119);
            lblValorProduto5.MinimumSize = new Size(114, 53);
            lblValorProduto5.Name = "lblValorProduto5";
            lblValorProduto5.Size = new Size(183, 53);
            lblValorProduto5.TabIndex = 107;
            lblValorProduto5.Text = "XXXXXXXX";
            lblValorProduto5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario5
            // 
            lblHorario5.AutoSize = true;
            lblHorario5.BackColor = Color.Transparent;
            lblHorario5.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario5.Location = new Point(1099, 1119);
            lblHorario5.MinimumSize = new Size(229, 73);
            lblHorario5.Name = "lblHorario5";
            lblHorario5.Size = new Size(229, 73);
            lblHorario5.TabIndex = 108;
            lblHorario5.Text = "XX:XX";
            lblHorario5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo4
            // 
            lblCodigo4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo4.AutoSize = true;
            lblCodigo4.BackColor = Color.Transparent;
            lblCodigo4.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo4.Location = new Point(141, 1046);
            lblCodigo4.MinimumSize = new Size(114, 53);
            lblCodigo4.Name = "lblCodigo4";
            lblCodigo4.Size = new Size(114, 53);
            lblCodigo4.TabIndex = 99;
            lblCodigo4.Text = "XXXX";
            lblCodigo4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente4
            // 
            lblNomeCliente4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente4.AutoSize = true;
            lblNomeCliente4.BackColor = Color.Transparent;
            lblNomeCliente4.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente4.Location = new Point(381, 1046);
            lblNomeCliente4.MinimumSize = new Size(114, 53);
            lblNomeCliente4.Name = "lblNomeCliente4";
            lblNomeCliente4.Size = new Size(183, 53);
            lblNomeCliente4.TabIndex = 100;
            lblNomeCliente4.Text = "XXXXXXXX";
            lblNomeCliente4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto4
            // 
            lblNomeProduto4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto4.AutoSize = true;
            lblNomeProduto4.BackColor = Color.Transparent;
            lblNomeProduto4.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto4.Location = new Point(621, 1046);
            lblNomeProduto4.MinimumSize = new Size(114, 53);
            lblNomeProduto4.Name = "lblNomeProduto4";
            lblNomeProduto4.Size = new Size(183, 53);
            lblNomeProduto4.TabIndex = 101;
            lblNomeProduto4.Text = "XXXXXXXX";
            lblNomeProduto4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto4
            // 
            lblValorProduto4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto4.AutoSize = true;
            lblValorProduto4.BackColor = Color.Transparent;
            lblValorProduto4.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto4.Location = new Point(861, 1046);
            lblValorProduto4.MinimumSize = new Size(114, 53);
            lblValorProduto4.Name = "lblValorProduto4";
            lblValorProduto4.Size = new Size(183, 53);
            lblValorProduto4.TabIndex = 102;
            lblValorProduto4.Text = "XXXXXXXX";
            lblValorProduto4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario4
            // 
            lblHorario4.AutoSize = true;
            lblHorario4.BackColor = Color.Transparent;
            lblHorario4.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario4.Location = new Point(1101, 1046);
            lblHorario4.MinimumSize = new Size(229, 73);
            lblHorario4.Name = "lblHorario4";
            lblHorario4.Size = new Size(229, 73);
            lblHorario4.TabIndex = 103;
            lblHorario4.Text = "XX:XX";
            lblHorario4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo3
            // 
            lblCodigo3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo3.AutoSize = true;
            lblCodigo3.BackColor = Color.Transparent;
            lblCodigo3.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo3.Location = new Point(141, 964);
            lblCodigo3.MinimumSize = new Size(114, 53);
            lblCodigo3.Name = "lblCodigo3";
            lblCodigo3.Size = new Size(114, 53);
            lblCodigo3.TabIndex = 94;
            lblCodigo3.Text = "XXXX";
            lblCodigo3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente3
            // 
            lblNomeCliente3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente3.AutoSize = true;
            lblNomeCliente3.BackColor = Color.Transparent;
            lblNomeCliente3.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente3.Location = new Point(381, 964);
            lblNomeCliente3.MinimumSize = new Size(114, 53);
            lblNomeCliente3.Name = "lblNomeCliente3";
            lblNomeCliente3.Size = new Size(183, 53);
            lblNomeCliente3.TabIndex = 95;
            lblNomeCliente3.Text = "XXXXXXXX";
            lblNomeCliente3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto3
            // 
            lblNomeProduto3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto3.AutoSize = true;
            lblNomeProduto3.BackColor = Color.Transparent;
            lblNomeProduto3.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto3.Location = new Point(621, 964);
            lblNomeProduto3.MinimumSize = new Size(114, 53);
            lblNomeProduto3.Name = "lblNomeProduto3";
            lblNomeProduto3.Size = new Size(183, 53);
            lblNomeProduto3.TabIndex = 96;
            lblNomeProduto3.Text = "XXXXXXXX";
            lblNomeProduto3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto3
            // 
            lblValorProduto3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto3.AutoSize = true;
            lblValorProduto3.BackColor = Color.Transparent;
            lblValorProduto3.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto3.Location = new Point(861, 964);
            lblValorProduto3.MinimumSize = new Size(114, 53);
            lblValorProduto3.Name = "lblValorProduto3";
            lblValorProduto3.Size = new Size(183, 53);
            lblValorProduto3.TabIndex = 97;
            lblValorProduto3.Text = "XXXXXXXX";
            lblValorProduto3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario3
            // 
            lblHorario3.AutoSize = true;
            lblHorario3.BackColor = Color.Transparent;
            lblHorario3.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario3.Location = new Point(1101, 964);
            lblHorario3.MinimumSize = new Size(229, 73);
            lblHorario3.Name = "lblHorario3";
            lblHorario3.Size = new Size(229, 73);
            lblHorario3.TabIndex = 98;
            lblHorario3.Text = "XX:XX";
            lblHorario3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo2
            // 
            lblCodigo2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo2.AutoSize = true;
            lblCodigo2.BackColor = Color.Transparent;
            lblCodigo2.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo2.Location = new Point(141, 882);
            lblCodigo2.MinimumSize = new Size(114, 53);
            lblCodigo2.Name = "lblCodigo2";
            lblCodigo2.Size = new Size(114, 53);
            lblCodigo2.TabIndex = 89;
            lblCodigo2.Text = "XXXX";
            lblCodigo2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente2
            // 
            lblNomeCliente2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente2.AutoSize = true;
            lblNomeCliente2.BackColor = Color.Transparent;
            lblNomeCliente2.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente2.Location = new Point(381, 882);
            lblNomeCliente2.MinimumSize = new Size(114, 53);
            lblNomeCliente2.Name = "lblNomeCliente2";
            lblNomeCliente2.Size = new Size(183, 53);
            lblNomeCliente2.TabIndex = 90;
            lblNomeCliente2.Text = "XXXXXXXX";
            lblNomeCliente2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto2
            // 
            lblNomeProduto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto2.AutoSize = true;
            lblNomeProduto2.BackColor = Color.Transparent;
            lblNomeProduto2.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto2.Location = new Point(621, 882);
            lblNomeProduto2.MinimumSize = new Size(114, 53);
            lblNomeProduto2.Name = "lblNomeProduto2";
            lblNomeProduto2.Size = new Size(183, 53);
            lblNomeProduto2.TabIndex = 91;
            lblNomeProduto2.Text = "XXXXXXXX";
            lblNomeProduto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto2
            // 
            lblValorProduto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto2.AutoSize = true;
            lblValorProduto2.BackColor = Color.Transparent;
            lblValorProduto2.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto2.Location = new Point(861, 882);
            lblValorProduto2.MinimumSize = new Size(114, 53);
            lblValorProduto2.Name = "lblValorProduto2";
            lblValorProduto2.Size = new Size(183, 53);
            lblValorProduto2.TabIndex = 92;
            lblValorProduto2.Text = "XXXXXXXX";
            lblValorProduto2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario2
            // 
            lblHorario2.AutoSize = true;
            lblHorario2.BackColor = Color.Transparent;
            lblHorario2.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario2.Location = new Point(1101, 882);
            lblHorario2.MinimumSize = new Size(229, 73);
            lblHorario2.Name = "lblHorario2";
            lblHorario2.Size = new Size(229, 73);
            lblHorario2.TabIndex = 93;
            lblHorario2.Text = "XX:XX";
            lblHorario2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo1
            // 
            lblCodigo1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo1.AutoSize = true;
            lblCodigo1.BackColor = Color.Transparent;
            lblCodigo1.Font = new Font("Microsoft Sans Serif", 18F);
            lblCodigo1.Location = new Point(141, 800);
            lblCodigo1.MinimumSize = new Size(114, 53);
            lblCodigo1.Name = "lblCodigo1";
            lblCodigo1.Size = new Size(114, 53);
            lblCodigo1.TabIndex = 84;
            lblCodigo1.Text = "XXXX";
            lblCodigo1.TextAlign = ContentAlignment.MiddleCenter;
            lblCodigo1.Click += lblCodigo1_Click;
            // 
            // lblNomeCliente1
            // 
            lblNomeCliente1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente1.AutoSize = true;
            lblNomeCliente1.BackColor = Color.Transparent;
            lblNomeCliente1.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeCliente1.Location = new Point(381, 800);
            lblNomeCliente1.MinimumSize = new Size(114, 53);
            lblNomeCliente1.Name = "lblNomeCliente1";
            lblNomeCliente1.Size = new Size(183, 53);
            lblNomeCliente1.TabIndex = 85;
            lblNomeCliente1.Text = "XXXXXXXX";
            lblNomeCliente1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeProduto1
            // 
            lblNomeProduto1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeProduto1.AutoSize = true;
            lblNomeProduto1.BackColor = Color.Transparent;
            lblNomeProduto1.Font = new Font("Microsoft Sans Serif", 18F);
            lblNomeProduto1.Location = new Point(621, 800);
            lblNomeProduto1.MinimumSize = new Size(114, 53);
            lblNomeProduto1.Name = "lblNomeProduto1";
            lblNomeProduto1.Size = new Size(183, 53);
            lblNomeProduto1.TabIndex = 86;
            lblNomeProduto1.Text = "XXXXXXXX";
            lblNomeProduto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto1
            // 
            lblValorProduto1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto1.AutoSize = true;
            lblValorProduto1.BackColor = Color.Transparent;
            lblValorProduto1.Font = new Font("Microsoft Sans Serif", 18F);
            lblValorProduto1.Location = new Point(861, 800);
            lblValorProduto1.MinimumSize = new Size(114, 53);
            lblValorProduto1.Name = "lblValorProduto1";
            lblValorProduto1.Size = new Size(183, 53);
            lblValorProduto1.TabIndex = 87;
            lblValorProduto1.Text = "XXXXXXXX";
            lblValorProduto1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario1
            // 
            lblHorario1.AutoSize = true;
            lblHorario1.BackColor = Color.Transparent;
            lblHorario1.Font = new Font("Microsoft Sans Serif", 18F);
            lblHorario1.Location = new Point(1101, 800);
            lblHorario1.MinimumSize = new Size(229, 73);
            lblHorario1.Name = "lblHorario1";
            lblHorario1.Size = new Size(229, 73);
            lblHorario1.TabIndex = 88;
            lblHorario1.Text = "XX:XX";
            lblHorario1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.BackColor = Color.Transparent;
            lblNomeCliente.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblNomeCliente.Location = new Point(381, 718);
            lblNomeCliente.MinimumSize = new Size(114, 53);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(142, 53);
            lblNomeCliente.TabIndex = 80;
            lblNomeCliente.Text = "Nome Cliente";
            lblNomeCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProduto
            // 
            lblProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblProduto.Location = new Point(621, 718);
            lblProduto.MinimumSize = new Size(114, 53);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(114, 53);
            lblProduto.TabIndex = 81;
            lblProduto.Text = "Produto";
            lblProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblValorProduto
            // 
            lblValorProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblValorProduto.AutoSize = true;
            lblValorProduto.BackColor = Color.Transparent;
            lblValorProduto.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblValorProduto.Location = new Point(861, 718);
            lblValorProduto.MinimumSize = new Size(114, 53);
            lblValorProduto.Name = "lblValorProduto";
            lblValorProduto.Size = new Size(114, 53);
            lblValorProduto.TabIndex = 82;
            lblValorProduto.Text = "Valor";
            lblValorProduto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblHorario.Location = new Point(1099, 704);
            lblHorario.MinimumSize = new Size(229, 80);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(229, 80);
            lblHorario.TabIndex = 83;
            lblHorario.Text = "Horário";
            lblHorario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold);
            lblCodigo.Location = new Point(141, 718);
            lblCodigo.MinimumSize = new Size(114, 53);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(114, 53);
            lblCodigo.TabIndex = 79;
            lblCodigo.Text = "Código";
            lblCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloHistorico
            // 
            lblTituloHistorico.AutoSize = true;
            lblTituloHistorico.Font = new Font("Microsoft Sans Serif", 50F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTituloHistorico.ForeColor = Color.FromArgb(34, 95, 226);
            lblTituloHistorico.Location = new Point(34, 577);
            lblTituloHistorico.Name = "lblTituloHistorico";
            lblTituloHistorico.Size = new Size(602, 58);
            lblTituloHistorico.TabIndex = 109;
            lblTituloHistorico.Text = "HISTÓRICO DE VENDAS";
            // 
            // frmMenuAbrirCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(0, 1500);
            BackColor = SystemColors.Control;
            ClientSize = new Size(1481, 1051);
            Controls.Add(lblTituloHistorico);
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
            Controls.Add(btnBuscaEstoque);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(btnRegistrarVenda);
            Controls.Add(gpbValorVendas);
            Controls.Add(pctAbrirCaixa);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMenuAbrirCaixa";
            Text = "frmMenuAbrirCaixa";
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
        private Button btnBuscaEstoque;
        private Button btnCadastrarCliente;
        private Button btnRegistrarVenda;
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
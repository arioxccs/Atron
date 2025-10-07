namespace Atron
{
    partial class FrmEstoqueGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueGerente));
            txt_CampoBuscaEstoque = new TextBox();
            lbl_EstoqueTitulo = new Label();
            lbl_Operacoes = new Label();
            btn_GerarRelatorio = new Button();
            btn_CadastrarProduto = new Button();
            btn_CadastrarFornecedor = new Button();
            btn_EntradaEstoque = new Button();
            lbl_NiveisEstoque = new Label();
            pictureBox1 = new PictureBox();
            lbl_NivelMaximo = new Label();
            lbl_NivelMedio = new Label();
            pictureBox2 = new PictureBox();
            lbl_NivelMinimo = new Label();
            pictureBox3 = new PictureBox();
            lbl_NivelReposicao = new Label();
            pictureBox4 = new PictureBox();
            panel_ProdutoEstoque = new Panel();
            btn_maisInformacoes = new Button();
            pictureBox5 = new PictureBox();
            lbl_QtdeProduto = new Label();
            lbl_NomeMarca = new Label();
            lbl_NomeProduto = new Label();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            pictureBox7 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lbl_HistoricoEntrada = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_ProdutoEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // txt_CampoBuscaEstoque
            // 
            txt_CampoBuscaEstoque.BorderStyle = BorderStyle.FixedSingle;
            txt_CampoBuscaEstoque.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CampoBuscaEstoque.ForeColor = Color.FromArgb(102, 126, 255);
            txt_CampoBuscaEstoque.Location = new Point(168, 12);
            txt_CampoBuscaEstoque.Name = "txt_CampoBuscaEstoque";
            txt_CampoBuscaEstoque.Size = new Size(1030, 40);
            txt_CampoBuscaEstoque.TabIndex = 0;
            txt_CampoBuscaEstoque.Text = "  Pesquise produto,categoria, etc";
            // 
            // lbl_EstoqueTitulo
            // 
            lbl_EstoqueTitulo.AutoSize = true;
            lbl_EstoqueTitulo.Font = new Font("ST-Komsomol", 81.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_EstoqueTitulo.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_EstoqueTitulo.Location = new Point(476, 55);
            lbl_EstoqueTitulo.Name = "lbl_EstoqueTitulo";
            lbl_EstoqueTitulo.Size = new Size(384, 176);
            lbl_EstoqueTitulo.TabIndex = 1;
            lbl_EstoqueTitulo.Text = "Estoque";
            lbl_EstoqueTitulo.Click += lbl_EstoqueTitulo_Click;
            // 
            // lbl_Operacoes
            // 
            lbl_Operacoes.AutoSize = true;
            lbl_Operacoes.Font = new Font("Bebas Neue", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Operacoes.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_Operacoes.Location = new Point(12, 206);
            lbl_Operacoes.Name = "lbl_Operacoes";
            lbl_Operacoes.Size = new Size(310, 100);
            lbl_Operacoes.TabIndex = 2;
            lbl_Operacoes.Text = "Operações";
            lbl_Operacoes.Click += label1_Click;
            // 
            // btn_GerarRelatorio
            // 
            btn_GerarRelatorio.BackColor = Color.FromArgb(255, 162, 71);
            btn_GerarRelatorio.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_GerarRelatorio.ForeColor = Color.FromArgb(9, 28, 128);
            btn_GerarRelatorio.Image = (Image)resources.GetObject("btn_GerarRelatorio.Image");
            btn_GerarRelatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GerarRelatorio.Location = new Point(32, 300);
            btn_GerarRelatorio.Name = "btn_GerarRelatorio";
            btn_GerarRelatorio.Padding = new Padding(5);
            btn_GerarRelatorio.Size = new Size(275, 50);
            btn_GerarRelatorio.TabIndex = 3;
            btn_GerarRelatorio.Text = "Gerar relatório";
            btn_GerarRelatorio.UseVisualStyleBackColor = false;
            btn_GerarRelatorio.Click += btn_GerarRelatorio_Click;
            // 
            // btn_CadastrarProduto
            // 
            btn_CadastrarProduto.BackColor = Color.FromArgb(255, 162, 71);
            btn_CadastrarProduto.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CadastrarProduto.ForeColor = Color.FromArgb(9, 28, 128);
            btn_CadastrarProduto.Image = (Image)resources.GetObject("btn_CadastrarProduto.Image");
            btn_CadastrarProduto.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadastrarProduto.Location = new Point(348, 300);
            btn_CadastrarProduto.Name = "btn_CadastrarProduto";
            btn_CadastrarProduto.Padding = new Padding(5);
            btn_CadastrarProduto.Size = new Size(275, 50);
            btn_CadastrarProduto.TabIndex = 4;
            btn_CadastrarProduto.Text = "Cadastrar Produto";
            btn_CadastrarProduto.UseVisualStyleBackColor = false;
            // 
            // btn_CadastrarFornecedor
            // 
            btn_CadastrarFornecedor.BackColor = Color.FromArgb(255, 162, 71);
            btn_CadastrarFornecedor.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CadastrarFornecedor.ForeColor = Color.FromArgb(9, 28, 128);
            btn_CadastrarFornecedor.Image = (Image)resources.GetObject("btn_CadastrarFornecedor.Image");
            btn_CadastrarFornecedor.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadastrarFornecedor.Location = new Point(656, 300);
            btn_CadastrarFornecedor.Name = "btn_CadastrarFornecedor";
            btn_CadastrarFornecedor.Padding = new Padding(5);
            btn_CadastrarFornecedor.Size = new Size(275, 50);
            btn_CadastrarFornecedor.TabIndex = 5;
            btn_CadastrarFornecedor.Text = "Cadastrar Fornecedor";
            btn_CadastrarFornecedor.TextAlign = ContentAlignment.MiddleRight;
            btn_CadastrarFornecedor.UseVisualStyleBackColor = false;
            // 
            // btn_EntradaEstoque
            // 
            btn_EntradaEstoque.BackColor = Color.FromArgb(255, 162, 71);
            btn_EntradaEstoque.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EntradaEstoque.ForeColor = Color.FromArgb(9, 28, 128);
            btn_EntradaEstoque.Image = (Image)resources.GetObject("btn_EntradaEstoque.Image");
            btn_EntradaEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EntradaEstoque.Location = new Point(978, 300);
            btn_EntradaEstoque.Name = "btn_EntradaEstoque";
            btn_EntradaEstoque.Padding = new Padding(5);
            btn_EntradaEstoque.Size = new Size(275, 50);
            btn_EntradaEstoque.TabIndex = 6;
            btn_EntradaEstoque.Text = "Entrada no Estoque";
            btn_EntradaEstoque.UseVisualStyleBackColor = false;
            // 
            // lbl_NiveisEstoque
            // 
            lbl_NiveisEstoque.AutoSize = true;
            lbl_NiveisEstoque.Font = new Font("Bebas Neue", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NiveisEstoque.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_NiveisEstoque.Location = new Point(12, 402);
            lbl_NiveisEstoque.Name = "lbl_NiveisEstoque";
            lbl_NiveisEstoque.Size = new Size(465, 100);
            lbl_NiveisEstoque.TabIndex = 7;
            lbl_NiveisEstoque.Text = "Nível do Estoque";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 505);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 25);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lbl_NivelMaximo
            // 
            lbl_NivelMaximo.AutoSize = true;
            lbl_NivelMaximo.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NivelMaximo.Location = new Point(98, 505);
            lbl_NivelMaximo.Name = "lbl_NivelMaximo";
            lbl_NivelMaximo.Size = new Size(87, 25);
            lbl_NivelMaximo.TabIndex = 9;
            lbl_NivelMaximo.Text = "Máximo";
            lbl_NivelMaximo.Click += lbl_NivelMaximo_Click;
            // 
            // lbl_NivelMedio
            // 
            lbl_NivelMedio.AutoSize = true;
            lbl_NivelMedio.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NivelMedio.Location = new Point(257, 505);
            lbl_NivelMedio.Name = "lbl_NivelMedio";
            lbl_NivelMedio.Size = new Size(71, 25);
            lbl_NivelMedio.TabIndex = 11;
            lbl_NivelMedio.Text = "Médio";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(191, 505);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 25);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lbl_NivelMinimo
            // 
            lbl_NivelMinimo.AutoSize = true;
            lbl_NivelMinimo.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NivelMinimo.Location = new Point(400, 505);
            lbl_NivelMinimo.Name = "lbl_NivelMinimo";
            lbl_NivelMinimo.Size = new Size(82, 25);
            lbl_NivelMinimo.TabIndex = 13;
            lbl_NivelMinimo.Text = "Mínimo";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(334, 505);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 25);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // lbl_NivelReposicao
            // 
            lbl_NivelReposicao.AutoSize = true;
            lbl_NivelReposicao.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NivelReposicao.Location = new Point(543, 505);
            lbl_NivelReposicao.Name = "lbl_NivelReposicao";
            lbl_NivelReposicao.Size = new Size(229, 25);
            lbl_NivelReposicao.TabIndex = 15;
            lbl_NivelReposicao.Text = "Necessita de Reposição";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(477, 505);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 25);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // panel_ProdutoEstoque
            // 
            panel_ProdutoEstoque.BackColor = Color.FromArgb(179, 255, 208);
            panel_ProdutoEstoque.Controls.Add(btn_maisInformacoes);
            panel_ProdutoEstoque.Controls.Add(pictureBox5);
            panel_ProdutoEstoque.Controls.Add(lbl_QtdeProduto);
            panel_ProdutoEstoque.Controls.Add(lbl_NomeMarca);
            panel_ProdutoEstoque.Controls.Add(lbl_NomeProduto);
            panel_ProdutoEstoque.Location = new Point(32, 563);
            panel_ProdutoEstoque.Name = "panel_ProdutoEstoque";
            panel_ProdutoEstoque.Size = new Size(360, 111);
            panel_ProdutoEstoque.TabIndex = 16;
            panel_ProdutoEstoque.Paint += panel_ProdutoEstoque_Paint;
            // 
            // btn_maisInformacoes
            // 
            btn_maisInformacoes.BackColor = Color.FromArgb(179, 255, 208);
            btn_maisInformacoes.FlatAppearance.BorderSize = 0;
            btn_maisInformacoes.FlatStyle = FlatStyle.Flat;
            btn_maisInformacoes.Image = (Image)resources.GetObject("btn_maisInformacoes.Image");
            btn_maisInformacoes.Location = new Point(327, 3);
            btn_maisInformacoes.Name = "btn_maisInformacoes";
            btn_maisInformacoes.Size = new Size(30, 30);
            btn_maisInformacoes.TabIndex = 18;
            btn_maisInformacoes.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(181, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 97);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // lbl_QtdeProduto
            // 
            lbl_QtdeProduto.AutoSize = true;
            lbl_QtdeProduto.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_QtdeProduto.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_QtdeProduto.Location = new Point(22, 74);
            lbl_QtdeProduto.Name = "lbl_QtdeProduto";
            lbl_QtdeProduto.Size = new Size(92, 19);
            lbl_QtdeProduto.TabIndex = 2;
            lbl_QtdeProduto.Text = "Quantidade";
            // 
            // lbl_NomeMarca
            // 
            lbl_NomeMarca.AutoSize = true;
            lbl_NomeMarca.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomeMarca.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_NomeMarca.Location = new Point(21, 49);
            lbl_NomeMarca.Name = "lbl_NomeMarca";
            lbl_NomeMarca.Size = new Size(53, 19);
            lbl_NomeMarca.TabIndex = 1;
            lbl_NomeMarca.Text = "Marca";
            // 
            // lbl_NomeProduto
            // 
            lbl_NomeProduto.AutoSize = true;
            lbl_NomeProduto.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomeProduto.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_NomeProduto.Location = new Point(13, 11);
            lbl_NomeProduto.Name = "lbl_NomeProduto";
            lbl_NomeProduto.Size = new Size(90, 35);
            lbl_NomeProduto.TabIndex = 0;
            lbl_NomeProduto.Text = "Produto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 236, 128);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(412, 563);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 111);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 236, 128);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(327, 3);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(181, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(94, 97);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 41, 184);
            label1.Location = new Point(22, 74);
            label1.Name = "label1";
            label1.Size = new Size(92, 19);
            label1.TabIndex = 2;
            label1.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(14, 41, 184);
            label2.Location = new Point(21, 49);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 1;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(14, 41, 184);
            label3.Location = new Point(13, 11);
            label3.Name = "label3";
            label3.Size = new Size(90, 35);
            label3.TabIndex = 0;
            label3.Text = "Produto";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 162, 162);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(788, 563);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 111);
            panel2.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(252, 162, 162);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(327, 3);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 18;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(181, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(94, 97);
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(14, 41, 184);
            label4.Location = new Point(22, 74);
            label4.Name = "label4";
            label4.Size = new Size(92, 19);
            label4.TabIndex = 2;
            label4.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(14, 41, 184);
            label5.Location = new Point(21, 49);
            label5.Name = "label5";
            label5.Size = new Size(53, 19);
            label5.TabIndex = 1;
            label5.Text = "Marca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(14, 41, 184);
            label6.Location = new Point(13, 11);
            label6.Name = "label6";
            label6.Size = new Size(90, 35);
            label6.TabIndex = 0;
            label6.Text = "Produto";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 0, 0, 153);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(327, 3);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 18;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(153, 153, 153);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(29, 699);
            panel3.Name = "panel3";
            panel3.Size = new Size(360, 111);
            panel3.TabIndex = 21;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(181, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(94, 97);
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(14, 41, 184);
            label7.Location = new Point(22, 74);
            label7.Name = "label7";
            label7.Size = new Size(92, 19);
            label7.TabIndex = 2;
            label7.Text = "Quantidade";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lato", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(14, 41, 184);
            label8.Location = new Point(21, 49);
            label8.Name = "label8";
            label8.Size = new Size(53, 19);
            label8.TabIndex = 1;
            label8.Text = "Marca";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(14, 41, 184);
            label9.Location = new Point(13, 11);
            label9.Name = "label9";
            label9.Size = new Size(90, 35);
            label9.TabIndex = 0;
            label9.Text = "Produto";
            // 
            // lbl_HistoricoEntrada
            // 
            lbl_HistoricoEntrada.AutoSize = true;
            lbl_HistoricoEntrada.BackColor = Color.White;
            lbl_HistoricoEntrada.Font = new Font("Bebas Neue", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_HistoricoEntrada.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_HistoricoEntrada.Location = new Point(21, 847);
            lbl_HistoricoEntrada.Name = "lbl_HistoricoEntrada";
            lbl_HistoricoEntrada.Size = new Size(579, 100);
            lbl_HistoricoEntrada.TabIndex = 22;
            lbl_HistoricoEntrada.Text = "Histórico de Entrada";
            // 
            // FrmEstoqueGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1296, 1061);
            Controls.Add(lbl_HistoricoEntrada);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel_ProdutoEstoque);
            Controls.Add(lbl_NivelReposicao);
            Controls.Add(pictureBox4);
            Controls.Add(lbl_NivelMinimo);
            Controls.Add(pictureBox3);
            Controls.Add(lbl_NivelMedio);
            Controls.Add(pictureBox2);
            Controls.Add(lbl_NivelMaximo);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_NiveisEstoque);
            Controls.Add(btn_EntradaEstoque);
            Controls.Add(btn_CadastrarFornecedor);
            Controls.Add(btn_CadastrarProduto);
            Controls.Add(btn_GerarRelatorio);
            Controls.Add(lbl_Operacoes);
            Controls.Add(lbl_EstoqueTitulo);
            Controls.Add(txt_CampoBuscaEstoque);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEstoqueGerente";
            Text = "FrmEstoqueGerente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_ProdutoEstoque.ResumeLayout(false);
            panel_ProdutoEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_CampoBuscaEstoque;
        private Label lbl_EstoqueTitulo;
        private Label lbl_Operacoes;
        private Button btn_GerarRelatorio;
        private Button btn_CadastrarProduto;
        private Button btn_CadastrarFornecedor;
        private Button btn_EntradaEstoque;
        private Label lbl_NiveisEstoque;
        private PictureBox pictureBox1;
        private Label lbl_NivelMaximo;
        private Label lbl_NivelMedio;
        private PictureBox pictureBox2;
        private Label lbl_NivelMinimo;
        private PictureBox pictureBox3;
        private Label lbl_NivelReposicao;
        private PictureBox pictureBox4;
        private Panel panel_ProdutoEstoque;
        private Button btn_maisInformacoes;
        private PictureBox pictureBox5;
        private Label lbl_QtdeProduto;
        private Label lbl_NomeMarca;
        private Label lbl_NomeProduto;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Button button2;
        private PictureBox pictureBox7;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button3;
        private Panel panel3;
        private PictureBox pictureBox8;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl_HistoricoEntrada;
    }
}
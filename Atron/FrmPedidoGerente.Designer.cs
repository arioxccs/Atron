namespace Atron
{
    partial class FrmPedidoGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidoGerente));
            lbl_PedidosTitulo = new Label();
            lbl_PedidosReativacao = new Label();
            panelPedidoReativacao = new Panel();
            btn_PedidoReativacao = new Button();
            lbl_ValorPedidoReativacao = new Label();
            lbl_QtdePedidoReativacao = new Label();
            lbl_CorPedidoReativacao = new Label();
            lbl_MarcaPedidoReativacao = new Label();
            lbl_DataCancelamentoPedido = new Label();
            lbl_CancelamentoPedido = new Label();
            lbl_DataSolicitacaoReativacao = new Label();
            lbl_SolicitacaoReativacao = new Label();
            lbl_NomePedidoReativacao = new Label();
            panel_ProdutoEstoque = new Panel();
            btn_Pedido = new Button();
            pictureBox5 = new PictureBox();
            lbl_QtdeProduto = new Label();
            lbl_NomeMarca = new Label();
            lbl_NomeProduto = new Label();
            lbl_Pedido = new Label();
            panelPedidoCancelado = new Panel();
            btn_PedidoCancelado = new Button();
            lbl_ValorPedidoCancelado = new Label();
            lbl_QtdePedidoCancelado = new Label();
            lbl_CorPedidoCancelado = new Label();
            lbl_MarcaPedidoCancelado = new Label();
            label16lbl_DataCancelamentoPedidoCancelado = new Label();
            lbl_CancelamentoPedidoCancelado = new Label();
            lbl_NomePedidoCancelado = new Label();
            lbl_PedidoCancelado = new Label();
            panelPedidoReativacao.SuspendLayout();
            panel_ProdutoEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelPedidoCancelado.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_PedidosTitulo
            // 
            lbl_PedidosTitulo.AutoSize = true;
            lbl_PedidosTitulo.Font = new Font("ST-Komsomol", 81.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PedidosTitulo.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_PedidosTitulo.Location = new Point(477, -49);
            lbl_PedidosTitulo.Name = "lbl_PedidosTitulo";
            lbl_PedidosTitulo.Size = new Size(374, 176);
            lbl_PedidosTitulo.TabIndex = 2;
            lbl_PedidosTitulo.Text = "Pedidos";
            // 
            // lbl_PedidosReativacao
            // 
            lbl_PedidosReativacao.AutoSize = true;
            lbl_PedidosReativacao.Font = new Font("Bebas Neue", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PedidosReativacao.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_PedidosReativacao.Location = new Point(24, 153);
            lbl_PedidosReativacao.Name = "lbl_PedidosReativacao";
            lbl_PedidosReativacao.Size = new Size(841, 87);
            lbl_PedidosReativacao.TabIndex = 3;
            lbl_PedidosReativacao.Text = "pedidos solicitados para reativação";
            // 
            // panelPedidoReativacao
            // 
            panelPedidoReativacao.BorderStyle = BorderStyle.FixedSingle;
            panelPedidoReativacao.Controls.Add(btn_PedidoReativacao);
            panelPedidoReativacao.Controls.Add(lbl_ValorPedidoReativacao);
            panelPedidoReativacao.Controls.Add(lbl_QtdePedidoReativacao);
            panelPedidoReativacao.Controls.Add(lbl_CorPedidoReativacao);
            panelPedidoReativacao.Controls.Add(lbl_MarcaPedidoReativacao);
            panelPedidoReativacao.Controls.Add(lbl_DataCancelamentoPedido);
            panelPedidoReativacao.Controls.Add(lbl_CancelamentoPedido);
            panelPedidoReativacao.Controls.Add(lbl_DataSolicitacaoReativacao);
            panelPedidoReativacao.Controls.Add(lbl_SolicitacaoReativacao);
            panelPedidoReativacao.Controls.Add(lbl_NomePedidoReativacao);
            panelPedidoReativacao.Location = new Point(37, 243);
            panelPedidoReativacao.Name = "panelPedidoReativacao";
            panelPedidoReativacao.Size = new Size(425, 158);
            panelPedidoReativacao.TabIndex = 4;
            panelPedidoReativacao.Paint += panel1_Paint;
            // 
            // btn_PedidoReativacao
            // 
            btn_PedidoReativacao.BackColor = Color.White;
            btn_PedidoReativacao.FlatAppearance.BorderSize = 0;
            btn_PedidoReativacao.FlatStyle = FlatStyle.Flat;
            btn_PedidoReativacao.Image = (Image)resources.GetObject("btn_PedidoReativacao.Image");
            btn_PedidoReativacao.Location = new Point(395, 3);
            btn_PedidoReativacao.Name = "btn_PedidoReativacao";
            btn_PedidoReativacao.Size = new Size(30, 30);
            btn_PedidoReativacao.TabIndex = 19;
            btn_PedidoReativacao.UseVisualStyleBackColor = false;
            btn_PedidoReativacao.Click += btn_PedidoReativacao_Click;
            // 
            // lbl_ValorPedidoReativacao
            // 
            lbl_ValorPedidoReativacao.AutoSize = true;
            lbl_ValorPedidoReativacao.Font = new Font("Bebas Neue", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ValorPedidoReativacao.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_ValorPedidoReativacao.Location = new Point(13, 122);
            lbl_ValorPedidoReativacao.Name = "lbl_ValorPedidoReativacao";
            lbl_ValorPedidoReativacao.Size = new Size(50, 27);
            lbl_ValorPedidoReativacao.TabIndex = 12;
            lbl_ValorPedidoReativacao.Text = "Valor";
            // 
            // lbl_QtdePedidoReativacao
            // 
            lbl_QtdePedidoReativacao.AutoSize = true;
            lbl_QtdePedidoReativacao.Font = new Font("Lato", 11.9999981F);
            lbl_QtdePedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_QtdePedidoReativacao.Location = new Point(13, 96);
            lbl_QtdePedidoReativacao.Name = "lbl_QtdePedidoReativacao";
            lbl_QtdePedidoReativacao.Size = new Size(92, 19);
            lbl_QtdePedidoReativacao.TabIndex = 11;
            lbl_QtdePedidoReativacao.Text = "Quantidade";
            // 
            // lbl_CorPedidoReativacao
            // 
            lbl_CorPedidoReativacao.AutoSize = true;
            lbl_CorPedidoReativacao.Font = new Font("Lato", 11.9999981F);
            lbl_CorPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CorPedidoReativacao.Location = new Point(13, 69);
            lbl_CorPedidoReativacao.Name = "lbl_CorPedidoReativacao";
            lbl_CorPedidoReativacao.Size = new Size(35, 19);
            lbl_CorPedidoReativacao.TabIndex = 10;
            lbl_CorPedidoReativacao.Text = "Cor";
            // 
            // lbl_MarcaPedidoReativacao
            // 
            lbl_MarcaPedidoReativacao.AutoSize = true;
            lbl_MarcaPedidoReativacao.Font = new Font("Lato", 11.9999981F);
            lbl_MarcaPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_MarcaPedidoReativacao.Location = new Point(13, 45);
            lbl_MarcaPedidoReativacao.Name = "lbl_MarcaPedidoReativacao";
            lbl_MarcaPedidoReativacao.Size = new Size(53, 19);
            lbl_MarcaPedidoReativacao.TabIndex = 9;
            lbl_MarcaPedidoReativacao.Text = "Marca";
            // 
            // lbl_DataCancelamentoPedido
            // 
            lbl_DataCancelamentoPedido.AutoSize = true;
            lbl_DataCancelamentoPedido.Font = new Font("Lato", 11.9999981F);
            lbl_DataCancelamentoPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_DataCancelamentoPedido.Location = new Point(297, 100);
            lbl_DataCancelamentoPedido.Name = "lbl_DataCancelamentoPedido";
            lbl_DataCancelamentoPedido.Size = new Size(93, 19);
            lbl_DataCancelamentoPedido.TabIndex = 8;
            lbl_DataCancelamentoPedido.Text = "01/01/2025";
            // 
            // lbl_CancelamentoPedido
            // 
            lbl_CancelamentoPedido.AutoSize = true;
            lbl_CancelamentoPedido.Font = new Font("Lato", 11.9999981F);
            lbl_CancelamentoPedido.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CancelamentoPedido.Location = new Point(255, 79);
            lbl_CancelamentoPedido.Name = "lbl_CancelamentoPedido";
            lbl_CancelamentoPedido.Size = new Size(170, 19);
            lbl_CancelamentoPedido.TabIndex = 7;
            lbl_CancelamentoPedido.Text = "Data de Cancelamento:";
            // 
            // lbl_DataSolicitacaoReativacao
            // 
            lbl_DataSolicitacaoReativacao.AutoSize = true;
            lbl_DataSolicitacaoReativacao.Font = new Font("Lato", 11.9999981F);
            lbl_DataSolicitacaoReativacao.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_DataSolicitacaoReativacao.Location = new Point(297, 47);
            lbl_DataSolicitacaoReativacao.Name = "lbl_DataSolicitacaoReativacao";
            lbl_DataSolicitacaoReativacao.Size = new Size(93, 19);
            lbl_DataSolicitacaoReativacao.TabIndex = 6;
            lbl_DataSolicitacaoReativacao.Text = "01/01/2025";
            // 
            // lbl_SolicitacaoReativacao
            // 
            lbl_SolicitacaoReativacao.AutoSize = true;
            lbl_SolicitacaoReativacao.Font = new Font("Lato", 11.9999981F);
            lbl_SolicitacaoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_SolicitacaoReativacao.Location = new Point(268, 26);
            lbl_SolicitacaoReativacao.Name = "lbl_SolicitacaoReativacao";
            lbl_SolicitacaoReativacao.Size = new Size(144, 19);
            lbl_SolicitacaoReativacao.TabIndex = 5;
            lbl_SolicitacaoReativacao.Text = "Data de Solicitação:";
            // 
            // lbl_NomePedidoReativacao
            // 
            lbl_NomePedidoReativacao.AutoSize = true;
            lbl_NomePedidoReativacao.Font = new Font("Bebas Neue", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_NomePedidoReativacao.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_NomePedidoReativacao.Location = new Point(13, 10);
            lbl_NomePedidoReativacao.Name = "lbl_NomePedidoReativacao";
            lbl_NomePedidoReativacao.Size = new Size(73, 35);
            lbl_NomePedidoReativacao.TabIndex = 5;
            lbl_NomePedidoReativacao.Text = "Pedido";
            // 
            // panel_ProdutoEstoque
            // 
            panel_ProdutoEstoque.BackColor = Color.White;
            panel_ProdutoEstoque.BorderStyle = BorderStyle.FixedSingle;
            panel_ProdutoEstoque.Controls.Add(btn_Pedido);
            panel_ProdutoEstoque.Controls.Add(pictureBox5);
            panel_ProdutoEstoque.Controls.Add(lbl_QtdeProduto);
            panel_ProdutoEstoque.Controls.Add(lbl_NomeMarca);
            panel_ProdutoEstoque.Controls.Add(lbl_NomeProduto);
            panel_ProdutoEstoque.Location = new Point(37, 516);
            panel_ProdutoEstoque.Name = "panel_ProdutoEstoque";
            panel_ProdutoEstoque.Size = new Size(360, 111);
            panel_ProdutoEstoque.TabIndex = 17;
            // 
            // btn_Pedido
            // 
            btn_Pedido.BackColor = Color.White;
            btn_Pedido.FlatAppearance.BorderSize = 0;
            btn_Pedido.FlatStyle = FlatStyle.Flat;
            btn_Pedido.Image = (Image)resources.GetObject("btn_Pedido.Image");
            btn_Pedido.Location = new Point(327, 3);
            btn_Pedido.Name = "btn_Pedido";
            btn_Pedido.Size = new Size(30, 30);
            btn_Pedido.TabIndex = 18;
            btn_Pedido.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(181, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(94, 97);
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
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
            // lbl_Pedido
            // 
            lbl_Pedido.AutoSize = true;
            lbl_Pedido.Font = new Font("Bebas Neue", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Pedido.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_Pedido.Location = new Point(24, 426);
            lbl_Pedido.Name = "lbl_Pedido";
            lbl_Pedido.Size = new Size(206, 87);
            lbl_Pedido.TabIndex = 18;
            lbl_Pedido.Text = "pedidos";
            // 
            // panelPedidoCancelado
            // 
            panelPedidoCancelado.BorderStyle = BorderStyle.FixedSingle;
            panelPedidoCancelado.Controls.Add(btn_PedidoCancelado);
            panelPedidoCancelado.Controls.Add(lbl_ValorPedidoCancelado);
            panelPedidoCancelado.Controls.Add(lbl_QtdePedidoCancelado);
            panelPedidoCancelado.Controls.Add(lbl_CorPedidoCancelado);
            panelPedidoCancelado.Controls.Add(lbl_MarcaPedidoCancelado);
            panelPedidoCancelado.Controls.Add(label16lbl_DataCancelamentoPedidoCancelado);
            panelPedidoCancelado.Controls.Add(lbl_CancelamentoPedidoCancelado);
            panelPedidoCancelado.Controls.Add(lbl_NomePedidoCancelado);
            panelPedidoCancelado.Location = new Point(37, 742);
            panelPedidoCancelado.Name = "panelPedidoCancelado";
            panelPedidoCancelado.Size = new Size(425, 158);
            panelPedidoCancelado.TabIndex = 20;
            panelPedidoCancelado.Paint += panel2_Paint;
            // 
            // btn_PedidoCancelado
            // 
            btn_PedidoCancelado.BackColor = Color.White;
            btn_PedidoCancelado.FlatAppearance.BorderSize = 0;
            btn_PedidoCancelado.FlatStyle = FlatStyle.Flat;
            btn_PedidoCancelado.Image = (Image)resources.GetObject("btn_PedidoCancelado.Image");
            btn_PedidoCancelado.Location = new Point(392, 3);
            btn_PedidoCancelado.Name = "btn_PedidoCancelado";
            btn_PedidoCancelado.Size = new Size(30, 30);
            btn_PedidoCancelado.TabIndex = 19;
            btn_PedidoCancelado.UseVisualStyleBackColor = false;
            // 
            // lbl_ValorPedidoCancelado
            // 
            lbl_ValorPedidoCancelado.AutoSize = true;
            lbl_ValorPedidoCancelado.Font = new Font("Bebas Neue", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ValorPedidoCancelado.ForeColor = Color.FromArgb(255, 151, 55);
            lbl_ValorPedidoCancelado.Location = new Point(13, 122);
            lbl_ValorPedidoCancelado.Name = "lbl_ValorPedidoCancelado";
            lbl_ValorPedidoCancelado.Size = new Size(50, 27);
            lbl_ValorPedidoCancelado.TabIndex = 12;
            lbl_ValorPedidoCancelado.Text = "Valor";
            // 
            // lbl_QtdePedidoCancelado
            // 
            lbl_QtdePedidoCancelado.AutoSize = true;
            lbl_QtdePedidoCancelado.Font = new Font("Lato", 11.9999981F);
            lbl_QtdePedidoCancelado.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_QtdePedidoCancelado.Location = new Point(13, 96);
            lbl_QtdePedidoCancelado.Name = "lbl_QtdePedidoCancelado";
            lbl_QtdePedidoCancelado.Size = new Size(92, 19);
            lbl_QtdePedidoCancelado.TabIndex = 11;
            lbl_QtdePedidoCancelado.Text = "Quantidade";
            // 
            // lbl_CorPedidoCancelado
            // 
            lbl_CorPedidoCancelado.AutoSize = true;
            lbl_CorPedidoCancelado.Font = new Font("Lato", 11.9999981F);
            lbl_CorPedidoCancelado.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CorPedidoCancelado.Location = new Point(13, 69);
            lbl_CorPedidoCancelado.Name = "lbl_CorPedidoCancelado";
            lbl_CorPedidoCancelado.Size = new Size(35, 19);
            lbl_CorPedidoCancelado.TabIndex = 10;
            lbl_CorPedidoCancelado.Text = "Cor";
            // 
            // lbl_MarcaPedidoCancelado
            // 
            lbl_MarcaPedidoCancelado.AutoSize = true;
            lbl_MarcaPedidoCancelado.Font = new Font("Lato", 11.9999981F);
            lbl_MarcaPedidoCancelado.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_MarcaPedidoCancelado.Location = new Point(13, 45);
            lbl_MarcaPedidoCancelado.Name = "lbl_MarcaPedidoCancelado";
            lbl_MarcaPedidoCancelado.Size = new Size(53, 19);
            lbl_MarcaPedidoCancelado.TabIndex = 9;
            lbl_MarcaPedidoCancelado.Text = "Marca";
            // 
            // label16lbl_DataCancelamentoPedidoCancelado
            // 
            label16lbl_DataCancelamentoPedidoCancelado.AutoSize = true;
            label16lbl_DataCancelamentoPedidoCancelado.Font = new Font("Lato", 11.9999981F);
            label16lbl_DataCancelamentoPedidoCancelado.ForeColor = Color.FromArgb(147, 147, 147);
            label16lbl_DataCancelamentoPedidoCancelado.Location = new Point(297, 75);
            label16lbl_DataCancelamentoPedidoCancelado.Name = "label16lbl_DataCancelamentoPedidoCancelado";
            label16lbl_DataCancelamentoPedidoCancelado.Size = new Size(93, 19);
            label16lbl_DataCancelamentoPedidoCancelado.TabIndex = 8;
            label16lbl_DataCancelamentoPedidoCancelado.Text = "01/01/2025";
            // 
            // lbl_CancelamentoPedidoCancelado
            // 
            lbl_CancelamentoPedidoCancelado.AutoSize = true;
            lbl_CancelamentoPedidoCancelado.Font = new Font("Lato", 11.9999981F);
            lbl_CancelamentoPedidoCancelado.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CancelamentoPedidoCancelado.Location = new Point(255, 54);
            lbl_CancelamentoPedidoCancelado.Name = "lbl_CancelamentoPedidoCancelado";
            lbl_CancelamentoPedidoCancelado.Size = new Size(170, 19);
            lbl_CancelamentoPedidoCancelado.TabIndex = 7;
            lbl_CancelamentoPedidoCancelado.Text = "Data de Cancelamento:";
            // 
            // lbl_NomePedidoCancelado
            // 
            lbl_NomePedidoCancelado.AutoSize = true;
            lbl_NomePedidoCancelado.Font = new Font("Bebas Neue", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_NomePedidoCancelado.ForeColor = Color.FromArgb(194, 94, 0);
            lbl_NomePedidoCancelado.Location = new Point(13, 10);
            lbl_NomePedidoCancelado.Name = "lbl_NomePedidoCancelado";
            lbl_NomePedidoCancelado.Size = new Size(73, 35);
            lbl_NomePedidoCancelado.TabIndex = 5;
            lbl_NomePedidoCancelado.Text = "Pedido";
            // 
            // lbl_PedidoCancelado
            // 
            lbl_PedidoCancelado.AutoSize = true;
            lbl_PedidoCancelado.Font = new Font("Bebas Neue", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PedidoCancelado.ForeColor = Color.FromArgb(194, 94, 0);
            lbl_PedidoCancelado.Location = new Point(24, 652);
            lbl_PedidoCancelado.Name = "lbl_PedidoCancelado";
            lbl_PedidoCancelado.Size = new Size(453, 87);
            lbl_PedidoCancelado.TabIndex = 19;
            lbl_PedidoCancelado.Text = "Pedido Cancelados";
            // 
            // FrmPedidoGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 917);
            Controls.Add(panelPedidoCancelado);
            Controls.Add(lbl_PedidoCancelado);
            Controls.Add(lbl_Pedido);
            Controls.Add(panel_ProdutoEstoque);
            Controls.Add(panelPedidoReativacao);
            Controls.Add(lbl_PedidosReativacao);
            Controls.Add(lbl_PedidosTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPedidoGerente";
            Text = "FrmPedidoGerente";
            panelPedidoReativacao.ResumeLayout(false);
            panelPedidoReativacao.PerformLayout();
            panel_ProdutoEstoque.ResumeLayout(false);
            panel_ProdutoEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelPedidoCancelado.ResumeLayout(false);
            panelPedidoCancelado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_PedidosTitulo;
        private Label lbl_PedidosReativacao;
        private Panel panelPedidoReativacao;
        private Label lbl_SolicitacaoReativacao;
        private Label lbl_NomePedidoReativacao;
        private Label lbl_ValorPedidoReativacao;
        private Label lbl_QtdePedidoReativacao;
        private Label lbl_CorPedidoReativacao;
        private Label lbl_MarcaPedidoReativacao;
        private Label lbl_DataCancelamentoPedido;
        private Label lbl_CancelamentoPedido;
        private Label lbl_DataSolicitacaoReativacao;
        private Panel panel_ProdutoEstoque;
        private Button btn_Pedido;
        private PictureBox pictureBox5;
        private Label lbl_QtdeProduto;
        private Label lbl_NomeMarca;
        private Label lbl_NomeProduto;
        private Label lbl_Pedido;
        private Panel panelPedidoCancelado;
        private Label lbl_ValorPedidoCancelado;
        private Label lbl_QtdePedidoCancelado;
        private Label lbl_CorPedidoCancelado;
        private Label lbl_MarcaPedidoCancelado;
        private Label label16lbl_DataCancelamentoPedidoCancelado;
        private Label lbl_CancelamentoPedidoCancelado;
        private Label lbl_NomePedidoCancelado;
        private Label lbl_PedidoCancelado;
        private Button btn_PedidoReativacao;
        private Button btn_PedidoCancelado;
    }
}
namespace Atron
{
    partial class FrmPedidosRecentesGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosRecentesGerente));
            panel1 = new Panel();
            lbl_NomePedido = new Label();
            lbl_StatusPedido = new Label();
            lbl_CodFornecedorPedido = new Label();
            lbl_QtdeMinRPop = new Label();
            lbl_ProdutoSolicitadoPedido = new Label();
            lbl_NomeProdutoPedido = new Label();
            lbl_MarcaPedido = new Label();
            lbl_NumPedido = new Label();
            btn_Cancelar = new Button();
            lbl_NumPedidoT = new Label();
            lbl_NomeProdutoPedidoT = new Label();
            lbl_ProdutoSolicitadoPedidoT = new Label();
            lbl_QtdePedidoT = new Label();
            lbl_FornecedorPedidoT = new Label();
            lbl_MarcaPedidoT = new Label();
            lbl_CodFornecedorPedidoT = new Label();
            lbl_StatusPedidoT = new Label();
            lbl_CodFuncionarioPedido = new Label();
            lbl_CodFuncionarioPedidoT = new Label();
            lbl_QtdePedido = new Label();
            lbl_FornecedorPedido = new Label();
            lbl_SolicitacaoPedido = new Label();
            lbl_SolicitacaoPedidoT = new Label();
            btn_Certo = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(119, 162, 255);
            panel1.Controls.Add(lbl_NomePedido);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 97);
            panel1.TabIndex = 1;
            // 
            // lbl_NomePedido
            // 
            lbl_NomePedido.AutoSize = true;
            lbl_NomePedido.Font = new Font("Lato", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomePedido.ForeColor = Color.White;
            lbl_NomePedido.Location = new Point(183, 22);
            lbl_NomePedido.Name = "lbl_NomePedido";
            lbl_NomePedido.Size = new Size(161, 54);
            lbl_NomePedido.TabIndex = 0;
            lbl_NomePedido.Text = "Pedido";
            lbl_NomePedido.Click += lbl_PopUpNomeProduto_Click;
            // 
            // lbl_StatusPedido
            // 
            lbl_StatusPedido.AutoSize = true;
            lbl_StatusPedido.Font = new Font("Lato", 20.2499981F);
            lbl_StatusPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_StatusPedido.Location = new Point(117, 538);
            lbl_StatusPedido.Name = "lbl_StatusPedido";
            lbl_StatusPedido.Size = new Size(111, 33);
            lbl_StatusPedido.TabIndex = 42;
            lbl_StatusPedido.Text = "Enviado";
            // 
            // lbl_CodFornecedorPedido
            // 
            lbl_CodFornecedorPedido.AutoSize = true;
            lbl_CodFornecedorPedido.Font = new Font("Lato", 20.2499981F);
            lbl_CodFornecedorPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_CodFornecedorPedido.Location = new Point(249, 420);
            lbl_CodFornecedorPedido.Name = "lbl_CodFornecedorPedido";
            lbl_CodFornecedorPedido.Size = new Size(31, 33);
            lbl_CodFornecedorPedido.TabIndex = 41;
            lbl_CodFornecedorPedido.Text = "2";
            // 
            // lbl_QtdeMinRPop
            // 
            lbl_QtdeMinRPop.AutoSize = true;
            lbl_QtdeMinRPop.Font = new Font("Lato", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_QtdeMinRPop.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_QtdeMinRPop.Location = new Point(546, 364);
            lbl_QtdeMinRPop.Name = "lbl_QtdeMinRPop";
            lbl_QtdeMinRPop.Size = new Size(32, 35);
            lbl_QtdeMinRPop.TabIndex = 40;
            lbl_QtdeMinRPop.Text = "2";
            // 
            // lbl_ProdutoSolicitadoPedido
            // 
            lbl_ProdutoSolicitadoPedido.AutoSize = true;
            lbl_ProdutoSolicitadoPedido.Font = new Font("Lato", 20.2499981F);
            lbl_ProdutoSolicitadoPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_ProdutoSolicitadoPedido.Location = new Point(266, 298);
            lbl_ProdutoSolicitadoPedido.Name = "lbl_ProdutoSolicitadoPedido";
            lbl_ProdutoSolicitadoPedido.Size = new Size(113, 33);
            lbl_ProdutoSolicitadoPedido.TabIndex = 39;
            lbl_ProdutoSolicitadoPedido.Text = "Produto";
            lbl_ProdutoSolicitadoPedido.Click += lbl_ProdutoSolicitadoPedido_Click;
            // 
            // lbl_NomeProdutoPedido
            // 
            lbl_NomeProdutoPedido.AutoSize = true;
            lbl_NomeProdutoPedido.Font = new Font("Lato", 20.2499981F);
            lbl_NomeProdutoPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_NomeProdutoPedido.Location = new Point(272, 178);
            lbl_NomeProdutoPedido.Name = "lbl_NomeProdutoPedido";
            lbl_NomeProdutoPedido.Size = new Size(31, 33);
            lbl_NomeProdutoPedido.TabIndex = 37;
            lbl_NomeProdutoPedido.Text = "1";
            // 
            // lbl_MarcaPedido
            // 
            lbl_MarcaPedido.AutoSize = true;
            lbl_MarcaPedido.Font = new Font("Lato", 20.2499981F);
            lbl_MarcaPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_MarcaPedido.Location = new Point(116, 236);
            lbl_MarcaPedido.Name = "lbl_MarcaPedido";
            lbl_MarcaPedido.Size = new Size(92, 33);
            lbl_MarcaPedido.TabIndex = 36;
            lbl_MarcaPedido.Text = "Marca";
            // 
            // lbl_NumPedido
            // 
            lbl_NumPedido.AutoSize = true;
            lbl_NumPedido.Font = new Font("Lato", 20.2499981F);
            lbl_NumPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_NumPedido.Location = new Point(270, 120);
            lbl_NumPedido.Name = "lbl_NumPedido";
            lbl_NumPedido.Size = new Size(31, 33);
            lbl_NumPedido.TabIndex = 35;
            lbl_NumPedido.Text = "1";
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.BackColor = Color.FromArgb(255, 21, 0);
            btn_Cancelar.FlatStyle = FlatStyle.Flat;
            btn_Cancelar.Font = new Font("Bebas Neue", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Cancelar.ForeColor = Color.White;
            btn_Cancelar.Location = new Point(161, 669);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(215, 43);
            btn_Cancelar.TabIndex = 34;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.UseVisualStyleBackColor = false;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // lbl_NumPedidoT
            // 
            lbl_NumPedidoT.AutoSize = true;
            lbl_NumPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_NumPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_NumPedidoT.Location = new Point(5, 118);
            lbl_NumPedidoT.Name = "lbl_NumPedidoT";
            lbl_NumPedidoT.Size = new Size(259, 35);
            lbl_NumPedidoT.TabIndex = 33;
            lbl_NumPedidoT.Text = "Número do Pedido:";
            // 
            // lbl_NomeProdutoPedidoT
            // 
            lbl_NomeProdutoPedidoT.AutoSize = true;
            lbl_NomeProdutoPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_NomeProdutoPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_NomeProdutoPedidoT.Location = new Point(5, 176);
            lbl_NomeProdutoPedidoT.Name = "lbl_NomeProdutoPedidoT";
            lbl_NomeProdutoPedidoT.Size = new Size(261, 35);
            lbl_NomeProdutoPedidoT.TabIndex = 32;
            lbl_NomeProdutoPedidoT.Text = "Código do Produto:";
            // 
            // lbl_ProdutoSolicitadoPedidoT
            // 
            lbl_ProdutoSolicitadoPedidoT.AutoSize = true;
            lbl_ProdutoSolicitadoPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_ProdutoSolicitadoPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_ProdutoSolicitadoPedidoT.Location = new Point(5, 296);
            lbl_ProdutoSolicitadoPedidoT.Name = "lbl_ProdutoSolicitadoPedidoT";
            lbl_ProdutoSolicitadoPedidoT.Size = new Size(255, 35);
            lbl_ProdutoSolicitadoPedidoT.TabIndex = 30;
            lbl_ProdutoSolicitadoPedidoT.Text = "Produto solicitado:";
            // 
            // lbl_QtdePedidoT
            // 
            lbl_QtdePedidoT.AutoSize = true;
            lbl_QtdePedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_QtdePedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_QtdePedidoT.Location = new Point(5, 357);
            lbl_QtdePedidoT.Name = "lbl_QtdePedidoT";
            lbl_QtdePedidoT.Size = new Size(172, 35);
            lbl_QtdePedidoT.TabIndex = 29;
            lbl_QtdePedidoT.Text = "Quantidade:";
            // 
            // lbl_FornecedorPedidoT
            // 
            lbl_FornecedorPedidoT.AutoSize = true;
            lbl_FornecedorPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_FornecedorPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_FornecedorPedidoT.Location = new Point(5, 476);
            lbl_FornecedorPedidoT.Name = "lbl_FornecedorPedidoT";
            lbl_FornecedorPedidoT.Size = new Size(169, 35);
            lbl_FornecedorPedidoT.TabIndex = 28;
            lbl_FornecedorPedidoT.Text = "Fornecedor:";
            // 
            // lbl_MarcaPedidoT
            // 
            lbl_MarcaPedidoT.AutoSize = true;
            lbl_MarcaPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_MarcaPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_MarcaPedidoT.Location = new Point(5, 234);
            lbl_MarcaPedidoT.Name = "lbl_MarcaPedidoT";
            lbl_MarcaPedidoT.Size = new Size(105, 35);
            lbl_MarcaPedidoT.TabIndex = 27;
            lbl_MarcaPedidoT.Text = "Marca:";
            // 
            // lbl_CodFornecedorPedidoT
            // 
            lbl_CodFornecedorPedidoT.AutoSize = true;
            lbl_CodFornecedorPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_CodFornecedorPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_CodFornecedorPedidoT.Location = new Point(5, 417);
            lbl_CodFornecedorPedidoT.Name = "lbl_CodFornecedorPedidoT";
            lbl_CodFornecedorPedidoT.Size = new Size(233, 35);
            lbl_CodFornecedorPedidoT.TabIndex = 26;
            lbl_CodFornecedorPedidoT.Text = "Cód. Fornecedor:";
            // 
            // lbl_StatusPedidoT
            // 
            lbl_StatusPedidoT.AutoSize = true;
            lbl_StatusPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_StatusPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_StatusPedidoT.Location = new Point(5, 536);
            lbl_StatusPedidoT.Name = "lbl_StatusPedidoT";
            lbl_StatusPedidoT.Size = new Size(103, 35);
            lbl_StatusPedidoT.TabIndex = 25;
            lbl_StatusPedidoT.Text = "Status:";
            lbl_StatusPedidoT.Click += lbl_UltimaRespPop_Click;
            // 
            // lbl_CodFuncionarioPedido
            // 
            lbl_CodFuncionarioPedido.AutoSize = true;
            lbl_CodFuncionarioPedido.Font = new Font("Lato", 20.2499981F);
            lbl_CodFuncionarioPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_CodFuncionarioPedido.Location = new Point(491, 234);
            lbl_CodFuncionarioPedido.Name = "lbl_CodFuncionarioPedido";
            lbl_CodFuncionarioPedido.Size = new Size(47, 33);
            lbl_CodFuncionarioPedido.TabIndex = 44;
            lbl_CodFuncionarioPedido.Text = "10";
            // 
            // lbl_CodFuncionarioPedidoT
            // 
            lbl_CodFuncionarioPedidoT.AutoSize = true;
            lbl_CodFuncionarioPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_CodFuncionarioPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_CodFuncionarioPedidoT.Location = new Point(249, 234);
            lbl_CodFuncionarioPedidoT.Name = "lbl_CodFuncionarioPedidoT";
            lbl_CodFuncionarioPedidoT.Size = new Size(236, 35);
            lbl_CodFuncionarioPedidoT.TabIndex = 43;
            lbl_CodFuncionarioPedidoT.Text = "Cód. Funcionário:";
            lbl_CodFuncionarioPedidoT.Click += label2_Click;
            // 
            // lbl_QtdePedido
            // 
            lbl_QtdePedido.AutoSize = true;
            lbl_QtdePedido.Font = new Font("Lato", 20.2499981F);
            lbl_QtdePedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_QtdePedido.Location = new Point(183, 359);
            lbl_QtdePedido.Name = "lbl_QtdePedido";
            lbl_QtdePedido.Size = new Size(47, 33);
            lbl_QtdePedido.TabIndex = 45;
            lbl_QtdePedido.Text = "10";
            // 
            // lbl_FornecedorPedido
            // 
            lbl_FornecedorPedido.AutoSize = true;
            lbl_FornecedorPedido.Font = new Font("Lato", 20.2499981F);
            lbl_FornecedorPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_FornecedorPedido.Location = new Point(183, 478);
            lbl_FornecedorPedido.Name = "lbl_FornecedorPedido";
            lbl_FornecedorPedido.Size = new Size(152, 33);
            lbl_FornecedorPedido.TabIndex = 46;
            lbl_FornecedorPedido.Text = "Fornecedor";
            // 
            // lbl_SolicitacaoPedido
            // 
            lbl_SolicitacaoPedido.AutoSize = true;
            lbl_SolicitacaoPedido.Font = new Font("Lato", 20.2499981F);
            lbl_SolicitacaoPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_SolicitacaoPedido.Location = new Point(276, 595);
            lbl_SolicitacaoPedido.Name = "lbl_SolicitacaoPedido";
            lbl_SolicitacaoPedido.Size = new Size(163, 33);
            lbl_SolicitacaoPedido.TabIndex = 48;
            lbl_SolicitacaoPedido.Text = "01/01/2025";
            // 
            // lbl_SolicitacaoPedidoT
            // 
            lbl_SolicitacaoPedidoT.AutoSize = true;
            lbl_SolicitacaoPedidoT.Font = new Font("Lato", 21.75F, FontStyle.Underline);
            lbl_SolicitacaoPedidoT.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_SolicitacaoPedidoT.Location = new Point(7, 593);
            lbl_SolicitacaoPedidoT.Name = "lbl_SolicitacaoPedidoT";
            lbl_SolicitacaoPedidoT.Size = new Size(263, 35);
            lbl_SolicitacaoPedidoT.TabIndex = 47;
            lbl_SolicitacaoPedidoT.Text = "Data da solicitação:";
            // 
            // btn_Certo
            // 
            btn_Certo.BackColor = Color.FromArgb(14, 41, 184);
            btn_Certo.FlatAppearance.BorderSize = 0;
            btn_Certo.Image = (Image)resources.GetObject("btn_Certo.Image");
            btn_Certo.Location = new Point(440, 602);
            btn_Certo.Name = "btn_Certo";
            btn_Certo.Size = new Size(110, 110);
            btn_Certo.TabIndex = 49;
            btn_Certo.UseVisualStyleBackColor = false;
            btn_Certo.Click += btn_Certo_Click;
            // 
            // FrmPedidosRecentesGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(550, 712);
            Controls.Add(btn_Certo);
            Controls.Add(lbl_SolicitacaoPedido);
            Controls.Add(lbl_SolicitacaoPedidoT);
            Controls.Add(lbl_FornecedorPedido);
            Controls.Add(lbl_QtdePedido);
            Controls.Add(lbl_CodFuncionarioPedido);
            Controls.Add(lbl_CodFuncionarioPedidoT);
            Controls.Add(lbl_StatusPedido);
            Controls.Add(panel1);
            Controls.Add(lbl_CodFornecedorPedido);
            Controls.Add(lbl_QtdePedidoT);
            Controls.Add(lbl_QtdeMinRPop);
            Controls.Add(lbl_StatusPedidoT);
            Controls.Add(lbl_ProdutoSolicitadoPedido);
            Controls.Add(lbl_CodFornecedorPedidoT);
            Controls.Add(lbl_MarcaPedidoT);
            Controls.Add(lbl_NomeProdutoPedido);
            Controls.Add(lbl_FornecedorPedidoT);
            Controls.Add(lbl_MarcaPedido);
            Controls.Add(lbl_ProdutoSolicitadoPedidoT);
            Controls.Add(lbl_NumPedido);
            Controls.Add(btn_Cancelar);
            Controls.Add(lbl_NomeProdutoPedidoT);
            Controls.Add(lbl_NumPedidoT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPedidosRecentesGerente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmPedidosRecentesGerente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_NomePedido;
        private Label lbl_StatusPedido;
        private Label lbl_CodFornecedorPedido;
        private Label lbl_QtdeMinRPop;
        private Label lbl_ProdutoSolicitadoPedido;
        private Label lbl_NomeProdutoPedido;
        private Label lbl_MarcaPedido;
        private Label lbl_NumPedido;
        private Button btn_Cancelar;
        private Label lbl_NumPedidoT;
        private Label lbl_NomeProdutoPedidoT;
        private Label lbl_ProdutoSolicitadoPedidoT;
        private Label lbl_QtdePedidoT;
        private Label lbl_FornecedorPedidoT;
        private Label lbl_MarcaPedidoT;
        private Label lbl_CodFornecedorPedidoT;
        private Label lbl_StatusPedidoT;
        private Label lbl_CodFuncionarioPedido;
        private Label lbl_CodFuncionarioPedidoT;
        private Label lbl_QtdePedido;
        private Label lbl_FornecedorPedido;
        private Label lbl_SolicitacaoPedido;
        private Label lbl_SolicitacaoPedidoT;
        private Button btn_Certo;
    }
}
namespace Atron
{
    partial class FrmPedidosCanceladosGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosCanceladosGerente));
            btn_ReativarPedido = new Button();
            pictureBox1 = new PictureBox();
            lbl_DataCancelamentoPedido = new Label();
            lbl_CancelamentoPedido = new Label();
            panelMotivoCancelamento = new Panel();
            lbl_MotivoCancelamento = new Label();
            lbl_MotivoCancelamentoTitulo = new Label();
            label8 = new Label();
            lbl_CorPedidoReativacao = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lbl_QtdeAtualPedidoReativacao = new Label();
            lbl_QtdeSolicitadaPedidoReativacao = new Label();
            lbl_CanceladoporPedidoReativacao = new Label();
            lbl_FornecedorPedidoReativacao = new Label();
            lbl_MarcaPedidoReativacao = new Label();
            lbl_PedidoReativacao = new Label();
            lbl_NumeroPedidoReativacao = new Label();
            lbl_NomePedidoReativacao = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMotivoCancelamento.SuspendLayout();
            SuspendLayout();
            // 
            // btn_ReativarPedido
            // 
            btn_ReativarPedido.BackColor = Color.FromArgb(250, 189, 132);
            btn_ReativarPedido.FlatStyle = FlatStyle.Flat;
            btn_ReativarPedido.Font = new Font("Lato", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ReativarPedido.ForeColor = Color.White;
            btn_ReativarPedido.Location = new Point(329, 439);
            btn_ReativarPedido.Name = "btn_ReativarPedido";
            btn_ReativarPedido.Size = new Size(312, 37);
            btn_ReativarPedido.TabIndex = 42;
            btn_ReativarPedido.Text = "↪️ Reativar Pedido ";
            btn_ReativarPedido.UseVisualStyleBackColor = false;
            btn_ReativarPedido.Click += btn_ReativarPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 204);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // lbl_DataCancelamentoPedido
            // 
            lbl_DataCancelamentoPedido.AutoSize = true;
            lbl_DataCancelamentoPedido.Font = new Font("Lato", 11.9999981F);
            lbl_DataCancelamentoPedido.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_DataCancelamentoPedido.Location = new Point(435, 396);
            lbl_DataCancelamentoPedido.Name = "lbl_DataCancelamentoPedido";
            lbl_DataCancelamentoPedido.Size = new Size(93, 19);
            lbl_DataCancelamentoPedido.TabIndex = 40;
            lbl_DataCancelamentoPedido.Text = "01/01/2025";
            // 
            // lbl_CancelamentoPedido
            // 
            lbl_CancelamentoPedido.AutoSize = true;
            lbl_CancelamentoPedido.Font = new Font("Lato", 11.9999981F);
            lbl_CancelamentoPedido.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CancelamentoPedido.Location = new Point(408, 377);
            lbl_CancelamentoPedido.Name = "lbl_CancelamentoPedido";
            lbl_CancelamentoPedido.Size = new Size(166, 19);
            lbl_CancelamentoPedido.TabIndex = 39;
            lbl_CancelamentoPedido.Text = "Data de Cancelamento";
            // 
            // panelMotivoCancelamento
            // 
            panelMotivoCancelamento.BackColor = Color.FromArgb(208, 223, 255);
            panelMotivoCancelamento.Controls.Add(lbl_MotivoCancelamento);
            panelMotivoCancelamento.Controls.Add(lbl_MotivoCancelamentoTitulo);
            panelMotivoCancelamento.Controls.Add(label8);
            panelMotivoCancelamento.Location = new Point(227, 298);
            panelMotivoCancelamento.Name = "panelMotivoCancelamento";
            panelMotivoCancelamento.Size = new Size(576, 76);
            panelMotivoCancelamento.TabIndex = 36;
            // 
            // lbl_MotivoCancelamento
            // 
            lbl_MotivoCancelamento.AutoSize = true;
            lbl_MotivoCancelamento.Font = new Font("Lato", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MotivoCancelamento.ForeColor = Color.FromArgb(147, 147, 147);
            lbl_MotivoCancelamento.Location = new Point(3, 24);
            lbl_MotivoCancelamento.Name = "lbl_MotivoCancelamento";
            lbl_MotivoCancelamento.RightToLeft = RightToLeft.No;
            lbl_MotivoCancelamento.Size = new Size(221, 24);
            lbl_MotivoCancelamento.TabIndex = 16;
            lbl_MotivoCancelamento.Text = "Motivo do cancelamento";
            // 
            // lbl_MotivoCancelamentoTitulo
            // 
            lbl_MotivoCancelamentoTitulo.AutoSize = true;
            lbl_MotivoCancelamentoTitulo.Font = new Font("Lato", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_MotivoCancelamentoTitulo.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_MotivoCancelamentoTitulo.Location = new Point(3, 0);
            lbl_MotivoCancelamentoTitulo.Name = "lbl_MotivoCancelamentoTitulo";
            lbl_MotivoCancelamentoTitulo.RightToLeft = RightToLeft.No;
            lbl_MotivoCancelamentoTitulo.Size = new Size(221, 24);
            lbl_MotivoCancelamentoTitulo.TabIndex = 15;
            lbl_MotivoCancelamentoTitulo.Text = "Motivo do cancelamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(26, 76, 117);
            label8.Location = new Point(259, 14);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 12;
            // 
            // lbl_CorPedidoReativacao
            // 
            lbl_CorPedidoReativacao.AutoSize = true;
            lbl_CorPedidoReativacao.Font = new Font("Lato", 15F);
            lbl_CorPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CorPedidoReativacao.Location = new Point(114, 257);
            lbl_CorPedidoReativacao.Name = "lbl_CorPedidoReativacao";
            lbl_CorPedidoReativacao.Size = new Size(43, 24);
            lbl_CorPedidoReativacao.TabIndex = 35;
            lbl_CorPedidoReativacao.Text = "Cor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(26, 76, 117);
            label9.Location = new Point(359, 246);
            label9.Name = "label9";
            label9.Size = new Size(0, 25);
            label9.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(26, 76, 117);
            label10.Location = new Point(359, 190);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(26, 76, 117);
            label11.Location = new Point(359, 139);
            label11.Name = "label11";
            label11.Size = new Size(0, 25);
            label11.TabIndex = 32;
            // 
            // lbl_QtdeAtualPedidoReativacao
            // 
            lbl_QtdeAtualPedidoReativacao.AutoSize = true;
            lbl_QtdeAtualPedidoReativacao.Font = new Font("Lato", 15F);
            lbl_QtdeAtualPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_QtdeAtualPedidoReativacao.Location = new Point(406, 168);
            lbl_QtdeAtualPedidoReativacao.Name = "lbl_QtdeAtualPedidoReativacao";
            lbl_QtdeAtualPedidoReativacao.Size = new Size(168, 24);
            lbl_QtdeAtualPedidoReativacao.TabIndex = 31;
            lbl_QtdeAtualPedidoReativacao.Text = "Quantidade Atual:";
            // 
            // lbl_QtdeSolicitadaPedidoReativacao
            // 
            lbl_QtdeSolicitadaPedidoReativacao.AutoSize = true;
            lbl_QtdeSolicitadaPedidoReativacao.Font = new Font("Lato", 15F);
            lbl_QtdeSolicitadaPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_QtdeSolicitadaPedidoReativacao.Location = new Point(404, 118);
            lbl_QtdeSolicitadaPedidoReativacao.Name = "lbl_QtdeSolicitadaPedidoReativacao";
            lbl_QtdeSolicitadaPedidoReativacao.Size = new Size(200, 24);
            lbl_QtdeSolicitadaPedidoReativacao.TabIndex = 30;
            lbl_QtdeSolicitadaPedidoReativacao.Text = "Quantidade Solicitada";
            // 
            // lbl_CanceladoporPedidoReativacao
            // 
            lbl_CanceladoporPedidoReativacao.AutoSize = true;
            lbl_CanceladoporPedidoReativacao.Font = new Font("Lato", 15F);
            lbl_CanceladoporPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CanceladoporPedidoReativacao.Location = new Point(404, 69);
            lbl_CanceladoporPedidoReativacao.Name = "lbl_CanceladoporPedidoReativacao";
            lbl_CanceladoporPedidoReativacao.Size = new Size(200, 24);
            lbl_CanceladoporPedidoReativacao.TabIndex = 29;
            lbl_CanceladoporPedidoReativacao.Text = "Usuário que cancelou:";
            // 
            // lbl_FornecedorPedidoReativacao
            // 
            lbl_FornecedorPedidoReativacao.AutoSize = true;
            lbl_FornecedorPedidoReativacao.Font = new Font("Lato", 15F);
            lbl_FornecedorPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_FornecedorPedidoReativacao.Location = new Point(114, 207);
            lbl_FornecedorPedidoReativacao.Name = "lbl_FornecedorPedidoReativacao";
            lbl_FornecedorPedidoReativacao.Size = new Size(109, 24);
            lbl_FornecedorPedidoReativacao.TabIndex = 27;
            lbl_FornecedorPedidoReativacao.Text = "Fornecedor";
            // 
            // lbl_MarcaPedidoReativacao
            // 
            lbl_MarcaPedidoReativacao.AutoSize = true;
            lbl_MarcaPedidoReativacao.Font = new Font("Lato", 15F);
            lbl_MarcaPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_MarcaPedidoReativacao.Location = new Point(114, 158);
            lbl_MarcaPedidoReativacao.Name = "lbl_MarcaPedidoReativacao";
            lbl_MarcaPedidoReativacao.Size = new Size(65, 24);
            lbl_MarcaPedidoReativacao.TabIndex = 26;
            lbl_MarcaPedidoReativacao.Text = "Marca";
            // 
            // lbl_PedidoReativacao
            // 
            lbl_PedidoReativacao.AutoSize = true;
            lbl_PedidoReativacao.Font = new Font("Lato", 15F);
            lbl_PedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_PedidoReativacao.Location = new Point(114, 107);
            lbl_PedidoReativacao.Name = "lbl_PedidoReativacao";
            lbl_PedidoReativacao.Size = new Size(170, 24);
            lbl_PedidoReativacao.TabIndex = 25;
            lbl_PedidoReativacao.Text = "Produto Solicitado";
            // 
            // lbl_NumeroPedidoReativacao
            // 
            lbl_NumeroPedidoReativacao.AutoSize = true;
            lbl_NumeroPedidoReativacao.Font = new Font("Lato", 15F);
            lbl_NumeroPedidoReativacao.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_NumeroPedidoReativacao.Location = new Point(114, 60);
            lbl_NumeroPedidoReativacao.Name = "lbl_NumeroPedidoReativacao";
            lbl_NumeroPedidoReativacao.Size = new Size(171, 24);
            lbl_NumeroPedidoReativacao.TabIndex = 24;
            lbl_NumeroPedidoReativacao.Text = "Número do Pedido";
            // 
            // lbl_NomePedidoReativacao
            // 
            lbl_NomePedidoReativacao.AutoSize = true;
            lbl_NomePedidoReativacao.Font = new Font("Lato", 20.2499981F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_NomePedidoReativacao.ForeColor = Color.FromArgb(255, 151, 55);
            lbl_NomePedidoReativacao.Location = new Point(114, 16);
            lbl_NomePedidoReativacao.Name = "lbl_NomePedidoReativacao";
            lbl_NomePedidoReativacao.Size = new Size(98, 33);
            lbl_NomePedidoReativacao.TabIndex = 23;
            lbl_NomePedidoReativacao.Text = "Pedido";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(943, 0);
            button1.Name = "button1";
            button1.Size = new Size(28, 36);
            button1.TabIndex = 43;
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmPedidosCanceladosGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(972, 488);
            Controls.Add(button1);
            Controls.Add(btn_ReativarPedido);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_DataCancelamentoPedido);
            Controls.Add(lbl_CancelamentoPedido);
            Controls.Add(panelMotivoCancelamento);
            Controls.Add(lbl_CorPedidoReativacao);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(lbl_QtdeAtualPedidoReativacao);
            Controls.Add(lbl_QtdeSolicitadaPedidoReativacao);
            Controls.Add(lbl_CanceladoporPedidoReativacao);
            Controls.Add(lbl_FornecedorPedidoReativacao);
            Controls.Add(lbl_MarcaPedidoReativacao);
            Controls.Add(lbl_PedidoReativacao);
            Controls.Add(lbl_NumeroPedidoReativacao);
            Controls.Add(lbl_NomePedidoReativacao);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPedidosCanceladosGerente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmPedidosCanceladosGerente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMotivoCancelamento.ResumeLayout(false);
            panelMotivoCancelamento.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ReativarPedido;
        private PictureBox pictureBox1;
        private Label lbl_DataCancelamentoPedido;
        private Label lbl_CancelamentoPedido;
        private Panel panelMotivoCancelamento;
        private Label lbl_MotivoCancelamento;
        private Label lbl_MotivoCancelamentoTitulo;
        private Label label8;
        private Label lbl_CorPedidoReativacao;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lbl_QtdeAtualPedidoReativacao;
        private Label lbl_QtdeSolicitadaPedidoReativacao;
        private Label lbl_CanceladoporPedidoReativacao;
        private Label lbl_FornecedorPedidoReativacao;
        private Label lbl_MarcaPedidoReativacao;
        private Label lbl_PedidoReativacao;
        private Label lbl_NumeroPedidoReativacao;
        private Label lbl_NomePedidoReativacao;
        private Button button1;
    }
}
namespace Atron
{
    partial class FrmPedidosCancelados2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosCancelados2));
            pictureBox2 = new PictureBox();
            pnliNHA = new Panel();
            lblDadosdoCancelamentoDoPedido = new Label();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            lblDataCancel = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            lblCor = new Label();
            lblFornecedor = new Label();
            lblMarca = new Label();
            lblCodProduto = new Label();
            lblProduto = new Label();
            lblNumPedido = new Label();
            lblRaquete = new Label();
            panel2 = new Panel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(880, 478);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pnliNHA
            // 
            pnliNHA.Location = new Point(286, 94);
            pnliNHA.Name = "pnliNHA";
            pnliNHA.Size = new Size(539, 2);
            pnliNHA.TabIndex = 22;
            // 
            // lblDadosdoCancelamentoDoPedido
            // 
            lblDadosdoCancelamentoDoPedido.AutoSize = true;
            lblDadosdoCancelamentoDoPedido.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosdoCancelamentoDoPedido.ForeColor = Color.FromArgb(42, 97, 141);
            lblDadosdoCancelamentoDoPedido.Location = new Point(347, 55);
            lblDadosdoCancelamentoDoPedido.Name = "lblDadosdoCancelamentoDoPedido";
            lblDadosdoCancelamentoDoPedido.Size = new Size(412, 24);
            lblDadosdoCancelamentoDoPedido.TabIndex = 23;
            lblDadosdoCancelamentoDoPedido.Text = "DADOS DO CANCELAMENTO DO PEDIDO";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lblDataCancel);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblCor);
            panel1.Controls.Add(lblFornecedor);
            panel1.Controls.Add(lblMarca);
            panel1.Controls.Add(lblCodProduto);
            panel1.Controls.Add(lblProduto);
            panel1.Controls.Add(lblNumPedido);
            panel1.Controls.Add(lblRaquete);
            panel1.Location = new Point(95, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 390);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(880, 479);
            button1.Name = "button1";
            button1.Size = new Size(30, 32);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(327, 15);
            label1.TabIndex = 17;
            label1.Text = "Erro no pedido, falta de produto no fornecedor, desistência...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(624, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F);
            label15.Location = new Point(312, 330);
            label15.Name = "label15";
            label15.Size = new Size(69, 20);
            label15.TabIndex = 15;
            label15.Text = "02/03/25";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11.25F);
            label14.ForeColor = Color.FromArgb(30, 79, 119);
            label14.Location = new Point(239, 310);
            label14.Name = "label14";
            label14.Size = new Size(142, 20);
            label14.TabIndex = 14;
            label14.Text = "Data da Solicitação:";
            label14.TextAlign = ContentAlignment.TopRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F);
            label13.Location = new Point(418, 330);
            label13.Name = "label13";
            label13.Size = new Size(69, 20);
            label13.TabIndex = 13;
            label13.Text = "20/03/25";
            // 
            // lblDataCancel
            // 
            lblDataCancel.AutoSize = true;
            lblDataCancel.Font = new Font("Segoe UI", 11.25F);
            lblDataCancel.ForeColor = Color.FromArgb(30, 79, 119);
            lblDataCancel.Location = new Point(418, 310);
            lblDataCancel.Name = "lblDataCancel";
            lblDataCancel.Size = new Size(168, 20);
            lblDataCancel.TabIndex = 12;
            lblDataCancel.Text = "Data de Cancelamento: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.ForeColor = Color.FromArgb(99, 131, 157);
            label11.Location = new Point(407, 185);
            label11.Name = "label11";
            label11.Size = new Size(205, 20);
            label11.TabIndex = 11;
            label11.Text = "Quantidade Atual: 3 produtos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.ForeColor = Color.FromArgb(99, 131, 157);
            label10.Location = new Point(407, 161);
            label10.Name = "label10";
            label10.Size = new Size(244, 20);
            label10.TabIndex = 10;
            label10.Text = "Quantidade Solicitada: 40 produtos";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.ForeColor = Color.FromArgb(99, 131, 157);
            label9.Location = new Point(407, 111);
            label9.Name = "label9";
            label9.Size = new Size(171, 40);
            label9.TabIndex = 9;
            label9.Text = "Usuário que confirmou:  \nGabriela Chagas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.ForeColor = Color.FromArgb(99, 131, 157);
            label8.Location = new Point(407, 56);
            label8.Name = "label8";
            label8.Size = new Size(158, 40);
            label8.TabIndex = 8;
            label8.Text = "Pedido solicitado por: \nMaria Clara";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(99, 131, 157);
            label7.Location = new Point(14, 17);
            label7.Name = "label7";
            label7.Size = new Size(145, 15);
            label7.TabIndex = 7;
            label7.Text = "Motivo do Cancelamento:";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Segoe UI", 11.25F);
            lblCor.ForeColor = Color.FromArgb(99, 131, 157);
            lblCor.Location = new Point(64, 185);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(113, 20);
            lblCor.TabIndex = 6;
            lblCor.Text = "Cor: Estampada";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI", 11.25F);
            lblFornecedor.ForeColor = Color.FromArgb(99, 131, 157);
            lblFornecedor.Location = new Point(64, 161);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(226, 20);
            lblFornecedor.TabIndex = 5;
            lblFornecedor.Text = "Fornecedor: Atacado A Esportiva";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 11.25F);
            lblMarca.ForeColor = Color.FromArgb(99, 131, 157);
            lblMarca.Location = new Point(64, 136);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(94, 20);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca: Puma";
            // 
            // lblCodProduto
            // 
            lblCodProduto.AutoSize = true;
            lblCodProduto.Font = new Font("Segoe UI", 11.25F);
            lblCodProduto.ForeColor = Color.FromArgb(99, 131, 157);
            lblCodProduto.Location = new Point(64, 83);
            lblCodProduto.Name = "lblCodProduto";
            lblCodProduto.Size = new Size(160, 20);
            lblCodProduto.TabIndex = 3;
            lblCodProduto.Text = "Código do Produto: 54";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 11.25F);
            lblProduto.ForeColor = Color.FromArgb(99, 131, 157);
            lblProduto.Location = new Point(64, 111);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(253, 20);
            lblProduto.TabIndex = 2;
            lblProduto.Text = "Produto Solicitado: Raquete de Tênis";
            // 
            // lblNumPedido
            // 
            lblNumPedido.AutoSize = true;
            lblNumPedido.Font = new Font("Segoe UI", 11.25F);
            lblNumPedido.ForeColor = Color.FromArgb(99, 131, 157);
            lblNumPedido.Location = new Point(64, 58);
            lblNumPedido.Name = "lblNumPedido";
            lblNumPedido.Size = new Size(158, 20);
            lblNumPedido.TabIndex = 1;
            lblNumPedido.Text = "Número do Pedido: 12";
            // 
            // lblRaquete
            // 
            lblRaquete.AutoSize = true;
            lblRaquete.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblRaquete.ForeColor = Color.FromArgb(255, 122, 0);
            lblRaquete.Location = new Point(23, 16);
            lblRaquete.Name = "lblRaquete";
            lblRaquete.Size = new Size(154, 25);
            lblRaquete.TabIndex = 0;
            lblRaquete.Text = "Raquete de Tênis";
            lblRaquete.Click += lblMeiaCanoAlto_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(208, 223, 255);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(64, 222);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 77);
            panel2.TabIndex = 25;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 122, 0);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(384, 488);
            button2.Name = "button2";
            button2.Size = new Size(260, 54);
            button2.TabIndex = 26;
            button2.Text = "REATIVAR PEDIDO 🔄";
            button2.UseVisualStyleBackColor = false;
            // 
            // FrmPedidosCancelados2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 750);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(pnliNHA);
            Controls.Add(button1);
            Controls.Add(lblDadosdoCancelamentoDoPedido);
            Controls.Add(panel1);
            Name = "FrmPedidosCancelados2";
            Text = "FrmPedidosCancelados2";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel pnliNHA;
        private Label lblDadosdoCancelamentoDoPedido;
        private Panel panel1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label lblDataCancel;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label lblCor;
        private Label lblFornecedor;
        private Label lblMarca;
        private Label lblCodProduto;
        private Label lblProduto;
        private Label lblNumPedido;
        private Label lblRaquete;
        private Panel panel2;
        private Button button2;
    }
}
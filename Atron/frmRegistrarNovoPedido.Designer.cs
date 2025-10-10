namespace Atron
{
    partial class frmRegistrarNovoPedido
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
            lblRegistrarNovoPedido = new Label();
            txtFornecedor = new TextBox();
            lblFornecedor = new Label();
            label2 = new Label();
            lblFormaPag = new Label();
            lblObs = new Label();
            label5 = new Label();
            lblStatusPedido = new Label();
            lblSolicitado = new Label();
            lblSelecionarProdutos = new Label();
            lblCodFornecedor = new Label();
            lblAguardandoAprov = new Label();
            txtCodFornecedor = new TextBox();
            lblEmAndamento = new Label();
            textBox3 = new TextBox();
            lblAprovado = new Label();
            txtFormaPag = new TextBox();
            lblEntregue = new Label();
            lblCancelado = new Label();
            txtBox = new TextBox();
            mktDataChegada = new MaskedTextBox();
            cbxSelecionarProdutos = new ComboBox();
            btnMais = new Button();
            btnRegistraPedido = new Button();
            label1 = new Label();
            label3 = new Label();
            rbtnSolicitado = new RadioButton();
            pnlSolicitado = new Panel();
            pnlAguardandoAprovacao = new Panel();
            rbtnAguardandoAprovacao = new RadioButton();
            pnlAprovado = new Panel();
            rbtnAprovado = new RadioButton();
            pnlEmAndamento = new Panel();
            rbtnEmAndamento = new RadioButton();
            pnlEntregue = new Panel();
            rbtnEntregue = new RadioButton();
            pnlCancelado = new Panel();
            rbtnCancelado = new RadioButton();
            label4 = new Label();
            panel1 = new Panel();
            pnlSolicitado.SuspendLayout();
            pnlAguardandoAprovacao.SuspendLayout();
            pnlAprovado.SuspendLayout();
            pnlEmAndamento.SuspendLayout();
            pnlEntregue.SuspendLayout();
            pnlCancelado.SuspendLayout();
            SuspendLayout();
            // 
            // lblRegistrarNovoPedido
            // 
            lblRegistrarNovoPedido.AutoSize = true;
            lblRegistrarNovoPedido.Font = new Font("Bebas Neue", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarNovoPedido.ForeColor = Color.FromArgb(255, 122, 0);
            lblRegistrarNovoPedido.Location = new Point(299, 34);
            lblRegistrarNovoPedido.Name = "lblRegistrarNovoPedido";
            lblRegistrarNovoPedido.Size = new Size(215, 35);
            lblRegistrarNovoPedido.TabIndex = 0;
            lblRegistrarNovoPedido.Text = "REGISTRAR NOVO PEDIDO";
            lblRegistrarNovoPedido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(255, 180, 100);
            txtFornecedor.ForeColor = Color.Black;
            txtFornecedor.Location = new Point(68, 117);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(213, 23);
            txtFornecedor.TabIndex = 1;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFornecedor.ForeColor = Color.FromArgb(42, 97, 141);
            lblFornecedor.Location = new Point(68, 99);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(73, 15);
            lblFornecedor.TabIndex = 2;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = Color.FromArgb(42, 97, 141);
            label2.Location = new Point(68, 193);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 3;
            label2.Text = "Data de Chegada:";
            // 
            // lblFormaPag
            // 
            lblFormaPag.AutoSize = true;
            lblFormaPag.Font = new Font("Microsoft Sans Serif", 9F);
            lblFormaPag.ForeColor = Color.FromArgb(42, 97, 141);
            lblFormaPag.Location = new Point(68, 239);
            lblFormaPag.Name = "lblFormaPag";
            lblFormaPag.Size = new Size(130, 15);
            lblFormaPag.TabIndex = 4;
            lblFormaPag.Text = "Forma de Pagamento:";
            // 
            // lblObs
            // 
            lblObs.AutoSize = true;
            lblObs.Font = new Font("Microsoft Sans Serif", 9F);
            lblObs.ForeColor = Color.FromArgb(42, 97, 141);
            lblObs.Location = new Point(68, 288);
            lblObs.Name = "lblObs";
            lblObs.Size = new Size(81, 15);
            lblObs.TabIndex = 5;
            lblObs.Text = "Observações:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.ForeColor = Color.FromArgb(42, 97, 141);
            label5.Location = new Point(437, 100);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 6;
            label5.Text = "Imagem:";
            // 
            // lblStatusPedido
            // 
            lblStatusPedido.AutoSize = true;
            lblStatusPedido.Font = new Font("Microsoft Sans Serif", 9F);
            lblStatusPedido.ForeColor = Color.FromArgb(255, 122, 0);
            lblStatusPedido.Location = new Point(437, 161);
            lblStatusPedido.Name = "lblStatusPedido";
            lblStatusPedido.Size = new Size(138, 15);
            lblStatusPedido.TabIndex = 7;
            lblStatusPedido.Text = "Status Inicial do Pedido:";
            lblStatusPedido.Click += label6_Click;
            // 
            // lblSolicitado
            // 
            lblSolicitado.AutoSize = true;
            lblSolicitado.Font = new Font("Microsoft Sans Serif", 9F);
            lblSolicitado.ForeColor = Color.FromArgb(42, 97, 141);
            lblSolicitado.Location = new Point(486, 195);
            lblSolicitado.Name = "lblSolicitado";
            lblSolicitado.Size = new Size(61, 15);
            lblSolicitado.TabIndex = 9;
            lblSolicitado.Text = "Solicitado";
            // 
            // lblSelecionarProdutos
            // 
            lblSelecionarProdutos.AutoSize = true;
            lblSelecionarProdutos.Font = new Font("Microsoft Sans Serif", 9F);
            lblSelecionarProdutos.ForeColor = Color.FromArgb(42, 97, 141);
            lblSelecionarProdutos.Location = new Point(68, 144);
            lblSelecionarProdutos.Name = "lblSelecionarProdutos";
            lblSelecionarProdutos.Size = new Size(121, 15);
            lblSelecionarProdutos.TabIndex = 10;
            lblSelecionarProdutos.Text = "Selecionar Produtos:";
            // 
            // lblCodFornecedor
            // 
            lblCodFornecedor.AutoSize = true;
            lblCodFornecedor.Font = new Font("Microsoft Sans Serif", 9F);
            lblCodFornecedor.ForeColor = Color.FromArgb(42, 97, 141);
            lblCodFornecedor.Location = new Point(299, 100);
            lblCodFornecedor.Name = "lblCodFornecedor";
            lblCodFornecedor.Size = new Size(132, 15);
            lblCodFornecedor.TabIndex = 11;
            lblCodFornecedor.Text = "Código do Fornecedor:";
            // 
            // lblAguardandoAprov
            // 
            lblAguardandoAprov.AutoSize = true;
            lblAguardandoAprov.Font = new Font("Microsoft Sans Serif", 9F);
            lblAguardandoAprov.ForeColor = Color.FromArgb(42, 97, 141);
            lblAguardandoAprov.Location = new Point(486, 218);
            lblAguardandoAprov.Name = "lblAguardandoAprov";
            lblAguardandoAprov.Size = new Size(134, 15);
            lblAguardandoAprov.TabIndex = 13;
            lblAguardandoAprov.Text = "Aguardando aprovação";
            // 
            // txtCodFornecedor
            // 
            txtCodFornecedor.BackColor = Color.FromArgb(255, 180, 100);
            txtCodFornecedor.ForeColor = Color.Black;
            txtCodFornecedor.Location = new Point(299, 117);
            txtCodFornecedor.Name = "txtCodFornecedor";
            txtCodFornecedor.Size = new Size(100, 23);
            txtCodFornecedor.TabIndex = 12;
            // 
            // lblEmAndamento
            // 
            lblEmAndamento.AutoSize = true;
            lblEmAndamento.Font = new Font("Microsoft Sans Serif", 9F);
            lblEmAndamento.ForeColor = Color.FromArgb(42, 97, 141);
            lblEmAndamento.Location = new Point(486, 265);
            lblEmAndamento.Name = "lblEmAndamento";
            lblEmAndamento.Size = new Size(92, 15);
            lblEmAndamento.TabIndex = 15;
            lblEmAndamento.Text = "Em andamento";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 180, 100);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(68, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(331, 23);
            textBox3.TabIndex = 14;
            // 
            // lblAprovado
            // 
            lblAprovado.AutoSize = true;
            lblAprovado.Font = new Font("Microsoft Sans Serif", 9F);
            lblAprovado.ForeColor = Color.FromArgb(42, 97, 141);
            lblAprovado.Location = new Point(486, 240);
            lblAprovado.Name = "lblAprovado";
            lblAprovado.Size = new Size(58, 15);
            lblAprovado.TabIndex = 17;
            lblAprovado.Text = "Aprovado";
            // 
            // txtFormaPag
            // 
            txtFormaPag.BackColor = Color.FromArgb(255, 180, 100);
            txtFormaPag.ForeColor = Color.Black;
            txtFormaPag.Location = new Point(68, 258);
            txtFormaPag.Name = "txtFormaPag";
            txtFormaPag.Size = new Size(213, 23);
            txtFormaPag.TabIndex = 16;
            // 
            // lblEntregue
            // 
            lblEntregue.AutoSize = true;
            lblEntregue.Font = new Font("Microsoft Sans Serif", 9F);
            lblEntregue.ForeColor = Color.FromArgb(42, 97, 141);
            lblEntregue.Location = new Point(486, 288);
            lblEntregue.Name = "lblEntregue";
            lblEntregue.Size = new Size(57, 15);
            lblEntregue.TabIndex = 19;
            lblEntregue.Text = "Entregue";
            // 
            // lblCancelado
            // 
            lblCancelado.AutoSize = true;
            lblCancelado.Font = new Font("Microsoft Sans Serif", 9F);
            lblCancelado.ForeColor = Color.FromArgb(42, 97, 141);
            lblCancelado.Location = new Point(486, 312);
            lblCancelado.Name = "lblCancelado";
            lblCancelado.Size = new Size(66, 15);
            lblCancelado.TabIndex = 21;
            lblCancelado.Text = "Cancelado";
            lblCancelado.Click += lblCancelado_Click;
            // 
            // txtBox
            // 
            txtBox.BackColor = Color.FromArgb(255, 180, 100);
            txtBox.ForeColor = Color.Black;
            txtBox.Location = new Point(437, 117);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(222, 23);
            txtBox.TabIndex = 22;
            // 
            // mktDataChegada
            // 
            mktDataChegada.BackColor = Color.FromArgb(255, 180, 100);
            mktDataChegada.ForeColor = Color.Black;
            mktDataChegada.Location = new Point(68, 209);
            mktDataChegada.Mask = "00/00/0000";
            mktDataChegada.Name = "mktDataChegada";
            mktDataChegada.Size = new Size(100, 23);
            mktDataChegada.TabIndex = 26;
            // 
            // cbxSelecionarProdutos
            // 
            cbxSelecionarProdutos.BackColor = Color.FromArgb(255, 180, 100);
            cbxSelecionarProdutos.ForeColor = Color.Black;
            cbxSelecionarProdutos.FormattingEnabled = true;
            cbxSelecionarProdutos.Location = new Point(68, 161);
            cbxSelecionarProdutos.Name = "cbxSelecionarProdutos";
            cbxSelecionarProdutos.Size = new Size(331, 23);
            cbxSelecionarProdutos.TabIndex = 27;
            // 
            // btnMais
            // 
            btnMais.BackColor = Color.FromArgb(255, 180, 100);
            btnMais.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMais.ImageAlign = ContentAlignment.MiddleLeft;
            btnMais.Location = new Point(634, 117);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(25, 23);
            btnMais.TabIndex = 28;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = false;
            btnMais.Click += button1_Click;
            // 
            // btnRegistraPedido
            // 
            btnRegistraPedido.BackColor = Color.FromArgb(255, 180, 100);
            btnRegistraPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistraPedido.ForeColor = Color.White;
            btnRegistraPedido.Location = new Point(660, 377);
            btnRegistraPedido.Name = "btnRegistraPedido";
            btnRegistraPedido.Size = new Size(95, 47);
            btnRegistraPedido.TabIndex = 32;
            btnRegistraPedido.Text = "Registrar Pedido";
            btnRegistraPedido.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistraPedido.UseVisualStyleBackColor = false;
            btnRegistraPedido.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 180, 100);
            label1.ForeColor = Color.White;
            label1.Location = new Point(732, 394);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 33;
            label1.Text = ">";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 180, 100);
            label3.ForeColor = Color.White;
            label3.Location = new Point(721, 394);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 34;
            label3.Text = ">";
            // 
            // rbtnSolicitado
            // 
            rbtnSolicitado.AutoSize = true;
            rbtnSolicitado.Location = new Point(3, 2);
            rbtnSolicitado.Name = "rbtnSolicitado";
            rbtnSolicitado.Size = new Size(14, 13);
            rbtnSolicitado.TabIndex = 36;
            rbtnSolicitado.TabStop = true;
            rbtnSolicitado.UseVisualStyleBackColor = true;
            // 
            // pnlSolicitado
            // 
            pnlSolicitado.BackColor = Color.FromArgb(128, 128, 255);
            pnlSolicitado.Controls.Add(rbtnSolicitado);
            pnlSolicitado.Location = new Point(445, 193);
            pnlSolicitado.Name = "pnlSolicitado";
            pnlSolicitado.Size = new Size(35, 18);
            pnlSolicitado.TabIndex = 30;
            // 
            // pnlAguardandoAprovacao
            // 
            pnlAguardandoAprovacao.BackColor = Color.Green;
            pnlAguardandoAprovacao.Controls.Add(rbtnAguardandoAprovacao);
            pnlAguardandoAprovacao.Location = new Point(445, 217);
            pnlAguardandoAprovacao.Name = "pnlAguardandoAprovacao";
            pnlAguardandoAprovacao.Size = new Size(35, 18);
            pnlAguardandoAprovacao.TabIndex = 35;
            // 
            // rbtnAguardandoAprovacao
            // 
            rbtnAguardandoAprovacao.AutoSize = true;
            rbtnAguardandoAprovacao.Location = new Point(3, 2);
            rbtnAguardandoAprovacao.Name = "rbtnAguardandoAprovacao";
            rbtnAguardandoAprovacao.Size = new Size(14, 13);
            rbtnAguardandoAprovacao.TabIndex = 36;
            rbtnAguardandoAprovacao.TabStop = true;
            rbtnAguardandoAprovacao.UseVisualStyleBackColor = true;
            // 
            // pnlAprovado
            // 
            pnlAprovado.BackColor = Color.FromArgb(64, 0, 0);
            pnlAprovado.Controls.Add(rbtnAprovado);
            pnlAprovado.Location = new Point(445, 239);
            pnlAprovado.Name = "pnlAprovado";
            pnlAprovado.Size = new Size(35, 18);
            pnlAprovado.TabIndex = 36;
            // 
            // rbtnAprovado
            // 
            rbtnAprovado.AutoSize = true;
            rbtnAprovado.Location = new Point(3, 2);
            rbtnAprovado.Name = "rbtnAprovado";
            rbtnAprovado.Size = new Size(14, 13);
            rbtnAprovado.TabIndex = 36;
            rbtnAprovado.TabStop = true;
            rbtnAprovado.UseVisualStyleBackColor = true;
            // 
            // pnlEmAndamento
            // 
            pnlEmAndamento.BackColor = Color.Yellow;
            pnlEmAndamento.Controls.Add(rbtnEmAndamento);
            pnlEmAndamento.Location = new Point(445, 263);
            pnlEmAndamento.Name = "pnlEmAndamento";
            pnlEmAndamento.Size = new Size(35, 18);
            pnlEmAndamento.TabIndex = 37;
            // 
            // rbtnEmAndamento
            // 
            rbtnEmAndamento.AutoSize = true;
            rbtnEmAndamento.Location = new Point(3, 2);
            rbtnEmAndamento.Name = "rbtnEmAndamento";
            rbtnEmAndamento.Size = new Size(14, 13);
            rbtnEmAndamento.TabIndex = 36;
            rbtnEmAndamento.TabStop = true;
            rbtnEmAndamento.UseVisualStyleBackColor = true;
            // 
            // pnlEntregue
            // 
            pnlEntregue.BackColor = Color.Lime;
            pnlEntregue.Controls.Add(rbtnEntregue);
            pnlEntregue.Location = new Point(445, 287);
            pnlEntregue.Name = "pnlEntregue";
            pnlEntregue.Size = new Size(35, 18);
            pnlEntregue.TabIndex = 38;
            pnlEntregue.Paint += panel4_Paint;
            // 
            // rbtnEntregue
            // 
            rbtnEntregue.AutoSize = true;
            rbtnEntregue.Location = new Point(3, 2);
            rbtnEntregue.Name = "rbtnEntregue";
            rbtnEntregue.Size = new Size(14, 13);
            rbtnEntregue.TabIndex = 36;
            rbtnEntregue.TabStop = true;
            rbtnEntregue.UseVisualStyleBackColor = true;
            // 
            // pnlCancelado
            // 
            pnlCancelado.BackColor = Color.Red;
            pnlCancelado.Controls.Add(rbtnCancelado);
            pnlCancelado.Location = new Point(445, 308);
            pnlCancelado.Name = "pnlCancelado";
            pnlCancelado.Size = new Size(35, 18);
            pnlCancelado.TabIndex = 39;
            // 
            // rbtnCancelado
            // 
            rbtnCancelado.AutoSize = true;
            rbtnCancelado.Location = new Point(3, 2);
            rbtnCancelado.Name = "rbtnCancelado";
            rbtnCancelado.Size = new Size(14, 13);
            rbtnCancelado.TabIndex = 36;
            rbtnCancelado.TabStop = true;
            rbtnCancelado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 72);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 40;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(190, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 2);
            panel1.TabIndex = 41;
            // 
            // frmRegistrarNovoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(pnlCancelado);
            Controls.Add(pnlEntregue);
            Controls.Add(pnlEmAndamento);
            Controls.Add(pnlAprovado);
            Controls.Add(pnlAguardandoAprovacao);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnRegistraPedido);
            Controls.Add(pnlSolicitado);
            Controls.Add(btnMais);
            Controls.Add(cbxSelecionarProdutos);
            Controls.Add(mktDataChegada);
            Controls.Add(txtBox);
            Controls.Add(lblCancelado);
            Controls.Add(lblEntregue);
            Controls.Add(lblAprovado);
            Controls.Add(txtFormaPag);
            Controls.Add(lblEmAndamento);
            Controls.Add(textBox3);
            Controls.Add(lblAguardandoAprov);
            Controls.Add(txtCodFornecedor);
            Controls.Add(lblCodFornecedor);
            Controls.Add(lblSelecionarProdutos);
            Controls.Add(lblSolicitado);
            Controls.Add(lblStatusPedido);
            Controls.Add(label5);
            Controls.Add(lblObs);
            Controls.Add(lblFormaPag);
            Controls.Add(label2);
            Controls.Add(lblFornecedor);
            Controls.Add(txtFornecedor);
            Controls.Add(lblRegistrarNovoPedido);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegistrarNovoPedido";
            Text = "frmRegistrarNovoPedido";
            WindowState = FormWindowState.Maximized;
            Load += frmRegistrarNovoPedido_Load;
            pnlSolicitado.ResumeLayout(false);
            pnlSolicitado.PerformLayout();
            pnlAguardandoAprovacao.ResumeLayout(false);
            pnlAguardandoAprovacao.PerformLayout();
            pnlAprovado.ResumeLayout(false);
            pnlAprovado.PerformLayout();
            pnlEmAndamento.ResumeLayout(false);
            pnlEmAndamento.PerformLayout();
            pnlEntregue.ResumeLayout(false);
            pnlEntregue.PerformLayout();
            pnlCancelado.ResumeLayout(false);
            pnlCancelado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistrarNovoPedido;
        private TextBox txtFornecedor;
        private Label lblFornecedor;
        private Label label2;
        private Label lblFormaPag;
        private Label lblObs;
        private Label label5;
        private Label lblStatusPedido;
        private Label lblSolicitado;
        private Label lblSelecionarProdutos;
        private Label lblCodFornecedor;
        private Label lblAguardandoAprov;
        private TextBox txtCodFornecedor;
        private Label lblEmAndamento;
        private TextBox textBox3;
        private Label lblAprovado;
        private TextBox txtFormaPag;
        private Label lblEntregue;
        private Label lblCancelado;
        private TextBox txtBox;
        private MaskedTextBox mktDataChegada;
        private ComboBox cbxSelecionarProdutos;
        private Button btnMais;
        private Button btnRegistraPedido;
        private Label label1;
        private Label label3;
        private RadioButton rbtnSolicitado;
        private Panel pnlSolicitado;
        private Panel pnlAguardandoAprovacao;
        private RadioButton rbtnAguardandoAprovacao;
        private Panel pnlAprovado;
        private RadioButton rbtnAprovado;
        private Panel pnlEmAndamento;
        private RadioButton rbtnEmAndamento;
        private Panel pnlEntregue;
        private RadioButton rbtnEntregue;
        private Panel pnlCancelado;
        private RadioButton rbtnCancelado;
        private Label label4;
        private Panel panel1;
    }
}
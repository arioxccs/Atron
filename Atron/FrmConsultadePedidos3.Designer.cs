namespace Atron
{
    partial class FrmConsultadePedidos3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultadePedidos3));
            panel1 = new Panel();
            lblConsultadePedidos = new Label();
            panel2 = new Panel();
            lblKitdeBasquete = new Label();
            IblItens = new Label();
            panel3 = new Panel();
            btnBola = new Button();
            btnPar = new Button();
            panel4 = new Panel();
            btnCamiseta = new Button();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            btnCesto = new Button();
            panel6 = new Panel();
            pnlCancelado = new Panel();
            rbtnCancelado = new RadioButton();
            pnlEntregue = new Panel();
            rbtnEntregue = new RadioButton();
            pnlEmAndamento = new Panel();
            rbtnEmAndamento = new RadioButton();
            pnlSolicitado = new Panel();
            rbtnSolicitado = new RadioButton();
            lblCancelado = new Label();
            lblEntregue = new Label();
            lblAprovado = new Label();
            lblEmAndamento = new Label();
            lblStatusPedido = new Label();
            button1 = new Button();
            panel7 = new Panel();
            lblBola = new Label();
            pbxBola = new PictureBox();
            panel8 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel9 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel10 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCancelado.SuspendLayout();
            pnlEntregue.SuspendLayout();
            pnlEmAndamento.SuspendLayout();
            pnlSolicitado.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBola).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(262, 187);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 2);
            panel1.TabIndex = 78;
            // 
            // lblConsultadePedidos
            // 
            lblConsultadePedidos.AutoSize = true;
            lblConsultadePedidos.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConsultadePedidos.ForeColor = Color.FromArgb(255, 122, 0);
            lblConsultadePedidos.Location = new Point(325, 84);
            lblConsultadePedidos.Name = "lblConsultadePedidos";
            lblConsultadePedidos.Size = new Size(597, 69);
            lblConsultadePedidos.TabIndex = 77;
            lblConsultadePedidos.Text = "Consulta de Pedidos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(pnlCancelado);
            panel2.Controls.Add(btnCesto);
            panel2.Controls.Add(pnlEntregue);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(pnlEmAndamento);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCamiseta);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(pnlSolicitado);
            panel2.Controls.Add(btnPar);
            panel2.Controls.Add(lblCancelado);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lblEntregue);
            panel2.Controls.Add(btnBola);
            panel2.Controls.Add(lblAprovado);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(lblEmAndamento);
            panel2.Controls.Add(IblItens);
            panel2.Controls.Add(lblKitdeBasquete);
            panel2.Controls.Add(lblStatusPedido);
            panel2.Location = new Point(138, 260);
            panel2.Name = "panel2";
            panel2.Size = new Size(1180, 748);
            panel2.TabIndex = 79;
            panel2.Paint += panel2_Paint;
            // 
            // lblKitdeBasquete
            // 
            lblKitdeBasquete.AutoSize = true;
            lblKitdeBasquete.BackColor = Color.FromArgb(0, 15, 255, 255);
            lblKitdeBasquete.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKitdeBasquete.ForeColor = Color.FromArgb(42, 97, 141);
            lblKitdeBasquete.Location = new Point(374, 45);
            lblKitdeBasquete.Name = "lblKitdeBasquete";
            lblKitdeBasquete.Size = new Size(260, 46);
            lblKitdeBasquete.TabIndex = 0;
            lblKitdeBasquete.Text = "Kit de Basquete";
            // 
            // IblItens
            // 
            IblItens.AutoEllipsis = true;
            IblItens.AutoSize = true;
            IblItens.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IblItens.ForeColor = Color.FromArgb(255, 122, 0);
            IblItens.Location = new Point(72, 151);
            IblItens.Name = "IblItens";
            IblItens.Size = new Size(345, 41);
            IblItens.TabIndex = 1;
            IblItens.Text = "Itens incluso no pedido:";
            IblItens.UseWaitCursor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 122, 0);
            panel3.ForeColor = SystemColors.ControlDarkDark;
            panel3.Location = new Point(91, 225);
            panel3.Name = "panel3";
            panel3.Size = new Size(45, 22);
            panel3.TabIndex = 2;
            // 
            // btnBola
            // 
            btnBola.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnBola.ForeColor = Color.FromArgb(42, 97, 141);
            btnBola.Location = new Point(154, 211);
            btnBola.Name = "btnBola";
            btnBola.Size = new Size(263, 74);
            btnBola.TabIndex = 3;
            btnBola.Text = "Bola de Basquete Oficial - Tamanho 7";
            btnBola.TextAlign = ContentAlignment.TopLeft;
            btnBola.UseVisualStyleBackColor = true;
            btnBola.Click += btnBola_Click;
            // 
            // btnPar
            // 
            btnPar.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnPar.ForeColor = Color.FromArgb(42, 97, 141);
            btnPar.Location = new Point(156, 454);
            btnPar.Name = "btnPar";
            btnPar.Size = new Size(263, 74);
            btnPar.TabIndex = 5;
            btnPar.Text = "Camiseta Regata de Basquete Masculina";
            btnPar.TextAlign = ContentAlignment.TopLeft;
            btnPar.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 122, 0);
            panel4.ForeColor = SystemColors.ControlDarkDark;
            panel4.Location = new Point(91, 464);
            panel4.Name = "panel4";
            panel4.Size = new Size(45, 22);
            panel4.TabIndex = 4;
            // 
            // btnCamiseta
            // 
            btnCamiseta.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnCamiseta.ForeColor = Color.FromArgb(42, 97, 141);
            btnCamiseta.Location = new Point(502, 211);
            btnCamiseta.Name = "btnCamiseta";
            btnCamiseta.Size = new Size(263, 74);
            btnCamiseta.TabIndex = 7;
            btnCamiseta.Text = "Par de Tênis de Basquete";
            btnCamiseta.TextAlign = ContentAlignment.TopLeft;
            btnCamiseta.UseVisualStyleBackColor = true;
            btnCamiseta.Click += btnCamiseta_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 122, 0);
            panel5.ForeColor = SystemColors.ControlDarkDark;
            panel5.Location = new Point(439, 225);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 22);
            panel5.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(837, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 324);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnCesto
            // 
            btnCesto.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btnCesto.ForeColor = Color.FromArgb(42, 97, 141);
            btnCesto.Location = new Point(502, 432);
            btnCesto.Name = "btnCesto";
            btnCesto.Size = new Size(263, 74);
            btnCesto.TabIndex = 10;
            btnCesto.Text = "Cesto de Basquete Portátil com Suporte";
            btnCesto.TextAlign = ContentAlignment.TopLeft;
            btnCesto.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 122, 0);
            panel6.ForeColor = SystemColors.ControlDarkDark;
            panel6.Location = new Point(439, 442);
            panel6.Name = "panel6";
            panel6.Size = new Size(45, 22);
            panel6.TabIndex = 9;
            // 
            // pnlCancelado
            // 
            pnlCancelado.BackColor = Color.Red;
            pnlCancelado.Controls.Add(rbtnCancelado);
            pnlCancelado.Location = new Point(555, 713);
            pnlCancelado.Margin = new Padding(3, 4, 3, 4);
            pnlCancelado.Name = "pnlCancelado";
            pnlCancelado.Size = new Size(40, 24);
            pnlCancelado.TabIndex = 92;
            // 
            // rbtnCancelado
            // 
            rbtnCancelado.AutoSize = true;
            rbtnCancelado.Location = new Point(3, 3);
            rbtnCancelado.Margin = new Padding(3, 4, 3, 4);
            rbtnCancelado.Name = "rbtnCancelado";
            rbtnCancelado.Size = new Size(17, 16);
            rbtnCancelado.TabIndex = 36;
            rbtnCancelado.TabStop = true;
            rbtnCancelado.UseVisualStyleBackColor = true;
            // 
            // pnlEntregue
            // 
            pnlEntregue.BackColor = Color.Lime;
            pnlEntregue.Controls.Add(rbtnEntregue);
            pnlEntregue.Location = new Point(425, 713);
            pnlEntregue.Margin = new Padding(3, 4, 3, 4);
            pnlEntregue.Name = "pnlEntregue";
            pnlEntregue.Size = new Size(40, 24);
            pnlEntregue.TabIndex = 91;
            // 
            // rbtnEntregue
            // 
            rbtnEntregue.AutoSize = true;
            rbtnEntregue.Location = new Point(3, 3);
            rbtnEntregue.Margin = new Padding(3, 4, 3, 4);
            rbtnEntregue.Name = "rbtnEntregue";
            rbtnEntregue.Size = new Size(17, 16);
            rbtnEntregue.TabIndex = 36;
            rbtnEntregue.TabStop = true;
            rbtnEntregue.UseVisualStyleBackColor = true;
            // 
            // pnlEmAndamento
            // 
            pnlEmAndamento.BackColor = Color.Yellow;
            pnlEmAndamento.Controls.Add(rbtnEmAndamento);
            pnlEmAndamento.Location = new Point(264, 713);
            pnlEmAndamento.Margin = new Padding(3, 4, 3, 4);
            pnlEmAndamento.Name = "pnlEmAndamento";
            pnlEmAndamento.Size = new Size(40, 24);
            pnlEmAndamento.TabIndex = 90;
            // 
            // rbtnEmAndamento
            // 
            rbtnEmAndamento.AutoSize = true;
            rbtnEmAndamento.Location = new Point(3, 3);
            rbtnEmAndamento.Margin = new Padding(3, 4, 3, 4);
            rbtnEmAndamento.Name = "rbtnEmAndamento";
            rbtnEmAndamento.Size = new Size(17, 16);
            rbtnEmAndamento.TabIndex = 36;
            rbtnEmAndamento.TabStop = true;
            rbtnEmAndamento.UseVisualStyleBackColor = true;
            // 
            // pnlSolicitado
            // 
            pnlSolicitado.BackColor = Color.FromArgb(128, 128, 255);
            pnlSolicitado.Controls.Add(rbtnSolicitado);
            pnlSolicitado.Location = new Point(141, 713);
            pnlSolicitado.Margin = new Padding(3, 4, 3, 4);
            pnlSolicitado.Name = "pnlSolicitado";
            pnlSolicitado.Size = new Size(40, 24);
            pnlSolicitado.TabIndex = 87;
            NewMethod();
            // 
            // rbtnSolicitado
            // 
            rbtnSolicitado.AutoSize = true;
            rbtnSolicitado.Location = new Point(3, 3);
            rbtnSolicitado.Margin = new Padding(3, 4, 3, 4);
            rbtnSolicitado.Name = "rbtnSolicitado";
            rbtnSolicitado.Size = new Size(17, 16);
            rbtnSolicitado.TabIndex = 36;
            rbtnSolicitado.TabStop = true;
            rbtnSolicitado.UseVisualStyleBackColor = true;
            // 
            // lblCancelado
            // 
            lblCancelado.AutoSize = true;
            lblCancelado.Font = new Font("Microsoft Sans Serif", 9F);
            lblCancelado.ForeColor = Color.FromArgb(42, 97, 141);
            lblCancelado.Location = new Point(601, 717);
            lblCancelado.Name = "lblCancelado";
            lblCancelado.Size = new Size(79, 18);
            lblCancelado.TabIndex = 86;
            lblCancelado.Text = "Cancelado";
            // 
            // lblEntregue
            // 
            lblEntregue.AutoSize = true;
            lblEntregue.Font = new Font("Microsoft Sans Serif", 9F);
            lblEntregue.ForeColor = Color.FromArgb(42, 97, 141);
            lblEntregue.Location = new Point(471, 714);
            lblEntregue.Name = "lblEntregue";
            lblEntregue.Size = new Size(67, 18);
            lblEntregue.TabIndex = 85;
            lblEntregue.Text = "Entregue";
            // 
            // lblAprovado
            // 
            lblAprovado.AutoSize = true;
            lblAprovado.Font = new Font("Microsoft Sans Serif", 9F);
            lblAprovado.ForeColor = Color.FromArgb(42, 97, 141);
            lblAprovado.Location = new Point(187, 717);
            lblAprovado.Name = "lblAprovado";
            lblAprovado.Size = new Size(71, 18);
            lblAprovado.TabIndex = 84;
            lblAprovado.Text = "Aprovado";
            lblAprovado.Click += lblAprovado_Click;
            // 
            // lblEmAndamento
            // 
            lblEmAndamento.AutoSize = true;
            lblEmAndamento.Font = new Font("Microsoft Sans Serif", 9F);
            lblEmAndamento.ForeColor = Color.FromArgb(42, 97, 141);
            lblEmAndamento.Location = new Point(310, 715);
            lblEmAndamento.Name = "lblEmAndamento";
            lblEmAndamento.Size = new Size(109, 18);
            lblEmAndamento.TabIndex = 83;
            lblEmAndamento.Text = "Em andamento";
            // 
            // lblStatusPedido
            // 
            lblStatusPedido.AutoSize = true;
            lblStatusPedido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusPedido.ForeColor = Color.FromArgb(42, 97, 141);
            lblStatusPedido.Location = new Point(72, 714);
            lblStatusPedido.Name = "lblStatusPedido";
            lblStatusPedido.Size = new Size(57, 20);
            lblStatusPedido.TabIndex = 80;
            lblStatusPedido.Text = "Status:";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1047, 951);
            button1.Name = "button1";
            button1.Size = new Size(316, 88);
            button1.TabIndex = 94;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.Controls.Add(pbxBola);
            panel7.Controls.Add(lblBola);
            panel7.Location = new Point(91, 291);
            panel7.Name = "panel7";
            panel7.Size = new Size(328, 125);
            panel7.TabIndex = 93;
            // 
            // lblBola
            // 
            lblBola.AutoSize = true;
            lblBola.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBola.Location = new Point(121, 28);
            lblBola.Name = "lblBola";
            lblBola.Size = new Size(204, 75);
            lblBola.TabIndex = 0;
            lblBola.Text = "Marca: Wilson\nMaterial: Couro sintético\nQuantidade: 2 unidades";
            lblBola.Visible = false;
            // 
            // pbxBola
            // 
            pbxBola.Image = (Image)resources.GetObject("pbxBola.Image");
            pbxBola.Location = new Point(16, 15);
            pbxBola.Name = "pbxBola";
            pbxBola.Size = new Size(99, 97);
            pbxBola.TabIndex = 1;
            pbxBola.TabStop = false;
            pbxBola.Visible = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(label2);
            panel8.Controls.Add(label1);
            panel8.Controls.Add(pictureBox2);
            panel8.Location = new Point(439, 291);
            panel8.Name = "panel8";
            panel8.Size = new Size(328, 125);
            panel8.TabIndex = 94;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(19, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(115, 112);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(142, 19);
            label1.Name = "label1";
            label1.Size = new Size(183, 23);
            label1.TabIndex = 2;
            label1.Text = "Marca: Adidas Harden ";
            label1.Visible = false;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 41);
            label2.Name = "label2";
            label2.Size = new Size(178, 69);
            label2.TabIndex = 3;
            label2.Text = "Stepback\nTamanhos: 40, 42 , 43 \nQuantidade: 5 pares";
            label2.Visible = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox3);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(91, 539);
            panel9.Name = "panel9";
            panel9.Size = new Size(328, 125);
            panel9.TabIndex = 94;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(5, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(116, 110);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 13);
            label3.Name = "label3";
            label3.Size = new Size(201, 100);
            label3.TabIndex = 0;
            label3.Text = "Marca: Nike\nTamanho: G\nCor: Amarelo\nQuantidade: 5 unidades";
            label3.Visible = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(label4);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(pictureBox4);
            panel10.Location = new Point(439, 539);
            panel10.Name = "panel10";
            panel10.Size = new Size(328, 125);
            panel10.TabIndex = 95;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(5, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(105, 104);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(115, 52);
            label5.Name = "label5";
            label5.Size = new Size(210, 46);
            label5.TabIndex = 2;
            label5.Text = "Altura regulável até 3,05m\nQuantidade: 1 unidade";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(113, 29);
            label4.Name = "label4";
            label4.Size = new Size(196, 23);
            label4.TabIndex = 3;
            label4.Text = "Marca:  Xalingo Multicor";
            label4.Visible = false;
            // 
            // FrmConsultadePedidos3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 1051);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblConsultadePedidos);
            Name = "FrmConsultadePedidos3";
            Text = "FrmConsultadePedidos3";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCancelado.ResumeLayout(false);
            pnlCancelado.PerformLayout();
            pnlEntregue.ResumeLayout(false);
            pnlEntregue.PerformLayout();
            pnlEmAndamento.ResumeLayout(false);
            pnlEmAndamento.PerformLayout();
            pnlSolicitado.ResumeLayout(false);
            pnlSolicitado.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBola).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            pnlSolicitado.Paint += this.pnlSolicitado.Paint;
        }

        #endregion

        private Panel panel1;
        private Label lblConsultadePedidos;
        private Panel panel2;
        private Panel panel3;
        private Label IblItens;
        private Label lblKitdeBasquete;
        private PictureBox pictureBox1;
        private Button btnCamiseta;
        private Panel panel5;
        private Button btnPar;
        private Panel panel4;
        private Button btnBola;
        private Button btnCesto;
        private Panel panel6;
        private Panel pnlCancelado;
        private RadioButton rbtnCancelado;
        private Panel pnlEntregue;
        private RadioButton rbtnEntregue;
        private Panel pnlEmAndamento;
        private RadioButton rbtnEmAndamento;
        private Panel pnlSolicitado;
        private RadioButton rbtnSolicitado;
        private Label lblCancelado;
        private Label lblEntregue;
        private Label lblAprovado;
        private Label lblEmAndamento;
        private Label lblStatusPedido;
        private Button button1;
        private Panel panel7;
        private Label lblBola;
        private PictureBox pbxBola;
        private Panel panel8;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private Panel panel9;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel panel10;
        private Label label5;
        private PictureBox pictureBox4;
        private Label label4;
    }
}
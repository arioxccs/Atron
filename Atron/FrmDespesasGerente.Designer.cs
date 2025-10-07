namespace Atron
{
    partial class FrmDespesasGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDespesasGerente));
            lbl_DespesasTitulo = new Label();
            textBox1 = new TextBox();
            btn_CadastrarDespesa = new Button();
            lbl_DespesaTotalValor = new Label();
            panelDespesaTotal = new Panel();
            lbl_DespesaTotal = new Label();
            btn_ImprimirRelatorioDespesa = new Button();
            panelDespesaPaga = new Panel();
            lbl_DespesaPago = new Label();
            lbl_DespesaPagoValor = new Label();
            panelDespesaPendente = new Panel();
            lbl_DespesaPendente = new Label();
            lbl_DespesaPendenteValor = new Label();
            panelpanelDespesaAtrasada = new Panel();
            lbl_DespesaAtrasada = new Label();
            lbl_DespesaAtrasadaValor = new Label();
            lbl_DespesaAtrasadaTitulo = new Label();
            panelDespesa = new Panel();
            lbl_FormaPgtoDespesa = new Label();
            pictureBox3 = new PictureBox();
            lbl_FormaPagamento = new Label();
            pictureBox2 = new PictureBox();
            lbl_NomeDespesa = new Label();
            lbl_DataDespesa = new Label();
            pictureBox1 = new PictureBox();
            btn_PagarDespesa = new Button();
            panelDespesaTotal.SuspendLayout();
            panelDespesaPaga.SuspendLayout();
            panelDespesaPendente.SuspendLayout();
            panelpanelDespesaAtrasada.SuspendLayout();
            panelDespesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_DespesasTitulo
            // 
            lbl_DespesasTitulo.AutoSize = true;
            lbl_DespesasTitulo.Font = new Font("ST-Komsomol", 80.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesasTitulo.Location = new Point(404, -60);
            lbl_DespesasTitulo.Name = "lbl_DespesasTitulo";
            lbl_DespesasTitulo.Size = new Size(437, 172);
            lbl_DespesasTitulo.TabIndex = 0;
            lbl_DespesasTitulo.Text = "Despesas";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Lato", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(34, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(749, 46);
            textBox1.TabIndex = 1;
            // 
            // btn_CadastrarDespesa
            // 
            btn_CadastrarDespesa.BackColor = Color.FromArgb(247, 193, 143);
            btn_CadastrarDespesa.FlatAppearance.BorderSize = 0;
            btn_CadastrarDespesa.FlatStyle = FlatStyle.Flat;
            btn_CadastrarDespesa.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CadastrarDespesa.ForeColor = Color.FromArgb(14, 41, 184);
            btn_CadastrarDespesa.Image = (Image)resources.GetObject("btn_CadastrarDespesa.Image");
            btn_CadastrarDespesa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_CadastrarDespesa.Location = new Point(803, 144);
            btn_CadastrarDespesa.Name = "btn_CadastrarDespesa";
            btn_CadastrarDespesa.Padding = new Padding(6, 0, 5, 0);
            btn_CadastrarDespesa.Size = new Size(240, 50);
            btn_CadastrarDespesa.TabIndex = 2;
            btn_CadastrarDespesa.Text = "Cadastrar Despesa";
            btn_CadastrarDespesa.TextAlign = ContentAlignment.MiddleRight;
            btn_CadastrarDespesa.UseVisualStyleBackColor = false;
            btn_CadastrarDespesa.Click += btn_CadastrarDespesa_Click;
            // 
            // lbl_DespesaTotalValor
            // 
            lbl_DespesaTotalValor.AutoSize = true;
            lbl_DespesaTotalValor.Font = new Font("Bebas Neue", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaTotalValor.Location = new Point(35, 33);
            lbl_DespesaTotalValor.Name = "lbl_DespesaTotalValor";
            lbl_DespesaTotalValor.Size = new Size(228, 100);
            lbl_DespesaTotalValor.TabIndex = 3;
            lbl_DespesaTotalValor.Text = "R$1000";
            // 
            // panelDespesaTotal
            // 
            panelDespesaTotal.BackColor = Color.FromArgb(147, 223, 250);
            panelDespesaTotal.Controls.Add(lbl_DespesaTotal);
            panelDespesaTotal.Controls.Add(lbl_DespesaTotalValor);
            panelDespesaTotal.Location = new Point(34, 248);
            panelDespesaTotal.Name = "panelDespesaTotal";
            panelDespesaTotal.Size = new Size(266, 133);
            panelDespesaTotal.TabIndex = 4;
            panelDespesaTotal.Paint += panel1_Paint;
            // 
            // lbl_DespesaTotal
            // 
            lbl_DespesaTotal.AutoSize = true;
            lbl_DespesaTotal.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaTotal.Location = new Point(0, 0);
            lbl_DespesaTotal.Name = "lbl_DespesaTotal";
            lbl_DespesaTotal.Size = new Size(87, 48);
            lbl_DespesaTotal.TabIndex = 4;
            lbl_DespesaTotal.Text = "Total";
            // 
            // btn_ImprimirRelatorioDespesa
            // 
            btn_ImprimirRelatorioDespesa.BackColor = Color.FromArgb(247, 193, 143);
            btn_ImprimirRelatorioDespesa.FlatAppearance.BorderSize = 0;
            btn_ImprimirRelatorioDespesa.FlatStyle = FlatStyle.Flat;
            btn_ImprimirRelatorioDespesa.Font = new Font("Lato", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_ImprimirRelatorioDespesa.ForeColor = Color.FromArgb(14, 41, 184);
            btn_ImprimirRelatorioDespesa.Image = (Image)resources.GetObject("btn_ImprimirRelatorioDespesa.Image");
            btn_ImprimirRelatorioDespesa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ImprimirRelatorioDespesa.Location = new Point(1049, 144);
            btn_ImprimirRelatorioDespesa.Name = "btn_ImprimirRelatorioDespesa";
            btn_ImprimirRelatorioDespesa.Padding = new Padding(6, 0, 5, 0);
            btn_ImprimirRelatorioDespesa.Size = new Size(240, 50);
            btn_ImprimirRelatorioDespesa.TabIndex = 5;
            btn_ImprimirRelatorioDespesa.Text = "Imprimir Relatório";
            btn_ImprimirRelatorioDespesa.TextAlign = ContentAlignment.MiddleRight;
            btn_ImprimirRelatorioDespesa.UseVisualStyleBackColor = false;
            // 
            // panelDespesaPaga
            // 
            panelDespesaPaga.BackColor = Color.FromArgb(147, 223, 250);
            panelDespesaPaga.Controls.Add(lbl_DespesaPago);
            panelDespesaPaga.Controls.Add(lbl_DespesaPagoValor);
            panelDespesaPaga.Location = new Point(356, 248);
            panelDespesaPaga.Name = "panelDespesaPaga";
            panelDespesaPaga.Size = new Size(266, 133);
            panelDespesaPaga.TabIndex = 5;
            // 
            // lbl_DespesaPago
            // 
            lbl_DespesaPago.AutoSize = true;
            lbl_DespesaPago.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaPago.Location = new Point(0, 0);
            lbl_DespesaPago.Name = "lbl_DespesaPago";
            lbl_DespesaPago.Size = new Size(77, 48);
            lbl_DespesaPago.TabIndex = 4;
            lbl_DespesaPago.Text = "Pago";
            lbl_DespesaPago.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_DespesaPagoValor
            // 
            lbl_DespesaPagoValor.AutoSize = true;
            lbl_DespesaPagoValor.Font = new Font("Bebas Neue", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaPagoValor.Location = new Point(38, 33);
            lbl_DespesaPagoValor.Name = "lbl_DespesaPagoValor";
            lbl_DespesaPagoValor.Size = new Size(197, 100);
            lbl_DespesaPagoValor.TabIndex = 3;
            lbl_DespesaPagoValor.Text = "R$500";
            lbl_DespesaPagoValor.Click += label4_Click;
            // 
            // panelDespesaPendente
            // 
            panelDespesaPendente.BackColor = Color.FromArgb(147, 223, 250);
            panelDespesaPendente.Controls.Add(lbl_DespesaPendente);
            panelDespesaPendente.Controls.Add(lbl_DespesaPendenteValor);
            panelDespesaPendente.Location = new Point(678, 248);
            panelDespesaPendente.Name = "panelDespesaPendente";
            panelDespesaPendente.Size = new Size(266, 133);
            panelDespesaPendente.TabIndex = 6;
            // 
            // lbl_DespesaPendente
            // 
            lbl_DespesaPendente.AutoSize = true;
            lbl_DespesaPendente.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaPendente.Location = new Point(0, 0);
            lbl_DespesaPendente.Name = "lbl_DespesaPendente";
            lbl_DespesaPendente.Size = new Size(133, 48);
            lbl_DespesaPendente.TabIndex = 4;
            lbl_DespesaPendente.Text = "Pendente";
            // 
            // lbl_DespesaPendenteValor
            // 
            lbl_DespesaPendenteValor.AutoSize = true;
            lbl_DespesaPendenteValor.Font = new Font("Bebas Neue", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaPendenteValor.Location = new Point(38, 33);
            lbl_DespesaPendenteValor.Name = "lbl_DespesaPendenteValor";
            lbl_DespesaPendenteValor.Size = new Size(197, 100);
            lbl_DespesaPendenteValor.TabIndex = 3;
            lbl_DespesaPendenteValor.Text = "R$300";
            // 
            // panelpanelDespesaAtrasada
            // 
            panelpanelDespesaAtrasada.BackColor = Color.FromArgb(147, 223, 250);
            panelpanelDespesaAtrasada.Controls.Add(lbl_DespesaAtrasada);
            panelpanelDespesaAtrasada.Controls.Add(lbl_DespesaAtrasadaValor);
            panelpanelDespesaAtrasada.Location = new Point(993, 248);
            panelpanelDespesaAtrasada.Name = "panelpanelDespesaAtrasada";
            panelpanelDespesaAtrasada.Size = new Size(266, 133);
            panelpanelDespesaAtrasada.TabIndex = 7;
            // 
            // lbl_DespesaAtrasada
            // 
            lbl_DespesaAtrasada.AutoSize = true;
            lbl_DespesaAtrasada.Font = new Font("Bebas Neue", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaAtrasada.Location = new Point(0, 0);
            lbl_DespesaAtrasada.Name = "lbl_DespesaAtrasada";
            lbl_DespesaAtrasada.Size = new Size(135, 48);
            lbl_DespesaAtrasada.TabIndex = 4;
            lbl_DespesaAtrasada.Text = "Atrasada";
            // 
            // lbl_DespesaAtrasadaValor
            // 
            lbl_DespesaAtrasadaValor.AutoSize = true;
            lbl_DespesaAtrasadaValor.Font = new Font("Bebas Neue", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaAtrasadaValor.Location = new Point(38, 33);
            lbl_DespesaAtrasadaValor.Name = "lbl_DespesaAtrasadaValor";
            lbl_DespesaAtrasadaValor.Size = new Size(197, 100);
            lbl_DespesaAtrasadaValor.TabIndex = 3;
            lbl_DespesaAtrasadaValor.Text = "R$200";
            // 
            // lbl_DespesaAtrasadaTitulo
            // 
            lbl_DespesaAtrasadaTitulo.AutoSize = true;
            lbl_DespesaAtrasadaTitulo.Font = new Font("Bebas Neue", 69.74999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaAtrasadaTitulo.Location = new Point(18, 401);
            lbl_DespesaAtrasadaTitulo.Name = "lbl_DespesaAtrasadaTitulo";
            lbl_DespesaAtrasadaTitulo.Size = new Size(375, 121);
            lbl_DespesaAtrasadaTitulo.TabIndex = 8;
            lbl_DespesaAtrasadaTitulo.Text = "Atrasadas";
            lbl_DespesaAtrasadaTitulo.Click += lbl_DespesaAtrasadaTitulo_Click;
            // 
            // panelDespesa
            // 
            panelDespesa.BackColor = Color.FromArgb(247, 193, 143);
            panelDespesa.Controls.Add(btn_PagarDespesa);
            panelDespesa.Controls.Add(lbl_FormaPgtoDespesa);
            panelDespesa.Controls.Add(pictureBox3);
            panelDespesa.Controls.Add(lbl_FormaPagamento);
            panelDespesa.Controls.Add(pictureBox2);
            panelDespesa.Controls.Add(lbl_NomeDespesa);
            panelDespesa.Controls.Add(lbl_DataDespesa);
            panelDespesa.Controls.Add(pictureBox1);
            panelDespesa.Location = new Point(60, 514);
            panelDespesa.Name = "panelDespesa";
            panelDespesa.Size = new Size(1190, 80);
            panelDespesa.TabIndex = 9;
            panelDespesa.Paint += panel1_Paint_1;
            // 
            // lbl_FormaPgtoDespesa
            // 
            lbl_FormaPgtoDespesa.AutoSize = true;
            lbl_FormaPgtoDespesa.Font = new Font("Lato", 24.75F);
            lbl_FormaPgtoDespesa.Location = new Point(849, 21);
            lbl_FormaPgtoDespesa.Name = "lbl_FormaPgtoDespesa";
            lbl_FormaPgtoDespesa.Size = new Size(114, 40);
            lbl_FormaPgtoDespesa.TabIndex = 6;
            lbl_FormaPgtoDespesa.Text = "R$100";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(833, -12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 92);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // lbl_FormaPagamento
            // 
            lbl_FormaPagamento.AutoSize = true;
            lbl_FormaPagamento.Font = new Font("Lato", 24.75F);
            lbl_FormaPagamento.Location = new Point(743, 21);
            lbl_FormaPagamento.Name = "lbl_FormaPagamento";
            lbl_FormaPagamento.Size = new Size(84, 40);
            lbl_FormaPagamento.TabIndex = 4;
            lbl_FormaPagamento.Text = "Pgto";
            lbl_FormaPagamento.Click += lbl_FormaPagamento_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(710, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 92);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_NomeDespesa
            // 
            lbl_NomeDespesa.AutoSize = true;
            lbl_NomeDespesa.Font = new Font("Lato", 24.75F);
            lbl_NomeDespesa.Location = new Point(210, 21);
            lbl_NomeDespesa.Name = "lbl_NomeDespesa";
            lbl_NomeDespesa.Size = new Size(139, 40);
            lbl_NomeDespesa.TabIndex = 2;
            lbl_NomeDespesa.Text = "Despesa";
            // 
            // lbl_DataDespesa
            // 
            lbl_DataDespesa.AutoSize = true;
            lbl_DataDespesa.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DataDespesa.Location = new Point(9, 21);
            lbl_DataDespesa.Name = "lbl_DataDespesa";
            lbl_DataDespesa.Size = new Size(163, 33);
            lbl_DataDespesa.TabIndex = 1;
            lbl_DataDespesa.Text = "01/01/2025";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(178, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_PagarDespesa
            // 
            btn_PagarDespesa.BackColor = Color.FromArgb(14, 41, 184);
            btn_PagarDespesa.FlatStyle = FlatStyle.Flat;
            btn_PagarDespesa.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_PagarDespesa.ForeColor = Color.White;
            btn_PagarDespesa.Location = new Point(1028, 21);
            btn_PagarDespesa.Name = "btn_PagarDespesa";
            btn_PagarDespesa.Size = new Size(140, 44);
            btn_PagarDespesa.TabIndex = 7;
            btn_PagarDespesa.Text = "Pagar";
            btn_PagarDespesa.UseVisualStyleBackColor = false;
            btn_PagarDespesa.Click += btn_PagarDespesa_Click;
            // 
            // FrmDespesasGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1296, 788);
            Controls.Add(panelDespesa);
            Controls.Add(lbl_DespesaAtrasadaTitulo);
            Controls.Add(panelpanelDespesaAtrasada);
            Controls.Add(panelDespesaPendente);
            Controls.Add(panelDespesaPaga);
            Controls.Add(btn_ImprimirRelatorioDespesa);
            Controls.Add(panelDespesaTotal);
            Controls.Add(btn_CadastrarDespesa);
            Controls.Add(textBox1);
            Controls.Add(lbl_DespesasTitulo);
            ForeColor = Color.FromArgb(14, 41, 184);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDespesasGerente";
            Text = "FrmDespesasGerente";
            panelDespesaTotal.ResumeLayout(false);
            panelDespesaTotal.PerformLayout();
            panelDespesaPaga.ResumeLayout(false);
            panelDespesaPaga.PerformLayout();
            panelDespesaPendente.ResumeLayout(false);
            panelDespesaPendente.PerformLayout();
            panelpanelDespesaAtrasada.ResumeLayout(false);
            panelpanelDespesaAtrasada.PerformLayout();
            panelDespesa.ResumeLayout(false);
            panelDespesa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_DespesasTitulo;
        private TextBox textBox1;
        private Button btn_CadastrarDespesa;
        private Label lbl_DespesaTotalValor;
        private Panel panelDespesaTotal;
        private Button btn_ImprimirRelatorioDespesa;
        private Panel panelDespesaPaga;
        private Label lbl_DespesaPago;
        private Label lbl_DespesaTotal;
        private Label lbl_DespesaPagoValor;
        private Panel panelDespesaPendente;
        private Label lbl_DespesaPendente;
        private Label lbl_DespesaPendenteValor;
        private Panel panelpanelDespesaAtrasada;
        private Label lbl_DespesaAtrasada;
        private Label lbl_DespesaAtrasadaValor;
        private Label lbl_DespesaAtrasadaTitulo;
        private Panel panelDespesa;
        private PictureBox pictureBox1;
        private Label lbl_FormaPgtoDespesa;
        private PictureBox pictureBox3;
        private Label lbl_FormaPagamento;
        private PictureBox pictureBox2;
        private Label lbl_NomeDespesa;
        private Label lbl_DataDespesa;
        private Button btn_PagarDespesa;
    }
}
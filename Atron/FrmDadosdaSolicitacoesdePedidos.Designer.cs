namespace Atron
{
    partial class FrmDadosdaSolicitacoesdePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDadosdaSolicitacoesdePedidos));
            lblDadosdaSolicitacaoDePedidos = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            lblMeia = new Label();
            lblMarca = new Label();
            lblCor = new Label();
            lblValor = new Label();
            lblDataSoliciacao = new Label();
            lblInfData = new Label();
            lblPrevisaoEntrega = new Label();
            lblInfPrevisao = new Label();
            btnDados = new Button();
            lblQuant = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            button2 = new Button();
            pnlVazio = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            pictureBox10 = new PictureBox();
            textBox1 = new TextBox();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // lblDadosdaSolicitacaoDePedidos
            // 
            lblDadosdaSolicitacaoDePedidos.AutoSize = true;
            lblDadosdaSolicitacaoDePedidos.Font = new Font("Lato Black", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDadosdaSolicitacaoDePedidos.ForeColor = Color.FromArgb(255, 122, 0);
            lblDadosdaSolicitacaoDePedidos.Location = new Point(94, 33);
            lblDadosdaSolicitacaoDePedidos.Name = "lblDadosdaSolicitacaoDePedidos";
            lblDadosdaSolicitacaoDePedidos.Size = new Size(389, 25);
            lblDadosdaSolicitacaoDePedidos.TabIndex = 0;
            lblDadosdaSolicitacaoDePedidos.Text = "DADOS DA SOLICITAÇÃO DE PEDIDOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(59, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 2);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(248, 252, 255);
            panel2.Controls.Add(lblQuant);
            panel2.Controls.Add(lblInfPrevisao);
            panel2.Controls.Add(lblPrevisaoEntrega);
            panel2.Controls.Add(lblInfData);
            panel2.Controls.Add(lblDataSoliciacao);
            panel2.Controls.Add(lblValor);
            panel2.Controls.Add(lblCor);
            panel2.Controls.Add(lblMarca);
            panel2.Controls.Add(lblMeia);
            panel2.Controls.Add(btnDados);
            panel2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(68, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(271, 122);
            panel2.TabIndex = 3;
            // 
            // lblMeia
            // 
            lblMeia.AutoSize = true;
            lblMeia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMeia.ForeColor = Color.FromArgb(255, 122, 0);
            lblMeia.ImageAlign = ContentAlignment.TopLeft;
            lblMeia.Location = new Point(9, 10);
            lblMeia.Name = "lblMeia";
            lblMeia.Size = new Size(115, 18);
            lblMeia.TabIndex = 1;
            lblMeia.Text = "Meia Cano Alto";
            lblMeia.Click += lblMeia_Click;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.ForeColor = Color.FromArgb(30, 79, 119);
            lblMarca.Location = new Point(9, 36);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(84, 17);
            lblMarca.TabIndex = 4;
            lblMarca.Text = "Marca: Puma\n";
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.ForeColor = Color.FromArgb(30, 79, 119);
            lblCor.Location = new Point(9, 51);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(67, 17);
            lblCor.TabIndex = 5;
            lblCor.Text = "Cor: Preto";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.ForeColor = Color.FromArgb(194, 94, 0);
            lblValor.Location = new Point(9, 95);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(97, 17);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor: R$ xxx,xx";
            // 
            // lblDataSoliciacao
            // 
            lblDataSoliciacao.AutoSize = true;
            lblDataSoliciacao.ForeColor = Color.FromArgb(30, 79, 119);
            lblDataSoliciacao.Location = new Point(144, 11);
            lblDataSoliciacao.Name = "lblDataSoliciacao";
            lblDataSoliciacao.Size = new Size(123, 17);
            lblDataSoliciacao.TabIndex = 7;
            lblDataSoliciacao.Text = "Data da Solicitação:";
            lblDataSoliciacao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInfData
            // 
            lblInfData.AutoSize = true;
            lblInfData.Location = new Point(201, 26);
            lblInfData.Name = "lblInfData";
            lblInfData.Size = new Size(60, 17);
            lblInfData.TabIndex = 8;
            lblInfData.Text = "02/03/25";
            // 
            // lblPrevisaoEntrega
            // 
            lblPrevisaoEntrega.AutoSize = true;
            lblPrevisaoEntrega.ForeColor = Color.FromArgb(30, 79, 119);
            lblPrevisaoEntrega.Location = new Point(140, 51);
            lblPrevisaoEntrega.Name = "lblPrevisaoEntrega";
            lblPrevisaoEntrega.Size = new Size(128, 17);
            lblPrevisaoEntrega.TabIndex = 9;
            lblPrevisaoEntrega.Text = "Previsão de Entrega:";
            lblPrevisaoEntrega.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInfPrevisao
            // 
            lblInfPrevisao.AutoSize = true;
            lblInfPrevisao.Location = new Point(207, 68);
            lblInfPrevisao.Name = "lblInfPrevisao";
            lblInfPrevisao.Size = new Size(60, 17);
            lblInfPrevisao.TabIndex = 9;
            lblInfPrevisao.Text = "01/04/25";
            lblInfPrevisao.Click += label2_Click;
            // 
            // btnDados
            // 
            btnDados.BackColor = Color.FromArgb(255, 122, 0);
            btnDados.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDados.ForeColor = Color.White;
            btnDados.Location = new Point(192, 95);
            btnDados.Name = "btnDados";
            btnDados.Size = new Size(75, 23);
            btnDados.TabIndex = 0;
            btnDados.Text = "DADOS";
            btnDados.UseVisualStyleBackColor = false;
            // 
            // lblQuant
            // 
            lblQuant.AutoSize = true;
            lblQuant.ForeColor = Color.FromArgb(30, 79, 119);
            lblQuant.Location = new Point(9, 68);
            lblQuant.Name = "lblQuant";
            lblQuant.Size = new Size(105, 17);
            lblQuant.TabIndex = 10;
            lblQuant.Text = "Quantidade:  40 ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(248, 252, 255);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(button1);
            panel3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(366, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 122);
            panel3.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(30, 79, 119);
            label1.Location = new Point(9, 68);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 10;
            label1.Text = "Quantidade:  40 ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 68);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 9;
            label2.Text = "01/04/25";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(30, 79, 119);
            label3.Location = new Point(140, 51);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 9;
            label3.Text = "Previsão de Entrega:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 26);
            label4.Name = "label4";
            label4.Size = new Size(60, 17);
            label4.TabIndex = 8;
            label4.Text = "02/03/25";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(30, 79, 119);
            label5.Location = new Point(144, 11);
            label5.Name = "label5";
            label5.Size = new Size(123, 17);
            label5.TabIndex = 7;
            label5.Text = "Data da Solicitação:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(194, 94, 0);
            label6.Location = new Point(9, 95);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 6;
            label6.Text = "Valor: R$ xxx,xx";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(30, 79, 119);
            label7.Location = new Point(9, 51);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 5;
            label7.Text = "Cor: Preto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(30, 79, 119);
            label8.Location = new Point(9, 36);
            label8.Name = "label8";
            label8.Size = new Size(84, 17);
            label8.TabIndex = 4;
            label8.Text = "Marca: Puma\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 122, 0);
            label9.ImageAlign = ContentAlignment.TopLeft;
            label9.Location = new Point(9, 10);
            label9.Name = "label9";
            label9.Size = new Size(115, 18);
            label9.TabIndex = 1;
            label9.Text = "Meia Cano Alto";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 122, 0);
            button1.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(192, 95);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "DADOS";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(248, 252, 255);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(button2);
            panel4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(68, 230);
            panel4.Name = "panel4";
            panel4.Size = new Size(271, 122);
            panel4.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(30, 79, 119);
            label10.Location = new Point(9, 68);
            label10.Name = "label10";
            label10.Size = new Size(105, 17);
            label10.TabIndex = 10;
            label10.Text = "Quantidade:  40 ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(207, 68);
            label11.Name = "label11";
            label11.Size = new Size(60, 17);
            label11.TabIndex = 9;
            label11.Text = "01/04/25";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(30, 79, 119);
            label12.Location = new Point(140, 51);
            label12.Name = "label12";
            label12.Size = new Size(128, 17);
            label12.TabIndex = 9;
            label12.Text = "Previsão de Entrega:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(201, 26);
            label13.Name = "label13";
            label13.Size = new Size(60, 17);
            label13.TabIndex = 8;
            label13.Text = "02/03/25";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(30, 79, 119);
            label14.Location = new Point(144, 11);
            label14.Name = "label14";
            label14.Size = new Size(123, 17);
            label14.TabIndex = 7;
            label14.Text = "Data da Solicitação:";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.FromArgb(194, 94, 0);
            label15.Location = new Point(9, 95);
            label15.Name = "label15";
            label15.Size = new Size(97, 17);
            label15.TabIndex = 6;
            label15.Text = "Valor: R$ xxx,xx";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(30, 79, 119);
            label16.Location = new Point(9, 51);
            label16.Name = "label16";
            label16.Size = new Size(67, 17);
            label16.TabIndex = 5;
            label16.Text = "Cor: Preto";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(30, 79, 119);
            label17.Location = new Point(9, 36);
            label17.Name = "label17";
            label17.Size = new Size(84, 17);
            label17.TabIndex = 4;
            label17.Text = "Marca: Puma\n";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(255, 122, 0);
            label18.ImageAlign = ContentAlignment.TopLeft;
            label18.Location = new Point(9, 10);
            label18.Name = "label18";
            label18.Size = new Size(115, 18);
            label18.TabIndex = 1;
            label18.Text = "Meia Cano Alto";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 122, 0);
            button2.Font = new Font("Lato Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(192, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "DADOS";
            button2.UseVisualStyleBackColor = false;
            // 
            // pnlVazio
            // 
            pnlVazio.BackColor = Color.FromArgb(230, 225, 225);
            pnlVazio.Location = new Point(366, 230);
            pnlVazio.Name = "pnlVazio";
            pnlVazio.Size = new Size(271, 122);
            pnlVazio.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(230, 225, 225);
            panel5.Location = new Point(68, 368);
            panel5.Name = "panel5";
            panel5.Size = new Size(271, 122);
            panel5.TabIndex = 14;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(230, 225, 225);
            panel6.Location = new Point(366, 368);
            panel6.Name = "panel6";
            panel6.Size = new Size(271, 122);
            panel6.TabIndex = 14;
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.White;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(753, 12);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(25, 22);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 25;
            pictureBox10.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(558, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 24;
            textBox1.Text = "Pesquisar Produto";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.White;
            btnVoltar.Image = (Image)resources.GetObject("btnVoltar.Image");
            btnVoltar.Location = new Point(42, 658);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(185, 68);
            btnVoltar.TabIndex = 26;
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FrmDadosdaSolicitacoesdePedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 749);
            Controls.Add(btnVoltar);
            Controls.Add(pictureBox10);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(textBox1);
            Controls.Add(pnlVazio);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblDadosdaSolicitacaoDePedidos);
            Name = "FrmDadosdaSolicitacoesdePedidos";
            Text = "FrmDadosdaSolicitacoesdePedidos";
            Load += FrmDadosdaSolicitacoesdePedidos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDadosdaSolicitacaoDePedidos;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label lblMeia;
        private Label lblInfPrevisao;
        private Label lblPrevisaoEntrega;
        private Label lblInfData;
        private Label lblDataSoliciacao;
        private Label lblValor;
        private Label lblCor;
        private Label lblMarca;
        private Button btnDados;
        private Label lblQuant;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private Panel panel4;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Button button2;
        private Panel pnlVazio;
        private Panel panel5;
        private Panel panel6;
        private PictureBox pictureBox10;
        private TextBox textBox1;
        private Button btnVoltar;
    }
}
namespace Atron
{
    partial class FrmGerenciamentoRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciamentoRegistros));
            lbl_GerenciamentodeRegistros = new Label();
            btnNovoPedido = new Button();
            btNovoProduto = new Button();
            btnEntradaEstoque = new Button();
            label1 = new Label();
            panel_entradaNoEstoque = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            label8 = new Label();
            label9 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            label11 = new Label();
            panel5 = new Panel();
            label12 = new Label();
            label13 = new Label();
            panel6 = new Panel();
            label14 = new Label();
            label15 = new Label();
            panel7 = new Panel();
            label16 = new Label();
            label17 = new Label();
            panel8 = new Panel();
            label18 = new Label();
            label19 = new Label();
            panel9 = new Panel();
            label20 = new Label();
            label21 = new Label();
            panel10 = new Panel();
            label22 = new Label();
            label23 = new Label();
            panel_entradaNoEstoque.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_GerenciamentodeRegistros
            // 
            lbl_GerenciamentodeRegistros.AutoSize = true;
            lbl_GerenciamentodeRegistros.Font = new Font("Microsoft Sans Serif", 51.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_GerenciamentodeRegistros.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_GerenciamentodeRegistros.Location = new Point(12, 18);
            lbl_GerenciamentodeRegistros.Name = "lbl_GerenciamentodeRegistros";
            lbl_GerenciamentodeRegistros.Size = new Size(908, 79);
            lbl_GerenciamentodeRegistros.TabIndex = 0;
            lbl_GerenciamentodeRegistros.Text = "Gerenciamento de Registros";
            // 
            // btnNovoPedido
            // 
            btnNovoPedido.BackColor = Color.FromArgb(75, 193, 196);
            btnNovoPedido.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovoPedido.ForeColor = Color.White;
            btnNovoPedido.Image = (Image)resources.GetObject("btnNovoPedido.Image");
            btnNovoPedido.ImageAlign = ContentAlignment.BottomRight;
            btnNovoPedido.Location = new Point(34, 136);
            btnNovoPedido.Name = "btnNovoPedido";
            btnNovoPedido.Size = new Size(385, 285);
            btnNovoPedido.TabIndex = 1;
            btnNovoPedido.Text = "Novo Pedido";
            btnNovoPedido.TextAlign = ContentAlignment.TopLeft;
            btnNovoPedido.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNovoPedido.UseVisualStyleBackColor = false;
            btnNovoPedido.Click += button1_Click;
            // 
            // btNovoProduto
            // 
            btNovoProduto.BackColor = Color.FromArgb(194, 91, 184);
            btNovoProduto.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNovoProduto.ForeColor = Color.White;
            btNovoProduto.Image = (Image)resources.GetObject("btNovoProduto.Image");
            btNovoProduto.ImageAlign = ContentAlignment.BottomRight;
            btNovoProduto.Location = new Point(425, 136);
            btNovoProduto.Name = "btNovoProduto";
            btNovoProduto.Size = new Size(385, 285);
            btNovoProduto.TabIndex = 2;
            btNovoProduto.Text = "Novo Produto";
            btNovoProduto.TextAlign = ContentAlignment.TopLeft;
            btNovoProduto.TextImageRelation = TextImageRelation.TextBeforeImage;
            btNovoProduto.UseVisualStyleBackColor = false;
            btNovoProduto.Click += button2_Click;
            // 
            // btnEntradaEstoque
            // 
            btnEntradaEstoque.BackColor = Color.FromArgb(91, 103, 194);
            btnEntradaEstoque.Font = new Font("Microsoft Sans Serif", 39.7499924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEntradaEstoque.ForeColor = Color.White;
            btnEntradaEstoque.Image = (Image)resources.GetObject("btnEntradaEstoque.Image");
            btnEntradaEstoque.ImageAlign = ContentAlignment.BottomRight;
            btnEntradaEstoque.Location = new Point(816, 136);
            btnEntradaEstoque.Name = "btnEntradaEstoque";
            btnEntradaEstoque.Size = new Size(385, 285);
            btnEntradaEstoque.TabIndex = 3;
            btnEntradaEstoque.Text = "Entrada no estoque";
            btnEntradaEstoque.TextAlign = ContentAlignment.TopLeft;
            btnEntradaEstoque.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnEntradaEstoque.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 53, 87);
            label1.Location = new Point(50, 458);
            label1.Name = "label1";
            label1.Size = new Size(471, 37);
            label1.TabIndex = 4;
            label1.Text = "Entradas no estoque recentes";
            label1.Click += label1_Click;
            // 
            // panel_entradaNoEstoque
            // 
            panel_entradaNoEstoque.BorderStyle = BorderStyle.FixedSingle;
            panel_entradaNoEstoque.Controls.Add(label3);
            panel_entradaNoEstoque.Controls.Add(label2);
            panel_entradaNoEstoque.Location = new Point(50, 520);
            panel_entradaNoEstoque.Name = "panel_entradaNoEstoque";
            panel_entradaNoEstoque.Size = new Size(250, 95);
            panel_entradaNoEstoque.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(99, 131, 157);
            label3.Location = new Point(13, 61);
            label3.Name = "label3";
            label3.Size = new Size(92, 14);
            label3.TabIndex = 1;
            label3.Text = "Marca: Adidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 122, 0);
            label2.Location = new Point(13, 16);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(227, 38);
            label2.TabIndex = 0;
            label2.Text = "Camisa Preta";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(329, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 95);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(99, 131, 157);
            label4.Location = new Point(18, 61);
            label4.Name = "label4";
            label4.Size = new Size(92, 14);
            label4.TabIndex = 2;
            label4.Text = "Marca: Adidas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 122, 0);
            label6.Location = new Point(18, 16);
            label6.Name = "label6";
            label6.Size = new Size(204, 33);
            label6.TabIndex = 0;
            label6.Text = "Camisa Preta";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(604, 520);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 95);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(99, 131, 157);
            label5.Location = new Point(18, 61);
            label5.Name = "label5";
            label5.Size = new Size(92, 14);
            label5.TabIndex = 2;
            label5.Text = "Marca: Adidas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(255, 122, 0);
            label7.Location = new Point(18, 16);
            label7.Name = "label7";
            label7.Size = new Size(204, 33);
            label7.TabIndex = 0;
            label7.Text = "Camisa Preta";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(882, 520);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 95);
            panel3.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(99, 131, 157);
            label8.Location = new Point(18, 61);
            label8.Name = "label8";
            label8.Size = new Size(92, 14);
            label8.TabIndex = 2;
            label8.Text = "Marca: Adidas";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(255, 122, 0);
            label9.Location = new Point(18, 16);
            label9.Name = "label9";
            label9.Size = new Size(204, 33);
            label9.TabIndex = 0;
            label9.Text = "Camisa Preta";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(50, 642);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 95);
            panel4.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(99, 131, 157);
            label10.Location = new Point(18, 61);
            label10.Name = "label10";
            label10.Size = new Size(92, 14);
            label10.TabIndex = 2;
            label10.Text = "Marca: Adidas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(255, 122, 0);
            label11.Location = new Point(18, 16);
            label11.Name = "label11";
            label11.Size = new Size(204, 33);
            label11.TabIndex = 0;
            label11.Text = "Camisa Preta";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label13);
            panel5.Location = new Point(-1, -1);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 95);
            panel5.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(99, 131, 157);
            label12.Location = new Point(18, 61);
            label12.Name = "label12";
            label12.Size = new Size(78, 14);
            label12.TabIndex = 2;
            label12.Text = "Marca: Vollo";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(255, 122, 0);
            label13.Location = new Point(18, 16);
            label13.Name = "label13";
            label13.Size = new Size(213, 33);
            label13.TabIndex = 0;
            label13.Text = "Corda de PVC";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label15);
            panel6.Location = new Point(329, 642);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 95);
            panel6.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(99, 131, 157);
            label14.Location = new Point(18, 61);
            label14.Name = "label14";
            label14.Size = new Size(92, 14);
            label14.TabIndex = 2;
            label14.Text = "Marca: Adidas";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(255, 122, 0);
            label15.Location = new Point(18, 16);
            label15.Name = "label15";
            label15.Size = new Size(204, 33);
            label15.TabIndex = 0;
            label15.Text = "Camisa Preta";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(-1, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 95);
            panel7.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(99, 131, 157);
            label16.Location = new Point(18, 61);
            label16.Name = "label16";
            label16.Size = new Size(78, 14);
            label16.TabIndex = 2;
            label16.Text = "Marca: Vollo";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(255, 122, 0);
            label17.Location = new Point(18, 16);
            label17.Name = "label17";
            label17.Size = new Size(213, 33);
            label17.TabIndex = 0;
            label17.Text = "Corda de PVC";
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(panel9);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(label19);
            panel8.Location = new Point(604, 642);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 95);
            panel8.TabIndex = 11;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(99, 131, 157);
            label18.Location = new Point(18, 61);
            label18.Name = "label18";
            label18.Size = new Size(92, 14);
            label18.TabIndex = 2;
            label18.Text = "Marca: Adidas";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(255, 122, 0);
            label19.Location = new Point(18, 16);
            label19.Name = "label19";
            label19.Size = new Size(204, 33);
            label19.TabIndex = 0;
            label19.Text = "Camisa Preta";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(label20);
            panel9.Controls.Add(label21);
            panel9.Location = new Point(-1, -1);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 95);
            panel9.TabIndex = 7;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(99, 131, 157);
            label20.Location = new Point(18, 61);
            label20.Name = "label20";
            label20.Size = new Size(78, 14);
            label20.TabIndex = 2;
            label20.Text = "Marca: Vollo";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(255, 122, 0);
            label21.Location = new Point(18, 16);
            label21.Name = "label21";
            label21.Size = new Size(213, 33);
            label21.TabIndex = 0;
            label21.Text = "Corda de PVC";
            // 
            // panel10
            // 
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(label22);
            panel10.Controls.Add(label23);
            panel10.Location = new Point(882, 642);
            panel10.Name = "panel10";
            panel10.Size = new Size(250, 95);
            panel10.TabIndex = 12;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(99, 131, 157);
            label22.Location = new Point(18, 61);
            label22.Name = "label22";
            label22.Size = new Size(78, 14);
            label22.TabIndex = 2;
            label22.Text = "Marca: Vollo";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(255, 122, 0);
            label23.Location = new Point(18, 16);
            label23.Name = "label23";
            label23.Size = new Size(213, 33);
            label23.TabIndex = 0;
            label23.Text = "Corda de PVC";
            // 
            // FrmGerenciamentoRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 749);
            Controls.Add(panel10);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel_entradaNoEstoque);
            Controls.Add(label1);
            Controls.Add(btnEntradaEstoque);
            Controls.Add(btNovoProduto);
            Controls.Add(btnNovoPedido);
            Controls.Add(lbl_GerenciamentodeRegistros);
            Name = "FrmGerenciamentoRegistros";
            Text = "FrmGerenciamentoRegistros";
            Load += FrmGerenciamentoRegistros_Load;
            panel_entradaNoEstoque.ResumeLayout(false);
            panel_entradaNoEstoque.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_GerenciamentodeRegistros;
        private Button btnNovoPedido;
        private Button btNovoProduto;
        private Button btnEntradaEstoque;
        private Label label1;
        private Panel panel_entradaNoEstoque;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label6;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Label label9;
        private Panel panel4;
        private Panel panel5;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label11;
        private Panel panel6;
        private Panel panel7;
        private Label label16;
        private Label label17;
        private Label label14;
        private Label label15;
        private Panel panel8;
        private Panel panel9;
        private Label label20;
        private Label label21;
        private Label label18;
        private Label label19;
        private Panel panel10;
        private Label label22;
        private Label label23;
    }
}
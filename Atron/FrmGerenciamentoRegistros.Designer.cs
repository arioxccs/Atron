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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            panel_entradaNoEstoque = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel_entradaNoEstoque.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_GerenciamentodeRegistros
            // 
            lbl_GerenciamentodeRegistros.AutoSize = true;
            lbl_GerenciamentodeRegistros.Font = new Font("Microsoft Sans Serif", 51.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_GerenciamentodeRegistros.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_GerenciamentodeRegistros.Location = new Point(14, 24);
            lbl_GerenciamentodeRegistros.Name = "lbl_GerenciamentodeRegistros";
            lbl_GerenciamentodeRegistros.Size = new Size(1145, 98);
            lbl_GerenciamentodeRegistros.TabIndex = 0;
            lbl_GerenciamentodeRegistros.Text = "Gerenciamento de Registros";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(75, 193, 196);
            button1.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(39, 181);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(440, 380);
            button1.TabIndex = 1;
            button1.Text = "Novo Pedido";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(194, 91, 184);
            button2.Font = new Font("Microsoft Sans Serif", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomRight;
            button2.Location = new Point(486, 181);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(440, 380);
            button2.TabIndex = 2;
            button2.Text = "Novo Produto";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(91, 103, 194);
            button3.Font = new Font("Microsoft Sans Serif", 39.7499924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomRight;
            button3.Location = new Point(933, 181);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(440, 380);
            button3.TabIndex = 3;
            button3.Text = "Entrada no estoque";
            button3.TextAlign = ContentAlignment.TopLeft;
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(10, 53, 87);
            label1.Location = new Point(57, 611);
            label1.Name = "label1";
            label1.Size = new Size(559, 46);
            label1.TabIndex = 4;
            label1.Text = "Entradas no estoque recente";
            // 
            // panel_entradaNoEstoque
            // 
            panel_entradaNoEstoque.BorderStyle = BorderStyle.FixedSingle;
            panel_entradaNoEstoque.Controls.Add(label3);
            panel_entradaNoEstoque.Controls.Add(label2);
            panel_entradaNoEstoque.Location = new Point(57, 693);
            panel_entradaNoEstoque.Margin = new Padding(3, 4, 3, 4);
            panel_entradaNoEstoque.Name = "panel_entradaNoEstoque";
            panel_entradaNoEstoque.Size = new Size(285, 126);
            panel_entradaNoEstoque.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(99, 131, 157);
            label3.Location = new Point(27, 81);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 1;
            label3.Text = "Adidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 122, 0);
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(285, 48);
            label2.TabIndex = 0;
            label2.Text = "Camisa Preta";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(379, 693);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 126);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(99, 131, 157);
            label4.Location = new Point(27, 81);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 1;
            label4.Text = "Adidas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 122, 0);
            label6.Location = new Point(17, 21);
            label6.Name = "label6";
            label6.Size = new Size(285, 48);
            label6.TabIndex = 0;
            label6.Text = "Camisa Preta";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 122, 0);
            label5.Location = new Point(27, 21);
            label5.Name = "label5";
            label5.Size = new Size(265, 57);
            label5.TabIndex = 0;
            label5.Text = "Camisa Preta";
            // 
            // FrmGerenciamentoRegistros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 1051);
            Controls.Add(panel1);
            Controls.Add(panel_entradaNoEstoque);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_GerenciamentodeRegistros);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmGerenciamentoRegistros";
            Text = "FrmGerenciamentoRegistros";
            panel_entradaNoEstoque.ResumeLayout(false);
            panel_entradaNoEstoque.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_GerenciamentodeRegistros;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Panel panel_entradaNoEstoque;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private Label label6;
        private Label label5;
    }
}
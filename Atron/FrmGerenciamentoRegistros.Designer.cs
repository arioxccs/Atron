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
            lbl_GerenciamentodeRegistros.Location = new Point(12, 18);
            lbl_GerenciamentodeRegistros.Name = "lbl_GerenciamentodeRegistros";
            lbl_GerenciamentodeRegistros.Size = new Size(908, 79);
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
            button1.Location = new Point(34, 136);
            button1.Name = "button1";
            button1.Size = new Size(385, 285);
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
            button2.Location = new Point(425, 136);
            button2.Name = "button2";
            button2.Size = new Size(385, 285);
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
            button3.Location = new Point(816, 136);
            button3.Name = "button3";
            button3.Size = new Size(385, 285);
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
            label1.Location = new Point(50, 458);
            label1.Name = "label1";
            label1.Size = new Size(454, 37);
            label1.TabIndex = 4;
            label1.Text = "Entradas no estoque recente";
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
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(99, 131, 157);
            label3.Location = new Point(24, 61);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 1;
            label3.Text = "Adidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 122, 0);
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
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
            panel1.Controls.Add(label5);
            panel1.Location = new Point(332, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 95);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(99, 131, 157);
            label4.Location = new Point(24, 61);
            label4.Name = "label4";
            label4.Size = new Size(39, 16);
            label4.TabIndex = 1;
            label4.Text = "Adidas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(255, 122, 0);
            label6.Location = new Point(15, 16);
            label6.Name = "label6";
            label6.Size = new Size(227, 38);
            label6.TabIndex = 0;
            label6.Text = "Camisa Preta";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(255, 122, 0);
            label5.Location = new Point(24, 16);
            label5.Name = "label5";
            label5.Size = new Size(207, 45);
            label5.TabIndex = 0;
            label5.Text = "Camisa Preta";
            // 
            // FrmGerenciamentoRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 788);
            Controls.Add(panel1);
            Controls.Add(panel_entradaNoEstoque);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_GerenciamentodeRegistros);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGerenciamentoRegistros";
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
namespace Atron
{
    partial class FrmConsultadeProdutos2
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
            lblCodProduto = new Label();
            lblBoladeBasquete = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            lblConsultadeProdutos = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblCodProduto
            // 
            lblCodProduto.AutoSize = true;
            lblCodProduto.BackColor = Color.FromArgb(255, 200, 130);
            lblCodProduto.Font = new Font("Arial Narrow", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCodProduto.ForeColor = Color.Gray;
            lblCodProduto.Location = new Point(215, 448);
            lblCodProduto.Name = "lblCodProduto";
            lblCodProduto.Size = new Size(206, 29);
            lblCodProduto.TabIndex = 63;
            lblCodProduto.Text = "Código do produto: 43";
            // 
            // lblBoladeBasquete
            // 
            lblBoladeBasquete.AutoSize = true;
            lblBoladeBasquete.BackColor = Color.FromArgb(255, 200, 130);
            lblBoladeBasquete.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBoladeBasquete.ForeColor = Color.FromArgb(42, 97, 141);
            lblBoladeBasquete.Location = new Point(215, 412);
            lblBoladeBasquete.Name = "lblBoladeBasquete";
            lblBoladeBasquete.Size = new Size(250, 27);
            lblBoladeBasquete.TabIndex = 62;
            lblBoladeBasquete.Text = "BOLA DE BASQUETE";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 200, 130);
            textBox1.Location = new Point(162, 382);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(837, 134);
            textBox1.TabIndex = 61;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 200, 130);
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(215, 249);
            label1.Name = "label1";
            label1.Size = new Size(206, 29);
            label1.TabIndex = 66;
            label1.Text = "Código do produto: 43";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 200, 130);
            label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(42, 97, 141);
            label2.Location = new Point(215, 213);
            label2.Name = "label2";
            label2.Size = new Size(250, 27);
            label2.TabIndex = 65;
            label2.Text = "BOLA DE BASQUETE";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 200, 130);
            textBox2.Location = new Point(162, 183);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(837, 134);
            textBox2.TabIndex = 64;
            // 
            // lblConsultadeProdutos
            // 
            lblConsultadeProdutos.AutoSize = true;
            lblConsultadeProdutos.Font = new Font("Lato Black", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConsultadeProdutos.ForeColor = Color.FromArgb(255, 122, 0);
            lblConsultadeProdutos.Location = new Point(347, 46);
            lblConsultadeProdutos.Name = "lblConsultadeProdutos";
            lblConsultadeProdutos.Size = new Size(496, 57);
            lblConsultadeProdutos.TabIndex = 67;
            lblConsultadeProdutos.Text = "Consulta de Produtos";
            // 
            // panel1
            // 
            panel1.Location = new Point(321, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 2);
            panel1.TabIndex = 68;
            // 
            // FrmConsultadeProdutos2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 788);
            Controls.Add(panel1);
            Controls.Add(lblConsultadeProdutos);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(lblCodProduto);
            Controls.Add(lblBoladeBasquete);
            Controls.Add(textBox1);
            Name = "FrmConsultadeProdutos2";
            Text = "FrmConsultadeProdutos2";
            WindowState = FormWindowState.Maximized;
            Load += FrmConsultadeProdutos2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodProduto;
        private Label lblBoladeBasquete;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label lblConsultadeProdutos;
        private Panel panel1;
    }
}
namespace Atron
{
    partial class FrmConsultadeProdutos3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultadeProdutos3));
            panel1 = new Panel();
            lblConsultadeProdutos = new Label();
            panel2 = new Panel();
            lblBoladeBasquete = new Label();
            lblCategoria = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblQuantidade = new Label();
            lblPreco = new Label();
            lblCodProduto = new Label();
            label5 = new Label();
            lblMarca = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnVoltar = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(399, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 2);
            panel1.TabIndex = 44;
            // 
            // lblConsultadeProdutos
            // 
            lblConsultadeProdutos.AutoSize = true;
            lblConsultadeProdutos.Font = new Font("Lato Black", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConsultadeProdutos.ForeColor = Color.FromArgb(255, 122, 0);
            lblConsultadeProdutos.Location = new Point(428, 72);
            lblConsultadeProdutos.Name = "lblConsultadeProdutos";
            lblConsultadeProdutos.Size = new Size(357, 42);
            lblConsultadeProdutos.TabIndex = 43;
            lblConsultadeProdutos.Text = "Consulta de Produtos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(251, 251, 251);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblMarca);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblCodProduto);
            panel2.Controls.Add(lblPreco);
            panel2.Controls.Add(lblQuantidade);
            panel2.Controls.Add(lblCategoria);
            panel2.Controls.Add(lblBoladeBasquete);
            panel2.Location = new Point(180, 197);
            panel2.Name = "panel2";
            panel2.Size = new Size(863, 353);
            panel2.TabIndex = 45;
            // 
            // lblBoladeBasquete
            // 
            lblBoladeBasquete.AutoSize = true;
            lblBoladeBasquete.BackColor = Color.FromArgb(251, 251, 251);
            lblBoladeBasquete.Font = new Font("Arial", 20.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblBoladeBasquete.ForeColor = Color.FromArgb(42, 97, 141);
            lblBoladeBasquete.Location = new Point(65, 43);
            lblBoladeBasquete.Name = "lblBoladeBasquete";
            lblBoladeBasquete.Size = new Size(229, 32);
            lblBoladeBasquete.TabIndex = 66;
            lblBoladeBasquete.Text = "Bola de Basquete";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.FromArgb(251, 251, 251);
            lblCategoria.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.Gray;
            lblCategoria.Location = new Point(65, 116);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(192, 27);
            lblCategoria.TabIndex = 67;
            lblCategoria.Text = "• Categoria: Bola";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.FromArgb(251, 251, 251);
            lblQuantidade.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantidade.ForeColor = Color.Gray;
            lblQuantidade.Location = new Point(65, 158);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(193, 27);
            lblQuantidade.TabIndex = 68;
            lblQuantidade.Text = "• Quantidade: 34";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.FromArgb(251, 251, 251);
            lblPreco.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPreco.ForeColor = Color.Gray;
            lblPreco.Location = new Point(65, 202);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(205, 27);
            lblPreco.TabIndex = 69;
            lblPreco.Text = "• Preço: R$235,00";
            // 
            // lblCodProduto
            // 
            lblCodProduto.AutoSize = true;
            lblCodProduto.BackColor = Color.FromArgb(251, 251, 251);
            lblCodProduto.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodProduto.ForeColor = Color.Gray;
            lblCodProduto.Location = new Point(65, 249);
            lblCodProduto.Name = "lblCodProduto";
            lblCodProduto.Size = new Size(269, 27);
            lblCodProduto.TabIndex = 70;
            lblCodProduto.Text = "• Código do Produto: 43";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(251, 251, 251);
            label5.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(338, 116);
            label5.Name = "label5";
            label5.Size = new Size(281, 27);
            label5.TabIndex = 71;
            label5.Text = "• Fornecedor: Altro Estral";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.BackColor = Color.FromArgb(251, 251, 251);
            lblMarca.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.ForeColor = Color.Gray;
            lblMarca.Location = new Point(338, 168);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(179, 27);
            lblMarca.TabIndex = 71;
            lblMarca.Text = "• Marca: Wilson";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(251, 251, 251);
            label4.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(338, 216);
            label4.Name = "label4";
            label4.Size = new Size(366, 27);
            label4.TabIndex = 72;
            label4.Text = "• Estoque dísponivel:23 produtos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(659, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(255, 122, 0);
            btnVoltar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(499, 519);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(213, 61);
            btnVoltar.TabIndex = 75;
            btnVoltar.Text = "Voltar à tela inicial";
            btnVoltar.UseVisualStyleBackColor = false;
            // 
            // FrmConsultadeProdutos3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 788);
            Controls.Add(btnVoltar);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblConsultadeProdutos);
            Name = "FrmConsultadeProdutos3";
            Text = "FrmConsultadeProdutos3";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblConsultadeProdutos;
        private Panel panel2;
        private Label lblBoladeBasquete;
        private Label lblCategoria;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblQuantidade;
        private Label lblMarca;
        private Label label5;
        private Label lblCodProduto;
        private Label lblPreco;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnVoltar;
    }
}
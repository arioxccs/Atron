namespace Atron
{
    partial class FrmConsultaProdutos1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaProdutos1));
            lblConsultadeProdutos = new Label();
            txtNomeProduto = new TextBox();
            lblNomeDoProduto = new Label();
            btnPesquisar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblConsultadeProdutos
            // 
            lblConsultadeProdutos.AutoSize = true;
            lblConsultadeProdutos.Font = new Font("Segoe UI", 30F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConsultadeProdutos.ForeColor = Color.FromArgb(255, 122, 0);
            lblConsultadeProdutos.Location = new Point(381, 100);
            lblConsultadeProdutos.Name = "lblConsultadeProdutos";
            lblConsultadeProdutos.Size = new Size(512, 67);
            lblConsultadeProdutos.TabIndex = 0;
            lblConsultadeProdutos.Text = "Consulta de Produtos:";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = Color.FromArgb(255, 200, 130);
            txtNomeProduto.Location = new Point(79, 248);
            txtNomeProduto.Multiline = true;
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(958, 72);
            txtNomeProduto.TabIndex = 1;
            txtNomeProduto.TextChanged += textBox1_TextChanged;
            // 
            // lblNomeDoProduto
            // 
            lblNomeDoProduto.AutoSize = true;
            lblNomeDoProduto.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeDoProduto.ForeColor = Color.FromArgb(42, 97, 141);
            lblNomeDoProduto.Location = new Point(69, 195);
            lblNomeDoProduto.Name = "lblNomeDoProduto";
            lblNomeDoProduto.Size = new Size(335, 50);
            lblNomeDoProduto.TabIndex = 2;
            lblNomeDoProduto.Text = "Nome do Produto:";
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(255, 200, 130);
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(962, 258);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(62, 54);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.ForeColor = Color.FromArgb(224, 224, 224);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(903, 837);
            button1.Name = "button1";
            button1.Size = new Size(254, 104);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmConsultaProdutos1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 1051);
            Controls.Add(button1);
            Controls.Add(btnPesquisar);
            Controls.Add(lblNomeDoProduto);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblConsultadeProdutos);
            Name = "FrmConsultaProdutos1";
            Text = "FrmConsultaProdutos1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultadeProdutos;
        private TextBox txtNomeProduto;
        private Label lblNomeDoProduto;
        private Button btnPesquisar;
        private Button button1;
    }
}
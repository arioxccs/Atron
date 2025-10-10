namespace Atron
{
    partial class FrmConsultadePedidos2
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
            panel1 = new Panel();
            lblConsultadeProdutos = new Label();
            btnResultPesquisa = new Button();
            label1 = new Label();
            lblPedido = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(321, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(612, 2);
            panel1.TabIndex = 76;
            // 
            // lblConsultadeProdutos
            // 
            lblConsultadeProdutos.AutoSize = true;
            lblConsultadeProdutos.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConsultadeProdutos.ForeColor = Color.FromArgb(255, 122, 0);
            lblConsultadeProdutos.Location = new Point(382, 31);
            lblConsultadeProdutos.Name = "lblConsultadeProdutos";
            lblConsultadeProdutos.Size = new Size(487, 55);
            lblConsultadeProdutos.TabIndex = 75;
            lblConsultadeProdutos.Text = "Consulta de Pedidos";
            // 
            // btnResultPesquisa
            // 
            btnResultPesquisa.BackColor = Color.FromArgb(255, 200, 130);
            btnResultPesquisa.Location = new Point(158, 188);
            btnResultPesquisa.Margin = new Padding(3, 2, 3, 2);
            btnResultPesquisa.Name = "btnResultPesquisa";
            btnResultPesquisa.Size = new Size(841, 133);
            btnResultPesquisa.TabIndex = 77;
            btnResultPesquisa.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 200, 130);
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(42, 97, 141);
            label1.Location = new Point(204, 266);
            label1.Name = "label1";
            label1.Size = new Size(208, 29);
            label1.TabIndex = 79;
            label1.Text = "Número do Pedido: 32";
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.BackColor = Color.FromArgb(255, 200, 130);
            lblPedido.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedido.ForeColor = Color.FromArgb(42, 97, 141);
            lblPedido.Location = new Point(196, 215);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(283, 27);
            lblPedido.TabIndex = 78;
            lblPedido.Text = "Pedido - Kit De Basquete";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 200, 130);
            label2.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(42, 97, 141);
            label2.Location = new Point(196, 460);
            label2.Name = "label2";
            label2.Size = new Size(208, 29);
            label2.TabIndex = 82;
            label2.Text = "Número do Pedido: 32";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 200, 130);
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(42, 97, 141);
            label3.Location = new Point(196, 401);
            label3.Name = "label3";
            label3.Size = new Size(283, 27);
            label3.TabIndex = 81;
            label3.Text = "Pedido - Kit De Basquete";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 200, 130);
            button1.Location = new Point(158, 377);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(841, 133);
            button1.TabIndex = 80;
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmConsultadePedidos2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 827);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblPedido);
            Controls.Add(btnResultPesquisa);
            Controls.Add(panel1);
            Controls.Add(lblConsultadeProdutos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmConsultadePedidos2";
            Text = "FrmConsultadePedidos2";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblConsultadeProdutos;
        private Label label2;
        private Button btnResultPesquisa;
        private Label label1;
        private Label lblPedido;
        private Label label3;
        private Button button1;
    }
}
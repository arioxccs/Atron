namespace Atron
{
    partial class FrmConsultadePedidos1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultadePedidos1));
            btnProcurar = new Button();
            btnPesquisar = new Button();
            lblNomeDoProduto = new Label();
            txtNumPedido = new TextBox();
            lblConsultadePedidos = new Label();
            button2 = new Button();
            lblFornecedor = new Label();
            txtFornecedor = new TextBox();
            SuspendLayout();
            // 
            // btnProcurar
            // 
            btnProcurar.BackColor = Color.FromArgb(224, 224, 224);
            btnProcurar.ForeColor = Color.FromArgb(224, 224, 224);
            btnProcurar.Image = (Image)resources.GetObject("btnProcurar.Image");
            btnProcurar.Location = new Point(779, 496);
            btnProcurar.Margin = new Padding(3, 2, 3, 2);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(222, 78);
            btnProcurar.TabIndex = 10;
            btnProcurar.UseVisualStyleBackColor = false;
            btnProcurar.Click += btnProcurar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(255, 200, 130);
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(839, 195);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(54, 40);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblNomeDoProduto
            // 
            lblNomeDoProduto.AutoSize = true;
            lblNomeDoProduto.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeDoProduto.ForeColor = Color.FromArgb(42, 97, 141);
            lblNomeDoProduto.Location = new Point(54, 148);
            lblNomeDoProduto.Name = "lblNomeDoProduto";
            lblNomeDoProduto.Size = new Size(285, 41);
            lblNomeDoProduto.TabIndex = 8;
            lblNomeDoProduto.Text = "Número do Pedido:";
            // 
            // txtNumPedido
            // 
            txtNumPedido.BackColor = Color.FromArgb(255, 200, 130);
            txtNumPedido.Location = new Point(63, 188);
            txtNumPedido.Margin = new Padding(3, 2, 3, 2);
            txtNumPedido.Multiline = true;
            txtNumPedido.Name = "txtNumPedido";
            txtNumPedido.Size = new Size(839, 55);
            txtNumPedido.TabIndex = 7;
            // 
            // lblConsultadePedidos
            // 
            lblConsultadePedidos.AutoSize = true;
            lblConsultadePedidos.Font = new Font("Segoe UI", 30F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConsultadePedidos.ForeColor = Color.FromArgb(255, 122, 0);
            lblConsultadePedidos.Location = new Point(327, 77);
            lblConsultadePedidos.Name = "lblConsultadePedidos";
            lblConsultadePedidos.Size = new Size(394, 54);
            lblConsultadePedidos.TabIndex = 6;
            lblConsultadePedidos.Text = "Consulta de Pedidos:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 200, 130);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(848, 318);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(54, 40);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFornecedor.ForeColor = Color.FromArgb(42, 97, 141);
            lblFornecedor.Location = new Point(63, 272);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(181, 41);
            lblFornecedor.TabIndex = 12;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(255, 200, 130);
            txtFornecedor.Location = new Point(63, 311);
            txtFornecedor.Margin = new Padding(3, 2, 3, 2);
            txtFornecedor.Multiline = true;
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(839, 55);
            txtFornecedor.TabIndex = 11;
            // 
            // FrmConsultadePedidos1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 827);
            Controls.Add(button2);
            Controls.Add(lblFornecedor);
            Controls.Add(txtFornecedor);
            Controls.Add(btnProcurar);
            Controls.Add(btnPesquisar);
            Controls.Add(lblNomeDoProduto);
            Controls.Add(txtNumPedido);
            Controls.Add(lblConsultadePedidos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmConsultadePedidos1";
            Text = "FrmConsultadePedidos1";
            WindowState = FormWindowState.Maximized;
            Load += FrmConsultadePedidos1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProcurar;
        private Button btnPesquisar;
        private Label lblNomeDoProduto;
        private TextBox txtNumPedido;
        private Label lblConsultadePedidos;
        private Button button2;
        private Label lblFornecedor;
        private TextBox txtFornecedor;
    }
}
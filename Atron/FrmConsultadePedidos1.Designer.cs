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
            btnProcurar.Location = new Point(890, 662);
            btnProcurar.Name = "btnProcurar";
            btnProcurar.Size = new Size(254, 104);
            btnProcurar.TabIndex = 10;
            btnProcurar.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(255, 200, 130);
            btnPesquisar.Image = (Image)resources.GetObject("btnPesquisar.Image");
            btnPesquisar.Location = new Point(959, 260);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(62, 54);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // lblNomeDoProduto
            // 
            lblNomeDoProduto.AutoSize = true;
            lblNomeDoProduto.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeDoProduto.ForeColor = Color.FromArgb(42, 97, 141);
            lblNomeDoProduto.Location = new Point(62, 198);
            lblNomeDoProduto.Name = "lblNomeDoProduto";
            lblNomeDoProduto.Size = new Size(351, 50);
            lblNomeDoProduto.TabIndex = 8;
            lblNomeDoProduto.Text = "Número do Pedido:";
            // 
            // txtNumPedido
            // 
            txtNumPedido.BackColor = Color.FromArgb(255, 200, 130);
            txtNumPedido.Location = new Point(72, 251);
            txtNumPedido.Multiline = true;
            txtNumPedido.Name = "txtNumPedido";
            txtNumPedido.Size = new Size(958, 72);
            txtNumPedido.TabIndex = 7;
            // 
            // lblConsultadePedidos
            // 
            lblConsultadePedidos.AutoSize = true;
            lblConsultadePedidos.Font = new Font("Segoe UI", 30F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblConsultadePedidos.ForeColor = Color.FromArgb(255, 122, 0);
            lblConsultadePedidos.Location = new Point(374, 103);
            lblConsultadePedidos.Name = "lblConsultadePedidos";
            lblConsultadePedidos.Size = new Size(486, 67);
            lblConsultadePedidos.TabIndex = 6;
            lblConsultadePedidos.Text = "Consulta de Pedidos:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 200, 130);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(969, 424);
            button2.Name = "button2";
            button2.Size = new Size(62, 54);
            button2.TabIndex = 13;
            button2.UseVisualStyleBackColor = false;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFornecedor.ForeColor = Color.FromArgb(42, 97, 141);
            lblFornecedor.Location = new Point(72, 362);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(224, 50);
            lblFornecedor.TabIndex = 12;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            txtFornecedor.BackColor = Color.FromArgb(255, 200, 130);
            txtFornecedor.Location = new Point(72, 415);
            txtFornecedor.Multiline = true;
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(958, 72);
            txtFornecedor.TabIndex = 11;
            // 
            // FrmConsultadePedidos1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 1051);
            Controls.Add(button2);
            Controls.Add(lblFornecedor);
            Controls.Add(txtFornecedor);
            Controls.Add(btnProcurar);
            Controls.Add(btnPesquisar);
            Controls.Add(lblNomeDoProduto);
            Controls.Add(txtNumPedido);
            Controls.Add(lblConsultadePedidos);
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
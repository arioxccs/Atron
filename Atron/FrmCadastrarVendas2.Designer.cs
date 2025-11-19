namespace Atron
{
    partial class FrmCadastrarVendas2
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
            panel2 = new Panel();
            lblCadastrodeVenda2 = new Label();
            panel3 = new Panel();
            btnAddOutraVenda = new Button();
            btnCancela = new Button();
            btnCadastrar = new Button();
            txtQtdeParcelas = new TextBox();
            txtFormaPgto = new TextBox();
            txtQtd = new TextBox();
            dtpData = new DateTimePicker();
            txtCodProduto = new TextBox();
            txtValorTotal = new TextBox();
            txtCodCliente = new TextBox();
            lblBaixanoEstoque = new Label();
            label3 = new Label();
            cbxCliente = new ComboBox();
            cbxProduto = new ComboBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(9, 28, 128);
            panel2.Controls.Add(lblCadastrodeVenda2);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(19, 28);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 680);
            panel2.TabIndex = 8;
            // 
            // lblCadastrodeVenda2
            // 
            lblCadastrodeVenda2.AutoSize = true;
            lblCadastrodeVenda2.Font = new Font("Microsoft Sans Serif", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCadastrodeVenda2.ForeColor = Color.White;
            lblCadastrodeVenda2.Location = new Point(47, 31);
            lblCadastrodeVenda2.Name = "lblCadastrodeVenda2";
            lblCadastrodeVenda2.Size = new Size(388, 38);
            lblCadastrodeVenda2.TabIndex = 2;
            lblCadastrodeVenda2.Text = "CADASTRO DE VENDA ";
            lblCadastrodeVenda2.Click += lblCadastrodeVenda_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(238, 238, 238);
            panel3.Controls.Add(cbxProduto);
            panel3.Controls.Add(cbxCliente);
            panel3.Controls.Add(btnAddOutraVenda);
            panel3.Controls.Add(btnCancela);
            panel3.Controls.Add(btnCadastrar);
            panel3.Controls.Add(txtQtdeParcelas);
            panel3.Controls.Add(txtFormaPgto);
            panel3.Controls.Add(txtQtd);
            panel3.Controls.Add(dtpData);
            panel3.Controls.Add(txtCodProduto);
            panel3.Controls.Add(txtValorTotal);
            panel3.Controls.Add(txtCodCliente);
            panel3.Controls.Add(lblBaixanoEstoque);
            panel3.Location = new Point(47, 88);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1017, 546);
            panel3.TabIndex = 3;
            // 
            // btnAddOutraVenda
            // 
            btnAddOutraVenda.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnAddOutraVenda.ForeColor = Color.FromArgb(0, 187, 255);
            btnAddOutraVenda.Location = new Point(60, 493);
            btnAddOutraVenda.Margin = new Padding(3, 2, 3, 2);
            btnAddOutraVenda.Name = "btnAddOutraVenda";
            btnAddOutraVenda.Size = new Size(162, 22);
            btnAddOutraVenda.TabIndex = 60;
            btnAddOutraVenda.Text = "Adicionar outra venda";
            btnAddOutraVenda.UseVisualStyleBackColor = true;
            btnAddOutraVenda.Click += btnAddOutraVenda_Click;
            // 
            // btnCancela
            // 
            btnCancela.BackColor = SystemColors.ControlLight;
            btnCancela.Font = new Font("Microsoft Sans Serif", 17F);
            btnCancela.ForeColor = Color.FromArgb(159, 0, 0);
            btnCancela.Location = new Point(535, 481);
            btnCancela.Margin = new Padding(3, 2, 3, 2);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(233, 34);
            btnCancela.TabIndex = 59;
            btnCancela.Text = "CANCELAR";
            btnCancela.TextAlign = ContentAlignment.MiddleLeft;
            btnCancela.UseVisualStyleBackColor = false;
            btnCancela.Click += btnCancela_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = SystemColors.ControlLight;
            btnCadastrar.Font = new Font("Microsoft Sans Serif", 17F);
            btnCadastrar.ForeColor = Color.FromArgb(9, 186, 0);
            btnCadastrar.Location = new Point(298, 481);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(227, 34);
            btnCadastrar.TabIndex = 58;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.TextAlign = ContentAlignment.MiddleLeft;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtQtdeParcelas
            // 
            txtQtdeParcelas.BorderStyle = BorderStyle.FixedSingle;
            txtQtdeParcelas.Font = new Font("Microsoft Sans Serif", 17F);
            txtQtdeParcelas.ForeColor = Color.FromArgb(147, 147, 147);
            txtQtdeParcelas.Location = new Point(670, 362);
            txtQtdeParcelas.Margin = new Padding(3, 2, 3, 2);
            txtQtdeParcelas.Name = "txtQtdeParcelas";
            txtQtdeParcelas.Size = new Size(278, 33);
            txtQtdeParcelas.TabIndex = 57;
            txtQtdeParcelas.Text = "QTDE. PARCELAS";
            // 
            // txtFormaPgto
            // 
            txtFormaPgto.BorderStyle = BorderStyle.FixedSingle;
            txtFormaPgto.Font = new Font("Microsoft Sans Serif", 17F);
            txtFormaPgto.ForeColor = Color.FromArgb(147, 147, 147);
            txtFormaPgto.Location = new Point(361, 362);
            txtFormaPgto.Margin = new Padding(3, 2, 3, 2);
            txtFormaPgto.Name = "txtFormaPgto";
            txtFormaPgto.Size = new Size(278, 33);
            txtFormaPgto.TabIndex = 56;
            txtFormaPgto.Text = "FORMA PGTO";
            // 
            // txtQtd
            // 
            txtQtd.BorderStyle = BorderStyle.FixedSingle;
            txtQtd.Font = new Font("Microsoft Sans Serif", 17F);
            txtQtd.ForeColor = Color.FromArgb(147, 147, 147);
            txtQtd.Location = new Point(535, 272);
            txtQtd.Margin = new Padding(3, 2, 3, 2);
            txtQtd.Name = "txtQtd";
            txtQtd.Size = new Size(413, 33);
            txtQtd.TabIndex = 55;
            txtQtd.Text = "QTDE.";
            // 
            // dtpData
            // 
            dtpData.Font = new Font("Segoe UI", 12F);
            dtpData.Location = new Point(66, 276);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(431, 29);
            dtpData.TabIndex = 48;
            // 
            // txtCodProduto
            // 
            txtCodProduto.BorderStyle = BorderStyle.FixedSingle;
            txtCodProduto.Font = new Font("Microsoft Sans Serif", 17F);
            txtCodProduto.ForeColor = Color.FromArgb(147, 147, 147);
            txtCodProduto.Location = new Point(673, 188);
            txtCodProduto.Margin = new Padding(3, 2, 3, 2);
            txtCodProduto.Name = "txtCodProduto";
            txtCodProduto.Size = new Size(275, 33);
            txtCodProduto.TabIndex = 54;
            txtCodProduto.Text = "CÓDIGO DO PRODUTO:";
            // 
            // txtValorTotal
            // 
            txtValorTotal.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotal.Font = new Font("Microsoft Sans Serif", 17F);
            txtValorTotal.ForeColor = Color.FromArgb(147, 147, 147);
            txtValorTotal.Location = new Point(60, 362);
            txtValorTotal.Margin = new Padding(3, 2, 3, 2);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(278, 33);
            txtValorTotal.TabIndex = 47;
            txtValorTotal.Text = "VALOR TOTAL";
            // 
            // txtCodCliente
            // 
            txtCodCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCodCliente.Font = new Font("Microsoft Sans Serif", 17F);
            txtCodCliente.ForeColor = Color.FromArgb(147, 147, 147);
            txtCodCliente.Location = new Point(673, 107);
            txtCodCliente.Margin = new Padding(3, 2, 3, 2);
            txtCodCliente.Name = "txtCodCliente";
            txtCodCliente.Size = new Size(275, 33);
            txtCodCliente.TabIndex = 35;
            txtCodCliente.Text = "CÓDIGO DO CLIENTE:";
            // 
            // lblBaixanoEstoque
            // 
            lblBaixanoEstoque.AutoSize = true;
            lblBaixanoEstoque.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblBaixanoEstoque.ForeColor = Color.FromArgb(121, 121, 121);
            lblBaixanoEstoque.Location = new Point(58, 29);
            lblBaixanoEstoque.Name = "lblBaixanoEstoque";
            lblBaixanoEstoque.Size = new Size(310, 36);
            lblBaixanoEstoque.TabIndex = 4;
            lblBaixanoEstoque.Text = "BAIXA NO ESTOQUE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(126, 38);
            label3.Name = "label3";
            label3.Size = new Size(294, 38);
            label3.TabIndex = 7;
            label3.Text = "Registro de Cliente";
            // 
            // cbxCliente
            // 
            cbxCliente.Font = new Font("Segoe UI", 14F);
            cbxCliente.ForeColor = Color.Gray;
            cbxCliente.FormattingEnabled = true;
            cbxCliente.Location = new Point(60, 107);
            cbxCliente.Name = "cbxCliente";
            cbxCliente.Size = new Size(592, 33);
            cbxCliente.TabIndex = 4;
            cbxCliente.Text = "CLIENTE";
            cbxCliente.SelectedIndexChanged += cbxCliente_SelectedIndexChanged;
            // 
            // cbxProduto
            // 
            cbxProduto.Font = new Font("Segoe UI", 14F);
            cbxProduto.ForeColor = Color.Gray;
            cbxProduto.FormattingEnabled = true;
            cbxProduto.Location = new Point(60, 188);
            cbxProduto.Name = "cbxProduto";
            cbxProduto.Size = new Size(592, 33);
            cbxProduto.TabIndex = 61;
            cbxProduto.Text = "PRODUTO";
            // 
            // FrmCadastrarVendas2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 749);
            Controls.Add(panel2);
            Controls.Add(label3);
            Name = "FrmCadastrarVendas2";
            Text = "FrmCadastrarVendas2";
            Load += FrmCadastrarVendas2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lblCadastrodeVenda2;
        private Panel panel3;
        private Button btnAddOutraVenda;
        private Button btnCancela;
        private Button btnCadastrar;
        private TextBox txtQtdeParcelas;
        private TextBox txtFormaPgto;
        private TextBox txtQtd;
        private DateTimePicker dtpData;
        private TextBox txtCodProduto;
        private TextBox txtValorTotal;
        private TextBox txtCodCliente;
        private Label lblBaixanoEstoque;
        private Label label3;
        private ComboBox cbxProduto;
        private ComboBox cbxCliente;
    }
}
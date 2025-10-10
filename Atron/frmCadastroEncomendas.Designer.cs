namespace Atron
{
    partial class frmCadastroEncomendas
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
            Label lblTitulo2;
            pnlFundo = new Panel();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            llbAdicionarVenda = new LinkLabel();
            txtQtdeParcelas = new TextBox();
            txtEntrada = new TextBox();
            txtValorTotal = new TextBox();
            txtQuantidade = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            cmbData = new ComboBox();
            cmbProduto = new ComboBox();
            cmbCliente = new ComboBox();
            lblTitulo1 = new Label();
            lblTitulo2 = new Label();
            pnlFundo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo2.ForeColor = Color.FromArgb(121, 121, 121);
            lblTitulo2.Location = new Point(27, 19);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(310, 36);
            lblTitulo2.TabIndex = 3;
            lblTitulo2.Text = "BAIXA NO ESTOQUE";
            // 
            // pnlFundo
            // 
            pnlFundo.BackColor = Color.FromArgb(9, 28, 128);
            pnlFundo.Controls.Add(panel1);
            pnlFundo.Controls.Add(lblTitulo1);
            pnlFundo.Location = new Point(114, 93);
            pnlFundo.Name = "pnlFundo";
            pnlFundo.Size = new Size(1270, 916);
            pnlFundo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(llbAdicionarVenda);
            panel1.Controls.Add(txtQtdeParcelas);
            panel1.Controls.Add(txtEntrada);
            panel1.Controls.Add(txtValorTotal);
            panel1.Controls.Add(txtQuantidade);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(cmbData);
            panel1.Controls.Add(cmbProduto);
            panel1.Controls.Add(cmbCliente);
            panel1.Controls.Add(lblTitulo2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(74, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 773);
            panel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 13.8F);
            btnCancelar.ForeColor = Color.FromArgb(159, 0, 0);
            btnCancelar.Location = new Point(590, 708);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 33);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ControlLight;
            btnConfirmar.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.FromArgb(9, 186, 0);
            btnConfirmar.Location = new Point(409, 708);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(163, 33);
            btnConfirmar.TabIndex = 16;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // llbAdicionarVenda
            // 
            llbAdicionarVenda.AutoSize = true;
            llbAdicionarVenda.LinkColor = Color.FromArgb(0, 187, 255);
            llbAdicionarVenda.Location = new Point(57, 714);
            llbAdicionarVenda.Name = "llbAdicionarVenda";
            llbAdicionarVenda.Size = new Size(156, 20);
            llbAdicionarVenda.TabIndex = 15;
            llbAdicionarVenda.TabStop = true;
            llbAdicionarVenda.Text = "Adicionar outra venda";
            llbAdicionarVenda.LinkClicked += llbAdicionarVenda_LinkClicked;
            // 
            // txtQtdeParcelas
            // 
            txtQtdeParcelas.BorderStyle = BorderStyle.FixedSingle;
            txtQtdeParcelas.Font = new Font("Microsoft Sans Serif", 17F);
            txtQtdeParcelas.ForeColor = Color.FromArgb(147, 147, 147);
            txtQtdeParcelas.Location = new Point(773, 580);
            txtQtdeParcelas.Name = "txtQtdeParcelas";
            txtQtdeParcelas.Size = new Size(309, 40);
            txtQtdeParcelas.TabIndex = 14;
            txtQtdeParcelas.Text = "    QTDE PARCELAS";
            // 
            // txtEntrada
            // 
            txtEntrada.BorderStyle = BorderStyle.FixedSingle;
            txtEntrada.Font = new Font("Microsoft Sans Serif", 17F);
            txtEntrada.ForeColor = Color.FromArgb(147, 147, 147);
            txtEntrada.Location = new Point(427, 580);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(309, 40);
            txtEntrada.TabIndex = 13;
            txtEntrada.Text = "    ENTRADA";
            txtEntrada.TextChanged += txtEntrada_TextChanged;
            // 
            // txtValorTotal
            // 
            txtValorTotal.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotal.Font = new Font("Microsoft Sans Serif", 17F);
            txtValorTotal.ForeColor = Color.FromArgb(147, 147, 147);
            txtValorTotal.Location = new Point(80, 580);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(309, 40);
            txtValorTotal.TabIndex = 12;
            txtValorTotal.Text = "    VALOR TOTAL";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Font = new Font("Microsoft Sans Serif", 17F);
            txtQuantidade.ForeColor = Color.FromArgb(147, 147, 147);
            txtQuantidade.Location = new Point(590, 440);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(492, 40);
            txtQuantidade.TabIndex = 11;
            txtQuantidade.Text = "    QUANTIDADE";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 17F);
            textBox2.ForeColor = Color.FromArgb(147, 147, 147);
            textBox2.Location = new Point(808, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 40);
            textBox2.TabIndex = 10;
            textBox2.Text = "    CÓDIGO DO PRODUTO";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 17F);
            textBox1.ForeColor = Color.FromArgb(147, 147, 147);
            textBox1.Location = new Point(808, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 40);
            textBox1.TabIndex = 9;
            textBox1.Text = "    CÓDIGO DO CLIENTE";
            // 
            // cmbData
            // 
            cmbData.Font = new Font("Microsoft Sans Serif", 16F);
            cmbData.ForeColor = Color.FromArgb(147, 147, 147);
            cmbData.FormattingEnabled = true;
            cmbData.Location = new Point(80, 440);
            cmbData.Name = "cmbData";
            cmbData.Size = new Size(492, 39);
            cmbData.TabIndex = 8;
            cmbData.Text = "    dd/mm/aa";
            // 
            // cmbProduto
            // 
            cmbProduto.Font = new Font("Microsoft Sans Serif", 16F);
            cmbProduto.ForeColor = Color.FromArgb(147, 147, 147);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Items.AddRange(new object[] { "Produto não encontrado, para cadastrar novo cliente clique aqui." });
            cmbProduto.Location = new Point(80, 291);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(707, 39);
            cmbProduto.TabIndex = 7;
            cmbProduto.Text = "    PRODUTO";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Microsoft Sans Serif", 18F);
            cmbCliente.ForeColor = Color.FromArgb(147, 147, 147);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Items.AddRange(new object[] { "Cliente não encontrado, para cadastrar novo cliente clique aqui." });
            cmbCliente.Location = new Point(80, 156);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(707, 44);
            cmbCliente.TabIndex = 6;
            cmbCliente.Text = "    CLIENTE";
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Microsoft Sans Serif", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo1.ForeColor = Color.White;
            lblTitulo1.Location = new Point(35, 25);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(645, 39);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "CADASTRO DE VENDA - ENCOMENDA";
            // 
            // frmCadastroEncomendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 1055);
            Controls.Add(pnlFundo);
            Name = "frmCadastroEncomendas";
            Text = "frmCadastroEncomendas";
            Load += frmCadastroEncomendas_Load;
            pnlFundo.ResumeLayout(false);
            pnlFundo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFundo;
        private Label lblTitulo1;
        private Label lblTitulo2;
        private Panel panel1;
        private ComboBox cmbData;
        private ComboBox cmbProduto;
        private ComboBox cmbCliente;
        private TextBox txtQuantidade;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox txtQtdeParcelas;
        private TextBox txtEntrada;
        private TextBox txtValorTotal;
        private Button btnCancelar;
        private Button btnConfirmar;
        private LinkLabel llbAdicionarVenda;
    }
}
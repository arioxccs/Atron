namespace Atron
{
    partial class frmCadastro2Encomendas
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
            Label label1;
            lblTitulo1 = new Label();
            pnlFundo = new Panel();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            txtQtdeParcelas2 = new TextBox();
            txtEntrada2 = new TextBox();
            txtValorTotal2 = new TextBox();
            txtQtde2 = new TextBox();
            txtCodigoProduto2 = new TextBox();
            txtCodigoCliente2 = new TextBox();
            cmbData2 = new ComboBox();
            cmbProduto2 = new ComboBox();
            cmbCliente2 = new ComboBox();
            txtQtdeParcelas = new TextBox();
            txtEntrada = new TextBox();
            txtValorTotal = new TextBox();
            txtQuantidade = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            cmbData = new ComboBox();
            cmbProduto = new ComboBox();
            cmbCliente = new ComboBox();
            lblTitulo2 = new Label();
            label1 = new Label();
            pnlFundo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo2.ForeColor = Color.FromArgb(121, 121, 121);
            lblTitulo2.Location = new Point(27, 19);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(186, 38);
            lblTitulo2.TabIndex = 3;
            lblTitulo2.Text = "BAIXA NO ESTOQUE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.ForeColor = Color.FromArgb(121, 121, 121);
            label1.Location = new Point(27, 737);
            label1.Name = "label1";
            label1.Size = new Size(127, 38);
            label1.TabIndex = 24;
            label1.Text = "Cadastro 2";
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Bebas Neue", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo1.ForeColor = Color.White;
            lblTitulo1.Location = new Point(35, 25);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(362, 43);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "CADASTRO DE VENDA - ENCOMENDA";
            // 
            // pnlFundo
            // 
            pnlFundo.BackColor = Color.FromArgb(9, 28, 128);
            pnlFundo.Controls.Add(panel1);
            pnlFundo.Controls.Add(lblTitulo1);
            pnlFundo.Location = new Point(114, 93);
            pnlFundo.MinimumSize = new Size(0, 1663);
            pnlFundo.Name = "pnlFundo";
            pnlFundo.Size = new Size(1270, 1663);
            pnlFundo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtQtdeParcelas2);
            panel1.Controls.Add(txtEntrada2);
            panel1.Controls.Add(txtValorTotal2);
            panel1.Controls.Add(txtQtde2);
            panel1.Controls.Add(txtCodigoProduto2);
            panel1.Controls.Add(txtCodigoCliente2);
            panel1.Controls.Add(cmbData2);
            panel1.Controls.Add(cmbProduto2);
            panel1.Controls.Add(cmbCliente2);
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
            panel1.Size = new Size(1128, 1500);
            panel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Font = new Font("Bebas Neue", 13.8F);
            btnCancelar.ForeColor = Color.FromArgb(159, 0, 0);
            btnCancelar.Location = new Point(590, 1404);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(163, 33);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ControlLight;
            btnConfirmar.Font = new Font("Bebas Neue", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.FromArgb(9, 186, 0);
            btnConfirmar.Location = new Point(409, 1404);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(163, 33);
            btnConfirmar.TabIndex = 25;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // txtQtdeParcelas2
            // 
            txtQtdeParcelas2.BorderStyle = BorderStyle.FixedSingle;
            txtQtdeParcelas2.Font = new Font("Bebas Neue", 17F);
            txtQtdeParcelas2.ForeColor = Color.FromArgb(147, 147, 147);
            txtQtdeParcelas2.Location = new Point(738, 1259);
            txtQtdeParcelas2.Name = "txtQtdeParcelas2";
            txtQtdeParcelas2.Size = new Size(309, 44);
            txtQtdeParcelas2.TabIndex = 23;
            txtQtdeParcelas2.Text = "    QTDE PARCELAS";
            // 
            // txtEntrada2
            // 
            txtEntrada2.BorderStyle = BorderStyle.FixedSingle;
            txtEntrada2.Font = new Font("Bebas Neue", 17F);
            txtEntrada2.ForeColor = Color.FromArgb(147, 147, 147);
            txtEntrada2.Location = new Point(392, 1259);
            txtEntrada2.Name = "txtEntrada2";
            txtEntrada2.Size = new Size(309, 44);
            txtEntrada2.TabIndex = 22;
            txtEntrada2.Text = "    ENTRADA";
            // 
            // txtValorTotal2
            // 
            txtValorTotal2.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotal2.Font = new Font("Bebas Neue", 17F);
            txtValorTotal2.ForeColor = Color.FromArgb(147, 147, 147);
            txtValorTotal2.Location = new Point(45, 1259);
            txtValorTotal2.Name = "txtValorTotal2";
            txtValorTotal2.Size = new Size(309, 44);
            txtValorTotal2.TabIndex = 21;
            txtValorTotal2.Text = "    VALOR TOTAL";
            // 
            // txtQtde2
            // 
            txtQtde2.BorderStyle = BorderStyle.FixedSingle;
            txtQtde2.Font = new Font("Bebas Neue", 17F);
            txtQtde2.ForeColor = Color.FromArgb(147, 147, 147);
            txtQtde2.Location = new Point(555, 1119);
            txtQtde2.Name = "txtQtde2";
            txtQtde2.Size = new Size(492, 44);
            txtQtde2.TabIndex = 20;
            txtQtde2.Text = "    QUANTIDADE";
            // 
            // txtCodigoProduto2
            // 
            txtCodigoProduto2.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoProduto2.Font = new Font("Bebas Neue", 17F);
            txtCodigoProduto2.ForeColor = Color.FromArgb(147, 147, 147);
            txtCodigoProduto2.Location = new Point(773, 970);
            txtCodigoProduto2.Name = "txtCodigoProduto2";
            txtCodigoProduto2.Size = new Size(274, 44);
            txtCodigoProduto2.TabIndex = 19;
            txtCodigoProduto2.Text = "    CÓDIGO DO PRODUTO";
            // 
            // txtCodigoCliente2
            // 
            txtCodigoCliente2.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoCliente2.Font = new Font("Bebas Neue", 17F);
            txtCodigoCliente2.ForeColor = Color.FromArgb(147, 147, 147);
            txtCodigoCliente2.Location = new Point(773, 835);
            txtCodigoCliente2.Name = "txtCodigoCliente2";
            txtCodigoCliente2.Size = new Size(274, 44);
            txtCodigoCliente2.TabIndex = 18;
            txtCodigoCliente2.Text = "    CÓDIGO DO CLIENTE";
            // 
            // cmbData2
            // 
            cmbData2.Font = new Font("Bebas Neue", 16F);
            cmbData2.ForeColor = Color.FromArgb(147, 147, 147);
            cmbData2.FormattingEnabled = true;
            cmbData2.Location = new Point(45, 1119);
            cmbData2.Name = "cmbData2";
            cmbData2.Size = new Size(492, 43);
            cmbData2.TabIndex = 17;
            cmbData2.Text = "    dd/mm/aa";
            // 
            // cmbProduto2
            // 
            cmbProduto2.Font = new Font("Bebas Neue", 16F);
            cmbProduto2.ForeColor = Color.FromArgb(147, 147, 147);
            cmbProduto2.FormattingEnabled = true;
            cmbProduto2.Items.AddRange(new object[] { "Produto não encontrado, para cadastrar novo cliente clique aqui." });
            cmbProduto2.Location = new Point(45, 970);
            cmbProduto2.Name = "cmbProduto2";
            cmbProduto2.Size = new Size(707, 43);
            cmbProduto2.TabIndex = 16;
            cmbProduto2.Text = "    PRODUTO";
            // 
            // cmbCliente2
            // 
            cmbCliente2.Font = new Font("Bebas Neue", 18F);
            cmbCliente2.ForeColor = Color.FromArgb(147, 147, 147);
            cmbCliente2.FormattingEnabled = true;
            cmbCliente2.Items.AddRange(new object[] { "Cliente não encontrado, para cadastrar novo cliente clique aqui." });
            cmbCliente2.Location = new Point(45, 835);
            cmbCliente2.Name = "cmbCliente2";
            cmbCliente2.Size = new Size(707, 46);
            cmbCliente2.TabIndex = 15;
            cmbCliente2.Text = "    CLIENTE";
            // 
            // txtQtdeParcelas
            // 
            txtQtdeParcelas.BorderStyle = BorderStyle.FixedSingle;
            txtQtdeParcelas.Font = new Font("Bebas Neue", 17F);
            txtQtdeParcelas.ForeColor = Color.FromArgb(147, 147, 147);
            txtQtdeParcelas.Location = new Point(773, 580);
            txtQtdeParcelas.Name = "txtQtdeParcelas";
            txtQtdeParcelas.Size = new Size(309, 44);
            txtQtdeParcelas.TabIndex = 14;
            txtQtdeParcelas.Text = "    QTDE PARCELAS";
            // 
            // txtEntrada
            // 
            txtEntrada.BorderStyle = BorderStyle.FixedSingle;
            txtEntrada.Font = new Font("Bebas Neue", 17F);
            txtEntrada.ForeColor = Color.FromArgb(147, 147, 147);
            txtEntrada.Location = new Point(427, 580);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.Size = new Size(309, 44);
            txtEntrada.TabIndex = 13;
            txtEntrada.Text = "    ENTRADA";
            // 
            // txtValorTotal
            // 
            txtValorTotal.BorderStyle = BorderStyle.FixedSingle;
            txtValorTotal.Font = new Font("Bebas Neue", 17F);
            txtValorTotal.ForeColor = Color.FromArgb(147, 147, 147);
            txtValorTotal.Location = new Point(80, 580);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(309, 44);
            txtValorTotal.TabIndex = 12;
            txtValorTotal.Text = "    VALOR TOTAL";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BorderStyle = BorderStyle.FixedSingle;
            txtQuantidade.Font = new Font("Bebas Neue", 17F);
            txtQuantidade.ForeColor = Color.FromArgb(147, 147, 147);
            txtQuantidade.Location = new Point(590, 440);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(492, 44);
            txtQuantidade.TabIndex = 11;
            txtQuantidade.Text = "    QUANTIDADE";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Bebas Neue", 17F);
            textBox2.ForeColor = Color.FromArgb(147, 147, 147);
            textBox2.Location = new Point(808, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 44);
            textBox2.TabIndex = 10;
            textBox2.Text = "    CÓDIGO DO PRODUTO";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Bebas Neue", 17F);
            textBox1.ForeColor = Color.FromArgb(147, 147, 147);
            textBox1.Location = new Point(808, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 44);
            textBox1.TabIndex = 9;
            textBox1.Text = "    CÓDIGO DO CLIENTE";
            // 
            // cmbData
            // 
            cmbData.Font = new Font("Bebas Neue", 16F);
            cmbData.ForeColor = Color.FromArgb(147, 147, 147);
            cmbData.FormattingEnabled = true;
            cmbData.Location = new Point(80, 440);
            cmbData.Name = "cmbData";
            cmbData.Size = new Size(492, 43);
            cmbData.TabIndex = 8;
            cmbData.Text = "    dd/mm/aa";
            // 
            // cmbProduto
            // 
            cmbProduto.Font = new Font("Bebas Neue", 16F);
            cmbProduto.ForeColor = Color.FromArgb(147, 147, 147);
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Items.AddRange(new object[] { "Produto não encontrado, para cadastrar novo cliente clique aqui." });
            cmbProduto.Location = new Point(80, 291);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(707, 43);
            cmbProduto.TabIndex = 7;
            cmbProduto.Text = "    PRODUTO";
            // 
            // cmbCliente
            // 
            cmbCliente.Font = new Font("Bebas Neue", 18F);
            cmbCliente.ForeColor = Color.FromArgb(147, 147, 147);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Items.AddRange(new object[] { "Cliente não encontrado, para cadastrar novo cliente clique aqui." });
            cmbCliente.Location = new Point(80, 156);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(707, 46);
            cmbCliente.TabIndex = 6;
            cmbCliente.Text = "    CLIENTE";
            // 
            // frmCadastro2Encomendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1481, 1055);
            Controls.Add(pnlFundo);
            MinimumSize = new Size(0, 1018);
            Name = "frmCadastro2Encomendas";
            Text = "frmCadastro2Encomendas";
            pnlFundo.ResumeLayout(false);
            pnlFundo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo1;
        private Panel pnlFundo;
        private Panel panel1;
        private TextBox txtQtdeParcelas;
        private TextBox txtEntrada;
        private TextBox txtValorTotal;
        private TextBox txtQuantidade;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cmbData;
        private ComboBox cmbProduto;
        private ComboBox cmbCliente;
        private TextBox txtQtdeParcelas2;
        private TextBox txtEntrada2;
        private TextBox txtValorTotal2;
        private TextBox txtQtde2;
        private TextBox txtCodigoProduto2;
        private TextBox txtCodigoCliente2;
        private ComboBox cmbData2;
        private ComboBox cmbProduto2;
        private ComboBox cmbCliente2;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}
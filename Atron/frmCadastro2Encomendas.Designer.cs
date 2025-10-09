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
            txtQtdeParcelas = new TextBox();
            txtEntrada = new TextBox();
            txtValorTotal = new TextBox();
            txtQuantidade = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            cmbData = new ComboBox();
            cmbProduto = new ComboBox();
            cmbCliente = new ComboBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            btnCancelar = new Button();
            btnConfirmar = new Button();
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
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox3);
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
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Bebas Neue", 17F);
            textBox3.ForeColor = Color.FromArgb(147, 147, 147);
            textBox3.Location = new Point(738, 1259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(309, 44);
            textBox3.TabIndex = 23;
            textBox3.Text = "    QTDE PARCELAS";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Bebas Neue", 17F);
            textBox4.ForeColor = Color.FromArgb(147, 147, 147);
            textBox4.Location = new Point(392, 1259);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(309, 44);
            textBox4.TabIndex = 22;
            textBox4.Text = "    ENTRADA";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Font = new Font("Bebas Neue", 17F);
            textBox5.ForeColor = Color.FromArgb(147, 147, 147);
            textBox5.Location = new Point(45, 1259);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(309, 44);
            textBox5.TabIndex = 21;
            textBox5.Text = "    VALOR TOTAL";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Font = new Font("Bebas Neue", 17F);
            textBox6.ForeColor = Color.FromArgb(147, 147, 147);
            textBox6.Location = new Point(555, 1119);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(492, 44);
            textBox6.TabIndex = 20;
            textBox6.Text = "    QUANTIDADE";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Font = new Font("Bebas Neue", 17F);
            textBox7.ForeColor = Color.FromArgb(147, 147, 147);
            textBox7.Location = new Point(773, 970);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(274, 44);
            textBox7.TabIndex = 19;
            textBox7.Text = "    CÓDIGO DO PRODUTO";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Bebas Neue", 17F);
            textBox8.ForeColor = Color.FromArgb(147, 147, 147);
            textBox8.Location = new Point(773, 835);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(274, 44);
            textBox8.TabIndex = 18;
            textBox8.Text = "    CÓDIGO DO CLIENTE";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Bebas Neue", 16F);
            comboBox1.ForeColor = Color.FromArgb(147, 147, 147);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 1119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(492, 43);
            comboBox1.TabIndex = 17;
            comboBox1.Text = "    dd/mm/aa";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Bebas Neue", 16F);
            comboBox2.ForeColor = Color.FromArgb(147, 147, 147);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Produto não encontrado, para cadastrar novo cliente clique aqui." });
            comboBox2.Location = new Point(45, 970);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(707, 43);
            comboBox2.TabIndex = 16;
            comboBox2.Text = "    PRODUTO";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Bebas Neue", 18F);
            comboBox3.ForeColor = Color.FromArgb(147, 147, 147);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Cliente não encontrado, para cadastrar novo cliente clique aqui." });
            comboBox3.Location = new Point(45, 835);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(707, 46);
            comboBox3.TabIndex = 15;
            comboBox3.Text = "    CLIENTE";
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
            btnConfirmar.Click += this.btnConfirmar_Click;
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
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button btnCancelar;
        private Button btnConfirmar;
    }
}
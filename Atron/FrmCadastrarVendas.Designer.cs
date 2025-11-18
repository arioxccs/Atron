namespace Atron
{
    partial class FrmCadastrarVendas
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
            pnlFundo = new Panel();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtComplemento = new TextBox();
            label2 = new Label();
            mktCEP = new MaskedTextBox();
            cmbUF = new ComboBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            lblEndereco = new Label();
            txtEmail = new TextBox();
            cmbData = new ComboBox();
            label1 = new Label();
            lblTelefone = new Label();
            lblCpf = new Label();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            txtCodigo = new TextBox();
            lblTitulo2 = new Label();
            lblTitulo1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lblCadastrodeVenda = new Label();
            panel3 = new Panel();
            btnAddOutraVenda = new Button();
            btnCancela = new Button();
            btnCadastrar = new Button();
            txtQtdeParcelas = new TextBox();
            txtFormaPgto = new TextBox();
            txtQtd = new TextBox();
            dtpData = new DateTimePicker();
            txtCodProduto = new TextBox();
            txtProduto = new TextBox();
            txtValorTotal = new TextBox();
            txtCliente = new TextBox();
            txtCodCliente = new TextBox();
            lblBaixanoEstoque = new Label();
            pnlFundo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFundo
            // 
            pnlFundo.BackColor = Color.FromArgb(9, 28, 128);
            pnlFundo.Controls.Add(panel1);
            pnlFundo.Controls.Add(lblTitulo1);
            pnlFundo.Location = new Point(-18, -177);
            pnlFundo.Margin = new Padding(3, 2, 3, 2);
            pnlFundo.Name = "pnlFundo";
            pnlFundo.Size = new Size(0, 0);
            pnlFundo.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtComplemento);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(mktCEP);
            panel1.Controls.Add(cmbUF);
            panel1.Controls.Add(txtCidade);
            panel1.Controls.Add(txtBairro);
            panel1.Controls.Add(txtRua);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(lblEndereco);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(cmbData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(maskedTextBox3);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(lblTitulo2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(65, 68);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 830);
            panel1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.ForeColor = Color.FromArgb(159, 0, 0);
            btnCancelar.Location = new Point(192, 771);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 26);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ControlLight;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 17F);
            btnRegistrar.ForeColor = Color.FromArgb(9, 186, 0);
            btnRegistrar.Location = new Point(483, 754);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(435, 34);
            btnRegistrar.TabIndex = 36;
            btnRegistrar.Text = "registrar novo cliente";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // txtComplemento
            // 
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Font = new Font("Microsoft Sans Serif", 17F);
            txtComplemento.ForeColor = Color.FromArgb(147, 147, 147);
            txtComplemento.Location = new Point(41, 641);
            txtComplemento.Margin = new Padding(3, 2, 3, 2);
            txtComplemento.Multiline = true;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(881, 86);
            txtComplemento.TabIndex = 35;
            txtComplemento.Text = "    complemento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13F);
            label2.ForeColor = Color.FromArgb(147, 147, 147);
            label2.Location = new Point(721, 548);
            label2.Name = "label2";
            label2.Size = new Size(34, 22);
            label2.TabIndex = 34;
            label2.Text = "cpf";
            // 
            // mktCEP
            // 
            mktCEP.BorderStyle = BorderStyle.FixedSingle;
            mktCEP.Font = new Font("Microsoft Sans Serif", 14F);
            mktCEP.ForeColor = Color.FromArgb(147, 147, 147);
            mktCEP.Location = new Point(721, 572);
            mktCEP.Margin = new Padding(3, 2, 3, 2);
            mktCEP.Mask = "00000-000";
            mktCEP.Name = "mktCEP";
            mktCEP.Size = new Size(202, 29);
            mktCEP.TabIndex = 33;
            // 
            // cmbUF
            // 
            cmbUF.Font = new Font("Microsoft Sans Serif", 16F);
            cmbUF.ForeColor = Color.FromArgb(147, 147, 147);
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AL; AM; AP; BA; ES; MA; MG; MS; MT; PE; PA;", " PB; PE; SC; SP; SE; TO; RS; RN; CE; GO; AC; DF;", "PR; PI;RO; RR" });
            cmbUF.Location = new Point(628, 568);
            cmbUF.Margin = new Padding(3, 2, 3, 2);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(78, 33);
            cmbUF.TabIndex = 32;
            cmbUF.Text = "    UF";
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Microsoft Sans Serif", 17F);
            txtCidade.ForeColor = Color.FromArgb(147, 147, 147);
            txtCidade.Location = new Point(336, 567);
            txtCidade.Margin = new Padding(3, 2, 3, 2);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(287, 33);
            txtCidade.TabIndex = 30;
            txtCidade.Text = "    Cidade";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Font = new Font("Microsoft Sans Serif", 17F);
            txtBairro.ForeColor = Color.FromArgb(147, 147, 147);
            txtBairro.Location = new Point(41, 567);
            txtBairro.Margin = new Padding(3, 2, 3, 2);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(287, 33);
            txtBairro.TabIndex = 29;
            txtBairro.Text = "    bairro";
            // 
            // txtRua
            // 
            txtRua.BorderStyle = BorderStyle.FixedSingle;
            txtRua.Font = new Font("Microsoft Sans Serif", 17F);
            txtRua.ForeColor = Color.FromArgb(147, 147, 147);
            txtRua.Location = new Point(41, 492);
            txtRua.Margin = new Padding(3, 2, 3, 2);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(664, 33);
            txtRua.TabIndex = 28;
            txtRua.Text = "    Rua";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Microsoft Sans Serif", 17F);
            txtNumero.ForeColor = Color.FromArgb(147, 147, 147);
            txtNumero.Location = new Point(721, 492);
            txtNumero.Margin = new Padding(3, 2, 3, 2);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(202, 33);
            txtNumero.TabIndex = 27;
            txtNumero.Text = "    N°";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEndereco.ForeColor = Color.FromArgb(121, 121, 121);
            lblEndereco.Location = new Point(41, 428);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(139, 36);
            lblEndereco.TabIndex = 26;
            lblEndereco.Text = "endereço";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 17F);
            txtEmail.ForeColor = Color.FromArgb(147, 147, 147);
            txtEmail.Location = new Point(41, 352);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(881, 33);
            txtEmail.TabIndex = 25;
            txtEmail.Text = "    email";
            // 
            // cmbData
            // 
            cmbData.Font = new Font("Microsoft Sans Serif", 16F);
            cmbData.ForeColor = Color.FromArgb(147, 147, 147);
            cmbData.FormattingEnabled = true;
            cmbData.Location = new Point(41, 279);
            cmbData.Margin = new Padding(3, 2, 3, 2);
            cmbData.Name = "cmbData";
            cmbData.Size = new Size(431, 33);
            cmbData.TabIndex = 24;
            cmbData.Text = "    dd/mm/aa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13F);
            label1.ForeColor = Color.FromArgb(147, 147, 147);
            label1.Location = new Point(648, 170);
            label1.Name = "label1";
            label1.Size = new Size(26, 22);
            label1.TabIndex = 23;
            label1.Text = "rg";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Microsoft Sans Serif", 13F);
            lblTelefone.ForeColor = Color.FromArgb(147, 147, 147);
            lblTelefone.Location = new Point(348, 170);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(132, 22);
            lblTelefone.TabIndex = 22;
            lblTelefone.Text = "telefone/celular";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Microsoft Sans Serif", 13F);
            lblCpf.ForeColor = Color.FromArgb(147, 147, 147);
            lblCpf.Location = new Point(41, 170);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(34, 22);
            lblCpf.TabIndex = 21;
            lblCpf.Text = "cpf";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox3.Font = new Font("Microsoft Sans Serif", 17F);
            maskedTextBox3.ForeColor = Color.FromArgb(147, 147, 147);
            maskedTextBox3.Location = new Point(648, 194);
            maskedTextBox3.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox3.Mask = "00.000.000-0";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(271, 33);
            maskedTextBox3.TabIndex = 20;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Font = new Font("Microsoft Sans Serif", 17F);
            maskedTextBox2.ForeColor = Color.FromArgb(147, 147, 147);
            maskedTextBox2.Location = new Point(348, 194);
            maskedTextBox2.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox2.Mask = "00 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(271, 33);
            maskedTextBox2.TabIndex = 19;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Microsoft Sans Serif", 17F);
            maskedTextBox1.ForeColor = Color.FromArgb(147, 147, 147);
            maskedTextBox1.Location = new Point(41, 194);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(271, 33);
            maskedTextBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 17F);
            textBox1.ForeColor = Color.FromArgb(147, 147, 147);
            textBox1.Location = new Point(304, 103);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(619, 33);
            textBox1.TabIndex = 12;
            textBox1.Text = "    Nome completo";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 17F);
            txtCodigo.ForeColor = Color.FromArgb(147, 147, 147);
            txtCodigo.Location = new Point(41, 103);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 33);
            txtCodigo.TabIndex = 10;
            txtCodigo.Text = "    CÓDIGO";
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo2.ForeColor = Color.FromArgb(121, 121, 121);
            lblTitulo2.Location = new Point(41, 36);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(233, 36);
            lblTitulo2.TabIndex = 2;
            lblTitulo2.Text = "dados do cliente";
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Microsoft Sans Serif", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo1.ForeColor = Color.White;
            lblTitulo1.Location = new Point(65, 22);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(294, 38);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "Registro de Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(201, 32);
            label3.Name = "label3";
            label3.Size = new Size(294, 38);
            label3.TabIndex = 5;
            label3.Text = "Registro de Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(9, 28, 128);
            panel2.Controls.Add(lblCadastrodeVenda);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(94, 22);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1111, 680);
            panel2.TabIndex = 6;
            panel2.Paint += panel2_Paint;
            // 
            // lblCadastrodeVenda
            // 
            lblCadastrodeVenda.AutoSize = true;
            lblCadastrodeVenda.Font = new Font("Microsoft Sans Serif", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblCadastrodeVenda.ForeColor = Color.White;
            lblCadastrodeVenda.Location = new Point(47, 31);
            lblCadastrodeVenda.Name = "lblCadastrodeVenda";
            lblCadastrodeVenda.Size = new Size(379, 38);
            lblCadastrodeVenda.TabIndex = 2;
            lblCadastrodeVenda.Text = "CADASTRO DE VENDA";
            lblCadastrodeVenda.Click += lblCadastrodeVenda_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(238, 238, 238);
            panel3.Controls.Add(btnAddOutraVenda);
            panel3.Controls.Add(btnCancela);
            panel3.Controls.Add(btnCadastrar);
            panel3.Controls.Add(txtQtdeParcelas);
            panel3.Controls.Add(txtFormaPgto);
            panel3.Controls.Add(txtQtd);
            panel3.Controls.Add(dtpData);
            panel3.Controls.Add(txtCodProduto);
            panel3.Controls.Add(txtProduto);
            panel3.Controls.Add(txtValorTotal);
            panel3.Controls.Add(txtCliente);
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
            // txtProduto
            // 
            txtProduto.BorderStyle = BorderStyle.FixedSingle;
            txtProduto.Font = new Font("Microsoft Sans Serif", 17F);
            txtProduto.ForeColor = Color.FromArgb(147, 147, 147);
            txtProduto.Location = new Point(66, 188);
            txtProduto.Margin = new Padding(3, 2, 3, 2);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(578, 33);
            txtProduto.TabIndex = 53;
            txtProduto.Text = "PRODUTO";
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
            // txtCliente
            // 
            txtCliente.BorderStyle = BorderStyle.FixedSingle;
            txtCliente.Font = new Font("Microsoft Sans Serif", 17F);
            txtCliente.ForeColor = Color.FromArgb(147, 147, 147);
            txtCliente.Location = new Point(66, 107);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(578, 33);
            txtCliente.TabIndex = 36;
            txtCliente.Text = "CLIENTE";
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
            txtCodCliente.TextChanged += txtCodCliente_TextChanged;
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
            lblBaixanoEstoque.Click += lblBaixanoEstoque_Click;
            // 
            // FrmCadastrarVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1328, 791);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(pnlFundo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCadastrarVendas";
            Text = "FrmCadastrarVendas";
            Load += FrmCadastrarVendas_Load;
            pnlFundo.ResumeLayout(false);
            pnlFundo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlFundo;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnRegistrar;
        private TextBox txtComplemento;
        private Label label2;
        private MaskedTextBox mktCEP;
        private ComboBox cmbUF;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtRua;
        private TextBox txtNumero;
        private Label lblEndereco;
        private TextBox txtEmail;
        private ComboBox cmbData;
        private Label label1;
        private Label lblTelefone;
        private Label lblCpf;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private TextBox txtCodigo;
        private Label lblTitulo2;
        private Label lblTitulo1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private Label lblCadastrodeVenda;
        private Label lblBaixanoEstoque;
        private TextBox txtValorTotal;
        private TextBox txtCliente;
        private TextBox txtCodCliente;
        private TextBox txtCodProduto;
        private TextBox txtProduto;
        private DateTimePicker dtpData;
        private TextBox txtQtd;
        private TextBox txtQtdeParcelas;
        private TextBox txtFormaPgto;
        private Button btnCadastrar;
        private Button btnCancela;
        private Button btnAddOutraVenda;
    }
}
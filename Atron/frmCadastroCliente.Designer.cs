namespace Atron
{
    partial class frmCadastroCliente
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
            lblTitulo1 = new Label();
            lblTitulo2 = new Label();
            txtCodigo = new TextBox();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            lblCpf = new Label();
            lblTelefone = new Label();
            label1 = new Label();
            cmbData = new ComboBox();
            txtEmail = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            lblEndereco = new Label();
            txtBairro = new TextBox();
            txtCidade = new TextBox();
            cmbUF = new ComboBox();
            mktCEP = new MaskedTextBox();
            label2 = new Label();
            txtComplemento = new TextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            pnlFundo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFundo
            // 
            pnlFundo.BackColor = Color.FromArgb(9, 28, 128);
            pnlFundo.Controls.Add(panel1);
            pnlFundo.Controls.Add(lblTitulo1);
            pnlFundo.Location = new Point(114, 93);
            pnlFundo.Name = "pnlFundo";
            pnlFundo.Size = new Size(1270, 1507);
            pnlFundo.TabIndex = 3;
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
            panel1.Location = new Point(74, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 1355);
            panel1.TabIndex = 2;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Bebas Neue", 33F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo1.ForeColor = Color.White;
            lblTitulo1.Location = new Point(74, 29);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(228, 43);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "Registro de Cliente";
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo2.ForeColor = Color.FromArgb(121, 121, 121);
            lblTitulo2.Location = new Point(47, 48);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(183, 38);
            lblTitulo2.TabIndex = 2;
            lblTitulo2.Text = "dados do cliente";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Bebas Neue", 17F);
            txtCodigo.ForeColor = Color.FromArgb(147, 147, 147);
            txtCodigo.Location = new Point(47, 137);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(274, 44);
            txtCodigo.TabIndex = 10;
            txtCodigo.Text = "    CÓDIGO";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Bebas Neue", 17F);
            textBox1.ForeColor = Color.FromArgb(147, 147, 147);
            textBox1.Location = new Point(347, 137);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(707, 44);
            textBox1.TabIndex = 12;
            textBox1.Text = "    Nome completo";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Bebas Neue", 17F);
            maskedTextBox1.ForeColor = Color.FromArgb(147, 147, 147);
            maskedTextBox1.Location = new Point(47, 259);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(309, 44);
            maskedTextBox1.TabIndex = 18;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox2.Font = new Font("Bebas Neue", 17F);
            maskedTextBox2.ForeColor = Color.FromArgb(147, 147, 147);
            maskedTextBox2.Location = new Point(398, 259);
            maskedTextBox2.Mask = "00 00000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(309, 44);
            maskedTextBox2.TabIndex = 19;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox3.Font = new Font("Bebas Neue", 17F);
            maskedTextBox3.ForeColor = Color.FromArgb(147, 147, 147);
            maskedTextBox3.Location = new Point(740, 259);
            maskedTextBox3.Mask = "00.000.000-0";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(309, 44);
            maskedTextBox3.TabIndex = 20;
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Bebas Neue", 13F);
            lblCpf.ForeColor = Color.FromArgb(147, 147, 147);
            lblCpf.Location = new Point(47, 227);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(37, 29);
            lblCpf.TabIndex = 21;
            lblCpf.Text = "cpf";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Bebas Neue", 13F);
            lblTelefone.ForeColor = Color.FromArgb(147, 147, 147);
            lblTelefone.Location = new Point(398, 227);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(147, 29);
            lblTelefone.TabIndex = 22;
            lblTelefone.Text = "telefone/celular";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bebas Neue", 13F);
            label1.ForeColor = Color.FromArgb(147, 147, 147);
            label1.Location = new Point(740, 227);
            label1.Name = "label1";
            label1.Size = new Size(31, 29);
            label1.TabIndex = 23;
            label1.Text = "rg";
            // 
            // cmbData
            // 
            cmbData.Font = new Font("Bebas Neue", 16F);
            cmbData.ForeColor = Color.FromArgb(147, 147, 147);
            cmbData.FormattingEnabled = true;
            cmbData.Location = new Point(47, 372);
            cmbData.Name = "cmbData";
            cmbData.Size = new Size(492, 43);
            cmbData.TabIndex = 24;
            cmbData.Text = "    dd/mm/aa";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Bebas Neue", 17F);
            txtEmail.ForeColor = Color.FromArgb(147, 147, 147);
            txtEmail.Location = new Point(47, 469);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1007, 44);
            txtEmail.TabIndex = 25;
            txtEmail.Text = "    email";
            // 
            // txtRua
            // 
            txtRua.BorderStyle = BorderStyle.FixedSingle;
            txtRua.Font = new Font("Bebas Neue", 17F);
            txtRua.ForeColor = Color.FromArgb(147, 147, 147);
            txtRua.Location = new Point(47, 656);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(759, 44);
            txtRua.TabIndex = 28;
            txtRua.Text = "    Rua";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Bebas Neue", 17F);
            txtNumero.ForeColor = Color.FromArgb(147, 147, 147);
            txtNumero.Location = new Point(824, 656);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(230, 44);
            txtNumero.TabIndex = 27;
            txtNumero.Text = "    N°";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEndereco.ForeColor = Color.FromArgb(121, 121, 121);
            lblEndereco.Location = new Point(47, 570);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(110, 38);
            lblEndereco.TabIndex = 26;
            lblEndereco.Text = "endereço";
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Font = new Font("Bebas Neue", 17F);
            txtBairro.ForeColor = Color.FromArgb(147, 147, 147);
            txtBairro.Location = new Point(47, 756);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(328, 44);
            txtBairro.TabIndex = 29;
            txtBairro.Text = "    bairro";
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Bebas Neue", 17F);
            txtCidade.ForeColor = Color.FromArgb(147, 147, 147);
            txtCidade.Location = new Point(384, 756);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(328, 44);
            txtCidade.TabIndex = 30;
            txtCidade.Text = "    Cidade";
            txtCidade.TextChanged += textBox3_TextChanged;
            // 
            // cmbUF
            // 
            cmbUF.Font = new Font("Bebas Neue", 16F);
            cmbUF.ForeColor = Color.FromArgb(147, 147, 147);
            cmbUF.FormattingEnabled = true;
            cmbUF.Items.AddRange(new object[] { "AL; AM; AP; BA; ES; MA; MG; MS; MT; PE; PA;", " PB; PE; SC; SP; SE; TO; RS; RN; CE; GO; AC; DF;", "PR; PI;RO; RR" });
            cmbUF.Location = new Point(718, 757);
            cmbUF.Name = "cmbUF";
            cmbUF.Size = new Size(88, 43);
            cmbUF.TabIndex = 32;
            cmbUF.Text = "    UF";
            // 
            // mktCEP
            // 
            mktCEP.BorderStyle = BorderStyle.FixedSingle;
            mktCEP.Font = new Font("Bebas Neue", 14F);
            mktCEP.ForeColor = Color.FromArgb(147, 147, 147);
            mktCEP.Location = new Point(824, 762);
            mktCEP.Mask = "00000-000";
            mktCEP.Name = "mktCEP";
            mktCEP.Size = new Size(230, 38);
            mktCEP.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bebas Neue", 13F);
            label2.ForeColor = Color.FromArgb(147, 147, 147);
            label2.Location = new Point(824, 730);
            label2.Name = "label2";
            label2.Size = new Size(37, 29);
            label2.TabIndex = 34;
            label2.Text = "cpf";
            // 
            // txtComplemento
            // 
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Font = new Font("Bebas Neue", 17F);
            txtComplemento.ForeColor = Color.FromArgb(147, 147, 147);
            txtComplemento.Location = new Point(47, 855);
            txtComplemento.Multiline = true;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(1007, 114);
            txtComplemento.TabIndex = 35;
            txtComplemento.Text = "    complemento";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ControlLight;
            btnRegistrar.Font = new Font("Bebas Neue", 17F);
            btnRegistrar.ForeColor = Color.FromArgb(9, 186, 0);
            btnRegistrar.Location = new Point(473, 1148);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(497, 45);
            btnRegistrar.TabIndex = 36;
            btnRegistrar.Text = "registrar novo cliente";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Font = new Font("Bebas Neue", 9F);
            btnCancelar.ForeColor = Color.FromArgb(159, 0, 0);
            btnCancelar.Location = new Point(47, 1280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 34);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1482, 1055);
            Controls.Add(pnlFundo);
            Name = "frmCadastroCliente";
            Text = "frmCadastroCliente";
            pnlFundo.ResumeLayout(false);
            pnlFundo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFundo;
        private Panel panel1;
        private Label lblTitulo1;
        private Label lblTitulo2;
        private TextBox txtCodigo;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label lblCpf;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label1;
        private Label lblTelefone;
        private TextBox txtRua;
        private TextBox txtNumero;
        private Label lblEndereco;
        private TextBox txtEmail;
        private ComboBox cmbData;
        private TextBox textBox3;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private ComboBox cmbUF;
        private TextBox txtComplemento;
        private Label label2;
        private MaskedTextBox mktCEP;
        private Button btnCancelar;
        private Button btnRegistrar;
    }
}
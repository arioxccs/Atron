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
            dtpData = new DateTimePicker();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            txtComplemento = new TextBox();
            lblCep = new Label();
            txtCep = new MaskedTextBox();
            cmbUf = new ComboBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            txtNumero = new TextBox();
            lblEndereco = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            lblTelefone = new Label();
            lblCpf = new Label();
            txtRg = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            txtCpf = new MaskedTextBox();
            txtNome = new TextBox();
            txtCodigo = new TextBox();
            lblTitulo2 = new Label();
            lblTitulo1 = new Label();
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
            panel1.Controls.Add(dtpData);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtComplemento);
            panel1.Controls.Add(lblCep);
            panel1.Controls.Add(txtCep);
            panel1.Controls.Add(cmbUf);
            panel1.Controls.Add(txtCidade);
            panel1.Controls.Add(txtBairro);
            panel1.Controls.Add(txtRua);
            panel1.Controls.Add(txtNumero);
            panel1.Controls.Add(lblEndereco);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTelefone);
            panel1.Controls.Add(lblCpf);
            panel1.Controls.Add(txtRg);
            panel1.Controls.Add(txtTelefone);
            panel1.Controls.Add(txtCpf);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(lblTitulo2);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(74, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 1355);
            panel1.TabIndex = 2;
            // 
            // dtpData
            // 
            dtpData.Font = new Font("Segoe UI", 12F);
            dtpData.Location = new Point(47, 369);
            dtpData.Margin = new Padding(3, 4, 3, 4);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(492, 34);
            dtpData.TabIndex = 47;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlLight;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F);
            btnCancelar.ForeColor = Color.FromArgb(159, 0, 0);
            btnCancelar.Location = new Point(47, 1280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 34);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ControlLight;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 17F);
            btnRegistrar.ForeColor = Color.FromArgb(9, 186, 0);
            btnRegistrar.Location = new Point(473, 1148);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(497, 45);
            btnRegistrar.TabIndex = 36;
            btnRegistrar.Text = "registrar novo cliente";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtComplemento
            // 
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Font = new Font("Microsoft Sans Serif", 17F);
            txtComplemento.ForeColor = Color.FromArgb(147, 147, 147);
            txtComplemento.Location = new Point(47, 855);
            txtComplemento.Multiline = true;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(1007, 114);
            txtComplemento.TabIndex = 35;
            txtComplemento.Text = "    complemento";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.BackColor = Color.Transparent;
            lblCep.Font = new Font("Microsoft Sans Serif", 13F);
            lblCep.ForeColor = Color.FromArgb(147, 147, 147);
            lblCep.Location = new Point(824, 730);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(58, 26);
            lblCep.TabIndex = 34;
            lblCep.Text = "CEP";
            // 
            // txtCep
            // 
            txtCep.BorderStyle = BorderStyle.FixedSingle;
            txtCep.Font = new Font("Microsoft Sans Serif", 14F);
            txtCep.ForeColor = Color.FromArgb(147, 147, 147);
            txtCep.Location = new Point(824, 762);
            txtCep.Mask = "00000-000";
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(230, 34);
            txtCep.TabIndex = 33;
            // 
            // cmbUf
            // 
            cmbUf.Font = new Font("Microsoft Sans Serif", 16F);
            cmbUf.ForeColor = Color.FromArgb(147, 147, 147);
            cmbUf.FormattingEnabled = true;
            cmbUf.Items.AddRange(new object[] { "AL", "AM", "AP", "BA", "ES", "MA", "MG", "MS", "MT", "PE", "PA", "PB", "PE", "SC", "SP", "SE", "TO", "RS", "RN", "CE", "GO", "AC", "DF", "PR", "PI", "RO", "RR" });
            cmbUf.Location = new Point(718, 757);
            cmbUf.Name = "cmbUf";
            cmbUf.Size = new Size(88, 39);
            cmbUf.TabIndex = 32;
            cmbUf.Text = "    UF";
            // 
            // txtCidade
            // 
            txtCidade.BorderStyle = BorderStyle.FixedSingle;
            txtCidade.Font = new Font("Microsoft Sans Serif", 17F);
            txtCidade.ForeColor = Color.FromArgb(147, 147, 147);
            txtCidade.Location = new Point(384, 756);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(328, 40);
            txtCidade.TabIndex = 30;
            txtCidade.Text = "    Cidade";
            txtCidade.TextChanged += textBox3_TextChanged;
            // 
            // txtBairro
            // 
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Font = new Font("Microsoft Sans Serif", 17F);
            txtBairro.ForeColor = Color.FromArgb(147, 147, 147);
            txtBairro.Location = new Point(47, 756);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(328, 40);
            txtBairro.TabIndex = 29;
            txtBairro.Text = "    bairro";
            // 
            // txtRua
            // 
            txtRua.BorderStyle = BorderStyle.FixedSingle;
            txtRua.Font = new Font("Microsoft Sans Serif", 17F);
            txtRua.ForeColor = Color.FromArgb(147, 147, 147);
            txtRua.Location = new Point(47, 656);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(759, 40);
            txtRua.TabIndex = 28;
            txtRua.Text = "    Rua";
            // 
            // txtNumero
            // 
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Microsoft Sans Serif", 17F);
            txtNumero.ForeColor = Color.FromArgb(147, 147, 147);
            txtNumero.Location = new Point(824, 656);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(230, 40);
            txtNumero.TabIndex = 27;
            txtNumero.Text = "    N°";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblEndereco.ForeColor = Color.FromArgb(121, 121, 121);
            lblEndereco.Location = new Point(47, 570);
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
            txtEmail.Location = new Point(47, 469);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(1007, 40);
            txtEmail.TabIndex = 25;
            txtEmail.Text = "    email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13F);
            label1.ForeColor = Color.FromArgb(147, 147, 147);
            label1.Location = new Point(740, 227);
            label1.Name = "label1";
            label1.Size = new Size(31, 26);
            label1.TabIndex = 23;
            label1.Text = "rg";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Microsoft Sans Serif", 13F);
            lblTelefone.ForeColor = Color.FromArgb(147, 147, 147);
            lblTelefone.Location = new Point(398, 227);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(159, 26);
            lblTelefone.TabIndex = 22;
            lblTelefone.Text = "telefone/celular";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.BackColor = Color.Transparent;
            lblCpf.Font = new Font("Microsoft Sans Serif", 13F);
            lblCpf.ForeColor = Color.FromArgb(147, 147, 147);
            lblCpf.Location = new Point(47, 227);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(41, 26);
            lblCpf.TabIndex = 21;
            lblCpf.Text = "cpf";
            // 
            // txtRg
            // 
            txtRg.BorderStyle = BorderStyle.FixedSingle;
            txtRg.Font = new Font("Microsoft Sans Serif", 17F);
            txtRg.ForeColor = Color.FromArgb(147, 147, 147);
            txtRg.Location = new Point(740, 259);
            txtRg.Mask = "00.000.000-0";
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(309, 40);
            txtRg.TabIndex = 20;
            // 
            // txtTelefone
            // 
            txtTelefone.BorderStyle = BorderStyle.FixedSingle;
            txtTelefone.Font = new Font("Microsoft Sans Serif", 17F);
            txtTelefone.ForeColor = Color.FromArgb(147, 147, 147);
            txtTelefone.Location = new Point(398, 259);
            txtTelefone.Mask = "00 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(309, 40);
            txtTelefone.TabIndex = 19;
            // 
            // txtCpf
            // 
            txtCpf.BorderStyle = BorderStyle.FixedSingle;
            txtCpf.Font = new Font("Microsoft Sans Serif", 17F);
            txtCpf.ForeColor = Color.FromArgb(147, 147, 147);
            txtCpf.Location = new Point(47, 259);
            txtCpf.Mask = "000.000.000-00";
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(309, 40);
            txtCpf.TabIndex = 18;
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Microsoft Sans Serif", 17F);
            txtNome.ForeColor = Color.FromArgb(147, 147, 147);
            txtNome.Location = new Point(347, 137);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(707, 40);
            txtNome.TabIndex = 12;
            txtNome.Text = "    Nome completo";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 17F);
            txtCodigo.ForeColor = Color.FromArgb(147, 147, 147);
            txtCodigo.Location = new Point(47, 137);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(274, 40);
            txtCodigo.TabIndex = 10;
            txtCodigo.Text = "    CÓDIGO";
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblTitulo2.ForeColor = Color.FromArgb(121, 121, 121);
            lblTitulo2.Location = new Point(47, 48);
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
            lblTitulo1.Location = new Point(74, 29);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(307, 39);
            lblTitulo1.TabIndex = 1;
            lblTitulo1.Text = "Registro de Cliente";
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
        private TextBox txtNome;
        private MaskedTextBox txtCpf;
        private Label lblCpf;
        private MaskedTextBox txtRg;
        private MaskedTextBox txtTelefone;
        private Label label1;
        private Label lblTelefone;
        private TextBox txtRua;
        private TextBox txtNumero;
        private Label lblEndereco;
        private TextBox txtEmail;
        private TextBox textBox3;
        private TextBox txtBairro;
        private TextBox txtCidade;
        private ComboBox cmbUf;
        private TextBox txtComplemento;
        private Label lblCep;
        private MaskedTextBox txtCep;
        private Button btnCancelar;
        private Button btnRegistrar;
        private DateTimePicker dtpData;
    }
}
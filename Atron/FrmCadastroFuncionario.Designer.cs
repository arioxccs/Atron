namespace Atron
{
    partial class FrmCadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFuncionario));
            panel1 = new Panel();
            dtp_Nascimento = new DateTimePicker();
            btn_CacelarCadastroUsuario = new Button();
            btn_SalvarFuncionario = new Button();
            txt_Cod = new TextBox();
            txt_Senha = new TextBox();
            txt_Horas = new TextBox();
            txt_Pagamento = new TextBox();
            txt_Salario = new TextBox();
            txt_Funcao = new TextBox();
            txt_Contato = new TextBox();
            txt_Endereco = new TextBox();
            txt_RG = new TextBox();
            txt_CPF = new TextBox();
            txt_NomeFuncionario = new TextBox();
            label2 = new Label();
            lbl_Cod = new Label();
            lbl_HorasMensaisT = new Label();
            lbl_FormaPagamentoT = new Label();
            lbl_SalarioT = new Label();
            lbl_FuncaoT = new Label();
            pictureBox2 = new PictureBox();
            lbl_ContatoT = new Label();
            lbl_EnderecoT = new Label();
            lbl_NascimentoT = new Label();
            lbl_RGT = new Label();
            lbl_CPFT = new Label();
            lbl_NomeFuncionarioT = new Label();
            pictureBox1 = new PictureBox();
            lbl_FichaFuncionarioTitulo = new Label();
            btn_Voltar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(94, 135, 225);
            panel1.Controls.Add(dtp_Nascimento);
            panel1.Controls.Add(btn_CacelarCadastroUsuario);
            panel1.Controls.Add(btn_SalvarFuncionario);
            panel1.Controls.Add(txt_Cod);
            panel1.Controls.Add(txt_Senha);
            panel1.Controls.Add(txt_Horas);
            panel1.Controls.Add(txt_Pagamento);
            panel1.Controls.Add(txt_Salario);
            panel1.Controls.Add(txt_Funcao);
            panel1.Controls.Add(txt_Contato);
            panel1.Controls.Add(txt_Endereco);
            panel1.Controls.Add(txt_RG);
            panel1.Controls.Add(txt_CPF);
            panel1.Controls.Add(txt_NomeFuncionario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbl_Cod);
            panel1.Controls.Add(lbl_HorasMensaisT);
            panel1.Controls.Add(lbl_FormaPagamentoT);
            panel1.Controls.Add(lbl_SalarioT);
            panel1.Controls.Add(lbl_FuncaoT);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lbl_ContatoT);
            panel1.Controls.Add(lbl_EnderecoT);
            panel1.Controls.Add(lbl_NascimentoT);
            panel1.Controls.Add(lbl_RGT);
            panel1.Controls.Add(lbl_CPFT);
            panel1.Controls.Add(lbl_NomeFuncionarioT);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl_FichaFuncionarioTitulo);
            panel1.Location = new Point(67, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 740);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // dtp_Nascimento
            // 
            dtp_Nascimento.Font = new Font("Segoe UI", 12F);
            dtp_Nascimento.Location = new Point(550, 293);
            dtp_Nascimento.Name = "dtp_Nascimento";
            dtp_Nascimento.Size = new Size(234, 29);
            dtp_Nascimento.TabIndex = 46;
            dtp_Nascimento.ValueChanged += dtp_Nascimento_ValueChanged;
            // 
            // btn_CacelarCadastroUsuario
            // 
            btn_CacelarCadastroUsuario.BackColor = Color.FromArgb(255, 128, 128);
            btn_CacelarCadastroUsuario.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CacelarCadastroUsuario.Location = new Point(979, 580);
            btn_CacelarCadastroUsuario.Name = "btn_CacelarCadastroUsuario";
            btn_CacelarCadastroUsuario.Size = new Size(192, 61);
            btn_CacelarCadastroUsuario.TabIndex = 45;
            btn_CacelarCadastroUsuario.Text = "Cancelar";
            btn_CacelarCadastroUsuario.UseVisualStyleBackColor = false;
            btn_CacelarCadastroUsuario.Click += btn_CacelarCadastroUsuario_Click;
            // 
            // btn_SalvarFuncionario
            // 
            btn_SalvarFuncionario.BackColor = Color.PaleGreen;
            btn_SalvarFuncionario.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_SalvarFuncionario.Location = new Point(781, 580);
            btn_SalvarFuncionario.Name = "btn_SalvarFuncionario";
            btn_SalvarFuncionario.Size = new Size(192, 61);
            btn_SalvarFuncionario.TabIndex = 44;
            btn_SalvarFuncionario.Text = "Salvar";
            btn_SalvarFuncionario.UseVisualStyleBackColor = false;
            btn_SalvarFuncionario.Click += btn_SalvarFuncionario_Click;
            // 
            // txt_Cod
            // 
            txt_Cod.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Cod.Location = new Point(227, 477);
            txt_Cod.Name = "txt_Cod";
            txt_Cod.Size = new Size(182, 35);
            txt_Cod.TabIndex = 42;
            // 
            // txt_Senha
            // 
            txt_Senha.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Senha.Location = new Point(199, 529);
            txt_Senha.Name = "txt_Senha";
            txt_Senha.Size = new Size(199, 35);
            txt_Senha.TabIndex = 41;
            // 
            // txt_Horas
            // 
            txt_Horas.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Horas.Location = new Point(1062, 341);
            txt_Horas.Name = "txt_Horas";
            txt_Horas.Size = new Size(135, 35);
            txt_Horas.TabIndex = 40;
            // 
            // txt_Pagamento
            // 
            txt_Pagamento.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Pagamento.Location = new Point(1026, 270);
            txt_Pagamento.Name = "txt_Pagamento";
            txt_Pagamento.Size = new Size(171, 35);
            txt_Pagamento.TabIndex = 39;
            // 
            // txt_Salario
            // 
            txt_Salario.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Salario.Location = new Point(949, 204);
            txt_Salario.Name = "txt_Salario";
            txt_Salario.Size = new Size(248, 35);
            txt_Salario.TabIndex = 38;
            // 
            // txt_Funcao
            // 
            txt_Funcao.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Funcao.Location = new Point(958, 138);
            txt_Funcao.Name = "txt_Funcao";
            txt_Funcao.Size = new Size(239, 35);
            txt_Funcao.TabIndex = 35;
            // 
            // txt_Contato
            // 
            txt_Contato.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Contato.Location = new Point(484, 401);
            txt_Contato.Name = "txt_Contato";
            txt_Contato.Size = new Size(284, 35);
            txt_Contato.TabIndex = 34;
            // 
            // txt_Endereco
            // 
            txt_Endereco.Font = new Font("Microsoft Sans Serif", 18F);
            txt_Endereco.Location = new Point(515, 349);
            txt_Endereco.Name = "txt_Endereco";
            txt_Endereco.Size = new Size(253, 35);
            txt_Endereco.TabIndex = 34;
            // 
            // txt_RG
            // 
            txt_RG.Font = new Font("Microsoft Sans Serif", 18F);
            txt_RG.Location = new Point(397, 240);
            txt_RG.Name = "txt_RG";
            txt_RG.Size = new Size(371, 35);
            txt_RG.TabIndex = 32;
            txt_RG.TextChanged += txt_RG_TextChanged;
            // 
            // txt_CPF
            // 
            txt_CPF.Font = new Font("Microsoft Sans Serif", 18F);
            txt_CPF.Location = new Point(420, 193);
            txt_CPF.Name = "txt_CPF";
            txt_CPF.Size = new Size(348, 35);
            txt_CPF.TabIndex = 31;
            // 
            // txt_NomeFuncionario
            // 
            txt_NomeFuncionario.Font = new Font("Microsoft Sans Serif", 18F);
            txt_NomeFuncionario.Location = new Point(451, 138);
            txt_NomeFuncionario.Name = "txt_NomeFuncionario";
            txt_NomeFuncionario.Size = new Size(317, 35);
            txt_NomeFuncionario.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(62, 518);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(146, 46);
            label2.TabIndex = 30;
            label2.Text = "Senha:";
            // 
            // lbl_Cod
            // 
            lbl_Cod.AutoSize = true;
            lbl_Cod.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Cod.ForeColor = Color.White;
            lbl_Cod.Location = new Point(62, 466);
            lbl_Cod.Name = "lbl_Cod";
            lbl_Cod.Size = new Size(159, 46);
            lbl_Cod.TabIndex = 28;
            lbl_Cod.Text = "Código:";
            // 
            // lbl_HorasMensaisT
            // 
            lbl_HorasMensaisT.AutoSize = true;
            lbl_HorasMensaisT.Font = new Font("Microsoft Sans Serif", 27F);
            lbl_HorasMensaisT.ForeColor = Color.White;
            lbl_HorasMensaisT.Location = new Point(804, 336);
            lbl_HorasMensaisT.Name = "lbl_HorasMensaisT";
            lbl_HorasMensaisT.Size = new Size(267, 40);
            lbl_HorasMensaisT.TabIndex = 25;
            lbl_HorasMensaisT.Text = "Horas Mensais:";
            // 
            // lbl_FormaPagamentoT
            // 
            lbl_FormaPagamentoT.AutoSize = true;
            lbl_FormaPagamentoT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FormaPagamentoT.ForeColor = Color.White;
            lbl_FormaPagamentoT.Location = new Point(804, 259);
            lbl_FormaPagamentoT.Name = "lbl_FormaPagamentoT";
            lbl_FormaPagamentoT.Size = new Size(235, 46);
            lbl_FormaPagamentoT.TabIndex = 23;
            lbl_FormaPagamentoT.Text = "Pagamento:";
            // 
            // lbl_SalarioT
            // 
            lbl_SalarioT.AutoSize = true;
            lbl_SalarioT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SalarioT.ForeColor = Color.White;
            lbl_SalarioT.Location = new Point(804, 193);
            lbl_SalarioT.Name = "lbl_SalarioT";
            lbl_SalarioT.Size = new Size(156, 46);
            lbl_SalarioT.TabIndex = 21;
            lbl_SalarioT.Text = "Salário:";
            // 
            // lbl_FuncaoT
            // 
            lbl_FuncaoT.AutoSize = true;
            lbl_FuncaoT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FuncaoT.ForeColor = Color.White;
            lbl_FuncaoT.Location = new Point(804, 130);
            lbl_FuncaoT.Name = "lbl_FuncaoT";
            lbl_FuncaoT.Size = new Size(165, 46);
            lbl_FuncaoT.TabIndex = 15;
            lbl_FuncaoT.Text = "Função:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(790, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 333);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // lbl_ContatoT
            // 
            lbl_ContatoT.AutoSize = true;
            lbl_ContatoT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ContatoT.ForeColor = Color.White;
            lbl_ContatoT.Location = new Point(318, 390);
            lbl_ContatoT.Name = "lbl_ContatoT";
            lbl_ContatoT.Size = new Size(172, 46);
            lbl_ContatoT.TabIndex = 12;
            lbl_ContatoT.Text = "Contato:";
            // 
            // lbl_EnderecoT
            // 
            lbl_EnderecoT.AutoSize = true;
            lbl_EnderecoT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_EnderecoT.ForeColor = Color.White;
            lbl_EnderecoT.Location = new Point(318, 338);
            lbl_EnderecoT.Name = "lbl_EnderecoT";
            lbl_EnderecoT.Size = new Size(203, 46);
            lbl_EnderecoT.TabIndex = 10;
            lbl_EnderecoT.Text = "Endereço:";
            // 
            // lbl_NascimentoT
            // 
            lbl_NascimentoT.AutoSize = true;
            lbl_NascimentoT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NascimentoT.ForeColor = Color.White;
            lbl_NascimentoT.Location = new Point(318, 283);
            lbl_NascimentoT.Name = "lbl_NascimentoT";
            lbl_NascimentoT.Size = new Size(243, 46);
            lbl_NascimentoT.TabIndex = 8;
            lbl_NascimentoT.Text = "Nascimento:";
            // 
            // lbl_RGT
            // 
            lbl_RGT.AutoSize = true;
            lbl_RGT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_RGT.ForeColor = Color.White;
            lbl_RGT.Location = new Point(318, 234);
            lbl_RGT.Name = "lbl_RGT";
            lbl_RGT.Size = new Size(91, 46);
            lbl_RGT.TabIndex = 6;
            lbl_RGT.Text = "RG:";
            // 
            // lbl_CPFT
            // 
            lbl_CPFT.AutoSize = true;
            lbl_CPFT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CPFT.ForeColor = Color.White;
            lbl_CPFT.Location = new Point(318, 188);
            lbl_CPFT.Name = "lbl_CPFT";
            lbl_CPFT.Size = new Size(111, 46);
            lbl_CPFT.TabIndex = 4;
            lbl_CPFT.Text = "CPF:";
            lbl_CPFT.Click += lbl_CPFT_Click;
            // 
            // lbl_NomeFuncionarioT
            // 
            lbl_NomeFuncionarioT.AutoSize = true;
            lbl_NomeFuncionarioT.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomeFuncionarioT.ForeColor = Color.White;
            lbl_NomeFuncionarioT.Location = new Point(318, 130);
            lbl_NomeFuncionarioT.Name = "lbl_NomeFuncionarioT";
            lbl_NomeFuncionarioT.Size = new Size(138, 46);
            lbl_NomeFuncionarioT.TabIndex = 2;
            lbl_NomeFuncionarioT.Text = "Nome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(62, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lbl_FichaFuncionarioTitulo
            // 
            lbl_FichaFuncionarioTitulo.AutoSize = true;
            lbl_FichaFuncionarioTitulo.Font = new Font("ST-Komsomol", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_FichaFuncionarioTitulo.ForeColor = Color.White;
            lbl_FichaFuncionarioTitulo.Location = new Point(308, -22);
            lbl_FichaFuncionarioTitulo.Name = "lbl_FichaFuncionarioTitulo";
            lbl_FichaFuncionarioTitulo.Size = new Size(638, 124);
            lbl_FichaFuncionarioTitulo.TabIndex = 0;
            lbl_FichaFuncionarioTitulo.Text = "Ficha de Funcionario";
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.White;
            btn_Voltar.FlatAppearance.BorderSize = 0;
            btn_Voltar.FlatStyle = FlatStyle.Flat;
            btn_Voltar.Image = (Image)resources.GetObject("btn_Voltar.Image");
            btn_Voltar.Location = new Point(13, 0);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(48, 48);
            btn_Voltar.TabIndex = 2;
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // FrmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 749);
            Controls.Add(panel1);
            Controls.Add(btn_Voltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCadastroFuncionario";
            Text = "FrmCadastroFuncionario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lbl_Cod;
        private Label lbl_HorasMensaisT;
        private Label lbl_FormaPagamentoT;
        private Label lbl_SalarioT;
        private Label lbl_FuncaoT;
        private PictureBox pictureBox2;
        private Label lbl_ContatoT;
        private Label lbl_EnderecoT;
        private Label lbl_NascimentoT;
        private Label lbl_RGT;
        private Label lbl_CPFT;
        private Label lbl_NomeFuncionarioT;
        private PictureBox pictureBox1;
        private Label lbl_FichaFuncionarioTitulo;
        private Button btn_Voltar;
        private TextBox txt_Cod;
        private TextBox txt_Senha;
        private TextBox txt_Horas;
        private TextBox txt_Pagamento;
        private TextBox txt_Salario;
        private TextBox txt_Funcao;
        private TextBox txt_Contato;
        private TextBox txt_Endereco;
        private TextBox txt_RG;
        private TextBox txt_CPF;
        private TextBox txt_NomeFuncionario;
        private Button btn_SalvarFuncionario;
        private Button btn_CacelarCadastroUsuario;
        private DateTimePicker dtp_Nascimento;
    }
}
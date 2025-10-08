namespace Atron
{
    partial class FrmFichaClienteGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFichaClienteGerente));
            panelFichaCliente = new Panel();
            label1 = new Label();
            lbl_ContatoR = new Label();
            lbl_ContatoT = new Label();
            lbl_EnderecoR = new Label();
            lbl_EnderecoT = new Label();
            lbl_NascimentoR = new Label();
            lbl_NascimentoT = new Label();
            lbl_CPFR = new Label();
            lbl_CPFT = new Label();
            lbl_NomeFuncionarioR = new Label();
            lbl_NomeFuncionarioT = new Label();
            lbl_CodigoCliente = new Label();
            lbl_CodigoClienteT = new Label();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Código = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            btn_Voltar = new Button();
            panelFichaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelFichaCliente
            // 
            panelFichaCliente.BackColor = Color.FromArgb(94, 135, 225);
            panelFichaCliente.Controls.Add(dataGridView1);
            panelFichaCliente.Controls.Add(lbl_CodigoCliente);
            panelFichaCliente.Controls.Add(lbl_CodigoClienteT);
            panelFichaCliente.Controls.Add(lbl_ContatoR);
            panelFichaCliente.Controls.Add(lbl_ContatoT);
            panelFichaCliente.Controls.Add(lbl_EnderecoR);
            panelFichaCliente.Controls.Add(lbl_EnderecoT);
            panelFichaCliente.Controls.Add(lbl_NascimentoR);
            panelFichaCliente.Controls.Add(lbl_NascimentoT);
            panelFichaCliente.Controls.Add(lbl_CPFR);
            panelFichaCliente.Controls.Add(lbl_CPFT);
            panelFichaCliente.Controls.Add(lbl_NomeFuncionarioR);
            panelFichaCliente.Controls.Add(lbl_NomeFuncionarioT);
            panelFichaCliente.Controls.Add(label1);
            panelFichaCliente.Location = new Point(45, 43);
            panelFichaCliente.Name = "panelFichaCliente";
            panelFichaCliente.Size = new Size(1235, 722);
            panelFichaCliente.TabIndex = 0;
            panelFichaCliente.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ST-Komsomol", 65.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 41, 184);
            label1.Location = new Point(459, -44);
            label1.Name = "label1";
            label1.Size = new Size(318, 140);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // lbl_ContatoR
            // 
            lbl_ContatoR.AutoSize = true;
            lbl_ContatoR.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ContatoR.ForeColor = Color.White;
            lbl_ContatoR.Location = new Point(189, 466);
            lbl_ContatoR.Name = "lbl_ContatoR";
            lbl_ContatoR.Size = new Size(205, 33);
            lbl_ContatoR.TabIndex = 24;
            lbl_ContatoR.Text = "(00) 00000-000";
            // 
            // lbl_ContatoT
            // 
            lbl_ContatoT.AutoSize = true;
            lbl_ContatoT.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ContatoT.ForeColor = Color.White;
            lbl_ContatoT.Location = new Point(60, 458);
            lbl_ContatoT.Name = "lbl_ContatoT";
            lbl_ContatoT.Size = new Size(136, 52);
            lbl_ContatoT.TabIndex = 23;
            lbl_ContatoT.Text = "Contato:";
            // 
            // lbl_EnderecoR
            // 
            lbl_EnderecoR.AutoSize = true;
            lbl_EnderecoR.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_EnderecoR.ForeColor = Color.White;
            lbl_EnderecoR.Location = new Point(203, 417);
            lbl_EnderecoR.Name = "lbl_EnderecoR";
            lbl_EnderecoR.Size = new Size(274, 33);
            lbl_EnderecoR.TabIndex = 22;
            lbl_EnderecoR.Text = "Rua da palmeiras, 123";
            // 
            // lbl_EnderecoT
            // 
            lbl_EnderecoT.AutoSize = true;
            lbl_EnderecoT.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_EnderecoT.ForeColor = Color.White;
            lbl_EnderecoT.Location = new Point(60, 406);
            lbl_EnderecoT.Name = "lbl_EnderecoT";
            lbl_EnderecoT.Size = new Size(155, 52);
            lbl_EnderecoT.TabIndex = 21;
            lbl_EnderecoT.Text = "Endereço:";
            // 
            // lbl_NascimentoR
            // 
            lbl_NascimentoR.AutoSize = true;
            lbl_NascimentoR.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NascimentoR.ForeColor = Color.White;
            lbl_NascimentoR.Location = new Point(240, 360);
            lbl_NascimentoR.Name = "lbl_NascimentoR";
            lbl_NascimentoR.Size = new Size(163, 33);
            lbl_NascimentoR.TabIndex = 20;
            lbl_NascimentoR.Text = "01/01/2000";
            // 
            // lbl_NascimentoT
            // 
            lbl_NascimentoT.AutoSize = true;
            lbl_NascimentoT.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NascimentoT.ForeColor = Color.White;
            lbl_NascimentoT.Location = new Point(60, 354);
            lbl_NascimentoT.Name = "lbl_NascimentoT";
            lbl_NascimentoT.Size = new Size(186, 52);
            lbl_NascimentoT.TabIndex = 19;
            lbl_NascimentoT.Text = "Nascimento:";
            // 
            // lbl_CPFR
            // 
            lbl_CPFR.AutoSize = true;
            lbl_CPFR.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CPFR.ForeColor = Color.White;
            lbl_CPFR.Location = new Point(126, 308);
            lbl_CPFR.Name = "lbl_CPFR";
            lbl_CPFR.Size = new Size(212, 33);
            lbl_CPFR.TabIndex = 17;
            lbl_CPFR.Text = "123.456.789-00";
            // 
            // lbl_CPFT
            // 
            lbl_CPFT.AutoSize = true;
            lbl_CPFT.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CPFT.ForeColor = Color.White;
            lbl_CPFT.Location = new Point(60, 302);
            lbl_CPFT.Name = "lbl_CPFT";
            lbl_CPFT.Size = new Size(74, 52);
            lbl_CPFT.TabIndex = 16;
            lbl_CPFT.Text = "CPF:";
            // 
            // lbl_NomeFuncionarioR
            // 
            lbl_NomeFuncionarioR.AutoSize = true;
            lbl_NomeFuncionarioR.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomeFuncionarioR.ForeColor = Color.White;
            lbl_NomeFuncionarioR.Location = new Point(151, 255);
            lbl_NomeFuncionarioR.Name = "lbl_NomeFuncionarioR";
            lbl_NomeFuncionarioR.Size = new Size(86, 33);
            lbl_NomeFuncionarioR.TabIndex = 15;
            lbl_NomeFuncionarioR.Text = "Nome";
            // 
            // lbl_NomeFuncionarioT
            // 
            lbl_NomeFuncionarioT.AutoSize = true;
            lbl_NomeFuncionarioT.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_NomeFuncionarioT.ForeColor = Color.White;
            lbl_NomeFuncionarioT.Location = new Point(60, 250);
            lbl_NomeFuncionarioT.Name = "lbl_NomeFuncionarioT";
            lbl_NomeFuncionarioT.Size = new Size(100, 52);
            lbl_NomeFuncionarioT.TabIndex = 14;
            lbl_NomeFuncionarioT.Text = "Nome:";
            // 
            // lbl_CodigoCliente
            // 
            lbl_CodigoCliente.AutoSize = true;
            lbl_CodigoCliente.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodigoCliente.ForeColor = Color.White;
            lbl_CodigoCliente.Location = new Point(169, 203);
            lbl_CodigoCliente.Name = "lbl_CodigoCliente";
            lbl_CodigoCliente.Size = new Size(31, 33);
            lbl_CodigoCliente.TabIndex = 26;
            lbl_CodigoCliente.Text = "0";
            // 
            // lbl_CodigoClienteT
            // 
            lbl_CodigoClienteT.AutoSize = true;
            lbl_CodigoClienteT.Font = new Font("Bebas Neue", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodigoClienteT.ForeColor = Color.White;
            lbl_CodigoClienteT.Location = new Point(60, 198);
            lbl_CodigoClienteT.Name = "lbl_CodigoClienteT";
            lbl_CodigoClienteT.Size = new Size(117, 52);
            lbl_CodigoClienteT.TabIndex = 25;
            lbl_CodigoClienteT.Text = "Código:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Código, CPF, Contato });
            dataGridView1.Location = new Point(514, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(690, 560);
            dataGridView1.TabIndex = 27;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            // 
            // CPF
            // 
            CPF.HeaderText = "CPF";
            CPF.Name = "CPF";
            // 
            // Contato
            // 
            Contato.HeaderText = "Contato";
            Contato.Name = "Contato";
            // 
            // btn_Voltar
            // 
            btn_Voltar.BackColor = Color.White;
            btn_Voltar.FlatAppearance.BorderSize = 0;
            btn_Voltar.FlatStyle = FlatStyle.Flat;
            btn_Voltar.Image = (Image)resources.GetObject("btn_Voltar.Image");
            btn_Voltar.Location = new Point(1, -1);
            btn_Voltar.Name = "btn_Voltar";
            btn_Voltar.Size = new Size(48, 48);
            btn_Voltar.TabIndex = 1;
            btn_Voltar.UseVisualStyleBackColor = false;
            btn_Voltar.Click += btn_Voltar_Click;
            // 
            // FrmFichaClienteGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 827);
            Controls.Add(btn_Voltar);
            Controls.Add(panelFichaCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFichaClienteGerente";
            Text = "FrmFichaClienteGerente";
            panelFichaCliente.ResumeLayout(false);
            panelFichaCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFichaCliente;
        private Label label1;
        private Label lbl_ContatoR;
        private Label lbl_ContatoT;
        private Label lbl_EnderecoR;
        private Label lbl_EnderecoT;
        private Label lbl_NascimentoR;
        private Label lbl_NascimentoT;
        private Label lbl_CPFR;
        private Label lbl_CPFT;
        private Label lbl_NomeFuncionarioR;
        private Label lbl_NomeFuncionarioT;
        private Label lbl_CodigoCliente;
        private Label lbl_CodigoClienteT;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Contato;
        private Button btn_Voltar;
    }
}
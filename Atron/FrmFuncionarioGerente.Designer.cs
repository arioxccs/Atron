namespace Atron
{
    partial class FrmFuncionarioGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionarioGerente));
            lbl_Funcionario = new Label();
            btn_CadastrarFuncionario = new Button();
            maskedTextBox1 = new MaskedTextBox();
            tb_funcionarios = new DataGridView();
            NomeFuncionario = new DataGridViewTextBoxColumn();
            FuncaoFuncionario = new DataGridViewTextBoxColumn();
            Cod = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)tb_funcionarios).BeginInit();
            SuspendLayout();
            // 
            // lbl_Funcionario
            // 
            lbl_Funcionario.AutoSize = true;
            lbl_Funcionario.Font = new Font("ST-Komsomol", 51.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Funcionario.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_Funcionario.Location = new Point(12, -24);
            lbl_Funcionario.Name = "lbl_Funcionario";
            lbl_Funcionario.Size = new Size(379, 111);
            lbl_Funcionario.TabIndex = 0;
            lbl_Funcionario.Text = "Funcionários";
            lbl_Funcionario.Click += lbl_Funcionario_Click;
            // 
            // btn_CadastrarFuncionario
            // 
            btn_CadastrarFuncionario.BackColor = Color.FromArgb(255, 162, 71);
            btn_CadastrarFuncionario.Font = new Font("Lato", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CadastrarFuncionario.Image = (Image)resources.GetObject("btn_CadastrarFuncionario.Image");
            btn_CadastrarFuncionario.ImageAlign = ContentAlignment.MiddleRight;
            btn_CadastrarFuncionario.Location = new Point(944, 32);
            btn_CadastrarFuncionario.Name = "btn_CadastrarFuncionario";
            btn_CadastrarFuncionario.Padding = new Padding(10, 0, 10, 0);
            btn_CadastrarFuncionario.Size = new Size(340, 55);
            btn_CadastrarFuncionario.TabIndex = 1;
            btn_CadastrarFuncionario.Text = "Cadastrar Funcionário";
            btn_CadastrarFuncionario.TextAlign = ContentAlignment.MiddleLeft;
            btn_CadastrarFuncionario.UseVisualStyleBackColor = false;
            btn_CadastrarFuncionario.Click += btn_CadastrarFuncionario_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.ForeColor = SystemColors.ScrollBar;
            maskedTextBox1.Location = new Point(83, 105);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.RightToLeft = RightToLeft.No;
            maskedTextBox1.Size = new Size(1120, 43);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.Text = "   Pesquise um funcionário";
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // tb_funcionarios
            // 
            tb_funcionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tb_funcionarios.BackgroundColor = Color.FromArgb(94, 135, 225);
            tb_funcionarios.BorderStyle = BorderStyle.None;
            tb_funcionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tb_funcionarios.Columns.AddRange(new DataGridViewColumn[] { NomeFuncionario, FuncaoFuncionario, Cod, Salario, Status, Contato });
            tb_funcionarios.GridColor = Color.DimGray;
            tb_funcionarios.Location = new Point(36, 176);
            tb_funcionarios.Name = "tb_funcionarios";
            tb_funcionarios.Size = new Size(1236, 584);
            tb_funcionarios.TabIndex = 3;
            tb_funcionarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NomeFuncionario
            // 
            NomeFuncionario.HeaderText = "Nome";
            NomeFuncionario.Name = "NomeFuncionario";
            // 
            // FuncaoFuncionario
            // 
            FuncaoFuncionario.HeaderText = "Função";
            FuncaoFuncionario.Name = "FuncaoFuncionario";
            // 
            // Cod
            // 
            Cod.HeaderText = "Cod";
            Cod.Name = "Cod";
            // 
            // Salario
            // 
            Salario.HeaderText = "Salário";
            Salario.Name = "Salario";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Contato
            // 
            Contato.HeaderText = "Contato";
            Contato.Name = "Contato";
            // 
            // FrmFuncionarioGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1296, 788);
            Controls.Add(tb_funcionarios);
            Controls.Add(maskedTextBox1);
            Controls.Add(btn_CadastrarFuncionario);
            Controls.Add(lbl_Funcionario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFuncionarioGerente";
            Text = "FrmFuncionarioGerente";
            ((System.ComponentModel.ISupportInitialize)tb_funcionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Funcionario;
        private Button btn_CadastrarFuncionario;
        private MaskedTextBox maskedTextBox1;
        private DataGridView tb_funcionarios;
        private DataGridViewTextBoxColumn NomeFuncionario;
        private DataGridViewTextBoxColumn FuncaoFuncionario;
        private DataGridViewTextBoxColumn Cod;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Contato;
    }
}
namespace Atron
{
    partial class FrmClientesGerente
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
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Código = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            Contato = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btn_Visualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Código, CPF, Contato });
            dataGridView1.Location = new Point(39, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1233, 644);
            dataGridView1.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ST-Komsomol", 80.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 41, 184);
            label1.Location = new Point(442, -65);
            label1.Name = "label1";
            label1.Size = new Size(439, 172);
            label1.TabIndex = 1;
            label1.Text = "Clientes";
            // 
            // btn_Visualizar
            // 
            btn_Visualizar.BackColor = Color.FromArgb(14, 41, 184);
            btn_Visualizar.FlatStyle = FlatStyle.Flat;
            btn_Visualizar.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Visualizar.ForeColor = Color.White;
            btn_Visualizar.Location = new Point(1073, 47);
            btn_Visualizar.Name = "btn_Visualizar";
            btn_Visualizar.Size = new Size(199, 44);
            btn_Visualizar.TabIndex = 8;
            btn_Visualizar.Text = "Visualizar";
            btn_Visualizar.UseVisualStyleBackColor = false;
            btn_Visualizar.Click += btn_Visualizar_Click;
            // 
            // FrmClientesGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 827);
            Controls.Add(btn_Visualizar);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmClientesGerente";
            Text = "FrmClientesGerente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn Contato;
        private Button btn_Visualizar;
    }
}
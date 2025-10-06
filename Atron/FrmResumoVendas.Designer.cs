namespace Atron
{
    partial class FrmResumoVendas
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
            lbl_Receita = new Label();
            lbl_Despesa = new Label();
            lbl_Lucro = new Label();
            lbl_ReceitaPreco = new Label();
            lbl_DespesaPreco = new Label();
            lbl_LucroPreco = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            vScrollBar1 = new VScrollBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Receita
            // 
            lbl_Receita.AutoSize = true;
            lbl_Receita.Font = new Font("ST-Komsomol", 50.25F);
            lbl_Receita.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_Receita.Location = new Point(147, -6);
            lbl_Receita.Name = "lbl_Receita";
            lbl_Receita.Size = new Size(221, 108);
            lbl_Receita.TabIndex = 0;
            lbl_Receita.Text = "Receita";
            // 
            // lbl_Despesa
            // 
            lbl_Despesa.AutoSize = true;
            lbl_Despesa.Font = new Font("ST-Komsomol", 50.25F);
            lbl_Despesa.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_Despesa.Location = new Point(526, -6);
            lbl_Despesa.Name = "lbl_Despesa";
            lbl_Despesa.Size = new Size(245, 108);
            lbl_Despesa.TabIndex = 1;
            lbl_Despesa.Text = "Despesa";
            // 
            // lbl_Lucro
            // 
            lbl_Lucro.AutoSize = true;
            lbl_Lucro.Font = new Font("ST-Komsomol", 50.25F);
            lbl_Lucro.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_Lucro.Location = new Point(955, -6);
            lbl_Lucro.Name = "lbl_Lucro";
            lbl_Lucro.Size = new Size(178, 108);
            lbl_Lucro.TabIndex = 2;
            lbl_Lucro.Text = "Lucro";
            // 
            // lbl_ReceitaPreco
            // 
            lbl_ReceitaPreco.AutoSize = true;
            lbl_ReceitaPreco.BackColor = Color.FromArgb(119, 162, 255);
            lbl_ReceitaPreco.Font = new Font("Bebas Neue", 75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ReceitaPreco.ForeColor = Color.White;
            lbl_ReceitaPreco.Location = new Point(110, 102);
            lbl_ReceitaPreco.Name = "lbl_ReceitaPreco";
            lbl_ReceitaPreco.Padding = new Padding(10);
            lbl_ReceitaPreco.Size = new Size(315, 150);
            lbl_ReceitaPreco.TabIndex = 3;
            lbl_ReceitaPreco.Text = "R$1500";
            // 
            // lbl_DespesaPreco
            // 
            lbl_DespesaPreco.AutoSize = true;
            lbl_DespesaPreco.BackColor = Color.FromArgb(119, 162, 255);
            lbl_DespesaPreco.Font = new Font("Bebas Neue", 75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_DespesaPreco.ForeColor = Color.White;
            lbl_DespesaPreco.Location = new Point(503, 102);
            lbl_DespesaPreco.Name = "lbl_DespesaPreco";
            lbl_DespesaPreco.Padding = new Padding(10);
            lbl_DespesaPreco.Size = new Size(315, 150);
            lbl_DespesaPreco.TabIndex = 4;
            lbl_DespesaPreco.Text = "R$1000";
            // 
            // lbl_LucroPreco
            // 
            lbl_LucroPreco.AutoSize = true;
            lbl_LucroPreco.BackColor = Color.FromArgb(119, 162, 255);
            lbl_LucroPreco.Font = new Font("Bebas Neue", 75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_LucroPreco.ForeColor = Color.White;
            lbl_LucroPreco.Location = new Point(897, 102);
            lbl_LucroPreco.Name = "lbl_LucroPreco";
            lbl_LucroPreco.Padding = new Padding(10);
            lbl_LucroPreco.Size = new Size(275, 150);
            lbl_LucroPreco.TabIndex = 5;
            lbl_LucroPreco.Text = "R$500";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ST-Komsomol", 50.25F);
            label1.ForeColor = Color.FromArgb(14, 41, 184);
            label1.Location = new Point(0, 252);
            label1.Name = "label1";
            label1.Size = new Size(503, 108);
            label1.TabIndex = 6;
            label1.Text = "Gráfico de Vendas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 363);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1252, 670);
            dataGridView1.TabIndex = 7;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1282, -6);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 1066);
            vScrollBar1.TabIndex = 8;
            // 
            // FrmResumoVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1313, 1078);
            Controls.Add(vScrollBar1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(lbl_LucroPreco);
            Controls.Add(lbl_DespesaPreco);
            Controls.Add(lbl_ReceitaPreco);
            Controls.Add(lbl_Lucro);
            Controls.Add(lbl_Despesa);
            Controls.Add(lbl_Receita);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmResumoVendas";
            Text = "FrmResumoVendas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Receita;
        private Label lbl_Despesa;
        private Label lbl_Lucro;
        private Label lbl_ReceitaPreco;
        private Label lbl_DespesaPreco;
        private Label lbl_LucroPreco;
        private Label label1;
        private DataGridView dataGridView1;
        private VScrollBar vScrollBar1;
    }
}
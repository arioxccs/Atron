namespace Atron
{
    partial class frmPopUpSenhaAbrirCaixa
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            lblTitulo = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            lbl1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 179, 92);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 246);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(9, 28, 128);
            label1.Location = new Point(51, 34);
            label1.Name = "label1";
            label1.Size = new Size(112, 27);
            label1.TabIndex = 2;
            label1.Text = "ABRIR O CAIXA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lbl1);
            panel2.Location = new Point(19, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(44, 62);
            panel2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bebas Neue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(9, 28, 128);
            lblTitulo.Location = new Point(24, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 27);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DIGITE SUA SENHA PARA";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(69, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(44, 62);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label3);
            panel4.Location = new Point(119, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(44, 62);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(169, 86);
            panel5.Name = "panel5";
            panel5.Size = new Size(44, 62);
            panel5.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(186, 89, 0);
            btnConfirmar.Font = new Font("Lato", 7F);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(119, 193);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(104, 34);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar senha";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(186, 89, 0);
            btnCancelar.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(9, 193);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Segoe UI", 40F);
            lbl1.Location = new Point(0, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(53, 72);
            lbl1.TabIndex = 7;
            lbl1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 40F);
            label2.Location = new Point(0, 9);
            label2.Name = "label2";
            label2.Size = new Size(53, 72);
            label2.TabIndex = 8;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 40F);
            label3.Location = new Point(0, 9);
            label3.Name = "label3";
            label3.Size = new Size(53, 72);
            label3.TabIndex = 9;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 40F);
            label4.Location = new Point(1, 9);
            label4.Name = "label4";
            label4.Size = new Size(53, 72);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // frmTelaSenhaAbrirCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 248);
            Controls.Add(panel1);
            Name = "frmTelaSenhaAbrirCaixa";
            Text = "frmTelaSenhaAbrirCaixa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitulo;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Panel panel5;
        private Label label4;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label lbl1;
    }
}
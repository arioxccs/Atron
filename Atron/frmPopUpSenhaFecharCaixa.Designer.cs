namespace Atron
{
    partial class frmPopUpSenhaFecharCaixa
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
            btnCancelar = new Button();
            btnConfirmar = new Button();
            label1 = new Label();
            lblTitulo = new Label();
            txtCaractere4 = new TextBox();
            txtCaractere3 = new TextBox();
            txtCaractere2 = new TextBox();
            txtCaractere1 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 179, 92);
            panel1.Controls.Add(txtCaractere4);
            panel1.Controls.Add(txtCaractere3);
            panel1.Controls.Add(txtCaractere2);
            panel1.Controls.Add(txtCaractere1);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 328);
            panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(186, 89, 0);
            btnCancelar.Font = new Font("Lato", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(10, 257);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 45);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(186, 89, 0);
            btnConfirmar.Font = new Font("Lato", 7F);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(136, 257);
            btnConfirmar.Margin = new Padding(3, 4, 3, 4);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(119, 45);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar senha";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bebas Neue", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(9, 28, 128);
            label1.Location = new Point(54, 48);
            label1.Name = "label1";
            label1.Size = new Size(158, 35);
            label1.TabIndex = 2;
            label1.Text = "fechar O CAIXA";
            label1.Click += label1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bebas Neue", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(9, 28, 128);
            lblTitulo.Location = new Point(27, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(228, 35);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DIGITE SUA SENHA PARA";
            // 
            // txtCaractere4
            // 
            txtCaractere4.Font = new Font("Segoe UI", 35F);
            txtCaractere4.Location = new Point(195, 122);
            txtCaractere4.Name = "txtCaractere4";
            txtCaractere4.Size = new Size(51, 85);
            txtCaractere4.TabIndex = 13;
            txtCaractere4.Text = "*";
            txtCaractere4.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCaractere3
            // 
            txtCaractere3.Font = new Font("Segoe UI", 35F);
            txtCaractere3.Location = new Point(138, 122);
            txtCaractere3.Name = "txtCaractere3";
            txtCaractere3.Size = new Size(51, 85);
            txtCaractere3.TabIndex = 12;
            txtCaractere3.Text = "*";
            txtCaractere3.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCaractere2
            // 
            txtCaractere2.Font = new Font("Segoe UI", 35F);
            txtCaractere2.Location = new Point(81, 122);
            txtCaractere2.Name = "txtCaractere2";
            txtCaractere2.Size = new Size(51, 85);
            txtCaractere2.TabIndex = 11;
            txtCaractere2.Text = "*";
            txtCaractere2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCaractere1
            // 
            txtCaractere1.Font = new Font("Segoe UI", 35F);
            txtCaractere1.ImeMode = ImeMode.NoControl;
            txtCaractere1.Location = new Point(24, 122);
            txtCaractere1.Name = "txtCaractere1";
            txtCaractere1.Size = new Size(51, 85);
            txtCaractere1.TabIndex = 10;
            txtCaractere1.Text = "*";
            txtCaractere1.TextAlign = HorizontalAlignment.Center;
            // 
            // frmPopUpSenhaFecharCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(267, 329);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPopUpSenhaFecharCaixa";
            Text = "frmPopUpSenhaFecharCaixa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnConfirmar;
        private Label label1;
        private Label lblTitulo;
        private TextBox txtCaractere4;
        private TextBox txtCaractere3;
        private TextBox txtCaractere2;
        private TextBox txtCaractere1;
    }
}
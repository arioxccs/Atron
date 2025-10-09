namespace Atron
{
    partial class frmAvisoSenhaIncorreta
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
            lblTitulo = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bebas Neue", 12F);
            lblTitulo.Location = new Point(25, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Para prosseguir, a autenticação foi enviada ao superior.";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(34, 95, 226);
            flowLayoutPanel1.Location = new Point(12, 33);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(333, 35);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 38);
            panel1.TabIndex = 2;
            // 
            // frmAvisoSenhaIncorreta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblTitulo);
            Name = "frmAvisoSenhaIncorreta";
            Text = "frmAvisoSenhaIncorreta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}
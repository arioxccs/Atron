namespace Atron
{
    partial class frmPopUpConfirmarCancelamento
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
            lblTexto = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Bebas Neue", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(148, 9);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(333, 48);
            lblTexto.TabIndex = 0;
            lblTexto.Text = "Deseja cancelar a venda?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 164, 86);
            button1.Font = new Font("Bebas Neue", 22.2F);
            button1.Location = new Point(25, 104);
            button1.Name = "button1";
            button1.Size = new Size(265, 74);
            button1.TabIndex = 1;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 0, 4);
            button2.Font = new Font("Bebas Neue", 22.2F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(334, 104);
            button2.Name = "button2";
            button2.Size = new Size(265, 74);
            button2.TabIndex = 2;
            button2.Text = "Cancelar venda";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // frmPopUpConfirmarCancelamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 223);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblTexto);
            Name = "frmPopUpConfirmarCancelamento";
            Text = "frmPopUpConfirmarCacelamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto;
        private Button button1;
        private Button button2;
    }
}
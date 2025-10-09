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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAvisoSenhaIncorreta));
            picAviso = new PictureBox();
            lblTempo = new Label();
            ((System.ComponentModel.ISupportInitialize)picAviso).BeginInit();
            SuspendLayout();
            // 
            // picAviso
            // 
            picAviso.Image = (Image)resources.GetObject("picAviso.Image");
            picAviso.Location = new Point(-17, -67);
            picAviso.Name = "picAviso";
            picAviso.Size = new Size(502, 283);
            picAviso.SizeMode = PictureBoxSizeMode.StretchImage;
            picAviso.TabIndex = 0;
            picAviso.TabStop = false;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.BackColor = Color.FromArgb(30, 79, 119);
            lblTempo.Font = new Font("Bebas Neue", 14F);
            lblTempo.ForeColor = Color.White;
            lblTempo.Location = new Point(120, 78);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(224, 31);
            lblTempo.TabIndex = 1;
            lblTempo.Text = "tENTE NOVAMENTE EM 2 MIN";
            // 
            // frmAvisoSenhaIncorreta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(469, 121);
            Controls.Add(lblTempo);
            Controls.Add(picAviso);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAvisoSenhaIncorreta";
            Text = "frmAvisoSenhaIncorreta";
            ((System.ComponentModel.ISupportInitialize)picAviso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picAviso;
        private Label lblTempo;
    }
}
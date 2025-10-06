namespace Atron
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pic_Logo = new PictureBox();
            lbl_CodigoLogin = new Label();
            txt_CodigoLogin = new TextBox();
            txt_SenhaLogin = new TextBox();
            lbl_SenhaLogin = new Label();
            btn_EntrarLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Logo).BeginInit();
            SuspendLayout();
            // 
            // pic_Logo
            // 
            pic_Logo.Image = (Image)resources.GetObject("pic_Logo.Image");
            pic_Logo.Location = new Point(586, 11);
            pic_Logo.Margin = new Padding(3, 2, 3, 2);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(219, 188);
            pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Logo.TabIndex = 0;
            pic_Logo.TabStop = false;
            pic_Logo.Click += pictureBox1_Click;
            // 
            // lbl_CodigoLogin
            // 
            lbl_CodigoLogin.AutoSize = true;
            lbl_CodigoLogin.Font = new Font("Bebas Neue", 41.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodigoLogin.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_CodigoLogin.Location = new Point(253, 257);
            lbl_CodigoLogin.Name = "lbl_CodigoLogin";
            lbl_CodigoLogin.Size = new Size(153, 73);
            lbl_CodigoLogin.TabIndex = 1;
            lbl_CodigoLogin.Text = "Código";
            // 
            // txt_CodigoLogin
            // 
            txt_CodigoLogin.BackColor = Color.White;
            txt_CodigoLogin.Font = new Font("Lato", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CodigoLogin.ForeColor = Color.Black;
            txt_CodigoLogin.Location = new Point(265, 333);
            txt_CodigoLogin.Name = "txt_CodigoLogin";
            txt_CodigoLogin.PlaceholderText = "  Código";
            txt_CodigoLogin.Size = new Size(826, 46);
            txt_CodigoLogin.TabIndex = 2;
            // 
            // txt_SenhaLogin
            // 
            txt_SenhaLogin.BackColor = Color.White;
            txt_SenhaLogin.Font = new Font("Lato", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_SenhaLogin.ForeColor = Color.Black;
            txt_SenhaLogin.Location = new Point(265, 511);
            txt_SenhaLogin.Name = "txt_SenhaLogin";
            txt_SenhaLogin.PlaceholderText = "  Senha";
            txt_SenhaLogin.Size = new Size(826, 46);
            txt_SenhaLogin.TabIndex = 4;
            txt_SenhaLogin.TextChanged += txt_SenhaLogin_TextChanged;
            // 
            // lbl_SenhaLogin
            // 
            lbl_SenhaLogin.AutoSize = true;
            lbl_SenhaLogin.Font = new Font("Bebas Neue", 41.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_SenhaLogin.ForeColor = Color.FromArgb(14, 41, 184);
            lbl_SenhaLogin.Location = new Point(253, 435);
            lbl_SenhaLogin.Name = "lbl_SenhaLogin";
            lbl_SenhaLogin.Size = new Size(143, 73);
            lbl_SenhaLogin.TabIndex = 3;
            lbl_SenhaLogin.Text = "Senha";
            lbl_SenhaLogin.Click += label2_Click;
            // 
            // btn_EntrarLogin
            // 
            btn_EntrarLogin.BackColor = Color.FromArgb(250, 241, 218);
            btn_EntrarLogin.FlatAppearance.BorderColor = Color.FromArgb(14, 41, 184);
            btn_EntrarLogin.FlatAppearance.BorderSize = 3;
            btn_EntrarLogin.FlatStyle = FlatStyle.Flat;
            btn_EntrarLogin.Font = new Font("Bebas Neue", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_EntrarLogin.ForeColor = Color.FromArgb(14, 41, 184);
            btn_EntrarLogin.Location = new Point(435, 687);
            btn_EntrarLogin.Name = "btn_EntrarLogin";
            btn_EntrarLogin.Size = new Size(535, 96);
            btn_EntrarLogin.TabIndex = 5;
            btn_EntrarLogin.Text = "Entrar";
            btn_EntrarLogin.UseVisualStyleBackColor = false;
            btn_EntrarLogin.Click += button1_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 241, 218);
            ClientSize = new Size(1424, 891);
            Controls.Add(txt_SenhaLogin);
            Controls.Add(btn_EntrarLogin);
            Controls.Add(lbl_SenhaLogin);
            Controls.Add(txt_CodigoLogin);
            Controls.Add(lbl_CodigoLogin);
            Controls.Add(pic_Logo);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmLogin";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Logo;
        private Label lbl_CodigoLogin;
        private TextBox txt_CodigoLogin;
        private TextBox txt_SenhaLogin;
        private Label lbl_SenhaLogin;
        private Button btn_EntrarLogin;
    }
}

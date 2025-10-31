namespace Atron
{
    partial class frmGerenciamentoConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciamentoConsultas));
            button1 = new Button();
            lbl_GerenciamentodeConsulta = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 42, 45);
            button1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(70, 168);
            button1.Name = "button1";
            button1.Size = new Size(385, 285);
            button1.TabIndex = 4;
            button1.Text = "CONSULTA DE PRODUTOS";
            button1.TextAlign = ContentAlignment.TopLeft;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_GerenciamentodeConsulta
            // 
            lbl_GerenciamentodeConsulta.AutoSize = true;
            lbl_GerenciamentodeConsulta.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_GerenciamentodeConsulta.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_GerenciamentodeConsulta.Location = new Point(70, 75);
            lbl_GerenciamentodeConsulta.Name = "lbl_GerenciamentodeConsulta";
            lbl_GerenciamentodeConsulta.Size = new Size(803, 55);
            lbl_GerenciamentodeConsulta.TabIndex = 3;
            lbl_GerenciamentodeConsulta.Text = "GERENCIAMENTO DE CONSULTA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 42, 45);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 338);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(91, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 8);
            panel1.TabIndex = 136;
            // 
            // frmGerenciamentoConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 827);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lbl_GerenciamentodeConsulta);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGerenciamentoConsultas";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label lbl_GerenciamentodeConsulta;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
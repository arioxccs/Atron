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
            button2 = new Button();
            button1 = new Button();
            lbl_GerenciamentodeConsulta = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(189, 255, 153);
            button2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.BottomRight;
            button2.Location = new Point(476, 168);
            button2.Name = "button2";
            button2.Size = new Size(385, 285);
            button2.TabIndex = 5;
            button2.Text = "CONSULTA DE PEDIDOS";
            button2.TextAlign = ContentAlignment.TopLeft;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(189, 255, 153);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(658, 308);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
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
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_GerenciamentodeConsulta);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGerenciamentoConsultas";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Label lbl_GerenciamentodeConsulta;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}
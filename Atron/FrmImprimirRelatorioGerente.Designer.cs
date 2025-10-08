namespace Atron
{
    partial class FrmImprimirRelatorioGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImprimirRelatorioGerente));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btn_CertoRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ST-Komsomol", 69.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 41, 184);
            label1.Location = new Point(273, -38);
            label1.Name = "label1";
            label1.Size = new Size(759, 150);
            label1.TabIndex = 0;
            label1.Text = "Impressão Relatório";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(99, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1083, 728);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_CertoRelatorio
            // 
            btn_CertoRelatorio.BackColor = Color.FromArgb(14, 41, 184);
            btn_CertoRelatorio.FlatAppearance.BorderSize = 0;
            btn_CertoRelatorio.Image = (Image)resources.GetObject("btn_CertoRelatorio.Image");
            btn_CertoRelatorio.Location = new Point(1199, 705);
            btn_CertoRelatorio.Name = "btn_CertoRelatorio";
            btn_CertoRelatorio.Size = new Size(110, 110);
            btn_CertoRelatorio.TabIndex = 14;
            btn_CertoRelatorio.UseVisualStyleBackColor = false;
            btn_CertoRelatorio.Click += btn_CertoRelatorio_Click;
            // 
            // FrmImprimirRelatorioGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 827);
            Controls.Add(btn_CertoRelatorio);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmImprimirRelatorioGerente";
            Text = "FrmImprimirRelatorioGerente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_CertoRelatorio;
    }
}
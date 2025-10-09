namespace Atron
{
    partial class frmBuscaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscaProduto));
            picVoltar = new PictureBox();
            txtPesquisa = new TextBox();
            picBuscar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picVoltar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).BeginInit();
            SuspendLayout();
            // 
            // picVoltar
            // 
            picVoltar.Image = (Image)resources.GetObject("picVoltar.Image");
            picVoltar.Location = new Point(0, 0);
            picVoltar.Margin = new Padding(3, 4, 3, 4);
            picVoltar.Name = "picVoltar";
            picVoltar.Size = new Size(75, 88);
            picVoltar.SizeMode = PictureBoxSizeMode.StretchImage;
            picVoltar.TabIndex = 0;
            picVoltar.TabStop = false;
            picVoltar.UseWaitCursor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Font = new Font("Bebas Neue", 26F);
            txtPesquisa.ForeColor = Color.Gray;
            txtPesquisa.Location = new Point(354, 107);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(899, 64);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.Text = "     Buscar Produto";
            txtPesquisa.TextChanged += textBox1_TextChanged;
            // 
            // picBuscar
            // 
            picBuscar.Image = (Image)resources.GetObject("picBuscar.Image");
            picBuscar.Location = new Point(1110, 684);
            picBuscar.Margin = new Padding(3, 4, 3, 4);
            picBuscar.Name = "picBuscar";
            picBuscar.Size = new Size(335, 211);
            picBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            picBuscar.TabIndex = 2;
            picBuscar.TabStop = false;
            picBuscar.Click += pictureBox2_Click;
            // 
            // frmBuscaProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 881);
            Controls.Add(picBuscar);
            Controls.Add(txtPesquisa);
            Controls.Add(picVoltar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBuscaProduto";
            Text = "frmBuscaProduto";
            ((System.ComponentModel.ISupportInitialize)picVoltar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picVoltar;
        private TextBox txtPesquisa;
        private PictureBox picBuscar;
    }
}
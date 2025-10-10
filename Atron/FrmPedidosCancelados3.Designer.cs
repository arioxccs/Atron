namespace Atron
{
    partial class FrmPedidosCancelados3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidosCancelados3));
            btnOk = new Button();
            lblInfQuantMin = new Label();
            lblInfNome = new Label();
            lbl_QtdeRPop = new Label();
            lbl_CodProdutoRPop = new Label();
            lbl_MarcaPop = new Label();
            panel1 = new Panel();
            ptbAlerta = new PictureBox();
            lbl_PopUpNomeProduto = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAlerta).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Image = (Image)resources.GetObject("btnOk.Image");
            btnOk.Location = new Point(929, 803);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(121, 144);
            btnOk.TabIndex = 68;
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblInfQuantMin
            // 
            lblInfQuantMin.AutoSize = true;
            lblInfQuantMin.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfQuantMin.ForeColor = Color.FromArgb(26, 76, 117);
            lblInfQuantMin.Location = new Point(381, 528);
            lblInfQuantMin.Name = "lblInfQuantMin";
            lblInfQuantMin.Size = new Size(329, 42);
            lblInfQuantMin.TabIndex = 63;
            lblInfQuantMin.Text = "login para aprovar.";
            // 
            // lblInfNome
            // 
            lblInfNome.AutoSize = true;
            lblInfNome.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfNome.ForeColor = Color.FromArgb(26, 76, 117);
            lblInfNome.Location = new Point(251, 229);
            lblInfNome.Name = "lblInfNome";
            lblInfNome.Size = new Size(685, 42);
            lblInfNome.TabIndex = 61;
            lblInfNome.Text = "ERRO AO REATIVAR O PRODUTO! 🚫";
            lblInfNome.Click += lblInfNome_Click;
            // 
            // lbl_QtdeRPop
            // 
            lbl_QtdeRPop.AutoSize = true;
            lbl_QtdeRPop.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_QtdeRPop.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_QtdeRPop.Location = new Point(80, 457);
            lbl_QtdeRPop.Name = "lbl_QtdeRPop";
            lbl_QtdeRPop.Size = new Size(1024, 42);
            lbl_QtdeRPop.TabIndex = 59;
            lbl_QtdeRPop.Text = " Você pode solicitar a reativação, e o gerente precisará fazer";
            // 
            // lbl_CodProdutoRPop
            // 
            lbl_CodProdutoRPop.AutoSize = true;
            lbl_CodProdutoRPop.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodProdutoRPop.ForeColor = Color.FromArgb(26, 76, 117);
            lbl_CodProdutoRPop.Location = new Point(139, 387);
            lbl_CodProdutoRPop.Name = "lbl_CodProdutoRPop";
            lbl_CodProdutoRPop.Size = new Size(845, 42);
            lbl_CodProdutoRPop.TabIndex = 58;
            lbl_CodProdutoRPop.Text = " Apenas o gerente pode confirmar novos pedidos.";
            // 
            // lbl_MarcaPop
            // 
            lbl_MarcaPop.AutoSize = true;
            lbl_MarcaPop.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Underline);
            lbl_MarcaPop.ForeColor = Color.FromArgb(255, 122, 0);
            lbl_MarcaPop.Location = new Point(14, 589);
            lbl_MarcaPop.Name = "lbl_MarcaPop";
            lbl_MarcaPop.Size = new Size(0, 52);
            lbl_MarcaPop.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(119, 162, 255);
            panel1.Controls.Add(ptbAlerta);
            panel1.Controls.Add(lbl_PopUpNomeProduto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 129);
            panel1.TabIndex = 53;
            // 
            // ptbAlerta
            // 
            ptbAlerta.Image = (Image)resources.GetObject("ptbAlerta.Image");
            ptbAlerta.Location = new Point(334, 32);
            ptbAlerta.Margin = new Padding(3, 4, 3, 4);
            ptbAlerta.Name = "ptbAlerta";
            ptbAlerta.Size = new Size(54, 65);
            ptbAlerta.TabIndex = 1;
            ptbAlerta.TabStop = false;
            // 
            // lbl_PopUpNomeProduto
            // 
            lbl_PopUpNomeProduto.AutoSize = true;
            lbl_PopUpNomeProduto.Font = new Font("Microsoft Sans Serif", 33.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PopUpNomeProduto.ForeColor = Color.White;
            lbl_PopUpNomeProduto.Location = new Point(429, 32);
            lbl_PopUpNomeProduto.Name = "lbl_PopUpNomeProduto";
            lbl_PopUpNomeProduto.Size = new Size(229, 65);
            lbl_PopUpNomeProduto.TabIndex = 0;
            lbl_PopUpNomeProduto.Text = "Produto";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 122, 0);
            button1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(365, 683);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(358, 109);
            button1.TabIndex = 69;
            button1.Text = "Solicitar a reativação";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmPedidosCancelados3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 951);
            Controls.Add(button1);
            Controls.Add(btnOk);
            Controls.Add(lblInfQuantMin);
            Controls.Add(lblInfNome);
            Controls.Add(lbl_QtdeRPop);
            Controls.Add(lbl_CodProdutoRPop);
            Controls.Add(lbl_MarcaPop);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPedidosCancelados3";
            Text = "FrmPedidosCancelados3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAlerta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label lblInfQuantMin;
        private Label lblInfNome;
        private Label lbl_QtdeRPop;
        private Label lbl_CodProdutoRPop;
        private Label lbl_MarcaPop;
        private Panel panel1;
        private PictureBox ptbAlerta;
        private Label lbl_PopUpNomeProduto;
        private Button button1;
    }
}
namespace Atron
{
    partial class FrmEstoquePrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoquePrincipal));
            panel_MenuEstoque = new Panel();
            btn_HistoricoMenu = new Button();
            btn_PedidosMenu = new Button();
            btn_ConsultarMenu = new Button();
            btn_RegistrarMenu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            panelForm = new Panel();
            panel_MenuEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_MenuEstoque
            // 
            panel_MenuEstoque.BackColor = Color.FromArgb(255, 151, 55);
            panel_MenuEstoque.Controls.Add(btn_HistoricoMenu);
            panel_MenuEstoque.Controls.Add(btn_PedidosMenu);
            panel_MenuEstoque.Controls.Add(btn_ConsultarMenu);
            panel_MenuEstoque.Controls.Add(btn_RegistrarMenu);
            panel_MenuEstoque.Controls.Add(pictureBox1);
            panel_MenuEstoque.Location = new Point(0, 62);
            panel_MenuEstoque.Name = "panel_MenuEstoque";
            panel_MenuEstoque.Size = new Size(120, 830);
            panel_MenuEstoque.TabIndex = 1;
            // 
            // btn_HistoricoMenu
            // 
            btn_HistoricoMenu.BackColor = Color.FromArgb(255, 151, 54);
            btn_HistoricoMenu.FlatAppearance.BorderSize = 0;
            btn_HistoricoMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_HistoricoMenu.FlatStyle = FlatStyle.Flat;
            btn_HistoricoMenu.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_HistoricoMenu.ForeColor = Color.White;
            btn_HistoricoMenu.Image = (Image)resources.GetObject("btn_HistoricoMenu.Image");
            btn_HistoricoMenu.Location = new Point(12, 258);
            btn_HistoricoMenu.Name = "btn_HistoricoMenu";
            btn_HistoricoMenu.Size = new Size(94, 68);
            btn_HistoricoMenu.TabIndex = 7;
            btn_HistoricoMenu.Text = "Histórico";
            btn_HistoricoMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_HistoricoMenu.UseVisualStyleBackColor = false;
            btn_HistoricoMenu.Click += button3_Click;
            // 
            // btn_PedidosMenu
            // 
            btn_PedidosMenu.BackColor = Color.FromArgb(255, 151, 54);
            btn_PedidosMenu.FlatAppearance.BorderSize = 0;
            btn_PedidosMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_PedidosMenu.FlatStyle = FlatStyle.Flat;
            btn_PedidosMenu.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_PedidosMenu.ForeColor = Color.White;
            btn_PedidosMenu.Image = (Image)resources.GetObject("btn_PedidosMenu.Image");
            btn_PedidosMenu.Location = new Point(12, 184);
            btn_PedidosMenu.Name = "btn_PedidosMenu";
            btn_PedidosMenu.Size = new Size(94, 68);
            btn_PedidosMenu.TabIndex = 6;
            btn_PedidosMenu.Text = "Pedido";
            btn_PedidosMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_PedidosMenu.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarMenu
            // 
            btn_ConsultarMenu.BackColor = Color.FromArgb(255, 151, 54);
            btn_ConsultarMenu.FlatAppearance.BorderSize = 0;
            btn_ConsultarMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_ConsultarMenu.FlatStyle = FlatStyle.Flat;
            btn_ConsultarMenu.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_ConsultarMenu.ForeColor = Color.White;
            btn_ConsultarMenu.Image = (Image)resources.GetObject("btn_ConsultarMenu.Image");
            btn_ConsultarMenu.Location = new Point(12, 110);
            btn_ConsultarMenu.Name = "btn_ConsultarMenu";
            btn_ConsultarMenu.Size = new Size(94, 68);
            btn_ConsultarMenu.TabIndex = 5;
            btn_ConsultarMenu.Text = "Consultar";
            btn_ConsultarMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ConsultarMenu.UseVisualStyleBackColor = false;
            // 
            // btn_RegistrarMenu
            // 
            btn_RegistrarMenu.BackColor = Color.FromArgb(255, 151, 54);
            btn_RegistrarMenu.FlatAppearance.BorderSize = 0;
            btn_RegistrarMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_RegistrarMenu.FlatStyle = FlatStyle.Flat;
            btn_RegistrarMenu.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_RegistrarMenu.ForeColor = Color.White;
            btn_RegistrarMenu.Image = (Image)resources.GetObject("btn_RegistrarMenu.Image");
            btn_RegistrarMenu.Location = new Point(12, 36);
            btn_RegistrarMenu.Name = "btn_RegistrarMenu";
            btn_RegistrarMenu.Size = new Size(94, 68);
            btn_RegistrarMenu.TabIndex = 4;
            btn_RegistrarMenu.Text = "Registrar";
            btn_RegistrarMenu.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_RegistrarMenu.UseVisualStyleBackColor = false;
            btn_RegistrarMenu.Click += btn_RegistrarMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1424, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(112, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 827);
            panel2.TabIndex = 3;
            // 
            // panelForm
            // 
            panelForm.Location = new Point(115, 63);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(1312, 827);
            panelForm.TabIndex = 3;
            // 
            // FrmEstoquePrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 891);
            Controls.Add(panelForm);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel_MenuEstoque);
            Name = "FrmEstoquePrincipal";
            Text = "GerenciamentoRegisttro";
            panel_MenuEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_MenuEstoque;
        private PictureBox pictureBox1;
        private Button btn_RegistrarMenu;
        private Button btn_ConsultarMenu;
        private Button btn_HistoricoMenu;
        private Button btn_PedidosMenu;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panelForm;
    }
}
namespace Atron
{
    partial class FrmGerentePrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerentePrincipal));
            pictureBox2 = new PictureBox();
            panel_MenuEstoque = new Panel();
            btn_DespesasMenuGerente = new Button();
            btn_FuncionariosMenuGerente = new Button();
            btn_EstoqueMenuGerente = new Button();
            btn_VendasMenuGerente = new Button();
            pictureBox1 = new PictureBox();
            btn_ClienteMenuGerente = new Button();
            btn_pedidosMenuGerente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_MenuEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 179, 92);
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1424, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel_MenuEstoque
            // 
            panel_MenuEstoque.BackColor = Color.FromArgb(255, 179, 92);
            panel_MenuEstoque.Controls.Add(btn_pedidosMenuGerente);
            panel_MenuEstoque.Controls.Add(btn_ClienteMenuGerente);
            panel_MenuEstoque.Controls.Add(btn_DespesasMenuGerente);
            panel_MenuEstoque.Controls.Add(btn_FuncionariosMenuGerente);
            panel_MenuEstoque.Controls.Add(btn_EstoqueMenuGerente);
            panel_MenuEstoque.Controls.Add(btn_VendasMenuGerente);
            panel_MenuEstoque.Controls.Add(pictureBox1);
            panel_MenuEstoque.Location = new Point(0, 61);
            panel_MenuEstoque.Name = "panel_MenuEstoque";
            panel_MenuEstoque.Size = new Size(120, 830);
            panel_MenuEstoque.TabIndex = 3;
            // 
            // btn_DespesasMenuGerente
            // 
            btn_DespesasMenuGerente.BackColor = Color.FromArgb(255, 179, 92);
            btn_DespesasMenuGerente.FlatAppearance.BorderSize = 0;
            btn_DespesasMenuGerente.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_DespesasMenuGerente.FlatStyle = FlatStyle.Flat;
            btn_DespesasMenuGerente.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_DespesasMenuGerente.ForeColor = Color.White;
            btn_DespesasMenuGerente.Image = (Image)resources.GetObject("btn_DespesasMenuGerente.Image");
            btn_DespesasMenuGerente.Location = new Point(12, 258);
            btn_DespesasMenuGerente.Name = "btn_DespesasMenuGerente";
            btn_DespesasMenuGerente.Size = new Size(94, 68);
            btn_DespesasMenuGerente.TabIndex = 7;
            btn_DespesasMenuGerente.Text = "Despesas";
            btn_DespesasMenuGerente.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_DespesasMenuGerente.UseVisualStyleBackColor = false;
            // 
            // btn_FuncionariosMenuGerente
            // 
            btn_FuncionariosMenuGerente.BackColor = Color.FromArgb(255, 179, 92);
            btn_FuncionariosMenuGerente.FlatAppearance.BorderSize = 0;
            btn_FuncionariosMenuGerente.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_FuncionariosMenuGerente.FlatStyle = FlatStyle.Flat;
            btn_FuncionariosMenuGerente.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_FuncionariosMenuGerente.ForeColor = Color.White;
            btn_FuncionariosMenuGerente.Image = (Image)resources.GetObject("btn_FuncionariosMenuGerente.Image");
            btn_FuncionariosMenuGerente.Location = new Point(12, 184);
            btn_FuncionariosMenuGerente.Name = "btn_FuncionariosMenuGerente";
            btn_FuncionariosMenuGerente.Size = new Size(94, 68);
            btn_FuncionariosMenuGerente.TabIndex = 6;
            btn_FuncionariosMenuGerente.Text = "Pedido";
            btn_FuncionariosMenuGerente.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_FuncionariosMenuGerente.UseVisualStyleBackColor = false;
            // 
            // btn_EstoqueMenuGerente
            // 
            btn_EstoqueMenuGerente.BackColor = Color.FromArgb(255, 179, 92);
            btn_EstoqueMenuGerente.FlatAppearance.BorderSize = 0;
            btn_EstoqueMenuGerente.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_EstoqueMenuGerente.FlatStyle = FlatStyle.Flat;
            btn_EstoqueMenuGerente.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_EstoqueMenuGerente.ForeColor = Color.White;
            btn_EstoqueMenuGerente.Image = (Image)resources.GetObject("btn_EstoqueMenuGerente.Image");
            btn_EstoqueMenuGerente.Location = new Point(12, 110);
            btn_EstoqueMenuGerente.Name = "btn_EstoqueMenuGerente";
            btn_EstoqueMenuGerente.Size = new Size(94, 68);
            btn_EstoqueMenuGerente.TabIndex = 5;
            btn_EstoqueMenuGerente.Text = "Estoque";
            btn_EstoqueMenuGerente.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_EstoqueMenuGerente.UseVisualStyleBackColor = false;
            // 
            // btn_VendasMenuGerente
            // 
            btn_VendasMenuGerente.BackColor = Color.FromArgb(255, 179, 92);
            btn_VendasMenuGerente.FlatAppearance.BorderSize = 0;
            btn_VendasMenuGerente.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_VendasMenuGerente.FlatStyle = FlatStyle.Flat;
            btn_VendasMenuGerente.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_VendasMenuGerente.ForeColor = Color.White;
            btn_VendasMenuGerente.Image = (Image)resources.GetObject("btn_VendasMenuGerente.Image");
            btn_VendasMenuGerente.Location = new Point(12, 36);
            btn_VendasMenuGerente.Name = "btn_VendasMenuGerente";
            btn_VendasMenuGerente.Size = new Size(94, 68);
            btn_VendasMenuGerente.TabIndex = 4;
            btn_VendasMenuGerente.Text = "Vendas";
            btn_VendasMenuGerente.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_VendasMenuGerente.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btn_ClienteMenuGerente
            // 
            btn_ClienteMenuGerente.BackColor = Color.FromArgb(255, 179, 92);
            btn_ClienteMenuGerente.FlatAppearance.BorderSize = 0;
            btn_ClienteMenuGerente.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_ClienteMenuGerente.FlatStyle = FlatStyle.Flat;
            btn_ClienteMenuGerente.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_ClienteMenuGerente.ForeColor = Color.White;
            btn_ClienteMenuGerente.Image = (Image)resources.GetObject("btn_ClienteMenuGerente.Image");
            btn_ClienteMenuGerente.Location = new Point(12, 332);
            btn_ClienteMenuGerente.Name = "btn_ClienteMenuGerente";
            btn_ClienteMenuGerente.Size = new Size(94, 68);
            btn_ClienteMenuGerente.TabIndex = 8;
            btn_ClienteMenuGerente.Text = "Clientes";
            btn_ClienteMenuGerente.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_ClienteMenuGerente.UseVisualStyleBackColor = false;
            // 
            // btn_pedidosMenuGerente
            // 
            btn_pedidosMenuGerente.BackColor = Color.FromArgb(255, 179, 92);
            btn_pedidosMenuGerente.FlatAppearance.BorderSize = 0;
            btn_pedidosMenuGerente.FlatAppearance.MouseOverBackColor = Color.FromArgb(137, 81, 41);
            btn_pedidosMenuGerente.FlatStyle = FlatStyle.Flat;
            btn_pedidosMenuGerente.Font = new Font("Microsoft Sans Serif", 11.25F);
            btn_pedidosMenuGerente.ForeColor = Color.White;
            btn_pedidosMenuGerente.Image = (Image)resources.GetObject("btn_pedidosMenuGerente.Image");
            btn_pedidosMenuGerente.Location = new Point(12, 406);
            btn_pedidosMenuGerente.Name = "btn_pedidosMenuGerente";
            btn_pedidosMenuGerente.Size = new Size(94, 68);
            btn_pedidosMenuGerente.TabIndex = 9;
            btn_pedidosMenuGerente.Text = "Pedidos";
            btn_pedidosMenuGerente.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_pedidosMenuGerente.UseVisualStyleBackColor = false;
            // 
            // FrmGerentePrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1424, 891);
            Controls.Add(pictureBox2);
            Controls.Add(panel_MenuEstoque);
            Name = "FrmGerentePrincipal";
            Text = "FrmGerentePrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_MenuEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Panel panel_MenuEstoque;
        private Button btn_DespesasMenuGerente;
        private Button btn_FuncionariosMenuGerente;
        private Button btn_EstoqueMenuGerente;
        private Button btn_VendasMenuGerente;
        private PictureBox pictureBox1;
        private Button btn_pedidosMenuGerente;
        private Button btn_ClienteMenuGerente;
    }
}
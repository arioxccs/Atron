namespace Atron
{
    partial class FrmEntradaEstoqueGerente
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
            txt_CodProduto = new TextBox();
            lbl_CodProduto = new Label();
            lbl_EntradaEstoque = new Label();
            txt_Img = new TextBox();
            lbl_Img = new Label();
            txt_CodFornecedor = new TextBox();
            lbl_CodFornecedor = new Label();
            txt_Produto = new TextBox();
            lbl_Produto = new Label();
            txt_Marca = new TextBox();
            lbl_Marca = new Label();
            txt_Qtde = new TextBox();
            lbl_Qtde = new Label();
            txt_Motivo = new TextBox();
            lbl_Motivo = new Label();
            txt_Obs = new TextBox();
            lbl_Obs = new Label();
            txt_Fornecedor = new TextBox();
            lbl_Fornecedor = new Label();
            btn_Salvar = new Button();
            SuspendLayout();
            // 
            // txt_CodProduto
            // 
            txt_CodProduto.BackColor = Color.FromArgb(247, 193, 143);
            txt_CodProduto.BorderStyle = BorderStyle.None;
            txt_CodProduto.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CodProduto.Location = new Point(153, 209);
            txt_CodProduto.Name = "txt_CodProduto";
            txt_CodProduto.Size = new Size(492, 40);
            txt_CodProduto.TabIndex = 18;
            // 
            // lbl_CodProduto
            // 
            lbl_CodProduto.AutoSize = true;
            lbl_CodProduto.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodProduto.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_CodProduto.Location = new Point(153, 163);
            lbl_CodProduto.Name = "lbl_CodProduto";
            lbl_CodProduto.Size = new Size(216, 43);
            lbl_CodProduto.TabIndex = 17;
            lbl_CodProduto.Text = "Código do Produto";
            // 
            // lbl_EntradaEstoque
            // 
            lbl_EntradaEstoque.AutoSize = true;
            lbl_EntradaEstoque.BackColor = Color.White;
            lbl_EntradaEstoque.Font = new Font("ST-Komsomol", 57.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_EntradaEstoque.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_EntradaEstoque.Location = new Point(321, -22);
            lbl_EntradaEstoque.Name = "lbl_EntradaEstoque";
            lbl_EntradaEstoque.Size = new Size(608, 124);
            lbl_EntradaEstoque.TabIndex = 16;
            lbl_EntradaEstoque.Text = "Entrada de Estoque";
            // 
            // txt_Img
            // 
            txt_Img.BackColor = Color.FromArgb(247, 193, 143);
            txt_Img.BorderStyle = BorderStyle.None;
            txt_Img.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Img.Location = new Point(668, 209);
            txt_Img.Name = "txt_Img";
            txt_Img.Size = new Size(492, 40);
            txt_Img.TabIndex = 20;
            // 
            // lbl_Img
            // 
            lbl_Img.AutoSize = true;
            lbl_Img.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Img.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_Img.Location = new Point(668, 163);
            lbl_Img.Name = "lbl_Img";
            lbl_Img.Size = new Size(99, 43);
            lbl_Img.TabIndex = 19;
            lbl_Img.Text = "Imagem";
            // 
            // txt_CodFornecedor
            // 
            txt_CodFornecedor.BackColor = Color.FromArgb(247, 193, 143);
            txt_CodFornecedor.BorderStyle = BorderStyle.None;
            txt_CodFornecedor.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_CodFornecedor.Location = new Point(668, 320);
            txt_CodFornecedor.Name = "txt_CodFornecedor";
            txt_CodFornecedor.Size = new Size(240, 40);
            txt_CodFornecedor.TabIndex = 24;
            // 
            // lbl_CodFornecedor
            // 
            lbl_CodFornecedor.AutoSize = true;
            lbl_CodFornecedor.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CodFornecedor.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_CodFornecedor.Location = new Point(668, 274);
            lbl_CodFornecedor.Name = "lbl_CodFornecedor";
            lbl_CodFornecedor.Size = new Size(222, 43);
            lbl_CodFornecedor.TabIndex = 23;
            lbl_CodFornecedor.Text = "Código Fornecedor";
            lbl_CodFornecedor.Click += label2_Click;
            // 
            // txt_Produto
            // 
            txt_Produto.BackColor = Color.FromArgb(247, 193, 143);
            txt_Produto.BorderStyle = BorderStyle.None;
            txt_Produto.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Produto.Location = new Point(153, 320);
            txt_Produto.Name = "txt_Produto";
            txt_Produto.Size = new Size(492, 40);
            txt_Produto.TabIndex = 22;
            // 
            // lbl_Produto
            // 
            lbl_Produto.AutoSize = true;
            lbl_Produto.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Produto.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_Produto.Location = new Point(153, 274);
            lbl_Produto.Name = "lbl_Produto";
            lbl_Produto.Size = new Size(224, 43);
            lbl_Produto.TabIndex = 21;
            lbl_Produto.Text = "Produto Solicitado";
            // 
            // txt_Marca
            // 
            txt_Marca.BackColor = Color.FromArgb(247, 193, 143);
            txt_Marca.BorderStyle = BorderStyle.None;
            txt_Marca.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Marca.Location = new Point(668, 440);
            txt_Marca.Name = "txt_Marca";
            txt_Marca.Size = new Size(492, 40);
            txt_Marca.TabIndex = 28;
            // 
            // lbl_Marca
            // 
            lbl_Marca.AutoSize = true;
            lbl_Marca.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Marca.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_Marca.Location = new Point(668, 394);
            lbl_Marca.Name = "lbl_Marca";
            lbl_Marca.Size = new Size(89, 43);
            lbl_Marca.TabIndex = 27;
            lbl_Marca.Text = "Marca";
            // 
            // txt_Qtde
            // 
            txt_Qtde.BackColor = Color.FromArgb(247, 193, 143);
            txt_Qtde.BorderStyle = BorderStyle.None;
            txt_Qtde.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Qtde.Location = new Point(153, 440);
            txt_Qtde.Name = "txt_Qtde";
            txt_Qtde.Size = new Size(492, 40);
            txt_Qtde.TabIndex = 26;
            // 
            // lbl_Qtde
            // 
            lbl_Qtde.AutoSize = true;
            lbl_Qtde.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Qtde.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_Qtde.Location = new Point(153, 394);
            lbl_Qtde.Name = "lbl_Qtde";
            lbl_Qtde.Size = new Size(247, 43);
            lbl_Qtde.TabIndex = 25;
            lbl_Qtde.Text = "Ajuste de Quantidade";
            // 
            // txt_Motivo
            // 
            txt_Motivo.BackColor = Color.FromArgb(247, 193, 143);
            txt_Motivo.BorderStyle = BorderStyle.None;
            txt_Motivo.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Motivo.Location = new Point(668, 554);
            txt_Motivo.Multiline = true;
            txt_Motivo.Name = "txt_Motivo";
            txt_Motivo.Size = new Size(492, 85);
            txt_Motivo.TabIndex = 32;
            // 
            // lbl_Motivo
            // 
            lbl_Motivo.AutoSize = true;
            lbl_Motivo.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Motivo.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_Motivo.Location = new Point(668, 508);
            lbl_Motivo.Name = "lbl_Motivo";
            lbl_Motivo.Size = new Size(262, 43);
            lbl_Motivo.TabIndex = 31;
            lbl_Motivo.Text = "Motivo para diferença";
            // 
            // txt_Obs
            // 
            txt_Obs.BackColor = Color.FromArgb(247, 193, 143);
            txt_Obs.BorderStyle = BorderStyle.None;
            txt_Obs.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Obs.Location = new Point(153, 554);
            txt_Obs.Multiline = true;
            txt_Obs.Name = "txt_Obs";
            txt_Obs.Size = new Size(492, 85);
            txt_Obs.TabIndex = 30;
            // 
            // lbl_Obs
            // 
            lbl_Obs.AutoSize = true;
            lbl_Obs.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Obs.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_Obs.Location = new Point(153, 508);
            lbl_Obs.Name = "lbl_Obs";
            lbl_Obs.Size = new Size(157, 43);
            lbl_Obs.TabIndex = 29;
            lbl_Obs.Text = "Observações";
            // 
            // txt_Fornecedor
            // 
            txt_Fornecedor.BackColor = Color.FromArgb(247, 193, 143);
            txt_Fornecedor.BorderStyle = BorderStyle.None;
            txt_Fornecedor.Font = new Font("Lato", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Fornecedor.Location = new Point(926, 320);
            txt_Fornecedor.Name = "txt_Fornecedor";
            txt_Fornecedor.Size = new Size(234, 40);
            txt_Fornecedor.TabIndex = 33;
            // 
            // lbl_Fornecedor
            // 
            lbl_Fornecedor.AutoSize = true;
            lbl_Fornecedor.Font = new Font("Bebas Neue", 24.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Fornecedor.ForeColor = Color.FromArgb(9, 28, 128);
            lbl_Fornecedor.Location = new Point(926, 274);
            lbl_Fornecedor.Name = "lbl_Fornecedor";
            lbl_Fornecedor.Size = new Size(146, 43);
            lbl_Fornecedor.TabIndex = 34;
            lbl_Fornecedor.Text = "Fornecedor";
            // 
            // btn_Salvar
            // 
            btn_Salvar.BackColor = Color.FromArgb(14, 41, 184);
            btn_Salvar.FlatStyle = FlatStyle.Flat;
            btn_Salvar.Font = new Font("Lato", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Salvar.ForeColor = Color.White;
            btn_Salvar.Location = new Point(1058, 714);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(216, 63);
            btn_Salvar.TabIndex = 59;
            btn_Salvar.Text = "Salvar";
            btn_Salvar.UseVisualStyleBackColor = false;
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // FrmEntradaEstoqueGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1312, 827);
            Controls.Add(btn_Salvar);
            Controls.Add(lbl_Fornecedor);
            Controls.Add(txt_Fornecedor);
            Controls.Add(txt_Motivo);
            Controls.Add(lbl_Motivo);
            Controls.Add(txt_Obs);
            Controls.Add(lbl_Obs);
            Controls.Add(txt_Marca);
            Controls.Add(lbl_Marca);
            Controls.Add(txt_Qtde);
            Controls.Add(lbl_Qtde);
            Controls.Add(txt_CodFornecedor);
            Controls.Add(lbl_CodFornecedor);
            Controls.Add(txt_Produto);
            Controls.Add(lbl_Produto);
            Controls.Add(txt_Img);
            Controls.Add(lbl_Img);
            Controls.Add(txt_CodProduto);
            Controls.Add(lbl_CodProduto);
            Controls.Add(lbl_EntradaEstoque);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEntradaEstoqueGerente";
            Text = "FrmEntradaEstoqueGerente";
            Load += FrmEntradaEstoqueGerente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_CodProduto;
        private Label lbl_CodProduto;
        private Label lbl_EntradaEstoque;
        private TextBox txt_Img;
        private Label lbl_Img;
        private TextBox txt_CodFornecedor;
        private Label lbl_CodFornecedor;
        private TextBox txt_Produto;
        private Label lbl_Produto;
        private TextBox txt_Marca;
        private Label lbl_Marca;
        private TextBox txt_Qtde;
        private Label lbl_Qtde;
        private TextBox txt_Motivo;
        private Label lbl_Motivo;
        private TextBox txt_Obs;
        private Label lbl_Obs;
        private TextBox txt_Fornecedor;
        private Label lbl_Fornecedor;
        private Button btn_Salvar;
    }
}
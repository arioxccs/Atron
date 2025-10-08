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
            lblGerenciamentoConsultas = new Label();
            btnConsultaProdutos = new Button();
            btnConsultaPedidos = new Button();
            SuspendLayout();
            // 
            // lblGerenciamentoConsultas
            // 
            lblGerenciamentoConsultas.AutoSize = true;
            lblGerenciamentoConsultas.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGerenciamentoConsultas.ForeColor = Color.FromArgb(255, 122, 0);
            lblGerenciamentoConsultas.Location = new Point(61, 75);
            lblGerenciamentoConsultas.Name = "lblGerenciamentoConsultas";
            lblGerenciamentoConsultas.Size = new Size(821, 54);
            lblGerenciamentoConsultas.TabIndex = 0;
            lblGerenciamentoConsultas.Text = "GERENCIAMENTO  DE CONSULTA";
            // 
            // btnConsultaProdutos
            // 
            btnConsultaProdutos.Image = (Image)resources.GetObject("btnConsultaProdutos.Image");
            btnConsultaProdutos.Location = new Point(61, 165);
            btnConsultaProdutos.Name = "btnConsultaProdutos";
            btnConsultaProdutos.Size = new Size(443, 399);
            btnConsultaProdutos.TabIndex = 1;
            btnConsultaProdutos.UseVisualStyleBackColor = true;
            // 
            // btnConsultaPedidos
            // 
            btnConsultaPedidos.Image = (Image)resources.GetObject("btnConsultaPedidos.Image");
            btnConsultaPedidos.Location = new Point(531, 165);
            btnConsultaPedidos.Name = "btnConsultaPedidos";
            btnConsultaPedidos.Size = new Size(460, 399);
            btnConsultaPedidos.TabIndex = 2;
            btnConsultaPedidos.UseVisualStyleBackColor = true;
            // 
            // frmGerenciamentoConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1481, 1051);
            Controls.Add(btnConsultaPedidos);
            Controls.Add(btnConsultaProdutos);
            Controls.Add(lblGerenciamentoConsultas);
            Name = "frmGerenciamentoConsultas";
            Text = "frmGerenciamentoConsultas";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGerenciamentoConsultas;
        private Button btnConsultaProdutos;
        private Button btnConsultaPedidos;
    }
}
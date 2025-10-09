namespace Atron
{
    partial class FrmGerenciamentodeHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerenciamentodeHistorico));
            label1 = new Label();
            btnHistoricoPedidos = new Button();
            btnHistoricoEntradaSaida = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 122, 0);
            label1.Location = new Point(74, 53);
            label1.Name = "label1";
            label1.Size = new Size(490, 42);
            label1.TabIndex = 0;
            label1.Text = "GERENCIAMENTO DE HISTÓRICO";
            // 
            // btnHistoricoPedidos
            // 
            btnHistoricoPedidos.Image = (Image)resources.GetObject("btnHistoricoPedidos.Image");
            btnHistoricoPedidos.Location = new Point(74, 117);
            btnHistoricoPedidos.Name = "btnHistoricoPedidos";
            btnHistoricoPedidos.Size = new Size(455, 406);
            btnHistoricoPedidos.TabIndex = 1;
            btnHistoricoPedidos.UseVisualStyleBackColor = true;
            // 
            // btnHistoricoEntradaSaida
            // 
            btnHistoricoEntradaSaida.Image = (Image)resources.GetObject("btnHistoricoEntradaSaida.Image");
            btnHistoricoEntradaSaida.Location = new Point(556, 117);
            btnHistoricoEntradaSaida.Name = "btnHistoricoEntradaSaida";
            btnHistoricoEntradaSaida.Size = new Size(455, 406);
            btnHistoricoEntradaSaida.TabIndex = 2;
            btnHistoricoEntradaSaida.UseVisualStyleBackColor = true;
            // 
            // FrmGerenciamentodeHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 881);
            Controls.Add(btnHistoricoEntradaSaida);
            Controls.Add(btnHistoricoPedidos);
            Controls.Add(label1);
            Name = "FrmGerenciamentodeHistorico";
            Text = "FrmGerenciamentodeHistorico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnHistoricoPedidos;
        private Button btnHistoricoEntradaSaida;
    }
}
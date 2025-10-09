namespace Atron
{
    partial class FrmHistoricodePedidos
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
            lblHistoricoPedido = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblData = new Label();
            lblIDPedido = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblHistoricoPedido
            // 
            lblHistoricoPedido.AutoSize = true;
            lblHistoricoPedido.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHistoricoPedido.ForeColor = Color.FromArgb(255, 122, 0);
            lblHistoricoPedido.Location = new Point(308, 45);
            lblHistoricoPedido.Name = "lblHistoricoPedido";
            lblHistoricoPedido.Size = new Size(397, 36);
            lblHistoricoPedido.TabIndex = 0;
            lblHistoricoPedido.Text = "HISTÓRICO DE PEDIDOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 247, 255);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(90, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 579);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(49, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(912, 504);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(119, 162, 255);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lblIDPedido);
            panel3.Controls.Add(lblData);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(911, 64);
            panel3.TabIndex = 0;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.White;
            lblData.Location = new Point(39, 15);
            lblData.Name = "lblData";
            lblData.Size = new Size(63, 30);
            lblData.TabIndex = 0;
            lblData.Text = "DATA";
            // 
            // lblIDPedido
            // 
            lblIDPedido.AutoSize = true;
            lblIDPedido.Font = new Font("Segoe UI", 15.75F);
            lblIDPedido.ForeColor = Color.White;
            lblIDPedido.Location = new Point(168, 17);
            lblIDPedido.Name = "lblIDPedido";
            lblIDPedido.Size = new Size(129, 30);
            lblIDPedido.TabIndex = 1;
            lblIDPedido.Text = "ID - PEDIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(356, 17);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 2;
            label1.Text = "FORNECEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(565, 15);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 3;
            label2.Text = "STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(711, 17);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 4;
            label3.Text = "TOTAL (R$)";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(14, 41, 184);
            panel4.Location = new Point(136, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(0, 0);
            panel4.TabIndex = 2;
            // 
            // FrmHistoricodePedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 881);
            Controls.Add(panel1);
            Controls.Add(lblHistoricoPedido);
            Name = "FrmHistoricodePedidos";
            Text = "FrmHistoricodePedidos";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHistoricoPedido;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblIDPedido;
        private Label lblData;
        private Panel panel4;
    }
}
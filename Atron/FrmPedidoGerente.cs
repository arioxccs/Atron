using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atron
{
    public partial class FrmPedidoGerente : Form
    {
        public FrmPedidoGerente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_PedidoReativacao_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Pedido_Click(object sender, EventArgs e)
        {
            new FrmPedidosRecentesGerente().ShowDialog();
        }

        private void btn_PedidoCancelado_Click(object sender, EventArgs e)
        {
           
        }
    }
}

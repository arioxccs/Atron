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
    public partial class FrmGerenciamentodePedidos : Form
    {
        public FrmGerenciamentodePedidos()
        {
            InitializeComponent();
        }

        private void FrmGerenciamentodePedidos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidosAtuais_Click(object sender, EventArgs e)
        {
            FrmPedidosAtuais1 FrmPedidosAtuais1 = new FrmPedidosAtuais1();
            FrmPedidosAtuais1.Show();
        }

        private void btnPedidosemFalta_Click(object sender, EventArgs e)
        {
            FrmPedidosEmFalta1 FrmPedidosEmFalta1 = new FrmPedidosEmFalta1();
            FrmPedidosEmFalta1.Show();
        }

        private void btnDadosSolicitacoes_Click(object sender, EventArgs e)
        {
            FrmDadosdaSolicitacoesdePedidos FrmDadosdaSolicitacoesdePedidos = new FrmDadosdaSolicitacoesdePedidos();
            FrmDadosdaSolicitacoesdePedidos.Show();
        }

        private void btnPedidosCancelados_Click(object sender, EventArgs e)
        {
            FrmPedidosCancelados1 FrmPedidosCancelados1 = new FrmPedidosCancelados1();
            FrmPedidosCancelados1.Show();
        }

        private void btnBolaVolei_Click(object sender, EventArgs e)
        {
            FrmPedidosAtuais2 FrmPedidosAtuais2 = new FrmPedidosAtuais2();
            FrmPedidosAtuais2.Show();
        }
    }
}

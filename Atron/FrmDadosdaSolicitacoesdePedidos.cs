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
    public partial class FrmDadosdaSolicitacoesdePedidos : Form
    {
        public FrmDadosdaSolicitacoesdePedidos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmDadosdaSolicitacoesdePedidos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblMeia_Click(object sender, EventArgs e)
        {

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            FrmDadosdaSolicitacaodePedidos2 FrmDadosdaSolicitacaodePedidos2 = new FrmDadosdaSolicitacaodePedidos2();
            FrmDadosdaSolicitacaodePedidos2.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

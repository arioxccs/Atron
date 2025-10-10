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
    public partial class frmBuscaProduto : Form
    {
        public frmBuscaProduto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmBuscaProduto2 frmBuscaProduto2 = new frmBuscaProduto2();
            frmBuscaProduto2.ShowDialog();
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {

            frmMenuFecharCaixa frmMenuFecharCaixa = new frmMenuFecharCaixa();
            frmMenuFecharCaixa.ShowDialog();
        }
    }
}

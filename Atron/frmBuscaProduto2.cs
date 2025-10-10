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
    public partial class frmBuscaProduto2 : Form
    {
        public frmBuscaProduto2()
        {
            InitializeComponent();
        }

        private void pnlFundo_Paint(object sender, PaintEventArgs e)
        {
            frmPopUpDetalhesProduto frmPopUpDetalhesProduto = new frmPopUpDetalhesProduto();
            frmPopUpDetalhesProduto.Show();
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmBuscaProduto frmBuscaProduto = new frmBuscaProduto();
            frmBuscaProduto.ShowDialog();
        }
    }
}

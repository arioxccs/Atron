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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            frmMenuFecharCaixa frmMenuFecharCaixa = new frmMenuFecharCaixa();
            frmMenuFecharCaixa.ShowDialog();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmMenuFecharCaixa frmMenuFecharCaixa = new frmMenuFecharCaixa();
            frmMenuFecharCaixa.ShowDialog();
        }
    }
}

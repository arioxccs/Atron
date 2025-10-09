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
    public partial class frmCarrinho : Form
    {
        public frmCarrinho()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblDescontos_Click(object sender, EventArgs e)
        {

        }

        private void picButtonMaisProdutos_Click(object sender, EventArgs e)
        {
            FrmCadastro2Vendas frmCadastro2Vendas = new FrmCadastro2Vendas();
            frmCadastro2Vendas.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPopUpConfirmarCancelamento frmPopUpConfirmarCancelamento = new frmPopUpConfirmarCancelamento();
            frmPopUpConfirmarCancelamento.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmMenuFecharCaixa frmMenuFecharCaixa = new frmMenuFecharCaixa();
            frmMenuFecharCaixa.ShowDialog();
        }
    }
}

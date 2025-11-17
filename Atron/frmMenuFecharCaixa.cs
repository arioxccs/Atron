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
    public partial class frmMenuFecharCaixa : Form
    {
        public frmMenuFecharCaixa()
        {
            InitializeComponent();
        }

        private void FrmMenuFecharCaixa_Load(object sender, EventArgs e)
        {

        }

        private void FrmMenuFecharCaixa_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente frmCadastroCliente = new frmCadastroCliente();
            frmCadastroCliente.ShowDialog();
        }

        private void btnBuscaEstoque_Click(object sender, EventArgs e)
        {
            frmBuscaProduto frmBuscaProduto = new frmBuscaProduto();
            frmBuscaProduto.ShowDialog();
        }

        private void pctAbrirCaixa_Click(object sender, EventArgs e)
        {
            frmPopUpSenhaFecharCaixa frmPopUpSenhaFecharCaixa = new frmPopUpSenhaFecharCaixa();
            frmPopUpSenhaFecharCaixa.Show();
        }

        private void lblTituloHistorico_Click(object sender, EventArgs e)
        {

        }

        private void lblHorario5_Click(object sender, EventArgs e)
        {

        }
    }
}

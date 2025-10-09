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

        private void frmMenuFecharCaixa_Load(object sender, EventArgs e)
        {

        }

        private void frmMenuFecharCaixa_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVenda_Click(object sender, EventArgs e)
        {
            FrmCadastrodeVenda frmCadastrodeVenda = new FrmCadastrodeVenda();
            frmCadastrodeVenda.ShowDialog();
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            frmCadastroEncomendas frmCadastroEncomendas = new frmCadastroEncomendas();
            frmCadastroEncomendas.ShowDialog();
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
    }
}

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
    public partial class FrmCadastrodeVenda : Form
    {
        public FrmCadastrodeVenda()
        {
            InitializeComponent();
        }

        private void FrmCadastrodeVenda_Load(object sender, EventArgs e)
        {

        }

        private void llbAdicionarVenda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro2Vendas frmCadastro2Vendas = new FrmCadastro2Vendas();
            frmCadastro2Vendas.ShowDialog();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmCarrinho frmCarrinho = new frmCarrinho();
            frmCarrinho.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPopUpConfirmarCancelamento frmPopUpConfirmarCancelamento = new frmPopUpConfirmarCancelamento();
            frmPopUpConfirmarCancelamento.Show();
        }
    }
}

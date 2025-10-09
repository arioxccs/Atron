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
    public partial class frmCadastroEncomendas : Form
    {
        public frmCadastroEncomendas()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroEncomendas_Load(object sender, EventArgs e)
        {

        }

        private void llbAdicionarVenda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastro2Encomendas frmCadastro2Encomendas = new frmCadastro2Encomendas();
            frmCadastro2Encomendas.ShowDialog();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            frmCarrinho frmCarrinho = new frmCarrinho();
            frmCarrinho.ShowDialog();
        }
    }
}

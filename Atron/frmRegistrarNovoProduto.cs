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
    public partial class frmRegistrarNovoProduto : Form
    {
        public frmRegistrarNovoProduto()
        {
            InitializeComponent();
        }

        private void mktdata_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCodProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistraProduto_Click(object sender, EventArgs e)
        {
            FrmGerenciamentoRegistros TelaAberta = new FrmGerenciamentoRegistros();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }

        private void frmRegistrarNovoProduto_Load(object sender, EventArgs e)
        {

        }
    }
}

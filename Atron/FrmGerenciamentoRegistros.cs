using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Atron
{
    public partial class FrmGerenciamentoRegistros : Form
    {
        public FrmGerenciamentoRegistros()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegistrarNovoProduto TelaAberta = new frmRegistrarNovoProduto();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FrmGerenciamentoRegistros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmRegistrarNovoPedido TelaAberta = new frmRegistrarNovoPedido();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmRegistrarNovoPedido frmRegistrarNovoPedido = new frmRegistrarNovoPedido();
            frmRegistrarNovoPedido.Show();
        }

        private void btnEntradaEstoque_Click(object sender, EventArgs e)
        {
            frmRegistrarEntradaNoEstoque TelaAberta = new frmRegistrarEntradaNoEstoque();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();

        }
    }
}

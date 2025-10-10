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
    public partial class frmRegistrarEntradaNoEstoque : Form
    {
        public frmRegistrarEntradaNoEstoque()
        {
            InitializeComponent();
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarEntradaNoEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEntradaNoEstoque_Click(object sender, EventArgs e)
        {
            FrmGerenciamentoRegistros TelaAberta = new FrmGerenciamentoRegistros();
            FrmEstoquePrincipal frmPrincipal = (FrmEstoquePrincipal)this.ParentForm;
            frmPrincipal.Controls["panelEstoque"].Controls.Clear();
            TelaAberta.TopLevel = false;
            frmPrincipal.Controls["panelEstoque"].Controls.Add(TelaAberta);
            TelaAberta.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblRegistrarNovoPedido_Click(object sender, EventArgs e)
        {

        }

        private void lblImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
